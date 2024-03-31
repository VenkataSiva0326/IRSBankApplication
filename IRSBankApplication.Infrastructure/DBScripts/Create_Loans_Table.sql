USE [BankDb]
GO

/****** Object:  Table [dbo].[Loans]    Script Date: 3/31/2024 12:18:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Loans](
	[LoanId] [int] NULL,
	[AccountId] [int] NULL,
	[Date] [datetime] NULL,
	[Amount] [decimal](18, 0) NULL,
	[Duration] [int] NULL,
	[Payments] [decimal](18, 0) NULL,
	[Status] [nvarchar](50) NULL
) ON [PRIMARY]
GO


