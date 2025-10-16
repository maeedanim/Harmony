using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Harmony_Music_Player_.Properties
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form load
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            //none
        }

      

        private void alphaBlendTextBox1_TextChanged(object sender, EventArgs e)
        {
            //admin username
        }

       

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //none
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //none
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //login button

            if (guna2TextBox1.Text == "")
            {
                MessageBox.Show("Please insert UserName");
                return;
            }

            if (guna2TextBox2.Text == "")
            {
                MessageBox.Show("Please insert Password");
                return;
            }

            AdminClass us = new AdminClass();

            if (!us.searchFunc(guna2TextBox1.Text))
            {
                MessageBox.Show("No User Found");
                return;
            }
            if (!us.CheckPass(guna2TextBox1.Text, guna2TextBox2.Text))
            {
                MessageBox.Show("Wrong Password");
                return;
            }

            Form9 form9 = new Form9();
            MessageBox.Show("WELCOME HOME...!!!");
            this.Hide();
            form9.ShowDialog();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //username
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //password

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //admin register
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //back panel
            Form1 form1 = new Form1();
            this.Hide();
            //pictureBox4.Controls.Clear();
            form1.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            this.Hide();
            form10.ShowDialog();
        }
    }
}
