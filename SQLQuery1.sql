-- Tạo cơ sở dữ liệu
CREATE DATABASE QuanLyNhaHang;
GO

USE QuanLyNhaHang;

-- Tạo bảng Ban
CREATE TABLE Ban (
    MaBan INT IDENTITY(1,1) PRIMARY KEY,
    TenBan NVARCHAR(100) NOT NULL,
    TrangThai NVARCHAR(50) NOT NULL
);

-- Tạo bảng MonAn
CREATE TABLE MonAn (
    MaMonAn INT IDENTITY(1,1) PRIMARY KEY,
    TenMonAn NVARCHAR(100) NOT NULL,
    Gia DECIMAL(18, 2) NOT NULL CHECK (Gia > 0),
    DanhMuc NVARCHAR(50),
    LoaiMon NVARCHAR(50) NOT NULL DEFAULT N'Món chính'
);

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNhanVien INT IDENTITY(1,1) PRIMARY KEY,
    TenNhanVien NVARCHAR(100) NOT NULL
);

-- Tạo bảng DonHang
CREATE TABLE DonHang (
    MaDonHang INT IDENTITY(1,1) PRIMARY KEY,
    MaBan INT NOT NULL FOREIGN KEY REFERENCES Ban(MaBan),
    NgayDat DATETIME NOT NULL DEFAULT GETDATE(),
    MaNhanVien INT NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNhanVien),
    TongTien DECIMAL(18, 2),
    TrangThai NVARCHAR(50) CHECK (TrangThai IN (N'Đã thanh toán', N'Chưa thanh toán'))
);

-- Tạo bảng ChiTietDonHang
CREATE TABLE ChiTietDonHang (
    MaChiTiet INT IDENTITY(1,1) PRIMARY KEY,
    MaDonHang INT NOT NULL FOREIGN KEY REFERENCES DonHang(MaDonHang),
    MaMonAn INT NOT NULL FOREIGN KEY REFERENCES MonAn(MaMonAn),
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGia DECIMAL(18, 2) NOT NULL,
    ThanhTien AS (SoLuong * DonGia)
);

-- Tạo bảng ThongKe
CREATE TABLE ThongKe (
    MaThongKe INT IDENTITY(1,1) PRIMARY KEY,
    NgayThanhToan DATE NOT NULL,
    MaBan INT NOT NULL FOREIGN KEY REFERENCES Ban(MaBan),
    TongTien DECIMAL(18, 2) NOT NULL
);
ALTER TABLE ThongKe
ADD NgayBatDau DATE,
    NgayKetThuc DATE;


INSERT INTO Ban (TenBan, TrangThai)
VALUES 
    ('Bàn 1', 'Trống'),
    ('Bàn 2', 'Trống'),
    ('Bàn 3', 'Trống'),
    ('Bàn 4', 'Trống'),
	('Bàn 5', 'Trống'),
	('Bàn 6', 'Trống'),
	('Bàn 7', 'Trống'),
	('Bàn 8', 'Trống'),
	('Bàn 9', 'Trống'),
    ('Bàn 10', 'Trống');

INSERT INTO MonAn (TenMonAn, Gia, DanhMuc) VALUES
(N'Phở bò', 50000, N'Món chính'),
(N'Cơm chiên dương châu', 50000, N'Món chính'),
(N'Hủ tíu', 50000, N'Món chính'),
(N'Lẩu hải sản', 50000, N'Món chính'),
(N'Gà nướng', 50000, N'Món chính'),
(N'Sting', 20000, N'Đồ uống'),
(N'Coca', 20000, N'Đồ uống'),
(N'Nước suối', 20000, N'Đồ uống'),
(N'Cà phê sữa', 20000, N'Đồ uống'),
(N'Sinh tố bơ', 20000, N'Đồ uống');


INSERT INTO NhanVien (TenNhanVien) VALUES
(N'Nguyễn Văn An'),
(N'Lê Thị Bình'),
(N'Trần Văn Chữ'),
(N'Phạm Thị Thùy Duyên'),
(N'Lê Thị Em');
INSERT INTO DonHang (MaBan, NgayDat, MaNhanVien, TongTien, TrangThai)
VALUES 
    (1, '2025-01-07', 1, NULL, N'Đã thanh toán'),
    (2, '2025-01-07', 2, NULL, N'Chưa thanh toán'),
    (3, '2025-01-07', 3, NULL, N'Đã thanh toán');

-- Chèn dữ liệu mẫu vào bảng ChiTietDonHang
INSERT INTO ChiTietDonHang (MaDonHang, MaMonAn, SoLuong, DonGia)
VALUES
    (1, 1, 2, 50000),
    (1, 4, 1, 10000),
    (3, 2, 1, 45000),
    (3, 3, 1, 40000);
-- Tính và cập nhật TongTien trong bảng DonHang
UPDATE DonHang
SET TongTien = (
    SELECT SUM(SoLuong * DonGia)
    FROM ChiTietDonHang
    WHERE ChiTietDonHang.MaDonHang = DonHang.MaDonHang
);

-- Tính và chèn dữ liệu vào bảng ThongKe
INSERT INTO ThongKe (NgayThanhToan, MaBan, TongTien)
SELECT 
    CAST(NgayDat AS DATE) AS NgayThanhToan,
    MaBan,
    SUM(TongTien)
FROM 
    DonHang
WHERE 
    TrangThai = N'Đã thanh toán'
GROUP BY 
    CAST(NgayDat AS DATE), MaBan;

	UPDATE ThongKe
SET TongTien = (
    SELECT SUM(ct.SoLuong * ct.DonGia)
    FROM ChiTietDonHang ct
    JOIN DonHang dh ON ct.MaDonHang = dh.MaDonHang
    WHERE dh.MaBan = ThongKe.MaBan
      AND dh.TrangThai = N'Đã thanh toán'
)
WHERE EXISTS (
    SELECT 1
    FROM ChiTietDonHang ct
    JOIN DonHang dh ON ct.MaDonHang = dh.MaDonHang
    WHERE dh.MaBan = ThongKe.MaBan
      AND dh.TrangThai = N'Đã thanh toán'
);
