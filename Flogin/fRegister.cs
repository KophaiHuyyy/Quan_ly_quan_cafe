﻿using System;
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
    public partial class fRegister : Form
    {
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=CoffeeManagement;Integrated Security=True;";
        SqlConnection sqlCon = null;
        public fRegister()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string name = txtUsername.Text;
            string password = txtPassword.Text;
            int sdt = int.Parse(txtPhone.Text);
            string email = txtEmail.Text;

            //Kiểm tra nhập lại mật khẩu
            if (password != txtConfirmPas.Text)
            {
                MessageBox.Show("Mật khẩu và Nhập lại mật khẩu không khớp!");
            }

            try
            {
                string query = "INSERT INTO nguoidung (name, sdt, email, password) VALUES (@name, @sdt, @email, @password)";
                SqlCommand cmd = new SqlCommand(query, sqlCon);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);


                int rowAffected = cmd.ExecuteNonQuery();
                if (rowAffected > 0)
                {
                    MessageBox.Show("Đăng ký thành công!");
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login o = new Login();
            this.Hide();
            o.ShowDialog();
            this.Show();
        }
    }
}
