using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace VLT.Music
{
    public partial class VltMusic : Form
    {

        List<string> lstFiles = new List<string>();
        string sFolderPath1 = "";
        string sFolderPath2 = "";
        string vltSong = @"C:\Sound\vlt1.wav";
        public VltMusic()
        {
            InitializeComponent();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                sFolderPath1 = folderBrowserDialog1.SelectedPath;
                textBox1.Text = sFolderPath1;
                //var myThread = new System.Threading.Thread(() => getFiles(sFolderPath1));
                //myThread.Start();
                LoadFiles();
            }

        }     

        private void getFiles(string path)
        {
            lstFiles = new List<string>();

            DirectoryInfo d = new DirectoryInfo(path); 

            FileInfo[] Files = d.GetFiles("*.wav");

            foreach (FileInfo file in Files)
            {
                lstFiles.Add(file.FullName);
            }

            dataGridView1.InvokeEx(y => y.DataSource = lstFiles.Select(x => new { Value = x }).ToList());

        }

        private void cmdPlay_Click(object sender, EventArgs e)
        {
            GetMusicReady(sFolderPath1);

        }

        private void GetMusicReady(string sFolder)
        {
            List<string> lstFilesInFolder = new List<string>();
            List<string> lstFile2Play = new List<string>();

            if (Directory.Exists(sFolder))
            {
                DirectoryInfo d = new DirectoryInfo(sFolder);

                FileInfo[] Files = d.GetFiles("*.wav");

                foreach (FileInfo file in Files)
                {
                    lstFilesInFolder.Add(file.FullName);
                }

                lstFile2Play.Clear();

                if (File.Exists(vltSong))
                {
                    lstFile2Play.Add(vltSong);
                }

                Random rnd = new Random();
                int r = rnd.Next(lstFilesInFolder.Count);
                lstFile2Play.Add(lstFilesInFolder[r]);

                //int r1 = rnd.Next(lstFilesInFolder.Count);
                //if(lstFilesInFolder.Count > 2 && r1 == r)
                //{
                //    do
                //    {
                //        r1 = rnd.Next(lstFilesInFolder.Count);
                //    } while (r1 == r);
                //}
                //lstFile2Play.Add(lstFilesInFolder[r1]);

                dataGridView2.InvokeEx(y => y.DataSource = lstFile2Play.Select(x => new { Value = x }).ToList());
                dataGridView2.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                var myThread = new System.Threading.Thread(() => PlayMusic(lstFile2Play));
                myThread.Start();
            }
        }

        private void PlayMusic(List<string> lstFile2Play)
        {
            for (int i = 0; i < lstFile2Play.Count(); i++)
            {
                using (System.Media.SoundPlayer player = new System.Media.SoundPlayer())
                {
                    lblPlayingSong.InvokeEx(x => x.Text = "Playing: " + lstFile2Play[i]);
                    player.SoundLocation = lstFile2Play[i];
                    player.PlaySync();
                }
            }                    
        }

        private void PlayMusicFodler(string sFolder)
        {
            DirectoryInfo d = new DirectoryInfo(sFolder);

            FileInfo[] Files = d.GetFiles("*.wav");

            //random file
            Random rnd = new Random();
            int r = rnd.Next(Files.Count());
            FileInfo file = Files[r];

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(file.FullName);
            lblPlayingSong.InvokeEx(x => x.Text = "Playing: " + file.Name);
            player.Play();

            //Play folder
            //System.Media.SoundPlayer player = new System.Media.SoundPlayer();

            //for (int i = 0; i < Files.Count(); i++)
            //{
            //    FileInfo file = Files[i];
            //    lblPlayingSong.InvokeEx(x => x.Text = "Playing: " + file.Name);
            //    player.SoundLocation = file.FullName;
            //    player.Play();
            //    Thread.Sleep(1000);
            //}

            //player.Stop();
            //player.Dispose();
        }

        private void VltMusic_Load(object sender, EventArgs e)
        {
            timer1.Start();
            sFolderPath1 = folderBrowserDialog1.SelectedPath;
            textBox1.Text = sFolderPath1;
            sFolderPath2 = folderBrowserDialog2.SelectedPath;
            textBox2.Text = sFolderPath2;

            LoadFiles();
        }

        private void LoadFiles()
        {
            lstFiles.Clear();
            if (Directory.Exists(sFolderPath1))
            {
                DirectoryInfo d1 = new DirectoryInfo(sFolderPath1);
                FileInfo[] f1 = d1.GetFiles("*.wav");
                for (int i = 0; i < f1.Count(); i++)
                {
                    lstFiles.Add(f1[i].FullName);
                }
            }

            if (Directory.Exists(sFolderPath2))
            {
                DirectoryInfo d2 = new DirectoryInfo(sFolderPath2);
                FileInfo[] f2 = d2.GetFiles("*.wav");
                for (int i = 0; i < f2.Count(); i++)
                {
                    lstFiles.Add(f2[i].FullName);
                }
            }

            if (lstFiles.Count > 0)
            {
                dataGridView1.InvokeEx(y => y.DataSource = lstFiles.Select(x => new { Value = x }).ToList());
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sTime = System.DateTime.Now.ToString("HH:mm:ss");
            lblTime.InvokeEx(x => x.Text = sTime);

            int iH1 = Convert.ToInt32(txtH1.Value);
            int iM1 = Convert.ToInt32(txtM1.Value);
            int iH2 = Convert.ToInt32(txtH2.Value);
            int iM2 = Convert.ToInt32(txtM2.Value);

            TimeSpan timeOfDay = System.DateTime.Now.TimeOfDay;
            int hour = timeOfDay.Hours;
            int min = timeOfDay.Minutes;
            int sec = timeOfDay.Seconds;                       

            if(hour == iH1 && min == iM1 && sec == 0)
            {
                //var myThread = new System.Threading.Thread(() => PlayMusicFodler(sFolderPath1));
                //myThread.Start();
                GetMusicReady(sFolderPath1);
            }

            if (hour == iH2 && min == iM2 && sec == 0)
            {
                GetMusicReady(sFolderPath1);
                //var myThread = new System.Threading.Thread(() => PlayMusicFodler(sFolderPath2));
                //myThread.Start();
            }
        }

        private void cmdLoadList2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog2.ShowDialog() == DialogResult.OK)
            {
                sFolderPath2 = folderBrowserDialog2.SelectedPath;
                textBox2.Text = sFolderPath2;
                LoadFiles();
                //var myThread = new System.Threading.Thread(() => getFiles(sFolderPath2));
                //myThread.Start();
            }
        }
    }

    static class ISynchronizeInvokeExtensions
    {
        public static void InvokeEx<T>(this T @this, Action<T> action) where T : ISynchronizeInvoke
        {
            try
            {
                if (@this.InvokeRequired)
                {
                    @this.Invoke(action, new object[] { @this });
                }
                else
                {
                    action(@this);
                }
            }
            catch (Exception ex) { System.Diagnostics.Debug.WriteLine(ex.Message); }
        }
    }
}
