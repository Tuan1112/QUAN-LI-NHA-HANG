using System;
using System.Linq;
using System.Windows.Forms;
using QL_Nha_Hang.Model;

namespace QL_Nha_Hang
{
    public partial class ThanhToanForm : Form
    {
        private int maBan;
        private Model1 db;

        public ThanhToanForm(int maBan)
        {
            InitializeComponent();
            db = new Model1();
            this.maBan = maBan;
            LoadData();
            LoadDanhSachBan();
        }

        private void LoadData()
        {
            if (maBan != 0)
            {
                var monanDaGoi = db.ChiTietDonHangs
                    .Where(ct => ct.DonHang.MaBan == maBan && ct.DonHang.TrangThai == "Chưa thanh toán")
                    .Select(ct => new
                    {
                        TênMónĂn = ct.MonAn.TenMonAn,
                        SốLượng = ct.SoLuong,
                        ĐơnGiá = ct.DonGia,
                        ThànhTiền = ct.SoLuong * ct.DonGia
                    }).ToList();

                // Gán dữ liệu cho DataGridView
                dgvMonan.DataSource = monanDaGoi;

                // Tùy chỉnh tiêu đề cột (đã đặt tên tiếng Việt từ truy vấn LINQ)
                dgvMonan.Columns["TênMónĂn"].HeaderText = "Tên Món Ăn";
                dgvMonan.Columns["SốLượng"].HeaderText = "Số Lượng";
                dgvMonan.Columns["ĐơnGiá"].HeaderText = "Đơn Giá";
                dgvMonan.Columns["ThànhTiền"].HeaderText = "Thành Tiền";

                // Tính tổng tiền
                var tongTien = monanDaGoi.Sum(m => m.ThànhTiền);
                txtTongtien.Text = $"{tongTien:N0} VND";

                // Load danh sách nhân viên
                var nhanViens = db.NhanViens.ToList();
                cboNhanvien.DataSource = nhanViens;
                cboNhanvien.DisplayMember = "TenNhanVien";
                cboNhanvien.ValueMember = "MaNhanVien";
            }
        }
        private void LoadDanhSachBan()
        {
            var danhSachBan = db.Bans
                .Where(b => b.TrangThai == "Đang phục vụ")
                .OrderBy(b => b.MaBan)
                .ToList();

            cboBan.DataSource = danhSachBan;
            cboBan.DisplayMember = "TenBan";
            cboBan.ValueMember = "MaBan";
        }

        private void cboBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBan.SelectedValue != null)
            {
                if (int.TryParse(cboBan.SelectedValue.ToString(), out int selectedMaBan))
                {
                    maBan = selectedMaBan;
                    LoadData();
                }
                else
                {
                }
            }
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (maBan != 0)
            {
                // Lấy đơn hàng chưa thanh toán
                var donHang = db.DonHangs.FirstOrDefault(dh => dh.MaBan == maBan && dh.TrangThai == "Chưa thanh toán");

                if (donHang != null)
                {
                    // Cập nhật trạng thái đơn hàng
                    donHang.TrangThai = "Đã thanh toán";
                    donHang.MaNhanVien = (int)cboNhanvien.SelectedValue;

                    // Cập nhật trạng thái bàn
                    var ban = db.Bans.Find(maBan);
                    if (ban != null)
                    {
                        ban.TrangThai = "Trống";
                    }

                    // Lưu vào bảng ThongKe
                    var thongKe = new ThongKe
                    {
                        NgayThanhToan = DateTime.Now,
                        MaBan = maBan,
                        TongTien = donHang.TongTien ?? 0
                    };
                    db.ThongKes.Add(thongKe);

                    db.SaveChanges();

                    MessageBox.Show("Thanh toán thành công!");
                    LoadDanhSachBan(); // Cập nhật danh sách bàn
                    dgvMonan.DataSource = null; // Xóa danh sách món
                    txtTongtien.Text = "0 VND"; // Đặt lại tổng tiền
                }
                else
                {
                    MessageBox.Show("Không tìm thấy đơn hàng chưa thanh toán cho bàn này!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để thanh toán!");
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
