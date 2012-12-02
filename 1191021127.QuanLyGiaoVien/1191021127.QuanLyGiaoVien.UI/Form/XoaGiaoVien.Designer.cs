namespace _1191021127.QuanLyGiaoVien.UI
{
    partial class XoaGiaoVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btXoa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaGV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaGV = new System.Windows.Forms.ComboBox();
            this.tbBoMon = new System.Windows.Forms.TextBox();
            this.tbKhoa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btDong = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(118, 266);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(100, 28);
            this.btXoa.TabIndex = 0;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã giáo viên :";
            // 
            // tbMaGV
            // 
            this.tbMaGV.Enabled = false;
            this.tbMaGV.Location = new System.Drawing.Point(157, 79);
            this.tbMaGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaGV.Name = "tbMaGV";
            this.tbMaGV.Size = new System.Drawing.Size(265, 23);
            this.tbMaGV.TabIndex = 2;
            this.tbMaGV.TextChanged += new System.EventHandler(this.tbMaGV_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bộ môn :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Khoa :";
            // 
            // cbMaGV
            // 
            this.cbMaGV.FormattingEnabled = true;
            this.cbMaGV.Location = new System.Drawing.Point(157, 121);
            this.cbMaGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMaGV.Name = "cbMaGV";
            this.cbMaGV.Size = new System.Drawing.Size(265, 24);
            this.cbMaGV.TabIndex = 6;
            this.cbMaGV.SelectedIndexChanged += new System.EventHandler(this.cbMaGV_SelectedIndexChanged);
            // 
            // tbBoMon
            // 
            this.tbBoMon.Enabled = false;
            this.tbBoMon.Location = new System.Drawing.Point(157, 166);
            this.tbBoMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBoMon.Name = "tbBoMon";
            this.tbBoMon.Size = new System.Drawing.Size(265, 23);
            this.tbBoMon.TabIndex = 7;
            // 
            // tbKhoa
            // 
            this.tbKhoa.Enabled = false;
            this.tbKhoa.Location = new System.Drawing.Point(157, 206);
            this.tbKhoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbKhoa.Name = "tbKhoa";
            this.tbKhoa.Size = new System.Drawing.Size(265, 23);
            this.tbKhoa.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Xóa giáo viên";
            // 
            // btDong
            // 
            this.btDong.Location = new System.Drawing.Point(277, 266);
            this.btDong.Margin = new System.Windows.Forms.Padding(4);
            this.btDong.Name = "btDong";
            this.btDong.Size = new System.Drawing.Size(100, 28);
            this.btDong.TabIndex = 10;
            this.btDong.Text = "Đóng";
            this.btDong.UseVisualStyleBackColor = true;
            this.btDong.Click += new System.EventHandler(this.btDong_Click);
            // 
            // XoaGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 322);
            this.Controls.Add(this.btDong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbKhoa);
            this.Controls.Add(this.tbBoMon);
            this.Controls.Add(this.cbMaGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btXoa);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "XoaGiaoVien";
            this.Text = "Xóa giáo viên";
            this.Load += new System.EventHandler(this.XoaGiaoVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaGV;
        private System.Windows.Forms.TextBox tbBoMon;
        private System.Windows.Forms.TextBox tbKhoa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btDong;
    }
}