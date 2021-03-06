USE [YakuzaDB]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Calificacion]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Calificacion](
	[idCalificacion] [int] IDENTITY(1,1) NOT NULL,
	[puntajeCalificacion] [char](10) NOT NULL,
	[idPlatillo] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carrito]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Carrito](
	[idCarrito] [int] IDENTITY(1,1) NOT NULL,
	[totalCarrito] [money] NOT NULL,
	[IdUsuario] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCarrito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CatalogoCarrito]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CatalogoCarrito](
	[idCatalogo] [int] IDENTITY(1,1) NOT NULL,
	[cantidadCatalogo] [int] NOT NULL,
	[subTotalCatalogo] [money] NOT NULL,
	[idCarrito] [int] NOT NULL,
	[idPlatillo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCatalogo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CategoriaPlatillo]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoriaPlatillo](
	[idCategoriaPlatillo] [int] IDENTITY(1,1) NOT NULL,
	[nombreCategoriaPlatillo] [varchar](50) NOT NULL,
	[descripcionCategoriaPlatillo] [varchar](2000) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCategoriaPlatillo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Comentario]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Comentario](
	[idComentario] [int] IDENTITY(1,1) NOT NULL,
	[descripcionComentario] [varchar](500) NOT NULL,
	[idCalificacion] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idComentario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Consumidor]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Consumidor](
	[idConsumidor] [int] IDENTITY(1,1) NOT NULL,
	[idMembresia] [int] NULL,
	[idTarjeta] [int] NULL,
	[IdUsuario] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idConsumidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ConsumidorHasDireccion]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConsumidorHasDireccion](
	[idDireccion] [int] NOT NULL,
	[idConsumidor] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC,
	[idConsumidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Direccion]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Direccion](
	[idDireccion] [int] IDENTITY(1,1) NOT NULL,
	[municipioDireccion] [varchar](200) NOT NULL,
	[coloniaDireccion] [varchar](200) NOT NULL,
	[calleDireccion] [varchar](200) NOT NULL,
	[numeroExterior] [varchar](10) NOT NULL,
	[numeroInterior] [varchar](10) NOT NULL,
	[latitudDirecicon] [varchar](25) NOT NULL,
	[longitudDireccion] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Membresia]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Membresia](
	[idMembresia] [int] IDENTITY(1,1) NOT NULL,
	[descripcionMembresia] [varchar](100) NOT NULL,
	[descuentoMembresia] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMembresia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Pais]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Pais](
	[idPais] [int] IDENTITY(1,1) NOT NULL,
	[nombrePais] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Platillo]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Platillo](
	[idPlatillo] [int] IDENTITY(1,1) NOT NULL,
	[nombrePlatillo] [varchar](200) NOT NULL,
	[descripcionPlatillo] [varchar](2000) NOT NULL,
	[calificacionPlatillo] [float] NOT NULL,
	[numeroVisitas] [int] NOT NULL DEFAULT ((0)),
	[idPais] [int] NOT NULL,
	[imagenPlatillo] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlatillo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PlatilloHasCategoria]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PlatilloHasCategoria](
	[idPlatillo] [int] NOT NULL,
	[idCategoriaPlatillo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPlatillo] ASC,
	[idCategoriaPlatillo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Precio]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Precio](
	[idPrecio] [int] IDENTITY(1,1) NOT NULL,
	[descripcionPrecio] [varchar](200) NOT NULL,
	[cantidadPrecio] [money] NOT NULL,
	[idPlatillo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPrecio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Sucursal]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[nombreSucursal] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SucursalHasDireccion]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SucursalHasDireccion](
	[idDireccion] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idDireccion] ASC,
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tag]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tag](
	[IdTag] [int] IDENTITY(1,1) NOT NULL,
	[descripcionTag] [nvarchar](50) NOT NULL,
	[IdPlatillo] [int] NOT NULL,
 CONSTRAINT [PK_Tag] PRIMARY KEY CLUSTERED 
(
	[IdTag] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tarjeta]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Tarjeta](
	[idTarjeta] [int] IDENTITY(1,1) NOT NULL,
	[numeroTarjeta] [varchar](16) NOT NULL,
	[bancoTarjeta] [varchar](60) NOT NULL,
	[idTipo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoDeTarjeta]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoDeTarjeta](
	[idTipo] [int] IDENTITY(1,1) NOT NULL,
	[descripcionTipo] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 16/06/2017 12:16:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nickNameUsuario] [varchar](25) NOT NULL,
	[nombreUsuario] [varchar](35) NOT NULL,
	[apellidoPaternoUsuario] [char](35) NOT NULL,
	[apellidoMaternoUsuario] [char](35) NOT NULL,
	[fechaNacimientoUsuario] [datetime] NOT NULL,
	[correoUsuario] [varchar](35) NOT NULL,
	[passwordUsuario] [varchar](50) NOT NULL,
	[Id] [nvarchar](128) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'655583af-09a8-466f-8eb6-823c85f1c9d9', N'nico@gmail.com', 0, N'AJqD9Hyq2cdd6uKXLibs+jLFolh2ikQCT8GoscCva0iD5vVOEaE1lHnjgV/v4y1otw==', N'45374370-f84a-4f35-8e36-9c2a03d84ec9', NULL, 0, 0, NULL, 1, 0, N'nico@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a7e9064c-40f5-4724-83c9-054fa8d700b6', N'limbo609@gmail.com', 0, N'ANxEUT06P7SpgkMNeaZzMTZXGDYC9BKLhbGJc0QV50xdBjTDv/TH9dmi+mRCsXmKlA==', N'de34f432-59bb-4ea5-90e6-31e4cc10f998', NULL, 0, 0, NULL, 1, 0, N'Limbo')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b15e8635-2cd4-452b-8fce-226bed18d431', N'jahazielg@gmail.com', 0, N'ABV5rlmg2kLa55f8vCB96RLcONc1x4rgMcUQu3c7vx5WNZbhptynEs4ioTirkgQpZg==', N'f482d1c0-d259-4770-8737-1eb1c6e63b1a', NULL, 0, 0, NULL, 1, 0, N'Jahaziel')
