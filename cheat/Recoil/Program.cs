using System;
using System.Threading;
using System.Windows.Forms;

namespace Recoil
{
    static class Program
    {
        public static bool g_enabled = false;
        public static bool g_humanization = false;

        public static float g_sensitivity = 0.42F;
        public static float g_field_of_view = 90.0F;

        public static WeaponIndex g_weapon_index;

        public static Barrel g_barrel = Barrel.None;
        public static Sight g_sight = Sight.None;
    }
}
