using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace LMB_Fix.GlobalHooks
{
    class NativeSupport
    {
        [DllImport("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

        public static void BlockInput(TimeSpan delay)
        {
            try
            {
                BlockInput(true);
                Thread.Sleep(delay);
            }
            finally
            {
                BlockInput(false);
            }
        }
    }
}
