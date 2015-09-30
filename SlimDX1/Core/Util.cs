using System;

namespace Core
{
    public static class Util
    {
        public static int LowWord(this int i)
        {
            return i & 0xFFFF;
        }

        public static int HighWord(this int i)
        {
            return (i >> 16) & 0xFFFF;
        }

        public static void ReleaseCom<T>(ref T x) where T : class, IDisposable
        {
            if (x != null)
            {
                x.Dispose();
                x = null;
            }
        }
    }
}