using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReorganizeFles
{
    public partial class Form1 : Form
    {
        public string m_sDestination = "";
        public string m_sSource = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblSelectedFolder.Text = fbd.SelectedPath;
                    m_sSource = fbd.SelectedPath;
                }
            }
        }
        private void MoveFiles(string sSource, string sDest)
        {
            string sFileType = "*.*";
            if (!txtFileType.Text.Equals(""))
                sFileType = txtFileType.Text;
            var fileList = new DirectoryInfo(sSource).GetFiles(sFileType, SearchOption.AllDirectories);
            progressBar.Maximum = fileList.Count();
            bool bDeleteOrig = chkDeleteOrig.Checked;
            bool bCheckTakenDate = chkCheckTakenDate.Checked;
            int iErrorCount = 0;
            foreach (var file in fileList)
            {
                bool bTakenError = false;
                string sOriginalFilePath = "";
                var TargetChildFolderName = "";
                //Get month from file
                var TargetParentFolderName = "";
                if (bCheckTakenDate)
                {
                    try
                    {
                        TargetParentFolderName = GetDateTakenFromImage(file.FullName).ToString("yyyy");
                    }
                    catch
                    {
                        bTakenError = true;
                    }
                    try
                    {
                        TargetChildFolderName = GetDateTakenFromImage(file.FullName).ToString("MMM");
                    }
                    catch
                    {
                        bTakenError = true;
                    }
                    if (bTakenError)
                    {
                        txtDisplay.Text += file.Name + " Date Taken Details Not Found \r\n";
                        txtDisplay.Update();
                        iErrorCount++;
                    }
                }
                if (bTakenError || !bCheckTakenDate)
                {
                    if (rblCreatedDate.Checked)
                    {
                        //Get year from file
                        TargetChildFolderName = file.CreationTime.ToString("MMM");
                        //Get month from file
                        TargetParentFolderName = file.CreationTime.ToString("yyyy");
                    }
                    else
                    {
                        //Get year from file
                        TargetChildFolderName = file.LastWriteTime.ToString("MMM");
                        //Get month from file
                        TargetParentFolderName = file.LastWriteTime.ToString("yyyy");
                    }
                }
                //Create year folder
                var parentdir = Directory.CreateDirectory(Path.Combine(sDest, TargetParentFolderName));
                //Create final path
                var childdir = Directory.CreateDirectory(Path.Combine(sDest + "/" + TargetParentFolderName, TargetChildFolderName));
                //Copy file to new directory
                file.CopyTo(Path.Combine(childdir.FullName, file.Name), true);
                #region Display & Progress Bar
                txtDisplay.Text += file.Name + " Moved \r\n";
                txtDisplay.Update();
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                txtDisplay.ScrollToCaret();
                progressBar.Value += 1;
                lblProgressText.Text = progressBar.Value.ToString() + "/" + progressBar.Maximum.ToString();
                lblProgressText.Update();
                #endregion
                //Get original file path and name for deleting if bool is cet

                if (bDeleteOrig)
                {
                    sOriginalFilePath = file.FullName;
                    System.IO.File.Delete(sOriginalFilePath);
                }

            }
            System.Windows.Forms.MessageBox.Show("Completed!\r\n" + fileList.Count() + " Files Moved\r\n Errors: " + iErrorCount.ToString() + "", "Message");
        }
        //we init this once so that if the function is repeatedly called
        //it isn't stressing the garbage man
        private static Regex r = new Regex(":");

        //retrieves the datetime WITHOUT loading the whole image
        public static DateTime GetDateTakenFromImage(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lblDest.Text = fbd.SelectedPath;
                    m_sDestination = fbd.SelectedPath;
                }
            }

        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (m_sDestination.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Select a destination folder", "Message");
                return;
            }
            else if (m_sSource.Equals(""))
            {
                System.Windows.Forms.MessageBox.Show("Select a source folder", "Message");
                return;
            }
            else
                MoveFiles(m_sSource, m_sDestination);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
