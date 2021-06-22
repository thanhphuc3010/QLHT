CREATE DATABASE QLHieuThuoc
Go

use QLHieuThuoc
go

CREATE TABLE tbl_NhanVien
(
	MaNV	char(10) primary key,
	TenNV	nvarchar(50),
	DiaChiNV	nvarchar(50),
	SDTNV	char(10)
)

CREATE TABLE tbl_DMKhachHang
(
	MaKH	char(10) primary key,
	TenKh	nvarchar(50) not null,
	LoaiDT	bit, -- 0 : Khách lẻ, 1 : Đơn vị tổ chức
	DChiKH	nvarchar(50),
	SdtKH	char(10) not null,
	Email	char(50)
)




CREATE TABLE tbl_DMNhaSx
(
	MaNhaSX	char(10) Primary key,
	TenNhaSX nvarchar(50) not null,
	DChiNhaSX	nvarchar(50) not null,
	SdtNhaSX	char(10) not null,
	email	char(50)
)

CREATE TABLE tbl_DMNCC
(
	MaNCC	char(10) primary key,
	TenNCC	nvarchar(50) not null,
	DChiNCC	nvarchar(50) not null,
	SdtNCC	char(10) not null,
	Email	char(50)
)
ALTER TABLE tbl_DMNCC
ALTER COLUMN DChiNCC nvarchar(200) not null;

CREATE TABLE tbl_HDBan
(
	SoHD	char(10) primary key ,
	MaKH	char(10) foreign key (MaKH) references tbl_DmKhachHang(MaKH),
	NgayHD	Date not null,
	HanTT	char(20),
	Thue	float
)
ALTER TABLE tbl_HDBan ADD MaNV	char(10)
ALTER TABLE tbl_HDBan ADD FOREIGN KEY(MaNV) REFERENCES tbl_NhanVien

CREATE TABLE tbl_Thuoc
(
	MaThuoc	char(10) primary key,
	TenThuoc	char(50) not null,
	HamLuong	nvarchar(50),
	DonviTinh	nvarchar(50) not null,
	SoLuong	int,
	SoDK	char(20),
	ThanhPhan	char(50),
	NgaySX	date not null,
	HSD	date not null,
	NoiSX	nvarchar(200),
	DonGia	float,
	DongGoi	char(50),
	MaNhaSX	char(10) foreign key (MaNhaSX) references tbl_DmNhaSX(MaNhaSX),
	
)

CREATE TABLE tbl_DMLoaiThuoc
(
	MaThuoc	char(10) foreign key (MaThuoc) references tbl_Thuoc(MaThuoc),
	TenLoaiThuoc	char(50) not null,
	constraint PK_dmLoaiThuoc_MaThuoc_TenLoaiThuoc primary key (MaThuoc, TenLoaiThuoc)
)

CREATE TABLE tbl_CTHD
(
	SoHD char(10) foreign key (SoHD) references tbl_hdBan(SoHD),
	MaThuoc	char(10) foreign key (MaThuoc) references tbl_Thuoc(MaThuoc),
	TenThuoc	char(50),
	DonviTinh	nvarchar(50),
	SoLuong	int,
	DonGia	float,
	constraint PK_tbl_ctHD_soHD_MaThuoc primary key(soHD, MaThuoc)
)

CREATE TABLE tbl_PhieuNhap
(
	soCT	char(10) primary key,
	MaNCC		char(10) foreign key (MaNCC) references tbl_DMNCC(MaNCC),
	NgayCt	Date,
	HanThanhToan	Date,
	Thue	float,
	ChietKhau	float
)
ALTER TABLE tbl_PhieuNhap ADD MaNV	char(10)
ALTER TABLE tbl_PhieuNhap ADD FOREIGN KEY(MaNV) REFERENCES tbl_NhanVien

CREATE TABLE tbl_CTNhap
(
	soCT char(10) foreign key (soCT) references tbl_phieuNhap(SoCt), 
	MaThuoc	char(10) foreign key (MaThuoc) references tbl_THUOC(MaThuoc),
	TenThuoc	nvarchar(50),
	DonviTinh	nvarchar(50),
	SoLuongNhap	int,
	DonGiaNhap	float,
	constraint PK_tbl_ctNhap_soCT_MaThuoc primary key(soCT, MaThuoc)
)


ALTER TABLE tbl_DMNCC
ALTER COLUMN TenNCC nvarchar(200) not null;

ALTER TABLE tbl_DMNhaSx
ALTER COLUMN TenNhaSX nvarchar(200) not null;

ALTER TABLE tbl_DMNhaSx
ALTER COLUMN DChiNhaSX nvarchar(200) not null;

ALTER TABLE tbl_NhanVien
ALTER COLUMN DiaChiNV nvarchar(200);

ALTER TABLE TBL_THUOC
ALTER COLUMN DongGoi nvarchar(50);

ALTER TABLE TBL_THUOC
ALTER COLUMN ThanhPhan nvarchar(50);

