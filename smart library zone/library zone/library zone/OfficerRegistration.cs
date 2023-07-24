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
    public partial class OfficerRegistration : Form
    {
        public OfficerRegistration()
        {
            InitializeComponent();
        }
        SqlCommand cmd1;
        SqlCommand cmd2;

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void OfficerRegistration_Load(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            int brid;
            string fname, lname, nic, address, tel, email, un, pwd;
            DateTime dob, regdate;
            brid = Convert.ToInt32(tb_brId.Text);
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
                cmd1 = new SqlCommand("Insert into Employee values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", con);
                cmd1.Parameters.AddWithValue("a", un);
                cmd1.Parameters.AddWithValue("b", fname);
                cmd1.Parameters.AddWithValue("c", lname);
                cmd1.Parameters.AddWithValue("d", nic);
                cmd1.Parameters.AddWithValue("e", address);
                cmd1.Parameters.AddWithValue("f", dob);
                cmd1.Parameters.AddWithValue("g", tel);
                cmd1.Parameters.AddWithValue("h", email);
                cmd1.Parameters.AddWithValue("i", regdate);
                cmd1.Parameters.AddWithValue("j", brid);

                cmd2 = new SqlCommand("Insert into OfficerLogin values(@m,@n)", con);
                cmd2.Parameters.AddWithValue("m", un);
                cmd2.Parameters.AddWithValue("n", pwd);
                int i = cmd1.ExecuteNonQuery();
                if (i != 0)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                int x = cmd2.ExecuteNonQuery();
                if (x != 0)
                    MessageBox.Show(this, "Data save Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(this, "Data Cannot Save", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
                cmd1.Dispose();
                cmd2.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
