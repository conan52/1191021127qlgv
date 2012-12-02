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
using _1191021127.QuanLyGiaoVien.Domain.Entities;

namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class TimKiemGiaoVien : Form
    {
        DBStoreDataContext db = new DBStoreDataContext();
   
        public TimKiemGiaoVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }
     
        private void btTim_Click(object sender, EventArgs e)
        {
            string tenGV = tbTenGV.Text;
            string maGV = tbMaGV.Text;
            ChucDanh hocVi = (ChucDanh)cbHocVi.SelectedValue;
            ChucDanh hocHam = (ChucDanh)cbHocHam.SelectedValue;

            List<GiaoVien> gv = db.GiaoViens.Where(x => x.HoTen.Contains(tenGV) && x.TrangThai == true).ToList<GiaoVien>();


            if (checkboxMaGV.Checked && tbMaGV.Text != null)
            {
                int ma= int.Parse(tbMaGV.Text);
                gv = db.GiaoViens.Where(x => x.MaGiaoVien == ma).ToList<GiaoVien>();
            }
            if (checkBoxHocVi.Checked && cbHocVi.SelectedValue != null)
            {
                ChucDanh m = (ChucDanh)cbHocVi.SelectedValue;
                List<ChucDanh_GiaoVien> lcd  = db.ChucDanh_GiaoViens.Where(x => x.MaChucDanh == m.MaChucDanh).ToList<ChucDanh_GiaoVien>();
                List<GiaoVien> gvs = new List<GiaoVien>();
                gv.Clear();
                for (int i = 0; i < lcd.Count; i++)
                {
                    gv.Add(lcd[i].GiaoVien);
                }
            }

            if (checkBoxHocHam.Checked && cbHocHam.SelectedValue != null)
            {
                ChucDanh m = (ChucDanh)cbHocHam.SelectedValue;
                List<ChucDanh_GiaoVien> lcd = db.ChucDanh_GiaoViens.Where(x => x.MaChucDanh == m.MaChucDanh).ToList<ChucDanh_GiaoVien>();
                List<GiaoVien> gvs = new List<GiaoVien>();
                gv.Clear();
                for (int i = 0; i < lcd.Count; i++)
                {
                    gv.Add(lcd[i].GiaoVien);
                }
            }

            if (checkBoxBoMon.Checked && cbBoMon.SelectedValue != null)
            {
                BoMon bm = (BoMon)cbBoMon.SelectedValue;
                gv = gv.Where(x => x.MaGiaoVien == bm.MaBoMon).ToList<GiaoVien>();
            }

            List<GiaoVienView> lGVView = new List<GiaoVienView>();
            for (int i = 0; i < gv.Count; i++)
            {
                GiaoVienView gvview = new GiaoVienView();
                gvview.Id = gv[i].MaGiaoVien;
                gvview.HoTen = gv[i].HoTen;
                gvview.GioiTinh = gv[i].GioiTinh;
                gvview.NgaySinh = ( gv[i].NgaySinh != null ? gv[i].NgaySinh.ToString() : "Chưa cập nhật ngày sinh");
                gvview.Email = gv[i].Email;
                gvview.SoDienThoai = (long)gv[i].SoDienThoai;
                gvview.LuongCoBan = (float)gv[i].LuongCoBan;
                gvview.BoMon = gv[i].BoMon;
                List<ChiTietChucVuGV> cv = db.ChiTietChucVuGVs.Where(x => x.MaGV == gv[i].MaGiaoVien).ToList<ChiTietChucVuGV>();
                if (cv.Count > 0)
                {
                    gvview.MChucVu = cv[0].ChucVu;
                }
                else
                {
                    gvview.MChucVu = new ChucVu();
                    gvview.MChucVu.TenChucVu = "Chưa có chức vụ";
                }

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
            dataGridViewGV.DataSource = lGVView;
            
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            Table<BoMon> tbBoMon = db.GetTable<BoMon>();
            List<ChucDanh> LHocVi = db.ChucDanhs.Where(x => x.LoaiChucDanh == "Hoc Vị").ToList<ChucDanh>();
            List<ChucDanh> LHocHam = db.ChucDanhs.Where(x => x.LoaiChucDanh == "Học Hàm").ToList<ChucDanh>();

            cbBoMon.DataSource = tbBoMon;
            cbHocHam.DataSource = LHocHam;
            cbHocVi.DataSource = LHocVi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
