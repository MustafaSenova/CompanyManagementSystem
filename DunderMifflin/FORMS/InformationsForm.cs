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
    public partial class InformationsForm : Form
    {
        public InformationsForm()
        {
            InitializeComponent();
            empID_lbl.Text = LoginForm.loginEmployee_id.ToString();
            empName_lbl.Text = LoginForm.loginEmployee_Name + " " + LoginForm.loginEmployee_Surname;
            empAge_lbl.Text = LoginForm.loginEmployee_Age.ToString();
            empSalary_lbl.Text = LoginForm.loginEmployee_Salary.ToString();
            //empHomeland_lbl.Text = LoginForm.loginEmployee_Homeland.ToString();
            //empDepartment_lbl.Text = LoginForm.loginEmployee_Department.ToString();
            //empEducation_lbl.Text = LoginForm.loginEmployee_Education.ToString();


        }

        public static string Employee_Homeland;
        public static string Employee_Department;
        public static string Employee_Education;

        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString);



        private void informations_exit_btn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void InformationsForm_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_CalisanBilgiGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@calisan_id", LoginForm.loginEmployee_id.ToString());
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read()) // Veri varsa devam et
            {
                Employee_Homeland = reader["Homeland"].ToString();
                Employee_Department = reader["Department"].ToString();
                Employee_Education = reader["Education"].ToString();
            }

           
            conn.Close();


            empHomeland_lbl.Text = Employee_Homeland;
            empDepartment_lbl.Text = Employee_Department;
            empEducation_lbl.Text = Employee_Education;
        }



        
    }
}
