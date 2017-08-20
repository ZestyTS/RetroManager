using System;
using System.Reflection;
using System.Windows.Forms;

namespace RetroManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, arg) => arg.Name.StartsWith("SharpCompress") ? Assembly.Load(Properties.Resources.SharpCompress) : null;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenuForm());
        }
    }
}
