/****** Object:  ForeignKey [FK_BoMon_Khoa]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoMon_Khoa]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoMon]'))
ALTER TABLE [dbo].[BoMon] DROP CONSTRAINT [FK_BoMon_Khoa]
GO
/****** Object:  ForeignKey [FK_ChucDanh_GiaoVien_ChucDanh]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChucDanh_GiaoVien_ChucDanh]') AND parent_object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]'))
ALTER TABLE [dbo].[ChucDanh_GiaoVien] DROP CONSTRAINT [FK_ChucDanh_GiaoVien_ChucDanh]
GO
/****** Object:  ForeignKey [FK_ChucDanh_GiaoVien_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChucDanh_GiaoVien_GiaoVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]'))
ALTER TABLE [dbo].[ChucDanh_GiaoVien] DROP CONSTRAINT [FK_ChucDanh_GiaoVien_GiaoVien]
GO
/****** Object:  ForeignKey [FK_GiaoVien_BoMon]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GiaoVien_BoMon]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoVien]'))
ALTER TABLE [dbo].[GiaoVien] DROP CONSTRAINT [FK_GiaoVien_BoMon]
GO
/****** Object:  ForeignKey [FK_MonHoc_BoMon]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MonHoc_BoMon]') AND parent_object_id = OBJECT_ID(N'[dbo].[MonHoc]'))
ALTER TABLE [dbo].[MonHoc] DROP CONSTRAINT [FK_MonHoc_BoMon]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_GiaoVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien] DROP CONSTRAINT [FK_PhanCongGiaoVien_GiaoVien]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_LopHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_LopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien] DROP CONSTRAINT [FK_PhanCongGiaoVien_LopHoc]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_MonHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_MonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien] DROP CONSTRAINT [FK_PhanCongGiaoVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_PhongBan]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_PhongBan]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien] DROP CONSTRAINT [FK_PhanCongGiaoVien_PhongBan]
GO
/****** Object:  ForeignKey [FK_User_NhomUser]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_NhomUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_NhomUser]
GO
/****** Object:  Table [dbo].[User]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
DROP TABLE [dbo].[User]
GO
/****** Object:  Table [dbo].[PhanCongGiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]') AND type in (N'U'))
DROP TABLE [dbo].[PhanCongGiaoVien]
GO
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MonHoc]') AND type in (N'U'))
DROP TABLE [dbo].[MonHoc]
GO
/****** Object:  Table [dbo].[ChucDanh_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]') AND type in (N'U'))
DROP TABLE [dbo].[ChucDanh_GiaoVien]
GO
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoVien]') AND type in (N'U'))
DROP TABLE [dbo].[GiaoVien]
GO
/****** Object:  Table [dbo].[BoMon]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoMon]') AND type in (N'U'))
DROP TABLE [dbo].[BoMon]
GO
/****** Object:  Table [dbo].[NhomUser]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhomUser]') AND type in (N'U'))
DROP TABLE [dbo].[NhomUser]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan]') AND type in (N'U'))
DROP TABLE [dbo].[PhongBan]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LopHoc]') AND type in (N'U'))
DROP TABLE [dbo].[LopHoc]
GO
/****** Object:  Table [dbo].[ChucDanh]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh]') AND type in (N'U'))
DROP TABLE [dbo].[ChucDanh]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/02/2012 14:28:10 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Khoa]') AND type in (N'U'))
DROP TABLE [dbo].[Khoa]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Khoa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [bigint] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Khoa] PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Khoa] ON
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (1, N'CNTT')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (2, N'Công Nghệ Môi Trường')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (3, N'Công Nghệ Hóa Học')
SET IDENTITY_INSERT [dbo].[Khoa] OFF
/****** Object:  Table [dbo].[ChucDanh]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ChucDanh](
	[MaChucDanh] [bigint] IDENTITY(1,1) NOT NULL,
	[TenChucDanh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[LoaiChucDanh] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[HeSoLuong] [float] NULL,
 CONSTRAINT [PK_ChucDanh] PRIMARY KEY CLUSTERED 
(
	[MaChucDanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[ChucDanh] ON
INSERT [dbo].[ChucDanh] ([MaChucDanh], [TenChucDanh], [LoaiChucDanh], [HeSoLuong]) VALUES (1, N'Tiến Sĩ', N'Học Vị', 3)
INSERT [dbo].[ChucDanh] ([MaChucDanh], [TenChucDanh], [LoaiChucDanh], [HeSoLuong]) VALUES (2, N'Kỹ Sư', N'Học Vị', 2)
INSERT [dbo].[ChucDanh] ([MaChucDanh], [TenChucDanh], [LoaiChucDanh], [HeSoLuong]) VALUES (3, N'Giáo Sư', N'Học Hàm', 4)
SET IDENTITY_INSERT [dbo].[ChucDanh] OFF
/****** Object:  Table [dbo].[LopHoc]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LopHoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LopHoc](
	[MaLopHoc] [bigint] IDENTITY(1,1) NOT NULL,
	[TenLopHoc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SiSo] [int] NULL,
 CONSTRAINT [PK_LopHoc] PRIMARY KEY CLUSTERED 
(
	[MaLopHoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[LopHoc] ON
INSERT [dbo].[LopHoc] ([MaLopHoc], [TenLopHoc], [SiSo]) VALUES (1, N'A01', 100)
INSERT [dbo].[LopHoc] ([MaLopHoc], [TenLopHoc], [SiSo]) VALUES (2, N'B01', 120)
INSERT [dbo].[LopHoc] ([MaLopHoc], [TenLopHoc], [SiSo]) VALUES (3, N'A02', 110)
INSERT [dbo].[LopHoc] ([MaLopHoc], [TenLopHoc], [SiSo]) VALUES (4, N'B02', 80)
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhongBan]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhongBan](
	[MaPhongBan] [bigint] IDENTITY(1,1) NOT NULL,
	[TenPhongBan] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPhongBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (1, N'Kế Toán')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (2, N'Nhân Sự')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (3, N'Marketing')
INSERT [dbo].[PhongBan] ([MaPhongBan], [TenPhongBan]) VALUES (4, N'Kỹ Thuật')
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
/****** Object:  Table [dbo].[NhomUser]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NhomUser]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NhomUser](
	[MaNhom] [bigint] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_NhomUser] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[NhomUser] ON
INSERT [dbo].[NhomUser] ([MaNhom], [TenNhom]) VALUES (1, N'Admin')
INSERT [dbo].[NhomUser] ([MaNhom], [TenNhom]) VALUES (2, N'User')
SET IDENTITY_INSERT [dbo].[NhomUser] OFF
/****** Object:  Table [dbo].[BoMon]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[BoMon]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[BoMon](
	[MaBoMon] [bigint] IDENTITY(1,1) NOT NULL,
	[TenBoMon] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaKhoa] [bigint] NULL,
	[TrungTamDaoTao] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_BoMon] PRIMARY KEY CLUSTERED 
(
	[MaBoMon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[BoMon] ON
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa], [TrungTamDaoTao]) VALUES (1, N'Nhập môn CNPM', 1, N'Khoa Học Tự Nhiên')
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa], [TrungTamDaoTao]) VALUES (2, N'Hệ thống thống tin', 1, N'Nhất Nghệ')
INSERT [dbo].[BoMon] ([MaBoMon], [TenBoMon], [MaKhoa], [TrungTamDaoTao]) VALUES (3, N'Địa chất học', 2, N'Xã Hội Nhân Văn')
SET IDENTITY_INSERT [dbo].[BoMon] OFF
/****** Object:  Table [dbo].[GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GiaoVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[GiaoVien](
	[MaGiaoVien] [bigint] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[GioiTinh] [nchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [nchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoDienThoai] [bigint] NULL,
	[MaChucDanh] [bigint] NULL,
	[LuongCoBan] [float] NULL,
	[MaBoMon] [bigint] NULL,
	[TrangThai] [bit] NULL,
 CONSTRAINT [PK_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[GiaoVien] ON
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [HoTen], [GioiTinh], [Email], [SoDienThoai], [MaChucDanh], [LuongCoBan], [MaBoMon], [TrangThai]) VALUES (1, N'Trần Văn Tèo', N'Nam       ', N'Teo@yahoo.com                                     ', 1686894443, 1, 2000000, 1, 1)
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [HoTen], [GioiTinh], [Email], [SoDienThoai], [MaChucDanh], [LuongCoBan], [MaBoMon], [TrangThai]) VALUES (2, N'Trần Văn Ổi', N'Nam       ', N'Oi@yahoo.com                                      ', 1686823333, 2, 1000000, 2, 1)
INSERT [dbo].[GiaoVien] ([MaGiaoVien], [HoTen], [GioiTinh], [Email], [SoDienThoai], [MaChucDanh], [LuongCoBan], [MaBoMon], [TrangThai]) VALUES (3, N'Nguyễn Thị Tuyết Nga', N'Nữ        ', N'Tuyetnga@gmail.com                                ', 901112788, 3, 2500000, 3, 1)
SET IDENTITY_INSERT [dbo].[GiaoVien] OFF
/****** Object:  Table [dbo].[ChucDanh_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ChucDanh_GiaoVien](
	[MaGiaoVien] [bigint] NOT NULL,
	[MaChucDanh] [bigint] NOT NULL,
	[GhiChu] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_ChucDanh_GiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC,
	[MaChucDanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[ChucDanh_GiaoVien] ([MaGiaoVien], [MaChucDanh], [GhiChu]) VALUES (1, 1, NULL)
INSERT [dbo].[ChucDanh_GiaoVien] ([MaGiaoVien], [MaChucDanh], [GhiChu]) VALUES (1, 2, NULL)
INSERT [dbo].[ChucDanh_GiaoVien] ([MaGiaoVien], [MaChucDanh], [GhiChu]) VALUES (2, 1, NULL)
INSERT [dbo].[ChucDanh_GiaoVien] ([MaGiaoVien], [MaChucDanh], [GhiChu]) VALUES (2, 2, NULL)
/****** Object:  Table [dbo].[MonHoc]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MonHoc]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MonHoc](
	[MaMonHoc] [bigint] IDENTITY(1,1) NOT NULL,
	[TenMonHoc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoTietLyThuyet] [int] NULL,
	[SoTietThucHanh] [int] NULL,
	[SoTinChi] [int] NULL,
	[LoaiMonHoc] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaBoMon] [bigint] NULL,
 CONSTRAINT [PK_MonHoc] PRIMARY KEY CLUSTERED 
(
	[MaMonHoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[MonHoc] ON
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTietLyThuyet], [SoTietThucHanh], [SoTinChi], [LoaiMonHoc], [MaBoMon]) VALUES (1, N'Nhập môn công nghệ phần mêm', 45, 45, 6, N'1', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTietLyThuyet], [SoTietThucHanh], [SoTinChi], [LoaiMonHoc], [MaBoMon]) VALUES (2, N'Phần mềm hướng đối tượng', 45, 45, 6, N'1', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTietLyThuyet], [SoTietThucHanh], [SoTinChi], [LoaiMonHoc], [MaBoMon]) VALUES (3, N'Tư Tuởng Hồ Chí Minh', 45, 45, 4, N'1', 1)
INSERT [dbo].[MonHoc] ([MaMonHoc], [TenMonHoc], [SoTietLyThuyet], [SoTietThucHanh], [SoTinChi], [LoaiMonHoc], [MaBoMon]) VALUES (4, N'Hóa chất học', 45, 45, 2, N'1', 2)
SET IDENTITY_INSERT [dbo].[MonHoc] OFF
/****** Object:  Table [dbo].[PhanCongGiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PhanCongGiaoVien](
	[MaGiaoVien] [bigint] NOT NULL,
	[MaLopHoc] [bigint] NOT NULL,
	[MaMonHoc] [bigint] NOT NULL,
	[MaPhongBan] [bigint] NOT NULL,
	[ThoiGianDay] [int] NULL,
	[PhanCong] [bit] NULL,
	[HocKy] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NamHoc] [int] NULL,
 CONSTRAINT [PK_PhanCongGiaoVien] PRIMARY KEY CLUSTERED 
(
	[MaGiaoVien] ASC,
	[MaLopHoc] ASC,
	[MaMonHoc] ASC,
	[MaPhongBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (1, 1, 1, 1, 120, 1, N'1', 2012)
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (1, 2, 1, 1, 120, 1, N'1', 2012)
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (2, 1, 2, 1, 120, 1, N'1', 2012)
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (2, 2, 2, 1, 120, 1, N'1', 2012)
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (3, 1, 3, 1, 120, 1, N'1', 2012)
INSERT [dbo].[PhanCongGiaoVien] ([MaGiaoVien], [MaLopHoc], [MaMonHoc], [MaPhongBan], [ThoiGianDay], [PhanCong], [HocKy], [NamHoc]) VALUES (3, 2, 3, 1, 120, 1, N'1', 2012)
/****** Object:  Table [dbo].[User]    Script Date: 12/02/2012 14:28:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[User]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[User](
	[TenDangNhap] [nchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[MatKhau] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[MaNhom] [bigint] NULL,
	[Email] [nchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[SoDienThoai] [bigint] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [MaNhom], [Email], [SoDienThoai]) VALUES (N'Admin     ', N'123456', 1, N'admin@gmail.com                                   ', 12345678)
INSERT [dbo].[User] ([TenDangNhap], [MatKhau], [MaNhom], [Email], [SoDienThoai]) VALUES (N'User      ', N'123456', 2, N'user@gmail.com                                    ', 909990009)
/****** Object:  ForeignKey [FK_BoMon_Khoa]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_BoMon_Khoa]') AND parent_object_id = OBJECT_ID(N'[dbo].[BoMon]'))
ALTER TABLE [dbo].[BoMon]  WITH CHECK ADD  CONSTRAINT [FK_BoMon_Khoa] FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[BoMon] CHECK CONSTRAINT [FK_BoMon_Khoa]
GO
/****** Object:  ForeignKey [FK_ChucDanh_GiaoVien_ChucDanh]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChucDanh_GiaoVien_ChucDanh]') AND parent_object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]'))
ALTER TABLE [dbo].[ChucDanh_GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_ChucDanh_GiaoVien_ChucDanh] FOREIGN KEY([MaChucDanh])
REFERENCES [dbo].[ChucDanh] ([MaChucDanh])
GO
ALTER TABLE [dbo].[ChucDanh_GiaoVien] CHECK CONSTRAINT [FK_ChucDanh_GiaoVien_ChucDanh]
GO
/****** Object:  ForeignKey [FK_ChucDanh_GiaoVien_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ChucDanh_GiaoVien_GiaoVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[ChucDanh_GiaoVien]'))
ALTER TABLE [dbo].[ChucDanh_GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_ChucDanh_GiaoVien_GiaoVien] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[ChucDanh_GiaoVien] CHECK CONSTRAINT [FK_ChucDanh_GiaoVien_GiaoVien]
GO
/****** Object:  ForeignKey [FK_GiaoVien_BoMon]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_GiaoVien_BoMon]') AND parent_object_id = OBJECT_ID(N'[dbo].[GiaoVien]'))
ALTER TABLE [dbo].[GiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_GiaoVien_BoMon] FOREIGN KEY([MaBoMon])
REFERENCES [dbo].[BoMon] ([MaBoMon])
GO
ALTER TABLE [dbo].[GiaoVien] CHECK CONSTRAINT [FK_GiaoVien_BoMon]
GO
/****** Object:  ForeignKey [FK_MonHoc_BoMon]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MonHoc_BoMon]') AND parent_object_id = OBJECT_ID(N'[dbo].[MonHoc]'))
ALTER TABLE [dbo].[MonHoc]  WITH CHECK ADD  CONSTRAINT [FK_MonHoc_BoMon] FOREIGN KEY([MaBoMon])
REFERENCES [dbo].[BoMon] ([MaBoMon])
GO
ALTER TABLE [dbo].[MonHoc] CHECK CONSTRAINT [FK_MonHoc_BoMon]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_GiaoVien]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_GiaoVien]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongGiaoVien_GiaoVien] FOREIGN KEY([MaGiaoVien])
REFERENCES [dbo].[GiaoVien] ([MaGiaoVien])
GO
ALTER TABLE [dbo].[PhanCongGiaoVien] CHECK CONSTRAINT [FK_PhanCongGiaoVien_GiaoVien]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_LopHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_LopHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongGiaoVien_LopHoc] FOREIGN KEY([MaLopHoc])
REFERENCES [dbo].[LopHoc] ([MaLopHoc])
GO
ALTER TABLE [dbo].[PhanCongGiaoVien] CHECK CONSTRAINT [FK_PhanCongGiaoVien_LopHoc]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_MonHoc]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_MonHoc]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongGiaoVien_MonHoc] FOREIGN KEY([MaMonHoc])
REFERENCES [dbo].[MonHoc] ([MaMonHoc])
GO
ALTER TABLE [dbo].[PhanCongGiaoVien] CHECK CONSTRAINT [FK_PhanCongGiaoVien_MonHoc]
GO
/****** Object:  ForeignKey [FK_PhanCongGiaoVien_PhongBan]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PhanCongGiaoVien_PhongBan]') AND parent_object_id = OBJECT_ID(N'[dbo].[PhanCongGiaoVien]'))
ALTER TABLE [dbo].[PhanCongGiaoVien]  WITH CHECK ADD  CONSTRAINT [FK_PhanCongGiaoVien_PhongBan] FOREIGN KEY([MaPhongBan])
REFERENCES [dbo].[PhongBan] ([MaPhongBan])
GO
ALTER TABLE [dbo].[PhanCongGiaoVien] CHECK CONSTRAINT [FK_PhanCongGiaoVien_PhongBan]
GO
/****** Object:  ForeignKey [FK_User_NhomUser]    Script Date: 12/02/2012 14:28:10 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_User_NhomUser]') AND parent_object_id = OBJECT_ID(N'[dbo].[User]'))
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_NhomUser] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NhomUser] ([MaNhom])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_NhomUser]
GO
