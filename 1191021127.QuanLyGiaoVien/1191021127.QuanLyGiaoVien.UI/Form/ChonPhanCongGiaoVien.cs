using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.Linq;
using _1191021127.QuanLyGiaoVien.Domain;
using _1191021127.QuanLyGiaoVien.Domain.Entities;
namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class ChonPhanCongGiaoVien : Form
    {
        public ChonPhanCongGiaoVien()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        private void ChonPhanCongGiaoVien_Load(object sender, EventArgs e)
        {
            ArrayList arr = new ArrayList { "1", "2" };
            cbHocKy.DataSource = arr;

            Table<LopHoc> lh = db.GetTable<LopHoc>();
            cbLop.DataSource = lh;

            Table<MonHoc> monHocs = db.GetTable<MonHoc>();
            cbMonHoc.DataSource = monHocs;

            Table<PhongBan> phongbans = db.GetTable<PhongBan>();
            cbPhongBan.DataSource = phongbans;
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtMaGiaoVien_TextChanged(object sender, EventArgs e)
        {
            if (txtMaGiaoVien.Text != null && txtMaGiaoVien.Text != "")
            {
                GiaoVien gv = db.GiaoViens.Where(x => x.MaGiaoVien == int.Parse(txtMaGiaoVien.Text)).FirstOrDefault();
                if (gv != null)
                {
                    tbHoTen.Text = gv.HoTen;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PhanCongGiaoVien pc = new PhanCongGiaoVien();
                if (txtMaGiaoVien.Text == null || txtMaGiaoVien.Text == "")
                {
                    MessageBox.Show("Chưa điền mã giáo viên!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                pc.MaGiaoVien = int.Parse(txtMaGiaoVien.Text);
                pc.MaLopHoc = ((LopHoc)cbLop.SelectedItem).MaLopHoc;
                pc.MaMonHoc = ((MonHoc)cbMonHoc.SelectedItem).MaMonHoc;
                pc.MaPhongBan = ((PhongBan)cbPhongBan.SelectedItem).MaPhongBan;
                pc.HocKy = cbHocKy.SelectedValue.ToString();
                pc.NamHoc = DateTime.Now.Year;

                if (tbSOtiet.Text == null || tbSOtiet.Text == "")
                {
                    MessageBox.Show("Chưa điền số tiêt!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pc.SoTietDay = int.Parse(tbSOtiet.Text);

                db.PhanCongGiaoViens.InsertOnSubmit(pc);
                db.SubmitChanges();
                MessageBox.Show("Quá trình phân công thành công!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình phân công thất bai,! " + ex.ToString(), "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        //cap nhat
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaGiaoVien.Text == null || txtMaGiaoVien.Text == "")
                {
                    MessageBox.Show("Chưa điền mã giáo viên!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                PhanCongGiaoVien pc = db.PhanCongGiaoViens.Where(x => x.MaPhanCong == int.Parse(Text)).FirstOrDefault();
                if (txtMaGiaoVien.Text == null || txtMaGiaoVien.Text == "")
                {
                    MessageBox.Show("Chưa điền mã giáo viên!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
               //PhanCongGiaoVien pc = db.PhanCongGiaoViens.Where(x
                pc.MaGiaoVien = int.Parse(txtMaGiaoVien.Text);
                pc.MaLopHoc = ((LopHoc)cbLop.SelectedItem).MaLopHoc;
                pc.MaMonHoc = ((MonHoc)cbMonHoc.SelectedItem).MaMonHoc;
                pc.MaPhongBan = ((PhongBan)cbPhongBan.SelectedItem).MaPhongBan;
                pc.HocKy = cbHocKy.SelectedValue.ToString();
                pc.NamHoc = DateTime.Now.Year;

                if (tbSOtiet.Text == null || tbSOtiet.Text == "")
                {
                    MessageBox.Show("Chưa điền số tiêt!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                pc.SoTietDay = int.Parse(tbSOtiet.Text);

                db.PhanCongGiaoViens.InsertOnSubmit(pc);
                db.SubmitChanges();
                MessageBox.Show("Quá trình phân công thành công!", "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Quá trình phân công thất bai,! " + ex.ToString(), "Phân công - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
