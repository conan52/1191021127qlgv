using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace _1191021127.QuanLyGiaoVien.UI.Common
{
    public partial class ThemGiaoVien : Form
    {
        public ThemGiaoVien()
        {
            InitializeComponent();
        }
        QLGVEntities data = new QLGVEntities();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThemGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaoVienDataSet1.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.quanLyGiaoVienDataSet1.ChucDanh);
            // TODO: This line of code loads data into the 'quanLyGiaoVienDataSet1.ChucDanh' table. You can move, or remove it, as needed.
         
            // TODO: This line of code loads data into the 'quanLyGiaoVienDataSet.BoMon' table. You can move, or remove it, as needed.
            this.boMonTableAdapter.Fill(this.quanLyGiaoVienDataSet.BoMon);
            try
            {
                // TODO: This line of code loads data into the 'quanLyGiaoVienDataSet.ChucDanh' table. You can move, or remove it, as needed.
               
                //Display List GioiTinh
                ArrayList gt = new ArrayList { "Nam", "Nữ" };
                cbGioiTinh.DataSource = gt;

                chucDanhBindingSource.DataSource = data.ChucDanhs;

                boMonBindingSource.DataSource = data.BoMons;

            }
            catch (Exception ex)
            {
                throw ex;
            }

            
        }

        

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbChucVu.DataSource = data.ChucDanhs;
        }
             

        private void cbBoMon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBoMon.DataSource = data.BoMons;
        }
    }
}
