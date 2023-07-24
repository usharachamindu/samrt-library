using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.Data.SqlClient; // Add this namespace for MS SQL Server

namespace library_zone
{
    public partial class bookReceiving : Form
    {
        // Replace the connection string with your MS SQL Server connection details
        private string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        SqlDataAdapter sda;
        SqlDataAdapter sda2;
        SqlDataAdapter sda3;
        SqlCommand cmd;
        SqlCommand cmd2;

        public bookReceiving()
        {
            InitializeComponent();
        }

        private void bookReceiving_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                sda2 = new SqlDataAdapter("Select * from bookissue", con);
                DataTable dt = new DataTable();
                sda2.Fill(dt);
                bookIssueDataTable.DataSource = dt;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cmbDevice.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void bookReceiving_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCamera.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pbCamera.Image);
                if (result != null)
                {
                    tb_QRcode.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string bookName = tb_QRcode.Text;
                sda = new SqlDataAdapter("Select * from bookissue where BookName = '" + bookName + "' ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bookIssueDataTable.DataSource = dt;
            }
        }

        private void bookIssueDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.bookIssueDataTable.Rows[e.RowIndex];
                tb_bookId.Text = row.Cells["BookId"].Value.ToString();
                tb_bookName.Text = row.Cells["BookName"].Value.ToString();
                tb_member.Text = row.Cells["UserName"].Value.ToString();
                tbIssuedDate.Text = row.Cells["IssueDate"].Value.ToString();
                tb_tobereceive.Text = row.Cells["FinalDate"].Value.ToString();
            }
        }

        private void tb_bookId_OnValueChanged(object sender, EventArgs e)
        {
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                int bookId;
                string Member;
                DateTime issuedate, fdate, receivedate;
                bookId = Convert.ToInt32(tb_bookId.Text);
                Member = tb_member.Text;
                issuedate = Convert.ToDateTime(tbIssuedDate.Text);
                fdate = Convert.ToDateTime(tb_tobereceive.Text);
                receivedate = dtpReceive.Value;
                try
                {
                    cmd = new SqlCommand("Insert into bookreceive values (@a,@b,@c,@d,@e)", con);
                    cmd.Parameters.AddWithValue("a", bookId);
                    cmd.Parameters.AddWithValue("b", Member);
                    cmd.Parameters.AddWithValue("c", issuedate);
                    cmd.Parameters.AddWithValue("d", fdate);
                    cmd.Parameters.AddWithValue("e", receivedate);
                    int i = cmd.ExecuteNonQuery();
                    if (i != 0)
                        MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                try
                {
                    cmd2 = new SqlCommand("Delete From bookissue WHERE BookId= @f ", con);
                    cmd2.Parameters.AddWithValue("f", bookId);
                    int j = cmd2.ExecuteNonQuery();
                    if (j == 1)
                        MessageBox.Show("Book Received!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sda3 = new SqlDataAdapter("Select * from bookissue", con);
                DataTable dt = new DataTable();
                sda3.Fill(dt);
                bookIssueDataTable.DataSource = dt;
            }
        }

        private void lblback_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
