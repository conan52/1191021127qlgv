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
    public partial class XoaGiaoVien : Form
    {
        public XoaGiaoVien()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        private void XoaGiaoVien_Load(object sender, EventArgs e)
        {
            var lstgiaoVien = db.GetTable<GiaoVien>();
            var lst = from gv in lstgiaoVien
                      where gv.TrangThai == true
                      select gv;
            cbHoTen.DataSource = lst;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                GiaoVien giaoVien = db.GiaoViens.Single(x => x.MaGiaoVien.Equals(cbHoTen.SelectedValue.ToString()));                
                giaoVien.TrangThai = false;
                db.SubmitChanges();
                MessageBox.Show("Quá trình xóa thành công!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
 
            }
            catch (Exception)
            {
                 
                MessageBox.Show("Qúa trình xóa thất bại!", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
