create database QuanLyThuVien;

GO

use QuanLyThuVien

GO
-- Tạo bảng "Sách"
CREATE TABLE Sach (
    ma_sach VARCHAR(5) PRIMARY KEY,
    ten_sach NVARCHAR(255),
    tac_gia NVARCHAR(100),
    the_loai NVARCHAR(150),
    so_luong_hien_co INT,
    mo_ta NVARCHAR(150),
    gia DECIMAL(10, 2),
    nam_xuat_ban INT
);
GO
-- Thêm dữ liệu vào bảng Sách
INSERT INTO Sach (ma_sach, ten_sach, tac_gia, the_loai, so_luong_hien_co, mo_ta, gia, nam_xuat_ban)
VALUES 
	('S001', N'Harry Potter', N'J.K. Rowling', N'Fantasy', 100, N'Cuốn sách kể về thế giới phù thủy', 15.99, 2001),
	('S002', N'Nhà giả kim', N'Paulo Coelho', N'Tiểu thuyết', 50, N'Cuốn sách về sự tìm kiếm ý nghĩa cuộc sống', 12.5, 1988),
    ('S003', N'Sức mạnh của ngôn từ', N'Don Miguel Ruiz', N'Phát triển bản thân', 30, N'Tác phẩm về sức mạnh của từ ngữ', 10.99, 1997),
    ('S004', N'Nghệ thuật sống', N'Thích Nhất Hạnh', N'Tâm lý - Tâm linh', 20, N'Sách về nghệ thuật sống hạnh phúc', 9.75, 2012),
	 ('S005', N'Gatsby Vĩ Đại', N'F. Scott Fitzgerald', N'Kinh điển', 40, N'Tiểu thuyết được đặt trong thập niên hồi sinh sức sống', 9.99, 1925),
    ('S006', N'Tiểu thư Hobbit', N'J.R.R. Tolkien', N'Fantasy', 60, N'Tiểu thuyết phiêu lưu giả tưởng', 14.50, 1937),
    ('S007', N'Kẻ Bắt Cỏ', N'J.D. Salinger', N'Tiểu thuyết lớn lên', 70, N'Tiểu thuyết về lo âu của tuổi teen', 10.25, 1951),
	 ('S008', N'Đắc nhân tâm', N'Dale Carnegie', N'Tự phát triển', 90, N'Trải nghiệm về kỹ năng giao tiếp và quản lý tâm trí', 8.75, 1936),
    ('S009', N'Giáo dục', N'Emile', N'Khoa học xã hội', 55, N'Giáo trình về giáo dục và phát triển cá nhân', 10.50, 1762),
    ('S010', N'Tiếng chim hót trong bụi mận gai', N'Harper Lee', N'Tiểu thuyết', 65, N'Truyện về sự vô tội và bất công', 13.25, 1960);

GO
-- Tạo bảng "Thẻ thư viện"
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
-- Thêm dữ liệu vào bảng Thẻ thư viện
INSERT INTO The_thu_vien (ma_the, ho_va_ten, dia_chi, so_dien_thoai, email, ngay_dang_ky, ngay_het_han)
VALUES 
    ('T001', N'Nguyễn Văn A', N'123 Đường ABC, Quận XYZ', '0987654321', 'nguyenvana@example.com', '2024-05-01', '2025-05-01'),
    ('T002', N'Trần Thị B', N'456 Đường XYZ, Quận ABC', '0123456789', 'tranthib@example.com', '2024-05-15', '2025-05-15'),
	('T003', N'Trần Văn C', N'789 Đường XYZ, Quận DEF', '0321654987', 'tranvanc@example.com', '2024-06-10', '2025-06-10'),
    ('T004', N'Lê Thị D', N'101 Đường GHI, Quận KLM', '0369852147', 'lethid@example.com', '2024-06-15', '2025-06-15'),
    ('T005', N'Phạm Văn E', N'246 Đường MNO, Quận PQR', '0987456321', 'phamvane@example.com', '2024-07-01', '2025-07-01'),
    ('T006', N'Hồ Thị F', N'369 Đường STU, Quận VWX', '0123456789', 'hothif@example.com', '2024-07-15', '2025-07-15'),
    ('T007', N'Đặng Văn G', N'468 Đường YZ, Quận HIJ', '0369852147', 'dangvang@example.com', '2024-08-01', '2025-08-01');

GO
-- Tạo bảng "Mược trả"
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
-- Thêm dữ liệu vào bảng mượn trả
INSERT INTO Muon_tra (ma_giao_dich, ma_sach, ma_the, ngay_muon, ngay_tra, so_tien_phat, trang_thai)
VALUES
    ('M001', 'S001', 'T001', '2024-05-02', '2024-05-09', 0, N'Đã trả'),
    ('M002', 'S002', 'T002', '2024-05-20', '2024-05-27', 0, N'Đã trả'),
    ('M003', 'S003', 'T001', '2024-05-25', '2024-06-01', 2.00, N'Chưa trả'),

	('M004', 'S004', 'T003', '2024-06-05', '2024-06-12', 0, N'Đã trả'),
    ('M005', 'S005', 'T004', '2024-06-10', '2024-06-17', 0, N'Đã trả'),
    ('M006', 'S006', 'T005', '2024-06-15', '2024-06-22', 0, N'Đã trả'),
    ('M007', 'S007', 'T006', '2024-06-20', '2024-06-27', 1.50, N'Chưa trả'),
    ('M008', 'S008', 'T007', '2024-06-25', '2024-07-02', 0, N'Chưa trả'),
    ('M009', 'S001', 'T003', '2024-07-01', '2024-07-08', 0, N'Chưa trả'),
    ('M010', 'S002', 'T004', '2024-07-05', '2024-07-12', 0, N'Đã trả');

GO
-- Truy vấn
SELECT * FROM Sach;
SELECT * FROM The_thu_vien;
SELECT * FROM Muon_tra;

GO
------------------------------------------------------
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

-------------------------------------------------------
-- Thêm ràng buộc Unique Key cho cột ma_sach trong bảng Sach
ALTER TABLE Sach
ADD CONSTRAINT UK_ma_sach UNIQUE (ma_sach);

AlTER TABLE The_thu_vien
ADD CONSTRAINT UK_ma_the_thu_vien UNIQUE (ma_the);

ALTER TABLE Muon_tra
ADD CONSTRAINT UK_ma_giao_dich UNIQUE (ma_giao_dich);


----
ALTER TABLE Muon_tra
DROP CONSTRAINT IF EXISTS FK_ma_the;

ALTER TABLE Muon_tra
ADD CONSTRAINT FK_ma_the FOREIGN KEY (ma_the) REFERENCES The_thu_vien(ma_the) ON DELETE CASCADE;
