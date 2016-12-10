SET IDENTITY_INSERT [dbo].[Stores] ON
INSERT INTO [dbo].[Stores] ([Id], [Name], [Address], [Mode]) VALUES (1, N'Евроопт', N'г. Минск, ул. Казинца, 52A', N'с 8:00 до 22:00 ежедневно')
INSERT INTO [dbo].[Stores] ([Id], [Name], [Address], [Mode]) VALUES (2, N'Корона', N'г.Минск, ул. Кальварийская, 24', N'09:00-24:00 ежедневно')
INSERT INTO [dbo].[Stores] ([Id], [Name], [Address], [Mode]) VALUES (3, N'Гиппо', N'г. Минск, пр. Рокоссовского, 2', N'пн. – вс.: 09:00–23:00')
SET IDENTITY_INSERT [dbo].[Stores] OFF
