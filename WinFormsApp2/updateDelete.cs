using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp2
{
    public partial class updateDelete : Form
    {
        public updateDelete()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            string update = "update Customer set Name='" + txtName.Text + "' where Id='" + txtId.Text + "'";
            SqlCommand cmd = new SqlCommand(update, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            string delete = "delete Customer  where Name='" + txtDeleteName.Text + "' ";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("deleted");
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            string display = "select * from Customer";
            SqlCommand cmd = new SqlCommand(display, conn);

            SqlDataReader rdr = cmd.ExecuteReader();
            string msg = "";
            while (rdr.Read())
            {
                msg += rdr[0].ToString() + "  " + rdr[1] + "\n";
            }
            rdr.Close();
            conn.Close();
            MessageBox.Show(msg);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Customer values('" + txtIdInsert.Text + "','" + txtNameInsert.Text + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("saved your information");
        }
    }
}
