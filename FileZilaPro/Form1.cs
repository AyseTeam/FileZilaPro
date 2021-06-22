using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.IO.Compression;
using System.Text.RegularExpressions;

namespace FileZilaPro
{
    public partial class Form1 : Form
    {
        int _tick = 5;
        int _tick2 = 5;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void por_Click(object sender, EventArgs e)
        {
            try
            {


                bool exist1 = File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\FileZilla.Pro.3.52.2.Portable.zip");
                bool exist11 = File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\FileZilla.Pro.3.52.2.Portable");

                if (exist1 || exist11)
                {
                    MessageBox.Show("File exist");
                }
                else
                {
                    progressBar1.Value = 10;

                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;

                    progressBar1.Value = 20;

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/824369227142135809/827214547021856788/FileZilla.Pro.3.52.2.Portable.zip", @"C:\Users\" + Environment.UserName + @"\Desktop\FileZilla.Pro.3.52.2.Portable.zip");

                    progressBar1.Value = 70;

                    string Name = "FileZilla.Pro.3.52.2.Portable.zip";
                    string Path = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                    string zipPath = Path + Name;

                    ZipFile.ExtractToDirectory(zipPath, @"C:\Users\" + Environment.UserName + @"\Desktop\");

                    File.Delete(zipPath);

                    progressBar1.Value = 78;


                    bool exist3 = File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Portable.txt");

                    if (exist3)
                    {
                        progressBar1.Value = 100;

                        DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want open the 'Readme-Portable.txt' ?          ", "Open", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Portable.txt");
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }
                        else
                        {
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }

                    }
                    else
                    {
                        WebClient Readme1 = new WebClient();
                        Readme1.DownloadFile("https://cdn.discordapp.com/attachments/824369227142135809/827255469508788274/Readme-Portable.txt", @"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Portable.txt");
                        progressBar1.Value = 100;
                        progressBar1.Value = 0;
                        End1.Start();
                        MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }


            }
            catch (WebException a)
            {
                progressBar1.Visible = false;
                MessageBox.Show(a.ToString());
            }
        }

        private void inst_Click(object sender, EventArgs e)
        {
            try
            {
               

                bool exist2 = File.Exists(@"C:\Users\"+Environment.UserName+ @"\Desktop\FileZilla.Pro.3.52.2_Installer.zip");
                bool exist22 = File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\FileZilla.Pro.3.52.2_Installer");

                if (exist2 || exist22)
                {
                    MessageBox.Show("File exist");
                }
                else
                {
                    progressBar1.Value = 10;

                    progressBar1.Visible = true;
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = 100;

                    progressBar1.Value = 20;

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://cdn.discordapp.com/attachments/824369227142135809/827214044746088448/FileZilla.Pro.3.52.2_Installer.zip", @"C:\Users\" + Environment.UserName + @"\Desktop\FileZilla.Pro.3.52.2_Installer.zip");

                    progressBar1.Value = 70;

                    string Name = "FileZilla.Pro.3.52.2_Installer.zip";
                        string Path = @"C:\Users\" + Environment.UserName + @"\Desktop\";
                        string zipPath = Path + Name;

                        ZipFile.ExtractToDirectory(zipPath, @"C:\Users\" + Environment.UserName + @"\Desktop\");

                    File.Delete(zipPath);

                    progressBar1.Value = 78;


                    bool exist3 = File.Exists(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Installer.txt");

                    if (exist3)
                    {
                        progressBar1.Value = 100;

                        DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want open the 'Readme-Installer.txt' ?          ", "...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (res == System.Windows.Forms.DialogResult.Yes)
                        {
                            Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Installer.txt");
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }
                        else
                        {
                            progressBar1.Visible = false;
                            progressBar1.Value = 0;
                            MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        }

                    }
                    else
                    {
                        WebClient Readme2 = new WebClient();
                        Readme2.DownloadFile("https://cdn.discordapp.com/attachments/824369227142135809/827231457298219008/Readme.txt", @"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Installer.txt");
                        progressBar1.Value = 100;
                        progressBar1.Value = 0;
                        End2.Start();
                        MessageBox.Show("It's installed ! 🐱‍🏍", "🐱‍🏍", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                
            }
            catch (WebException a)
            {
                progressBar1.Visible = false;
                MessageBox.Show(a.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
        }

        
        private void End_Tick(object sender, EventArgs e)
        {
            _tick2--;

            if (_tick2 == 0)
            {
                Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Installer.txt");
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                End2.Stop();
            }
        }

        private void End1_Tick(object sender, EventArgs e)
        {
            _tick--;

            if (_tick == 0)
            {
                Process.Start(@"C:\Users\" + Environment.UserName + @"\Desktop\Readme-Portable.txt");
                progressBar1.Visible = false;
                progressBar1.Value = 0;
                End2.Stop();
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/VVh9WCw8Ym");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes)
            {
                Dispose(true);
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }

            base.OnFormClosing(e);
            if (progressBar1.Value > 1)
            {
                if (Installation() == System.Windows.Forms.DialogResult.Yes)
                {
                    Dispose(true);
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private DialogResult PreClosingConfirmation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("Do you want to leave `FileZilla Pro` ?          ", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            return res;
        }

        private DialogResult Installation()
        {
            DialogResult res = System.Windows.Forms.MessageBox.Show("FileZilla Pro is in installation, Do you went leave ?          ", "Quit...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            return res;
        }
    }
}
