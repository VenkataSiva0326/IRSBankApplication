USE [BankDb]
GO

/****** Object:  Table [dbo].[Accounts]    Script Date: 3/31/2024 12:14:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Accounts](
	[AccountId] [int] NULL,
	[Frequency] [nvarchar](50) NULL,
	[Created] [datetime] NULL,
	[Balance] [decimal](18, 0) NULL,
	[AccountTypesId] [int] NULL
) ON [PRIMARY]
GO


