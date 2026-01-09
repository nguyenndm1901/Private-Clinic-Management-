USE [master]
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'DBPCM')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'DBPCM') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE DBPCM
END
GO

CREATE DATABASE DBPCM
GO
USE DBPCM
GO

CREATE TABLE DanhSachBenhNhan (
    BN_maBN varchar(20) NOT NULL PRIMARY KEY,
    BN_hoten nvarchar(50) NOT NULL,
    BN_gioitinh nvarchar(10) NOT NULL,
    BN_namsinh char(4) NOT NULL,
    BN_diachi nvarchar(100) NOT NULL,
    BN_sdt varchar(15) NOT NULL,
    BN_ngaykham varchar(10) NOT NULL,
    BN_loaibenh nvarchar(50) NULL,
    BN_trieuchung nvarchar(100) NULL
)

CREATE TABLE HoaDon (
    maHD varchar(30) PRIMARY KEY NOT NULL, -- Increased for timestamp+random
    ngaytao datetime NULL,
    tenBN nvarchar(50) NULL,
    tienthuoc decimal(18, 0) NULL,
    tongcong decimal(18, 0) NULL,
    donviTinh nchar(10) NULL
)

CREATE TABLE Thuoc (
    ID int IDENTITY(1,1) PRIMARY KEY NOT NULL,
    tenThuoc nvarchar(50) NOT NULL,
    donviTinh nchar(10) NOT NULL,
    giaThuoc decimal(18, 0) NOT NULL
)

CREATE TABLE ThongKe (
    id int identity(1,1) primary key not null,
    maHD varchar(30) NULL, 
    maThuoc int NULL, -- Changed to INT to link with Thuoc.ID
    tenThuoc nvarchar(50) NULL,
    donviTinh nchar(10) NULL,
    soLuong int NULL,
    donGia decimal(18, 0) NULL,
    thanhTien decimal(18, 0) NULL
)

-- ADD FOREIGN KEYS
ALTER TABLE ThongKe ADD CONSTRAINT FK_ThongKe_HoaDon 
FOREIGN KEY (maHD) REFERENCES HoaDon(maHD) ON DELETE CASCADE;

ALTER TABLE ThongKe ADD CONSTRAINT FK_ThongKe_Thuoc 
FOREIGN KEY (maThuoc) REFERENCES Thuoc(ID);
GO

 -- Insert Data

SET IDENTITY_INSERT [dbo].[Thuoc] ON

INSERT INTO [dbo].[Thuoc] ([ID], [tenThuoc], [donviTinh], [giaThuoc]) VALUES 

(1,'Paracetamol','viên',500), (2,'Alaxan','viên',910), (3,'Decolgen','viên',1250),

(4,'Hapacol Codein','chai',25000), (5,'Panadol Extra','viên',1200), (6,'Phosphalugel','gói',4000),

(7,'Yumangel','gói',4250), (8,'Gastropulgite','viên',4000), (9,'Gaviscon','chai',5625),

(10,'Trimafort','viên',5500), (11,'Penicillin','viên',3000), (12,'Amoxillin','viên',1000),

(13,'Aspirin','viên',575), (14,'Codein Sunfat','viên',700), (15,'Pepto-Bismol','chai',400000),

(16,'Domperidon','viên',400), (17,'Maalox','viên',875), (18,'Carbotrim','viên',2000),

(19,'Floctafenine','viên',1250), (20,'Tramadol','viên',500), (21,'Opioid Morphin','viên',1150000),

(22,'Fentanyl','viên',9600), (23,'Oxycontin','chai',5000), (24,'Naproxen','viên',1400),

(25,'Acetaminophen','viên',700), (26,'Efferalgan','viên',3000), (27,'Tiffy','viên',900),

(28,'Yuraf','viên',9000), (29,'Coldacmin','viên',330), (30,'E-cox 90','viên',3500);

SET IDENTITY_INSERT [dbo].[Thuoc] OFF

GO 

