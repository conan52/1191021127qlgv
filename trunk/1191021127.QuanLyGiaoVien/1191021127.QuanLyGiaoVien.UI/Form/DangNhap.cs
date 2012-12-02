using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using _1191021127.QuanLyGiaoVien.Domain;

namespace _1191021127.QuanLyGiaoVien.UI.Common
{
    public partial class DangNhap : Form
    {
        string tenDangNhap = "";
        string matkhau = "";
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            if (tbTenDangNhap.Text != null && tbTenDangNhap.Text != "")
            {
                if (tbMatKhau.Text != null && tbMatKhau.Text != "")
                {
                    DBStoreDataContext db = new DBStoreDataContext();
                   User user =  db.Users.Where(x => x.TenDangNhap == tbTenDangNhap.Text && x.MatKhau == tbMatKhau.Text).FirstOrDefault();

                   if (user == null)
                   {
                       MessageBox.Show("Sai tên hoặc mật khẩu,", "Đăng nhập - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   }
                   else {
                       tenDangNhap = tbTenDangNhap.Text;
                       matkhau = tbMatKhau.Text;
                       this.Close();
                   }
                }
                else
                    MessageBox.Show("Sai mật khẩu,", "Đăng nhập - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sai tên đăng nhập,", "Đăng nhập - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
