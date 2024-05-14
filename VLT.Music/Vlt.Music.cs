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
        public VltMusic()
        {
            InitializeComponent();
        }

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {                
                var myThread = new System.Threading.Thread(() => getFiles(folderBrowserDialog1.SelectedPath));
                myThread.Start();
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

            Random rnd = new Random();
            int r = rnd.Next(lstFiles.Count);
            string sFile = lstFiles[r];
            var myThread = new System.Threading.Thread(() => PlayMusic(sFile));
            myThread.Start();
        }

        private void PlayMusic(string file)
        {
            lblPlayingSong.InvokeEx(x => x.Text = "Playing: " + file);
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(file);
            player.Play();
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
