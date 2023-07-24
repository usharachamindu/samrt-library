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
using MySql.Data.MySqlClient;

namespace LZone_Employee_Attendance_System
{
    public partial class Home : Form
    {
        public string receiveData;
        public Home()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        MySqlDataAdapter sda2;
        MySqlCommand cmd;
        private void Home_Load(object sender, EventArgs e)
        {
            timer2.Start();
            leave1.Visible = false;
            tb_branchId.Text = receiveData;
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cmbDevice.Items.Add(filterInfo.Name);
            cmbDevice.SelectedIndex = 0;
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

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
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

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=lzone");
            con.Open();
            int brId;
            string userNm, InDate, InTime, LeaveTime;
            brId = Convert.ToInt32(tb_branchId.Text);
            userNm = tb_QRcode.Text;
            InDate = Convert.ToString(DateTime.Now.ToLongDateString());
            InTime = Convert.ToString(DateTime.Now.ToLongTimeString());
            LeaveTime = "Working..";
            cmd = new MySqlCommand("Insert into employeeattendance values (@a,@c,@d,@f,@g)", con);
            cmd.Parameters.AddWithValue("a", InDate);
            cmd.Parameters.AddWithValue("c", userNm);
            cmd.Parameters.AddWithValue("d", brId);
            cmd.Parameters.AddWithValue("f", InTime);
            cmd.Parameters.AddWithValue("g", LeaveTime);

            int i = cmd.ExecuteNonQuery();
            if (i != 0)
                MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sda2 = new MySqlDataAdapter("Select Date,UserName,BranchId,ArrivalTime from employeeattendance where UserName = '" + userNm + "' ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            con.Close();
            arriveDataTable.DataSource = dt2;
            cmd.Dispose();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_QRcode.ResetText();
            arriveDataTable.ClearSelection();
            pbCamera.Image = null;
        }

        private void brnArrive_Click(object sender, EventArgs e)
        {
            leave1.Visible = false;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            leave1.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
