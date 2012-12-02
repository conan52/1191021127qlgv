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
            string hocVi = cbHocVi.SelectedValue.ToString();
            string hocHam = cbHocHam.SelectedValue.ToString();
            
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
    }
}
