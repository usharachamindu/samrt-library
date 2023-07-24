using System;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace library_zone
{
    public partial class viewAvailableBooks : Form
    {
        public viewAvailableBooks()
        {
            InitializeComponent();
        }

        SqlDataAdapter  sda;
        private void viewAvailableBooks_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    sda = new SqlDataAdapter("SELECT * FROM book", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    memberDataTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
               
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
