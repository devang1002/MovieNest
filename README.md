CREATE DATABASE [MovieNest]

USE [MovieNest]
GO
 
/****** Object:  Table [dbo].[Movies]    Script Date: 10/15/2025 10:27:32 AM ******/

SET ANSI_NULLS ON
GO 
SET QUOTED_IDENTIFIER ON
GO
 
CREATE TABLE [dbo].[Movies](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ReleaseDate] [datetime] NULL,
	[Producer] [nvarchar](50) NULL,
	[Director] [nvarchar](50) NULL,
	[Casting] [nvarchar](50) NULL,

CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
 
 
 
