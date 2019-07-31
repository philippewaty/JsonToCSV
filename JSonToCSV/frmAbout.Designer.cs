namespace JSonToCSV
{
  partial class frmAbout
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
      this.lblApplicationName = new System.Windows.Forms.Label();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.lblAuthor = new System.Windows.Forms.Label();
      this.lblAuthorValue = new System.Windows.Forms.Label();
      this.lblEmail = new System.Windows.Forms.Label();
      this.lblEmailValue = new System.Windows.Forms.Label();
      this.lblWebsite = new System.Windows.Forms.Label();
      this.lblWebsiteValue = new System.Windows.Forms.Label();
      this.btnQuit = new System.Windows.Forms.Button();
      this.lblCredits = new System.Windows.Forms.Label();
      this.lblCreditsValue = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblApplicationName
      // 
      this.lblApplicationName.AutoSize = true;
      this.lblApplicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblApplicationName.Location = new System.Drawing.Point(12, 9);
      this.lblApplicationName.Name = "lblApplicationName";
      this.lblApplicationName.Size = new System.Drawing.Size(125, 20);
      this.lblApplicationName.TabIndex = 0;
      this.lblApplicationName.Text = "Program name";
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.54949F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.45051F));
      this.tableLayoutPanel1.Controls.Add(this.lblAuthor, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblAuthorValue, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblEmailValue, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.lblWebsite, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblWebsiteValue, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.lblCredits, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.lblCreditsValue, 1, 3);
      this.tableLayoutPanel1.Location = new System.Drawing.Point(16, 51);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(345, 85);
      this.tableLayoutPanel1.TabIndex = 1;
      // 
      // lblAuthor
      // 
      this.lblAuthor.AutoSize = true;
      this.lblAuthor.Location = new System.Drawing.Point(3, 0);
      this.lblAuthor.Name = "lblAuthor";
      this.lblAuthor.Size = new System.Drawing.Size(41, 13);
      this.lblAuthor.TabIndex = 0;
      this.lblAuthor.Text = "Author:";
      // 
      // lblAuthorValue
      // 
      this.lblAuthorValue.AutoSize = true;
      this.lblAuthorValue.Location = new System.Drawing.Point(84, 0);
      this.lblAuthorValue.Name = "lblAuthorValue";
      this.lblAuthorValue.Size = new System.Drawing.Size(72, 13);
      this.lblAuthorValue.TabIndex = 1;
      this.lblAuthorValue.Text = "Philippe Waty";
      // 
      // lblEmail
      // 
      this.lblEmail.AutoSize = true;
      this.lblEmail.Location = new System.Drawing.Point(3, 19);
      this.lblEmail.Name = "lblEmail";
      this.lblEmail.Size = new System.Drawing.Size(35, 13);
      this.lblEmail.TabIndex = 2;
      this.lblEmail.Text = "Email:";
      // 
      // lblEmailValue
      // 
      this.lblEmailValue.AutoSize = true;
      this.lblEmailValue.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblEmailValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblEmailValue.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblEmailValue.Location = new System.Drawing.Point(84, 19);
      this.lblEmailValue.Name = "lblEmailValue";
      this.lblEmailValue.Size = new System.Drawing.Size(150, 13);
      this.lblEmailValue.TabIndex = 3;
      this.lblEmailValue.Text = "philippe.waty@protonmail.com";
      this.lblEmailValue.Click += new System.EventHandler(this.lblEmailValue_Click);
      // 
      // lblWebsite
      // 
      this.lblWebsite.AutoSize = true;
      this.lblWebsite.Location = new System.Drawing.Point(3, 38);
      this.lblWebsite.Name = "lblWebsite";
      this.lblWebsite.Size = new System.Drawing.Size(49, 13);
      this.lblWebsite.TabIndex = 4;
      this.lblWebsite.Text = "Website:";
      // 
      // lblWebsiteValue
      // 
      this.lblWebsiteValue.AutoSize = true;
      this.lblWebsiteValue.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblWebsiteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblWebsiteValue.ForeColor = System.Drawing.Color.RoyalBlue;
      this.lblWebsiteValue.Location = new System.Drawing.Point(84, 38);
      this.lblWebsiteValue.Name = "lblWebsiteValue";
      this.lblWebsiteValue.Size = new System.Drawing.Size(219, 13);
      this.lblWebsiteValue.TabIndex = 5;
      this.lblWebsiteValue.Text = "https://github.com/philippewaty/JsonToCSV";
      this.lblWebsiteValue.Click += new System.EventHandler(this.lblWebsiteValue_Click);
      // 
      // btnQuit
      // 
      this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnQuit.Image = global::JSonToCSV.Properties.Resources.system_exit;
      this.btnQuit.Location = new System.Drawing.Point(321, 149);
      this.btnQuit.Name = "btnQuit";
      this.btnQuit.Size = new System.Drawing.Size(40, 40);
      this.btnQuit.TabIndex = 12;
      this.btnQuit.UseVisualStyleBackColor = true;
      this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
      // 
      // lblCredits
      // 
      this.lblCredits.AutoSize = true;
      this.lblCredits.Location = new System.Drawing.Point(3, 58);
      this.lblCredits.Name = "lblCredits";
      this.lblCredits.Size = new System.Drawing.Size(42, 13);
      this.lblCredits.TabIndex = 6;
      this.lblCredits.Text = "Credits:";
      // 
      // lblCreditsValue
      // 
      this.lblCreditsValue.AutoSize = true;
      this.lblCreditsValue.Location = new System.Drawing.Point(84, 58);
      this.lblCreditsValue.Name = "lblCreditsValue";
      this.lblCreditsValue.Size = new System.Drawing.Size(246, 26);
      this.lblCreditsValue.TabIndex = 7;
      this.lblCreditsValue.Text = "Icons : open_icon_library-standard ( https://sourceforge.net/projects/openiconlib" +
    "rary/ )";
      // 
      // frmAbout
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnQuit;
      this.ClientSize = new System.Drawing.Size(373, 201);
      this.Controls.Add(this.btnQuit);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.lblApplicationName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblApplicationName;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.Label lblAuthorValue;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblEmailValue;
    private System.Windows.Forms.Label lblWebsite;
    private System.Windows.Forms.Label lblWebsiteValue;
    private System.Windows.Forms.Button btnQuit;
    private System.Windows.Forms.Label lblCredits;
    private System.Windows.Forms.Label lblCreditsValue;
  }
}