using ChoETL;
using System;
using System.Windows.Forms;
using System.IO;

namespace JSonToCSV
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      this.Text = $"{Application.ProductName} - {Application.ProductVersion}";
      chkSameFolder.Checked = Properties.Settings.Default.USE_OUTPUT_PATH;
      if (!string.IsNullOrEmpty(Properties.Settings.Default.OUPUT_PATH))
      {
        txtOutputFolder.Text = Properties.Settings.Default.OUPUT_PATH;
      }
    }

    private void lstFiles_DragDrop(object sender, DragEventArgs e)
    {
      string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
      foreach (string file in files)
        lstFiles.Items.Add(file);
    }

    private void lstFiles_DragEnter(object sender, DragEventArgs e)
    {
      if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
    }

    private void lstFiles_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
        RemoveSelectedFile();
    }

    private void RemoveSelectedFile()
    {
      if (lstFiles.SelectedIndex > -1)
      {
        //Select next file
        int SelectedIndex = lstFiles.SelectedIndex;
        lstFiles.Items.RemoveAt(SelectedIndex);
        if (lstFiles.Items.Count > SelectedIndex)
        {
          lstFiles.SelectedIndex = SelectedIndex;
        }
        else if (lstFiles.Items.Count > 0)
        {
          //Select previous file
          lstFiles.SelectedIndex = SelectedIndex - 1;
        }
      }
    }

    private void chkSameFolder_CheckedChanged(object sender, EventArgs e)
    {
      txtOutputFolder.Enabled = !chkSameFolder.Checked;
      btnBrowse.Enabled = !chkSameFolder.Checked;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      using (var dlg = new FolderBrowserDialog())
      {
        dlg.Description = "Choose output folder";
        dlg.ShowNewFolderButton = true;
        dlg.RootFolder = Environment.SpecialFolder.MyComputer;
        if (!string.IsNullOrEmpty(txtOutputFolder.Text) && Directory.Exists(txtOutputFolder.Text))
          dlg.SelectedPath = txtOutputFolder.Text;
        if (dlg.ShowDialog() == DialogResult.OK)
        {
          txtOutputFolder.Text = dlg.SelectedPath;
          Properties.Settings.Default.OUPUT_PATH = txtOutputFolder.Text;
        }
      }
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
      try
      {
        progressBar1.Value = 0;
        progressBar1.Maximum = lstFiles.Items.Count;
        foreach (string file in lstFiles.Items)
        {
          using (var r = new ChoJSONReader(file))
          {
            FileInfo fi = new FileInfo(file);
            string csvFile;
            if (chkSameFolder.Checked)
            {
              csvFile = Path.Combine(fi.DirectoryName, Path.GetFileNameWithoutExtension(fi.Name) + ".csv");
            }
            else
            {
              csvFile = Path.Combine(txtOutputFolder.Text, Path.GetFileNameWithoutExtension(fi.Name) + ".csv");
            }
            using (var w = new ChoCSVWriter(csvFile))
            {
              w.WithFirstLineHeader();
              w.Write(r);
            }
          }
          progressBar1.Increment(1);
          Application.DoEvents();
        }
        MessageBox.Show("Conversion finished", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        progressBar1.Value = 0;
      }
      catch (Exception ex)
      {
        MessageBox.Show($"{ex.Message} {Environment.NewLine} {ex.StackTrace}", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      RemoveSelectedFile();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      using (var dlg = new OpenFileDialog())
      {
        dlg.Title = "Choose JSON file(s) to add";
        dlg.CheckFileExists = true;
        dlg.CheckPathExists = true;
        dlg.Filter = "JSON Files|*.json|All files (*.*)|*.*";
        dlg.Multiselect = true;
        if (dlg.ShowDialog() == DialogResult.OK)
        {
          lstFiles.Items.AddRange(dlg.FileNames);
        }
      }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      lstFiles.Items.Clear();
    }

    private void btnQuit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
      frmAbout about = new frmAbout();
      about.ShowDialog();
      about.Dispose();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.USE_OUTPUT_PATH = chkSameFolder.Checked;
      Properties.Settings.Default.OUPUT_PATH = txtOutputFolder.Text;
      Properties.Settings.Default.Save();
    }
  }
}
