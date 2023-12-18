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

namespace Flogin
{
    public partial class Login : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True;";
        SqlConnection sqlCon = null;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            //Xác nhận lại mật khẩu.
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu");
            }
            try
            {
                string query = "SELECT COUNT(*) FROM nguoidung WHERE email = @email AND password = @password";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                int userCount = (int)cmd.ExecuteScalar();
                // userCount chứa giá trị trả về từ câu lệnh SELECT
                if (userCount > 0)
                {
                    MessageBox.Show("Đăng nhập thành công!");
                    Fmain f = new Fmain();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công. Kiểm tra lại thông tin đăng nhập.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            fRegister r = new fRegister();
            this.Hide();
            r.ShowDialog();
            this.Show();
        }
    }
}
