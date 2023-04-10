/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
SET IDENTITY_INSERT [dbo].[Run] ON 
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (2, 1, N'TEST Run', CAST(N'0001-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (3, 1, N'TEST Run', CAST(N'0001-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (4, 1, N'TEST Run', CAST(N'0001-01-01' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1002, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), CAST(0.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1003, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(5.0 AS Decimal(3, 1)), CAST(12.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1004, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(2.5 AS Decimal(3, 1)), CAST(24.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1005, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'12:00:00' AS Time), CAST(N'13:00:00' AS Time), CAST(6.0 AS Decimal(3, 1)), CAST(10.0 AS Decimal(3, 1)), N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1006, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'14:01:46' AS Time), CAST(N'15:01:49' AS Time), CAST(5.4 AS Decimal(3, 1)), CAST(11.1 AS Decimal(3, 1)), N'N/A', N'', N'', N'', N'')
GO
INSERT [dbo].[Run] ([RunId], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (1007, 1, N'TEST Run', CAST(N'2023-04-04' AS Date), CAST(N'14:05:19' AS Time), CAST(N'15:05:21' AS Time), CAST(7.3 AS Decimal(3, 1)), CAST(8.2 AS Decimal(3, 1)), N'N/A', N'N/A', N'N/A', N'N/A', N'N/A')
GO
SET IDENTITY_INSERT [dbo].[Run] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([UserID], [Email], [FirstName], [LastName], [LastLogin], [AvatarURL], [Salt], [PasswordHash]) VALUES (1, N'TestEmail', N'TestFirstName', N'Test', CAST(N'1900-01-01T00:00:06.670' AS DateTime), NULL, N'1234', N'TestPassword')
GO
INSERT [dbo].[User] ([UserID], [Email], [FirstName], [LastName], [LastLogin], [AvatarURL], [Salt], [PasswordHash]) VALUES (2, N'TestEmail', N'Eric', N'C', CAST(N'1900-01-01T00:00:06.673' AS DateTime), NULL, N'1234', N'TestPassword')
GO
INSERT [dbo].[User] ([UserID], [Email], [FirstName], [LastName], [LastLogin], [AvatarURL], [Salt], [PasswordHash]) VALUES (3, N'Test', N'TestFirstName', N'Test', CAST(N'1900-01-01T00:00:06.677' AS DateTime), NULL, N'1234', N'TestPassword')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO

