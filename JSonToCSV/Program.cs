using System;
using System.Windows.Forms;
using System.Threading;
using ExceptionReporting;

namespace JSonToCSV
{
  class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      ExceptionReporter er = new ExceptionReporter();
      er.Config.ShowButtonIcons = true;
      er.Show(e.Exception);
    }

    public static void ShowError(Exception ex)
    {
      //TODO: add a better error manager
      //MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      ExceptionReporter er = new ExceptionReporter();
      Exception[] exceptions = new Exception[] { ex };
      er.Show(exceptions);
    }
  }
}
