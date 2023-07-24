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
    public partial class cancelMembership : Form
    {
        public cancelMembership()
        {
            InitializeComponent();
        }

        private void removeBooks_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Member", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
            }
        }

        private void tb_data_OnValueChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (tb_data.Text == "")
                {
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Member", con))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        memberDataTable.DataSource = dt;
                    }
                }
                else
                {
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Member WHERE UserName = @UserName", con))
                    {
                        sda.SelectCommand.Parameters.AddWithValue("@UserName", tb_data.Text);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        memberDataTable.DataSource = dt;
                    }
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                try
                {
                    using (SqlCommand cmd1 = new SqlCommand("DELETE FROM MemberLogin WHERE UserName = @UserName", con))
                    {
                        cmd1.Parameters.AddWithValue("@UserName", tb_data.Text);
                        int x = cmd1.ExecuteNonQuery();
                        if (x == 1)
                        {
                            using (SqlCommand cmd = new SqlCommand("DELETE FROM Member WHERE UserName = @UserName", con))
                            {
                                cmd.Parameters.AddWithValue("@UserName", tb_data.Text);
                                int i = cmd.ExecuteNonQuery();
                                if (i == 1)
                                    MessageBox.Show("User Suspended!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Can't remove member login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("System Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                this.Refresh();
                using (SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Member", con))
                {
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    memberDataTable.DataSource = dt;
                }
                con.Close();
            }
        }
    }
}
