using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using _1191021127.QuanLyGiaoVien.Domain;

namespace _1191021127.QuanLyGiaoVien.UI.Common
{
    public partial class ThemGiaoVien : Form
    {
        DBStoreDataContext db = new DBStoreDataContext();

        public ThemGiaoVien()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                GiaoVien giaoVien = new GiaoVien();

                giaoVien.HoTen = txtHoTen.Text;
                if (txtHoTen.Text == null || txtHoTen.Text == "")
                {
                     MessageBox.Show("chưa điền tên," , "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                }
                giaoVien.GioiTinh = cbGioiTinh.SelectedValue.ToString();
                giaoVien.NgaySinh = DateTime.Now;
                giaoVien.Email = txtEmail.Text;
            
                if(giaoVien.Email == null || giaoVien.Email == "")
                {
                     MessageBox.Show("chưa điền email" , "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                }

                if(txtSoDienThoai.Text == null || txtSoDienThoai.Text == "")
                {
                     MessageBox.Show("chưa điền so dien thoai" , "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                }

                giaoVien.SoDienThoai = int.Parse(txtSoDienThoai.Text);

                if(txtLuongCoBan.Text == null || txtLuongCoBan.Text == "")
                {
                     MessageBox.Show("Chưa điền lương cơ bản!," , "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return;
                }
                giaoVien.LuongCoBan = int.Parse(txtLuongCoBan.Text);
                BoMon bm =  (BoMon)cbBoMon.SelectedValue;
                if(bm != null){
                giaoVien.MaBoMon = bm.MaBoMon;
                }
                giaoVien.TrangThai = true;
              
                db.GiaoViens.InsertOnSubmit(giaoVien);
                db.SubmitChanges();

                ChiTietChucVuGV chiTiet = new ChiTietChucVuGV();
    
                ChucVu cv = (ChucVu)cbChucVu.SelectedValue;
                if (cv != null)
                {
                    chiTiet.MaChucVu = cv.MaChucVu;
                }
                chiTiet.MaGV = giaoVien.MaGiaoVien; ;

                db.ChiTietChucVuGVs.InsertOnSubmit(chiTiet);
                db.SubmitChanges();

                ChucDanh_GiaoVien chiTiet2 = new ChucDanh_GiaoVien();
                ChucDanh cd = (ChucDanh)cbChucDanh.SelectedValue;
                if (cd != null)
                {
                    chiTiet2.MaChucDanh = cd.MaChucDanh;
                }
                chiTiet2.MaGiaoVien = giaoVien.MaGiaoVien; ;

                db.ChucDanh_GiaoViens.InsertOnSubmit(chiTiet2);
                db.SubmitChanges();
                MessageBox.Show("Qúa trình thêm thành công!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            //}
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Qúa trình thêm thất bại!," + ex.ToString(), "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.DialogResult = DialogResult.OK;

            //}

        }


        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList { "Nam", "Nữ" };
            cbGioiTinh.DataSource = array;
            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucDanh.DataSource = chucDanhs;
            Table<ChucVu> chucVus = db.GetTable<ChucVu>();
            cbChucVu.DataSource = chucVus;
            Table<BoMon> boMons = db.GetTable<BoMon>();
            cbBoMon.DataSource = boMons;
        }
    }
}
