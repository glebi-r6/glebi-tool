using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace Recoil
{
    public static class Mouse
    {
        [DllImport("user32.dll")]
        static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        private static void Move(Vector2 pos)
        {
            mouse_event(0x0001, (int)pos.X, (int)pos.Y, 0, 0);
        }

        public static void LerpMove(Vector2 target, float animation, float delay)
        {
            Timer.Start();

            Vector2 sign = new Vector2(
                target.X < 0 ? -1.0F : 1.0F,
                target.Y < 0 ? -1.0F : 1.0F
            );

            target = new Vector2(Math.Abs(target.X), Math.Abs(target.Y));

            Vector2 total_moved = new Vector2(0.0F, 0.0F);

            while (Timer.Elapsed() < (double)animation)
            {
                Timer.Sleep(1);
                float t = (float)Timer.Elapsed() / animation;

                Vector2 to_move = (target.Lerp(t) - total_moved).Floor();

                if (to_move.X != 0.0F || to_move.Y != 0.0F)
                {
                    Move(to_move *  sign);
                    total_moved += to_move;
                }
            }
            Move(new Vector2(target.X - total_moved.X, target.Y - total_moved.Y));

            if (delay - animation > 0)
                Timer.Sleep((int)(delay - animation));
        }
    }
}
