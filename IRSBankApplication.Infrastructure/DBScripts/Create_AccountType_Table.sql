USE [BankDb]
GO

/****** Object:  Table [dbo].[AccountType]    Script Date: 3/31/2024 12:16:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[AccountType](
	[AccountTypeId] [int] NULL,
	[TypeName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO


