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
using MySql.Data.MySqlClient;

namespace library_zone
{
    public partial class MemberReport : Form
    {
        public MemberReport()
        {
            InitializeComponent();
        }

        private void MemberReport_Load(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM member", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void tb_userName_OnValueChanged(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=your_server_name;Initial Catalog=Lzone;User ID=your_username;Password=your_password;";
            MySqlConnection con = new MySqlConnection(connectionString);

            if (tb_userName.Text == "")
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM member", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                try
                {
                    con.Open();
                    MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM member WHERE MemberId='" + tb_userName.Text + "' OR UserName='" + tb_userName.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            MySqlConnection con = new MySqlConnection(connectionString);

            try
            {
                con.Open();
                MySqlDataAdapter sda = new MySqlDataAdapter("SELECT * FROM member WHERE MemberId='" + tb_userName.Text + "' OR UserName='" + tb_userName.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
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
