USE [master]
GO
/****** Object:  Database [BDhotelTransilvania]    Script Date: 25/11/2021 17:21:27 ******/
CREATE DATABASE [BDhotelTransilvania]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BDhotelTransilvania', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDhotelTransilvania.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BDhotelTransilvania_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BDhotelTransilvania_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BDhotelTransilvania] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BDhotelTransilvania].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BDhotelTransilvania] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET ARITHABORT OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BDhotelTransilvania] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BDhotelTransilvania] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BDhotelTransilvania] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BDhotelTransilvania] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BDhotelTransilvania] SET  MULTI_USER 
GO
ALTER DATABASE [BDhotelTransilvania] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BDhotelTransilvania] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BDhotelTransilvania] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BDhotelTransilvania] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BDhotelTransilvania] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BDhotelTransilvania] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BDhotelTransilvania] SET QUERY_STORE = OFF
GO
USE [BDhotelTransilvania]
GO
/****** Object:  Table [dbo].[TBcheckOut]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBcheckOut](
	[idCheckOut] [int] NOT NULL,
	[idHospedagem] [int] NOT NULL,
	[consumos] [float] NOT NULL,
	[valorTotal] [float] NOT NULL,
 CONSTRAINT [PK_TBcheckOut] PRIMARY KEY CLUSTERED 
(
	[idCheckOut] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBfuncionario]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBfuncionario](
	[cpfFuncionario] [varchar](11) NOT NULL,
	[nomeFuncionario] [varchar](50) NOT NULL,
	[cargo] [varchar](30) NOT NULL,
	[salario] [float] NOT NULL,
	[telefoneFuncionario] [varchar](15) NOT NULL,
	[emailFuncionario] [varchar](50) NOT NULL,
	[loginFuncionario] [varchar](30) NOT NULL,
	[senhaFuncionario] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TBfuncionario] PRIMARY KEY CLUSTERED 
(
	[cpfFuncionario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBhospedagem]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBhospedagem](
	[idHospedagem] [int] NOT NULL,
	[acompanhantes] [int] NULL,
	[checkIn] [date] NOT NULL,
	[checkOut] [date] NOT NULL,
	[numeroQuarto] [int] NOT NULL,
	[cpfHospede] [varchar](11) NOT NULL,
	[valorHospedagem] [float] NOT NULL,
 CONSTRAINT [PK_TBhospedagem] PRIMARY KEY CLUSTERED 
(
	[idHospedagem] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBhospede]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBhospede](
	[cpfHospede] [varchar](11) NOT NULL,
	[nomeHospede] [varchar](50) NOT NULL,
	[telefoneHospede] [varchar](15) NOT NULL,
	[RG] [varchar](9) NOT NULL,
	[emailHospede] [varchar](50) NOT NULL,
	[enderecoHospede] [varchar](50) NOT NULL,
	[VIP] [varchar](1) NOT NULL,
	[senhaHospede] [varchar](10) NOT NULL,
 CONSTRAINT [PK_TBhospede] PRIMARY KEY CLUSTERED 
(
	[cpfHospede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBquarto]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBquarto](
	[numeroQuarto] [int] NOT NULL,
	[tipoQuarto] [varchar](30) NOT NULL,
	[valorQuarto] [float] NOT NULL,
	[disponivel] [varchar](1) NOT NULL,
	[detalhesQuarto] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBquarto] PRIMARY KEY CLUSTERED 
(
	[numeroQuarto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBservico]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBservico](
	[nomeServico] [varchar](50) NOT NULL,
	[tipoServico] [varchar](30) NOT NULL,
	[valorServico] [float] NOT NULL,
	[detalhesServico] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TBservico] PRIMARY KEY CLUSTERED 
(
	[nomeServico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TBvenda]    Script Date: 25/11/2021 17:21:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TBvenda](
	[idVenda] [int] NOT NULL,
	[nomeServico] [varchar](50) NOT NULL,
	[idHospedagem] [int] NOT NULL,
	[quantidade] [int] NOT NULL,
	[valorVenda] [float] NOT NULL,
 CONSTRAINT [PK_TBvenda] PRIMARY KEY CLUSTERED 
(
	[idVenda] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[TBcheckOut]  WITH CHECK ADD  CONSTRAINT [FK_TBcheckOut_TBhospedagem] FOREIGN KEY([idHospedagem])
REFERENCES [dbo].[TBhospedagem] ([idHospedagem])
GO
ALTER TABLE [dbo].[TBcheckOut] CHECK CONSTRAINT [FK_TBcheckOut_TBhospedagem]
GO
ALTER TABLE [dbo].[TBhospedagem]  WITH CHECK ADD  CONSTRAINT [FK_TBhospedagem_TBhospede] FOREIGN KEY([cpfHospede])
REFERENCES [dbo].[TBhospede] ([cpfHospede])
GO
ALTER TABLE [dbo].[TBhospedagem] CHECK CONSTRAINT [FK_TBhospedagem_TBhospede]
GO
ALTER TABLE [dbo].[TBhospedagem]  WITH CHECK ADD  CONSTRAINT [FK_TBhospedagem_TBquarto] FOREIGN KEY([numeroQuarto])
REFERENCES [dbo].[TBquarto] ([numeroQuarto])
GO
ALTER TABLE [dbo].[TBhospedagem] CHECK CONSTRAINT [FK_TBhospedagem_TBquarto]
GO
ALTER TABLE [dbo].[TBvenda]  WITH CHECK ADD  CONSTRAINT [FK_TBvenda_TBhospedagem] FOREIGN KEY([idHospedagem])
REFERENCES [dbo].[TBhospedagem] ([idHospedagem])
GO
ALTER TABLE [dbo].[TBvenda] CHECK CONSTRAINT [FK_TBvenda_TBhospedagem]
GO
ALTER TABLE [dbo].[TBvenda]  WITH CHECK ADD  CONSTRAINT [FK_TBvenda_TBservico] FOREIGN KEY([nomeServico])
REFERENCES [dbo].[TBservico] ([nomeServico])
GO
ALTER TABLE [dbo].[TBvenda] CHECK CONSTRAINT [FK_TBvenda_TBservico]
GO
USE [master]
GO
ALTER DATABASE [BDhotelTransilvania] SET  READ_WRITE 
GO
