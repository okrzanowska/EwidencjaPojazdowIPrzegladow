using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EwidencjaPojazdow
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SqlServerTypesLoader.LoadNativeAssemblies();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
