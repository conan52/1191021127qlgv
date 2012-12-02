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
            cbMaGiaoVien.DataSource = giaoViens;
            cbMaGiaoVien.DisplayMember = "MaGiaoVien" ;
            cbMaGiaoVien.ValueMember   = "MaGiaoVien";
            TimKiemLichDayGiaoVien();
        }

        private void cbMaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {

            TimKiemLichDayGiaoVien();
        }

        private void TimKiemLichDayGiaoVien()
        {
            List<PhanCongGiaoVien> lstgv = null;
            long pMaGiaoVien = Int32.Parse(cbMaGiaoVien.SelectedValue.ToString());
            if (cbMaGiaoVien.SelectedValue != null)
            {
                if (lstgv == null)
                    lstgv = db.PhanCongGiaoViens.ToList<PhanCongGiaoVien>();
                GiaoVien gv = db.GiaoViens.Where(x => x.MaGiaoVien == pMaGiaoVien).FirstOrDefault();
                txtHoTen.Text = gv.HoTen.ToString();
                lstgv.Clear();
                lstgv = db.PhanCongGiaoViens.ToList<PhanCongGiaoVien>().Where(x => x.MaGiaoVien == gv.MaGiaoVien).ToList<PhanCongGiaoVien>(); ;
                dgPhanCong.DataSource = lstgv;
            }
        }
    }
}
