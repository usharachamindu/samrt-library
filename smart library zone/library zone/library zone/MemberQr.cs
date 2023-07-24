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
using ZXing;

namespace library_zone
{
    public partial class MemberQr : Form
    {
        public MemberQr()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        private void MemberQr_Load(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=your_server_name;Initial Catalog=your_database_name;User ID=your_username;Password=your_password;";
            SqlConnection con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                sda = new SqlDataAdapter("SELECT MemberID,UserName,Address,BranchId FROM Member", con);
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

        private void btnGrenerateQr_Click(object sender, EventArgs e)
        {
            string qrData = tb_memberUserName.Text;
            string qrFile = tb_qrName.Text;

            BarcodeWriter qrWriter = new BarcodeWriter();
            qrWriter.Format = BarcodeFormat.QR_CODE;
            qrWriter.Write(qrData).Save(@"C:\Users\ushar\Desktop\Project GUI\memberQR" + qrFile + ".png");
            qrBox.Image = Image.FromFile(@"C:\Users\ushar\Desktop\Project GUI\memberQR" + qrFile + ".png");
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tb_memberId.Text = row.Cells["MemberID"].Value.ToString();
                tb_memberUserName.Text = row.Cells["UserName"].Value.ToString();
                tb_qrName.Text = row.Cells["UserName"].Value.ToString();
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnPrintQr_Click(object sender, EventArgs e)
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
