using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms; 
using _1191021127.QuanLyGiaoVien.Domain;
using _1191021127.QuanLyGiaoVien.Domain.Entities;
using System.Data.Linq;
namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class ThongKeTheoBoMon : Form
    {
        public ThongKeTheoBoMon()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        private void ThongKeTheoBoMon_Load(object sender, EventArgs e)
        {
            Table<BoMon> boMons = db.GetTable<BoMon>();
            cbBoMon.DataSource = boMons;
            TimKiemGiaoVienTheoBoMon();
        }

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimKiemGiaoVienTheoBoMon();
        }

        private void TimKiemGiaoVienTheoBoMon()
        {
            List<GiaoVien> gv = null;
            if (cbBoMon.SelectedValue != null)
            {
                if (gv == null)
                    gv = db.GiaoViens.ToList<GiaoVien>();
                BoMon m = (BoMon)cbBoMon.SelectedValue;
                gv.Clear();
                gv = db.GiaoViens.ToList<GiaoVien>().Where(x => x.MaBoMon == m.MaBoMon).ToList<GiaoVien>(); ;
            }
            List<GiaoVienView> lGVView = new List<GiaoVienView>();
            if (gv == null)
            {
                dgBoMon.DataSource = null;
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
                lGVView.Add(gvview);
            }
            dgBoMon.DataSource = lGVView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
