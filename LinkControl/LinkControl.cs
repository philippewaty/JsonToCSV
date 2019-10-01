using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace LinkControl
{
  public partial class LinkControl : LinkLabel
  {
    public LinkControl()
    {
      InitializeComponent();
    }

    private void LinkControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (string.IsNullOrEmpty(this.Text)) return;
      if (e.Button == MouseButtons.Left)
      {
        if (this.Text.ToLower().StartsWith("http"))
        {
          Process.Start(this.Text);
          return;
        }
        if (this.Text.Contains("@"))
        {
          if (this.Text.ToLower().StartsWith("mailto"))
          {
            Process.Start(this.Text);
            return;
          } else
          {
            Process.Start($"mailto:{this.Text}");
            return;
          }
        }
        // Something other
        Process.Start(this.Text);
      }
    }

    private void mnuCopy_Click(object sender, EventArgs e)
    {
      if (!String.IsNullOrEmpty(this.Text))
      {
        try
        {
          Clipboard.Clear();
          Clipboard.SetText(this.Text);
        }
        catch (Exception ex)
        {
        }
      }
    }
  }
}
