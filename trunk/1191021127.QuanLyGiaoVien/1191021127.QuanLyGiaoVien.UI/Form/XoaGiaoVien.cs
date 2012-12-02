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

namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class XoaGiaoVien : Form
    {
        public XoaGiaoVien()
        {
            InitializeComponent();
        }


        DBStoreDataContext db = new DBStoreDataContext();
        private void btXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMaGV.Text != null && tbMaGV.Text != "")
                {
                    int magv = int.Parse(tbMaGV.Text);

                    // lay thong tin giao vien co ma giao vien la magv
                    GiaoVien gv = db.GiaoViens.Where(x => x.MaGiaoVien == magv).FirstOrDefault();

                    if (gv != null)
                    {
                        gv.TrangThai = false;

                        db.SubmitChanges();
                        MessageBox.Show("Xóa thành công,", "Xóa Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cbMaGV.DataSource = db.GiaoViens.Where(x => x.TrangThai == true).ToList<GiaoVien>();
                    }
                    else
                    {
                        MessageBox.Show("không tìm thấy giáo viên có mã : " + magv, "Xóa Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập mã giáo viên cần xóa,", "Xóa Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex) {
                MessageBox.Show("Xóa thất bại ! \n Lỗi :" + ex.ToString(), "Xóa Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void XoaGiaoVien_Load(object sender, EventArgs e)
        {
            // loat tat ca cac ma giao vien len combobox
            cbMaGV.DataSource = db.GiaoViens.Where(x=> x.TrangThai == true).ToList<GiaoVien>();
        }

        private void cbMaGV_SelectedIndexChanged(object sender, EventArgs e)
        {

            GiaoVien gv = (GiaoVien)cbMaGV.SelectedItem;
            tbMaGV.Text = "";
            tbBoMon.Text = "";
            tbKhoa.Text = "";

            // cap nhat lai thong tin tren form
            if (gv != null)
            {
                tbMaGV.Text = gv.MaGiaoVien.ToString();
                tbBoMon.Text = gv.BoMon.ToString();
                BoMon b = db.BoMons.Where(x => x.MaBoMon == gv.MaBoMon).FirstOrDefault();
                if (b != null) {
                    tbKhoa.Text = b.Khoa.ToString();
                }
            }
        }

        private void btDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbMaGV_TextChanged(object sender, EventArgs e)
        {
        //    if (tbMaGV.Text == null || tbMaGV.Text == "")
        //    { return; }

        //    int magv = int.Parse(tbMaGV.Text);
        //    List<GiaoVien> lgv =  db.GiaoViens.Where(x => x.TrangThai == true).ToList<GiaoVien>();
        //    if (lgv == null || lgv.Count <= 0) return;

        //    GiaoVien gv = (GiaoVien)lgv[0];
        //    tbBoMon.Text = "";
        //    tbKhoa.Text = "";

        //    cbMaGV.SelectedItem = gv;
        //    // cap nhat lai thong tin tren form
        //    if (gv != null)
        //    {
        //        tbBoMon.Text = gv.BoMon.ToString();
        //        BoMon b = db.BoMons.Where(x => x.MaBoMon == gv.MaBoMon).FirstOrDefault();
        //        if (b != null)
        //        {
        //            tbKhoa.Text = b.Khoa.ToString();
        //        }
        //    }
        }
    }
}
