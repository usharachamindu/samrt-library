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

namespace library_zone
{
    public partial class Edit_Profile : Form
    {
        public Edit_Profile()
        {
            InitializeComponent();
        }

        private void Edit_Profile_Load(object sender, EventArgs e)
        {
            memberDataTable.Visible = false;
            lbladdrs.Visible = false;
            lblcontact.Visible = false;
            lblemail.Visible = false;
            lblfn.Visible = false;
            lblln.Visible = false;
            lblnic.Visible = false;
            tbAddress.Visible = false;
            tbContact.Visible = false;
            tbEmail.Visible = false;
            tbFn.Visible = false;
            tbLn.Visible = false;
            tbNic.Visible = false;
            btnupdate.Visible = false;
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string pwd = tb_pwd.Text;
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM branchadminlogin WHERE UserName=@UserName AND Password=@Password", con))
                {
                    sda.SelectCommand.Parameters.AddWithValue("@UserName", userName);
                    sda.SelectCommand.Parameters.AddWithValue("@Password", pwd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        memberDataTable.Visible = true;
                        lbladdrs.Visible = true;
                        lblcontact.Visible = true;
                        lblemail.Visible = true;
                        lblfn.Visible = true;
                        lblln.Visible = true;
                        lblnic.Visible = true;
                        tbAddress.Visible = true;
                        tbContact.Visible = true;
                        tbEmail.Visible = true;
                        tbFn.Visible = true;
                        tbLn.Visible = true;
                        tbNic.Visible = true;
                        btnupdate.Visible = true;

                        using (SqlDataAdapter sda1 = new SqlDataAdapter("SELECT FirstName, LastName, NIC, Address, Contact, email FROM employee WHERE UserName=@UserName", con))
                        {
                            sda1.SelectCommand.Parameters.AddWithValue("@UserName", userName);
                            DataTable dt1 = new DataTable();
                            sda1.Fill(dt1);
                            memberDataTable.DataSource = dt1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Incorrect user name or password!", "WARNING!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.memberDataTable.Rows[e.RowIndex];
                tbFn.Text = row.Cells["FirstName"].Value.ToString();
                tbLn.Text = row.Cells["LastName"].Value.ToString();
                tbContact.Text = row.Cells["Contact"].Value.ToString();
                tbNic.Text = row.Cells["NIC"].Value.ToString();
                tbAddress.Text = row.Cells["Address"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string userName = tb_username.Text;
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE employee SET FirstName=@FirstName, LastName=@LastName, Contact=@Contact, NIC=@NIC, Address=@Address, email=@Email WHERE UserName=@UserName", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", tbFn.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbLn.Text);
                    cmd.Parameters.AddWithValue("@Contact", tbContact.Text);
                    cmd.Parameters.AddWithValue("@NIC", tbNic.Text);
                    cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@UserName", userName);

                    int i = cmd.ExecuteNonQuery();
                    if (i == 1)
                    {
                        MessageBox.Show("Successfully updated your info!", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Can't update your info!\nCheck again.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
