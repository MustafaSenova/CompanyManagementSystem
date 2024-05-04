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

using System.Configuration;
using System.Data.SqlClient;


using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.CompilerServices;
using System.Resources;
//using $safeprojectname$.Forms;
using System.Globalization;
using System.Diagnostics;
using $safeprojectname$.Forms;

namespace $safeprojectname$
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            if (LoginForm.tabEmp == false)
            {
                tabControl1.TabPages.Remove(tabPageEmployees);

            }

            if (LoginForm.tabCityCountry == false)
            {
                tabControl1.TabPages.Remove(tabPageCityCountry);

            }

            if (LoginForm.tabDeptEducation == false)
            {
                tabControl1.TabPages.Remove(tabPageDepartment);

            }

            if (LoginForm.tabCustomers == false)
            {
                tabControl1.TabPages.Remove(tabPageCustomers);

            }

            if (LoginForm.tabSales == false)
            {
                tabControl1.TabPages.Remove(tabPageSales);

            }

            if (LoginForm.tabProducts == false)
            {
                tabControl1.TabPages.Remove(tabPageProducts);

            }

            if (LoginForm.tabWarehouse == false)
            {
                tabControl1.TabPages.Remove(tabPageWarehouse);

            }

            if (LoginForm.tabSupply == false)
            {
                tabControl1.TabPages.Remove(tabPageSupply);

            }

            if (LoginForm.tabUsers == false)
            {
                tabControl1.TabPages.Remove(tabPageUsers);
                tabControl1.TabPages.Remove(tabPageLog);
                tabControl1.TabPages.Remove(tabPageAnalysis);

            }



            

        }

        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["connection_string"].ConnectionString);

        private void Form1_Load(object sender, EventArgs e)
        {
            home_emp_name.Text = LoginForm.loginEmployee_Name + " " + LoginForm.loginEmployee_Surname;



            education_update_btn.Hide();
            education_delete_btn.Hide();


            department_update_btn.Hide();
            department_delete_btn.Hide();

            city_update_btn.Hide();
            city_delete_btn.Hide();

            country_update_btn.Hide();
            country_delete_btn.Hide();

            datagrid_employees.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_employees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_employees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_city.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_city.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_city.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_country.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_country.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_country.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_department.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_department.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_department.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_education.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_education.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_education.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_customers.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_customers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_customers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_sales.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_sales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_sales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_product.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_product.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_warehouse.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_warehouse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_warehouse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_supply.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_supply.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_supply.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_users.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_users.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            datagrid_log.BackgroundColor = System.Drawing.SystemColors.Control;
            datagrid_log.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            datagrid_log.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGrid_maxCiro.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGrid_maxCiro.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid_maxCiro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGrid_MaasEgitim.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGrid_MaasEgitim.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid_MaasEgitim.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGrid_DepartmanCalisan.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGrid_DepartmanCalisan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid_DepartmanCalisan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            dataGrid_OrtalamaMaas.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGrid_OrtalamaMaas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGrid_OrtalamaMaas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            



        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            TabPage selectedPage = tabControl1.SelectedTab;

            if (selectedPage == tabPageHome)
            {

            }

            if (selectedPage == tabPageEmployees)
            {
                clear_employee();
                empUpdate_btn.Hide();
                empDelete_btn.Hide();

                show_employee();
                conn.Open();
                SqlCommand cmd1 = new SqlCommand("sp_MemleketGoster",conn);
                SqlCommand cmd2 = new SqlCommand("sp_DepartmanGoster", conn);
                SqlCommand cmd3 = new SqlCommand("sp_EgitimGoster",conn);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd3.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);


                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();

                ad1.Fill(dt1);
                ad2.Fill(dt2);
                ad3.Fill(dt3);


                empHomeland_cmb.DataSource = dt1;
                empDepartment_cmb.DataSource = dt2;
                empEducation_cmb.DataSource = dt3;


                empHomeland_cmb.DisplayMember = "City";
                empHomeland_cmb.ValueMember = "City ID";
                empHomeland_cmb.SelectedIndex = -1;

              
                empDepartment_cmb.DisplayMember = "Department";
                empDepartment_cmb.ValueMember = "Department ID";
                empDepartment_cmb.SelectedIndex = -1;

              
                empEducation_cmb.DisplayMember = "Education";
                empEducation_cmb.ValueMember = "Education ID";
                empEducation_cmb.SelectedIndex = -1;

                conn.Close();
            }

            if (selectedPage == tabPageCityCountry)
            {
                clear_country();
                clear_city();

                show_city();
                show_country();

                ulke_cbx_yenile();


            }

            if (selectedPage == tabPageDepartment)
            {
                clear_department();
                clear_education();

                show_department();
                show_education();
            }

            

            if (selectedPage == tabPageCustomers)
            {
                clear_customer();
                show_customer();
                customer_add_btn.Show();
                customer_update_btn.Hide();
                customer_delete_btn.Hide();

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MemleketGoster",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                customerCity_cbx.DataSource= dt;

                customerCity_cbx.DisplayMember = "City";
                customerCity_cbx.ValueMember = "City ID";
                customerCity_cbx.SelectedIndex = -1;

                conn.Close();
            }

            if (selectedPage == tabPageSales)
            {
                clear_sales();
                show_sales();

                sales_add_btn.Show();
                sales_update_btn.Hide();
                sales_delete_btn.Hide();

                conn.Open();
                SqlCommand cmd1 = new SqlCommand("sp_CalisanGoster", conn);
                SqlCommand cmd2 = new SqlCommand("sp_MusteriGoster", conn);
                SqlCommand cmd3 = new SqlCommand("sp_UrunGoster", conn);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd2.CommandType = CommandType.StoredProcedure;
                cmd3.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
                SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
                SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);


                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();

                ad1.Fill(dt1);
                ad2.Fill(dt2);
                ad3.Fill(dt3);


                sales_employee_cbx.DataSource = dt1;
                sales_customer_cbx.DataSource = dt2;
                sales_product_cbx.DataSource = dt3;


                sales_employee_cbx.DisplayMember = "Name";
                sales_employee_cbx.ValueMember = "Employee ID";
                sales_employee_cbx.SelectedIndex = -1;


                sales_customer_cbx.DisplayMember = "Name";
                sales_customer_cbx.ValueMember = "Customer ID";
                sales_customer_cbx.SelectedIndex = -1;


                sales_product_cbx.DisplayMember = "Product";
                sales_product_cbx.ValueMember = "Product ID";
                sales_product_cbx.SelectedIndex = -1;

                conn.Close();

            }

            if (selectedPage == tabPageProducts)
            {
                clear_product();
                show_product();
                product_add_btn.Show();
                product_delete_btn.Hide();
                product_update_btn.Hide();




            }

            if (selectedPage == tabPageWarehouse)
            { 
              
                show_stock();
                

                

            }

            if (selectedPage == tabPageSupply)
            {
                clear_supply();
                show_product();

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UrunGoster", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                supplyProduct_cmb.DataSource = dt;

                supplyProduct_cmb.DisplayMember = "Product";
                supplyProduct_cmb.ValueMember = "Product ID";
                supplyProduct_cmb.SelectedIndex = -1;

                conn.Close();

            }

            if (selectedPage == tabPageUsers)
            {

                show_users();
                clear_users();

                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_CalisanGoster",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                userEmployee_cbx.DataSource = dt;

                userEmployee_cbx.DisplayMember = "Name";
                userEmployee_cbx.ValueMember = "Employee ID";
                userEmployee_cbx.SelectedIndex = -1;

                conn.Close();
            
            }

            if (selectedPage == tabPageLog)
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_IslemLogGoster",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                ad.Fill(dt);

                datagrid_log.DataSource = dt;

                this.datagrid_log.Columns["Log ID"].Visible = false;


                conn.Close();

            }

            if (selectedPage == tabPageAnalysis)
            {

                showMaxCiro();
                showAnalizMaasEgitim();
                showAnalizDepartmanCalisan();
                showAnalizOrtalamaMaas();

            }



        }






        //Employee

        bool gender;

         private void empAdd_btn_Click(object sender, EventArgs e)
        {

            try
            {
                string emp = "";

                bool empName = false;
                bool empSurname = false;
                bool empAge = false;
                bool Ggender = false;
                bool empSalary = false;
                bool homeland = false;
                bool department = false;
                bool education = false;


                if (string.IsNullOrWhiteSpace(empName_txt.Text))
                {
                    empName = true;
                    emp += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(empSurname_txt.Text))
                {
                    empSurname = true;
                    emp += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(empAge_txt.Text))
                {
                    empAge = true;
                    emp += "Age\n";
                }

                if (empMale_rdbtn.Checked == false && empFemale_rdbtn.Checked == false)
                {
                    gender = true;
                    emp += "Gender\n";
                }

                if (string.IsNullOrWhiteSpace(empSalary_txt.Text))
                {
                    empSalary = true;
                    emp += "Salary\n";
                }

                if (string.IsNullOrWhiteSpace(empHomeland_cmb.Text))
                {
                    homeland = true;
                    emp += "Homeland\n";
                }

                if (string.IsNullOrWhiteSpace(empDepartment_cmb.Text))
                {
                    department = true;
                    emp += "Department\n";
                }

                if (string.IsNullOrWhiteSpace(empEducation_cmb.Text))
                {
                    education = true;
                    emp += "Education\n";
                }

                if (empName || empSurname || empAge || Ggender || empSalary || homeland || department || education)
                {
                    MessageBox.Show(emp + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CalisanEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_ad", empName_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_soyad", empSurname_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_yas", empAge_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_cinsiyet", gender);
                cmd.Parameters.AddWithValue("@calisan_maas", empSalary_txt.Text);
                cmd.Parameters.AddWithValue("@memleket_id", empHomeland_cmb.SelectedValue);
                cmd.Parameters.AddWithValue("@departman_id", empDepartment_cmb.SelectedValue);
                cmd.Parameters.AddWithValue("@egitim_id", empEducation_cmb.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee hired successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_employee();
                clear_employee();
            }

            catch
            {
                MessageBox.Show("An issue occurred while hiring the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();

            }


        }

        private void empDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string emp = "";

                bool empName = false;
                bool empSurname = false;
                bool empAge = false;
                bool Ggender = false;
                bool empSalary = false;
                bool homeland = false;
                bool department = false;
                bool education = false;


                if (string.IsNullOrWhiteSpace(empName_txt.Text))
                {
                    empName = true;
                    emp += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(empSurname_txt.Text))
                {
                    empSurname = true;
                    emp += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(empAge_txt.Text))
                {
                    empAge = true;
                    emp += "Age\n";
                }

                if (empMale_rdbtn.Checked == false && empFemale_rdbtn.Checked == false)
                {
                    Ggender = true;
                    emp += "Gender\n";
                }

                if (string.IsNullOrWhiteSpace(empSalary_txt.Text))
                {
                    empSalary = true;
                    emp += "Salary\n";
                }

                if (string.IsNullOrWhiteSpace(empHomeland_cmb.Text))
                {
                    homeland = true;
                    emp += "Homeland\n";
                }

                if (string.IsNullOrWhiteSpace(empDepartment_cmb.Text))
                {
                    department = true;
                    emp += "Department\n";
                }

                if (string.IsNullOrWhiteSpace(empEducation_cmb.Text))
                {
                    education = true;
                    emp += "Education\n";
                }

                if (empName || empSurname || empAge || Ggender || empSalary || homeland || department || education)
                {
                    MessageBox.Show(emp + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CalisanSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_id", empID_lbl.Text);  
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Employee fired successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_employee();
                clear_employee();
            }

            catch
            {
                MessageBox.Show("An issue occurred while firing the employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void empUpdate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string emp = "";

                bool empName = false;
                bool empSurname = false;
                bool empAge = false;
                bool Ggender = false;
                bool empSalary = false;
                bool homeland = false;
                bool department = false;
                bool education = false;


                if (string.IsNullOrWhiteSpace(empName_txt.Text))
                {
                    empName = true;
                    emp += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(empSurname_txt.Text))
                {
                    empSurname = true;
                    emp += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(empAge_txt.Text))
                {
                    empAge = true;
                    emp += "Age\n";
                }

                if (empMale_rdbtn.Checked == false && empFemale_rdbtn.Checked == false)
                {
                    Ggender = true;
                    emp += "Gender\n";
                }

                if (string.IsNullOrWhiteSpace(empSalary_txt.Text))
                {
                    empSalary = true;
                    emp += "Salary\n";
                }

                if (string.IsNullOrWhiteSpace(empHomeland_cmb.Text))
                {
                    homeland = true;
                    emp += "Homeland\n";
                }

                if (string.IsNullOrWhiteSpace(empDepartment_cmb.Text))
                {
                    department = true;
                    emp += "Department\n";
                }

                if (string.IsNullOrWhiteSpace(empEducation_cmb.Text))
                {
                    education = true;
                    emp += "Education\n";
                }

                if (empName || empSurname || empAge || Ggender || empSalary || homeland || department || education)
                {
                    MessageBox.Show(emp + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_CalisanGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_id", empID_lbl.Text);
                cmd.Parameters.AddWithValue("@calisan_ad", empName_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_soyad", empSurname_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_yas", empAge_txt.Text);
                cmd.Parameters.AddWithValue("@calisan_cinsiyet", gender);
                cmd.Parameters.AddWithValue("@calisan_maas", empSalary_txt.Text);
                cmd.Parameters.AddWithValue("@memleket_id", empHomeland_cmb.SelectedValue);
                cmd.Parameters.AddWithValue("@departman_id", empDepartment_cmb.SelectedValue);
                cmd.Parameters.AddWithValue("@egitim_id", empEducation_cmb.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("The employee's information has been successfully updated.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_employee();
                clear_employee();
            }

            catch
            {
                MessageBox.Show("An issue occurred while updating the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void empClear_btn_Click(object sender, EventArgs e)
        {
            clear_employee();
        }

        private void empMale_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = true;
        }

        private void empFemale_rdbtn_CheckedChanged(object sender, EventArgs e)
        {
            gender = false;
        }

        private void empName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void empSurname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void empAge_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                // only number 
            }
        }

        private void empSalary_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                // only number 
            }
        }

       

        private void datagrid_employees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            empID_lbl.Text = datagrid_employees.CurrentRow.Cells[0].Value.ToString();
            empName_txt.Text = datagrid_employees.CurrentRow.Cells[1].Value.ToString();
            empSurname_txt.Text = datagrid_employees.CurrentRow.Cells[2].Value.ToString();
            empAge_txt.Text = datagrid_employees.CurrentRow.Cells[3].Value.ToString();
            string c_cinsiyet = datagrid_employees.CurrentRow.Cells[4].Value.ToString();

            if (c_cinsiyet == "Male")
                empMale_rdbtn.Checked = true;

            else if (c_cinsiyet == "Female")
                empFemale_rdbtn.Checked=true;

            
            empSalary_txt.Text = datagrid_employees.CurrentRow.Cells[5].Value.ToString();
            empHomeland_cmb.Text = datagrid_employees.CurrentRow.Cells[6].Value.ToString();
            empDepartment_cmb.Text = datagrid_employees.CurrentRow.Cells[7].Value.ToString();
            empEducation_cmb.Text = datagrid_employees.CurrentRow.Cells[8].Value.ToString();

            if (empID_lbl.Text != "")
            {
                empAdd_btn.Hide();
                empUpdate_btn.Show();
                empDelete_btn.Show();
            }

        }

        public void show_employee()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_CalisanGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            datagrid_employees.DataSource = dt;
            this.datagrid_employees.Columns["Employee ID"].Visible = false;


            conn.Close();
        
        }

        public void clear_employee()
        {
            empID_lbl.Text = string.Empty;
            empName_txt.Clear();
            empSurname_txt.Clear();
            empAge_txt.Clear();
            empMale_rdbtn.Checked = false;
            empFemale_rdbtn.Checked = false;
            empSalary_txt.Clear();
            empHomeland_cmb.SelectedIndex = -1;
            empDepartment_cmb.SelectedIndex = -1;
            empEducation_cmb.SelectedIndex = -1;

            empAdd_btn.Show();
            empUpdate_btn.Hide();
            empDelete_btn.Hide();
        }

        //Employee






        //City 

        private void citycountry_city_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void city_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string city = "";

                bool cityName = false;
                bool country = false;
               


                if (string.IsNullOrWhiteSpace(citycountry_city_txt.Text))
                {
                    cityName = true;
                    city += "City\n";
                }

                if (string.IsNullOrWhiteSpace(citycountry_sol_country_cbx.Text))
                {
                    country = true;
                    city += "Country\n";
                }

                if (cityName || country)
                {
                    MessageBox.Show(city + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MemleketEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@memleket_ad", citycountry_city_txt.Text);
                cmd.Parameters.AddWithValue("@ulke_id", citycountry_sol_country_cbx.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("City added successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_city();
                clear_city();
            }
            catch
            {
                MessageBox.Show("An issue occurred while adding the city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void city_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string city = "";

                bool cityName = false;
                bool country = false;



                if (string.IsNullOrWhiteSpace(citycountry_city_txt.Text))
                {
                    cityName = true;
                    city += "City\n";
                }

                if (string.IsNullOrWhiteSpace(citycountry_sol_country_cbx.Text))
                {
                    country = true;
                    city += "Country\n";
                }

                if (cityName || country)
                {
                    MessageBox.Show(city + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MemleketSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@memleket_id", cityID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("City deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_city();
                clear_city();
            }
            catch
            {
                MessageBox.Show("An issue occurred while deleting the city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void city_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string city = "";

                bool cityName = false;
                bool country = false;



                if (string.IsNullOrWhiteSpace(citycountry_city_txt.Text))
                {
                    cityName = true;
                    city += "City\n";
                }

                if (string.IsNullOrWhiteSpace(citycountry_sol_country_cbx.Text))
                {
                    country = true;
                    city += "Country\n";
                }

                if (cityName || country)
                {
                    MessageBox.Show(city + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MemleketGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@memleket_id", cityID_lbl.Text);
                cmd.Parameters.AddWithValue("@memleket_ad", citycountry_city_txt.Text);
                cmd.Parameters.AddWithValue("@ulke_id", citycountry_sol_country_cbx.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("City updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_city();
                clear_city();

            }
            catch
            {
                MessageBox.Show("An issue occurred while updating the city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void city_clear_btn_Click(object sender, EventArgs e)
        {
            clear_city();
        }

        public void show_city()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_MemleketGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            datagrid_city.DataSource = dt;
            this.datagrid_city.Columns["City ID"].Visible = false;

            conn.Close();
        }

        public void clear_city()
        {
            cityID_lbl.Text = string.Empty;
            citycountry_city_txt.Clear();
            citycountry_sol_country_cbx.SelectedIndex = -1;

            city_add_btn.Show();
            city_delete_btn.Hide();
            city_update_btn.Hide();

        }

        private void datagrid_city_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cityID_lbl.Text = datagrid_city.CurrentRow.Cells[0].Value.ToString();
            citycountry_city_txt.Text = datagrid_city.CurrentRow.Cells[1].Value.ToString();
            citycountry_sol_country_cbx.Text = datagrid_city.CurrentRow.Cells[2].Value.ToString();

            if (cityID_lbl.Text != "")
            {
                city_add_btn.Hide();
                city_delete_btn.Show();
                city_update_btn.Show();
            }
        }

        //City 





        //Country


        public void ulke_cbx_yenile()
        {
            conn.Open();
            SqlCommand cmd1 = new SqlCommand("sp_UlkeGoster", conn);
            cmd1.CommandType = CommandType.StoredProcedure;

            DataTable dt1 = new DataTable();
            SqlDataAdapter ad1 = new SqlDataAdapter(cmd1);
            ad1.Fill(dt1);

            citycountry_sol_country_cbx.DataSource = dt1;

            citycountry_sol_country_cbx.DisplayMember = "Country";
            citycountry_sol_country_cbx.ValueMember = "Country ID";
            citycountry_sol_country_cbx.SelectedIndex = -1;
            conn.Close();
        }

        private void citycountry_sag_country_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void country_add_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                string country = "";

                bool countryName = false;



                if (string.IsNullOrWhiteSpace(citycountry_sag_country_txt.Text))
                {
                    countryName = true;
                    country += "Country\n";
                }


                if (countryName)
                {
                    MessageBox.Show(country + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UlkeEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@ulke_ad", citycountry_sag_country_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Country added successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_country();
                show_country();
                ulke_cbx_yenile();

            }
            catch 
            {
                MessageBox.Show("An issue occurred while adding the country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void country_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string country = "";

                bool countryName = false;



                if (string.IsNullOrWhiteSpace(citycountry_sag_country_txt.Text))
                {
                    countryName = true;
                    country += "Country\n";
                }


                if (countryName)
                {
                    MessageBox.Show(country + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UlkeSil",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@ulke_id", countryID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Country deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_country();
                show_country();
                ulke_cbx_yenile();

            }
            catch
            {
                MessageBox.Show("An issue occurred while deleting the country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void country_clear_btn_Click(object sender, EventArgs e)
        {
            clear_country();
        }

        private void country_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string country = "";

                bool countryName = false;



                if (string.IsNullOrWhiteSpace(citycountry_sag_country_txt.Text))
                {
                    countryName = true;
                    country += "Country\n";
                }


                if (countryName)
                {
                    MessageBox.Show(country + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UlkeGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@ulke_id", countryID_lbl.Text);
                cmd.Parameters.AddWithValue("@ulke_ad", citycountry_sag_country_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Country updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_country();
                show_country();
                ulke_cbx_yenile();

            }
            catch
            {
                MessageBox.Show("An issue occurred while updating the country.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        public void show_country()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_UlkeGoster",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            datagrid_country.DataSource = dt;
            this.datagrid_country.Columns["Country ID"].Visible = false;

            conn.Close();
        }

        public void clear_country()
        {
            countryID_lbl.Text = string.Empty;
            citycountry_sag_country_txt.Clear();

            country_add_btn.Show();
            country_update_btn.Hide();
            country_delete_btn.Hide();
        }

        private void datagrid_country_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            countryID_lbl.Text = datagrid_country.CurrentRow.Cells[0].Value.ToString();
            citycountry_sag_country_txt.Text = datagrid_country.CurrentRow.Cells[1].Value.ToString();

            if (countryID_lbl.Text != "")
            {
                country_add_btn.Hide();
                country_update_btn.Show();
                country_delete_btn.Show();
            }

        }

        //Country















        //Departments


        private void department_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void department_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string dept = "";

                bool deptName = false;



                if (string.IsNullOrWhiteSpace(department_txt.Text))
                {
                    deptName = true;
                    dept += "Department\n";
                }


                if (deptName)
                {
                    MessageBox.Show(dept + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DepartmanEkle",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@departman_ad", department_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_department();
                MessageBox.Show("Department added successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_department();

            }

            catch
            {
                MessageBox.Show("An issue occurred while adding the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            { 
                if(conn != null)
                    conn.Close();
            }



        }

        private void department_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string dept = "";

                bool deptName = false;



                if (string.IsNullOrWhiteSpace(department_txt.Text))
                {
                    deptName = true;
                    dept += "Department\n";
                }


                if (deptName)
                {
                    MessageBox.Show(dept + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DepartmanSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@departman_id", departmentID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_department();
                MessageBox.Show("Department deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_department();
            }

            catch 
            {
                MessageBox.Show("An issue occurred while deleting the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                if (conn != null)
                    conn.Close();
            }

        }

        private void department_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string dept = "";

                bool deptName = false;



                if (string.IsNullOrWhiteSpace(department_txt.Text))
                {
                    deptName = true;
                    dept += "Department\n";
                }


                if (deptName)
                {
                    MessageBox.Show(dept + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_DepartmanGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@departman_id", departmentID_lbl.Text);
                cmd.Parameters.AddWithValue("@departman_ad", department_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_department();
                MessageBox.Show("Department updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_department();
            }

            catch
            {
                MessageBox.Show("An issue occurred while updating the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void department_clear_btn_Click(object sender, EventArgs e)
        {
            clear_department();
        }

        public void show_department()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_DepartmanGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            datagrid_department.DataSource = dt;
            this.datagrid_department.Columns["Department ID"].Visible = false;

            conn.Close();
        
        }

        public void clear_department()
        {
            departmentID_lbl.Text = string.Empty;
            department_txt.Clear();

            department_add_btn.Show();
            department_delete_btn.Hide();
            department_update_btn.Hide();
        }

        private void datagrid_department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            departmentID_lbl.Text = datagrid_department.CurrentRow.Cells[0].Value.ToString();
            department_txt.Text = datagrid_department.CurrentRow.Cells[1].Value.ToString();

            if (departmentID_lbl.Text != "")
            {
                department_add_btn.Hide();
                department_delete_btn.Show();
                department_update_btn.Show();


            }

        }

        //Departments




        //Education

        private void education_add_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string edct = "";

                bool educationName = false;



                if (string.IsNullOrWhiteSpace(education_txt.Text))
                {
                    educationName = true;
                    edct += "Education\n";
                }


                if (educationName)
                {
                    MessageBox.Show(edct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EgitimEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@egitim_durum", education_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_education();
                MessageBox.Show("Education status added successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_education();

            }

            catch
            {
                MessageBox.Show("An issue occurred while adding the education level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void education_update_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string edct = "";

                bool educationName = false;



                if (string.IsNullOrWhiteSpace(education_txt.Text))
                {
                    educationName = true;
                    edct += "Education\n";
                }


                if (educationName)
                {
                    MessageBox.Show(edct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EgitimGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@egitim_id", educationID_lbl.Text); //KONTROL ET
                cmd.Parameters.AddWithValue("@egitim_durum", education_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_education();
                MessageBox.Show("Education status updated successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_education();
            }

            catch
            {
                MessageBox.Show("An issue occurred while updating the education level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally 
            { 
                if(conn != null)
                    conn.Close();
            }
        }

        private void education_delete_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string edct = "";

                bool educationName = false;



                if (string.IsNullOrWhiteSpace(education_txt.Text))
                {
                    educationName = true;
                    edct += "Education\n";
                }


                if (educationName)
                {
                    MessageBox.Show(edct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_EgitimSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@egitim_id", educationID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                show_education();
                MessageBox.Show("Education status deleted successfully", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_education();

            }

            catch
            {
                MessageBox.Show("An issue occurred while deleting the education level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void education_clear_btn_Click_1(object sender, EventArgs e)
        {
            clear_education();
        }

        private void education_txt_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }


        private void education_clear_btn_Click(object sender, EventArgs e)
        {
            clear_education();
        }

        public void show_education()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_EgitimGoster",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            datagrid_education.DataSource = dt;
            this.datagrid_education.Columns["Education ID"].Visible = false;


            conn.Close();
        }

        private void datagrid_education_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            educationID_lbl.Text = datagrid_education.CurrentRow.Cells[0].Value.ToString();
            education_txt.Text = datagrid_education.CurrentRow.Cells[1].Value.ToString();

            if (educationID_lbl.Text != "")
            {
                education_add_btn.Hide();
                education_update_btn.Show();
                education_delete_btn.Show();
            }
        }

        public void clear_education()
        {
            educationID_lbl.Text = string.Empty;
            education_txt.Clear();

            education_add_btn.Show();
            education_update_btn.Hide();
            education_delete_btn.Hide();

        }


        //Education






        //Customer

        private void customer_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string cst = "";

                bool cName = false;
                bool cSurname = false;
                bool cMail = false;
                bool cPhone = false;
                bool cAddress = false;
                bool cHomeland = false;
             


                if (string.IsNullOrWhiteSpace(customerName_txt.Text))
                {
                    cName = true;
                    cst += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(customerSurname_txt.Text))
                {
                    cSurname = true;
                    cst += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(customerMail_txt.Text))
                {
                    cMail = true;
                    cst += "E-Mail Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCellphone_txt.Text))
                {
                    cPhone = true;
                    cst += "Cell Phone\n";
                }

                if (string.IsNullOrWhiteSpace(customerAddress_txt.Text))
                {
                    cAddress = true;
                    cst += "Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCity_cbx.Text))
                {
                    cHomeland = true;
                    cst += "City\n";
                }


                if (cName || cSurname || cMail || cPhone || cAddress || cHomeland )
                {
                    MessageBox.Show(cst + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MusteriEkle",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@musteri_ad", customerName_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_soyad", customerSurname_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_mail", customerMail_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_telefon", customerCellphone_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_adres", customerAddress_txt.Text);
                cmd.Parameters.AddWithValue("@memleket_ID", customerCity_cbx.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer added successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_customer();
                show_customer();
                
            }

            catch 
            {
                MessageBox.Show("An issue occurred while adding the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally 
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void customer_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string cst = "";

                bool cName = false;
                bool cSurname = false;
                bool cMail = false;
                bool cPhone = false;
                bool cAddress = false;
                bool cHomeland = false;



                if (string.IsNullOrWhiteSpace(customerName_txt.Text))
                {
                    cName = true;
                    cst += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(customerSurname_txt.Text))
                {
                    cSurname = true;
                    cst += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(customerMail_txt.Text))
                {
                    cMail = true;
                    cst += "E-Mail Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCellphone_txt.Text))
                {
                    cPhone = true;
                    cst += "Cell Phone\n";
                }

                if (string.IsNullOrWhiteSpace(customerAddress_txt.Text))
                {
                    cAddress = true;
                    cst += "Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCity_cbx.Text))
                {
                    cHomeland = true;
                    cst += "City\n";
                }


                if (cName || cSurname || cMail || cPhone || cAddress || cHomeland)
                {
                    MessageBox.Show(cst + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MusteriSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@musteri_id", customerID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_customer();
                show_customer();
            }

            catch
            {
                MessageBox.Show("An issue occurred while deleting the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void customer_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string cst = "";

                bool cName = false;
                bool cSurname = false;
                bool cMail = false;
                bool cPhone = false;
                bool cAddress = false;
                bool cHomeland = false;



                if (string.IsNullOrWhiteSpace(customerName_txt.Text))
                {
                    cName = true;
                    cst += "Name\n";
                }

                if (string.IsNullOrWhiteSpace(customerSurname_txt.Text))
                {
                    cSurname = true;
                    cst += "Surname\n";
                }

                if (string.IsNullOrWhiteSpace(customerMail_txt.Text))
                {
                    cMail = true;
                    cst += "E-Mail Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCellphone_txt.Text))
                {
                    cPhone = true;
                    cst += "Cell Phone\n";
                }

                if (string.IsNullOrWhiteSpace(customerAddress_txt.Text))
                {
                    cAddress = true;
                    cst += "Address\n";
                }

                if (string.IsNullOrWhiteSpace(customerCity_cbx.Text))
                {
                    cHomeland = true;
                    cst += "City\n";
                }


                if (cName || cSurname || cMail || cPhone || cAddress || cHomeland)
                {
                    MessageBox.Show(cst + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_MusteriGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@musteri_id", customerID_lbl.Text);
                cmd.Parameters.AddWithValue("@musteri_ad", customerName_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_soyad", customerSurname_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_mail", customerMail_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_telefon", customerCellphone_txt.Text);
                cmd.Parameters.AddWithValue("@musteri_adres", customerAddress_txt.Text);
                cmd.Parameters.AddWithValue("@memleket_ID", customerCity_cbx.SelectedValue);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Customer updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_customer();
                show_customer();
            }

            catch
            {
                MessageBox.Show("An issue occurred while updating the customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void customer_clear_btn_Click(object sender, EventArgs e)
        {
            clear_customer();
        }

        private void customerName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void customerSurname_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                //only letter

            }
        }

        private void customerMail_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void customerCellphone_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                // only number 
            }
        }

        private void customerAddress_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void show_customer()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_MusteriGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            datagrid_customers.DataSource = dt;
            this.datagrid_customers.Columns["Customer ID"].Visible = false;

            conn.Close();
        
        }

        private void datagrid_customers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerID_lbl.Text = datagrid_customers.CurrentRow.Cells[0].Value.ToString();
            customerName_txt.Text = datagrid_customers.CurrentRow.Cells[1].Value.ToString();
            customerSurname_txt.Text = datagrid_customers.CurrentRow.Cells[2].Value.ToString();
            customerMail_txt.Text = datagrid_customers.CurrentRow.Cells[3].Value.ToString();
            customerCellphone_txt.Text = datagrid_customers.CurrentRow.Cells[4].Value.ToString();
            customerAddress_txt.Text = datagrid_customers.CurrentRow.Cells[5].Value.ToString();
            customerCity_cbx.Text = datagrid_customers.CurrentRow.Cells[6].Value.ToString();

            if (customerID_lbl.Text != "")
            {
                customer_add_btn.Hide();
                customer_update_btn.Show();
                customer_delete_btn.Show();
            }

        }

        public void clear_customer()
        {
            customerID_lbl.Text = string.Empty;
            customerName_txt.Clear();
            customerSurname_txt.Clear();
            customerMail_txt.Clear();
            customerCellphone_txt.Clear();
            customerAddress_txt.Clear();
            customerCity_cbx.SelectedIndex = -1;

            customer_add_btn.Show();
            customer_update_btn.Hide();
            customer_delete_btn.Hide();
        }

        //Customer





        //Sales


        private void sales_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sls = "";

                bool cEmp = false;
                bool cCustomer = false;
                bool cProduct = false;
                bool cQuantity = false;


                if (string.IsNullOrWhiteSpace(sales_employee_cbx.Text))
                {
                    cEmp = true;
                    sls += "Employee\n";
                }

                if (string.IsNullOrWhiteSpace(sales_customer_cbx.Text))
                {
                    cCustomer = true;
                    sls += "Customer\n";
                }

                if (string.IsNullOrWhiteSpace(sales_product_cbx.Text))
                {
                    cProduct = true;
                    sls += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(sales_quantity_txt.Text))
                {
                    cQuantity = true;
                    sls += "Product Quantity\n";
                }

                if (cEmp || cCustomer || cProduct || cQuantity)
                {
                    MessageBox.Show(sls + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SatisEkle",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_ID", sales_employee_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@musteri_ID", sales_customer_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_ID", sales_product_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_miktari", sales_quantity_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("The sale was completed successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_sales();
                clear_sales();
            }
            catch
            {
                MessageBox.Show("There was a problem while making the sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void sales_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sls = "";

                bool cEmp = false;
                bool cCustomer = false;
                bool cProduct = false;
                bool cQuantity = false;


                if (string.IsNullOrWhiteSpace(sales_employee_cbx.Text))
                {
                    cEmp = true;
                    sls += "Employee\n";
                }

                if (string.IsNullOrWhiteSpace(sales_customer_cbx.Text))
                {
                    cCustomer = true;
                    sls += "Customer\n";
                }

                if (string.IsNullOrWhiteSpace(sales_product_cbx.Text))
                {
                    cProduct = true;
                    sls += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(sales_quantity_txt.Text))
                {
                    cQuantity = true;
                    sls += "Product Quantity\n";
                }

                if (cEmp || cCustomer || cProduct || cQuantity)
                {
                    MessageBox.Show(sls + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SatisSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_ID", sales_employee_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@musteri_ID", sales_customer_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_ID", sales_product_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_miktari", sales_quantity_txt.Text);
                cmd.Parameters.AddWithValue("@satis_id", salesID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("The sale deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_sales();
                clear_sales();
            }
            catch
            {
                MessageBox.Show("There was a problem while deleting the sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void sales_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sls = "";

                bool satis_id = false;
                bool cEmp = false;
                bool cCustomer = false;
                bool cProduct = false;
                bool cQuantity = false;

                if (string.IsNullOrWhiteSpace(salesID_lbl.Text))
                {
                    satis_id = true;
                    sls += "Sales ID\n";
                }

                if (string.IsNullOrWhiteSpace(sales_employee_cbx.Text))
                {
                    cEmp = true;
                    sls += "Employee\n";
                }

                if (string.IsNullOrWhiteSpace(sales_customer_cbx.Text))
                {
                    cCustomer = true;
                    sls += "Customer\n";
                }

                if (string.IsNullOrWhiteSpace(sales_product_cbx.Text))
                {
                    cProduct = true;
                    sls += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(sales_quantity_txt.Text))
                {
                    cQuantity = true;
                    sls += "Product Quantity\n";
                }

                if (satis_id || cEmp || cCustomer || cProduct || cQuantity)
                {
                    MessageBox.Show(sls + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_SatisGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@satis_id", salesID_lbl.Text);
                cmd.Parameters.AddWithValue("@calisan_ID", sales_employee_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@musteri_ID", sales_customer_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_ID", sales_product_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@urun_miktari", sales_quantity_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("The sale updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_sales();
                clear_sales();
            }
            catch
            {
                MessageBox.Show("There was a problem while updating the sale.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void sales_clear_btn_Click(object sender, EventArgs e)
        {
            clear_sales();
        }

        public void clear_sales()
        {
            salesID_lbl.Text = string.Empty;
            sales_employee_cbx.SelectedIndex = -1;
            sales_customer_cbx.SelectedIndex = -1;
            sales_product_cbx.SelectedIndex = -1;
            sales_quantity_txt.Clear();

            sales_add_btn.Show();
            sales_update_btn.Hide();
            sales_delete_btn.Hide();

        }

        public void show_sales()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_SatisGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            datagrid_sales.DataSource = dt;
            this.datagrid_sales.Columns["Sales ID"].Visible = false;


            conn.Close();
        }

        private void datagrid_sales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            salesID_lbl.Text = datagrid_sales.CurrentRow.Cells[0].Value.ToString();
            sales_employee_cbx.Text = datagrid_sales.CurrentRow.Cells[1].Value.ToString();
            sales_customer_cbx.Text = datagrid_sales.CurrentRow.Cells[2].Value.ToString();
            sales_product_cbx.Text = datagrid_sales.CurrentRow.Cells[3].Value.ToString();
            sales_quantity_txt.Text = datagrid_sales.CurrentRow.Cells[4].Value.ToString();

            if (salesID_lbl.Text != "")
            {
                sales_add_btn.Hide();
                sales_update_btn.Show();
                sales_delete_btn.Show();
            }

        }


        private void sales_quantity_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
                // Sadece rakam veya '-' karakteri kabul edilir
            }

        }







        //Sales






        //Product

        private void product_add_btn_Click(object sender, EventArgs e)
        {
            try 
            {
                string prdct = "";

                bool productName = false;
                bool productSize = false;
                bool productDesc = false;
                bool productPrice = false;



                if (string.IsNullOrWhiteSpace(productName_txt.Text))
                {
                    productName = true;
                    prdct += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(productSize_txt.Text))
                {
                    productSize = true;
                    prdct += "Product Size\n";
                }

                if (string.IsNullOrWhiteSpace(productDesc_txt.Text))
                {
                    productDesc = true;
                    prdct += "Product Description\n";
                }

                if (string.IsNullOrWhiteSpace(productPrice_txt.Text))
                {
                    productPrice = true;
                    prdct += "Product Price\n";
                }


                if (productName || productSize || productDesc || productPrice)
                {
                    MessageBox.Show(prdct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UrunEkle",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@urun_ad", productName_txt.Text);
                cmd.Parameters.AddWithValue("@urun_ebat", productSize_txt.Text);
                cmd.Parameters.AddWithValue("@urun_aciklama", productDesc_txt.Text);
                cmd.Parameters.AddWithValue("@urun_fiyat", productPrice_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product added successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_product();
                show_product();

            }
            catch
            {
                MessageBox.Show("An issue occurred while adding the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();
            
            }
        }

        private void product_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string prdct = "";

                bool productName = false;
                bool productSize = false;
                bool productDesc = false;
                bool productPrice = false;



                if (string.IsNullOrWhiteSpace(productName_txt.Text))
                {
                    productName = true;
                    prdct += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(productSize_txt.Text))
                {
                    productSize = true;
                    prdct += "Product Size\n";
                }

                if (string.IsNullOrWhiteSpace(productDesc_txt.Text))
                {
                    productDesc = true;
                    prdct += "Product Description\n";
                }

                if (string.IsNullOrWhiteSpace(productPrice_txt.Text))
                {
                    productPrice = true;
                    prdct += "Product Price\n";
                }


                if (productName || productSize || productDesc || productPrice)
                {
                    MessageBox.Show(prdct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UrunSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@urun_id", productID_lbl.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_product();
                show_product();

            }
            catch
            {
                MessageBox.Show("An issue occurred while deleting the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void product_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string prdct = "";

                bool productName = false;
                bool productSize = false;
                bool productDesc = false;
                bool productPrice = false;



                if (string.IsNullOrWhiteSpace(productName_txt.Text))
                {
                    productName = true;
                    prdct += "Product\n";
                }

                if (string.IsNullOrWhiteSpace(productSize_txt.Text))
                {
                    productSize = true;
                    prdct += "Product Size\n";
                }

                if (string.IsNullOrWhiteSpace(productDesc_txt.Text))
                {
                    productDesc = true;
                    prdct += "Product Description\n";
                }

                if (string.IsNullOrWhiteSpace(productPrice_txt.Text))
                {
                    productPrice = true;
                    prdct += "Product Price\n";
                }


                if (productName || productSize || productDesc || productPrice)
                {
                    MessageBox.Show(prdct + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_UrunGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@urun_id", productID_lbl.Text);
                cmd.Parameters.AddWithValue("@urun_ad", productName_txt.Text);
                cmd.Parameters.AddWithValue("@urun_ebat", productSize_txt.Text);
                cmd.Parameters.AddWithValue("@urun_aciklama", productDesc_txt.Text);
                cmd.Parameters.AddWithValue("@urun_fiyat", productPrice_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Product updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear_product();
                show_product();

            }
            catch
            {
                MessageBox.Show("An issue occurred while updating the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

        private void product_clear_btn_Click(object sender, EventArgs e)
        {
            clear_product();
        }

        public void show_product()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_UrunGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            datagrid_product.DataSource = dt;
            datagrid_supply.DataSource = dt;

            this.datagrid_product.Columns["Product ID"].Visible = false;
            this.datagrid_supply.Columns["Product ID"].Visible = false;

            conn.Close();
        }

        public void clear_product()
        {
            productID_lbl.Text = string.Empty;
            productName_txt.Clear();
            productSize_txt.Clear();
            productDesc_txt.Clear();
            productPrice_txt.Clear();

            product_add_btn.Show();
            product_delete_btn.Hide();
            product_update_btn.Hide();


        }
        private void datagrid_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            productID_lbl.Text = datagrid_product.CurrentRow.Cells[0].Value.ToString();
            productName_txt.Text = datagrid_product.CurrentRow.Cells[1].Value.ToString();
            productSize_txt.Text = datagrid_product.CurrentRow.Cells[2].Value.ToString();
            productDesc_txt.Text = datagrid_product.CurrentRow.Cells[3].Value.ToString();
            productPrice_txt.Text = datagrid_product.CurrentRow.Cells[4].Value.ToString();

            if (productID_lbl.Text != "")
            {
                product_add_btn.Hide();
                product_delete_btn.Show();
                product_update_btn.Show();
            }


        }

        private void productName_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void productSize_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void productDesc_txt_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void productPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                // only number 
            }
        }






        //Warehouse

        public void show_stock()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_StokGoster",conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            datagrid_warehouse.DataSource = dt;
            this.datagrid_warehouse.Columns["Product ID"].Visible = false;

            conn.Close();
        }

        private void datagrid_warehouse_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            warehouseStockID_lbl.Text = datagrid_warehouse.CurrentRow.Cells[0].Value.ToString();
            warehouseProduct_lbl.Text = datagrid_warehouse.CurrentRow.Cells[1].Value.ToString();
            warehouseProductSize_lbl.Text = datagrid_warehouse.CurrentRow.Cells[2].Value.ToString();
            warehouseStockQuantity_lbl.Text = datagrid_warehouse.CurrentRow.Cells[3].Value.ToString();

        }

        private void warehouse_clear_btn_Click(object sender, EventArgs e)
        {
            warehouseStockID_lbl.Text = string.Empty;
            warehouseProduct_lbl.Text = string.Empty;
            warehouseProductSize_lbl.Text = string.Empty;
            warehouseStockQuantity_lbl.Text = string.Empty;

        }


        //Warehouse












        //Supply

       
        private void supply_add_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string spply = "";

                bool supplyProduct = false;
                bool supplyQuantity = false;


                if (string.IsNullOrWhiteSpace(supplyProduct_cmb.Text))
                {
                    supplyProduct = true;
                    spply += "Product Name\n";
                }

                if (string.IsNullOrWhiteSpace(supplyQuantity_txt.Text))
                {
                    supplyQuantity = true;
                    spply += "Product Quantity\n";
                }

                if (supplyProduct || supplyQuantity)
                {
                    MessageBox.Show(spply + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_TedarikEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@urun_ID", supplyProduct_cmb.SelectedValue);
                cmd.Parameters.AddWithValue("@tedarik_miktari", supplyQuantity_txt.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Supply added to the warehouse successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //clear_product();
                clear_supply();
                show_product();

            }
            catch
            {
                MessageBox.Show("An issue occurred while adding the supply.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if (conn != null)
                    conn.Close();

            }
        }

   
        private void supply_clear_btn_Click(object sender, EventArgs e)
        {
            clear_supply();
        }


        private void datagrid_supply_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            supplyID_lbl.Text = datagrid_supply.CurrentRow.Cells[0].Value.ToString();
            supplyProduct_cmb.Text = datagrid_supply.CurrentRow.Cells[1].Value.ToString();
            //supplyQuantity_txt.Text = datagrid_supply.CurrentRow.Cells[2].Value.ToString();
        }

        public void clear_supply()
        {
            supplyID_lbl.Text = string.Empty;
            supplyProduct_cmb.SelectedIndex = -1;
            supplyQuantity_txt.Clear();
        }





        //Supply


        //Users


        private void user_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string usrs = "";

                bool userEmployee = false;
                bool userUsername = false;
                bool userPassword = false;
                bool userSecurity = false;


                if (string.IsNullOrWhiteSpace(userEmployee_cbx.Text))
                {
                    userEmployee = true;
                    usrs += "Employee Name\n";
                }

                if (string.IsNullOrWhiteSpace(userUsername_txt.Text))
                {
                    userUsername = true;
                    usrs += "Username\n";
                }

                if (string.IsNullOrWhiteSpace(userPassword_txt.Text))
                {
                    userPassword = true;
                    usrs += "Password\n";
                }

                if (string.IsNullOrWhiteSpace(userSecurity_txt.Text))
                {
                    userSecurity = true;
                    usrs += "Security Question\n";
                }

                if (userEmployee || userUsername || userPassword || userSecurity)
                {
                    MessageBox.Show(usrs + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_KullaniciEkle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@islemi_yapan_kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@calisan_ID", userEmployee_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@kullanici_ad", userUsername_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_sifre", userPassword_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_guvenlik", userSecurity_txt.Text);

                cmd.Parameters.AddWithValue("@calisanlar", cBoxEmployee.Checked);
                cmd.Parameters.AddWithValue("@sehirUlke", cBoxCityCountry.Checked);
                cmd.Parameters.AddWithValue("@departmanlar", cBoxDepartment.Checked);

                cmd.Parameters.AddWithValue("@egitim", cBoxEducation.Checked); 
                cmd.Parameters.AddWithValue("@musteriler", cBoxCustomers.Checked);
                cmd.Parameters.AddWithValue("@satislar", cBoxSales.Checked);
                cmd.Parameters.AddWithValue("@urunler", cBoxProducts.Checked);

                cmd.Parameters.AddWithValue("@stoklar",cBoxWarehouse.Checked);
                cmd.Parameters.AddWithValue("@tedarik", cBoxSupply.Checked);
                cmd.Parameters.AddWithValue("@kullanicilar", cBoxUsers.Checked);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("User created successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_users();
                clear_users();


            }
            catch 
            {
                MessageBox.Show("An issue occurred while creating the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally 
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void user_update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string usrs = "";

                bool userIDid = false;
                bool userEmployee = false;
                bool userUsername = false;
                bool userPassword = false;
                bool userSecurity = false;

                if (string.IsNullOrWhiteSpace(userID_lbl.Text))
                {
                    userIDid = true;
                    usrs += "User ID\n";
                }

                if (string.IsNullOrWhiteSpace(userEmployee_cbx.Text))
                {
                    userEmployee = true;
                    usrs += "Employee Name\n";
                }

                if (string.IsNullOrWhiteSpace(userUsername_txt.Text))
                {
                    userUsername = true;
                    usrs += "Username\n";
                }

                if (string.IsNullOrWhiteSpace(userPassword_txt.Text))
                {
                    userPassword = true;
                    usrs += "Password\n";
                }

                if (string.IsNullOrWhiteSpace(userSecurity_txt.Text))
                {
                    userSecurity = true;
                    usrs += "Security Question\n";
                }

                if (userIDid || userEmployee || userUsername || userPassword || userSecurity)
                {
                    MessageBox.Show(usrs + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_KullaniciGuncelle", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@islemi_yapan_kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@kullanici_id", userID_lbl.Text);
                cmd.Parameters.AddWithValue("@calisan_ID", userEmployee_cbx.SelectedValue);
                cmd.Parameters.AddWithValue("@kullanici_ad", userUsername_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_sifre", userPassword_txt.Text);
                cmd.Parameters.AddWithValue("@kullanici_guvenlik", userSecurity_txt.Text);

                cmd.Parameters.AddWithValue("@calisanlar", cBoxEmployee.Checked);
                cmd.Parameters.AddWithValue("@sehirUlke", cBoxCityCountry.Checked);
                cmd.Parameters.AddWithValue("@departmanlar", cBoxDepartment.Checked);

                cmd.Parameters.AddWithValue("@egitim", cBoxEducation.Checked);
                cmd.Parameters.AddWithValue("@musteriler", cBoxCustomers.Checked);
                cmd.Parameters.AddWithValue("@satislar", cBoxSales.Checked);
                cmd.Parameters.AddWithValue("@urunler", cBoxProducts.Checked);

                cmd.Parameters.AddWithValue("@stoklar", cBoxWarehouse.Checked);
                cmd.Parameters.AddWithValue("@tedarik", cBoxSupply.Checked);
                cmd.Parameters.AddWithValue("@kullanicilar", cBoxUsers.Checked);
                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("User updated successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_users();
                clear_users();


            }
            catch
            {
                MessageBox.Show("A user with the specified ID already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void user_delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string usrs = "";

                bool userIDid = false;
                bool userEmployee = false;
                bool userUsername = false;
                bool userPassword = false;
                bool userSecurity = false;

                if (string.IsNullOrWhiteSpace(userID_lbl.Text))
                {
                    userIDid = true;
                    usrs += "User ID\n";
                }

                if (string.IsNullOrWhiteSpace(userEmployee_cbx.Text))
                {
                    userEmployee = true;
                    usrs += "Employee Name\n";
                }

                if (string.IsNullOrWhiteSpace(userUsername_txt.Text))
                {
                    userUsername = true;
                    usrs += "Username\n";
                }

                if (string.IsNullOrWhiteSpace(userPassword_txt.Text))
                {
                    userPassword = true;
                    usrs += "Password\n";
                }

                if (string.IsNullOrWhiteSpace(userSecurity_txt.Text))
                {
                    userSecurity = true;
                    usrs += "Security Question\n";
                }

                if (userIDid || userEmployee || userUsername || userPassword || userSecurity)
                {
                    MessageBox.Show(usrs + "\nPlease Enter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                conn.Open();

                SqlCommand cmd = new SqlCommand("sp_KullaniciSil", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@islemi_yapan_kullanici_ad", LoginForm.loginEmployeeUsername);
                cmd.Parameters.AddWithValue("@kullanici_id", userID_lbl.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                MessageBox.Show("User deleted successfully.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                show_users();
                clear_users();


            }
            catch
            {
                MessageBox.Show("An issue occurred while deleting the user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        private void user_clear_btn_Click(object sender, EventArgs e)
        {
            clear_users();
        }

        public void clear_users()
        {
            user_add_btn.Show();
            user_update_btn.Hide();
            user_delete_btn.Hide();

            userID_lbl.Text = string.Empty;
            userEmployee_cbx.SelectedIndex = -1;
            userUsername_txt.Clear();
            userPassword_txt.Clear();
            userSecurity_txt.Clear();

            cBoxEmployee.Checked = false;
            cBoxCityCountry.Checked = false;
            cBoxDepartment.Checked = false;
            cBoxEducation.Checked = false;
            cBoxCustomers.Checked = false;
            cBoxSales.Checked = false;
            cBoxProducts.Checked = false;
            cBoxWarehouse.Checked = false;
            cBoxSupply.Checked = false;
            cBoxUsers.Checked = false;


        }
        public void show_users()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_KullaniciGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            datagrid_users.DataSource = dt;
            this.datagrid_users.Columns["User ID"].Visible = false;


            conn.Close();

        }

        private void datagrid_users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userID_lbl.Text = datagrid_users.CurrentRow.Cells[0].Value.ToString();
            userEmployee_cbx.Text = datagrid_users.CurrentRow.Cells[1].Value.ToString();
            userUsername_txt.Text = datagrid_users.CurrentRow.Cells[2].Value.ToString();
            userPassword_txt.Text = datagrid_users.CurrentRow.Cells[3].Value.ToString();
            userSecurity_txt.Text = datagrid_users.CurrentRow.Cells[4].Value.ToString();

            cBoxEmployee.Checked = datagrid_users.CurrentRow.Cells[5].Value.ToString() == "True";
            cBoxCityCountry.Checked = datagrid_users.CurrentRow.Cells[6].Value.ToString() == "True";
            cBoxDepartment.Checked = datagrid_users.CurrentRow.Cells[7].Value.ToString() == "True";
            cBoxEducation.Checked = datagrid_users.CurrentRow.Cells[8].Value.ToString() == "True";
            cBoxCustomers.Checked = datagrid_users.CurrentRow.Cells[9].Value.ToString() == "True";
            cBoxSales.Checked = datagrid_users.CurrentRow.Cells[10].Value.ToString() == "True";
            cBoxProducts.Checked = datagrid_users.CurrentRow.Cells[11].Value.ToString() == "True";
            cBoxWarehouse.Checked = datagrid_users.CurrentRow.Cells[12].Value.ToString() == "True";
            cBoxSupply.Checked = datagrid_users.CurrentRow.Cells[13].Value.ToString() == "True";
            cBoxUsers.Checked = datagrid_users.CurrentRow.Cells[14].Value.ToString() == "True";

            if (userID_lbl.Text != "")
            {
                user_add_btn.Hide();
                user_update_btn.Show();
                user_delete_btn.Show();
            }

        }
        //


        //Analysis

        public void showMaxCiro()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_MaxSatisGoster", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            dataGrid_maxCiro.DataSource = dt;

            conn.Close();
        }

        public void showAnalizMaasEgitim()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_AnalizMaasEgitim", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            dataGrid_MaasEgitim.DataSource = dt;

            conn.Close();
        }


        public void showAnalizDepartmanCalisan()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_DepartmanCalisanAdet", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            dataGrid_DepartmanCalisan.DataSource = dt;

            conn.Close();
        }

        public void showAnalizOrtalamaMaas()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("sp_AnalizMaas", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            ad.Fill(dt);

            dataGrid_OrtalamaMaas.DataSource = dt;

            conn.Close();
        }



        //Analysis






        private void logOut_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.Show();
        }

        private void home_myInformations_btn_Click(object sender, EventArgs e)
        {
            InformationsForm informationsForm = new InformationsForm();
            this.Hide();
            informationsForm.Show();
        }

        
    }
}
