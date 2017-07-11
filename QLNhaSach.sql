--create database QLNhaSach
--use QLNhaSach

/*create table TheLoai (
	MaTheLoai varchar(5) primary key not null,
	TenTheLoai nvarchar(50)
) */

/*create table TacGia (
	MaTacGia varchar(5) primary key not null,
	TenTacGia nvarchar(40),
	LienHeTacGia nvarchar (100)
) */

/*create table NhaCungCap (
	MaNhaCungcap varchar(5) primary key not null,
	TenNhaCungCap nvarchar(100),
	DiaChi nvarchar(200),
	DienThoai nvarchar(11),
	Email nvarchar(50),
	GhiChu nvarchar(200)

) */

/*create table NhaXuatBan (
	MaNXB varchar(5) primary key not null,
	TenNXB nvarchar (100),
	DiaChi nvarchar(100),
	DienThoai nvarchar(11),
	Email nvarchar(50),
	GhiChu nvarchar(300)
) */

/* create table Sach (
	MaSach varchar(5) primary key not null,
	TenSach nvarchar (50),
	GiaMua int not null,
	GiaBan int not null,
	MaTacGia varchar(5) foreign key (MaTacGia) references TacGia(MaTacGia),
	MaNXB varchar(5) foreign key (MaNXB) references NhaXuatBan(MaNXB),
	MaNhaCungCap varchar(5) foreign key (MaNhaCungCap) references NhaCungCap(MaNhaCungCap),
	MaTheLoai varchar(5) foreign key (MaTheLoai) references TheLoai(MaTheLoai),
	SoLuong int
) */

/*create table NhanVien (
	MaNV varchar(5) primary key not null,
	TenNV nvarchar (30),
	NgaySinh smalldatetime,
	CMND nvarchar(20),
	GioiTinh nvarchar(10),
	SDT nvarchar(11),
	DiaChi nvarchar(50),
	TaiKhoan nvarchar(20),
	MatKhau nvarchar(20),
	ChucVu nvarchar(10),
) */


/*create table HoaDon (
	MaHoaDon varchar(5) primary key not null,
	MaNV varchar(5) foreign key (MaNV) references NhanVien(MaNV),
	TenKhachHang nvarchar(50),
	TongTien int,
	Ngay datetime
) */

/*create table ChiTietHoaDon (
	CTMaHoaDon varchar(5) primary key not null,
	MaHoaDon varchar(5) foreign key (MaHoaDon) references HoaDon(MaHoaDon),
	MaSach varchar(5) foreign key (MaSach) references Sach(MaSach),
	SoLuong int
)*/

/*create table PhieuNhap (
	MaPhieuNhap varchar(5) primary key not null,
	MaNV varchar(5) foreign key (MaNV) references NhanVien(MaNV),
	TenNhaCungCap nvarchar(100),
	TongTien int,
	Ngay datetime
)*/

/*create table ChiTietPhieuNhap (
MaCTPhieuNhap varchar(5) primary key not null,
MaPhieuNhap varchar(5) foreign key (MaPhieuNhap) references PhieuNhap(MaPhieuNhap),
MaSach varchar(5) foreign key (MaSach) references Sach(MaSach),
SoLuong int
)*/
