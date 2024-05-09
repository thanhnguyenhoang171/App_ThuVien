--create database QuanLyThuVien;

use QuanLyThuVien
GO
-- Tạo bảng "Books"
CREATE TABLE Sach (
    ma_sach VARCHAR(5) PRIMARY KEY,
    ten_sach NVARCHAR(255),
    tac_gia NVARCHAR(100),
    the_loai NVARCHAR(50),
    so_luong_hien_co INT,
    mo_ta NVARCHAR(50),
    gia DECIMAL(10, 2),
    nam_xuat_ban INT
);
INSERT INTO Sach (ma_sach, ten_sach, tac_gia, the_loai, so_luong_hien_co, mo_ta, gia, nam_xuat_ban)
VALUES ('S001', N'Harry Potter', N'J.K. Rowling', N'Fantasy', 100, N'Cuốn sách kể về thế giới phù thủy', 15.99, 2001),
('S002', N'Nhà giả kim', N'Paulo Coelho', N'Tiểu thuyết', 50, N'Cuốn sách về sự tìm kiếm ý nghĩa cuộc sống', 12.5, 1988),
    ('S003', N'Sức mạnh của ngôn từ', N'Don Miguel Ruiz', N'Phát triển bản thân', 30, N'Tác phẩm về sức mạnh của từ ngữ', 10.99, 1997),
    ('S004', N'Nghệ thuật sống', N'Thích Nhất Hạnh', N'Tâm lý - Tâm linh', 20, N'Sách về nghệ thuật sống hạnh phúc', 9.75, 2012);

GO
--DELETE FROM Sach;
GO
SELECT * FROM Sach;

GO
-- Tạo bảng "Library_Cards"
CREATE TABLE The_thu_vien (
    ma_the VARCHAR(5) PRIMARY KEY,
    ho_va_ten NVARCHAR(100),
    đia_chi NVARCHAR(255),
    so_đien_thoai VARCHAR(10),
    email VARCHAR(255),
    ngay_đang_ky DATE,
    ngay_het_han DATE
);
GO
-- Tạo bảng "Loans"
CREATE TABLE Muon_tra (
    ma_giao_dich VARCHAR(5) PRIMARY KEY,
    ma_sach VARCHAR(5),
    ma_the VARCHAR(5),
    ngay_muon DATE,
    ngay_het_han DATE,
    so_tien_phat DECIMAL(10, 2),
    trang_thai NVARCHAR(50),
    FOREIGN KEY (ma_sach) REFERENCES Sach(ma_sach),
    FOREIGN KEY (ma_the) REFERENCES The_thu_vien(ma_the)
);

