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

create table MuonTra(
	MaMuon char(10) primary key,
	NgayMuon datetime,
	NgayHenTra datetime,
	SoThe char(10) references TheThuVien(SoThe)
)


----------------- Da_Tra = 0 tuc la chua tra sach
------------------- = 1 la da tra sach
create table CT_MuonTra(
	MaMuon char(10) references MuonTra(MaMuon),
	MaSach char(10) references Sach(MaSach),
	NgayTra datetime default null,
	Da_Tra bit
	PRIMARY KEY (MaMuon, MaSach)
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


insert into TheThuVien(SoThe)
values('TV0022');
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
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0001','1996-01-01','1996-07-01','TV0001');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0002','1997-01-10','1997-08-10','TV0002');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0003','2002-01-12','2002-09-12','TV0003');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0004','2002-06-01','2002-12-01','TV0004');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0005','2004-04-01','2005-01-01','TV0005');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0006','2003-02-27','2003-08-26','TV0006');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0007','1997-09-12','1998-03-12','TV0007');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0008','2005-07-28','2006-01-28','TV0008');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0009','2006-02-01','2006-08-03','TV0009');
insert into MuonTra(MaMuon, NgayMuon, NgayHenTra,SoThe)
values('MM0010','2007-12-01','2008-06-01','TV0010');
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



