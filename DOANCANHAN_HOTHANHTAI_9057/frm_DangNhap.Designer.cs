using System.Windows.Forms;
using System.Data.SqlClient;
using System;
using System.Threading;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    partial class frm_DangNhap
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
            this.txt_username = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Meetei Mayek", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Meetei Mayek", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Mono SemCond", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(292, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGIN";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Location = new System.Drawing.Point(260, 132);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(236, 22);
            this.txt_username.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Turquoise;
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_login.Location = new System.Drawing.Point(147, 253);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(96, 40);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_password.Location = new System.Drawing.Point(260, 194);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(236, 22);
            this.txt_password.TabIndex = 5;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Crimson;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(270, 253);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(666, 419);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frm_DangNhap";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        LoadingFormFunction loadingFormFunc = new LoadingFormFunction();
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.OK) {
                Application.Exit();
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Vui lòng điển tên đăng nhập hoặc mật khẩu để đăng nhập!", "Cảnh báo!");
            }
            else
            {
                string sql = "SELECT COUNT (*) FROM TAIKHOAN WHERE TENDANGNHAP = '"+txt_username.Text+"' AND MATKHAU = '"+txt_password.Text+"'";
                int kq = (int)lopchung.TraGiaTri(sql);
                if (kq >= 1)
                {
                    try
                    {
                        loadingFormFunc.Show(this);
                        Thread.Sleep(3000);
                        if (Application.OpenForms["frm_Main"] == null)
                        {
                            frm_Main main = new frm_Main();
                            main.Show();
                        }
                        else
                        {
                            Application.OpenForms["frm_Main"].Activate();
                        }
                        loadingFormFunc.Close();
                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công, vui lòng kiểm tra lại tên đăng nhập và mật khẩu!","Cảnh báo đăng nhập");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button button2;
        private TextBox txt_password;
    }
}