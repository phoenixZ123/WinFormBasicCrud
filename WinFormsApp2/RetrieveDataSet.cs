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
    public partial class RetrieveDataSet : Form
    {
        public RetrieveDataSet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=localhost;Initial Catalog=master;User ID=sa;Password=ComplexPassword123!;Connect Timeout=30;Encrypt=False;");

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Customer", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string data = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                data += "Id : " + row["Id"].ToString() + "Name : " + row["Name"] + "\n";

            }
            MessageBox.Show(data);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RetrieveDataSet_Load(object sender, EventArgs e)
        {
            
        }
    }
}
}
