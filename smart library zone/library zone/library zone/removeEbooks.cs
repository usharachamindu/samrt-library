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
    public partial class removeEbooks : Form
    {
        public removeEbooks()
        {
            InitializeComponent();
        }
        SqlDataAdapter sda;
        SqlCommand cmd;

        private void removeEbooks_Load(object sender, EventArgs e)
        {
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);

            con.Open();
            sda = new SqlDataAdapter("Select * from eBook", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            memberDataTable.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tb_ebookId.Text);
            // Replace "your_server_name", "your_username", and "your_password" with your MS SQL Server credentials
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            try
            {
                cmd = new SqlCommand("Delete From eBook WHERE eBookId= @a ", con);
                cmd.Parameters.AddWithValue("a", id);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                    MessageBox.Show("Data delete successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Data cannot delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Database Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Refresh();
            sda = new SqlDataAdapter("Select * from eBook", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            memberDataTable.DataSource = dt;
            con.Close();
            cmd.Dispose();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
