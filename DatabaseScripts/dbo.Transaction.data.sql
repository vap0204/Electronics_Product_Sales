SET IDENTITY_INSERT [dbo].[Transaction] ON
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (1, 1, 1, N'ORD_1_2019111930')
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (2, 1, 1, N'ORD_1_2019111930')
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (3, 1, 2, N'ORD_2_201911190')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
