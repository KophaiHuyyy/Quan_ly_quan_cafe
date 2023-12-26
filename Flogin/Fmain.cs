using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flogin
{
    public partial class Fmain : Form
    {
        public Fmain()
        {
            InitializeComponent();
        }

        private void btnCustormer_Click(object sender, EventArgs e)
        {
            Fcustomer c = new Fcustomer();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có chắc muốn đăng xuất không?", "Hộp thoại", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (re == DialogResult.OK)
            {
                Login l = new Login();
                this.Hide();
                l.ShowDialog();
                this.Show();
            }
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            Facount a = new Facount();
            this.Hide();
            a.ShowDialog();
            this.Show();
        }
    }
}
