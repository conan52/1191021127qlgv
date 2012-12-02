using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using System.Data.Linq;
using _1191021127.QuanLyGiaoVien.Domain;
using _1191021127.QuanLyGiaoVien.Domain.Entities;
namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class ThongKeChucDanh : Form
    {
        public ThongKeChucDanh()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        private void ThongKeChucDanh_Load(object sender, EventArgs e)
        {
            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucDanh.DataSource = chucDanhs;
            TimKiemGiaoVienTheoChucDanh();
        }

        private void cbChucDanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemGiaoVienTheoChucDanh();
        }

        private void TimKiemGiaoVienTheoChucDanh()
        {
            List<GiaoVien> gv = null;
            if (cbChucDanh.SelectedValue != null)
            {
                if (gv == null) 
                gv = db.GiaoViens.ToList<GiaoVien>();
                ChucDanh m = (ChucDanh)cbChucDanh.SelectedValue;
                List<ChucDanh_GiaoVien> lcd = db.ChucDanh_GiaoViens.Where(x => x.MaChucDanh == m.MaChucDanh).ToList<ChucDanh_GiaoVien>();
                List<GiaoVien> gvs = new List<GiaoVien>();
                gv.Clear();
                for (int i = 0; i < lcd.Count; i++)
                {
                    gv.Add(lcd[i].GiaoVien);
                }
            }
            List<GiaoVienView> lGVView = new List<GiaoVienView>();
            if (gv == null)
            {
                dgChucDanh.DataSource = null;
                return;
            }
            for (int i = 0; i < gv.Count; i++)
            {
                GiaoVienView gvview = new GiaoVienView();
                gvview.Id = gv[i].MaGiaoVien;
                gvview.HoTen = gv[i].HoTen;
                gvview.GioiTinh = gv[i].GioiTinh;
                gvview.NgaySinh = (gv[i].NgaySinh != null ? gv[i].NgaySinh.ToString() : "Chưa cập nhật ngày sinh");
                gvview.Email = gv[i].Email;
                gvview.SoDienThoai = (long)gv[i].SoDienThoai;
                gvview.LuongCoBan = (float)gv[i].LuongCoBan;
                gvview.BoMon = gv[i].BoMon;
                List<ChucDanh_GiaoVien> cd = db.ChucDanh_GiaoViens.Where(x => x.MaGiaoVien == gv[i].MaGiaoVien).ToList<ChucDanh_GiaoVien>();
                if (cd.Count > 0)
                {
                    gvview.ChucDanh = cd[0].ChucDanh;
                }
                else
                {
                    gvview.ChucDanh = new ChucDanh();
                    gvview.ChucDanh.TenChucDanh = "Chưa có chức danh";
                }
                lGVView.Add(gvview);
            }
            dgChucDanh.DataSource = lGVView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
