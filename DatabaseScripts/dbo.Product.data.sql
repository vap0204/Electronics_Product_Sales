SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (1, N'Samsung Smart TV', CAST(850.00 AS Decimal(18, 2)), N'A smart TV experiance', N'downloand.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (2, N'IPhone 11', CAST(750.00 AS Decimal(18, 2)), N'IPhone 11 with massive digital media experience', N'iphone_11.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (3, N'X Box 360', CAST(1200.00 AS Decimal(18, 2)), N'Real world gaming experience with 3D cameras and motion detection', N'XBOX_360.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (4, N'Play station 5', CAST(1000.00 AS Decimal(18, 2)), N'High performance interactive multiplayer gaming ', N'play_st_5.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (5, N'Nexus -Android Pie', CAST(700.00 AS Decimal(18, 2)), N'High performance Games and Apps with Cloud sync ', N'Android_pie_nexus.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