SET IDENTITY_INSERT [dbo].[Consumidor] ON 

INSERT [dbo].[Consumidor] ([idConsumidor], [idMembresia], [idTarjeta], [IdUsuario]) VALUES (1, NULL, NULL, 2)
INSERT [dbo].[Consumidor] ([idConsumidor], [idMembresia], [idTarjeta], [IdUsuario]) VALUES (2, NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[Consumidor] OFF
SET IDENTITY_INSERT [dbo].[Direccion] ON 

INSERT [dbo].[Direccion] ([idDireccion], [municipioDireccion], [coloniaDireccion], [calleDireccion], [numeroExterior], [numeroInterior], [latitudDirecicon], [longitudDireccion]) VALUES (1, N'Oaxaca de Juarez', N'Centro', N'Reforma', N'25', N'A-2', N'17.063411', N'-96.722258')
INSERT [dbo].[Direccion] ([idDireccion], [municipioDireccion], [coloniaDireccion], [calleDireccion], [numeroExterior], [numeroInterior], [latitudDirecicon], [longitudDireccion]) VALUES (2, N'Centro', N'El Retiro', N'Gerardo Varela', N'8', N'', N'17.082852', N'-96.719895')
INSERT [dbo].[Direccion] ([idDireccion], [municipioDireccion], [coloniaDireccion], [calleDireccion], [numeroExterior], [numeroInterior], [latitudDirecicon], [longitudDireccion]) VALUES (3, N'Centro', N'Reforma', N'Sabinos', N'192', N'', N'17.077066', N'-96.713069')
SET IDENTITY_INSERT [dbo].[Direccion] OFF
SET IDENTITY_INSERT [dbo].[Pais] ON 

INSERT [dbo].[Pais] ([idPais], [nombrePais]) VALUES (1, N'Japón')
INSERT [dbo].[Pais] ([idPais], [nombrePais]) VALUES (2, N'Tailandia')
INSERT [dbo].[Pais] ([idPais], [nombrePais]) VALUES (3, N'China')
SET IDENTITY_INSERT [dbo].[Pais] OFF
SET IDENTITY_INSERT [dbo].[Platillo] ON 

INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (1, N'Roti canai', N' El roti canai es un panqueque de origen indio que se acompaña con curry de lentejas', 4, 10, 2, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/1-roti-canai.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (2, N'Nasi padang', N'El nasi padang no es un plato en sí, sino un tipo de cocina en el que se usa mucho curry. Eso sí, es muy picante (sobre todo para mí, que antes de salir de Argentina casi ni había probado un ají), pero tan rico…', 5, 15, 3, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/2-nasi-padang.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (3, N'Pad Thai', N'Se prepara al wok y sus ingredientes son fideos de arroz con huevo, salsa de tamarindo, pimiento rojo, salsa de pescado, brotes de soja, gambas, pollo, cilantro, jugo de lima y maní', 5, 3, 3, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/3-pad-thai.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (4, N'Char kway teow', N'El char kway teow es un plato chino muy popular que se hace con fideos chatos, salsa de soja, ají, gambas, berberechos, huevo y ajo. Buena opción para pedir en cualquier puesto de comida china.', 4, 11, 3, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/4-Char-kway-teow.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (5, N'Banana Leaf Set', N'Es muy picante, se come con la mano derecha y, al terminar, la hoja se dobla hacia adentro si la comida fue satisfactoria o hacia afuera si no fue buena.', 3, 6, 2, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/6-banana-leaf-set.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (6, N'Sushi', N' Es una comida sana, fresca y liviana, lo único malo es que se termina demasiado rápido. Podría vivir a base de sushi sin ningún problema (eso sí, necesitaría, mínimamente, un sponsor que me lo provea).', 5, 1, 1, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2011/12/7-sushi.jpg')
INSERT [dbo].[Platillo] ([idPlatillo], [nombrePlatillo], [descripcionPlatillo], [calificacionPlatillo], [numeroVisitas], [idPais], [imagenPlatillo]) VALUES (7, N'Nám tok', N'A menudo se sirve en sopa, o en otra versión, una preparación que se parece a una ensalada con arroz tostado y molido, chiles, salsa de pescado, jugo de limón, cebolla y hojas de menta', 5, 5, 2, N'https://viajes.101lugaresincreibles.com/wp-content/uploads/2014/11/comida-tipica-tailandia-e1416595528577.jpg')
SET IDENTITY_INSERT [dbo].[Platillo] OFF
SET IDENTITY_INSERT [dbo].[Precio] ON 

INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (1, N'Mediano', 85.0000, 1)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (2, N'Grande', 120.0000, 1)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (3, N'Mediano', 120.0000, 2)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (4, N'Grande', 148.0000, 2)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (5, N'Estandar', 90.0000, 3)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (6, N'Estandar', 78.0000, 5)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (7, N'Medio Rollo', 95.0000, 6)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (8, N'Rollo Completo', 180.0000, 6)
INSERT [dbo].[Precio] ([idPrecio], [descripcionPrecio], [cantidadPrecio], [idPlatillo]) VALUES (9, N'Estandar', 110.0000, 7)
SET IDENTITY_INSERT [dbo].[Precio] OFF
SET IDENTITY_INSERT [dbo].[Tag] ON 

INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (1, N'Verduras', 1)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (2, N'Carne', 1)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (3, N'Fresco', 2)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (4, N'A la plancha', 2)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (5, N'Al vapor', 2)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (6, N'A las brasas', 3)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (7, N'tentempié', 3)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (8, N'Dulce', 4)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (9, N'Nuevo', 4)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (10, N'Fruta', 5)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (11, N'Dulce', 5)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (12, N'Sushi', 6)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (13, N'Arroz', 6)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (14, N'Tradicional', 6)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (15, N'Vegetariano', 7)
INSERT [dbo].[Tag] ([IdTag], [descripcionTag], [IdPlatillo]) VALUES (16, N'Típico', 7)
SET IDENTITY_INSERT [dbo].[Tag] OFF
SET IDENTITY_INSERT [dbo].[TipoDeTarjeta] ON 

INSERT [dbo].[TipoDeTarjeta] ([idTipo], [descripcionTipo]) VALUES (1, N'Débito')
INSERT [dbo].[TipoDeTarjeta] ([idTipo], [descripcionTipo]) VALUES (2, N'Crédito')
SET IDENTITY_INSERT [dbo].[TipoDeTarjeta] OFF
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([IdUsuario], [nickNameUsuario], [nombreUsuario], [apellidoPaternoUsuario], [apellidoMaternoUsuario], [fechaNacimientoUsuario], [correoUsuario], [passwordUsuario], [Id]) VALUES (1, N'Limbo', N'Lino Alejandro', N'Arango                             ', N'Cruz                               ', CAST(N'1995-05-29 00:00:00.000' AS DateTime), N'limbo609@gmail.com', N'L.d.c.n.140832', N'a7e9064c-40f5-4724-83c9-054fa8d700b6')
INSERT [dbo].[Usuario] ([IdUsuario], [nickNameUsuario], [nombreUsuario], [apellidoPaternoUsuario], [apellidoMaternoUsuario], [fechaNacimientoUsuario], [correoUsuario], [passwordUsuario], [Id]) VALUES (2, N'nico@gmail.com', N'Nicolai', N'Arango                             ', N'Negrete                            ', CAST(N'2015-06-06 00:00:00.000' AS DateTime), N'nico@gmail.com', N'Nico_1', N'655583af-09a8-466f-8eb6-823c85f1c9d9')
INSERT [dbo].[Usuario] ([IdUsuario], [nickNameUsuario], [nombreUsuario], [apellidoPaternoUsuario], [apellidoMaternoUsuario], [fechaNacimientoUsuario], [correoUsuario], [passwordUsuario], [Id]) VALUES (3, N'Jahaziel', N'ffdas', N'daf                                ', N'fdsa                               ', CAST(N'1990-12-12 00:00:00.000' AS DateTime), N'jahazielg@gmail.com', N'Qw123456$', N'b15e8635-2cd4-452b-8fce-226bed18d431')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Tarjeta__FBAB949F929DA5BD]    Script Date: 16/06/2017 12:16:26 ******/
ALTER TABLE [dbo].[Tarjeta] ADD UNIQUE NONCLUSTERED 
(
	[numeroTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__Usuario__F25EB4FBBE022215]    Script Date: 16/06/2017 12:16:26 ******/
ALTER TABLE [dbo].[Usuario] ADD UNIQUE NONCLUSTERED 
(
	[nickNameUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Calificacion]  WITH CHECK ADD FOREIGN KEY([idPlatillo])
REFERENCES [dbo].[Platillo] ([idPlatillo])
GO
ALTER TABLE [dbo].[Calificacion]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[Carrito]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[CatalogoCarrito]  WITH CHECK ADD FOREIGN KEY([idCarrito])
REFERENCES [dbo].[Carrito] ([idCarrito])
GO
ALTER TABLE [dbo].[CatalogoCarrito]  WITH CHECK ADD FOREIGN KEY([idPlatillo])
REFERENCES [dbo].[Platillo] ([idPlatillo])
GO
ALTER TABLE [dbo].[Comentario]  WITH CHECK ADD FOREIGN KEY([idCalificacion])
REFERENCES [dbo].[Calificacion] ([idCalificacion])
GO
ALTER TABLE [dbo].[Consumidor]  WITH CHECK ADD FOREIGN KEY([idMembresia])
REFERENCES [dbo].[Membresia] ([idMembresia])
GO
ALTER TABLE [dbo].[Consumidor]  WITH CHECK ADD FOREIGN KEY([idTarjeta])
REFERENCES [dbo].[Tarjeta] ([idTarjeta])
GO
ALTER TABLE [dbo].[Consumidor]  WITH CHECK ADD FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[Usuario] ([IdUsuario])
GO
ALTER TABLE [dbo].[ConsumidorHasDireccion]  WITH CHECK ADD FOREIGN KEY([idConsumidor])
REFERENCES [dbo].[Consumidor] ([idConsumidor])
GO
ALTER TABLE [dbo].[ConsumidorHasDireccion]  WITH CHECK ADD FOREIGN KEY([idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[Platillo]  WITH CHECK ADD FOREIGN KEY([idPais])
REFERENCES [dbo].[Pais] ([idPais])
GO
ALTER TABLE [dbo].[PlatilloHasCategoria]  WITH CHECK ADD FOREIGN KEY([idCategoriaPlatillo])
REFERENCES [dbo].[CategoriaPlatillo] ([idCategoriaPlatillo])
GO
ALTER TABLE [dbo].[PlatilloHasCategoria]  WITH CHECK ADD FOREIGN KEY([idPlatillo])
REFERENCES [dbo].[Platillo] ([idPlatillo])
GO
ALTER TABLE [dbo].[Precio]  WITH CHECK ADD FOREIGN KEY([idPlatillo])
REFERENCES [dbo].[Platillo] ([idPlatillo])
GO
ALTER TABLE [dbo].[SucursalHasDireccion]  WITH CHECK ADD FOREIGN KEY([idDireccion])
REFERENCES [dbo].[Direccion] ([idDireccion])
GO
ALTER TABLE [dbo].[SucursalHasDireccion]  WITH CHECK ADD FOREIGN KEY([idSucursal])
REFERENCES [dbo].[Sucursal] ([idSucursal])
GO
ALTER TABLE [dbo].[Tag]  WITH CHECK ADD  CONSTRAINT [FK_Tag_Platillo] FOREIGN KEY([IdPlatillo])
REFERENCES [dbo].[Platillo] ([idPlatillo])
GO
ALTER TABLE [dbo].[Tag] CHECK CONSTRAINT [FK_Tag_Platillo]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD FOREIGN KEY([idTipo])
REFERENCES [dbo].[TipoDeTarjeta] ([idTipo])
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
