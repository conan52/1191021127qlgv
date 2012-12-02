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
            try{
                GiaoVien giaoVien = new GiaoVien();
                giaoVien.HoTen = txtHoTen.Text;
                giaoVien.GioiTinh = cbGioiTinh.SelectedText;
                giaoVien.NgaySinh = DateTime.Now;
                giaoVien.Email = txtEmail.Text;
                giaoVien.SoDienThoai = Int32.Parse(txtSoDienThoai.Text);
                giaoVien.LuongCoBan = Int32.Parse(txtLuongCoBan.Text);
                giaoVien.MaBoMon = Int32.Parse(cbBoMon.SelectedValue.ToString());
                giaoVien.TrangThai = true;
                db.SubmitChanges();
                db.GiaoViens.InsertOnSubmit(giaoVien);
                db.SubmitChanges();

                ChiTietChucVuGV chiTiet = new ChiTietChucVuGV();
                long pMaGiaoVien = db.GiaoViens.Count();
                chiTiet.MaChucVu = Int32.Parse(cbChucVu.SelectedValue.ToString());
                chiTiet.MaGV = pMaGiaoVien;

                db.ChiTietChucVuGVs.InsertOnSubmit(chiTiet);
                db.SubmitChanges();

                ChucDanh_GiaoVien chiTiet2 = new ChucDanh_GiaoVien();                
                chiTiet2.MaChucDanh = Int32.Parse(cbChucDanh.SelectedValue.ToString());
                chiTiet.MaGV = pMaGiaoVien;

                db.ChucDanh_GiaoViens.InsertOnSubmit(chiTiet2);
                db.SubmitChanges();
                MessageBox.Show("Qúa trình thêm thành công!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception )
            {
                MessageBox.Show("Qúa trình thêm thất bại!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                
            }

        }


        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList { "Nam", "Nữ" };
            cbGioiTinh.DataSource = array;
            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucVu.DataSource = chucDanhs;
            Table<ChucVu> chucVus = db.GetTable<ChucVu>();
            cbChucVu.DataSource = chucVus;
            Table<BoMon> boMons = db.GetTable<BoMon>();
            cbBoMon.DataSource = boMons;
        }
    }
}
