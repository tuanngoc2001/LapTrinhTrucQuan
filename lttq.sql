USE [LTTQ]
GO
/****** Object:  Table [dbo].[dangky]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dangky](
	[user] [varchar](50) NULL,
	[pass] [varchar](50) NULL,
	[email] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DoChoi]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoChoi](
	[MaDoChoi] [varchar](50) NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[MaTheLoai] [varchar](50) NULL,
	[DonGiaBan] [int] NULL,
	[DonGiaNhap] [int] NULL,
	[DoTuoi] [int] NULL,
	[GioiTinh] [nchar](10) NULL,
	[Anh] [varchar](50) NULL,
 CONSTRAINT [PK_DoChoi] PRIMARY KEY CLUSTERED 
(
	[MaDoChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GianHang]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GianHang](
	[MaDoChoi] [varchar](50) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_GianHang] PRIMARY KEY CLUSTERED 
(
	[MaDoChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[SoHDB] [varchar](50) NOT NULL,
	[MaNV] [varchar](50) NULL,
	[MaKH] [varchar](50) NULL,
	[MaDoChoi] [varchar](50) NULL,
	[SoLuong] [int] NULL,
	[KhuyenMai] [float] NULL,
	[NgayBan] [date] NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[SoHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [varchar](50) NOT NULL,
	[TenKH] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Diem] [int] NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kho]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kho](
	[MaKho] [varchar](50) NOT NULL,
	[MaDoChoi] [varchar](50) NULL,
	[TinhTrang] [nvarchar](50) NULL,
	[SoLuongTon] [int] NULL,
 CONSTRAINT [PK_Kho] PRIMARY KEY CLUSTERED 
(
	[MaKho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[MaNCC] [varchar](50) NOT NULL,
	[TenNCC] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SDT] [int] NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[MaNCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[SoCMT] [varchar](50) NULL,
	[SDT] [varchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhap]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhap](
	[SoHDN] [varchar](50) NOT NULL,
	[MaNCC] [varchar](50) NULL,
	[MaNV] [varchar](50) NULL,
	[MaDoChoi] [varchar](50) NULL,
	[SoLuongNhap] [int] NULL,
	[KhuyenMai] [float] NULL,
	[NgayNhap] [date] NULL,
 CONSTRAINT [PK_Nhap] PRIMARY KEY CLUSTERED 
(
	[SoHDN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanLiNhanVien]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanLiNhanVien](
	[MaNV] [varchar](50) NOT NULL,
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NOT NULL,
	[NgayVaoLam] [date] NULL,
	[LuongCoBan] [float] NULL,
	[ThuongDT] [float] NULL,
	[email] [varchar](50) NULL,
	[Anh] [nvarchar](200) NULL,
	[DoanhThu] [float] NULL,
 CONSTRAINT [PK_QuanLiNhanVien] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC,
	[MatKhau] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tChiTietHDB]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tChiTietHDB](
	[MaHDB] [varchar](20) NOT NULL,
	[MaDoChoi] [varchar](20) NOT NULL,
	[NgayBan] [datetime] NULL,
	[SoTien] [float] NULL,
 CONSTRAINT [PK_tChiTietHDB] PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC,
	[MaDoChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 11/24/2021 8:48:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](50) NOT NULL,
	[TenTheLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_TheLoai] PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DoChoi] ([MaDoChoi], [Ten], [MaTheLoai], [DonGiaBan], [DonGiaNhap], [DoTuoi], [GioiTinh], [Anh]) VALUES (N'A1', N'xetai', N'B1', 10000, 5000, 12, N'Nam       ', N'cao.jpg')
INSERT [dbo].[DoChoi] ([MaDoChoi], [Ten], [MaTheLoai], [DonGiaBan], [DonGiaNhap], [DoTuoi], [GioiTinh], [Anh]) VALUES (N'A2', N'bupbe', N'B2', 12000, 6000, 12, N'Nu        ', N'bupbe.jpg')
INSERT [dbo].[DoChoi] ([MaDoChoi], [Ten], [MaTheLoai], [DonGiaBan], [DonGiaNhap], [DoTuoi], [GioiTinh], [Anh]) VALUES (N'A3', N'logo', N'B3', 8000, 4000, 12, N'Nam       ', N'Logo.jpg')
INSERT [dbo].[DoChoi] ([MaDoChoi], [Ten], [MaTheLoai], [DonGiaBan], [DonGiaNhap], [DoTuoi], [GioiTinh], [Anh]) VALUES (N'A4', N'mohinhxe', N'B4', 20000, 10000, 12, N'Nam       ', N'xe tai.jpg')
INSERT [dbo].[DoChoi] ([MaDoChoi], [Ten], [MaTheLoai], [DonGiaBan], [DonGiaNhap], [DoTuoi], [GioiTinh], [Anh]) VALUES (N'A5', N'sieunhan', N'B5', 16000, 10000, 12, N'Nam       ', N'b1.jpg')
GO
INSERT [dbo].[GianHang] ([MaDoChoi], [SoLuong]) VALUES (N'A1', 170)
INSERT [dbo].[GianHang] ([MaDoChoi], [SoLuong]) VALUES (N'A2', 130)
INSERT [dbo].[GianHang] ([MaDoChoi], [SoLuong]) VALUES (N'A3', 120)
INSERT [dbo].[GianHang] ([MaDoChoi], [SoLuong]) VALUES (N'A4', 80)
INSERT [dbo].[GianHang] ([MaDoChoi], [SoLuong]) VALUES (N'A5', 90)
GO
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB1', N'NV1', N'KH1', N'A1', 160, 0.1, CAST(N'2002-05-09' AS Date))
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB2', N'NV2', N'KH2', N'A2', 60, 0.1, CAST(N'2002-07-08' AS Date))
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB3', N'NV3', N'KH3', N'A3', 48, 0.1, CAST(N'2002-08-09' AS Date))
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB4', N'NV3', N'KH4', N'A4', 58, 0.1, CAST(N'2002-08-06' AS Date))
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB5', N'NV5', N'KH5', N'A5', 67, 0.1, CAST(N'2002-01-04' AS Date))
INSERT [dbo].[HoaDon] ([SoHDB], [MaNV], [MaKH], [MaDoChoi], [SoLuong], [KhuyenMai], [NgayBan]) VALUES (N'HDB6', N'NV1', N'KH3', N'A1', 1, 2, CAST(N'2021-11-22' AS Date))
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Diem]) VALUES (N'KH1', N'Minh', N'02142144  ', N'Phutho', 121000)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Diem]) VALUES (N'KH2', N'Quang', N'01242144  ', N'BacNinh', 121000)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Diem]) VALUES (N'KH3', N'Nam', N'01241244  ', N'QuangNgai', 135400)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Diem]) VALUES (N'KH4', N'Hang', N'06757522  ', N'TayNinh', 120012)
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [DiaChi], [Diem]) VALUES (N'KH5', N'Bich', N'01412441  ', N'CaMau', 132300)
GO
INSERT [dbo].[Kho] ([MaKho], [MaDoChoi], [TinhTrang], [SoLuongTon]) VALUES (N'MK1', N'A1', N'Con', 83)
INSERT [dbo].[Kho] ([MaKho], [MaDoChoi], [TinhTrang], [SoLuongTon]) VALUES (N'MK2', N'A2', N'Con', 15)
INSERT [dbo].[Kho] ([MaKho], [MaDoChoi], [TinhTrang], [SoLuongTon]) VALUES (N'MK3', N'A3', N'Con', 4)
INSERT [dbo].[Kho] ([MaKho], [MaDoChoi], [TinhTrang], [SoLuongTon]) VALUES (N'MK4', N'A4', N'Con', 21)
INSERT [dbo].[Kho] ([MaKho], [MaDoChoi], [TinhTrang], [SoLuongTon]) VALUES (N'MK5', N'A5', N'Con', 8)
GO
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC1', N'MinhKhai', N'Coloa', 123412)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC2', N'ChauPhong', N'BacNinh', 124214)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC3', N'VanNinh', N'NamDInh', 432562)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC4', N'DinhThu', N'QuangNgai', 412412)
INSERT [dbo].[NhaCungCap] ([MaNCC], [TenNCC], [DiaChi], [SDT]) VALUES (N'NCC5', N'VanNghia', N'NhaTrang', 182522)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV1', N'Nguyễn Tuấn Ngọc', N'Nam', CAST(N'2001-11-08' AS Date), N'Đông Anh', N'12345678', N'0912414', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV2', N'Nguyễn Tuấn Ngọc', N'Nu', CAST(N'2001-12-06' AS Date), N'GiaLam', N'46325233', N'014124124', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV3', N'C', N'Nam', CAST(N'2001-05-07' AS Date), N'LongAn', N'12412452', N'015421441', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV4', N'D', N'Nu', CAST(N'2001-05-01' AS Date), N'BacGiang', N'14124124', N'041241244', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV5', N'E', N'Nam', CAST(N'2001-04-11' AS Date), N'Lao', N'21412442', N'012412442', N'NhanVien')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [NgaySinh], [QueQuan], [SoCMT], [SDT], [ChucVu]) VALUES (N'NV6', N'C', N'Nam', CAST(N'2001-05-07' AS Date), N'LongAn', N'12412452', N'015421441', N'NhanVien')
GO
INSERT [dbo].[Nhap] ([SoHDN], [MaNCC], [MaNV], [MaDoChoi], [SoLuongNhap], [KhuyenMai], [NgayNhap]) VALUES (N'HDN1', N'NCC2', N'NV2', N'A2', 111, 0.1, CAST(N'2002-01-01' AS Date))
INSERT [dbo].[Nhap] ([SoHDN], [MaNCC], [MaNV], [MaDoChoi], [SoLuongNhap], [KhuyenMai], [NgayNhap]) VALUES (N'HDN2', N'NCC3', N'NV3', N'A3', 80, 0.1, CAST(N'2002-01-01' AS Date))
INSERT [dbo].[Nhap] ([SoHDN], [MaNCC], [MaNV], [MaDoChoi], [SoLuongNhap], [KhuyenMai], [NgayNhap]) VALUES (N'HDN3', N'NCC4', N'NV4', N'A4', 85, 0.1, CAST(N'2002-01-01' AS Date))
INSERT [dbo].[Nhap] ([SoHDN], [MaNCC], [MaNV], [MaDoChoi], [SoLuongNhap], [KhuyenMai], [NgayNhap]) VALUES (N'HDN4', N'NCC1', N'NV1', N'A1', 1, 10, CAST(N'2021-11-22' AS Date))
INSERT [dbo].[Nhap] ([SoHDN], [MaNCC], [MaNV], [MaDoChoi], [SoLuongNhap], [KhuyenMai], [NgayNhap]) VALUES (N'HDN5', N'NCC1', N'NV1', N'A1', 10, 10, CAST(N'2021-11-22' AS Date))
GO
INSERT [dbo].[QuanLiNhanVien] ([MaNV], [TaiKhoan], [MatKhau], [NgayVaoLam], [LuongCoBan], [ThuongDT], [email], [Anh], [DoanhThu]) VALUES (N'NV1', N'TK1', N'81DC9BDB52D04DC20036DBD8313ED055', CAST(N'2001-05-05' AS Date), 500.1, 5020.2, N'tuanngocnguyen78@gmail.com', N'avatar1.jpg', NULL)
INSERT [dbo].[QuanLiNhanVien] ([MaNV], [TaiKhoan], [MatKhau], [NgayVaoLam], [LuongCoBan], [ThuongDT], [email], [Anh], [DoanhThu]) VALUES (N'NV2', N'TK2', N'81B073DE9370EA873F548E31B8ADC081', CAST(N'2001-06-05' AS Date), 500.1, 20.2, NULL, N'avatar.jpg', NULL)
INSERT [dbo].[QuanLiNhanVien] ([MaNV], [TaiKhoan], [MatKhau], [NgayVaoLam], [LuongCoBan], [ThuongDT], [email], [Anh], [DoanhThu]) VALUES (N'NV3', N'TK3', N'AFF0A6A4521232970B2C1CF539AD0A19', CAST(N'2001-06-05' AS Date), 500.1, 4020.1999999999534, NULL, N'avatar.jpg', NULL)
INSERT [dbo].[QuanLiNhanVien] ([MaNV], [TaiKhoan], [MatKhau], [NgayVaoLam], [LuongCoBan], [ThuongDT], [email], [Anh], [DoanhThu]) VALUES (N'NV4', N'TK4', N'7DC3338D429A3114842CA29DBBFCCFEF', CAST(N'2001-06-05' AS Date), 500.1, 20.2, NULL, N'avatar.jpg', NULL)
INSERT [dbo].[QuanLiNhanVien] ([MaNV], [TaiKhoan], [MatKhau], [NgayVaoLam], [LuongCoBan], [ThuongDT], [email], [Anh], [DoanhThu]) VALUES (N'NV5', N'TK5', N'8A057268A74A5F1201285AA667585E15', CAST(N'2001-05-05' AS Date), 500.1, 20.2, NULL, N'avatar.jpg', NULL)
GO
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB1', N'NV1', CAST(N'2019-01-01T00:00:00.000' AS DateTime), 900000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB10', N'NV1', CAST(N'2021-09-01T00:00:00.000' AS DateTime), 5000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB11', N'NV1', CAST(N'2021-10-01T00:00:00.000' AS DateTime), 6000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB12', N'NV1', CAST(N'2021-11-01T00:00:00.000' AS DateTime), 1000001)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB13', N'NV1', CAST(N'2021-12-01T00:00:00.000' AS DateTime), 2000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB14', N'NV1', CAST(N'2020-01-01T00:00:00.000' AS DateTime), 3000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB2', N'NV2', CAST(N'2021-01-01T00:00:00.000' AS DateTime), 1230000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB3', N'NV1', CAST(N'2021-02-01T00:00:00.000' AS DateTime), 1000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB4', N'NV1', CAST(N'2021-03-01T00:00:00.000' AS DateTime), 1000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB5', N'NV1', CAST(N'2021-04-01T00:00:00.000' AS DateTime), 3000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB6', N'NV1', CAST(N'2021-05-01T00:00:00.000' AS DateTime), 1230000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB7', N'NV1', CAST(N'2021-06-01T00:00:00.000' AS DateTime), 1111111)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB8', N'NV1', CAST(N'2021-07-01T00:00:00.000' AS DateTime), 2000000)
INSERT [dbo].[tChiTietHDB] ([MaHDB], [MaDoChoi], [NgayBan], [SoTien]) VALUES (N'HDB9', N'NV1', CAST(N'2021-08-01T00:00:00.000' AS DateTime), 3000000)
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'B1', N'lego')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'B2', N'laprap')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'B3', N'suachua')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'B4', N'mohinh')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'B5', N'sieunhan')
GO
ALTER TABLE [dbo].[DoChoi]  WITH CHECK ADD  CONSTRAINT [FK_DoChoi_TheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[DoChoi] CHECK CONSTRAINT [FK_DoChoi_TheLoai]
GO
ALTER TABLE [dbo].[GianHang]  WITH CHECK ADD  CONSTRAINT [FK_GianHang_DoChoi] FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[GianHang] CHECK CONSTRAINT [FK_GianHang_DoChoi]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_DoChoi] FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_DoChoi]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien]
GO
ALTER TABLE [dbo].[Kho]  WITH CHECK ADD  CONSTRAINT [FK_Kho_DoChoi] FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[Kho] CHECK CONSTRAINT [FK_Kho_DoChoi]
GO
ALTER TABLE [dbo].[Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Nhap_DoChoi] FOREIGN KEY([MaDoChoi])
REFERENCES [dbo].[DoChoi] ([MaDoChoi])
GO
ALTER TABLE [dbo].[Nhap] CHECK CONSTRAINT [FK_Nhap_DoChoi]
GO
ALTER TABLE [dbo].[Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Nhap_NhaCungCap] FOREIGN KEY([MaNCC])
REFERENCES [dbo].[NhaCungCap] ([MaNCC])
GO
ALTER TABLE [dbo].[Nhap] CHECK CONSTRAINT [FK_Nhap_NhaCungCap]
GO
ALTER TABLE [dbo].[Nhap]  WITH CHECK ADD  CONSTRAINT [FK_Nhap_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Nhap] CHECK CONSTRAINT [FK_Nhap_NhanVien]
GO
ALTER TABLE [dbo].[QuanLiNhanVien]  WITH CHECK ADD  CONSTRAINT [FK_QuanLiNhanVien_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QuanLiNhanVien] CHECK CONSTRAINT [FK_QuanLiNhanVien_NhanVien]
GO
