using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MiniProjecttt
{
    public partial class Form3 : Form
    {
        private SqlCommand cmd;
        private SqlConnection cn;
        private SqlDataReader dr;

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (cn = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=Workshop; Integrated Security=True;"))
            {
                cn.Open();
                using (cmd = new SqlCommand("select username from people where username=@username", cn))
                {

                    cmd.Parameters.AddWithValue("@username", username.Text);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            MessageBox.Show("Username already exists, please try another", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();

                            using (cmd = new SqlCommand("Insert into people(email, passwordd, phone, username) values(@email, @passwordd, @phone, @username)", cn))
                            {
                                cmd.Parameters.AddWithValue("@username", username.Text);
                                cmd.Parameters.AddWithValue("@email", email.Text);
                                cmd.Parameters.AddWithValue("@passwordd", passwordd.Text);
                                cmd.Parameters.AddWithValue("@phone", phone.Text);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Your Account is created.We'll be happy to see you.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Hide();
                                Form6 bye = new Form6();
                                bye.Show();
                            }
                        }
                    }
                }
            }
        }

        private void username_Validating(object sender, CancelEventArgs e)
        {
            string desiredUsername = username.Text.ToLower(); // Convert username to lowercase for case-insensitive comparison
            List<string> prohibitedUsernames = new List<string> { "sophiak", "kandes", "sophiakande", "password", "test" }; // Convert all usernames to lowercase

            if (username.Text.Length <= 5)
            {
                MessageBox.Show("Username should be at least 4 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                e.Cancel = true;
            }
            else if (prohibitedUsernames.Contains(desiredUsername))
            {
                MessageBox.Show("Sorry, your  username '" + desiredUsername + "' is not allowed. You cannot be the orhanizer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Focus();
                e.Cancel = true;
            }


        }

        private void passwordd_Validating(object sender, CancelEventArgs e)
        {
            if (!(passwordd.Text.Length > 8))
            {
                MessageBox.Show("password should be at least 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordd.SelectAll();
                e.Cancel = true;
            }
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(email.Text))
            {
                MessageBox.Show("Email not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                email.SelectAll();
                e.Cancel = true;
            }
        }
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return !string.IsNullOrEmpty(email) && Regex.IsMatch(email, emailPattern);
        }

        private void phone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IsValidPhone(phone.Text) == false)
            {
                MessageBox.Show("Invalid phone number", "Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                phone.Focus();
                e.Cancel = true;
            }
        }
        public static bool IsValidPhone(string phoneNumber)
        {
            string phonePattern = @"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$";

            if (string.IsNullOrEmpty(phoneNumber))
                return false;

            Regex regex = new Regex(phonePattern);
            return regex.IsMatch(phoneNumber);
        }

    }
}

