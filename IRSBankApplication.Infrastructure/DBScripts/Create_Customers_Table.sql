USE [BankDb]
GO

/****** Object:  Table [dbo].[Customers]    Script Date: 3/31/2024 12:17:31 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] NULL,
	[Gender] [nvarchar](50) NULL,
	[Givenname] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Streetaddress] [nvarchar](50) NULL,
	[City] [nvarchar](50) NULL,
	[Zipcode] [nvarchar](50) NULL,
	[Country] [nvarchar](50) NULL,
	[CountryCode] [nvarchar](50) NULL,
	[Birthday] [datetime] NULL,
	[Telephonecountrycode] [nvarchar](50) NULL,
	[Telephonenumber] [nvarchar](50) NULL,
	[Emailaddress] [nvarchar](50) NULL
) ON [PRIMARY]
GO


