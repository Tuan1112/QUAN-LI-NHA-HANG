using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_Nha_Hang.Model;

namespace QL_Nha_Hang
{
    public partial class QuanLyBanForm : Form
    {
        private Model1 db; // Đối tượng kết nối Entity Framework

        public QuanLyBanForm()
        {
            InitializeComponent();
            db = new Model1();
            LoadBan(); // Tải danh sách bàn
        }

        // Tải danh sách bàn vào DataGridView
        private void LoadBan()
        {
            // Lấy danh sách bàn từ cơ sở dữ liệu
            var danhSachBan = db.Bans.Select(b => new
            {
                MaBan = b.MaBan,
                TenBan = b.TenBan,
                TrangThai = b.TrangThai
            }).ToList();

            // Gán dữ liệu vào DataGridView
            dgvBan.DataSource = danhSachBan;

            // Cấu hình tiêu đề cột
            dgvBan.Columns["MaBan"].HeaderText = "Mã Bàn";
            dgvBan.Columns["TenBan"].HeaderText = "Tên Bàn";
            dgvBan.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }
        // Thêm bàn mới
        private void btnThemban_Click(object sender, EventArgs e)
        {
            string tenBan = txtTenban.Text;
            string trangThai = cboTrangthai.Text;

            if (!string.IsNullOrWhiteSpace(tenBan) && !string.IsNullOrWhiteSpace(trangThai))
            {
                var ban = new Ban { TenBan = tenBan, TrangThai = trangThai };
                db.Bans.Add(ban);
                db.SaveChanges();
                LoadBan();
                MessageBox.Show("Thêm bàn mới thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        // Xóa bàn được chọn
        private void btnXoaban_Click(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow != null)
            {
                int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);
                var ban = db.Bans.Find(maBan);
                if (ban != null)
                {
                    db.Bans.Remove(ban);
                    db.SaveChanges();
                    LoadBan();
                    MessageBox.Show("Xóa bàn thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn cần xóa!");
            }
        }

        // Cập nhật trạng thái bàn
        private void btnCapnhattrangthai_Click(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow != null)
            {
                int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);
                var ban = db.Bans.Find(maBan);
                if (ban != null)
                {
                    ban.TrangThai = cboTrangthai.Text;
                    db.SaveChanges();
                    LoadBan();
                    MessageBox.Show("Cập nhật trạng thái thành công!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn bàn để cập nhật trạng thái!");
            }
        }

        private void btnDatbantrong_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (dgvBan.CurrentRow != null)
            {
                // Lấy mã bàn từ DataGridView
                int maBan = Convert.ToInt32(dgvBan.CurrentRow.Cells["MaBan"].Value);

                // Kiểm tra trạng thái bàn
                var ban = db.Bans.Find(maBan);
                if (ban != null && ban.TrangThai == "Đang phục vụ")
                {
                    // Mở form ThanhToanForm
                    ThanhToanForm formThanhToan = new ThanhToanForm(maBan);
                    formThanhToan.ShowDialog();

                    // Cập nhật lại danh sách bàn sau khi thanh toán
                    LoadBan();
                }
                else
                {
                    MessageBox.Show("Chỉ có thể thanh toán bàn đang ở trạng thái 'Đang phục vụ'!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để thanh toán!");
            }
        }

        private void dgvBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBan.Rows[e.RowIndex];
                txtTenban.Text = row.Cells["TenBan"].Value.ToString();
                cboTrangthai.SelectedItem = row.Cells["TrangThai"].Value.ToString();
            }
        }

    }
}
