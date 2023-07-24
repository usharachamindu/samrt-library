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
    public partial class MemberAttendanceReport : Form
    {
        public MemberAttendanceReport()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string pwd = tb_pwd.Text;
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True"; // Update with your connection details
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();

                // Check if the provided username and password match with branch admin login credentials
                SqlCommand cmdLogin = new SqlCommand("SELECT COUNT(*) FROM branchadminlogin WHERE UserName = @username AND Password = @password", con);
                cmdLogin.Parameters.AddWithValue("@username", userName);
                cmdLogin.Parameters.AddWithValue("@password", pwd);

                int loginResult = (int)cmdLogin.ExecuteScalar();
                if (loginResult == 1)
                {
                    // Fetch the member attendance records for the branch
                    SqlCommand cmdAttendance = new SqlCommand("SELECT * FROM memberattendance WHERE branchId IN (SELECT branchId FROM employee WHERE UserName = @username)", con);
                    cmdAttendance.Parameters.AddWithValue("@username", userName);
                    SqlDataAdapter sda = new SqlDataAdapter(cmdAttendance);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
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
