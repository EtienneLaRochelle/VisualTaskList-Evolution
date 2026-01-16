using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* * ======================================================================================
 * LEGACY CODE WARNING (Version 1.0)
 * ======================================================================================
 * This code represents the initial state of the project before refactoring.
 * It contains:
 * - Direct SQL dependencies (no Repository pattern)
 * - Tightly coupled UI logic (no MVP pattern)
 * - Mixed naming conventions
 * * Please refer to the "VisualTaskList" (Version 2.0) folder for the clean, 
 * refactored architecture.
 * ======================================================================================
 */

namespace VisualOrganisationTool
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new VisualOrganisationToolInterface());
        }
    }
}
