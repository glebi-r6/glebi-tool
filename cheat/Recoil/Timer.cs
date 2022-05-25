using System.Runtime.InteropServices;

namespace Recoil
{
    public static class Timer
    {
        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceCounter(out long lpPerformanceCount);

        [DllImport("Kernel32.dll")]
        private static extern bool QueryPerformanceFrequency(out long lpFrequency);

        private static long start, frequency;

        public static void QueryFrequency()
        {
            QueryPerformanceFrequency(out frequency);
        }

        public static void Start()
        {
            QueryPerformanceCounter(out start);
        }

        public static double Elapsed()
        {
            long current_time = 0;

            QueryPerformanceCounter(out current_time);

            return (double)(current_time - start) * 1000 / (double)frequency;
        }

        public static void Sleep(int ms)
        {
            long s = 0;
            QueryPerformanceCounter(out s);

            long c = 0;
            QueryPerformanceCounter(out c);

            while ((double)((c - s) * 1000 / frequency) < ms)
            {
                QueryPerformanceCounter(out c);
            }
        }
    }
}
