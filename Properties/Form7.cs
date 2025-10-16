using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmony_Music_Player_.Properties
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            //form load
        }

   
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //play button
            Form8 form8 = new Form8();
            this.Hide();
            form8.ShowDialog();

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            ///NONE
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //play button
            Form8 form8 = new Form8();
            this.Hide();
            form8.ShowDialog();
        }

        private void Form7_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            this.Hide();
            form4.ShowDialog();
        }
    }
}
