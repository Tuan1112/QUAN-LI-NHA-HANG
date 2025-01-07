using System;
using System.Linq;
using System.Windows.Forms;
using QL_Nha_Hang.Model; // Namespace chứa các entity của bạn

namespace QL_Nha_Hang
{
    public partial class ThongKeForm : Form
    {
        private Model1 db; // Đối tượng kết nối Entity Framework

        public ThongKeForm()
        {
            InitializeComponent();
            db = new Model1(); // Khởi tạo kết nối database
        }

        // Xử lý khi nhấn nút Thống Kê
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime ngayBatDau = dtpNgayBatDau.Value.Date;
                DateTime ngayKetThuc = dtpNgayKetThuc.Value.Date.AddDays(1).AddSeconds(-1); // Lấy đến cuối ngày

                // Lấy dữ liệu thống kê từ database
                var thongKeData = db.DonHangs
                    .Where(dh => dh.TrangThai == "Đã thanh toán" &&
                                 dh.NgayDat >= ngayBatDau &&
                                 dh.NgayDat <= ngayKetThuc)
                    .Select(dh => new
                    {
                        dh.MaDonHang,
                        dh.MaBan,
                        TenBan = dh.Ban.TenBan,
                        TenNhanVien = dh.NhanVien.TenNhanVien, // Thêm tên nhân viên
                        dh.NgayDat,
                        TongTien = dh.ChiTietDonHangs
                            .Sum(ct => (decimal?)ct.SoLuong * ct.DonGia) ?? 0 // Tổng tiền hóa đơn, xử lý null
                    })
                    .ToList();

                // Gán dữ liệu vào DataGridView
                dgvThongKe.DataSource = thongKeData;

                // Đặt tên cột cho DataGridView
                dgvThongKe.Columns["MaDonHang"].HeaderText = "Mã Đơn Hàng";
                dgvThongKe.Columns["MaBan"].HeaderText = "Mã Bàn";
                dgvThongKe.Columns["TenBan"].HeaderText = "Tên Bàn";
                dgvThongKe.Columns["TenNhanVien"].HeaderText = "Nhân Viên Thanh Toán"; // Tên cột mới
                dgvThongKe.Columns["NgayDat"].HeaderText = "Ngày Đặt";
                dgvThongKe.Columns["TongTien"].HeaderText = "Tổng Tiền (VND)";

                // Tính tổng doanh thu
                var tongDoanhThu = thongKeData.Sum(dh => dh.TongTien);
                lblTongDoanhThu.Text = $"Tổng doanh thu: {tongDoanhThu:N0} VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
