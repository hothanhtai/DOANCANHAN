
namespace DOANCANHAN_HOTHANHTAI_9057
{
    partial class frm_PhongBan
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
            this.txt_mapb = new System.Windows.Forms.TextBox();
            this.txt_tenpb = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_dong = new System.Windows.Forms.Button();
            this.dataGridView_phongban = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongban)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(265, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHÒNG BAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(73, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ PHÒNG BAN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(73, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÊN PHÒNG BAN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_mapb
            // 
            this.txt_mapb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_mapb.Location = new System.Drawing.Point(270, 77);
            this.txt_mapb.Name = "txt_mapb";
            this.txt_mapb.Size = new System.Drawing.Size(222, 22);
            this.txt_mapb.TabIndex = 3;
            // 
            // txt_tenpb
            // 
            this.txt_tenpb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_tenpb.Location = new System.Drawing.Point(270, 154);
            this.txt_tenpb.Name = "txt_tenpb";
            this.txt_tenpb.Size = new System.Drawing.Size(222, 22);
            this.txt_tenpb.TabIndex = 4;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(76, 229);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(192, 229);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 6;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(313, 229);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_dong
            // 
            this.btn_dong.Location = new System.Drawing.Point(590, 229);
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.Size = new System.Drawing.Size(75, 23);
            this.btn_dong.TabIndex = 8;
            this.btn_dong.Text = "Đóng";
            this.btn_dong.UseVisualStyleBackColor = true;
            this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
            // 
            // dataGridView_phongban
            // 
            this.dataGridView_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_phongban.Location = new System.Drawing.Point(192, 327);
            this.dataGridView_phongban.Name = "dataGridView_phongban";
            this.dataGridView_phongban.RowHeadersWidth = 51;
            this.dataGridView_phongban.RowTemplate.Height = 24;
            this.dataGridView_phongban.Size = new System.Drawing.Size(358, 230);
            this.dataGridView_phongban.TabIndex = 9;
            this.dataGridView_phongban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_phongban_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(283, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "DANH SÁCH PHÒNG BAN";
            // 
            // frm_PhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_phongban);
            this.Controls.Add(this.btn_dong);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.txt_tenpb);
            this.Controls.Add(this.txt_mapb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "frm_PhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PhongBan";
            this.Load += new System.EventHandler(this.frm_PhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_phongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mapb;
        private System.Windows.Forms.TextBox txt_tenpb;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_dong;
        private System.Windows.Forms.DataGridView dataGridView_phongban;
        private System.Windows.Forms.Label label4;
    }
}