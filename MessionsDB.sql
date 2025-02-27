USE [master]
GO
/****** Object:  Database [MessionsDB]    Script Date: 18/06/2024 18:32:08 ******/
CREATE DATABASE [MessionsDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MessionsDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\MessionsDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MessionsDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQL2019EXPRESS\MSSQL\DATA\MessionsDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MessionsDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MessionsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MessionsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MessionsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MessionsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MessionsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MessionsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MessionsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MessionsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MessionsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MessionsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MessionsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MessionsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MessionsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MessionsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MessionsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MessionsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MessionsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MessionsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MessionsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MessionsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MessionsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MessionsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MessionsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MessionsDB] SET RECOVERY FULL 
GO
ALTER DATABASE [MessionsDB] SET  MULTI_USER 
GO
ALTER DATABASE [MessionsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MessionsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MessionsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MessionsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MessionsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MessionsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'MessionsDB', N'ON'
GO
ALTER DATABASE [MessionsDB] SET QUERY_STORE = OFF
GO
USE [MessionsDB]
GO
/****** Object:  Table [dbo].[Messions]    Script Date: 18/06/2024 18:32:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Messions](
	[taskId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[subject] [nvarchar](250) NOT NULL,
	[targetDate] [datetime] NOT NULL,
	[isCompleted] [bit] NOT NULL,
 CONSTRAINT [PK_Tasks] PRIMARY KEY CLUSTERED 
(
	[taskId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 18/06/2024 18:32:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Messions] ON 

INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (1, 2, N'string', CAST(N'2024-06-17T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (2, 3, N'stri222ng', CAST(N'2024-06-17T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (3, 3, N'asdasd', CAST(N'2024-06-17T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (4, 3, N'asdf', CAST(N'2024-06-19T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (5, 1, N'zzzz', CAST(N'2024-06-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (6, 1, N'zzzz', CAST(N'2024-06-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (7, 1, N'zzzz', CAST(N'2024-06-16T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (8, 1, N'zzzz', CAST(N'2024-06-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (9, 2, N'qwe', CAST(N'2024-06-13T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (10, 6, N'asdf', CAST(N'2024-06-30T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Messions] ([taskId], [userId], [subject], [targetDate], [isCompleted]) VALUES (11, 2, N'sad', CAST(N'2024-06-05T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Messions] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([userId], [name]) VALUES (1, N'זיו')
INSERT [dbo].[Users] ([userId], [name]) VALUES (2, N'חיים')
INSERT [dbo].[Users] ([userId], [name]) VALUES (3, N'מוטי')
INSERT [dbo].[Users] ([userId], [name]) VALUES (4, N'איילה')
INSERT [dbo].[Users] ([userId], [name]) VALUES (5, N'נעמה')
INSERT [dbo].[Users] ([userId], [name]) VALUES (6, N'מיכל')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
USE [master]
GO
ALTER DATABASE [MessionsDB] SET  READ_WRITE 
GO
