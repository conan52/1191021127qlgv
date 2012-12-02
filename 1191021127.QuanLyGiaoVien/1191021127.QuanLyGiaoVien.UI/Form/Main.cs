using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1191021127.QuanLyGiaoVien.UI.Common;

namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void quảnLýHồSơGiáoVienToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void thêmHồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThemGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void xóaHồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new XoaGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void cậpNhậtHồSơGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new CapNhatGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void thôngTinGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new TimKiemGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void chứcDanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThongKeChucDanh();
            f.MdiParent = this;
            f.Show();
        }


        private void TimKiemGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new TimKiemGiaoVien();
            f.MdiParent = this;
            f.Show();
        }

        private void TimKiemLichGiangDayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new TimKiemLichGiangDay();
            f.MdiParent = this;
            f.Show();
        }

        private void ThongKeTheoHocViToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThongKeChucDanh();
            f.MdiParent = this;
            f.Show();
        }

        private void ThongKeTheoBoMonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new ThongKeTheoBoMon();
            f.MdiParent = this;
            f.Show();
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XuatLuongGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new XuatLuongGV();
            f.MdiParent = this;
            f.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Form dangNhap = new DangNhap();
            dangNhap.MdiParent = this;
            dangNhap.Show();
        }
    }
}
