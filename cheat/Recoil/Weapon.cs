using System.Collections.Generic;
using System.Numerics;

namespace Recoil
{
    public class Attachment
    {
        public Attachment(string n, float p_mod, float a_mod, float d_mod)
        {
            name = n;
            pixel_modifier = p_mod;
            anim_modifier = a_mod;
            delay_modifier = d_mod;
        }

        public string name { get; }
        public float pixel_modifier { get; }
        public float anim_modifier { get; }
        public float delay_modifier { get; }
    }

    public class Weapon
    {
        public string name { get; }

        private float _delay;
        private List<Vector2> _view_angles;

        public float delay { get; private set; }
        public List<Vector2> pixels { get; }
        public List<float> anims { get; }

        public Weapon(string n, float d, List<Vector2> va)
        {
            name = n;
            _delay = d;
            _view_angles = va;

            pixels = new List<Vector2>();
            anims = new List<float>();

            Update();
        }

        public void Update()
        {
            if (pixels.Count > 0 || anims.Count > 0)
            {
                pixels.Clear();
                anims.Clear();
            }

            Vector2 previous_shot = new Vector2(0.0F,0.0F);
            Vector2 current_shot = new Vector2(0.0F, 0.0F);

            float multiplier = -0.03F * (Program.g_sensitivity * 3.0F) * (Program.g_field_of_view / 100.0F);

            ApplyDelayModifier();

            for (int i = 0; i < _view_angles.Count; i++)
            {
                current_shot = _view_angles[i];

                Vector2 delta = current_shot - previous_shot;

                pixels.Add( ApplyPixelModifier(delta / multiplier) );
                anims.Add( ApplyAnimModifier(delta.Length() / 0.02F) );

                previous_shot = current_shot;
            }
        }

        public float GetDelay()
        {
            return delay;
        }

        private Vector2 ApplyPixelModifier(Vector2 pixels)
        {
            if (Program.g_barrel == Barrel.None && Program.g_sight == Sight.None)
                return pixels;

            if (Program.g_barrel != Barrel.None)
            {
                pixels *= Data.BarrelCollection[(int)Program.g_barrel].pixel_modifier;
            }

            if (Program.g_sight != Sight.None)
            {
                pixels *= Data.SightCollection[(int)Program.g_sight].pixel_modifier;
            }

            return pixels;
        }

        private float ApplyAnimModifier(float animation)
        {
            if (Program.g_barrel == Barrel.None && Program.g_sight == Sight.None)
                return animation;

            if (Program.g_barrel != Barrel.None)
            {
                animation *= Data.BarrelCollection[(int)Program.g_barrel].anim_modifier;
            }

            if (Program.g_sight != Sight.None)
            {
                animation *= Data.SightCollection[(int)Program.g_sight].anim_modifier;
            }

            return animation;
        }

        private void ApplyDelayModifier()
        {
            if (Program.g_barrel == Barrel.MuzzleBoost)
                delay *= Data.BarrelCollection[(int)Barrel.MuzzleBoost].delay_modifier;
            else
                delay = _delay;
        }

    }
}
