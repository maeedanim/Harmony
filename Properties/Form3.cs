using Guna.UI2.WinForms;
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
    public partial class Form3 : Form
    {
        public string Crol;
        public string Cgen;
        public Form3()
        {
            InitializeComponent();
            guna2TextBox3.UseSystemPasswordChar = true;
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            //panal
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //confirm tab
            //DateTime dt = new DateTime();
            //dt = Convert.ToDateTime(this.guna2DateTimePicker1);

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //form load


            var data1 = new List<helpCombo1Form3>();
            data1.Add(new helpCombo1Form3() { index=0,rol="User"});
            data1.Add(new helpCombo1Form3() { index = 1, rol = "Admin" });
            guna2ComboBox1.DataSource = data1;
            guna2ComboBox1.DisplayMember = "rol";
            guna2ComboBox1.ValueMember = "index";



            var data2 = new List<helpCombo2Form3>();
            data2.Add(new helpCombo2Form3() { index = 0, Gnd = "Male" });
            data2.Add(new helpCombo2Form3() { index = 1, Gnd = "Female" });
            guna2ComboBox2.DataSource = data2;
            guna2ComboBox2.DisplayMember = "Gnd";
            guna2ComboBox2.ValueMember = "index";

            Cgen = Crol = "";


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //back button
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Crol == "")
                {
                    MessageBox.Show("Please select role first !!");
                    return;
                }
                if (Crol == "User")
                {
                    UserClass us = new UserClass();
                    if (guna2TextBox1.Text == "")
                    {
                        MessageBox.Show("Please Insert Full name !!");
                        return;
                    }

                    if (guna2TextBox2.Text == "")
                    {
                        MessageBox.Show("Please Insert Email !!");
                        return;
                    }

                    if (guna2TextBox3.Text == "")
                    {
                        MessageBox.Show("Please Set Password !!");
                        return;
                    }

                    if (guna2TextBox4.Text == "")
                    {
                        MessageBox.Show("Please Insert your Phone number !!");
                        return;
                    }

                    if (guna2TextBox5.Text == "")
                    {
                        MessageBox.Show("Please Select User name !!");
                        return;
                    }

                    if (Cgen == "")
                    {
                        MessageBox.Show("Please Select Gender !!");
                        return;
                    }

                    us._UserName = guna2TextBox5.Text;
                    us._FullName = guna2TextBox1.Text;
                    us._phone = guna2TextBox4.Text;
                    us._password = guna2TextBox3.Text;
                    us._Email = guna2TextBox2.Text;
                    us._gender = Cgen;
                    us._membership = 0;
                    DateTime dt=new DateTime();
                    dt = guna2DateTimePicker1.Value;
                    us._dt = dt;

                    us.insertFunc();
                }
                else if(Crol == "Admin")
                {
                    AdminClass us = new AdminClass();
                    if (guna2TextBox1.Text == "")
                    {
                        MessageBox.Show("Please Insert Full name !!");
                        return;
                    }

                    if (guna2TextBox2.Text == "")
                    {
                        MessageBox.Show("Please Insert Email !!");
                        return;
                    }

                    if (guna2TextBox3.Text == "")
                    {
                        MessageBox.Show("Please Set Password !!");
                        return;
                    }

                    if (guna2TextBox4.Text == "")
                    {
                        MessageBox.Show("Please Insert your Phone number !!");
                        return;
                    }

                    if (guna2TextBox5.Text == "")
                    {
                        MessageBox.Show("Please Select User name !!");
                        return;
                    }

                    if (Cgen == "")
                    {
                        MessageBox.Show("Please Select Gender !!");
                        return;
                    }

                    us._ad_UserName = guna2TextBox5.Text;
                    us._FullName = guna2TextBox1.Text;
                    us._phone = guna2TextBox4.Text;
                    us._password = guna2TextBox3.Text;
                    us._Email = guna2TextBox2.Text;
                    us._gender = Cgen;
                    DateTime dt = new DateTime();
                    dt = guna2DateTimePicker1.Value;
                    us._dt = dt;

                    us.insertFunc();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }





            //confirm button
            Form1 form = new Form1();
            MessageBox.Show("New Account Created...");
            //this.Hide();
            //form.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //none
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //fullnamme
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //emailbox
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //dateofbirth
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gender

            var f = guna2ComboBox2.SelectedItem as helpCombo2Form3;
            if (f.index == 0)
            {
                Cgen = f.Gnd;
            }
            if (f.index == 1)
            {
                Cgen = f.Gnd;
            }


        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //role

            var f = guna2ComboBox1.SelectedItem as helpCombo1Form3;
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
                guna2TextBox3.UseSystemPasswordChar=true;
            }
        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {
            //user name
        }

      
    }




    internal class helpCombo2Form3
    {
        public string Gnd {  get; set; }
        public int index {  get; set; }
    }

    internal class helpCombo1Form3
    {
        public string rol { get; set; }
        public int index { get; set; }
    }

}
