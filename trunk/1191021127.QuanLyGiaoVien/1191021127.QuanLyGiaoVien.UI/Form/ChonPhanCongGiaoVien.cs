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
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
