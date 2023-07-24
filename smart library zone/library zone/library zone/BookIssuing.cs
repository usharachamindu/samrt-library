using AForge.Video.DirectShow;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
// Add other namespaces as needed.

namespace library_zone
{
    public partial class BookIssuing : Form
    {
        // Connection string for MS SQL Server
        private string connectionString = "Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True";

        public FilterInfoCollection FilterInfoCollection { get; private set; }

        // Rest of your code...

        private void BookIssuing_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;

            // SqlConnection con = new SqlConnection("Data Source=YourServerName;Initial Catalog=YourDatabaseName;Integrated Security=True");
            // con.Open();
            // Replace the above line with the correct connection string

            // Rest of your code...
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string bookName = tb_QRcode.Text;
                using (SqlCommand cmd = new SqlCommand("SELECT BookId, BookName, AuthorName, Pages FROM Book WHERE BookName = @bookName", con))
                {
                    cmd.Parameters.AddWithValue("@bookName", bookName);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt1 = new DataTable();
                        sda.Fill(dt1);
                        bookDataTable.DataSource = dt1;
                    }
                }
            }
        }

        // Rest of your code...
    }
}
