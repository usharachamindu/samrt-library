using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // This is the namespace for MSSQL connection

namespace library_zone
{
    public partial class AvailableEBooks : Form
    {
        public AvailableEBooks()
        {
            InitializeComponent();
        }

        SqlDataAdapter sda;
        //SqlCommand cmd; // You can uncomment this if you need to execute custom SQL commands.

        private void AvailableEBooks_Load(object sender, EventArgs e)
        {
            // Replace the connection string with your MS SSMS connection details
            // Example: "Data Source=myServerAddress;Initial Catalog=myDataBase;User Id=myUsername;Password=myPassword;"
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    sda = new SqlDataAdapter("SELECT * FROM ebook", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    memberDataTable.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
