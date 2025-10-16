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
    public partial class Form6 : Form
    {
        public string Cgen;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            //form load
            guna2TextBox1.Text = "";
            guna2TextBox2.Text = "";
            guna2TextBox4.Text = "";


            var data2 = new List<helpCombo2Form6>();
            data2.Add(new helpCombo2Form6() { index = 0, Gnd = "Male" });
            data2.Add(new helpCombo2Form6() { index = 1, Gnd = "Female" });
            guna2ComboBox2.DataSource = data2;
            guna2ComboBox2.DisplayMember = "Gnd";
            guna2ComboBox2.ValueMember = "index";

            Cgen = "";

           // dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //back button
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //show list bo
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //user settings label
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //user settings image
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///////////////data list view
        }
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //phone number box
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            //role

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //fullname box
        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            //emailbox
        }

       
      

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {
            //phone number
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //date of birth
        }

        private void label12_Click(object sender, EventArgs e)
        {
            //none
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //delete user

            UserClass us = new UserClass();

            if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("First Enter Username.");
                return;
            }
            if (!us.searchFunc(guna2TextBox3.Text))
            {
                MessageBox.Show("User Not Found");
                return;
            }
            us.deleteFunc(guna2TextBox3.Text);

            MessageBox.Show("User Deleted.");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //add user



            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //edit user

            UserClass us = new UserClass();

            if (guna2TextBox3.Text == "")
            {
                MessageBox.Show("First Enter Username.");
                return;
            }
            if (!us.searchFunc(guna2TextBox3.Text))
            {
                MessageBox.Show("User Not Found");
                return;
            }
            if (guna2DateTimePicker1.Value != null)
            {
                UserClass uk = new UserClass();
                DateTime dt = new DateTime();
                dt = guna2DateTimePicker1.Value;
                uk.DOBchange(guna2TextBox3.Text, dt);
            }


            if(Cgen!="")
            {
                us._gender = Cgen;
            }


            us._FullName = guna2TextBox1.Text;
            us._phone = guna2TextBox4.Text;
            us._Email = guna2TextBox2.Text;
            
            us.updateFunc(guna2TextBox3.Text);




            MessageBox.Show("User Updated.");
        }

      
        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //gender

            var f = guna2ComboBox2.SelectedItem as helpCombo2Form6;
            if (f.index == 0)
            {
                Cgen = f.Gnd;
            }
            if (f.index == 1)
            {
                Cgen = f.Gnd;
            }
        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            //username
        }
    }
    internal class helpCombo2Form6
    {
        public string Gnd { get; set; }
        public int index { get; set; }
    }
}
