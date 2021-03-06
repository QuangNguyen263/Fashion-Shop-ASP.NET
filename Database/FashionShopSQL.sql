USE [master]
GO
/****** Object:  Database [ProjectFinal]    Script Date: 7/30/2015 5:24:34 PM ******/
CREATE DATABASE [ProjectFinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProjectFinal', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProjectFinal.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProjectFinal_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\ProjectFinal_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ProjectFinal] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectFinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectFinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectFinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectFinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectFinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectFinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectFinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectFinal] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectFinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectFinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectFinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectFinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectFinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectFinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectFinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectFinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectFinal] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectFinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectFinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectFinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectFinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectFinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectFinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectFinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectFinal] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectFinal] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectFinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectFinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectFinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectFinal] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectFinal', N'ON'
GO
USE [ProjectFinal]
GO
/****** Object:  Table [dbo].[cart]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cart](
	[id_cart] [int] IDENTITY(1,1) NOT NULL,
	[id_cus] [int] NULL,
	[time_cart] [date] NULL,
 CONSTRAINT [PK_cart] PRIMARY KEY CLUSTERED 
(
	[id_cart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cat]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cat](
	[id_cat] [int] IDENTITY(1,1) NOT NULL,
	[cat_name] [nvarchar](50) NULL,
 CONSTRAINT [PK_cat] PRIMARY KEY CLUSTERED 
(
	[id_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[cust]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cust](
	[id_cus] [int] IDENTITY(1,1) NOT NULL,
	[cus_name] [nvarchar](50) NULL,
	[email] [nvarchar](100) NULL,
 CONSTRAINT [PK_cust] PRIMARY KEY CLUSTERED 
(
	[id_cus] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[detail_cart]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_cart](
	[id_dtcart] [int] IDENTITY(1,1) NOT NULL,
	[id_cart] [int] NOT NULL,
	[id_pro] [int] NOT NULL,
	[quanlity] [int] NOT NULL,
	[TTprice] [float] NULL,
 CONSTRAINT [PK_detail_cart] PRIMARY KEY CLUSTERED 
(
	[id_dtcart] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[img_prod]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[img_prod](
	[id_img] [int] IDENTITY(1,1) NOT NULL,
	[id_prod] [int] NULL,
	[img_url] [nvarchar](100) NULL,
	[stt_img] [int] NULL,
 CONSTRAINT [PK_img_prod] PRIMARY KEY CLUSTERED 
(
	[id_img] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[prod]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prod](
	[id_cat] [int] NOT NULL,
	[id_pro] [int] IDENTITY(1,1) NOT NULL,
	[pro_name] [nvarchar](50) NULL,
	[pro_price] [float] NULL,
 CONSTRAINT [PK_prod] PRIMARY KEY CLUSTERED 
(
	[id_pro] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[role]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[id_usrole] [int] IDENTITY(1,1) NOT NULL,
	[user_role] [nvarchar](10) NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id_usrole] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[user_name]    Script Date: 7/30/2015 5:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_name](
	[id_usrole] [int] NOT NULL,
	[id_user] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](100) NULL,
	[usFulname] [nvarchar](50) NULL,
	[user_name] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[usAge] [int] NULL,
	[usImg] [nvarchar](100) NULL,
 CONSTRAINT [PK_user_name] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[cart] ON 

INSERT [dbo].[cart] ([id_cart], [id_cus], [time_cart]) VALUES (1021, 1015, CAST(0xEC390B00 AS Date))
INSERT [dbo].[cart] ([id_cart], [id_cus], [time_cart]) VALUES (2021, 1015, CAST(0xF0390B00 AS Date))
INSERT [dbo].[cart] ([id_cart], [id_cus], [time_cart]) VALUES (2022, 2015, CAST(0xF0390B00 AS Date))
INSERT [dbo].[cart] ([id_cart], [id_cus], [time_cart]) VALUES (2023, 2016, CAST(0xF0390B00 AS Date))
INSERT [dbo].[cart] ([id_cart], [id_cus], [time_cart]) VALUES (2024, 2016, CAST(0xF0390B00 AS Date))
SET IDENTITY_INSERT [dbo].[cart] OFF
SET IDENTITY_INSERT [dbo].[cat] ON 

INSERT [dbo].[cat] ([id_cat], [cat_name]) VALUES (1, N'Clothes')
INSERT [dbo].[cat] ([id_cat], [cat_name]) VALUES (2, N'Bags')
INSERT [dbo].[cat] ([id_cat], [cat_name]) VALUES (2017, N'Shoes')
SET IDENTITY_INSERT [dbo].[cat] OFF
SET IDENTITY_INSERT [dbo].[cust] ON 

INSERT [dbo].[cust] ([id_cus], [cus_name], [email]) VALUES (1015, N'Quang Nguyen', N'nguyenvanquang263@gmail.com')
INSERT [dbo].[cust] ([id_cus], [cus_name], [email]) VALUES (2015, N'ádas', N'asd@gs.com')
INSERT [dbo].[cust] ([id_cus], [cus_name], [email]) VALUES (2016, N'Quang Ng', N'quangnguyen@gmail.com')
SET IDENTITY_INSERT [dbo].[cust] OFF
SET IDENTITY_INSERT [dbo].[detail_cart] ON 

INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (2023, 1021, 5014, 2, 400)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (2024, 1021, 5015, 1, 149)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (2025, 1021, 5018, 2, 1000)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (3023, 2021, 5013, 1, 75)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (3024, 2022, 5013, 2, 150)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (3025, 2023, 5013, 1, 75)
INSERT [dbo].[detail_cart] ([id_dtcart], [id_cart], [id_pro], [quanlity], [TTprice]) VALUES (3026, 2024, 5013, 1, 75)
SET IDENTITY_INSERT [dbo].[detail_cart] OFF
SET IDENTITY_INSERT [dbo].[img_prod] ON 

INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2030, 5013, N'gallery4.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2031, 5013, N'girl1.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2032, 5013, N'girl2.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2033, 5013, N'girl3.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2034, 5014, N'image1xxl (1).jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2035, 5014, N'image1xxl.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2036, 5015, N'Cheap-Nike-Mens-Air-Max-2015-Black-Volt-Green.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2037, 5015, N'nike-air-max-93-red-suede.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2038, 5015, N'nike-air-max-2015-blue-lagoon-bright-crimson-4.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2039, 5016, N'Nike-Air-Max-1-FB-Cristiano-Ronaldo-CR7-2.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2040, 5016, N'nike-air-max-2015-black-white-3.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2041, 5016, N'nike-air-max-nm-2015-releases-2.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2042, 5017, N'nike-air-max-1-olympic-2015-2.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2043, 5017, N'nike-air-max-zero-coming-3-26-01.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2044, 5018, N'1243535350_jcrew-ludlow-suit_1.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2045, 5018, N'image1xl.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2046, 5018, N'Suit17-0.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2047, 5019, N'964803324_01.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2048, 5019, N'best.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2049, 5019, N'image1xl.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2050, 5019, N'Neal-Caffrey-Black-Suit.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2051, 5020, N'image1xl (1).jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2052, 5020, N'levis-blue-slim-fit-denim-jacket-product-1-15790547-696022059_large_flex.jpeg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2053, 5020, N'prps-goods-co-800x1000.jpeg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2054, 5020, N'RJK32AN_1_lg.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2055, 5021, N'74145PW_1_lg.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2056, 5021, N'633790-0029_1.jpeg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2057, 5021, N'7446207.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2058, 5021, N'1273178063_gap-denim-jacket_1.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2059, 5021, N'Cheap-denim-jacket-unlined.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2060, 5022, N'adidas (1).jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2061, 5022, N'adidas.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2062, 5023, N'41TDPt5rBdL.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2063, 5023, N'adidas-adiPure3.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2064, 5025, N'Adidas-JS-Rainbow-Wings-1.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2065, 5025, N'Jeremy-Scott-Wings-10.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2066, 5025, N'jeremy-scott-adidas-shoes-paris.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2067, 5025, N'Jeremy-Scott-Wings-10.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2068, 5027, N'adidas JS Apes shoes.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2069, 5027, N'Adidas-Originals-JS-Leopard-Tail-High-Tops-Shoes.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2070, 5027, N'JEREMY-SCOTT-ANIMAL-14_6.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2071, 5027, N'KidsAdidasJeremyScottTeddyBearBlackWhite.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2075, 5030, N'dgfsdf.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2076, 5030, N'ádasds.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2077, 5030, N'sadass.jpeg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2078, 5031, N'Adidas-Originals-T-Shirt-059316-1.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2079, 5031, N'adidas-pixel-t-shirt-schwarz-1740.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2080, 5031, N'adidas-trefoil-sneaker-graphic-t-shirt-img-1054417006.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2081, 5031, N'adidas-t-shirt-11.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2082, 5031, N'img-thing.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2083, 5031, N'men-s-nike-maxing-out-t-shirt-435012-100-x7-6.95-5268-p.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2084, 5031, N'Nike-OG-Air-Logo-Mens-T-Shirt.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2085, 5032, N'sadasdasd.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2086, 5032, N'sdfsdf.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2087, 5033, N'00000016.JPG', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2088, 5033, N'Kappa-Black-Round-Neck-T-Shirt-2111-551158-1-catalog.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2089, 5033, N'product2.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2090, 5034, N'ádasds.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2091, 5034, N'Kappa-Black-Round-Neck-T-Shirt-2111-551158-1-catalog.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2092, 5034, N'tải xuống.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2093, 5035, N'chosen_t_shirt-p235048042505818427bfb0j_325.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2094, 5035, N'DB_10YrEgg_T-1.png', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2095, 5035, N'may_10_birthday_arabic_tshirt.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2096, 5035, N'Shirt_Support-Admire-Honor.png', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2097, 5035, N'tumblr_n58lseILTk1qctvzro1_1280.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2098, 5036, N'jm295-gr_zoom-jute-bag-medium-green.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2099, 5036, N'nw_bag_12.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2100, 5036, N'standard-cotton-bag-short-handles-coloured.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2101, 5037, N'6.jpeg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2102, 5037, N'218491_A2O0G_2527_001_web_doublehero.png', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2103, 5038, N'10_3001-22.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2104, 5038, N'bag.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2105, 5038, N'Lands-End-Cinch-Sack-224x300.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2106, 5040, N'dsfsdf (2).png', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2107, 5040, N'dsfsdf.png', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2108, 5040, N'sacpondichery48h-chocolat_graine-Arriere.jpeg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2109, 5041, N'img-thing.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2110, 5041, N'Striped-Handbag-Spring.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2111, 5042, N'Cult bag brand Valextra coming to Singapore DECOR.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2112, 5042, N'Kelly_Bag.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2113, 5042, N'reusable-shopping-bag-recycle.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2114, 5042, N'Tods-D-Bag-Shopping.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2115, 5043, N'sacpondichery48h-chocolat_graine-Arriere.jpeg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2116, 5043, N'travel-bag-large-leather-weekend-bag-20-side_1.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2117, 5044, N'7d7d6ec317f46eb12b5bbf11d1be1656.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2118, 5044, N'47152980.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2119, 5044, N'denim-hobo.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2120, 5045, N'denim-bag.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2121, 5045, N'recycled-denim-bag-blue-mini-messenger-bag.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2122, 5045, N'satchel-bags-for-women-recycled-denim-bag.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2123, 5045, N'trussardi-1911-patchwork-denim-bag.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2131, 5018, N'964803324_01.jpg', NULL)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2132, 5018, N'best.jpg', NULL)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (2133, 5018, N'best.jpg', NULL)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (4137, 6046, N'1888-bandc-safran-mens-polo-shirt-zoom.jpg', 1)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (4138, 6046, N'Ralph Lauren Classic-Fit Mesh Polo Ultra Pink.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (4139, 6046, N'tumblr_n58lseILTk1qctvzro1_1280.jpg', 0)
INSERT [dbo].[img_prod] ([id_img], [id_prod], [img_url], [stt_img]) VALUES (4140, 6046, N'worlds-classy-polo-shirt-nautica.jpg', 0)
SET IDENTITY_INSERT [dbo].[img_prod] OFF
GO
SET IDENTITY_INSERT [dbo].[prod] ON 

INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5013, N'D&G Bag', 75)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5014, N'Kappa', 200)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5015, N'Nike Air Max 90', 149)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5016, N'Nike Black Edition', 100)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5017, N'Nike Lunar', 80)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5018, N'Kingsman Suit', 500)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5019, N'Dolce & Gabanna Suit', 600)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5020, N'Cowboy Denim', 300)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5021, N'Lacoste Denim', 350)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5022, N'Adidas Mars', 35)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5023, N'Adidas Beat', 200)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5025, N'Adidas Ultra Color', 50)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5027, N'Adidas Animal', 50)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5029, N'Dolce & Gabanna Shirt', 75)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5030, N'Adidas Basic Shirt', 75)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5031, N'Adidas Fun', 99)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2017, 5032, N'Adidas Ultra Light', 500)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5033, N'Basic Shirt', 35)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5034, N'Super Short T-Shirt', 60)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 5035, N'May 10', 100)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5036, N'Basic Plastic ', 20)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5037, N'Snake Bag', 55)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5038, N'Teenager Bag', 99)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5040, N'Hugo Boss Bag', 150)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5041, N'Dark Bag', 99)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5042, N'Test Bag', 70)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5043, N'Man Bag', 85)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5044, N'Buttefly Bag', 99)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (2, 5045, N'Lacoste Bag', 105)
INSERT [dbo].[prod] ([id_cat], [id_pro], [pro_name], [pro_price]) VALUES (1, 6046, N'Nike T-Shirt', 99)
SET IDENTITY_INSERT [dbo].[prod] OFF
SET IDENTITY_INSERT [dbo].[role] ON 

INSERT [dbo].[role] ([id_usrole], [user_role]) VALUES (1, N'admin')
SET IDENTITY_INSERT [dbo].[role] OFF
SET IDENTITY_INSERT [dbo].[user_name] ON 

INSERT [dbo].[user_name] ([id_usrole], [id_user], [email], [usFulname], [user_name], [password], [usAge], [usImg]) VALUES (1, 1, N'nguyenvanquang263@gmail.com', N'Quang Nguyen', N'admin', N'admin', 20, N'thesummer-chillstep-selection-17.jpg')
SET IDENTITY_INSERT [dbo].[user_name] OFF
ALTER TABLE [dbo].[cart]  WITH CHECK ADD  CONSTRAINT [FK_cart_cust] FOREIGN KEY([id_cus])
REFERENCES [dbo].[cust] ([id_cus])
GO
ALTER TABLE [dbo].[cart] CHECK CONSTRAINT [FK_cart_cust]
GO
ALTER TABLE [dbo].[detail_cart]  WITH CHECK ADD  CONSTRAINT [FK_detail_cart_cart] FOREIGN KEY([id_cart])
REFERENCES [dbo].[cart] ([id_cart])
GO
ALTER TABLE [dbo].[detail_cart] CHECK CONSTRAINT [FK_detail_cart_cart]
GO
ALTER TABLE [dbo].[detail_cart]  WITH CHECK ADD  CONSTRAINT [FK_detail_cart_prod] FOREIGN KEY([id_pro])
REFERENCES [dbo].[prod] ([id_pro])
GO
ALTER TABLE [dbo].[detail_cart] CHECK CONSTRAINT [FK_detail_cart_prod]
GO
ALTER TABLE [dbo].[img_prod]  WITH CHECK ADD  CONSTRAINT [FK_img_prod_prod] FOREIGN KEY([id_prod])
REFERENCES [dbo].[prod] ([id_pro])
GO
ALTER TABLE [dbo].[img_prod] CHECK CONSTRAINT [FK_img_prod_prod]
GO
ALTER TABLE [dbo].[prod]  WITH CHECK ADD  CONSTRAINT [FK_prod_cat] FOREIGN KEY([id_cat])
REFERENCES [dbo].[cat] ([id_cat])
GO
ALTER TABLE [dbo].[prod] CHECK CONSTRAINT [FK_prod_cat]
GO
ALTER TABLE [dbo].[user_name]  WITH CHECK ADD  CONSTRAINT [FK_user_name_role] FOREIGN KEY([id_usrole])
REFERENCES [dbo].[role] ([id_usrole])
GO
ALTER TABLE [dbo].[user_name] CHECK CONSTRAINT [FK_user_name_role]
GO
USE [master]
GO
ALTER DATABASE [ProjectFinal] SET  READ_WRITE 
GO
