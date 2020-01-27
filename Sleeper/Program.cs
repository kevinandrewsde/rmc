using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sleeper
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
        }
    }

    public static class ApplicationStateHelper
    {
        public static void Sleep()
        {
            Application.SetSuspendState(PowerState.Suspend, true, false);
        }
    }
}
