USE [Rundown]
GO
SET IDENTITY_INSERT [dbo].[Statuses] ON 

INSERT [dbo].[Statuses] ([StatusId], [Status], [IsDisabled]) VALUES (4, N'Open', 0)
INSERT [dbo].[Statuses] ([StatusId], [Status], [IsDisabled]) VALUES (5, N'Investigating', 0)
INSERT [dbo].[Statuses] ([StatusId], [Status], [IsDisabled]) VALUES (6, N'Testing', 0)
INSERT [dbo].[Statuses] ([StatusId], [Status], [IsDisabled]) VALUES (7, N'Closed', 0)
INSERT [dbo].[Statuses] ([StatusId], [Status], [IsDisabled]) VALUES (8, N'Hold', 0)
SET IDENTITY_INSERT [dbo].[Statuses] OFF
