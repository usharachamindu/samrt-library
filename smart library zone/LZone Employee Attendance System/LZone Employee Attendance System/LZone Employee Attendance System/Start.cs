using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LZone_Employee_Attendance_System
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            using (Home sendToHome = new Home())
            {
                string a = "1";
                string b = "2";
                string c = "3";
                string d = "4";
                string f = "5";
                string g = "6";
                if (cmbBranchId.SelectedIndex == 0)
                {
                    sendToHome.receiveData = a;
                    sendToHome.ShowDialog();
                }
                else if (cmbBranchId.SelectedIndex == 1)
                {
                    sendToHome.receiveData = b;
                    sendToHome.ShowDialog();
                }
                else if (cmbBranchId.SelectedIndex == 2)
                {
                    sendToHome.receiveData = c;
                    sendToHome.ShowDialog();
                }
                else if (cmbBranchId.SelectedIndex == 3)
                {
                    sendToHome.receiveData = d;
                    sendToHome.ShowDialog();
                }
                else if (cmbBranchId.SelectedIndex == 4)
                {
                    sendToHome.receiveData = f;
                    sendToHome.ShowDialog();
                }
                else if (cmbBranchId.SelectedIndex == 5)
                {
                    sendToHome.receiveData = g;
                    sendToHome.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select the Branch Id !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
