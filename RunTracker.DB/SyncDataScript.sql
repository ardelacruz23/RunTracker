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
INSERT [dbo].[Run] ([RunID], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Measurement], [Duration], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (2, 1, N'TEST Run', N'0001-01-01', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), NULL, NULL, NULL, N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunID], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Measurement], [Duration], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (3, 1, N'TEST Run', N'0001-01-01', CAST(N'00:00:00' AS Time), CAST(N'00:00:00' AS Time), CAST(1.0 AS Decimal(3, 1)), NULL, NULL, NULL, N'No Photo Provided', NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[Run] ([RunID], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Measurement], [Duration], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (2006, 1, N'Test Day View', N'2023-04-10', CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(5.0 AS Decimal(3, 1)), NULL, CAST(N'01:00:00' AS Time), CAST(N'00:12:00' AS Time), N'N/A', N'N/A', N'N/A', N'N/A', N'N/A')
GO
INSERT [dbo].[Run] ([RunID], [UserID], [RunName], [RunDate], [StartTime], [EndTime], [Distance], [Measurement], [Duration], [Pace], [PhotoURL], [LocationName], [City], [State], [Country]) VALUES (2012, 1, N'TestPace', N'2023-04-10', CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), CAST(3.9 AS Decimal(3, 1)), N'Measurement', CAST(N'01:00:00' AS Time), CAST(N'00:15:23' AS Time), N'N/A', N'N/A', N'N/A', N'N/A', N'N/A')
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
INSERT [dbo].[User] ([UserID], [Email], [FirstName], [LastName], [LastLogin], [AvatarURL], [Salt], [PasswordHash]) VALUES (4, N'123', N'First Name', N'Last Name', NULL, NULL, N'1234', N'123')
GO
INSERT [dbo].[User] ([UserID], [Email], [FirstName], [LastName], [LastLogin], [AvatarURL], [Salt], [PasswordHash]) VALUES (5, N't', N'T', N't', NULL, NULL, N'1234', N't')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO