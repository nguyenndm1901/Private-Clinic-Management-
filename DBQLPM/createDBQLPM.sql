/****** Object:  Database [QLPM]    Script Date: 5/27/2019 11:11:25 PM ******/
 USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLPM')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLPM') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLPM]
END

CREATE DATABASE [QLPM]
GO
USE [QLPM]
GO
/****** Object:  Table [dbo].[DanhSachBenhNhan]    Script Date: 5/27/2019 11:11:25 PM ******/

CREATE TABLE [dbo].[DanhSachBenhNhan](
	[maBN] [char](10) NOT NULL,
	[hoten] [varchar](50) NOT NULL,
	[gioitinh] [char](5) NOT NULL,
	[namsinh] [char](4) NOT NULL,
	[diachi] [varchar](50) NOT NULL,
	[sdt] [char](10) NOT NULL,
	[ngaykham] [char](10) NOT NULL,
 CONSTRAINT [PK_DanhSachBenhNhan] PRIMARY KEY CLUSTERED 
(
	[maBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhSachKhamBenh]    Script Date: 5/27/2019 11:11:25 PM ******/
CREATE TABLE [dbo].[DanhSachKhamBenh](
	[maBN] [char](10) NOT NULL,
	[hoten] [varchar](50) NOT NULL,
	[gioitinh] [char](5) NOT NULL,
	[namsinh] [char](4) NOT NULL,
	[diachi] [varchar](50) NOT NULL,
	[sdt] [char](10) NOT NULL,
	[ngaykham] [char](10) NOT NULL,
 CONSTRAINT [PK_DanhSachKhamBenh] PRIMARY KEY CLUSTERED 
(
	[maBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

