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
using System.Net;
using System.Net.Mail;

namespace library_zone
{
    public partial class resetpwd : Form
    {
        string randomCode;
        string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True"; // Replace with your server and database details

        public resetpwd()
        {
            InitializeComponent();
        }

        // Rest of the code remains the same...

        private void btnReset_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                if (cmbTyp.SelectedIndex == 0)
                {
                    MessageBox.Show("Can't change main admin password!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbTyp.SelectedIndex == 1)
                {
                    if ((tbnewpw.Text).ToString() == (tbConfirmPw.Text).ToString())
                    {
                        try
                        {
                            string query = "UPDATE branchadminlogin SET Password = @Password WHERE UserName IN (SELECT UserName FROM employee WHERE email = @Email)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Password", tbnewpw.Text);
                                cmd.Parameters.AddWithValue("@Email", tb_email.Text);

                                int i = cmd.ExecuteNonQuery();
                                if (i == 1)
                                {
                                    MessageBox.Show("Password reset successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Can't reset your password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("System error", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        lblvalidation.Text = "*must be same";
                    }
                }
                else if (cmbTyp.SelectedIndex == 2)
                {
                    if ((tbnewpw.Text).ToString() == (tbConfirmPw.Text).ToString())
                    {
                        try
                        {
                            string query = "UPDATE officerlogin SET Password = @Password WHERE UserName IN (SELECT UserName FROM employee WHERE email = @Email)";
                            using (SqlCommand cmd = new SqlCommand(query, con))
                            {
                                cmd.Parameters.AddWithValue("@Password", tbnewpw.Text);
                                cmd.Parameters.AddWithValue("@Email", tb_email.Text);

                                int i = cmd.ExecuteNonQuery();
                                if (i == 1)
                                {
                                    MessageBox.Show("Password reset successfully!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Can't reset your password!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("System error", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        lblvalidation.Text = "*must be same";
                    }
                }
                else
                {
                    MessageBox.Show("Please select your login type!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            login backToLogin = new login();
            backToLogin.Show();
            this.Close();
        }
    }
}
