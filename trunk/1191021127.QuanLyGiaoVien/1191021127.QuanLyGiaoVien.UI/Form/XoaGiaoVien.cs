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

        private void btXoa_Click(object sender, EventArgs e)
        {
            DBStoreDataContext db = new DBStoreDataContext();

            if (tbMaGV.Text != null && tbMaGV.Text != "")
            {
                int magv = int.Parse(tbMaGV.Text);

                GiaoVien gv = db.GiaoViens.Where(x => x.MaGiaoVien == magv).FirstOrDefault();

                if (gv != null)
                {
                    gv.TrangThai = false;

                    db.SubmitChanges();
                }
                else
                {
                    MessageBox.Show("không có giáo viên ", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("chưa nhập mã giáo viên cần xóa,", "Giáo viên - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
