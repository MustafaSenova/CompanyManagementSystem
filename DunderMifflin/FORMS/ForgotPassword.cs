using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace $safeprojectname$.Forms
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString);


        private void forgot_exit_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void forgot_change_password_btn_Click(object sender, EventArgs e)
        {
            try
            {

                string forgotstr = "";

                bool empUsername = false;
                bool empNewPassword = false;
                bool empSecurity = false;


                if (string.IsNullOrWhiteSpace(forgotUsername_txt.Text))
                {
                    empUsername = true;
                    forgotstr += "Username\n";
                }

                if (string.IsNullOrWhiteSpace(forgotPassword_txt.Text))
                {
                    empNewPassword = true;
                    forgotstr += "New Password\n";
                }

                if (string.IsNullOrWhiteSpace(forgotSecurity_txt.Text))
                {
                    empSecurity = true;
                    forgotstr += "Security Question\n";
                }

                


                if (empUsername || empNewPassword || empSecurity)
                {
                    MessageBox.Show(forgotstr + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SifreDegistir", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", forgotUsername_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_sifre", forgotPassword_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_guvenlik", forgotSecurity_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Password changed succesfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

            }
            catch
            {
                MessageBox.Show("Username or security question answer is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
    }
}
