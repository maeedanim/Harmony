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
    public partial class Form10 : Form
    {

        public string Crol;
        public Form10()
        {
            InitializeComponent();
            guna2TextBox1.UseSystemPasswordChar = true;
            guna2TextBox2.UseSystemPasswordChar = true;
        }

       

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //password change
            if (Crol == "")
            {
                MessageBox.Show("Please Select Role first");
                return;
            }

            if (Crol == "User")
            {

                if (guna2TextBox3.Text == "")
                {
                    MessageBox.Show("Please insert User Name First");
                    return;
                }
                if (guna2TextBox4.Text == "")
                {
                    MessageBox.Show("Please insert User Name First");
                    return;
                }

                UserClass us = new UserClass();

                if (!us.searchFunc(guna2TextBox3.Text))
                {
                    MessageBox.Show("No User Found");
                    return;
                }

                if (!us.CheckPhone(guna2TextBox3.Text, guna2TextBox4.Text))
                {
                    MessageBox.Show("Invalid Phone Number");
                    return;
                }

                if (guna2TextBox1.Text == "")
                {

                    MessageBox.Show("Please Insert New Password");
                    return;
                }

                if (guna2TextBox2.Text == "")
                {

                    MessageBox.Show("Please Confirm Password");
                    return;
                }


                if (guna2TextBox1.Text.ToString() != guna2TextBox2.Text.ToString())
                {

                    MessageBox.Show("Password Does Not Match");
                    return;
                }



                us.changePass(guna2TextBox3.Text, guna2TextBox2.Text);



            }
            else if(Crol=="Admin")
            {
                if (guna2TextBox3.Text == "")
                {
                    MessageBox.Show("Please insert User Name First");
                    return;
                }
                if (guna2TextBox4.Text == "")
                {
                    MessageBox.Show("Please insert User Name First");
                    return;
                }

                AdminClass us = new AdminClass();

                if (!us.searchFunc(guna2TextBox3.Text))
                {
                    MessageBox.Show("No User Found");
                    return;
                }

                if (!us.CheckPhone(guna2TextBox3.Text, guna2TextBox4.Text))
                {
                    MessageBox.Show("Invalid Phone Number");
                    return;
                }

                if (guna2TextBox1.Text == "")
                {

                    MessageBox.Show("Please Insert New Password");
                    return;
                }

                if (guna2TextBox2.Text == "")
                {

                    MessageBox.Show("Please Confirm Password");
                    return;
                }


                if (guna2TextBox1.Text.ToString() != guna2TextBox2.Text.ToString())
                {

                    MessageBox.Show("Password Does Not Match");
                    return;
                }



                us.changePass(guna2TextBox3.Text, guna2TextBox2.Text);



            }



            MessageBox.Show("Password Changed...");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //none

        }

        private void Form10_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //confirm password
        }

        private void guna2CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox2.Checked)
            {
                guna2TextBox2.UseSystemPasswordChar=false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar=true;
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //password
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(guna2CheckBox1.Checked)
            {
                guna2TextBox1.UseSystemPasswordChar=false;
            }
            else
            {
                guna2TextBox1.UseSystemPasswordChar = true;
            }
        }

        private void Form10_Load(object sender, EventArgs e) // Load
        {
            var data1 = new List<helpCombo1Form10>();
            data1.Add(new helpCombo1Form10() { index = 0, rol = "User" });
            data1.Add(new helpCombo1Form10() { index = 1, rol = "Admin" });
            guna2ComboBox1.DataSource = data1;
            guna2ComboBox1.DisplayMember = "rol";
            guna2ComboBox1.ValueMember = "index";




            Crol = "";




        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // role

            var f = guna2ComboBox1.SelectedItem as helpCombo1Form10;
            if (f.index == 0)
            {
                Crol = f.rol;
            }
            if (f.index == 1)
            {
                Crol = f.rol;
            }


        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            // user name
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            // phone number
        }

        

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //back button
            Form1 form1 = new Form1();
            this.Hide();

            form1.ShowDialog();
        }
    }

    internal class helpCombo1Form10
    {
        public string rol { get; set; }
        public int index { get; set; }
    }
}
