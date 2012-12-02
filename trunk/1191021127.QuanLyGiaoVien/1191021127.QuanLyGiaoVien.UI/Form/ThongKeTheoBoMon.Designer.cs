namespace _1191021127.QuanLyGiaoVien.UI
{
    partial class ThongKeTheoBoMon
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
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgBoMon = new System.Windows.Forms.DataGridView();
            this.cbBoMon = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBoMon)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(698, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 33);
            this.button2.TabIndex = 18;
            this.button2.Text = "Đóng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(96, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Thống Kê Giáo Viên Theo Bộ Môn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgBoMon);
            this.groupBox1.Location = new System.Drawing.Point(9, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 310);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách giáo viên";
            // 
            // dgBoMon
            // 
            this.dgBoMon.BackgroundColor = System.Drawing.Color.White;
            this.dgBoMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBoMon.Location = new System.Drawing.Point(6, 19);
            this.dgBoMon.Name = "dgBoMon";
            this.dgBoMon.Size = new System.Drawing.Size(767, 285);
            this.dgBoMon.TabIndex = 0;
            // 
            // cbBoMon
            // 
            this.cbBoMon.FormattingEnabled = true;
            this.cbBoMon.Location = new System.Drawing.Point(99, 66);
            this.cbBoMon.Name = "cbBoMon";
            this.cbBoMon.Size = new System.Drawing.Size(204, 21);
            this.cbBoMon.TabIndex = 15;
            this.cbBoMon.SelectedIndexChanged += new System.EventHandler(this.cbBoMon_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tên bộ môn";
            // 
            // ThongKeTheoBoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(217)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(812, 446);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cbBoMon);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ThongKeTheoBoMon";
            this.Text = "ThongKeTheoBoMon";
            this.Load += new System.EventHandler(this.ThongKeTheoBoMon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBoMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgBoMon;
        private System.Windows.Forms.ComboBox cbBoMon;
        private System.Windows.Forms.Label label1;
    }
}