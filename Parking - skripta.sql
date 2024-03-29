USE [Parking "Stari Most"]
GO
/****** Object:  Table [dbo].[Vozila_sa_poternicom]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP TABLE [dbo].[Vozila_sa_poternicom]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP TABLE [dbo].[Radnik]
GO
/****** Object:  Table [dbo].[Povlascena_vozila]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP TABLE [dbo].[Povlascena_vozila]
GO
/****** Object:  Table [dbo].[Parkirana_vozila]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP TABLE [dbo].[Parkirana_vozila]
GO
/****** Object:  Table [dbo].[Parking_Info]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP TABLE [dbo].[Parking_Info]
GO
USE [master]
GO
/****** Object:  Database [Parking "Stari Most"]    Script Date: 9/5/2019 1:33:55 PM ******/
DROP DATABASE [Parking "Stari Most"]
GO
/****** Object:  Database [Parking "Stari Most"]    Script Date: 9/5/2019 1:33:55 PM ******/
CREATE DATABASE [Parking "Stari Most"]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Parking _Stari Most_', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ILIJA\MSSQL\DATA\Parking _Stari Most_.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Parking _Stari Most__log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.ILIJA\MSSQL\DATA\Parking _Stari Most__log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Parking "Stari Most"].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Parking "Stari Most"] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parking "Stari Most"] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parking "Stari Most"] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parking "Stari Most"] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parking "Stari Most"] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET RECOVERY FULL 
GO
ALTER DATABASE [Parking "Stari Most"] SET  MULTI_USER 
GO
ALTER DATABASE [Parking "Stari Most"] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parking "Stari Most"] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Parking "Stari Most"] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Parking "Stari Most"] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Parking "Stari Most"] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Parking "Stari Most"] SET QUERY_STORE = OFF
GO
USE [Parking "Stari Most"]
GO
/****** Object:  Table [dbo].[Parking_Info]    Script Date: 9/5/2019 1:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parking_Info](
	[ID_Parkinga] [int] NOT NULL,
	[Naziv_Parkinga] [nvarchar](50) NOT NULL,
	[Kapacitet_Parkinga] [int] NOT NULL,
 CONSTRAINT [PK_Parking_Info] PRIMARY KEY CLUSTERED 
(
	[ID_Parkinga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parkirana_vozila]    Script Date: 9/5/2019 1:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parkirana_vozila](
	[Registracija] [nvarchar](15) NOT NULL,
	[Vreme_ulaska] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Parkirana_vozila] PRIMARY KEY CLUSTERED 
(
	[Registracija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Povlascena_vozila]    Script Date: 9/5/2019 1:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Povlascena_vozila](
	[Registracija] [nvarchar](15) NOT NULL,
	[Naziv_preduzeca] [nvarchar](50) NULL,
 CONSTRAINT [PK_Povlascena_vozila] PRIMARY KEY CLUSTERED 
(
	[Registracija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Radnik]    Script Date: 9/5/2019 1:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radnik](
	[ID Radnika] [int] NOT NULL,
	[Ime_Prezime] [nvarchar](80) NOT NULL,
	[Kontakt_telefon] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_Radnik] PRIMARY KEY CLUSTERED 
(
	[ID Radnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vozila_sa_poternicom]    Script Date: 9/5/2019 1:33:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vozila_sa_poternicom](
	[Registracija] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_Vozila_sa_poternicom] PRIMARY KEY CLUSTERED 
(
	[Registracija] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Parking_Info] ([ID_Parkinga], [Naziv_Parkinga], [Kapacitet_Parkinga]) VALUES (5523, N'Stari Most', 75)
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'88-F56Y3321', N'08:46:24')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'BE-027-AB', N'06:04:24')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'BG-300-FG', N'05:43:28')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'BG-334-PS', N'05:49:31')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'MH12DE1433', N'06:05:15')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'NG-833-HJ', N'06:06:41')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'UB-1022-GP', N'12:05:18')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'VA-773-HJ', N'05:45:34')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'VA-974-JG', N'04:28:28')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'W-8764-KI', N'05:48:27')
INSERT [dbo].[Parkirana_vozila] ([Registracija], [Vreme_ulaska]) VALUES (N'Y-54DH65-90', N'04:30:29')
INSERT [dbo].[Povlascena_vozila] ([Registracija], [Naziv_preduzeca]) VALUES (N'BG-520-FG', N'MUP')
INSERT [dbo].[Povlascena_vozila] ([Registracija], [Naziv_preduzeca]) VALUES (N'BG-996-LO', N'EPS')
INSERT [dbo].[Povlascena_vozila] ([Registracija], [Naziv_preduzeca]) VALUES (N'UB-1022-GP', N'JKP "Vodovod"')
INSERT [dbo].[Povlascena_vozila] ([Registracija], [Naziv_preduzeca]) VALUES (N'VA-655-JK', N'BIA')
INSERT [dbo].[Radnik] ([ID Radnika], [Ime_Prezime], [Kontakt_telefon]) VALUES (1452309, N'Radovan Sreckovic', CAST(2698945637 AS Numeric(18, 0)))
INSERT [dbo].[Radnik] ([ID Radnika], [Ime_Prezime], [Kontakt_telefon]) VALUES (5789225, N'Milutin Tomic', CAST(3247824553 AS Numeric(18, 0)))
INSERT [dbo].[Radnik] ([ID Radnika], [Ime_Prezime], [Kontakt_telefon]) VALUES (9963147, N'MIrko Stevanovic', CAST(9984521321 AS Numeric(18, 0)))
INSERT [dbo].[Vozila_sa_poternicom] ([Registracija]) VALUES (N'BG-610-NT')
INSERT [dbo].[Vozila_sa_poternicom] ([Registracija]) VALUES (N'VA-1023-VF')
INSERT [dbo].[Vozila_sa_poternicom] ([Registracija]) VALUES (N'W-5432-LK')
USE [master]
GO
ALTER DATABASE [Parking "Stari Most"] SET  READ_WRITE 
GO
