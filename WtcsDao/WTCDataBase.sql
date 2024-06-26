USE [master]
GO
/****** Object:  Database [WTCDatabase]    Script Date: 2024/3/27 11:34:12 ******/
CREATE DATABASE [WTCDatabase]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WTCDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WTCDatabase.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WTCDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WTCDatabase_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WTCDatabase] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WTCDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WTCDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WTCDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WTCDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WTCDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WTCDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [WTCDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WTCDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WTCDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WTCDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WTCDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WTCDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WTCDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WTCDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WTCDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WTCDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WTCDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WTCDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WTCDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WTCDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WTCDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WTCDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WTCDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WTCDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [WTCDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [WTCDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WTCDatabase] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WTCDatabase] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WTCDatabase] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WTCDatabase] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WTCDatabase', N'ON'
GO
USE [WTCDatabase]
GO
/****** Object:  Table [dbo].[AlarmLog]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AlarmLog](
	[Alog_id] [int] IDENTITY(1,1) NOT NULL,
	[AlarmLog] [varchar](500) NOT NULL,
	[AlarmTemperature] [varchar](50) NOT NULL,
	[AlarmType] [varchar](50) NOT NULL,
	[SRegionId] [int] NOT NULL,
	[AlarmLowTemperature] [varchar](50) NOT NULL,
	[AlarmHighTemperature] [varchar](50) NOT NULL,
 CONSTRAINT [PK_AlarmLog] PRIMARY KEY CLUSTERED 
(
	[Alog_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductInfos](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](50) NOT NULL,
	[ProductNumber] [varchar](50) NULL,
	[FitLowTemperature] [decimal](18, 2) NOT NULL,
	[FitHighTemperature] [decimal](18, 2) NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_ProductInfos] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductInStoreRecordInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductInStoreRecordInfos](
	[RecordId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[SRegionId] [int] NOT NULL,
	[ProductCount] [int] NOT NULL,
	[InSoreLog] [varchar](500) NULL,
	[InStoreTime] [datetime] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_ProductInStoreRecordInfos\] PRIMARY KEY CLUSTERED 
(
	[RecordId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductStoreInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductStoreInfos](
	[ProStoreId] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[StoreId] [int] NOT NULL,
	[SRegionId] [int] NOT NULL,
	[ProductCount] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_ProductStoreInfos] PRIMARY KEY CLUSTERED 
(
	[ProStoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SensoreAddress]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SensoreAddress](
	[SensoreId] [int] NULL,
	[SensoreName] [varchar](50) NULL,
	[SRegionId] [int] NULL,
	[SensoreState] [varchar](50) NULL,
	[RegisterAddress] [int] NOT NULL,
	[Modbus_Slave_id] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StoreInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StoreInfos](
	[StoreId] [int] IDENTITY(1,1) NOT NULL,
	[StoreName] [nvarchar](50) NOT NULL,
	[StoreNumber] [varchar](50) NULL,
	[RegionCount] [int] NOT NULL,
	[Remark] [nvarchar](50) NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_StoreInfos] PRIMARY KEY CLUSTERED 
(
	[StoreId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StoreRegionInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StoreRegionInfos](
	[SRegionId] [int] NOT NULL,
	[SRegionName] [nvarchar](50) NOT NULL,
	[SRegionNumber] [varchar](50) NULL,
	[StoreId] [int] NOT NULL,
	[SRTemperature] [decimal](18, 2) NULL,
	[AllowLowTemperture] [decimal](18, 2) NULL,
	[AllowHighTemperture] [decimal](18, 2) NULL,
	[Remark] [varchar](500) NULL,
	[IsDeleted] [nchar](10) NOT NULL,
	[SensorAddress] [varchar](50) NOT NULL,
	[AlarmLog] [varchar](500) NULL,
	[TemperatureLog] [varchar](500) NULL,
	[SensorIP] [varchar](50) NOT NULL,
	[SensorPort] [int] NOT NULL,
 CONSTRAINT [PK_StoreRegionInfos] PRIMARY KEY CLUSTERED 
(
	[SRegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Temperature]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Temperature](
	[Tlog_id] [int] NOT NULL,
	[SRegionId] [int] NOT NULL,
	[Temperature] [varchar](50) NOT NULL,
	[RecordTime] [datetime] NOT NULL,
 CONSTRAINT [PK_Temperature] PRIMARY KEY CLUSTERED 
(
	[Tlog_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserInfos]    Script Date: 2024/3/27 11:34:12 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserInfos](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[UserPwd] [varchar](50) NOT NULL,
	[UserState] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_UserInfos] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[ProductInfos] ADD  CONSTRAINT [DF_ProductInfos_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ProductInStoreRecordInfos] ADD  CONSTRAINT [DF_ProductInStoreRecordInfos\_ProductCount]  DEFAULT ((0)) FOR [ProductCount]
GO
ALTER TABLE [dbo].[ProductInStoreRecordInfos] ADD  CONSTRAINT [DF_ProductInStoreRecordInfos\_InStoreTime]  DEFAULT (getdate()) FOR [InStoreTime]
GO
ALTER TABLE [dbo].[ProductInStoreRecordInfos] ADD  CONSTRAINT [DF_ProductInStoreRecordInfos\_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[ProductStoreInfos] ADD  CONSTRAINT [DF_ProductStoreInfos_ProductCount]  DEFAULT ((0)) FOR [ProductCount]
GO
ALTER TABLE [dbo].[ProductStoreInfos] ADD  CONSTRAINT [DF_ProductStoreInfos_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[StoreInfos] ADD  CONSTRAINT [DF_StoreInfos_RegionCount]  DEFAULT ((0)) FOR [RegionCount]
GO
ALTER TABLE [dbo].[StoreInfos] ADD  CONSTRAINT [DF_StoreInfos_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[UserInfos] ADD  CONSTRAINT [DF_UserInfos_UserState]  DEFAULT ((1)) FOR [UserState]
GO
ALTER TABLE [dbo].[UserInfos] ADD  CONSTRAINT [DF_UserInfos_IsDeleted]  DEFAULT ((0)) FOR [IsDeleted]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'未删除为0，已删除为1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProductInfos', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'未删除为0，已删除为1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ProductStoreInfos', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StoreInfos', @level2type=N'COLUMN',@level2name=N'StoreNumber'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'仓库分区数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StoreInfos', @level2type=N'COLUMN',@level2name=N'RegionCount'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StoreInfos', @level2type=N'COLUMN',@level2name=N'Remark'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'未删除为0，已删除为1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'StoreRegionInfos', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'状态正常为1，不正常为0' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfos', @level2type=N'COLUMN',@level2name=N'UserState'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'未删除为0，已删除为1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserInfos', @level2type=N'COLUMN',@level2name=N'IsDeleted'
GO
USE [master]
GO
ALTER DATABASE [WTCDatabase] SET  READ_WRITE 
GO
