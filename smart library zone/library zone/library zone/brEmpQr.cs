using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZXing;
using System.Data.SqlClient;

namespace library_zone
{
    public partial class brEmpQr : Form
    {
        public brEmpQr()
        {
            InitializeComponent();
        }

        private void tb_BrId_OnValueChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT UserName, FirstName, LastName, Address, BranchId FROM Employee WHERE BranchId = @BranchId", con))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@BranchId", tb_BrId.Text);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
            }
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tb_EmpUserName.Text = row.Cells["UserName"].Value.ToString();
                tb_qrName.Text = row.Cells["FirstName"].Value.ToString();
            }
        }

        private void btnGrenerateQr_Click(object sender, EventArgs e)
        {
            string qrData = tb_EmpUserName.Text;
            string qrFile = tb_qrName.Text;

            BarcodeWriter qrWriter = new BarcodeWriter();
            qrWriter.Format = BarcodeFormat.QR_CODE;
            qrWriter.Write(qrData).Save(@"C:\Users\ushar\Desktop\Project GUI\employeeQR\" + qrFile + ".png");
            qrBox.Image = Image.FromFile(@"C:\Users\ushar\Desktop\Project GUI\employeeQR" + qrFile + ".png");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void brEmpQr_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT UserName, FirstName, LastName, Address FROM Employee", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
            }
        }
    }
}
