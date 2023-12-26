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

namespace Flogin
{
    public partial class Fcustomer : Form
    {
        //Kết nối csdl
        string strCon = @"Data Source=DESKTOP-B3E8RSQ\SQLEXPRESS;Initial Catalog=quanlicaphe;Integrated Security=True;";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Fcustomer()
        {
            InitializeComponent();
        }
        

        private void Fcustomer_Load(object sender, EventArgs e)
        {
            HienThi();

        }

        private void HienThi()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            //Kiểm tra trạng thái(state) kết nối
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }

            string query = "SELECT * FROM khachhang";
            adapter = new SqlDataAdapter(query, sqlCon);
            SqlCommandBuilder buider = new SqlCommandBuilder(adapter);

            ds = new DataSet();

            adapter.Fill(ds, "tblCustomers");

            dtgvCustomer.DataSource = ds.Tables["tblCustomers"];
        }

        //Làm mới!
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            txtPhone.ResetText();
            txtEmail.ResetText();
            txtAdress.ResetText();
        }
        //Quay lại trang chủ
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Fmain f = new Fmain();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        //Thêm
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataRow dataRow = ds.Tables["tblCustomers"].NewRow();
            //row["customer_id"] = txtCustomerID.Text.Trim();
            dataRow["ten_khachhang"] = txtName.Text.Trim();
            dataRow["sdt"] = txtPhone.Text.Trim();
            dataRow["email"] = txtEmail.Text.Trim();
            dataRow["diachi"] = txtAdress.Text.Trim();

            ds.Tables["tblCustomers"].Rows.Add(dataRow);

            int kq = adapter.Update(ds.Tables["tblCustomers"]);
            if (kq > 0)
            {
                MessageBox.Show("Thêm thành công!");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        int vt = -1;
        //Sửa
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn khách hàng!");
                return;
            }

            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            dataRow.BeginEdit();

            dataRow["ten_khachhang"] = txtName.Text.Trim();
            dataRow["sdt"] = txtPhone.Text.Trim();
            dataRow["email"] = txtEmail.Text.Trim();
            dataRow["diachi"] = txtAdress.Text.Trim();

            dataRow.EndEdit();

            int re = adapter.Update(ds.Tables["tblCustomers"]);
            if (re > 0)
            {
                MessageBox.Show("Sửa thành công!");
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void dtgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vt = e.RowIndex;
            if (vt == -1)
            {
                return;
            }
            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            txtID.Text = dataRow["id_khachhang"].ToString();
            txtName.Text = dataRow["ten_khachhang"].ToString();
            txtPhone.Text = dataRow["sdt"].ToString();
            txtEmail.Text = dataRow["email"].ToString();
            txtAdress.Text = dataRow["diachi"].ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có chắc muốn xóa không?", "Hộp thoại", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaKhachHang();
            }
        }

        private void XoaKhachHang()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu!");
            }

            DataRow dataRow = ds.Tables["tblCustomers"].Rows[vt];
            dataRow.Delete();

            try
            {
                int kq = adapter.Update(ds.Tables["tblCustomers"]);
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi SQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSearch.Text.Trim()) && int.TryParse(txtSearch.Text.Trim(), out int searchCustomerId)) 
            {
                TimKiemKhachHangTheoID(searchCustomerId);
            }
        }

        private void TimKiemKhachHangTheoID(int customerId)
        {

            DataRow[] resultRows = ds.Tables["tblCustomers"].Select($"id_khachhang = {customerId}");

            if (resultRows.Length > 0)
            {
                // Hiển thị thông tin sản phẩm tìm được
                DataRow dataRow = resultRows[0];
                txtID.Text = dataRow["id_khachhang"].ToString();
                txtName.Text = dataRow["ten_khachhang"].ToString();
                txtPhone.Text = dataRow["sdt"].ToString();
                txtEmail.Text = dataRow["email"].ToString();
                txtAdress.Text = dataRow["diachi"].ToString();

                MessageBox.Show("Đã tìm thấy khách hàng!");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với ID đã nhập.");
            }
        }
    }
}
