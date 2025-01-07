using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using QL_Nha_Hang.Model;

namespace QL_Nha_Hang
{
    public partial class Form1 : Form
    {
        private Model1 db; // Đối tượng kết nối Entity Framework

        public Form1()
        {
            InitializeComponent();
            db = new Model1(); // Khởi tạo kết nối database
            LoadDanhSachBan(); // Tải danh sách bàn vào ComboBox
            LoadMenu();        // Tải danh sách món ăn vào FlowLayoutPanel
            UpdateTongGia();   // Cập nhật tổng giá
        }

        // Tải danh sách bàn vào ComboBox
        private void LoadDanhSachBan()
        {
            var danhSachBan = db.Bans.OrderBy(b => b.MaBan).ToList(); // Lấy danh sách bàn
            cboBan.DataSource = danhSachBan;
            cboBan.DisplayMember = "TenBan"; // Hiển thị tên bàn
            cboBan.ValueMember = "MaBan";    // Lưu mã bàn
        }

        // Hiển thị danh sách món ăn trên FlowLayoutPanel
        private void LoadMenu()
        {
            flpMenu.Controls.Clear(); // Xóa các món ăn cũ trên FlowLayoutPanel

            // Lấy danh sách món ăn từ cơ sở dữ liệu
            var menu = db.MonAns.ToList();

            foreach (var mon in menu)
            {
                // Tạo Panel cho mỗi món ăn
                Panel panel = new Panel
                {
                    Width = 380,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Label: Tên món ăn
                Label lblTenMon = new Label
                {
                    Text = mon.TenMonAn,
                    Location = new Point(10, 10),
                    Size = new Size(250, 20)
                };
                panel.Controls.Add(lblTenMon);

                // Label: Giá món ăn
                Label lblGia = new Label
                {
                    Text = $"Giá: {mon.Gia:N0} VND",
                    Location = new Point(10, 40),
                    Size = new Size(200, 20)
                };
                panel.Controls.Add(lblGia);

                // NumericUpDown: Số lượng
                NumericUpDown numSoLuong = new NumericUpDown
                {
                    Minimum = 1,
                    Maximum = 100,
                    Value = 1,
                    Location = new Point(270, 10),
                    Size = new Size(60, 20)
                };
                panel.Controls.Add(numSoLuong);

                // Button: Chọn món
                Button btnChon = new Button
                {
                    Text = "Chọn",
                    Location = new Point(270, 40),
                    Size = new Size(70, 30),
                    Tag = new { mon.MaMonAn, mon.TenMonAn, mon.Gia, SoLuong = numSoLuong }
                };
                btnChon.Click += BtnChon_Click;
                panel.Controls.Add(btnChon);

                flpMenu.Controls.Add(panel);
            }
        }

        // Xử lý sự kiện khi chọn món ăn
        private void BtnChon_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null && btn.Tag != null)
            {
                dynamic tag = btn.Tag;
                string tenMonAn = tag.TenMonAn;
                decimal gia = tag.Gia;
                NumericUpDown numSoLuong = tag.SoLuong;

                int soLuong = (int)numSoLuong.Value;

                // Kiểm tra xem món đã có trong ListView chưa
                var existingItem = lvSelectedItems.Items
                    .Cast<ListViewItem>()
                    .FirstOrDefault(item => item.Text == tenMonAn);

                if (existingItem != null)
                {
                    // Nếu món đã tồn tại, cập nhật số lượng và giá
                    int currentSoLuong = int.Parse(existingItem.SubItems[1].Text);
                    existingItem.SubItems[1].Text = (currentSoLuong + soLuong).ToString();
                    existingItem.SubItems[2].Text = $"{(currentSoLuong + soLuong) * gia:N0} VND";
                }
                else
                {
                    // Nếu món chưa tồn tại, thêm mới
                    var item = new ListViewItem(tenMonAn); // Cột 1: Tên món
                    item.SubItems.Add(soLuong.ToString()); // Cột 2: Số lượng
                    item.SubItems.Add($"{soLuong * gia:N0} VND"); // Cột 3: Giá
                    lvSelectedItems.Items.Add(item);
                }

                // Gọi UpdateTongGia để cập nhật tổng giá
                UpdateTongGia();
            }
        }
        // Xử lý đặt món
        private void btnDatmon_Click(object sender, EventArgs e)
        {
            // Lấy bàn được chọn từ ComboBox
            int maBan = (int)cboBan.SelectedValue;

            // Kiểm tra bàn có tồn tại không
            var ban = db.Bans.Find(maBan);
            if (ban != null)
            {
                // Tạo hoặc lấy đơn hàng chưa thanh toán của bàn
                var donHang = GetOrCreateDonHang(maBan);

                // Thêm các món ăn trong ListView vào đơn hàng
                foreach (ListViewItem item in lvSelectedItems.Items)
                {
                    string tenMonAn = item.SubItems[0].Text;
                    int soLuong = int.Parse(item.SubItems[1].Text);
                    decimal gia = decimal.Parse(item.SubItems[2].Text.Replace(" VND", "").Replace(",", ""));

                    // Lấy thông tin món ăn từ cơ sở dữ liệu
                    var monAn = db.MonAns.FirstOrDefault(m => m.TenMonAn == tenMonAn);
                    if (monAn != null)
                    {
                        AddMonToDonHang(donHang.MaDonHang, monAn.MaMonAn, soLuong);
                    }
                }

                // Cập nhật trạng thái bàn
                ban.TrangThai = "Đang phục vụ";
                db.SaveChanges();

                // Thông báo thành công
                MessageBox.Show($"Đã thêm món ăn vào bàn {ban.TenBan}.");

                // Xóa danh sách món đã chọn sau khi đặt
                lvSelectedItems.Items.Clear();
            }
            else
            {
                MessageBox.Show("Bàn không tồn tại.");
            }
        }
        private DonHang GetOrCreateDonHang(int maBan)
        {
            // Tìm đơn hàng chưa thanh toán của bàn
            var donHang = db.DonHangs.FirstOrDefault(dh => dh.MaBan == maBan && dh.TrangThai == "Chưa thanh toán");
            if (donHang == null)
            {
                // Tạo đơn hàng mới nếu chưa có
                donHang = new DonHang
                {
                    MaBan = maBan,
                    MaNhanVien = 1, // Giả định nhân viên ID = 1, có thể thay bằng ComboBox chọn nhân viên
                    TrangThai = "Chưa thanh toán",
                    NgayDat = DateTime.Now
                };
                db.DonHangs.Add(donHang);
                db.SaveChanges();
            }
            return donHang;
        }
        private void AddMonToDonHang(int maDonHang, int maMonAn, int soLuong)
        {
            // Kiểm tra món ăn đã có trong đơn hàng chưa
            var chiTiet = db.ChiTietDonHangs
                .FirstOrDefault(ct => ct.MaDonHang == maDonHang && ct.MaMonAn == maMonAn);

            if (chiTiet != null)
            {
                // Cập nhật số lượng nếu món ăn đã tồn tại trong đơn hàng
                chiTiet.SoLuong += soLuong;
            }
            else
            {
                // Thêm món ăn mới vào đơn hàng
                var monAn = db.MonAns.Find(maMonAn);
                if (monAn != null)
                {
                    chiTiet = new ChiTietDonHang
                    {
                        MaDonHang = maDonHang,
                        MaMonAn = maMonAn,
                        SoLuong = soLuong,
                        DonGia = monAn.Gia
                    };
                    db.ChiTietDonHangs.Add(chiTiet);
                }
            }

            db.SaveChanges();
        }
        private void UpdateTongGia()
        {
            decimal tongGia = 0;

            foreach (ListViewItem item in lvSelectedItems.Items)
            {
                // Lấy giá trị từ cột "Giá" và chuyển thành số
                string giaText = item.SubItems[2].Text.Replace(" VND", "").Replace(",", "");
                tongGia += decimal.Parse(giaText);
            }

            // Cập nhật tổng giá vào Label
            lblTongGia.Text = $"Tổng giá: {tongGia:N0} VND";
        }
        // Mở giao diện quản lý bàn
        private void btnQuanlyban_Click(object sender, EventArgs e)
        {
            QuanLyBanForm formQuanlyban = new QuanLyBanForm();
            formQuanlyban.ShowDialog();
        }
    }
}
