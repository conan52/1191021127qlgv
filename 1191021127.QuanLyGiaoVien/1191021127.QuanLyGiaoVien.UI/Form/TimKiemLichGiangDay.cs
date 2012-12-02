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
    public partial class TimKiemLichGiangDay : Form
    {
        public TimKiemLichGiangDay()
        {
            InitializeComponent();
        }
        DBStoreDataContext db = new DBStoreDataContext();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimKiemLichGiangDay_Load(object sender, EventArgs e)
        {
            //Load danh sách mã giáo viên cần thống kê
            Table<GiaoVien> giaoViens = db.GetTable<GiaoVien>();
            cbGV.DataSource = giaoViens;
           // TimKiemLichDayGiaoVien();
        }

        private void cbMaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            TimKiemLichDayGiaoVien();
        }

        private void TimKiemLichDayGiaoVien()
        {
            //if (cbMaGiaoVien.SelectedValue != null)
            //{
            //    List<PhanCongGiaoVien> lstgv = null;
            //    GiaoVien gvx = (GiaoVien)cbMaGiaoVien.SelectedValue;
 
            //    txtHoTen.Text = gvx.HoTen;

            //    lstgv = db.PhanCongGiaoViens.ToList<PhanCongGiaoVien>().Where(x => x.MaGiaoVien == gvx.MaGiaoVien).ToList<PhanCongGiaoVien>(); ;
            //    dgPhanCong.DataSource = lstgv;
            //}
        }

        private void cbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            GiaoVien gvx = (GiaoVien)cbGV.SelectedValue;
            List<PhanCongGiaoVien> lstgv = db.PhanCongGiaoViens.ToList<PhanCongGiaoVien>().Where(x => x.MaGiaoVien == gvx.MaGiaoVien).ToList<PhanCongGiaoVien>();
            dgPhanCong.DataSource = lstgv;
        }
    }
}
