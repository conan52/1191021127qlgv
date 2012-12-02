using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1191021127.QuanLyGiaoVien.UI
{
    public partial class CapNhatGiaoVien : Form
    {
        public CapNhatGiaoVien()
        {
            InitializeComponent();
        }
        QLGVEntities data = new QLGVEntities();
        private void CapNhatGiaoVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyGiaoVienDataSet.ChucDanh' table. You can move, or remove it, as needed.
            this.chucDanhTableAdapter.Fill(this.quanLyGiaoVienDataSet.ChucDanh);
            chucDanhBindingSource.DataSource = data.ChucDanhs;

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
           

        }
    }
}
