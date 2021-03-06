using glebi_tool_2te_design;
using Recoil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using NoRecoil;

namespace glebi_tool_2te_design_test
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        /// 

        public static bool g_enabled = false;
        public static bool g_humanization = false;

        public static float g_sensitivity = 0.42F;
        public static float g_field_of_view = 90.0F;

        public static WeaponIndex g_weapon_index;

        public static Barrel g_barrel = Barrel.None;
        public static Sight g_sight = Sight.None;

        [STAThread]
        static void Main()
        {
            Recoil.Timer.QueryFrequency();

            g_weapon_index = WeaponIndex.AR;

            Thread mouse_thread = new Thread(MouseListener.Listen);
            mouse_thread.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMainMenu());
        }
    }
}

