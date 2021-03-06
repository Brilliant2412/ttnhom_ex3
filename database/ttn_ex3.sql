USE [master]
GO
/****** Object:  Database [ttn_ex3]    Script Date: 3/17/2021 10:50:51 AM ******/
CREATE DATABASE [ttn_ex3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ttn_ex3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ttn_ex3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ttn_ex3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ttn_ex3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ttn_ex3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ttn_ex3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ttn_ex3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ttn_ex3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ttn_ex3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ttn_ex3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ttn_ex3] SET ARITHABORT OFF 
GO
ALTER DATABASE [ttn_ex3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ttn_ex3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ttn_ex3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ttn_ex3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ttn_ex3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ttn_ex3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ttn_ex3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ttn_ex3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ttn_ex3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ttn_ex3] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ttn_ex3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ttn_ex3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ttn_ex3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ttn_ex3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ttn_ex3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ttn_ex3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ttn_ex3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ttn_ex3] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ttn_ex3] SET  MULTI_USER 
GO
ALTER DATABASE [ttn_ex3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ttn_ex3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ttn_ex3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ttn_ex3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ttn_ex3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ttn_ex3] SET QUERY_STORE = OFF
GO
USE [ttn_ex3]
GO
USE [ttn_ex3]
GO
/****** Object:  Sequence [dbo].[Sach_seq]    Script Date: 3/17/2021 10:50:51 AM ******/
CREATE SEQUENCE [dbo].[Sach_seq] 
 AS [bigint]
 START WITH 1
 INCREMENT BY 1
 MINVALUE -9223372036854775808
 MAXVALUE 9223372036854775807
 CACHE 
GO
/****** Object:  Table [dbo].[CT_MuonTra]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_MuonTra](
	[MaMuon] [char](10) NULL,
	[MaSach] [char](10) NULL,
	[NgayTra] [datetime] NULL,
	[Da_Tra] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[MaDG] [char](10) NOT NULL,
	[TenDocGia] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoThe] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuonTra]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuonTra](
	[MaMuon] [char](10) NOT NULL,
	[NgayMuon] [datetime] NULL,
	[NgayHenTra] [datetime] NULL,
	[TinhTrang] [bit] NULL,
	[SoThe] [char](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[MaSach] [char](10) NOT NULL,
	[TenSach] [nvarchar](50) NULL,
	[TenTheLoai] [nvarchar](50) NULL,
	[TenTacGia] [nvarchar](50) NULL,
	[TenNXB] [nvarchar](50) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[SoThe] [char](10) NOT NULL,
	[NgayBatDau] [datetime] NULL,
	[NgayHetHan] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[SoThe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_MuonTra] ADD  DEFAULT (NULL) FOR [NgayTra]
GO
ALTER TABLE [dbo].[MuonTra] ADD  DEFAULT (getdate()) FOR [NgayMuon]
GO
ALTER TABLE [dbo].[CT_MuonTra]  WITH CHECK ADD FOREIGN KEY([MaMuon])
REFERENCES [dbo].[MuonTra] ([MaMuon])
GO
ALTER TABLE [dbo].[CT_MuonTra]  WITH CHECK ADD FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
ALTER TABLE [dbo].[MuonTra]  WITH CHECK ADD FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([SoThe])
GO
/****** Object:  StoredProcedure [dbo].[ThemMoiSach]    Script Date: 3/17/2021 10:50:51 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
GO
USE [master]
GO
ALTER DATABASE [ttn_ex3] SET  READ_WRITE 
GO

USE ttn_ex3
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

create procedure SelectDocGiaById
	@maDocGia char(10)
as
begin
	select * from DocGia where MaDG = @maDocGia
	
end
go

create procedure ThemMoiTheThuVIen @ngayBatDau datetime,
	@ngayHetHan datetime
as begin
	insert into TheThuVien 
	(
		SoThe,NgayBatDau,NgayHetHan
	)
	values(
		'TTV' + cast(next value for TheThuVien_seg as char(4)),
		@ngayBatDau,
		@ngayHetHan);

	if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;

end


	

create procedure ThemMoiDocGia
	@tenDocGia nvarchar(50),
	@diaChi nvarchar(50),
	@soThe varchar(50)
	
as 
begin
	insert into DocGia
	(
		MaDG,  TenDocGia, DiaChi,SoThe
	)values(
		'MDG' + cast(next value for DocGia_seq as char(4)),
		@tenDocGia,
		@diaChi,
		@soThe
		);
	


		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
go
create procedure UpdateTheThuVIen
	@soThe varchar(50),
	@ngayBatDau datetime,
	@ngayHetHan datetime
as
begin
	update TheThuVien
	set NgayBatDau = @ngayBatDau,
	NgayHetHan = @ngayHetHan
	where SoThe = @soThe

	if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

CREATE SEQUENCE [dbo].[DocGia_seq] 
 AS [bigint]
 START WITH 11
 INCREMENT BY 1
 MINVALUE -92233720
 MAXVALUE 99999999
 CACHE 
go

create sequence TheThuVien_seg
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
		select next value for TheThuVien_seg

SELECT current_value FROM sys.sequences WHERE name = 'TheThuVien_seg' ;


select * from TheThuVien

