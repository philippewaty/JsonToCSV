using System;
using System.Windows.Forms;
using System.Threading;

namespace JSonToCSV
{
    class Program
    {
        const string EMAIL = "jsontocsv@piweesoft.slmail.me";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            pwErrorBox.ErrorReport.Bind(EMAIL);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void ShowError(Exception ex, string source)
        {
            pwErrorBox.ErrorReport errorReport = new pwErrorBox.ErrorReport();
            errorReport.Source = source;
            errorReport.DisplayReport(ex, errorReport);
        }
    }
}