CREATE SEQUENCE [dbo].[Sach_seq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO


create procedure [dbo].[ThemMoiSach]
	@tenSach nvarchar(50),
	@tenTheLoai nvarchar(50),
	@tenTacGia nvarchar(50),
	@tenNXB nvarchar(50),
	@soLuong int
as 
begin
	insert into SACH
	(
		MaSach, TenSach, TenTheLoai, TenTacGia, TenNXB, SoLuong
	)values(
		'MS' + cast(next value for Sach_seq as char(4)),
		@tenSach,
		@tenTheLoai,
		@tenTacGia,
		@tenNXB,
		@soLuong
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end


----------Tim kiem Sach--------
--MaHS--
GO
create procedure searchMaSach @MaSach char(10)
as 
begin
	select MaSach, TenSach, TenTheLoai, TenTacGia,
		TenNXB, convert(varchar(10),Sach.SoLuong) as SoLuong
	from Sach
	where MaSach = @MaSach
end
go
exec searchMaSach 'MS0006'

go
--Ten sach--
create procedure searchTenSach @TenSach nvarchar(50)
as 
begin
	select MaSach, TenSach, TenTheLoai, TenTacGia,
		TenNXB, convert(varchar(10),Sach.SoLuong) as SoLuong
	from Sach
	where TenSach = @TenSach
end
go
exec searchTenSach N'Làm chủ 660 TOEIC'
go
--Ten the loai--
create procedure searchTenTheLoai @TenTheLoai nvarchar(50)
as 
begin
	select MaSach, TenSach, TenTheLoai, TenTacGia,
		TenNXB, convert(varchar(10),Sach.SoLuong) as SoLuong
	from Sach
	where TenTheLoai = @TenTheLoai
end
go
exec searchTenTheLoai N'lập trình'
go
--Ten tac gia--
create procedure searchTenTacGia @TenTacGia nvarchar(50)
as 
begin
	select MaSach, TenSach, TenTheLoai, TenTacGia,
		TenNXB, convert(varchar(10),Sach.SoLuong) as SoLuong
	from Sach
	where TenTacGia = @TenTacGia
end
go
exec searchTenTacGia N'Vũ Anh Tú'
go

--Sửa độc giả
create procedure UpdateDocGia 
	@maDocGia char(10),
	@tenDocGia nvarchar(50), 
	@diaChi nvarchar(50),
	@soThe char(10)
as
begin
	update DocGia
	set TenDocGia = @tenDocGia,
	DiaChi = @diaChi,
	SoThe = @soThe
	where MaDG = @maDocGia
end
go

alter procedure SelectDocGiaById
	@maDocGia char(10)
as
begin
	select dg.DiaChi,dg.TenDocGia,dg.SoThe, ttv.NgayBatDau,ttv.NgayHetHan
	from DocGia as dg,TheThuVien as ttv
where MaDG = @maDocGia and ttv.SoThe = dg.SoThe
end
go

exec SelectDocGiaById 'MDG23'


SELECT current_value FROM sys.sequences WHERE name = 'TheThuVien_seg'
SELECT current_value FROM sys.sequences WHERE name = 'DocGia_seq'


-----Search Doc Gia--------
create procedure searchMaDG @MaDG char(10)
as 
begin
	select MaDG, TenDocGia, DiaChi, SoThe
	from DocGia
	where MaDG = @MaDG
end

GO
create procedure searchTenDG @TenDG nvarchar(50)
as 
begin
	select MaDG, TenDocGia, DiaChi, SoThe
	from DocGia
	where TenDocGia = @TenDG
end

GO
create procedure searchSoThe @Sothe char(10)
as 
begin
	select MaDG, TenDocGia, DiaChi, SoThe
	from DocGia
	where SoThe = @Sothe
end


-- Mượn trả
CREATE SEQUENCE [dbo].[MuonTra_seq] 
 AS [bigint]
 START WITH 11
 INCREMENT BY 1
 MINVALUE -92233720
 MAXVALUE 99999999
 CACHE 
go



exec SelectMuonTraandCTMTById 

EXEC SelectMuonTraById 'MM0001'

GO
CREATE PROCEDURE ThemMoiMuonTra
	@ngayMuon DATETIME,
	@ngayHenTra DATETIME,
	@soThe CHAR(10)
AS
BEGIN
	insert into MUONTRA (MaMuon, NgayMuon, NgayHenTra, SoThe)
	values(
		'MM00' + cast(next value for MuonTra_seq as char(4)),
		@ngayMuon,
		@ngayHenTra,
		@soThe
		);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

GO
create procedure UpdateMuonTra
	@maMuon char(10),
	@ngayMuon DATETIME, 
	@ngayHenTra DATETIME,
	@soThe char(10)
as
begin
	update MuonTra
	set NgayMuon = @ngayMuon,
		NgayHenTra = @ngayHenTra,
		SoThe = @soThe
	where MaMuon = @maMuon
end

GO
create procedure searchMaMuon @MaMuon char(10)
as 
begin
	select MaMuon, NgayMuon, NgayHenTra, SoThe
	from MuonTra
	where MaMuon = @MaMuon
end

GO
create procedure searchSoTheNguoiMuon @Sothe char(10)
as 
begin
	select MaMuon, NgayMuon, NgayHenTra, SoThe
	from MuonTra
	where SoThe = @Sothe
end



alter procedure SelectSachById @MaSach char(10)
as 
begin
	select TenSach,TenTheLoai,TenTacGia,TenNXB,SoLuong
	from Sach
	where MaSach = @MaSach
end

exec SelectSachById 'MS2'

create procedure UpdateSach
	@MaSach char(10),
	@tenSach nvarchar(50),
	@tenTheLoai nvarchar(50),
	@tenTacGia nvarchar(50),
	@tenNXB nvarchar(50),
	@soLuong int
as
begin
	update Sach
	set TenSach = @tenSach,
		TenTheLoai = @tenTheLoai,
		TenTacGia = @tenTacGia,
		TenNXB = @tenNXB,
		SoLuong = @soLuong
	where MaSach = @MaSach
end
----- MT CTMT
alter procedure listAllSachAvailable
as
begin
	select TenSach
	from Sach 
	where SoLuong > 0;
end

ALTER PROCEDURE [dbo].[ThemMoiMuonTra]
	@MaMuon char(10),
	@ngayMuon DATETIME,
	@ngayHenTra DATETIME,
	@soThe CHAR(10)
AS
BEGIN
	insert into MUONTRA (MaMuon, NgayMuon, NgayHenTra, SoThe)
	values(
		'MM' + cast(@MaMuon as char(4)),
		@ngayMuon,
		@ngayHenTra,
		@soThe
		);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

alter procedure ThemMoiCTMuonTra
	@MaMM char (10),
	@TenSach nvarchar(50)
AS
BEGIN
	declare @MaSach char(10);
	set @MaSach = (select MaSach from Sach where TenSach = @TenSach and SoLuong > 0)

	insert into CT_MuonTra(MaMuon, MaSach, NgayTra, Da_Tra)
	values(
		'MM' + cast(@MaMM as char(4)),
		@MaSach,
		null,
		0
		);
	if @@ROWCOUNT > 0 begin return 1 end
	else begin return 0 end;
END

SELECT current_value FROM sys.sequences WHERE name = 'MuonTra_seq'

alter procedure SelectMuonTraandCTMTById
	@maMuon char(10)
as
begin
	select convert(VARCHAR(10), mt.NgayMuon, 103) as NgayMuon, convert(VARCHAR(10), mt.NgayHenTra, 103) as NgayHenTra, mt.SoThe,s.TenSach  
	from MuonTra mt,CT_MuonTra as ctmt, Sach as s
	where mt.MaMuon = @maMuon and mt.MaMuon = ctmt.MaMuon and ctmt.MaSach = s.MaSach and ctmt.Da_Tra = 0
end

exec SelectMuonTraandCTMTById 'MM0001'

create proc GetAllMTandCTMT
as
begin
	select mt.MaMuon,s.TenSach, mt.NgayMuon,mt.NgayHenTra,dg.TenDocGia
	from MuonTra as mt
	left join CT_MuonTra as ctmt
	on ctmt.MaMuon = mt.MaMuon
	left join Sach as s
	on ctmt.MaSach = s.MaSach
	left join TheThuVien as ttv
	on ttv.SoThe = mt.SoThe
	left join DocGia as dg
	on ttv.SoThe = dg.SoThe
	where ctmt.Da_Tra = 0
end
go

exec GetAllMTandCTMT

alter proc InsertMTandCTMT
    @MaMM char(10),
	@ngayMuon DATETIME,
	@ngayHenTra DATETIME,
	@soThe CHAR(10),
	@TenSach nvarchar(50)
as
begin
    declare @SoLuongCon CHAR(10);
	set @SoLuongCon=(select SoLuong from Sach where TenSach = @TenSach)

	declare @MaSach char(10);
	set @MaSach = (select MaSach from Sach where TenSach = @TenSach and SoLuong > 0)
	
	insert into MUONTRA (MaMuon, NgayMuon, NgayHenTra, SoThe)
	values(
		'MM' + cast(@MaMM as char(4)),
		@ngayMuon,
		@ngayHenTra,
		@soThe
		);

	if(@SoLuongCon-1 > 0)
		begin
			insert into CT_MuonTra(MaMuon, MaSach, NgayTra, Da_Tra)
	values(
		'MM' + cast(@MaMM as char(4)),
		@MaSach,
		null,
		0
		);

			UPDATE Sach
			SET SoLuong = SoLuong - 1
			WHERE MaSach = @MaSach
		end
	else
	begin
	UPDATE Sach
			SET SoLuong = 0
			WHERE MaSach = @MaSach
	end

if @@ROWCOUNT > 0 begin return 1 end
else begin return 0 end;

end
go


--------------------------------------------------------------------------------------------------------
alter proc UpdateMTandCTMT
	@MaMM char(10),
	@ngayMuon DATETIME,
	@ngayHenTra DATETIME,
	@soThe CHAR(10),
	@TenSach nvarchar(50),
	@TenSachCu nvarchar(50)
as
begin

	declare @SoLuongCon CHAR(10);
	set @SoLuongCon=(select SoLuong from Sach where TenSach = @TenSach)

	declare @MaSach char(10);
	set @MaSach = (select MaSach from Sach where TenSach = @TenSach and SoLuong > 0)

	declare @MaSachCu char(10);
	set @MaSachCu = (select MaSach from Sach where TenSach = @TenSachCu)

	print @MaSach;
	print @MaSachCu;

	Update MuonTra
	set
		NgayHenTra = @ngayHenTra,
		NgayMuon= @ngayMuon,
		SoThe = @soThe
	where MaMuon = @MaMM

	Update CT_MuonTra
	set 
		MaSach = @MaSach,
		Da_Tra = 0,
		NgayTra = null
	where MaMuon = @MaMM and MaSach = @MaSachCu

	UPDATE Sach
		SET SoLuong = SoLuong- 1
		WHERE MaSach = @MaSach

	UPDATE sach
	set SoLuong = SoLuong + 1
	where MaSach = @MaSachCu
	if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go

exec UpdateMTandCTMT 'MM0010','2007-12-01 00:00:00.000','2009-12-01 00:00:00.000', 'TV0002',N'Lịch sử Đảng',N'Địa lý 12'

alter procedure searchMaMuon @MaM char(10)
as 
begin
	select mt.MaMuon,s.TenSach, mt.NgayMuon,mt.NgayHenTra,mt.SoThe,dg.TenDocGia
	from MuonTra as mt
	left join CT_MuonTra as ctmt
	on ctmt.MaMuon = mt.MaMuon
	left join Sach as s
	on ctmt.MaSach = s.MaSach
	left join TheThuVien as ttv
	on ttv.SoThe = mt.SoThe
	left join DocGia as dg
	on ttv.SoThe = dg.SoThe
	where ctmt.Da_Tra = 0 and mt.MaMuon = @MaM
end
go


--------------------------------
alter procedure searchSoTheNguoiMuon @SoThe char(10)
as 
begin
	select mt.MaMuon,s.TenSach, mt.NgayMuon,mt.NgayHenTra,mt.SoThe,dg.TenDocGia
	from MuonTra as mt
	left join CT_MuonTra as ctmt
	on ctmt.MaMuon = mt.MaMuon
	left join Sach as s
	on ctmt.MaSach = s.MaSach
	left join TheThuVien as ttv
	on ttv.SoThe = mt.SoThe
	left join DocGia as dg
	on ttv.SoThe = dg.SoThe
	where ctmt.Da_Tra = 0 and mt.SoThe = @SoThe
end
go
-------------------------------

create procedure searchSoTheNguoiMuon @SoThe char(10)
as 
begin
	select mt.MaMuon,s.TenSach, mt.NgayMuon,mt.NgayHenTra,mt.SoThe,dg.TenDocGia
	from MuonTra as mt
	left join CT_MuonTra as ctmt
	on ctmt.MaMuon = mt.MaMuon
	left join Sach as s
	on ctmt.MaSach = s.MaSach
	left join TheThuVien as ttv
	on ttv.SoThe = mt.SoThe
	left join DocGia as dg
	on ttv.SoThe = dg.SoThe
	where ctmt.Da_Tra = 0 and mt.SoThe = @SoThe
end
go