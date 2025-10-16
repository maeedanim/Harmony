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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            guna2TextBox3.UseSystemPasswordChar = true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //form load
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //none
        }

        private void label2_Click(object sender, EventArgs e)
        {
            //none
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //submit button

            AdminClass us = new AdminClass();

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
            if (guna2DateTimePicker1.Value != null)
            {
                AdminClass uk = new AdminClass();
                DateTime dt = new DateTime();
                dt = guna2DateTimePicker1.Value;
                uk.DOBchange(guna2TextBox5.Text, dt);
            }

            if(guna2TextBox3.Text!="")
            {
                us.changePass(guna2TextBox5.Text, guna2TextBox3.Text);
            }

            us._FullName = guna2TextBox1.Text;
            us._phone = guna2TextBox4.Text;
            us._Email = guna2TextBox2.Text;
            
            us.updateFunc(guna2TextBox5.Text);


            MessageBox.Show("Admin Profile Updated...");
        }

       
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //none
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            //none
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ////////////////////////////////////back button
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //Sign out button
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

      
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //back button
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateofbirth
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //fullname
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            //password
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            //phone number
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

        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
