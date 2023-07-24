using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_zone
{
    public partial class BAregistration : Form
    {
        // Connection string for MS SQL Server
        private string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";

        public BAregistration()
        {
            InitializeComponent();
        }

        private void BAregistration_Load(object sender, EventArgs e)
        {
            // You don't need this MySqlConnection since you are connecting to MS SQL Server.
            // MySqlConnection con = new MySqlConnection(connectionString);
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                int brid;
                string fname, lname, nic, address, tel, email, un, pwd;
                DateTime dob, regdate;
                brid = Convert.ToInt32(tb_brId.Text);

                if (string.IsNullOrEmpty(tb_fname.Text))
                {
                    lblError.Text = "*First Name cannot be blank";
                    tb_fname.Focus();
                    return;
                }
                // Add other validation checks for other textboxes if needed...

                fname = tb_fname.Text;
                lname = tb_lname.Text;
                nic = tb_nic.Text;
                address = tb_address.Text;
                tel = tb_contact.Text;
                email = tb_email.Text;
                un = tb_uname.Text;
                pwd = tb_pwd.Text;
                dob = dtp_dob.Value;
                regdate = dtp_regdate.Value;

                try
                {
                    using (SqlCommand cmd1 = new SqlCommand("INSERT INTO Employee VALUES (@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", con))
                    {
                        cmd1.Parameters.AddWithValue("@a", un);
                        cmd1.Parameters.AddWithValue("@b", fname);
                        cmd1.Parameters.AddWithValue("@c", lname);
                        cmd1.Parameters.AddWithValue("@d", nic);
                        cmd1.Parameters.AddWithValue("@e", address);
                        cmd1.Parameters.AddWithValue("@f", dob);
                        cmd1.Parameters.AddWithValue("@g", tel);
                        cmd1.Parameters.AddWithValue("@h", email);
                        cmd1.Parameters.AddWithValue("@i", regdate);
                        cmd1.Parameters.AddWithValue("@j", brid);

                        int i = cmd1.ExecuteNonQuery();

                        if (i != 0)
                            MessageBox.Show(this, "Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Data cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    using (SqlCommand cmd2 = new SqlCommand("INSERT INTO BranchAdminLogin VALUES (@m,@n)", con))
                    {
                        cmd2.Parameters.AddWithValue("@m", un);
                        cmd2.Parameters.AddWithValue("@n", pwd);

                        int x = cmd2.ExecuteNonQuery();

                        if (x != 0)
                            MessageBox.Show(this, "Data saved successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show(this, "Data cannot be saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_address.ResetText();
            tb_brId.ResetText();
            tb_contact.ResetText();
            tb_email.ResetText();
            tb_fname.ResetText();
            tb_lname.ResetText();
            tb_nic.ResetText();
            tb_pwd.ResetText();
            tb_uname.ResetText();
        }
    }
}
