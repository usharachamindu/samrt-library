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
    public partial class excludeBooks : Form
    {
        public excludeBooks()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGrenerateQr_Click(object sender, EventArgs e)
        {
            string qrData = tb_bookName.Text;
            string qrFile = tb_qrName.Text;

            BarcodeWriter qrWriter = new BarcodeWriter();
            qrWriter.Format = BarcodeFormat.QR_CODE;
            qrWriter.Write(qrData).Save(@"C:\Users\ushar\Desktop\Project GUI\bookqr" + qrFile + ".png");
            qrBox.Image = Image.FromFile(@"C:\Users\ushar\Desktop\Project GUI\bookqr" + qrFile + ".png");
        }

        private void excludeBooks_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                sda = new SqlDataAdapter("Select BookId,BookName from Book", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                memberDataTable.DataSource = dt;
            }
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tb_bookId.Text = row.Cells["BookId"].Value.ToString();
                tb_bookName.Text = row.Cells["BookName"].Value.ToString();
                tb_qrName.Text = row.Cells["BookName"].Value.ToString();
            }
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

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
