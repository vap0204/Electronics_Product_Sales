SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Email], [CustomerName], [Address], [ContactNumber]) VALUES (1, N'customer1@products.com', N'Harry', N'345A Great South road', N'02108813540')
INSERT INTO [dbo].[Customer] ([Id], [Email], [CustomerName], [Address], [ContactNumber]) VALUES (2, N'customer2@products.com', N'Smith', N'4567 Great South road', N'02208813540')
SET IDENTITY_INSERT [dbo].[Customer] OFF
