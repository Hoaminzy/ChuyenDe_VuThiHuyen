USE [master]
GO
/****** Object:  Database [QLChauCay]    Script Date: 2/26/2021 4:34:47 PM ******/
CREATE DATABASE [QLChauCay]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLChauCay', FILENAME = N'D:\BT\DATN\Huyen\QLBH\DB\QLChauCay.MDF' , SIZE = 204800KB , MAXSIZE = UNLIMITED, FILEGROWTH = 20480KB )
 LOG ON 
( NAME = N'QLChauCay_log', FILENAME = N'D:\BT\DATN\Huyen\QLBH\DB\QLChauCay.ldf' , SIZE = 102400KB , MAXSIZE = 2048GB , FILEGROWTH = 20480KB )
GO
ALTER DATABASE [QLChauCay] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLChauCay].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLChauCay] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLChauCay] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLChauCay] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLChauCay] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLChauCay] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLChauCay] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLChauCay] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLChauCay] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLChauCay] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLChauCay] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLChauCay] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLChauCay] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLChauCay] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLChauCay] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLChauCay] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLChauCay] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLChauCay] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLChauCay] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLChauCay] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLChauCay] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLChauCay] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLChauCay] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLChauCay] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLChauCay] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLChauCay] SET  MULTI_USER 
GO
ALTER DATABASE [QLChauCay] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLChauCay] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLChauCay] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLChauCay] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLChauCay]
GO
/****** Object:  StoredProcedure [dbo].[ChangeStatus_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ChangeStatus_KhachHang](
    @Status bit,
    @idKhachHang int
 )
 as update  tbl_KhachHang set @Status= 'false' where idKhachHang = @idKhachHang
GO
/****** Object:  StoredProcedure [dbo].[Delete_Chau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[Delete_Chau](
    @idChau int
 )
 as delete from tbl_ChauCay where idChau = @idChau

GO
/****** Object:  StoredProcedure [dbo].[Delete_CTHoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[Delete_CTHoaDon](
    @idCTHD  int
 )
 as delete from tbl_ChiTietHoaDon where idCTHD  = @idCTHD 

GO
/****** Object:  StoredProcedure [dbo].[Delete_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[Delete_HoaDon](
    @idHoaDon int
 )
 as delete from tbl_HoaDon where idHoaDon = @idHoaDon
GO
/****** Object:  StoredProcedure [dbo].[Delete_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[Delete_KhachHang](
    @idKhachHang int
 )
 as delete from tbl_KhachHang where idKhachHang = @idKhachHang
GO
/****** Object:  StoredProcedure [dbo].[Delete_LoaiChau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[Delete_LoaiChau](
    @idLoaiChau int
 )
 as delete from tbl_LoaiChau where idLoaiChau = @idLoaiChau
GO
/****** Object:  StoredProcedure [dbo].[Delete_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 create proc [dbo].[Delete_NhanVien](
    @idNhanVien int
 )
 as delete from tbl_NhanVien where idNhanVien = @idNhanVien
GO
/****** Object:  StoredProcedure [dbo].[getHoadon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[getHoadon]
		as
			select tbl_HoaDon.idHoaDon, tbl_NhanVien.sTenNV, tbl_KhachHang.sTenKH , sum(tbl_ChiTietHoaDon.sSoLuong*tbl_ChiTietHoaDon.fDonGia) as tong_tien,  tbl_HoaDon.Createdate, tbl_HoaDon.Status
			from tbl_HoaDon
			inner join tbl_ChiTietHoaDon on tbl_HoaDon.idHoaDon =tbl_ChiTietHoaDon.idHoaDon
			inner join tbl_NhanVien on tbl_NhanVien.idNhanVien=tbl_HoaDon.idHoaDon
			inner join tbl_KhachHang on tbl_KhachHang.idKhachHang = tbl_HoaDon.idHoaDon
			group by tbl_HoaDon.idHoaDon,tbl_NhanVien.sTenNV, tbl_KhachHang.sTenKH, tbl_HoaDon.Createdate, tbl_HoaDon.Status
GO
/****** Object:  StoredProcedure [dbo].[Insert_ChauCay]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_ChauCay]
(
	@idLoaiChau int
    ,@sTenChau nvarchar(150)
   , @sChatLieu nvarchar(150)
   , @sMauSac nvarchar(150)
   ,@fDonGia float 
   ,@fGiaNhap float 
   ,@sSoLuong int
   ,@sMoTa nvarchar(500)
   ,@sNhaCungCap nvarchar(150)
   , @sHinhAnh nvarchar(500)
  , @sKichThuoc int )
as
insert into tbl_ChauCay(idLoaiChau, sTenChau , sChatLieu, sMauSac, fDonGia, fGiaNhap, sSoLuong, sMoTa, sNhaCungCap, sHinhAnh, sKichThuoc )
values (
@idLoaiChau
 ,@sTenChau 
   , @sChatLieu 
   , @sMauSac
   ,@fDonGia  
   ,@fGiaNhap 
   ,@sSoLuong 
   ,@sMoTa
   ,@sNhaCungCap 
   , @sHinhAnh 
  , @sKichThuoc  )
GO
/****** Object:  StoredProcedure [dbo].[Insert_CTHoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_CTHoaDon]
(
    @idHoaDon int
   ,@idChau int
   , @fDonGia float 
   , @sSoLuong int  )
as
insert into tbl_CTHoaDon(idHoaDon, idChau , fDonGia, sSoLuong )
values (
@idHoaDon
 ,@idChau
   , @fDonGia
   , @sSoLuong
 )
GO
/****** Object:  StoredProcedure [dbo].[Insert_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_HoaDon]
(
    @idNhanVien int
   ,@idKhachHang int
  , @Createdate date )
as
insert into tbl_HoaDon( idNhanVien , idKhachHang, Createdate )
values (
 @idNhanVien
   ,@idKhachHang
  ,@Createdate  )
GO
/****** Object:  StoredProcedure [dbo].[Insert_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_KhachHang]
(
  @sTenKH nvarchar(100)
  , @sDiaChi nvarchar(150)
  , @sCMND varchar(50)
  , @sGioiTinh nvarchar(5)
  , @sSDT varchar(12)
  , @sNgaySinh date)
as
insert into tbl_KhachHang(sTenKH, sDiaChi, sCMND, sGioiTinh, sSDT, sNgaySinh )
values (@sTenKH 
  , @sDiaChi
  , @sCMND 
  , @sGioiTinh 
  , @sSDT 
  , @sNgaySinh 
   )
GO
/****** Object:  StoredProcedure [dbo].[Insert_LoaiChau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_LoaiChau]
(
    @sTenLoai nvarchar(150)
  )
as
insert into tbl_LoaiChau(sTenLoai )
values (
	@sTenLoai
  )

GO
/****** Object:  StoredProcedure [dbo].[Insert_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Insert_NhanVien]
(
   @sTenNV nvarchar(50)
  , @sDiaChi nvarchar(150)
  , @sCMND varchar(50)
  , @sGioiTinh nvarchar(5)
  , @sSDT varchar(12)
  , @sNgaySinh date
  , @Username nvarchar(50)
  , @Password nvarchar(50)
  )
as
insert into tbl_NhanVien(sTenNV, sDiaChi, sCMND, sGioiTinh, sSDT, sNgaySinh,Username, Password )
values (
	@sTenNV
  , @sDiaChi
  , @sCMND 
  , @sGioiTinh 
  , @sSDT 
  , @sNgaySinh 
  , @Username
  , @Password
  )
GO
/****** Object:  StoredProcedure [dbo].[Rp_Chau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[Rp_Chau]
 as 
 select tbl_ChauCay.idChau, tbl_ChauCay.sTenChau, tbl_LoaiChau.sTenLoai, tbl_ChauCay.sChatLieu,tbl_ChauCay.sMauSac, tbl_ChauCay.fDonGia, tbl_ChauCay.sSoLuong, tbl_ChauCay.sKichThuoc
  from tbl_ChauCay inner join tbl_LoaiChau  
  on tbl_ChauCay.idLoaiChau = tbl_LoaiChau.idLoaiChau 
GO
/****** Object:  StoredProcedure [dbo].[rp_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rp_HoaDon]
 as
 select tbl_HoaDon.idHoaDon, tbl_NhanVien.idNhanVien, tbl_NhanVien.sTenNV, tbl_ChauCay.sTenChau,tbl_ChiTietHoaDon.fDonGia, tbl_ChiTietHoaDon.sSoLuong, (tbl_ChiTietHoaDon.fDonGia * tbl_ChiTietHoaDon.sSoLuong) as thanh_tien, tbl_HoaDon.Createdate, sum(tbl_ChiTietHoaDon.fDonGia * tbl_ChiTietHoaDon.sSoLuong) as tong_tien
 from tbl_HoaDon inner join tbl_NhanVien on tbl_HoaDon.idNhanVien = tbl_NhanVien.idNhanVien
 inner join tbl_ChiTietHoaDon on tbl_HoaDon.idHoaDon = tbl_ChiTietHoaDon.idHoaDon
 inner join tbl_ChauCay on tbl_ChiTietHoaDon.idChau = tbl_ChauCay.idChau
 group by tbl_HoaDon.idHoaDon,tbl_NhanVien.idNhanVien, tbl_NhanVien.sTenNV, tbl_ChauCay.sTenChau,tbl_ChiTietHoaDon.fDonGia, tbl_ChiTietHoaDon.sSoLuong,tbl_HoaDon.Createdate order by tbl_HoaDon.Createdate desc

GO
/****** Object:  StoredProcedure [dbo].[rp_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[rp_NhanVien]
 as
 select idNhanVien, sTenNV, Username,sSDT, sDiaChi, sCMND, sGioiTinh, sNgaySinh from tbl_NhanVien 
 ---------------------
GO
/****** Object:  StoredProcedure [dbo].[select_AllNV]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[select_AllNV]
 as
 select sTenNV, Username, sDiaChi, sCMND, sGioiTinh, sSDT, sNgaySinh from tbl_NhanVien
GO
/****** Object:  StoredProcedure [dbo].[Select_ChauCay]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_ChauCay]
as
select * from tbl_ChauCay
GO
/****** Object:  StoredProcedure [dbo].[Select_CTHoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Select_CTHoaDon]
as
select * from tbl_ChiTietHoaDon
GO
/****** Object:  StoredProcedure [dbo].[Select_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_HoaDon]
as
select * from tbl_HoaDon
GO
/****** Object:  StoredProcedure [dbo].[Select_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_KhachHang]
as
select * from tbl_KhachHang
GO
/****** Object:  StoredProcedure [dbo].[Select_LoaiChau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_LoaiChau]
as
select * from tbl_LoaiChau

GO
/****** Object:  StoredProcedure [dbo].[Select_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Select_NhanVien](
  @Username nvarchar(50)
  , @Password nvarchar(50)
)
as
select * from tbl_NhanVien where UserName = @UserName and Password = @Password

GO
/****** Object:  StoredProcedure [dbo].[sp_ThemHD]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  Create proc [dbo].[sp_ThemHD]
as	
	select  tbl_HoaDon.idHoaDon, tbl_NhanVien.sTenNV, sum(tbl_ChiTietHoaDon.sSoLuong) as TongSL, sum(tbl_ChiTietHoaDon.sSoLuong*tbl_ChiTietHoaDon.fDonGia) as tong_tien, tbl_HoaDon.Createdate, tbl_HoaDon.Status from tbl_HoaDon, tbl_ChiTietHoaDon, tbl_NhanVien
	where  tbl_HoaDon.idHoaDon = tbl_ChiTietHoaDon.idHoaDon and tbl_HoaDon.idNhanVien=tbl_NhanVien.idNhanVien
	group by tbl_HoaDon.idHoaDon , tbl_HoaDon.Createdate, tbl_hoaDon.Status, tbl_NhanVien.sTenNV
	order by tbl_HoaDon.Createdate desc
GO
/****** Object:  StoredProcedure [dbo].[Update_ChauCay]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_ChauCay](
  @idChau int
  ,@idLoaiChau int
     ,@sTenChau nvarchar(150)
   , @sChatLieu nvarchar(150)
   , @sMauSac nvarchar(150)
   ,@fDonGia float 
   ,@fGiaNhap float 
   ,@sSoLuong int 
   ,@sMoTa nvarchar(500)
   ,@sNhaCungCap nvarchar(150)
   , @sHinhAnh nvarchar(500) 
  , @sKichThuoc int
  )
  as begin
 Update tbl_ChauCay
 set idLoaiChau = @idLoaiChau, sTenChau = @sTenChau, sChatLieu = @sChatLieu, sMauSac = @sMauSac, fDonGia= @fDonGia, fGiaNhap = @fGiaNhap, sSoLuong = @sSoLuong, sMoTa = @sMoTa,  sNhaCungCap = @sNhaCungCap,  sHinhAnh = @sHinhAnh, sKichThuoc = @sKichThuoc
 where idChau = @idChau
 end
GO
/****** Object:  StoredProcedure [dbo].[Update_CTHoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[Update_CTHoaDon](
    @idCTHD int 
   ,@idHoaDon int
   ,@idChau int
   , @fDonGia float 
   , @sSoLuong int
  )
  as begin
 Update tbl_ChiTietHoaDon
 set idHoaDon = @idHoaDon, idChau  = @idChau , @idChau = @idChau, fDonGia = @fDonGia, @sSoLuong = @sSoLuong
 where idCTHD  = @idCTHD 
 end
GO
/****** Object:  StoredProcedure [dbo].[Update_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_HoaDon](
	 @idHoaDon int
   , @idNhanVien int
   ,@idKhachHang int
  , @Createdate date
  )
  as begin
 Update tbl_HoaDon
 set idNhanVien = @idNhanVien, idKhachHang = @idKhachHang, Createdate = @Createdate
 where idHoaDon = @idHoaDon
 end
GO
/****** Object:  StoredProcedure [dbo].[Update_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[Update_KhachHang](
  @idKhachHang int
  ,@sTenKH nvarchar(50)
  , @sDiaChi nvarchar(150)
  , @sCMND varchar(50)
  , @sGioiTinh nvarchar(5)
  , @sSDT varchar(12)
  , @sNgaySinh date
  )
  as begin
 Update tbl_KhachHang 
 set sTenKH = @sTenKH, sDiaChi = @sDiaChi, sCMND = @sCMND, sGioiTinh = @sGioiTinh
 where idKhachHang = @idKhachHang
 end
GO
/****** Object:  StoredProcedure [dbo].[Update_LoaiChau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_LoaiChau](
  @idLoaiChau int
  ,  @sTenLoai nvarchar(150)
  )
  as begin
 Update tbl_LoaiChau
 set sTenLoai = @sTenLoai
 where idLoaiChau = @idLoaiChau
 end

GO
/****** Object:  StoredProcedure [dbo].[Update_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Update_NhanVien](
  @idNhanVien int
  ,@sTenNV nvarchar(100)
  , @sDiaChi nvarchar(150)
  , @sCMND varchar(50)
  , @sGioiTinh nvarchar(5)
  , @sSDT varchar(12)
  , @sNgaySinh date
  , @Username nvarchar(50)
  , @Password nvarchar(50)
  )
  as begin
 Update tbl_NhanVien
 set sTenNV = @sTenNV, sDiaChi = @sDiaChi, sCMND = @sCMND, sGioiTinh = @sGioiTinh, Username =@Username, Password = @Password 
 where idNhanVien = @idNhanVien
 end

GO
/****** Object:  Table [dbo].[tbl_ChauCay]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChauCay](
	[idChau] [int] IDENTITY(1,1) NOT NULL,
	[idLoaiChau] [int] NULL,
	[sTenChau] [nvarchar](150) NULL,
	[sChatLieu] [nvarchar](150) NULL,
	[sMauSac] [nvarchar](150) NULL,
	[fDonGia] [float] NULL DEFAULT ((0)),
	[fGiaNhap] [float] NULL DEFAULT ((0)),
	[sSoLuong] [int] NULL DEFAULT ((0)),
	[sMoTa] [nvarchar](500) NULL,
	[sNhaCungCap] [nvarchar](150) NULL,
	[sHinhAnh] [nvarchar](500) NULL,
	[sKichThuoc] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idChau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_ChiTietHoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTietHoaDon](
	[idCTHD] [int] IDENTITY(1,1) NOT NULL,
	[idHoaDon] [int] NULL,
	[idChau] [int] NULL,
	[fDonGia] [float] NULL DEFAULT ((0)),
	[sSoLuong] [int] NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[idCTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[idHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [int] NULL,
	[idKhachHang] [int] NULL,
	[Status] [int] NULL DEFAULT ((0)),
	[Createdate] [date] NULL DEFAULT (getdate()),
PRIMARY KEY CLUSTERED 
(
	[idHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[idKhachHang] [int] IDENTITY(1,1) NOT NULL,
	[sTenKH] [nvarchar](50) NULL,
	[sDiaChi] [nvarchar](150) NULL,
	[sCMND] [varchar](50) NULL,
	[sGioiTinh] [nvarchar](5) NULL,
	[sSDT] [varchar](12) NULL,
	[sNgaySinh] [date] NULL,
 CONSTRAINT [PK__tbl_Khac__DAF646D07294541D] PRIMARY KEY CLUSTERED 
(
	[idKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_LoaiChau]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_LoaiChau](
	[idLoaiChau] [int] IDENTITY(1,1) NOT NULL,
	[sTenLoai] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[idLoaiChau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhanVien]    Script Date: 2/26/2021 4:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_NhanVien](
	[idNhanVien] [int] IDENTITY(1,1) NOT NULL,
	[sTenNV] [nvarchar](50) NULL,
	[sDiaChi] [nvarchar](150) NULL,
	[sCMND] [varchar](50) NULL,
	[sGioiTinh] [nvarchar](5) NULL,
	[sSDT] [varchar](12) NULL,
	[sNgaySinh] [date] NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[tbl_ChauCay]  WITH CHECK ADD  CONSTRAINT [FK_LoaiChau] FOREIGN KEY([idLoaiChau])
REFERENCES [dbo].[tbl_LoaiChau] ([idLoaiChau])
GO
ALTER TABLE [dbo].[tbl_ChauCay] CHECK CONSTRAINT [FK_LoaiChau]
GO
ALTER TABLE [dbo].[tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTTHD] FOREIGN KEY([idHoaDon])
REFERENCES [dbo].[tbl_HoaDon] ([idHoaDon])
GO
ALTER TABLE [dbo].[tbl_ChiTietHoaDon] CHECK CONSTRAINT [FK_CTTHD]
GO
ALTER TABLE [dbo].[tbl_ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_CTTHD_Chau] FOREIGN KEY([idChau])
REFERENCES [dbo].[tbl_ChauCay] ([idChau])
GO
ALTER TABLE [dbo].[tbl_ChiTietHoaDon] CHECK CONSTRAINT [FK_CTTHD_Chau]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HD_KH] FOREIGN KEY([idKhachHang])
REFERENCES [dbo].[tbl_KhachHang] ([idKhachHang])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_HD_KH]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HD_NV] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[tbl_NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_HD_NV]
GO
USE [master]
GO
ALTER DATABASE [QLChauCay] SET  READ_WRITE 
GO
