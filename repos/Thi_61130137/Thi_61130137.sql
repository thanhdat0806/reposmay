CREATE DATABASE Thi_61130137
GO
USE Thi_61130137
GO
CREATE TABLE LoaiTaiSan
(
	MaLTS nvarchar(10) PRIMARY KEY,
	TenLTS nvarchar(50) NOT NULL
)
GO
CREATE TABLE TaiSan
(
	MaTS char(10) PRIMARY KEY,
	TenTS nvarchar(100),
	DVT nvarchar(50),
	XuatXu bit,
	Dongia int,
	AnhMH nvarchar(100),
	Ghichu nvarchar(60),
	MaLTS nvarchar(10) FOREIGN KEY REFERENCES LoaiTaiSan(MaLTS)
	ON UPDATE CASCADE
	ON DELETE CASCADE
)
GO
INSERT INTO LoaiTaiSan VALUES('MTXT',N'Máy Tính Sách Tay'),('MC',N'Máy chiếu'),('MI',N'Máy In')
INSERT INTO TaiSan VALUES('TS000001',N'HP ProBook 4430s',N'cái',1,15000000,N'employee.png',N'...','MTXT'),
					('TS000002',N'Projector Epson Ex3240',N'cái',2,9000000,N'employee.png',N'...','MC'),
					('TS000003',N'Canon Pixma G2010',N'cái',2,4000000,N'employee.png',N'...','MI')