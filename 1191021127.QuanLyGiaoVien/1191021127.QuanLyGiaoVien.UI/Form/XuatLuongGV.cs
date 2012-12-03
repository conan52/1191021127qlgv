using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using _1191021127.QuanLyGiaoVien.Domain;

namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class XuatLuongGV : Form
    {
        DBStoreDataContext db = new DBStoreDataContext();
        public XuatLuongGV()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                GiaoVien gv = db.GiaoViens.Where(x => x.MaGiaoVien == int.Parse(textBox1.Text)).FirstOrDefault();
                if (gv != null)
                {
                    tbMaGV.Text = gv.MaGiaoVien.ToString();
                    tbHoTen.Text = gv.HoTen;
                    ChucDanh_GiaoVien xx = db.ChucDanh_GiaoViens.Where(x => x.MaGiaoVien == gv.MaGiaoVien).FirstOrDefault();
                    if (xx != null)
                    {
                        tbHSL.Text = xx.ChucDanh.HeSoLuong.ToString();
                    }
                    tbLuongCoBan.Text = gv.LuongCoBan.ToString();
                    List<PhanCongGiaoVien> lpc = db.PhanCongGiaoViens.Where(x => x.MaGiaoVien == gv.MaGiaoVien).ToList<PhanCongGiaoVien>();
                    int soTietDay = 0;
                    
                    for (int i = 0; i < lpc.Count; i++)
                    {
                        soTietDay += (int)lpc[i].SoTietDay;
                    }

                    tbSoTiet.Text = soTietDay.ToString();
                   
                    float tongLuong =(float)(gv.LuongCoBan + xx.ChucDanh.HeSoLuong * soTietDay);

                    tbTongLuong.Text = tongLuong.ToString();
                }
            }
        }

        private void XuatLuongGV_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
