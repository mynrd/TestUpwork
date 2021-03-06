USE [TEST]
GO
/****** Object:  Table [dbo].[TestCategories]    Script Date: 19/02/2020 3:34:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestCategories](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
 CONSTRAINT [PK_TestCategories] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestOrderProducts]    Script Date: 19/02/2020 3:34:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestOrderProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[OrderId] [int] NULL,
	[ProductId] [int] NULL,
	[Quantity] [int] NULL,
	[Price] [money] NULL,
	[Total] [money] NULL,
 CONSTRAINT [PK_TestOrderProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestOrders]    Script Date: 19/02/2020 3:34:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestOrders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](255) NULL,
	[LastName] [varchar](255) NULL,
	[Address] [varchar](255) NULL,
	[City] [varchar](255) NULL,
	[State] [varchar](255) NULL,
	[Country] [varchar](255) NULL,
 CONSTRAINT [PK_TestOrders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestProductCategories]    Script Date: 19/02/2020 3:34:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestProductCategories](
	[ProductId] [int] NULL,
	[CategoryId] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TestProducts]    Script Date: 19/02/2020 3:34:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TestProducts](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](255) NULL,
	[SKU] [varchar](255) NULL,
	[Description] [varchar](255) NULL,
 CONSTRAINT [PK_TestProducts] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TestCategories] ON 

INSERT [dbo].[TestCategories] ([id], [Name]) VALUES (1, N'Category 1')
INSERT [dbo].[TestCategories] ([id], [Name]) VALUES (2, N'Category 2')
SET IDENTITY_INSERT [dbo].[TestCategories] OFF
SET IDENTITY_INSERT [dbo].[TestOrderProducts] ON 

INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (1, 1, 1, 1, 9.9900, 9.9900)
INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (2, 1, 3, 1, 4.9900, 9.9900)
INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (3, 2, 2, 1, 9.9900, 9.9900)
INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (4, 3, 1, 1, 9.9900, 9.9900)
INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (5, 3, 3, 1, 4.9900, 9.9900)
INSERT [dbo].[TestOrderProducts] ([id], [OrderId], [ProductId], [Quantity], [Price], [Total]) VALUES (6, 3, 2, 1, 9.9900, 9.9900)
SET IDENTITY_INSERT [dbo].[TestOrderProducts] OFF
SET IDENTITY_INSERT [dbo].[TestOrders] ON 

INSERT [dbo].[TestOrders] ([id], [FirstName], [LastName], [Address], [City], [State], [Country]) VALUES (1, N'Jeff', N'Cheung', N'150 Golf Course Rd', N'South Burlington', N'VT', N'USA')
INSERT [dbo].[TestOrders] ([id], [FirstName], [LastName], [Address], [City], [State], [Country]) VALUES (2, N'Jeff', N'Cheung', N'150 Golf Course Rd', N'South Burlington', N'VT', N'USA')
INSERT [dbo].[TestOrders] ([id], [FirstName], [LastName], [Address], [City], [State], [Country]) VALUES (3, N'Jeff', N'Cheung', N'150 Dorset St Ste 245-236', N'South Burlington', N'VT', N'USA')
SET IDENTITY_INSERT [dbo].[TestOrders] OFF
INSERT [dbo].[TestProductCategories] ([ProductId], [CategoryId]) VALUES (1, 1)
INSERT [dbo].[TestProductCategories] ([ProductId], [CategoryId]) VALUES (2, 1)
INSERT [dbo].[TestProductCategories] ([ProductId], [CategoryId]) VALUES (3, 2)
SET IDENTITY_INSERT [dbo].[TestProducts] ON 

INSERT [dbo].[TestProducts] ([id], [Name], [SKU], [Description]) VALUES (1, N'Argan Product', N'Argan', N'Argan Test Product')
INSERT [dbo].[TestProducts] ([id], [Name], [SKU], [Description]) VALUES (2, N'Argan Product 2', N'Argan2', N'Argan Test Product #2')
INSERT [dbo].[TestProducts] ([id], [Name], [SKU], [Description]) VALUES (3, N'Idro Product', N'Idro', N'Idro Test Product')
SET IDENTITY_INSERT [dbo].[TestProducts] OFF
ALTER TABLE [dbo].[TestOrderProducts]  WITH CHECK ADD  CONSTRAINT [FK_TestOrderProducts_TestOrders] FOREIGN KEY([OrderId])
REFERENCES [dbo].[TestOrders] ([id])
GO
ALTER TABLE [dbo].[TestOrderProducts] CHECK CONSTRAINT [FK_TestOrderProducts_TestOrders]
GO
ALTER TABLE [dbo].[TestOrderProducts]  WITH CHECK ADD  CONSTRAINT [FK_TestOrderProducts_TestProducts] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TestProducts] ([id])
GO
ALTER TABLE [dbo].[TestOrderProducts] CHECK CONSTRAINT [FK_TestOrderProducts_TestProducts]
GO
ALTER TABLE [dbo].[TestProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_TestProductCategories_TestCategories] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[TestCategories] ([id])
GO
ALTER TABLE [dbo].[TestProductCategories] CHECK CONSTRAINT [FK_TestProductCategories_TestCategories]
GO
ALTER TABLE [dbo].[TestProductCategories]  WITH CHECK ADD  CONSTRAINT [FK_TestProductCategories_TestProducts] FOREIGN KEY([ProductId])
REFERENCES [dbo].[TestProducts] ([id])
GO
ALTER TABLE [dbo].[TestProductCategories] CHECK CONSTRAINT [FK_TestProductCategories_TestProducts]
GO
