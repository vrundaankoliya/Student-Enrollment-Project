USE [student]
GO

/****** Object:  Table [dbo].[enroll_detail]    Script Date: 08/30/2013 15:11:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

drop table [dbo].[enroll_detail]
CREATE TABLE [dbo].[enroll_detail](
	[enroll_id] [numeric](18, 0) NOT NULL,
	[stu_surname] [varchar](15) NOT NULL,
	[stu_fname] [varchar](15) NOT NULL,
	[stu_lname] [varchar](15) NOT NULL,
	[address] [varchar](30) NOT NULL,
	[city] [varchar](20) NOT NULL,
	[pincode] [numeric](6, 0) NOT NULL,
	[phone_no] [numeric](12, 0) NOT NULL,
	[mob_no] [numeric](12, 0) NOT NULL,
	[dob] [datetime] NOT NULL,
	[gender] [varchar](6) NOT NULL,
	[physically_hand] [varchar](3) NOT NULL,
	[nationality] [varchar](10) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

