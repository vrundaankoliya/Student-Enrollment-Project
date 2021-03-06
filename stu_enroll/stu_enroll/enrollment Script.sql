USE [master]
GO
/****** Object:  Database [project]    Script Date: 09/05/2013 14:53:05 ******/
CREATE DATABASE [project] ON  PRIMARY 
( NAME = N'project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\project.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL.1\MSSQL\DATA\project_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [project] SET COMPATIBILITY_LEVEL = 90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [project] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [project] SET ANSI_NULLS OFF
GO
ALTER DATABASE [project] SET ANSI_PADDING OFF
GO
ALTER DATABASE [project] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [project] SET ARITHABORT OFF
GO
ALTER DATABASE [project] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [project] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [project] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [project] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [project] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [project] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [project] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [project] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [project] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [project] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [project] SET  DISABLE_BROKER
GO
ALTER DATABASE [project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [project] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [project] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [project] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [project] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [project] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [project] SET  READ_WRITE
GO
ALTER DATABASE [project] SET RECOVERY SIMPLE
GO
ALTER DATABASE [project] SET  MULTI_USER
GO
ALTER DATABASE [project] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [project] SET DB_CHAINING OFF
GO
USE [project]
GO
/****** Object:  Table [dbo].[tblCourse]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCourse](
	[CourseCode] [int] NOT NULL,
	[CourseName] [varchar](100) NOT NULL,
	[Remark] [varchar](500) NULL,
	[FacultyCode] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [nchar](10) NOT NULL,
	[UserName] [nchar](10) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[MobileNo] [nchar](10) NOT NULL,
	[Address] [nchar](10) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblEnrollment]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblEnrollment](
	[EnrollmentID] [int] NOT NULL,
	[FormNo] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address1] [varchar](1000) NOT NULL,
	[City1] [varchar](1000) NOT NULL,
	[Pincode1] [int] NOT NULL,
	[MobileNo1] [varchar](20) NOT NULL,
	[PhoneNo1] [varchar](20) NOT NULL,
	[Address2] [varchar](1000) NOT NULL,
	[City2] [varchar](1000) NOT NULL,
	[Pincode2] [int] NOT NULL,
	[MobileNo2] [varchar](20) NOT NULL,
	[PhoneNo2] [varchar](20) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Handicape] [bit] NOT NULL,
	[Nationality] [varchar](50) NOT NULL,
	[Cast] [varchar](50) NOT NULL,
	[SubCast] [varchar](50) NOT NULL,
	[Minority] [varchar](50) NOT NULL,
	[Religion] [varchar](50) NOT NULL,
	[NameOfBoard] [varchar](100) NOT NULL,
	[SeatNumber] [varchar](100) NOT NULL,
	[ExamCenter] [varchar](100) NOT NULL,
	[YearOfPassing] [varchar](10) NOT NULL,
	[NameOfSchool] [varchar](100) NOT NULL,
	[TotalMarks] [float] NOT NULL,
	[ObtainMarks] [float] NOT NULL,
	[PECNumber] [varchar](50) NOT NULL,
	[PECDate] [varchar](50) NOT NULL,
	[FECNumber] [varchar](50) NOT NULL,
	[FECDate] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblMarks]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblMarks](
	[SubjectID] [int] NOT NULL,
	[EnrollmentID] [int] NOT NULL,
	[TotalMarks] [float] NOT NULL,
	[ObtainMarks] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubject]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSubject](
	[SubjectID] [int] NOT NULL,
	[SubjectName] [varchar](100) NOT NULL,
	[TotalMarks] [float] NOT NULL,
	[Remarks] [varchar](500) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblCollege]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblCollege](
	[CollegeID] [varchar](100) NOT NULL,
	[CollegeName] [varchar](500) NOT NULL,
	[Address] [varchar](500) NOT NULL,
	[PhoneNo] [varchar](20) NOT NULL,
	[MobileNo] [varchar](20) NOT NULL,
	[EmailID] [varchar](100) NOT NULL,
	[Website] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tblCollege] PRIMARY KEY CLUSTERED 
(
	[CollegeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblFaculty]    Script Date: 09/05/2013 14:53:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblFaculty](
	[FacultyCode] [int] NOT NULL,
	[FacultyName] [varchar](100) NOT NULL,
	[Remark] [varchar](500) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
