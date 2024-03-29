/*Here */
USE [master]
GO

CREATE DATABASE [ApotekOnline]
GO

USE [ApotekOnline]
GO
/****** Object:  Table [dbo].[DaftarObat]    Script Date: 5/12/2020 10:02:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaftarObat](
	[ObatID] [int] IDENTITY(1,1) NOT NULL,
	[NamaObat] [varchar](50) NOT NULL,
	[Keterangan] [nvarchar](200) NOT NULL,
	[Harga] [float] NOT NULL,
	[Stok] [int] NULL,
 CONSTRAINT [PK_DaftarObat] PRIMARY KEY CLUSTERED 
(
	[ObatID] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DaftarResep]    Script Date: 5/12/2020 10:02:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DaftarResep](
	[ResepID] [int] IDENTITY(1,1) NOT NULL,
	[NamaPasien] [nvarchar](200) NOT NULL,
	[NamaObat] [nvarchar](50) NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Keterangan] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_DaftarResep] PRIMARY KEY CLUSTERED 
(
	[ResepID] ASC
)

) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hendra]    Script Date: 5/12/2020 10:02:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hendra](
	[PasienID] [int] IDENTITY(1,1) NOT NULL,
	[NamaPasien] [nvarchar](50) NOT NULL,
	[Keluhan] [nvarchar](200) NOT NULL,
	[Tanggal] [smalldatetime] NULL,
 CONSTRAINT [PK_Hendra] PRIMARY KEY CLUSTERED 
(
	[PasienID] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Isnan]    Script Date: 5/12/2020 10:02:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Isnan](
	[PasienID] [int] IDENTITY(1,1) NOT NULL,
	[NamaPasien] [nvarchar](50) NOT NULL,
	[Keluhan] [nvarchar](200) NOT NULL,
	[Tanggal] [smalldatetime] NULL,
 CONSTRAINT [PK_Isnan] PRIMARY KEY CLUSTERED 
(
	[PasienID] ASC
)
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Robert]    Script Date: 5/12/2020 10:02:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Robert](
	[PasienID] [int] IDENTITY(1,1) NOT NULL,
	[NamaPasien] [nvarchar](50) NOT NULL,
	[Keluhan] [nvarchar](200) NOT NULL,
	[Tanggal] [smalldatetime] NULL,
 CONSTRAINT [PK_Robert] PRIMARY KEY CLUSTERED 
(
	[PasienID] ASC
)
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DaftarObat] ON 

INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (1, N'Metoklopramid', N'Obat Pencernaan', 4000, 35)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (2, N'Bisakodil Suppo', N'Obat Pencernaan', 3200, 28)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (4, N'Triamcinolone Acetonide', N'Obta Mulut dan Tenggorokan', 6000, 21)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (5, N'Salbutamol', N'Obat Asma', 7300, 23)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (6, N'Terbutalin', N'Obat Asma', 2400, 18)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (7, N'Ketotifen', N'Obat Asma', 3600, 10)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (8, N'Nistatin', N'Obat Kulit', 4500, 27)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (9, N'Desoksimetason', N'Obat Kulit', 3900, 25)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (10, N'Betametason', N'Obat Kulit', 4200, 25)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (11, N'Triamsinolon', N'Obat Kulit', 3200, 35)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (12, N'Hidrokortison', N'Obat Kulit', 4700, 13)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (13, N'Gentamisin', N'Obat Kulit', 3100, 12)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (14, N'Eritromisin', N'Obat Kulit', 6700, 20)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (15, N'Clindamisin', N'Obat Jerawat', 4200, 20)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (16, N'Orsiprenalin', N'Obat Asma', 13450, 9)
INSERT [dbo].[DaftarObat] ([ObatID], [NamaObat], [Keterangan], [Harga], [Stok]) VALUES (17, N'Gentamisin', N'Obat Mata', 9800, 18)
SET IDENTITY_INSERT [dbo].[DaftarObat] OFF
GO
SET IDENTITY_INSERT [dbo].[DaftarResep] ON 

INSERT [dbo].[DaftarResep] ([ResepID], [NamaPasien], [NamaObat], [Jumlah], [Keterangan]) VALUES (1, N'Firas', N'Nistatin', 2, N'Diminum dua kali sehari')
INSERT [dbo].[DaftarResep] ([ResepID], [NamaPasien], [NamaObat], [Jumlah], [Keterangan]) VALUES (2, N'Ivan', N'Panadol', 6, N'Diminum 2x sehari, setelah makan')
SET IDENTITY_INSERT [dbo].[DaftarResep] OFF
GO
SET IDENTITY_INSERT [dbo].[Hendra] ON 

INSERT [dbo].[Hendra] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (1, N'Ahmad Albar', N'Sakit Telinga', CAST(N'2020-05-12T16:37:00' AS SmallDateTime))
INSERT [dbo].[Hendra] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (2, N'Bagas Kara Sutanto', N'Sesak napas, batuk - batuk, demam, pusing', CAST(N'2020-05-12T16:41:00' AS SmallDateTime))
INSERT [dbo].[Hendra] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (3, N'Muhammad Yusuf', N'Mual mual', CAST(N'2020-05-12T16:46:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Hendra] OFF
GO
SET IDENTITY_INSERT [dbo].[Isnan] ON 

INSERT [dbo].[Isnan] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (1, N'Kyle Musek', N'Banyak Jerawat', CAST(N'2020-05-12T16:41:00' AS SmallDateTime))
INSERT [dbo].[Isnan] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (2, N'Zidane Akbar', N'Demam dan pusing', CAST(N'2020-05-12T16:47:00' AS SmallDateTime))
INSERT [dbo].[Isnan] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (3, N'Ayu Saputri', N'Tenggorokan Sakit', CAST(N'2020-05-12T16:48:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Isnan] OFF
GO
SET IDENTITY_INSERT [dbo].[Robert] ON 

INSERT [dbo].[Robert] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (1, N'Rio Ferdiansyah', N'Perut sakit', CAST(N'2020-05-12T16:49:00' AS SmallDateTime))
INSERT [dbo].[Robert] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (2, N'Nathalie Lim', N'Sesak napas', CAST(N'2020-05-12T16:49:00' AS SmallDateTime))
INSERT [dbo].[Robert] ([PasienID], [NamaPasien], [Keluhan], [Tanggal]) VALUES (3, N'Galang Saputra', N'Maag dan Asma', CAST(N'2020-05-12T16:50:00' AS SmallDateTime))
SET IDENTITY_INSERT [dbo].[Robert] OFF
GO
