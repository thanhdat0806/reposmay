CREATE DATABASE KT0720_61130137
GO
USE KT0720_61130137
GO
CREATE TABLE Lop
(
	MaLop nvarchar(10) PRIMARY KEY,
	TenLop nvarchar(50) NOT NULL
)
GO
CREATE TABLE SinhVien
(
	MaSV char(8) PRIMARY KEY,
	HoSV nvarchar(50),
	TenSV nvarchar(15),
	GioiTinh bit,
	NgaySinh smalldatetime,
	AnhNV nvarchar(100),
	DiaChi nvarchar(60),
	MaLop nvarchar(10) FOREIGN KEY REFERENCES Lop(MaLop)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
INSERT INTO Lop VALUES('61.CNTT-2',N'Lớp 2 ngành CNTT Khóa 61'),('61.CNTT-3',N'Lớp 3 ngành CNTT Khóa 61'),('60.CNTT-1',N'Lớp 1 ngành CNTT Khóa 60')
INSERT INTO SinhVien VALUES('61123456',N'Nguyễn Văn',N'Nam',1,'01/01/1999','61123456.gif',N'02 - Nguyễn Đình Chiểu ...','61.CNTT-3'),
					('61198998',N'Nguyễn Thi Van',N'Anh',2,'01/01/1999','61199999.gif',N'37 - Đặng Tất ...','61.CNTT-3'),
					('61177777',N'Nguyễn Thị',N'Mai',2,'02/01/1999','61177777.gif',N'05 - Sao Biển ...','60.CNTT-1')