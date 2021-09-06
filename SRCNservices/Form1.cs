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

namespace SRCNservices
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            frmAddRecord frm = new frmAddRecord();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=SRCNServ;Integrated Security=True");
            try
            {
                conn.Open();

            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }

            //SqlCommand command = new SqlCommand("SELECT * FROM Services", conn);
            string query = "SELECT * FROM Services";
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
