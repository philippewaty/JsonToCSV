namespace LinkControl
{
  partial class LinkControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCopy});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
      // 
      // mnuCopy
      // 
      this.mnuCopy.Name = "mnuCopy";
      this.mnuCopy.Size = new System.Drawing.Size(102, 22);
      this.mnuCopy.Text = "Copy";
      this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
      // 
      // LinkControl
      // 
      this.ContextMenuStrip = this.contextMenuStrip1;
      this.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkControl_LinkClicked);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem mnuCopy;
  }
}
