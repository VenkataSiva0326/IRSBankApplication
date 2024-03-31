USE [BankDb]
GO

/****** Object:  Table [dbo].[User]    Script Date: 3/31/2024 12:19:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[User](
	[UserId] [nvarchar](100) NULL,
	[Email] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Role] [nvarchar](50) NULL
) ON [PRIMARY]
GO


