using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicplayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        string[] path, files;

        private void start_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.FileNames;
                path = openFileDialog.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    musicList.Items.Add(files[i]);
                }
            }
        }

        private void stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
        }

        private void pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (musicList.SelectedIndex > 0)
            {
                musicList.SelectedIndex = musicList.SelectedIndex - 1;
            }
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (musicList.SelectedIndex < musicList.Items.Count - 1)
            {
                musicList.SelectedIndex = musicList.SelectedIndex + 1;
            }
        }

        private void volumeLevel_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = volumeLevel.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar.Value = (int)player.Ctlcontrols.currentPosition;
            }
        }

        private void progressBar_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition = player.currentMedia.duration * e.X / progressBar.Width;
        }

        private void musicList_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = path[musicList.SelectedIndex];
            player.Ctlcontrols.play();
        }

    }
}
