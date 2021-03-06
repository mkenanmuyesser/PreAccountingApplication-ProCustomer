USE [master]
GO
/****** Object:  Database [ProCustomerDB]    Script Date: 13.07.2022 12:58:54 ******/
CREATE DATABASE [ProCustomerDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProPetDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ProPetDB.mdf' , SIZE = 4352KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ProPetDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\ProPetDB_log.LDF' , SIZE = 6400KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProCustomerDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProCustomerDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProCustomerDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProCustomerDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProCustomerDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProCustomerDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProCustomerDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProCustomerDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProCustomerDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProCustomerDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProCustomerDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProCustomerDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProCustomerDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProCustomerDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProCustomerDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProCustomerDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProCustomerDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProCustomerDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProCustomerDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProCustomerDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProCustomerDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProCustomerDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProCustomerDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProCustomerDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProCustomerDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProCustomerDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProCustomerDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProCustomerDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProCustomerDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProCustomerDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ProCustomerDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProCustomerDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProCustomerDB', N'ON'
GO
ALTER DATABASE [ProCustomerDB] SET QUERY_STORE = OFF
GO
USE [ProCustomerDB]
GO
/****** Object:  Table [dbo].[Asilar]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asilar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MuayeneKartID] [int] NULL,
	[AsiAdi] [nvarchar](1000) NULL,
	[AsiTarihi] [datetime] NOT NULL,
 CONSTRAINT [PK_Asilar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bolge]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bolge](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SorumluID] [int] NULL,
	[Tanim] [nvarchar](1000) NULL,
	[FiyatKademe] [int] NOT NULL,
 CONSTRAINT [PK_Bolge] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cagri]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cagri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NULL,
	[Tarih] [datetime] NOT NULL,
	[TelefonNo] [nvarchar](1000) NULL,
	[Ad_Unvan] [nvarchar](1000) NULL,
	[Aciklama] [nvarchar](max) NULL,
 CONSTRAINT [PK_Cagrilar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hatirlatmalar]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hatirlatmalar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Baslangic] [datetime] NOT NULL,
	[Bitis] [datetime] NOT NULL,
	[Subject] [nvarchar](1000) NULL,
	[MusteriID] [int] NULL,
	[allday] [bit] NULL,
	[description] [nvarchar](1000) NULL,
	[hasreminder] [bit] NULL,
	[occurence] [bit] NULL,
	[location] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Hatirlatmalar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HayvanTanim]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HayvanTanim](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NULL,
	[Adi] [nvarchar](1000) NOT NULL,
	[Turu] [nvarchar](1000) NOT NULL,
	[Cinsi] [bit] NOT NULL,
	[Aylik] [int] NOT NULL,
	[Ciftlesme] [bit] NOT NULL,
 CONSTRAINT [PK_HayvanTanim] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HayvanTur]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HayvanTur](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TurAdi] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_HayvanTur] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kasa]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kasa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KasaAdi] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Kasa] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KasaIslem]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KasaIslem](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriID] [int] NULL,
	[Tarih] [datetime] NOT NULL,
	[EvrakNo] [nvarchar](1000) NULL,
	[IslemYeriID] [int] NULL,
	[OdemeSekliID] [int] NULL,
	[Ad_Unvan] [nvarchar](1000) NULL,
	[PersonelID] [int] NULL,
	[Tutar] [money] NOT NULL,
	[Aciklama] [nvarchar](1000) NULL,
	[GirisCikis] [bit] NOT NULL,
 CONSTRAINT [PK_KasaIslem] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanici]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanici](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAdi] [nvarchar](1000) NOT NULL,
	[Sifre] [nvarchar](1000) NOT NULL,
 CONSTRAINT [PK_Kullanıcılar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KullMal]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KullMal](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MuayeneKartID] [int] NOT NULL,
	[UrunAdi] [int] NULL,
	[UrunAdeti] [int] NULL,
 CONSTRAINT [PK_KullMal] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meslekler]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meslekler](
	[MeslekId] [int] IDENTITY(1,1) NOT NULL,
	[Meslek] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Meslekler] PRIMARY KEY CLUSTERED 
(
	[MeslekId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MuayeneKart]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MuayeneKart](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DoktorID] [int] NOT NULL,
	[MusteriID] [int] NOT NULL,
	[HayvanID] [int] NOT NULL,
	[MuayeneNedeni] [nvarchar](1000) NULL,
	[Teşhis] [nvarchar](1000) NULL,
	[UygTedavi] [nvarchar](1000) NULL,
	[MuayeneSonucu] [nvarchar](1000) NULL,
	[MuayeneTutar] [money] NOT NULL,
	[Sonuc1] [image] NULL,
	[Sonuc2] [image] NULL,
	[Sonuc3] [image] NULL,
	[Sonuc4] [image] NULL,
	[Sonuc5] [image] NULL,
	[Sonuc6] [image] NULL,
	[Tarih] [datetime] NULL,
 CONSTRAINT [PK_MuayeneKart] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MusteriGrupID] [int] NULL,
	[BolgeID] [int] NULL,
	[Meslek] [nvarchar](1000) NULL,
	[Ad_Unvan] [nvarchar](1000) NULL,
	[Telefon1] [nvarchar](1000) NULL,
	[Telefon2] [nvarchar](1000) NULL,
	[Telefon3] [nvarchar](1000) NULL,
	[Telefon4] [nvarchar](1000) NULL,
	[Telefon5] [nvarchar](1000) NULL,
	[Telefon6] [nvarchar](1000) NULL,
	[Adres] [nvarchar](max) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[Eposta] [nvarchar](1000) NULL,
	[Resim] [image] NULL,
	[ZimmetMiktar] [money] NOT NULL,
	[FaturaUnvan] [nvarchar](1000) NULL,
	[FaturaAdres] [nvarchar](1000) NULL,
	[VergiDairesi] [nvarchar](1000) NULL,
	[VergiNo] [nvarchar](1000) NULL,
	[KayitTarihi] [date] NOT NULL,
	[Sirket] [bit] NOT NULL,
	[Cinsiyet] [bit] NOT NULL,
	[DogumGunuHatırlat] [bit] NOT NULL,
	[DogumGunuTarih] [date] NOT NULL,
	[OzelGunHatırlat] [bit] NOT NULL,
	[OzelGunTarih] [date] NOT NULL,
	[Hatırlat] [bit] NOT NULL,
	[Tarih] [date] NOT NULL,
	[Barkod] [nvarchar](1000) NULL,
	[ParaPuan] [int] NULL,
	[Gold] [bit] NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MusteriGrup]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MusteriGrup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AltGrupID] [int] NULL,
	[GrupTanim] [nvarchar](1000) NULL,
 CONSTRAINT [PK_MusteriGrup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OdemeTip]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OdemeTip](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[OdemeTipi] [nvarchar](1000) NULL,
 CONSTRAINT [PK_OdemeTipi] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ParaPuan]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ParaPuan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AlisverisTutari] [money] NOT NULL,
	[KarsiligiParaPuan] [int] NOT NULL,
 CONSTRAINT [PK_ParaPuan] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personel]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personel](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [nvarchar](1000) NULL,
	[Telefon] [nvarchar](1000) NULL,
	[Eposta] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Personel] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProgramAyar]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProgramAyar](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SmsKullaniciAdi] [nvarchar](1000) NULL,
	[SmsSifre] [nvarchar](1000) NULL,
	[SmtpHost] [nvarchar](1000) NULL,
	[SmtpPort] [int] NOT NULL,
	[SmtpKullaniciAdi] [nvarchar](1000) NULL,
	[SmtpSifre] [nvarchar](1000) NULL,
	[SmtpGonderenAd] [nvarchar](1000) NULL,
	[SmtpGonderenEmail] [nvarchar](1000) NULL,
 CONSTRAINT [PK_ProgramAyar] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DurumID] [int] NULL,
	[MusteriID] [int] NULL,
	[UrunID] [int] NULL,
	[Ad_Unvan] [nvarchar](1000) NULL,
	[SiparisTarih] [datetime] NOT NULL,
	[Telefon] [nvarchar](1000) NULL,
	[Aciklama] [nvarchar](1000) NULL,
	[TeslimAdres] [nvarchar](1000) NULL,
	[PersonelID] [int] NULL,
	[TeslimTarih] [datetime] NOT NULL,
	[TeslimEdildi] [bit] NOT NULL,
	[TahsilEdildi] [bit] NOT NULL,
	[TaksitliSatis] [bit] NOT NULL,
	[SiparisTutar] [money] NOT NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisDetay]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisDetay](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SiparisID] [int] NULL,
	[UrunID] [int] NULL,
	[Adet] [int] NOT NULL,
	[Fiyat] [money] NOT NULL,
	[KdvOran] [tinyint] NOT NULL,
	[KdvTutar] [money] NOT NULL,
	[Toplam] [money] NOT NULL,
	[Aciklama] [nvarchar](1000) NULL,
 CONSTRAINT [PK_SiparisDetay] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SiparisDurum]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SiparisDurum](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Durum] [nvarchar](1000) NULL,
 CONSTRAINT [PK_SiparisDurum] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sirket]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sirket](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Unvan] [nvarchar](1000) NULL,
	[Adres] [nvarchar](max) NULL,
	[Tel1] [nvarchar](1000) NULL,
	[Tel2] [nvarchar](1000) NULL,
	[Fax] [nvarchar](1000) NULL,
	[Aciklama] [nvarchar](max) NULL,
	[VergiDairesi] [nvarchar](1000) NULL,
	[VDNo] [nvarchar](1000) NULL,
	[SicilNo] [nvarchar](1000) NULL,
	[Eposta] [nvarchar](1000) NULL,
	[WebSayfa] [nvarchar](1000) NULL,
	[Logo] [image] NULL,
	[BankaAdi] [nvarchar](1000) NULL,
	[BankaSube] [nvarchar](1000) NULL,
	[SubeKodu] [nvarchar](1000) NULL,
	[HesapNo] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Sirketler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TeslimatDetay]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TeslimatDetay](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TeslimatciID] [int] NULL,
	[OdemeTipiID] [int] NULL,
	[TeslimTarihi] [datetime] NOT NULL,
	[TeslimDurum] [bit] NOT NULL,
	[TahsilDurum] [bit] NOT NULL,
	[TahsilatTutar] [money] NOT NULL,
 CONSTRAINT [PK_TeslimatDetay] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Urun]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Urun](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UrunAdi] [nvarchar](1000) NULL,
	[GrupID] [int] NULL,
	[Fiyat1] [money] NOT NULL,
	[Fiyat2] [money] NOT NULL,
	[Fiyat3] [money] NOT NULL,
	[Fiyat4] [money] NOT NULL,
	[Fiyat5] [money] NOT NULL,
	[Fiyat6] [money] NOT NULL,
	[KdvOran] [tinyint] NOT NULL,
	[KdvDahil] [bit] NOT NULL,
	[Aciklama] [nvarchar](max) NULL,
	[Barkod] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Urunler] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunGrup]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunGrup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[AltGrupID] [int] NULL,
	[GrupTanim] [nvarchar](1000) NULL,
 CONSTRAINT [PK_UrunGrup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UrunStok]    Script Date: 13.07.2022 12:58:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UrunStok](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[KasaID] [int] NULL,
	[UrunID] [int] NULL,
	[Miktar] [int] NOT NULL,
	[Giris] [bit] NOT NULL,
 CONSTRAINT [PK_UrunStok] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Musteri] ADD  CONSTRAINT [DF_Musteriler_Kayıt Tarihi_1]  DEFAULT (getdate()) FOR [KayitTarihi]
GO
ALTER TABLE [dbo].[Musteri] ADD  CONSTRAINT [DF_Musteri_ParaPuan]  DEFAULT ((0)) FOR [ParaPuan]
GO
ALTER TABLE [dbo].[Bolge]  WITH CHECK ADD  CONSTRAINT [FK_Bolge_Personel] FOREIGN KEY([SorumluID])
REFERENCES [dbo].[Personel] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Bolge] CHECK CONSTRAINT [FK_Bolge_Personel]
GO
ALTER TABLE [dbo].[Cagri]  WITH CHECK ADD  CONSTRAINT [FK_Cagri_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Cagri] CHECK CONSTRAINT [FK_Cagri_Musteri]
GO
ALTER TABLE [dbo].[HayvanTanim]  WITH CHECK ADD  CONSTRAINT [FK_HayvanTanim_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([ID])
GO
ALTER TABLE [dbo].[HayvanTanim] CHECK CONSTRAINT [FK_HayvanTanim_Musteri]
GO
ALTER TABLE [dbo].[KasaIslem]  WITH CHECK ADD  CONSTRAINT [FK_KasaIslem_Kasa] FOREIGN KEY([IslemYeriID])
REFERENCES [dbo].[Kasa] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KasaIslem] CHECK CONSTRAINT [FK_KasaIslem_Kasa]
GO
ALTER TABLE [dbo].[KasaIslem]  WITH CHECK ADD  CONSTRAINT [FK_KasaIslem_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KasaIslem] CHECK CONSTRAINT [FK_KasaIslem_Musteri]
GO
ALTER TABLE [dbo].[KasaIslem]  WITH CHECK ADD  CONSTRAINT [FK_KasaIslem_OdemeTip] FOREIGN KEY([OdemeSekliID])
REFERENCES [dbo].[OdemeTip] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KasaIslem] CHECK CONSTRAINT [FK_KasaIslem_OdemeTip]
GO
ALTER TABLE [dbo].[KasaIslem]  WITH CHECK ADD  CONSTRAINT [FK_KasaIslem_Personel] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KasaIslem] CHECK CONSTRAINT [FK_KasaIslem_Personel]
GO
ALTER TABLE [dbo].[KullMal]  WITH CHECK ADD  CONSTRAINT [FK_KullMal_MuayeneKart] FOREIGN KEY([MuayeneKartID])
REFERENCES [dbo].[MuayeneKart] ([ID])
GO
ALTER TABLE [dbo].[KullMal] CHECK CONSTRAINT [FK_KullMal_MuayeneKart]
GO
ALTER TABLE [dbo].[KullMal]  WITH CHECK ADD  CONSTRAINT [FK_KullMal_Urun] FOREIGN KEY([UrunAdi])
REFERENCES [dbo].[Urun] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[KullMal] CHECK CONSTRAINT [FK_KullMal_Urun]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Musteri_Bolge] FOREIGN KEY([BolgeID])
REFERENCES [dbo].[Bolge] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Musteri_Bolge]
GO
ALTER TABLE [dbo].[Musteri]  WITH CHECK ADD  CONSTRAINT [FK_Musteri_MusteriGrup] FOREIGN KEY([MusteriGrupID])
REFERENCES [dbo].[MusteriGrup] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Musteri] CHECK CONSTRAINT [FK_Musteri_MusteriGrup]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Musteri] FOREIGN KEY([MusteriID])
REFERENCES [dbo].[Musteri] ([ID])
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Musteri]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Personel] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Personel] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Personel]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_SiparisDurum] FOREIGN KEY([DurumID])
REFERENCES [dbo].[SiparisDurum] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_SiparisDurum]
GO
ALTER TABLE [dbo].[SiparisDetay]  WITH CHECK ADD  CONSTRAINT [FK_SiparisDetay_Siparis] FOREIGN KEY([SiparisID])
REFERENCES [dbo].[Siparis] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SiparisDetay] CHECK CONSTRAINT [FK_SiparisDetay_Siparis]
GO
ALTER TABLE [dbo].[SiparisDetay]  WITH CHECK ADD  CONSTRAINT [FK_SiparisDetay_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[SiparisDetay] CHECK CONSTRAINT [FK_SiparisDetay_Urun]
GO
ALTER TABLE [dbo].[TeslimatDetay]  WITH CHECK ADD  CONSTRAINT [FK_TeslimatDetay_OdemeTip] FOREIGN KEY([OdemeTipiID])
REFERENCES [dbo].[OdemeTip] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[TeslimatDetay] CHECK CONSTRAINT [FK_TeslimatDetay_OdemeTip]
GO
ALTER TABLE [dbo].[TeslimatDetay]  WITH CHECK ADD  CONSTRAINT [FK_TeslimatDetay_Personel] FOREIGN KEY([TeslimatciID])
REFERENCES [dbo].[Personel] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[TeslimatDetay] CHECK CONSTRAINT [FK_TeslimatDetay_Personel]
GO
ALTER TABLE [dbo].[Urun]  WITH CHECK ADD  CONSTRAINT [FK_Urun_UrunGrup] FOREIGN KEY([GrupID])
REFERENCES [dbo].[UrunGrup] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Urun] CHECK CONSTRAINT [FK_Urun_UrunGrup]
GO
ALTER TABLE [dbo].[UrunStok]  WITH CHECK ADD  CONSTRAINT [FK_UrunStok_Kasa] FOREIGN KEY([KasaID])
REFERENCES [dbo].[Kasa] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[UrunStok] CHECK CONSTRAINT [FK_UrunStok_Kasa]
GO
ALTER TABLE [dbo].[UrunStok]  WITH CHECK ADD  CONSTRAINT [FK_UrunStok_Urun] FOREIGN KEY([UrunID])
REFERENCES [dbo].[Urun] ([ID])
ON UPDATE SET NULL
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[UrunStok] CHECK CONSTRAINT [FK_UrunStok_Urun]
GO
USE [master]
GO
ALTER DATABASE [ProCustomerDB] SET  READ_WRITE 
GO
