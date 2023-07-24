using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // Add this namespace for MS SQL Server

namespace library_zone
{
    public partial class brAdminReport : Form
    {
        public brAdminReport()
        {
            InitializeComponent();
        }

        private void brAdminReport_Load(object sender, EventArgs e)
        {
            // Replace the connection string with your MS SQL Server connection details
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM employee WHERE UserName IN (SELECT UserName FROM branchAdminLogin)", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
        }

        private void tb_userName_OnValueChanged(object sender, EventArgs e)
        {
            // Replace the connection string with your MS SQL Server connection details
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (tb_userName.Text == "")
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM employee WHERE UserName IN (SELECT UserName FROM branchAdminLogin)", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                else
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM employee WHERE (UserName IN (SELECT UserName FROM branchAdminLogin)) AND BranchId = @userName", con);
                    sda.SelectCommand.Parameters.AddWithValue("@userName", tb_userName.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.memberDataTable.Width, this.memberDataTable.Height);
            memberDataTable.DrawToBitmap(bm, new Rectangle(0, 0, this.memberDataTable.Width, this.memberDataTable.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}
