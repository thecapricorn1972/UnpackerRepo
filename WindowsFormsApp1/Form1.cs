using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private string orgFilePath = ConfigurationManager.AppSettings["defaultFilePath"].ToString();
        private string orgExtensionRAR = ConfigurationManager.AppSettings["defaultExtensionRAR"].ToString();
        private string orgExtensionZIP = ConfigurationManager.AppSettings["defaultExtensionZIP"].ToString();
        private List<FileInfo> files = new List<FileInfo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filePath.Text = orgFilePath;
            chkExtensionRAR.Checked = (orgExtensionRAR == "True");
            chkExtensionZIP.Checked = (orgExtensionZIP == "True");
            btnUpdatePath.Enabled = false;
            btnUpdateExtension.Enabled = false;
           // btnUpdatePath.Image = Properties.Resources.Image1;
            //btnUpdatePath.Image = Image.FromFile(@"F:\Projects\Test\WindowsFormsApp1\Icon1.ico");
            //btnUpdatePath.ImageAlign = ContentAlignment.MiddleLeft;
            //btnUpdatePath.TextImageRelation = TextImageRelation.ImageBeforeText;
            //btnUpdatePath.TextAlign = ContentAlignment.MiddleRight;
        }

        private void btnUpdatePath_Click(object sender, EventArgs e)
        {
            UpdateSetting("defaultFilePath", filePath.Text);
            btnUpdatePath.Enabled = false;
            orgFilePath = filePath.Text;
        }

        private void updateExtensions()
        {
            if (orgExtensionRAR != chkExtensionRAR.ToString())
            {
                UpdateSetting("defaultExtensionRAR", chkExtensionRAR.Checked.ToString());
                UpdateSetting("defaultExtensionZIP", chkExtensionZIP.Checked.ToString());
                orgExtensionRAR = chkExtensionRAR.Checked.ToString();
                orgExtensionZIP = chkExtensionZIP.Checked.ToString();
                btnUpdateExtension.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileInfo[] tmpFiles;

            DirectoryInfo dirInfo = new DirectoryInfo(filePath.Text);

            tmpFiles = (from file in dirInfo.GetFiles("*.*", SearchOption.AllDirectories) orderby file.Name select file).ToArray();
            fileList.Items.Clear();
            foreach (FileInfo file in tmpFiles)
            {
                bool insertFile = false;

                // RAR: Only files with extension .part01.rar or where .part is not part of the filename
                if (chkExtensionRAR.Checked == true && file.Extension.ToLower() == ".rar")
                    if ((file.ToString().Contains(".part") && file.ToString().Contains(".part01")) || (!file.ToString().Contains(".part")))
                        insertFile = true;

                // ZIP: All ZIP files
                if (chkExtensionZIP.Checked == true && file.Extension.ToLower() == ".zip")
                    insertFile = true;

                if (insertFile)
                {
                    files.Add(file);
                    fileList.Items.Add(file.ToString());
                }
            }
        }

        private void UpdateSetting(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        private void fileList_SelectedValueChanged(object sender, EventArgs e)
        {
            int selectedPos = fileList.FindStringExact(fileList.Text);
            textBox1.Text = files[selectedPos].DirectoryName;
            textBox1.Text = files[selectedPos].DirectoryName;
        }

        private void filePath_TextChanged(object sender, EventArgs e)
        {
            btnUpdatePath.Enabled = (orgFilePath != filePath.Text);
        }

        private void chkExtension_CheckedChanged(object sender, EventArgs e)
        {
            btnUpdateExtension.Enabled = (orgExtensionRAR != chkExtensionRAR.Checked.ToString()) || (orgExtensionZIP != chkExtensionZIP.Checked.ToString());
        }

        private void btnUpdateExtension_Click(object sender, EventArgs e)
        {
            updateExtensions();
        }

    }
}
