using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Serilog;

namespace TransferLogger.Interop
{
    // https://stackoverflow.com/questions/158706/how-do-i-properly-clean-up-excel-interop-objects
    // nightcoder
    public static class WindowsNative
    {
        [DllImport("user32.dll")]
        private static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(int hWnd);

        public static bool TryKillProcess(int hWnd)
        {
            GetWindowThreadProcessId((IntPtr)hWnd, out uint processId);

            if (processId == 0)
                return false;

            try
            {
                Process.GetProcessById((int)processId)?.Kill();

                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "failed");

                return false;
            }
        }
    }
}
