using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Harmony_Music_Player_.Properties
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            trackBar1.Value = 50;

        }
        
        string[] paths, files;
        private void Form8_Load(object sender, EventArgs e)
        {
            //form load
        }

        private void guna2Shapes2_Click(object sender, EventArgs e)
        {
            //
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
     
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ////
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            /////export

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = openFileDialog.SafeFileNames;
                paths = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBox1.Items.Add(files[i]);
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ///playlist
        }
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            
            Form1 form1 = new Form1();
            axWindowsMediaPlayer1.close();
            this.Hide();
            form1.ShowDialog();
            
        }

        private void Form8_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Shapes4_Click(object sender, EventArgs e)
        {
            //
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();  
            axWindowsMediaPlayer1.close();
            this.Hide();
            form7.ShowDialog();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //songs list box
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            try
            {
                var file = TagLib.File.Create(paths[listBox1.SelectedIndex]);
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                pictureBox1.Image = Image.FromStream(new MemoryStream(bin));
            }
            catch
            {

            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //stop
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            guna2TrackBar1.Value = 0;
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //play
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count- 1)
            {
                listBox1.SelectedIndex=listBox1.SelectedIndex+1;
            }
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex>0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex-1;
            }
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                guna2TrackBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                guna2TrackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
            try
            {
                label3.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                label4.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
            }
            catch { }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;    
        }

        private void guna2TrackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = axWindowsMediaPlayer1.currentMedia.duration * e.X / trackBar1.Width/7;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

     
    }
        
}
