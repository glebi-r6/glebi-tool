using System;
using System.Threading;
using System.Runtime.InteropServices;

namespace Recoil
{
    public static class MouseListener
    {
        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vkey);

        public static void Listen()
        {
            while (true)
            {
                while (Program.g_enabled)
                {
                    while ( Convert.ToBoolean( GetAsyncKeyState(0x02) ) )
                    {
                        if ( Convert.ToBoolean( GetAsyncKeyState(0x01) ) )
                        {
                            Weapon current = Data.WeaponColletion[(int)Program.g_weapon_index];
                            for (int i = 0; i < current.pixels.Count; i++)
                            {
                                if ( !Convert.ToBoolean( GetAsyncKeyState(0x01) ) )
                                    break;

                                Mouse.LerpMove(current.pixels[i], current.anims[i], current.GetDelay());
                            }
                        }
                    }
                    Thread.Sleep(10);
                }
                Thread.Sleep(100);
            }
        }
    }
}
