namespace JSonToCSV
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.label1 = new System.Windows.Forms.Label();
      this.lstFiles = new System.Windows.Forms.ListBox();
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnQuit = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnConvert = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.chkSameFolder = new System.Windows.Forms.CheckBox();
      this.txtOutputFolder = new System.Windows.Forms.TextBox();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(52, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Input files";
      // 
      // lstFiles
      // 
      this.lstFiles.AllowDrop = true;
      this.lstFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstFiles.FormattingEnabled = true;
      this.lstFiles.Location = new System.Drawing.Point(12, 25);
      this.lstFiles.Name = "lstFiles";
      this.lstFiles.Size = new System.Drawing.Size(544, 134);
      this.lstFiles.TabIndex = 1;
      this.lstFiles.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragDrop);
      this.lstFiles.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstFiles_DragEnter);
      this.lstFiles.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lstFiles_KeyUp);
      // 
      // btnBrowse
      // 
      this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnBrowse.Enabled = false;
      this.btnBrowse.Location = new System.Drawing.Point(368, 188);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(26, 23);
      this.btnBrowse.TabIndex = 7;
      this.btnBrowse.Text = "...";
      this.toolTip1.SetToolTip(this.btnBrowse, "Choose output folder");
      this.btnBrowse.UseVisualStyleBackColor = true;
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnQuit.Image = global::JSonToCSV.Properties.Resources.system_exit;
      this.btnQuit.Location = new System.Drawing.Point(562, 214);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(40, 40);
      this.btnQuit.TabIndex = 11;
      this.toolTip1.SetToolTip(this.btnQuit, "Exit");
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbout.Image = global::JSonToCSV.Properties.Resources.help_about_3;
      this.btnAbout.Location = new System.Drawing.Point(516, 214);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(40, 40);
      this.btnAbout.TabIndex = 10;
      this.toolTip1.SetToolTip(this.btnAbout, "About JSonToCSV");
      this.btnAbout.UseVisualStyleBackColor = true;
      this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRemove.Image = global::JSonToCSV.Properties.Resources.list_remove;
      this.btnRemove.Location = new System.Drawing.Point(562, 71);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(40, 40);
      this.btnRemove.TabIndex = 3;
      this.toolTip1.SetToolTip(this.btnRemove, "Remove selected file");
      this.btnRemove.UseVisualStyleBackColor = true;
      this.btnRemove.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.Image = global::JSonToCSV.Properties.Resources.list_add;
      this.btnAdd.Location = new System.Drawing.Point(562, 25);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(40, 40);
      this.btnAdd.TabIndex = 2;
      this.toolTip1.SetToolTip(this.btnAdd, "Add file(s)");
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnConvert
      // 
      this.btnConvert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnConvert.Image = global::JSonToCSV.Properties.Resources.text_csv;
      this.btnConvert.Location = new System.Drawing.Point(12, 214);
      this.btnConvert.Name = "btnConvert";
      this.btnConvert.Size = new System.Drawing.Size(40, 40);
      this.btnConvert.TabIndex = 8;
      this.toolTip1.SetToolTip(this.btnConvert, "Convert to CSV");
      this.btnConvert.UseVisualStyleBackColor = true;
      this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
      // 
      // btnClear
      // 
      this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClear.Image = global::JSonToCSV.Properties.Resources.edit_clear_2;
      this.btnClear.Location = new System.Drawing.Point(562, 119);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(40, 40);
      this.btnClear.TabIndex = 4;
      this.toolTip1.SetToolTip(this.btnClear, "Clear file list");
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // chkSameFolder
      // 
      this.chkSameFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.chkSameFolder.AutoSize = true;
      this.chkSameFolder.Checked = true;
      this.chkSameFolder.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkSameFolder.Location = new System.Drawing.Point(12, 165);
      this.chkSameFolder.Name = "chkSameFolder";
      this.chkSameFolder.Size = new System.Drawing.Size(150, 17);
      this.chkSameFolder.TabIndex = 5;
      this.chkSameFolder.Text = "Use same folder for output";
      this.chkSameFolder.UseVisualStyleBackColor = true;
      this.chkSameFolder.CheckedChanged += new System.EventHandler(this.chkSameFolder_CheckedChanged);
      // 
      // txtOutputFolder
      // 
      this.txtOutputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txtOutputFolder.Enabled = false;
      this.txtOutputFolder.Location = new System.Drawing.Point(12, 188);
      this.txtOutputFolder.Name = "txtOutputFolder";
      this.txtOutputFolder.Size = new System.Drawing.Size(350, 20);
      this.txtOutputFolder.TabIndex = 6;
      // 
      // progressBar1
      // 
      this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.progressBar1.Location = new System.Drawing.Point(58, 214);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(304, 23);
      this.progressBar1.TabIndex = 9;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(614, 265);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.btnAbout);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.progressBar1);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtOutputFolder);
      this.Controls.Add(this.chkSameFolder);
      this.Controls.Add(this.btnConvert);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.lstFiles);
      this.Controls.Add(this.label1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "JSonToCSV";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListBox lstFiles;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.ToolTip toolTip1;
    private System.Windows.Forms.Button btnConvert;
    private System.Windows.Forms.CheckBox chkSameFolder;
    private System.Windows.Forms.TextBox txtOutputFolder;
    private System.Windows.Forms.Button btnBrowse;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnRemove;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.Button btnQuit;
  }
}