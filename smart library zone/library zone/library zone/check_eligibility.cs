using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace library_zone
{
    public partial class check_eligibility : Form
    {
        public check_eligibility()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        private void check_eligibility_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (sda = new SqlDataAdapter("SELECT * FROM bookissue", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    bookIssueDataTable.DataSource = dt;
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string UserName = tb_userName.Text;
                using (sda2 = new SqlDataAdapter("SELECT * FROM bookissue WHERE UserName = @UserName", con))
                {
                    sda2.SelectCommand.Parameters.AddWithValue("@UserName", UserName);
                    DataTable dt = new DataTable();
                    sda2.Fill(dt);
                    bookIssueDataTable.DataSource = dt;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            BookIssuing bookIssuing = new BookIssuing();
            bookIssuing.Show();
            this.Hide();
        }

        private void btnIgnore_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
