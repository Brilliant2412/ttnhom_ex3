use ttn_ex3


create table TheThuVien(
	SoThe char(10) primary key,
	NgayBatDau datetime,
	NgayHetHan datetime
)
go
create table DocGia(
	MaDG char(10) primary key,
	TenDocGia nvarchar(50),
	DiaChi nvarchar(50),
	SoThe char(10) references TheThuVien(SoThe)
)

create table Sach(
	MaSach char(10) primary key,
	TenSach nvarchar(50),
	TenTheLoai nvarchar(50),
	TenTacGia nvarchar(50),
	TenNXB nvarchar(50),
	SoLuong int
)

--------- -1 khi muon sach, 

create table MuonTra(
	MaMuon char(10) primary key,
	NgayMuon datetime default CURRENT_TIMESTAMP,
	NgayHenTra datetime,
	TinhTrang bit,
	SoThe char(10) references TheThuVien(SoThe)
)
----------------- Da_Tra = 0 tuc la chua tra sach
------------------- = 1 la da tra sach
create table CT_MuonTra(
	MaMuon char(10) references MuonTra(MaMuon),
	MaSach char(10) references Sach(MaSach),
	NgayTra datetime,
	Da_Tra bit
)




