INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'228c4948-7195-4587-841c-da01e4b6e3c0', N'Admin', N'Admin', N'41288d9a-ca89-40eb-bef7-6b28947bbaf6')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'e2834744-9a1f-456f-8697-c141c34c8a48', N'User', N'User', N'5c972f32-9150-47da-9285-eee01726acc7')

INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a69d7417-0a6f-45f9-9c51-06914e146818', N'admin3@products.com', N'ADMIN3@PRODUCTS.COM', N'admin3@products.com', N'ADMIN3@PRODUCTS.COM', 1, N'AQAAAAEAACcQAAAAEHv7Qc/7wQzB36At8Sr7WaXCdsPnfOsX56hApuzFhghbPeAArrc6Rq10VWItdxx9kQ==', N'AD4KNQJ2FQWGXQBRT2Q2BILE3FASKVQM', N'b71f95a8-7066-4bd8-8831-81c3f46d65a6', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'cb9d2318-dff6-49b6-8088-211d92194f9e', N'customer2@products.com', N'CUSTOMER2@PRODUCTS.COM', N'customer2@products.com', N'CUSTOMER2@PRODUCTS.COM', 1, N'AQAAAAEAACcQAAAAEPwFcRhHBpxuo4kn37nWjQDs9/DQYUprrC14EaKUzNtFTs8xT/1wD/mGqmj8JI6Fkg==', N'ITWIQ455QW3RH4Z4RVBGHAQU3UWYJ2VB', N'7d030e7a-b709-4cd4-b3da-15cf6fa52bb1', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e535e9aa-0a2c-42b6-abe1-d380909f63f0', N'customer1@products.com', N'CUSTOMER1@PRODUCTS.COM', N'customer1@products.com', N'CUSTOMER1@PRODUCTS.COM', 1, N'AQAAAAEAACcQAAAAEMrVJrkHs0K+4lgRZ+N31vnTDFSWp/lTtW5QkGrdQGbK+9lDaCF+30LN42LgSWGzMg==', N'CBMNTS7V3AIZ3ZX7QU73ESLQHXFX3VSD', N'9e26cb88-e579-44fd-b281-b8d5c7e6b64a', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'fce68fcd-6f50-46b0-8d49-b1d9ba028857', N'user@products.com', N'USER@PRODUCTS.COM', N'user@products.com', N'USER@PRODUCTS.COM', 1, N'AQAAAAEAACcQAAAAEFrpPK+q/T053V7qoqYBvbGlGO49lkUAasRQ0JuPHLGFo4X0jhZYV0VU2Q4hpCBHXA==', N'MH72DXJS65YC3OTJPYRIGGWK45B5XONO', N'61b4fd56-faaa-4bab-86e7-2d3865e43f0a', NULL, 0, 0, NULL, 1, 0)

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a69d7417-0a6f-45f9-9c51-06914e146818', N'228c4948-7195-4587-841c-da01e4b6e3c0')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'cb9d2318-dff6-49b6-8088-211d92194f9e', N'e2834744-9a1f-456f-8697-c141c34c8a48')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e535e9aa-0a2c-42b6-abe1-d380909f63f0', N'e2834744-9a1f-456f-8697-c141c34c8a48')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'fce68fcd-6f50-46b0-8d49-b1d9ba028857', N'e2834744-9a1f-456f-8697-c141c34c8a48')
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Email], [CustomerName], [Address], [ContactNumber]) VALUES (1, N'customer1@products.com', N'Harry', N'345A Great South road', N'02108813540')
INSERT INTO [dbo].[Customer] ([Id], [Email], [CustomerName], [Address], [ContactNumber]) VALUES (2, N'customer2@products.com', N'Smith', N'4567 Great South road', N'02208813540')
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Product] ON
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (1, N'Samsung Smart TV', CAST(850.00 AS Decimal(18, 2)), N'A smart TV experiance', N'smart_tv.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (2, N'IPhone 11', CAST(750.00 AS Decimal(18, 2)), N'IPhone 11 with massive digital media experience', N'iphone_11.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (3, N'X Box 360', CAST(1200.00 AS Decimal(18, 2)), N'Real world gaming experience with 3D cameras and motion detection', N'XBOX_360.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (4, N'Play station 5', CAST(1000.00 AS Decimal(18, 2)), N'High performance interactive multiplayer gaming ', N'play_st_5.jpg')
INSERT INTO [dbo].[Product] ([Id], [ProductName], [ProductPrice], [ProductDescription], [ImageUrl]) VALUES (5, N'Nexus -Android Pie', CAST(700.00 AS Decimal(18, 2)), N'High performance Games and Apps with Cloud sync ', N'Android_pie_nexus.jpg')
SET IDENTITY_INSERT [dbo].[Product] OFF
SET IDENTITY_INSERT [dbo].[Transaction] ON
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (1, 1, 1, N'ORD_1_2019111930')
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (2, 1, 1, N'ORD_1_2019111930')
INSERT INTO [dbo].[Transaction] ([Id], [ProductId], [CustomerId], [OrderId]) VALUES (3, 1, 2, N'ORD_2_201911190')
SET IDENTITY_INSERT [dbo].[Transaction] OFF
