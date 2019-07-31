using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSonToCSV
{
  public partial class frmAbout : Form
  {
    public frmAbout()
    {
      InitializeComponent();
      lblApplicationName.Text = $"{Application.ProductName} - {Application.ProductVersion}";
    }

    private void lblEmailValue_Click(object sender, EventArgs e)
    {
      Process.Start("mailto:" + lblEmailValue.Text);
    }

    private void lblWebsiteValue_Click(object sender, EventArgs e)
    {
      Process.Start(lblWebsiteValue.Text);
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
