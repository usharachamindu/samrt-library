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
    public partial class BookReportByBranch : Form
    {
        public BookReportByBranch()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string pwd = tb_pwd.Text;
            // Replace the connection string with your MS SQL Server connection details
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM officerlogin WHERE UserName=@userName AND Password=@pwd", con);
                cmd.Parameters.AddWithValue("@userName", userName);
                cmd.Parameters.AddWithValue("@pwd", pwd);
                int count = (int)cmd.ExecuteScalar();

                if (count == 1)
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM book WHERE branchId IN (SELECT branchId FROM employee WHERE UserName=@userName)", con);
                    sda.SelectCommand.Parameters.AddWithValue("@userName", userName);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
