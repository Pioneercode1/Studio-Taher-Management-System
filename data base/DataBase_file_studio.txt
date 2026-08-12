USE [StudioTaher]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- 1. إنشاء جدول طلبات الفيديو
CREATE TABLE [dbo].[CustomerVideo](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[CusNmae] [nvarchar](50) NULL,
	[CusPhone] [nvarchar](25) NULL,
	[CusAdrress] [nvarchar](50) NULL,
	[CusOrder] [nvarchar](300) NULL,
	[AllPrise] [decimal](10, 0) NULL,
	[JetPrise] [decimal](10, 0) NULL,
	[SetPrise] [decimal](10, 0) NULL,
	[FriDate] [date] NULL,
	[SecDate] [date] NULL,
	[OrderBy] [nvarchar](20) NULL,
	[CameraMan] [nvarchar](50) NULL,
	[AboutOrder] [nvarchar](50) NULL,
	[CusNotes] [nvarchar](300) NULL,
	[CusGavet] [nvarchar](100) NULL,
 CONSTRAINT [PK_CustomerVideo] PRIMARY KEY CLUSTERED ([CusId] ASC)
) ON [PRIMARY]
GO

-- 2. إنشاء جدول أسعار تصميم الصور
CREATE TABLE [dbo].[disgnphoto](
	[custsize] [nvarchar](50) NOT NULL,
	[custprise] [decimal](8, 2) NOT NULL
) ON [PRIMARY]
GO

-- 3. إنشاء جدول بيانات الموظفين
CREATE TABLE [dbo].[EmployeeResource](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[EmpName] [nvarchar](30) NULL,
	[EmpAddress] [nvarchar](50) NULL,
	[EmpPhone] [nvarchar](30) NULL,
	[EmpSchool] [nvarchar](50) NULL,
	[EmpIdPerson] [nvarchar](30) NULL,
	[EmpServise] [nvarchar](30) NULL,
	[EmpJop] [nvarchar](50) NULL,
	[EmpPrise] [decimal](10, 0) NULL,
	[WorkDate] [date] NULL,
	[EmpNotes] [nvarchar](300) NULL,
 CONSTRAINT [PK_EmployeeResource] PRIMARY KEY CLUSTERED ([EmpId] ASC)
) ON [PRIMARY]
GO

-- 4. إنشاء جدول تسجيل الدخول والصلاحيات
CREATE TABLE [dbo].[loginAdmin](
	[UserName] [nvarchar](20) NOT NULL,
	[Password] [nvarchar](10) NOT NULL,
	[JobEmployee] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_loginAdmin] PRIMARY KEY CLUSTERED ([Password] ASC)
) ON [PRIMARY]
GO

-- 5. إنشاء جدول حجوزات الزفاف
CREATE TABLE [dbo].[marage](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[CusName] [nvarchar](50) NULL,
	[CusPhone] [nvarchar](50) NULL,
	[CusAddress] [nvarchar](50) NULL,
	[FriDate] [datetime] NULL,
	[SecDate] [datetime] NULL,
	[CusOrder] [nvarchar](300) NULL,
	[AllPrise] [decimal](10, 0) NULL,
	[JetPrise] [decimal](10, 0) NULL,
	[SetPrise] [decimal](10, 0) NULL,
	[gavet] [nvarchar](50) NULL,
	[CusNots] [nvarchar](100) NULL,
	[OrderBy] [nvarchar](50) NULL,
	[AboutOrder] [nvarchar](50) NULL,
 CONSTRAINT [PK_marage] PRIMARY KEY CLUSTERED ([CusId] ASC)
) ON [PRIMARY]
GO

-- 6. إنشاء جدول طلبات الصور
CREATE TABLE [dbo].[CustomerPhoto](
	[CusId] [int] IDENTITY(1,1) NOT NULL,
	[CusName] [nvarchar](50) NULL,
	[CusSize] [nvarchar](300) NULL,
	[CusUnit] [nvarchar](50) NULL,
	[AllPrise] [decimal](8, 0) NULL,
	[JetPrise] [decimal](8, 0) NULL,
	[SetPrise] [decimal](8, 0) NULL,
	[CusGavet] [nvarchar](50) NULL,
	[OrderBy] [nvarchar](20) NULL,
	[AboutOrder] [nvarchar](20) NULL,
	[FriDate] [date] NULL,
	[SecDate] [date] NULL,
	[CusNotes] [nvarchar](300) NULL,
	[CusPhone] [nvarchar](30) NULL,
 CONSTRAINT [PK_CustomerPhoto] PRIMARY KEY CLUSTERED ([CusId] ASC)
) ON [PRIMARY]
GO