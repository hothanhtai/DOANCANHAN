using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOANCANHAN_HOTHANHTAI_9057
{
    public partial class frm_PhongBan : Form
    {
        public frm_PhongBan()
        {
            InitializeComponent();
        }
        LOPDUNGCHUNG lopchung = new LOPDUNGCHUNG();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mapb.Text) || string.IsNullOrEmpty(txt_tenpb.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Cảnh báo");
            }else
            {

                string cmd = "INSERT INTO PHONGBAN VALUES(N'"+txt_mapb.Text+"',N'"+txt_tenpb.Text+"')";
                int kq = lopchung.ThemSuaXoa(cmd);
                if (kq >= 1)
                {
                    MessageBox.Show("Thêm phòng ban thành công", "Thông báo");
                    txt_mapb.Text = "";
                    txt_tenpb.Text = "";
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                HienThi();
            }

        }

        private void frm_PhongBan_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM PHONGBAN";
            dataGridView_phongban.DataSource = lopchung.LoadDL(cmd);
        }
        public void HienThi()
        {
            string cmd = "SELECT * FROM PHONGBAN";
            dataGridView_phongban.DataSource = lopchung.LoadDL(cmd);
        }
        private void dataGridView_phongban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_mapb.Text = dataGridView_phongban.CurrentRow.Cells["MAPB"].Value.ToString();
            txt_tenpb.Text = dataGridView_phongban.CurrentRow.Cells["TENPB"].Value.ToString();

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string cmd = "UPDATE PHONGBAN SET TENPB = N'"+txt_tenpb.Text+"' WHERE MAPB = N'"+txt_mapb.Text+"'";
            int kq = lopchung.ThemSuaXoa(cmd);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhật phòng ban thành công!", "Thông báo");
                txt_mapb.Text = "";
                txt_tenpb.Text = "";
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!", "Thông báo");
            }
            HienThi();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mapb.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phòng ban cần xóa!");
            }
            else
            {
                DialogResult dialog = MessageBox.Show($"Bạn có thật sự muốn xóa mã phong ban {txt_mapb.Text}?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialog == DialogResult.OK)
                {
                    string cmd = "DELETE FROM PHONGBAN WHERE MAPB = N'" + txt_mapb.Text + "'";
                    int kq = lopchung.ThemSuaXoa(cmd);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Xóa phòng ban thành công!", "Thông báo");
                        txt_mapb.Text = "";
                        txt_tenpb.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!", "Thông báo");
                    }
                    HienThi();
                }
            }
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có thật sự muốn thoát?", "cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(dialog == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
