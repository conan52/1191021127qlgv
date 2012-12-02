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
        }

        private void cbMaGiaoVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //List<PhanCongGiaoVien> phanCong = new List<PhanCongGiaoVien>(); 
            //Table<PhanCongGiaoVien> tb  = new Table<PhanCongGiaoVien>();
            GiaoVien m = new GiaoVien();
           // if (cbMaGiaoVien.SelectedValue != null)
           // {
              //  if (tb == null)
                          
               //  m = (GiaoVien)cbMaGiaoVien.SelectedValue; 
                 
                //var tbs = from t in db.GetTable<PhanCongGiaoVien>() 
                  //        where 
                 // phanCong = db.PhanCongGiaoViens.Where(x => x.MaGiaoVien == m.MaGiaoVien).ToList<ChonPhanCongGiaoVien>();
           // }
            
        }
    }
}
