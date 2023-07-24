using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace library_zone
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void AddBooks_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT MAX(BookId) AS MaximumId FROM book", con))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        int num = Convert.ToInt32(reader["MaximumId"]);
                        int newId = num + 1;
                        tb_bookId.Text = Convert.ToString(newId);
                    }
                    reader.Close();
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                int bookId, brid, pges;
                string bookName, author, catg;
                bookId = Convert.ToInt32(tb_bookId.Text);
                brid = Convert.ToInt32(tbBrid.Text);
                pges = Convert.ToInt32(tb_pages.Text);
                bookName = tb_bookName.Text;
                author = tb_author.Text;
                catg = cmb_category.Text;

                try
                {
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO book VALUES (@a,@b,@c,@d,@e,@f)", con))
                    {
                        cmd.Parameters.AddWithValue("@a", bookId);
                        cmd.Parameters.AddWithValue("@b", bookName);
                        cmd.Parameters.AddWithValue("@c", author);
                        cmd.Parameters.AddWithValue("@d", pges);
                        cmd.Parameters.AddWithValue("@e", catg);
                        cmd.Parameters.AddWithValue("@f", brid);

                        int i = cmd.ExecuteNonQuery();
                        if (i != 0)
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

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
