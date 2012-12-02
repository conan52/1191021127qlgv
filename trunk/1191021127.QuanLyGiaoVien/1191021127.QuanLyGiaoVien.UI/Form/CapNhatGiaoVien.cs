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
using System.Collections;
namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class CapNhatGiaoVien : Form
    {
        GiaoVien giaovienHienTai = null;
        public CapNhatGiaoVien()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        
        private void CapNhatGiaoVien_Load(object sender, EventArgs e)
        {
            ArrayList array = new ArrayList { "Nam", "Nữ" };
            cbGioiTinh.DataSource = array;

            Table<ChucDanh> chucDanhs = db.GetTable<ChucDanh>();
            cbChucDanh.DataSource = chucDanhs;

            Table<ChucVu> chucVus = db.GetTable<ChucVu>();
            cbChucVu.DataSource = chucVus;

            Table<BoMon> boMons = db.GetTable<BoMon>();
            cbBoMon.DataSource = boMons;


            cbHoTen.DataSource = db.GiaoViens.Where(x=> x.TrangThai == true).ToList<GiaoVien>();
            giaovienHienTai = (GiaoVien)cbHoTen.SelectedItem;

            dtNgaySinh.Text = giaovienHienTai.NgaySinh.ToString();
            cbGioiTinh.Text = giaovienHienTai.GioiTinh;
            txtEmail.Text = giaovienHienTai.Email;
            txtSoDienThoai.Text = giaovienHienTai.SoDienThoai.ToString();
            txtLuongCoBan.Text = giaovienHienTai.LuongCoBan.ToString();

            ChucDanh_GiaoVien ct = db.ChucDanh_GiaoViens.Where(x => x.MaGiaoVien == giaovienHienTai.MaGiaoVien).FirstOrDefault();
           if(ct != null)
            cbChucDanh.SelectedItem = ct.ChucDanh;

            ChiTietChucVuGV chiTietChucVu = db.ChiTietChucVuGVs.Where(x => x.MaGV == giaovienHienTai.MaGiaoVien).FirstOrDefault();
            if (chiTietChucVu != null)
             cbChucVu.SelectedItem = chiTietChucVu.ChucVu ;

            cbBoMon.SelectedItem = giaovienHienTai.BoMon;

        }

        private void cbChucDanh_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if(giaovienHienTai != null)
            {
            ChucDanh_GiaoVien ct = db.ChucDanh_GiaoViens.Where(x => x.MaGiaoVien == giaovienHienTai.MaGiaoVien).FirstOrDefault();
            if (ct == null) return;
            db.ChucDanh_GiaoViens.InsertOnSubmit(ct);
                ct.MaChucDanh = ((ChucDanh)cbChucDanh.SelectedItem).MaChucDanh;
            ct.MaGiaoVien = giaovienHienTai.MaGiaoVien;
            db.ChucDanh_GiaoViens.InsertOnSubmit(ct);
            }
           // db.SubmitChanges();
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (giaovienHienTai != null)
            {
                ChiTietChucVuGV ct = db.ChiTietChucVuGVs.Where(x => x.MaGV == giaovienHienTai.MaGiaoVien).FirstOrDefault();
               
                db.ChiTietChucVuGVs.DeleteOnSubmit(ct);

                ct.MaChucVu = ((ChucVu)cbChucVu.SelectedItem).MaChucVu;
                ct.MaGV = giaovienHienTai.MaGiaoVien;

                db.ChiTietChucVuGVs.InsertOnSubmit(ct);
            }
           // db.SubmitChanges();
        }

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (giaovienHienTai != null)
            giaovienHienTai.MaBoMon = ((BoMon)cbBoMon.SelectedItem).MaBoMon;
           // db.SubmitChanges();
        }

        private void cbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GiaoVien gv = (GiaoVien)cbHoTen.SelectedItem;


                dtNgaySinh.Text = gv.NgaySinh.ToString();
                cbGioiTinh.Text = gv.GioiTinh;
                txtEmail.Text = gv.Email;
                txtSoDienThoai.Text = gv.SoDienThoai.ToString();
                txtLuongCoBan.Text = gv.LuongCoBan.ToString();


                ChiTietChucVuGV cv = db.ChiTietChucVuGVs.Where(x => x.MaGV == gv.MaGiaoVien).FirstOrDefault();
                if (cv != null)
                    cbChucVu.SelectedItem = cv.ChucVu;
                ChucDanh_GiaoVien cd = gv.ChucDanh_GiaoViens.Where(x => x.MaGiaoVien == gv.MaGiaoVien).FirstOrDefault();
                if (cd != null)
                    cbChucDanh.SelectedItem = cd.ChucDanh;

                BoMon bm = gv.BoMon;
                cbBoMon.SelectedItem = bm;
            }
            catch (Exception ex) { }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if( txtEmail.Text != null &&  txtEmail.Text != "") 
                giaovienHienTai.Email = txtEmail.Text;
                if(txtSoDienThoai.Text != null && txtSoDienThoai.Text != "")
                giaovienHienTai.SoDienThoai = Int32.Parse(txtSoDienThoai.Text);
                if (txtLuongCoBan.Text != null && txtLuongCoBan.Text != "")
                giaovienHienTai.LuongCoBan = Int32.Parse(txtLuongCoBan.Text);
     

            
                db.SubmitChanges();

                MessageBox.Show("Quá trình cập nhật thành công!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex )
            { 
                MessageBox.Show("Qúa trình cập nhật thất bại! \n Lỗi : " + ex.ToString(), "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (giaovienHienTai != null && cbGioiTinh.SelectedItem != null)
            giaovienHienTai.GioiTinh = (string)cbGioiTinh.SelectedItem;
        }

        private void dtNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            if (giaovienHienTai != null)
            giaovienHienTai.NgaySinh = dtNgaySinh.Value;
        }
    }
}
