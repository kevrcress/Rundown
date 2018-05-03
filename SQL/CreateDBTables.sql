USE [Rundown]
GO
/****** Object:  Table [dbo].[Issues]    Script Date: 5/3/2018 12:39:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Issues](
	[IssueId] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[StatusId] [int] NULL,
	[ExpectedResolutionDate] [datetime] NULL,
	[ActualResolutionDate] [datetime] NULL,
	[IsDeleted] [bit] NOT NULL,
 CONSTRAINT [PK_Issues] PRIMARY KEY CLUSTERED 
(
	[IssueId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Statuses]    Script Date: 5/3/2018 12:39:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Statuses](
	[StatusId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](50) NULL,
	[IsDisabled] [bit] NOT NULL,
 CONSTRAINT [PK_Statuses] PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Statuses] ADD  CONSTRAINT [DF_Statuses_IsDisabled]  DEFAULT ((0)) FOR [IsDisabled]
GO
ALTER TABLE [dbo].[Issues]  WITH CHECK ADD  CONSTRAINT [FK_Issues_Statuses] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Statuses] ([StatusId])
GO
ALTER TABLE [dbo].[Issues] CHECK CONSTRAINT [FK_Issues_Statuses]
GO
