CREATE TABLE [dbo].[Khoa] (
    [MaKhoa]  CHAR (10)      NOT NULL,
    [TenKhoa] NVARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([MaKhoa] ASC)
);
CREATE TABLE [dbo].[LopHoc] (
    [MaLop]  CHAR (10)     NOT NULL,
    [TenLop] NVARCHAR (50) NOT NULL,
    [MaKhoa] CHAR (10)     NULL,
    PRIMARY KEY CLUSTERED ([MaLop] ASC),
    FOREIGN KEY ([MaKhoa]) REFERENCES [dbo].[Khoa] ([MaKhoa]) ON DELETE CASCADE
);
CREATE TABLE [dbo].[MonHoc] (
    [MaMon]    CHAR (10)      NOT NULL,
    [TenMon]   NVARCHAR (100) NOT NULL,
    [SoTinChi] INT            NULL,
    PRIMARY KEY CLUSTERED ([MaMon] ASC),
    CHECK ([SoTinChi]>(0))
);

CREATE TABLE [dbo].[SinhVien] (
    [MaSV]        CHAR (10)      NOT NULL,
    [HoTen]       NVARCHAR (100) NOT NULL,
    [NgaySinh]    DATE           NOT NULL,
    [GioiTinh]    NVARCHAR (10)  NULL,
    [DiaChi]      NVARCHAR (255) NULL,
    [Email]       NVARCHAR (100) NULL,
    [SoDienThoai] CHAR (10)      NULL,
    [MaLop]       CHAR (10)      NULL,
    PRIMARY KEY CLUSTERED ([MaSV] ASC),
    UNIQUE NONCLUSTERED ([SoDienThoai] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC),
    FOREIGN KEY ([MaLop]) REFERENCES [dbo].[LopHoc] ([MaLop]) ON DELETE CASCADE
);
CREATE TABLE [dbo].[DangKyMonHoc] (
    [MaSV]  CHAR (10)      NOT NULL,
    [MaMon] NVARCHAR (100) NOT NULL,
    FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV])
);
CREATE TABLE [dbo].[Diem] (
    [MaSV]   CHAR (10)      NULL,
    [TenMon] NVARCHAR (100) NULL,
    [DiemTX] FLOAT (53)     NULL,
    [DiemGK] FLOAT (53)     NULL,
    [DiemCK] FLOAT (53)     NULL,
    FOREIGN KEY ([MaSV]) REFERENCES [dbo].[SinhVien] ([MaSV]) ON DELETE CASCADE,
    CHECK ([DiemTX]>=(0) AND [DiemTX]<=(10))
);
CREATE TABLE [dbo].[StudentScores] (
    [ID]           INT        IDENTITY (1, 1) NOT NULL,
    [DateRecorded] DATE       NOT NULL,
    [AverageScore] FLOAT (53) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

CREATE TABLE [dbo].[Users] (
    [id]       INT           IDENTITY (1, 1) NOT NULL,
    [username] VARCHAR (255) NOT NULL,
    [password] VARCHAR (255) NOT NULL,
    [keyword]  VARCHAR (255) NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);

