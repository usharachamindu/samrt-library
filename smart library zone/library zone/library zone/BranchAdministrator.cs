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
    public partial class BranchAdministrator : Form
    {
        public string receiveUser;

        // Replace the connection string with your MS SQL Server connection details
        string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

        public BranchAdministrator()
        {
            InitializeComponent();
        }

        private void BranchAdministrator_Load(object sender, EventArgs e)
        {
            lblUser.Text = receiveUser;
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        // Method to execute SQL queries and retrieve data
        private DataTable ExecuteQuery(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            // Hide other user controls and show the settings user control
            HideAllUserControls();
            ucbr_settings1.Visible = true;
        }

        private void btn_Dashboard_Click_1(object sender, EventArgs e)
        {
            // Hide other user controls and show the dashboard user control
            HideAllUserControls();
            // ucbr_dashboard1.Visible = true; // Uncomment this line if you have a dashboard user control
        }

        private void btn_registration_Click_1(object sender, EventArgs e)
        {
            // Hide other user controls and show the registration user control
            HideAllUserControls();
            ucbr_registration1.Visible = true;
        }

        // Implement similar event handlers for other buttons...

        // Method to hide all user controls
        private void HideAllUserControls()
        {
            // ucbr_dashboard1.Visible = false; // Uncomment this line if you have a dashboard user control
            ucbr_registration1.Visible = false;
            ucbr_books1.Visible = false;
            ucbr_ebooks1.Visible = false;
            ucbr_reports1.Visible = false;
            ucbr_accounts1.Visible = false;
            ucbr_settings1.Visible = false;
            ucbr_help1.Visible = false;
        }

        // Rest of the form code...
    }
}
