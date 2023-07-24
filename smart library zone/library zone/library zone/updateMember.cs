﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_zone
{
    public partial class updateMember : Form
    {
        string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True"; // Replace with your server and database details

        public updateMember()
        {
            InitializeComponent();
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            memberDataTable.Visible = true;
            string userName = tb_username.Text;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT FirstName, LastName, Address, Contact, email FROM member WHERE UserName = @UserName", con))
                {
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        if (dt.Rows.Count >= 1)
                        {
                            memberDataTable.DataSource = dt;
                        }
                        else
                        {
                            MessageBox.Show("Incorrect User Name!\nCheck again.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        private void updateMember_Load(object sender, EventArgs e)
        {
            memberDataTable.Visible = false;
        }

        private void memberDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = memberDataTable.Rows[e.RowIndex];
                tbFn.Text = row.Cells["FirstName"].Value.ToString();
                tbLn.Text = row.Cells["LastName"].Value.ToString();
                tbContact.Text = row.Cells["Contact"].Value.ToString();
                tbAddress.Text = row.Cells["Address"].Value.ToString();
                tbEmail.Text = row.Cells["email"].Value.ToString();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("UPDATE member SET FirstName=@FirstName, LastName=@LastName, " +
                    "Contact=@Contact, Address=@Address, email=@Email WHERE UserName=@UserName", con))
                {
                    cmd.Parameters.AddWithValue("@FirstName", tbFn.Text);
                    cmd.Parameters.AddWithValue("@LastName", tbLn.Text);
                    cmd.Parameters.AddWithValue("@Contact", tbContact.Text);
                    cmd.Parameters.AddWithValue("@Address", tbAddress.Text);
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                    cmd.Parameters.AddWithValue("@UserName", tb_username.Text);

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

        private void btnReset_Click(object sender, EventArgs e)
        {
            tb_username.ResetText();
            tbLn.ResetText();
            tbFn.ResetText();
            tbEmail.ResetText();
            tbContact.ResetText();
            tbAddress.ResetText();
        }
    }
}
