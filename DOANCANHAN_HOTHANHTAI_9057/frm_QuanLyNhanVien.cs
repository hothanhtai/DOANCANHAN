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
    public partial class frm_QuanLyNhanVien : Form
    {
        public frm_QuanLyNhanVien()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void frm_QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            HienThi();
            string cmd = "SELECT * FROM PHONGBAN";
            DataTable dt = lopchung.LoadDL(cmd);
            cb_phongban.DataSource = dt;
            cb_phongban.DisplayMember = "TENPB";
            cb_phongban.ValueMember = "MAPB";
        }
        public void HienThi()
        {
            string cmd = "SELECT * FROM NHANVIEN";
            dataGridView_quanlynhanvien.DataSource = lopchung.LoadDL(cmd);
        }
        private void dt_ngayvaolam_CloseUp(object sender, EventArgs e)
        {
           
            DateTime date = DateTime.Now;
            int namhientai = (int)date.Year;
            int namvaolam = (int)dt_ngayvaolam.Value.Year;
            int tinh = namhientai - namvaolam + 1;
            txt_thamnien.Text = tinh.ToString();
        }

        private void btn_dem_Click(object sender, EventArgs e)
        {
            string cmd = "SELECT COUNT (MSNV) FROM NHANVIEN";
            int kq = (int)lopchung.TraGiaTri(cmd);
            txt_dem.Text = kq.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_msnv.Text) || string.IsNullOrEmpty(txt_hoten.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo");
            }
            else
            {
                string cmd = "INSERT INTO NHANVIEN VALUES(N'"+txt_msnv.Text+"',N'"+txt_hoten.Text+"',N'"+cb_phongban.SelectedValue+"',Convert(datetime,N'" + dt_ngayvaolam.Text + "',103),N'"+txt_thamnien.Text+"')";
                int kq = lopchung.ThemSuaXoa(cmd);
                if(kq >= 1)
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo");
                }
                HienThi();
                txt_msnv.Text = "";
                txt_hoten.Text = "";
                txt_thamnien.Text = "";
                dt_ngayvaolam.Text = "";
                txt_thamnien.Text = "";
            }
        }

      

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_msnv.Text)){
                MessageBox.Show("Vui lòng nhập mã nhân viên cần xóa!", "Thông báo");
            }
            else
            {
                DialogResult dialog = MessageBox.Show($"Bạn có thật sự muốn xóa mã nhân viên {txt_msnv.Text} ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialog == DialogResult.OK)
                {
                    string cmd = "DELETE FROM NHANVIEN WHERE MSNV = N'"+txt_msnv.Text+"'";
                    int kq= lopchung.ThemSuaXoa(cmd);
                    if(kq >= 1)
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên thất bại!", "Thông báo");
                    }
                    HienThi();
                    txt_msnv.Text = "";
                    txt_hoten.Text = "";
                    txt_thamnien.Text = "";
                    dt_ngayvaolam.Text = "";
                    txt_thamnien.Text = "";
                }
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE NHANVIEN SET HOTEN = N'"+txt_hoten.Text+"',MAPB = '"+cb_phongban.SelectedValue+"',NGAYVAOLAM = CONVERT(DATETIME,N'"+dt_ngayvaolam.Text+"',103),THAMNIEN = N'"+txt_thamnien.Text+"' WHERE MSNV = N'"+txt_msnv.Text+"'";
            int kq = lopchung.ThemSuaXoa(cmd);
            if(kq >= 1)
            {
                MessageBox.Show("Update nhân viên thành công!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Update nhân viên thất bại!", "Thông báo");
            }
            HienThi();
            txt_msnv.Text = "";
            txt_hoten.Text = "";
            txt_thamnien.Text = "";
            dt_ngayvaolam.Text = "";
            txt_thamnien.Text = "";
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void dataGridView_quanlynhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_msnv.Text = dataGridView_quanlynhanvien.CurrentRow.Cells["MSNV"].Value.ToString();
            txt_hoten.Text = dataGridView_quanlynhanvien.CurrentRow.Cells["HOTEN"].Value.ToString();
            dt_ngayvaolam.Text = dataGridView_quanlynhanvien.CurrentRow.Cells["NGAYVAOLAM"].Value.ToString();
            cb_phongban.SelectedValue = dataGridView_quanlynhanvien.CurrentRow.Cells["MAPB"].Value.ToString();
            txt_thamnien.Text = dataGridView_quanlynhanvien.CurrentRow.Cells["THAMNIEN"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadingFormFunction loadingFormFunc = new LoadingFormFunction();
            loadingFormFunc.Show(this);
            Thread.Sleep(3000);
            if(Application.OpenForms["frm_PhongBan"] == null)
            {

                frm_PhongBan bp = new frm_PhongBan();
                bp.MdiParent = this;
                bp.Show();
            }else
            {
                Application.OpenForms["frm_PhongBan"].Activate();
            }
            loadingFormFunc.Close();
        }
    }
}
