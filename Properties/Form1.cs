using Harmony_Music_Player_.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmony_Music_Player_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            guna2TextBox2.UseSystemPasswordChar = true;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //none
        }
        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            //none
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //none
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //none
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form load
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //username
        }

        

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Register Button
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //password

           
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

            UserClass us=new UserClass();

            if (!us.searchFunc(guna2TextBox1.Text))
            {
                MessageBox.Show("No User Found");
                return;
            }
            if(!us.CheckPass(guna2TextBox1.Text, guna2TextBox2.Text))
            {
                MessageBox.Show("Wrong Password");
                return;
            }

            Form7 form7 = new Form7();
            
            this.Hide();
           
            form7.ShowDialog();
        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            //admin login panel
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //forget password
            Form10 form10 = new Form10();   
            this.Hide();
            form10.ShowDialog();
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar = false; 
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true; 
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
        }
    }
}
