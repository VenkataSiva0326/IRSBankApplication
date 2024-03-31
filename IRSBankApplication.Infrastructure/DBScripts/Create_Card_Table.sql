USE [BankDb]
GO

/****** Object:  Table [dbo].[Card]    Script Date: 3/31/2024 12:17:02 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Card](
	[CardId] [int] NULL,
	[DispositionId] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[Issued] [datetime] NULL,
	[Cctype] [nvarchar](50) NULL,
	[Ccnumber] [nvarchar](50) NULL,
	[Cvv2] [nvarchar](50) NULL,
	[ExpM] [int] NULL,
	[ExpY] [int] NULL
) ON [PRIMARY]
GO


