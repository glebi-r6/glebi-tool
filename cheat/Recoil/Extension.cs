using System;
using System.Numerics;

namespace Recoil
{
    public static class Extension
    {
        public static Vector2 Lerp(this Vector2 v, float t)
        {
            // We should honestly be clamping our lerp value
            return new Vector2(
                v.X * t,
                v.Y * t
            );
        }

        public static Vector2 Abs(this Vector2 v)
        {
            return new Vector2(
                Math.Abs(v.X),
                Math.Abs(v.Y)
            );
        }

        public static Vector2 Floor(this Vector2 v)
        {
            return new Vector2(
                (float)Math.Floor(v.X),
                (float)Math.Floor(v.Y)
            );
        }
    }
}
