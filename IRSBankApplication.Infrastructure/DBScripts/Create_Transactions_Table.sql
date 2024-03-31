USE [BankDb]
GO

/****** Object:  Table [dbo].[Transactions]    Script Date: 3/31/2024 12:19:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Transactions](
	[TransactionId] [int] NULL,
	[AccountId] [int] NULL,
	[Date] [datetime] NULL,
	[Type] [nvarchar](50) NULL,
	[Operation] [nvarchar](50) NULL,
	[Amount] [decimal](18, 0) NULL,
	[Balance] [decimal](18, 0) NULL,
	[Symbol] [nvarchar](50) NULL,
	[Bank] [nvarchar](50) NULL,
	[Account] [nvarchar](50) NULL
) ON [PRIMARY]
GO


