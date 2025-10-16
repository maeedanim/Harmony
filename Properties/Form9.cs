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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //formload
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Maintenaince...!!!");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //admin settings
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //signout
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            this.Hide();
            form11.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            this.Hide();
            form5.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            this.Hide();
            form6.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            this.Hide();
            form11.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under Maintenaince...!!!");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
