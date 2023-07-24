using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class Leave : UserControl
    {
        public Leave()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;
        MySqlDataAdapter sda2;
        MySqlCommand cmd;

        private void Leave_Load(object sender, EventArgs e)
        {
            timer2.Start();
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (captureDevice.IsRunning)
                captureDevice.Stop();

            tb_QRcode.ResetText();
            pbCamera.Image = null;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password='';database=lzone");
            con.Open();
            string OutTime = Convert.ToString(DateTime.Now.ToLongTimeString());
            string Date = Convert.ToString(DateTime.Now.ToLongDateString());
            cmd = new MySqlCommand("Update employeeattendance SET LeaveTime='" + OutTime + "' where UserName='" + tb_QRcode.Text + "'", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Data save successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Data cannot save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sda2 = new MySqlDataAdapter("Select * from employeeattendance where UserName = '" + tb_QRcode.Text + "' ", con);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            con.Close();
            leaveDataTable.DataSource = dt2;
            cmd.Dispose();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
