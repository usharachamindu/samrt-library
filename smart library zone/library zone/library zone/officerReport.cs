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
    public partial class officerReport : Form
    {
        public officerReport()
        {
            InitializeComponent();
        }

        private void officerReport_Load(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select * from employee where UserName IN(select UserName from officerlogin)", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            memberDataTable.DataSource = dt;
        }

        private void tb_userName_OnValueChanged(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            if (tb_userName.Text == "")
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from employee where UserName IN(select UserName from officerlogin)", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from employee where (UserName IN(select UserName from branchAdminLogin)) AND BranchId = '" + tb_userName.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                memberDataTable.DataSource = dt;
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
