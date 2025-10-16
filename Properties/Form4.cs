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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            guna2TextBox3.UseSystemPasswordChar = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            //none
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //form load
            guna2TextBox1.Text = "";
            guna2TextBox3.Text = "";
            guna2TextBox5.Text = "";
            guna2TextBox4.Text = "";
            guna2TextBox2.Text = "";


        }
       

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            //none
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //none
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //none
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UserClass us = new UserClass();

            if (guna2TextBox5.Text == "")
            {
                MessageBox.Show("First Enter Username.");
                return;
            }
            if (!us.searchFunc(guna2TextBox5.Text))
            {
                MessageBox.Show("User Not Found");
                return;
            }
            if(guna2DateTimePicker1.Value != null)
            {
                UserClass uk = new UserClass();
                DateTime dt = new DateTime();
                dt = guna2DateTimePicker1.Value;
                uk.DOBchange(guna2TextBox5.Text, dt);
            }


            
            us._FullName = guna2TextBox1.Text;
            us._phone = guna2TextBox4.Text;
            us._Email = guna2TextBox2.Text;
            if(guna2TextBox3.Text!="")
            {
                us.changePass(guna2TextBox5.Text, guna2TextBox3.Text);
            }
            us.updateFunc(guna2TextBox5.Text);

            //submit button
            MessageBox.Show("User Profile Updated...");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //back button
            Form7 form7 = new Form7();
            this.Hide();
            form7.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //none
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ///signout
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            //password

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox3.UseSystemPasswordChar = true;
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            //user name
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            // full name
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            // phone number
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            // Email
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
