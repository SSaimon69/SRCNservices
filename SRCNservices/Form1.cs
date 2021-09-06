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
using System.Globalization;

namespace SRCNservices
{
    public partial class frmMain : Form
    {
        readonly string dataSource = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=SRCNServ;Integrated Security=True";

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
            //Заполняем фильтры
            yearCombo.DataSource = new string[]{"2021"};

            monthCombo.DataSource = DateTimeFormatInfo.CurrentInfo.MonthNames.Take(12).ToArray();
            monthCombo.SelectedItem = DateTime.Now.ToString("MMMM");

            halfCombo.DataSource = new string[] { "Первая", "Вторая" };

            SqlConnection conn = new SqlConnection(dataSource);
            try
            {
                conn.Open();

                //Заполняем обзорную таблицу
                string query = "SELECT Children.name AS Воспитанник, Service.name AS Услуга, count AS Колличество FROM Services " +
                    "JOIN Children ON Children.id = Services.idChild " +
                    "JOIN Service ON Services.idService = Service.id";

                dataGridView1.DataSource = GetData(conn, query);

                //Заполняем фильтр детей
                query = "SELECT name FROM Children";
                childCombo.DataSource = GetData(conn, query);
                childCombo.ValueMember = "name";
                conn.Close();
            }
            catch (Exception ex)
            {
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        DataTable GetData (SqlConnection conn, string query)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
