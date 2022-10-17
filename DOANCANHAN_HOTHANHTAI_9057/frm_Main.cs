using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }
        LoadingFormFunction loadingFormFunc = new LoadingFormFunction();
        private void danhSáchPhòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                loadingFormFunc.Show(this);
                Thread.Sleep(3000);
                if (Application.OpenForms["frm_PhongBan"] == null)
                {
                    frm_PhongBan pb = new frm_PhongBan();
                    pb.MdiParent = this;
                    pb.Show();
                }
                else
                {
                    Application.OpenForms["frm_PhongBan"].Activate();
                }
                loadingFormFunc.Close();
            }
            catch
            {

            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                loadingFormFunc.Show(this);
                Thread.Sleep(3000);
                if (Application.OpenForms["frm_QuanLyNhanVien"] == null)
                {
                    frm_QuanLyNhanVien nv = new frm_QuanLyNhanVien();
                    nv.MdiParent = this;
                    nv.Show();
                }
                else
                {
                    Application.OpenForms["frm_QuanLyNhanVien"].Activate();
                }
                loadingFormFunc.Close();
            }
            catch
            {

            }
        }
    }
}
