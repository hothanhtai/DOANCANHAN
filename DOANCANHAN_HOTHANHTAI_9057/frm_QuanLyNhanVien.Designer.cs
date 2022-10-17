
namespace DOANCANHAN_HOTHANHTAI_9057
{
    partial class frm_QuanLyNhanVien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_msnv = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_dem = new System.Windows.Forms.TextBox();
            this.dt_ngayvaolam = new System.Windows.Forms.DateTimePicker();
            this.btn_dem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_phongban = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_thamnien = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.dataGridView_quanlynhanvien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quanlynhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(447, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(91, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSNV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(91, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "HỌ TÊN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(91, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY VÀO LÀM";
            // 
            // txt_msnv
            // 
            this.txt_msnv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_msnv.Location = new System.Drawing.Point(236, 76);
            this.txt_msnv.Name = "txt_msnv";
            this.txt_msnv.Size = new System.Drawing.Size(221, 22);
            this.txt_msnv.TabIndex = 4;
            // 
            // txt_hoten
            // 
            this.txt_hoten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_hoten.Location = new System.Drawing.Point(236, 138);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(221, 22);
            this.txt_hoten.TabIndex = 5;
            // 
            // txt_dem
            // 
            this.txt_dem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_dem.Location = new System.Drawing.Point(615, 67);
            this.txt_dem.Multiline = true;
            this.txt_dem.Name = "txt_dem";
            this.txt_dem.Size = new System.Drawing.Size(80, 31);
            this.txt_dem.TabIndex = 6;
            // 
            // dt_ngayvaolam
            // 
            this.dt_ngayvaolam.CustomFormat = "dd/MM/yyyy";
            this.dt_ngayvaolam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngayvaolam.Location = new System.Drawing.Point(236, 200);
            this.dt_ngayvaolam.Name = "dt_ngayvaolam";
            this.dt_ngayvaolam.Size = new System.Drawing.Size(221, 22);
            this.dt_ngayvaolam.TabIndex = 7;
            this.dt_ngayvaolam.CloseUp += new System.EventHandler(this.dt_ngayvaolam_CloseUp);
            this.dt_ngayvaolam.ValueChanged += new System.EventHandler(this.frm_QuanLyNhanVien_Load);
            // 
            // btn_dem
            // 
            this.btn_dem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dem.Location = new System.Drawing.Point(519, 67);
            this.btn_dem.Name = "btn_dem";
            this.btn_dem.Size = new System.Drawing.Size(75, 31);
            this.btn_dem.TabIndex = 8;
            this.btn_dem.Text = "Đếm";
            this.btn_dem.UseVisualStyleBackColor = true;
            this.btn_dem.Click += new System.EventHandler(this.btn_dem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(713, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "TÊN PHÒNG BAN";
            // 
            // cb_phongban
            // 
            this.cb_phongban.FormattingEnabled = true;
            this.cb_phongban.Location = new System.Drawing.Point(876, 74);
            this.cb_phongban.Name = "cb_phongban";
            this.cb_phongban.Size = new System.Drawing.Size(226, 24);
            this.cb_phongban.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(516, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "THÂM NIÊN";
            // 
            // txt_thamnien
            // 
            this.txt_thamnien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_thamnien.Location = new System.Drawing.Point(615, 154);
            this.txt_thamnien.Multiline = true;
            this.txt_thamnien.Name = "txt_thamnien";
            this.txt_thamnien.Size = new System.Drawing.Size(80, 31);
            this.txt_thamnien.TabIndex = 12;
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_them.Location = new System.Drawing.Point(94, 293);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(85, 35);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_capnhat.Location = new System.Drawing.Point(236, 293);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(100, 35);
            this.btn_capnhat.TabIndex = 14;
            this.btn_capnhat.Text = "Cập Nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_xoa.Location = new System.Drawing.Point(382, 293);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 35);
            this.btn_xoa.TabIndex = 15;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_dong.Location = new System.Drawing.Point(524, 293);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(70, 35);
            this.btn_dong.TabIndex = 16;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // dataGridView_quanlynhanvien
            // 
            this.dataGridView_quanlynhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_quanlynhanvien.Location = new System.Drawing.Point(94, 364);
            this.dataGridView_quanlynhanvien.Name = "dataGridView_quanlynhanvien";
            this.dataGridView_quanlynhanvien.RowHeadersWidth = 51;
            this.dataGridView_quanlynhanvien.RowTemplate.Height = 24;
            this.dataGridView_quanlynhanvien.Size = new System.Drawing.Size(983, 450);
            this.dataGridView_quanlynhanvien.TabIndex = 17;
            this.dataGridView_quanlynhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_quanlynhanvien_CellClick);
            // 
            // frm_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 826);
            this.Controls.Add(this.dataGridView_quanlynhanvien);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_thamnien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_phongban);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_dem);
            this.Controls.Add(this.dt_ngayvaolam);
            this.Controls.Add(this.txt_dem);
            this.Controls.Add(this.txt_hoten);
            this.Controls.Add(this.txt_msnv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_QuanLyNhanVien";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_quanlynhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_msnv;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_dem;
        private System.Windows.Forms.DateTimePicker dt_ngayvaolam;
        private System.Windows.Forms.Button btn_dem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_phongban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_thamnien;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.DataGridView dataGridView_quanlynhanvien;
    }
}