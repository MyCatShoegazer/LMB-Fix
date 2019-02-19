using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace LMB_Fix.GlobalHooks
{
    /// <summary>
    ///     A class providing some static methods marshaled from user32.dll.
    /// </summary>
    class NativeSupport
    {
        [DllImport("user32.dll", EntryPoint = "BlockInput")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool BlockInput([MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

        /// <summary>
        ///     Low level method for blocking all user input globaly in system.
        /// </summary>
        /// <param name="delay">A <see cref="TimeSpan"/> delay for returning input.</param>
        public static void BlockInput(TimeSpan delay)
        {
            /*
             *  We will run this code in try block
             *  because of its possible errors.
             */
            try
            {
                /*
                 *  Blocking global user input in system
                 *  for delay time.
                 */
                BlockInput(true);
                Thread.Sleep(delay);
            }
            finally
            {
                /*
                 *  Releasing user input after timer.
                 */
                BlockInput(false);
            }
        }
    }
}
