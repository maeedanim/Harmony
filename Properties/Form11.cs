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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //formload
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

   
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //show d
            DataClasses2DataContext db = new DataClasses2DataContext();
            var q = from Project in db.User_tbls
                    select new
                    {
                        Project.full_name,
                        Project.username,
                        Project.email,
                        Project.gender,
                        Project.phone_number
                    };

            dataGridView1.DataSource = q;
            dataGridView1.Show();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //data
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            //search

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //search
            if(guna2TextBox1.Text=="")
            {
                MessageBox.Show("Enter User Name");
                return;
            }
            DataClasses2DataContext db=new DataClasses2DataContext();
            //User_tbl us=db.User_tbls.SingleOrDefault(x=> x.username==guna2TextBox1.Text);
            var us = from Project in db.User_tbls where Project.username== guna2TextBox1.Text select new
            {
                Project.full_name,
                Project.username,
                Project.email,
                Project.gender,
                Project.phone_number
            }; ;
            dataGridView1.DataSource=us;
            dataGridView1.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9();
            this.Hide();
            form9.ShowDialog();
        }
    }
}
