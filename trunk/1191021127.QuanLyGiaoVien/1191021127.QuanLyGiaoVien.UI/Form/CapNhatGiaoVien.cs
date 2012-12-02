using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1191021127.QuanLyGiaoVien.Domain;
using System.Data.Linq;
namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class CapNhatGiaoVien : Form
    {
        public CapNhatGiaoVien()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        public  GiaoVien GetInfoGiaoVien(long  pMaGiaoVien)
        {
            GiaoVien gv = new GiaoVien(); 
            gv = (GiaoVien)db.GiaoViens.Where(x => x.MaGiaoVien == pMaGiaoVien && x.TrangThai == true).FirstOrDefault();
            if (gv != null)
            {
                return gv;
            }
            else
            {
                MessageBox.Show("Không tồn tại giáo viên!");
                return null;
            }
        }
        public ChucVu GetInfoChucVu(long pMaChucVu)
        {
            ChucVu cv = new ChucVu(); 
            cv = (ChucVu)db.ChucVus.Where(x => x.MaChucVu == pMaChucVu).FirstOrDefault();
            if (cv != null)
            {
                return cv;
            }
            else
            {
                MessageBox.Show("Không tồn tại chức vụ!");
                return null;
            }
        }
        public ChucDanh GetInfoChucDanh(long pMaChucDanh)
        {
            ChucDanh cd = new ChucDanh();
            cd = (ChucDanh)db.ChucDanhs.Where(x => x.MaChucDanh == pMaChucDanh).FirstOrDefault();
            if (cd != null)
            {
                return cd;
            }
            else
            {
                MessageBox.Show("Không tồn tại chức danh!");
                return null;
            }
        }
        public BoMon GetInfoBoMon(long pMaBoMon)
        {
            BoMon bm = new BoMon();
            bm = (BoMon)db.BoMons.Where(x => x.MaBoMon == pMaBoMon).FirstOrDefault();
            if (bm != null)
            {
                return bm;
            }
            else
            {
                MessageBox.Show("Không tồn tại bộ môn!");
                return null;
            }
        }
        private void CapNhatGiaoVien_Load(object sender, EventArgs e)
        {
            var lstgiaoVien = db.GetTable<GiaoVien>();
            var lst = from gv in lstgiaoVien 
                           where gv.TrangThai == true
                           select gv;
            cbHoTen.DataSource = lst;

        }
              private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }

        private void cbChucDanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucVu.DataSource = chucDanhs;
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table<ChucVu> chucVus = db.GetTable<ChucVu>();
            cbChucVu.DataSource = chucVus;
        }

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table<BoMon> boMons = db.GetTable<BoMon>();
            cbBoMon.DataSource = boMons;
        }

        private void cbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv = GetInfoGiaoVien (Int32.Parse(cbHoTen.SelectedValue.ToString()));
            dtNgaySinh.Text = gv.NgaySinh.ToString();
            cbGioiTinh.Text = gv.GioiTinh;
            txtEmail.Text = gv.Email;
            txtSoDienThoai.Text = gv.SoDienThoai.ToString();
            txtLuongCoBan.Text = gv.LuongCoBan.ToString();

            ChucVu cv = GetInfoChucVu(Int32.Parse(cbHoTen.SelectedValue.ToString()));
            cbChucVu.DataSource = cv;
            ChucDanh cd = GetInfoChucDanh(Int32.Parse(cbHoTen.SelectedValue.ToString()));
            cbChucDanh.DataSource = cd;
            BoMon bm = GetInfoBoMon(Int32.Parse(cbHoTen.SelectedValue.ToString()));
            cbBoMon.DataSource = bm;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien giaoVien = db.GiaoViens.Single(x => x.MaGiaoVien.Equals(cbHoTen.SelectedValue.ToString())); 
                giaoVien.HoTen = cbHoTen.SelectedText;
                giaoVien.GioiTinh = cbGioiTinh.SelectedText;
                giaoVien.NgaySinh = DateTime.Now;
                giaoVien.Email = txtEmail.Text;
                giaoVien.SoDienThoai = Int32.Parse(txtSoDienThoai.Text);
                giaoVien.LuongCoBan = Int32.Parse(txtLuongCoBan.Text);
                giaoVien.MaBoMon = Int32.Parse(cbBoMon.SelectedValue.ToString());
                giaoVien.TrangThai = true;

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

                MessageBox.Show("Quá trình cập nhật thành công!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception  )
            { 
                MessageBox.Show("Qúa trình cập nhật thất bại!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
