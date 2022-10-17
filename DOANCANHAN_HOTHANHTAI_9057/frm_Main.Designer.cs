
namespace DOANCANHAN_HOTHANHTAI_9057
{
    partial class frm_Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhSáchPhòngBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhSáchPhòngBanToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(739, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhSáchPhòngBanToolStripMenuItem
            // 
            this.danhSáchPhòngBanToolStripMenuItem.Name = "danhSáchPhòngBanToolStripMenuItem";
            this.danhSáchPhòngBanToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.danhSáchPhòngBanToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.danhSáchPhòngBanToolStripMenuItem.Text = "&Danh Sách Phòng Ban";
            this.danhSáchPhòngBanToolStripMenuItem.Click += new System.EventHandler(this.danhSáchPhòngBanToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.quảnLýNhânViênToolStripMenuItem.Text = "&Quản Lý Nhân Viên";
            this.quảnLýNhânViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Main";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhSáchPhòngBanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
    }
}