use ttn_ex3


create table TheThuVien(
	SoThe char(10) primary key,
	NgayBatDau datetime,
	NgayHetHan datetime
)
/*
create sequence thethuvienSeg
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
		select next value for thethuvienSeg
*/
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
	NgayTra datetime default null,
	Da_Tra bit
)

-- the thu vien
go

insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0001','1996-01-01','2001-01-01');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0002','1997-01-10','2003-01-10');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0003','2001-02-12','2006-02-12');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0004','2002-03-01','2007-03-01');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0005','2003-04-01','2008-04-01');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0006','2002-02-27','2007-02-27');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0007','1996-09-12','2000-09-12');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0008','2005-06-28','2009-06-28');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0009','2006-01-01','2011-01-01');
insert into TheThuVien(SoThe, NgayBatDau, NgayHetHan)
values('TV0010','2007-11-03','2011-11-03');

select * from TheThuVien

--doc gia
go
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0001',N'Đỗ Duy Mạnh',N'Hà Nội','TV0010');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0002',N'Trần Đình Trọng',N'Hà Nội','TV0001');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0003',N'Phạm Đức Huy',N'Hà Nội','TV0002');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0004',N'Nguyễn Quang Hải',N'Hà Nội','TV0003');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0005',N'Lương Xuân Trường',N'Gia Lai','TV0004');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0006',N'Nguyễn Công Phượng',N'Gia Lai','TV0007');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0007',N'Bùi Tiến Dũng',N'Thanh Hóa','TV0005');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0008',N'Nguyễn Trọng Hoàng',N'Thanh Hóa','TV0006');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0009',N'Phan Văn Đức',N'Nghệ An','TV0009');
insert into DocGia(MaDG, TenDocGia, DiaChi,SoThe)
values('DG0010',N'Nguyễn Anh Đức',N'Bình Dương','TV0008');
select * from DocGia

-- sach
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0001',N'Làm chủ python 1 tuần',N'lập trình',N'Trung Kiên',N'Kim đồng',100);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0002',N'Lịch sử Đảng',N'lịch sử',N'Thanh Tùng',N'Văn Lang',60);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0003',N'Lập trình C#',N'lập trình',N'Văn Hiến',N'Kim đồng',70);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0004',N'Làm chủ 660 TOEIC',N'tiếng anh',N'Đạt',N'Giáo dục',200);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0005',N'Công nghệ và xu hướng',N'lập trình',N'Vũ Anh Tú',N'Kim Đồng',250);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0006',N'Làm chủ AI trong 1 tháng',N'lập trình',N'Hiếu',N'Giáo dục',123);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0007',N'Làm chủ fullstack trong 1 tháng',N'lập trình',N'Doãn Hưng',N'Văn Lang',432);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0008',N'Làm chủ ATTT trong 3 ngày',N'lập trình',N'GS.Lộc',N'Kim đồng',587);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0009',N'Toán cao cấp 3',N'toán',N'Lam',N'Giáo Dục',988);
insert into Sach(MaSach, TenSach, TenTheLoai,TenTacGia,TenNXB,SoLuong)
values('MS0010',N'Địa lý 12',N'học tập',N'Hà',N'Giáo Dục',1000);
select * from Sach
-- muon tra
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0001','1996-01-01','1996-07-01',1,'TV0001');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0002','1997-01-10','1997-08-10',1,'TV0002');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0003','2002-01-12','2002-09-12',1,'TV0003');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0004','2002-06-01','2002-12-01',1,'TV0004');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0005','2004-04-01','2005-01-01',1,'TV0005');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0006','2003-02-27','2003-08-26',1,'TV0006');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0007','1997-09-12','1998-03-12',1,'TV0007');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0008','2005-07-28','2006-01-28',1,'TV0008');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0009','2006-02-01','2006-08-03',1,'TV0009');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,TinhTrang,SoThe)
values('MM0010','2007-12-01','2008-06-01',1,'TV0010');
select * from MuonTra
-- chi tiet muon tra
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0001','MS0003','',0);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0002','MS0001','1997-08-05',1);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0003','MS0002','2002-09-11',1);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0004','MS0004','2002-11-28',1);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0005','MS0009','',0);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0006','MS0007','',0);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0007','MS0005','1998-03-09',1);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0008','MS0006','2006-01-27',1);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0009','MS0008','',0);
insert into CT_MuonTra(MaMuon, MaSach, NgayTra,Da_Tra)
values('MM0010','MS0010','',0);

select * from CT_MuonTra
