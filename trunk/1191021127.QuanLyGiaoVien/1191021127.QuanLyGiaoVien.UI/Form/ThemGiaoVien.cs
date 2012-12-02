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
            GiaoVien giaoVien = new GiaoVien();
            giaoVien.HoTen = "Trần Đại Nghĩa";
            giaoVien.GioiTinh = "Nam";
            giaoVien.NgaySinh = DateTime.Now;
            giaoVien.Email = "trandainghia@gmail.com";
            giaoVien.SoDienThoai = 0987429755;
            giaoVien.LuongCoBan = 3999;
            giaoVien.MaBoMon = 1;
            giaoVien.TrangThai = true;

            db.GiaoViens.InsertOnSubmit(giaoVien);
            db.SubmitChanges();
        }


        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucVu.DataSource = chucDanhs;
        }
    }
}
