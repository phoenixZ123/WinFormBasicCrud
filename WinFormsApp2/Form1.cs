using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.stdName = txtName.Text;
            fm.ShowDialog();

            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values('" + txtId.Text + "','" + txtName.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}