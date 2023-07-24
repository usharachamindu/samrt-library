using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;

namespace library_zone
{
    public partial class feedbackform : Form
    {
        public feedbackform()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string to = "libraryzonesmart@gmail.com";
            string pw = tb_pw.Text;
            string from = tb_from.Text;
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = tb_body.Text;
            message.Subject = tb_subject.Text;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pw);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Send email to member successfully!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Store the feedback data in the MS SQL Server database
                string connectionString = "Data Source=MSI;Initial Catalog=smartlibraryzone;Integrated Security=True;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string feedback = tb_body.Text;
                    SqlCommand cmd = new SqlCommand("INSERT INTO Feedback (FeedbackText) VALUES (@feedback)", con);
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Can't send email to member!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
