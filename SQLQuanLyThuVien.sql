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
GO

INSERT INTO Sach (ma_sach, ten_sach, tac_gia, the_loai, so_luong_hien_co, mo_ta, gia, nam_xuat_ban)
VALUES ('S001', N'Harry Potter', N'J.K. Rowling', N'Fantasy', 100, N'Cuốn sách kể về thế giới phù thủy', 15.99, 2001),
('S002', N'Nhà giả kim', N'Paulo Coelho', N'Tiểu thuyết', 50, N'Cuốn sách về sự tìm kiếm ý nghĩa cuộc sống', 12.5, 1988),
    ('S003', N'Sức mạnh của ngôn từ', N'Don Miguel Ruiz', N'Phát triển bản thân', 30, N'Tác phẩm về sức mạnh của từ ngữ', 10.99, 1997),
    ('S004', N'Nghệ thuật sống', N'Thích Nhất Hạnh', N'Tâm lý - Tâm linh', 20, N'Sách về nghệ thuật sống hạnh phúc', 9.75, 2012);

GO
--DELETE FROM Sach;
GO
SELECT * FROM Sach;
s
GO
-- Tạo bảng "Library_Cards"
CREATE TABLE The_thu_vien (
    ma_the VARCHAR(5) PRIMARY KEY,
    ho_va_ten NVARCHAR(100),
    dia_chi NVARCHAR(255),
    so_dien_thoai VARCHAR(10),
    email VARCHAR(255),
    ngay_dang_ky DATE,
    ngay_het_han DATE
);
GO
INSERT INTO The_thu_vien (ma_the, ho_va_ten, dia_chi, so_dien_thoai, email, ngay_dang_ky, ngay_het_han)
VALUES 
    ('T001', N'Nguyễn Văn A', N'123 Đường ABC, Quận XYZ', '0987654321', 'nguyenvana@example.com', '2024-05-01', '2025-05-01'),
    ('T002', N'Trần Thị B', N'456 Đường XYZ, Quận ABC', '0123456789', 'tranthib@example.com', '2024-05-15', '2025-05-15');

GO
SELECT * FROM The_thu_vien;
GO
-- Tạo bảng "Loans"
CREATE TABLE Muon_tra (
    ma_giao_dich VARCHAR(5) PRIMARY KEY,
    ma_sach VARCHAR(5),
    ma_the VARCHAR(5),
    ngay_muon DATE,
    ngay_tra DATE,
    so_tien_phat DECIMAL(10, 2),
    trang_thai NVARCHAR(50),
    FOREIGN KEY (ma_sach) REFERENCES Sach(ma_sach),
    FOREIGN KEY (ma_the) REFERENCES The_thu_vien(ma_the)
);
GO

INSERT INTO Muon_tra (ma_giao_dich, ma_sach, ma_the, ngay_muon, ngay_tra, so_tien_phat, trang_thai)
VALUES
    ('M001', 'S001', 'T001', '2024-05-02', '2024-05-09', 0, N'Đã trả'),
    ('M002', 'S002', 'T002', '2024-05-20', '2024-05-27', 0, N'Đã trả'),
    ('M003', 'S003', 'T001', '2024-05-25', '2024-06-01', 0, N'Chưa trả');

GO

SELECT * FROM Muon_tra;

GO
-- Ràng buộc kiểm tra ngày mượn trả
CREATE TRIGGER Ktra_ngay_muon
ON Muon_tra
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM Muon_tra AS m
        WHERE m.ngay_muon > m.ngay_tra
    )
    BEGIN
        RAISERROR ('Ngày mượn phải trước ngày trả', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;

GO

--Ràng buộc xóa thẻ thư viện đảm bảo khi không có mượn trả nào liên kết (nếu có đang mượn thì ko xoá đc thẻ)
CREATE TRIGGER Ngan_xoa_the
ON The_thu_vien
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @dem_muon INTEGER;
    SELECT @dem_muon= COUNT(*) FROM Muon_tra WHERE ma_the IN (SELECT ma_the FROM DELETED);
    IF @dem_muon > 0
    BEGIN
        RAISERROR ('Không thể xóa thẻ thư viện có giao dịch mượn trả liên kết', 16, 1);
        ROLLBACK TRANSACTION;
    END
    ELSE
    BEGIN
        DELETE FROM The_thu_vien WHERE ma_the IN (SELECT ma_the FROM DELETED);
        COMMIT TRANSACTION;
    END
END;

GO

--Ràng buộc số lượng sách không âm
CREATE TRIGGER Kiem_tra_sach_ko_am
ON Sach
AFTER UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE so_luong_hien_co < 0
    )
    BEGIN
        RAISERROR('Số lượng sách không được âm', 16, 1);
        ROLLBACK TRANSACTION;
    END;
END;
