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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString);

        public static string loginEmployeeUsername;
        public static int loginEmployee_id;
        public static string loginEmployee_Name;
        public static string loginEmployee_Surname;
        public static int loginEmployee_Age;
        //public static DateTime loginEmployee_birthdate;
        public static int loginEmployee_Salary;
        public static DateTime loginEmployee_RegistrationDate;
        

        public static bool tabEmp;
        public static bool tabCityCountry;
        public static bool tabDeptEducation;
        public static bool tabCustomers;
        public static bool tabSales;
        public static bool tabProducts;
        public static bool tabWarehouse;
        public static bool tabSupply;
        public static bool tabUsers;


        private void login_login_btn_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_GirisYap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@kullanici_ad", loginUsername_txt.Text);
            cmd.Parameters.AddWithValue("@kullanici_sifre", loginPassword_txt.Text);
            SqlDataReader reader = cmd.ExecuteReader();

            string loginstr = "";
            bool kullaniciadstr = false;
            bool sifrestr = false;

            if (string.IsNullOrWhiteSpace(loginUsername_txt.Text))
            {
                kullaniciadstr = true;
                loginstr += "Username\n";
            }

            if (string.IsNullOrWhiteSpace(loginPassword_txt.Text))
            {
                sifrestr = true;
                loginstr += "Password\n";
            }

            if (kullaniciadstr || sifrestr)
            {
                MessageBox.Show(loginstr + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
                return;
            }

            if (reader.HasRows)
            {

                while (reader.Read())
                {

                    loginEmployeeUsername = loginUsername_txt.Text;

                    loginEmployee_id = Convert.ToInt32(reader["calisan_id"].ToString());
                    loginEmployee_Name = reader["calisan_ad"].ToString();
                    loginEmployee_Surname = reader["calisan_soyad"].ToString();
                    loginEmployee_Age = Convert.ToInt32(reader["calisan_yas"].ToString());


                    

                    loginEmployee_Salary = Convert.ToInt32(reader["calisan_maas"].ToString());

                    //DateTime birthdate = Convert.ToDateTime(reader["birthdate"]);
                    //loginEmployee_RegistrationDate = reader["email"].ToString();

                   

                    tabEmp = Convert.ToBoolean(reader["calisanlar"]);
                    tabCityCountry = Convert.ToBoolean(reader["sehirUlke"]);
                    tabDeptEducation = Convert.ToBoolean(reader["departmanlar"]);
                    tabCustomers = Convert.ToBoolean(reader["musteriler"]);
                    tabSales = Convert.ToBoolean(reader["satislar"]);
                    tabProducts = Convert.ToBoolean(reader["urunler"]); 
                    tabWarehouse = Convert.ToBoolean(reader["stoklar"]);  
                    tabSupply = Convert.ToBoolean(reader["tedarik"]);  
                    tabUsers = Convert.ToBoolean(reader["kullanicilar"]);

                }

                conn.Close();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }

            else
            {

                conn.Close();
                MessageBox.Show("Invalid Account Number or Password. Please try again.", "Invalid Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_forgotPassword_btn_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotpassw = new ForgotPassword();
            this.Hide();
            forgotpassw.Show();
        }

        private void cBox_login_showHide_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_login_showHide.Checked == true)
            {
                loginPassword_txt.PasswordChar = '\0';
            }

            else
            {
                loginPassword_txt.PasswordChar = '*';
            }
        }
    }
}
