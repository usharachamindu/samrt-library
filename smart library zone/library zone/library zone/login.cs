using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient; // This is required for SQL Server connection

namespace library_zone
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string pwd = tb_pwd.Text;

            // Update the connection string with your SQL Server details
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    if (cmbLoginTyp.SelectedIndex == 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM mainadminlogin WHERE UserName=@UserName AND Password=@Password", con))
                        {
                            cmd.Parameters.AddWithValue("@UserName", tb_username.Text);
                            cmd.Parameters.AddWithValue("@Password", tb_pwd.Text);

                            int count = (int)cmd.ExecuteScalar();

                            if (count == 1)
                            {
                                using (MainAdministrator mAdmin = new MainAdministrator())
                                {
                                    mAdmin.receiveUser = userName;
                                    DialogResult dialogResult = mAdmin.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (cmbLoginTyp.SelectedIndex == 1)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM branchadminlogin WHERE UserName=@UserName AND Password=@Password", con))
                        {
                            cmd.Parameters.AddWithValue("@UserName", tb_username.Text);
                            cmd.Parameters.AddWithValue("@Password", tb_pwd.Text);

                            int count = (int)cmd.ExecuteScalar();

                            if (count == 1)
                            {
                                using (BranchAdministrator bAdmin = new BranchAdministrator())
                                {
                                    bAdmin.receiveUser = userName;
                                    bAdmin.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else if (cmbLoginTyp.SelectedIndex == 2)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM officerlogin WHERE UserName=@UserName AND Password=@Password", con))
                        {
                            cmd.Parameters.AddWithValue("@UserName", tb_username.Text);
                            cmd.Parameters.AddWithValue("@Password", tb_pwd.Text);

                            int count = (int)cmd.ExecuteScalar();

                            if (count == 1)
                            {
                                using (Officer sendToOfficer = new Officer())
                                {
                                    sendToOfficer.receiveUser = userName;
                                    sendToOfficer.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select login type!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbl_forgotpw_Click(object sender, EventArgs e)
        {
            resetpwd pwdreset = new resetpwd();
            this.Hide();
            pwdreset.Show();
        }

        private void lbl_forgotpw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
