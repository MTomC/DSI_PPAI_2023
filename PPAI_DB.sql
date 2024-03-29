USE [PPAI]
GO
/****** Object:  Table [dbo].[Accion]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_Accion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstado]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[fechaHoraInicio] [datetime] NOT NULL,
	[idLlamada] [int] NOT NULL,
	[idEstado] [int] NOT NULL,
 CONSTRAINT [PK_CambioEstado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriaLlamada]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriaLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajeOpciones] [varchar](50) NULL,
	[mensajeOpciones] [varchar](50) NULL,
 CONSTRAINT [PK_CategoriaLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[nroCelular] [int] NULL,
 CONSTRAINT [PK_Cliente_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [nchar](10) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InformacionCliente]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InformacionCliente](
	[idInfoCliente] [int] NOT NULL,
	[datoAValidar] [varchar](50) NOT NULL,
	[idOpcionCorrecta] [int] NOT NULL,
	[idValidacion] [int] NOT NULL,
	[tipo] [varchar](50) NOT NULL,
	[idCliente] [int] NOT NULL,
 CONSTRAINT [PK_InformacionCliente] PRIMARY KEY CLUSTERED 
(
	[idInfoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Llamada]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Llamada](
	[idLlamada] [int] IDENTITY(1,1) NOT NULL,
	[descripcionOperador] [nchar](100) NULL,
	[detalleAccionRequerida] [nchar](100) NULL,
	[duracion] [time](7) NULL,
	[encuestaEnviada] [bit] NULL,
	[observacionAuditor] [nchar](100) NULL,
	[idCliente] [int] NOT NULL,
	[idAccion] [int] NULL,
	[idSubOpcionLlamada] [int] NULL,
	[idOpcionLlamada] [int] NULL,
	[idUsuario] [int] NOT NULL,
 CONSTRAINT [PK_Llamada] PRIMARY KEY CLUSTERED 
(
	[idLlamada] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionLlamada]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajesSubopciones] [varchar](50) NULL,
	[mensajeSubopciones] [varchar](50) NULL,
	[idCategoria] [int] NOT NULL,
 CONSTRAINT [PK_OpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OpcionValidacion]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionValidacion](
	[idOpcionValidacion] [int] NOT NULL,
	[correcta] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[idValidacion] [int] NOT NULL,
 CONSTRAINT [PK_OpcionValidacion] PRIMARY KEY CLUSTERED 
(
	[idOpcionValidacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubOpcionLlamada]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubOpcionLlamada](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [nchar](10) NULL,
	[nombre] [varchar](50) NULL,
	[idOpcion] [int] NOT NULL,
 CONSTRAINT [PK_SubOpcionLlamada] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[activo] [bit] NULL,
	[fechaAlta] [date] NULL,
	[nombreUsuario] [varchar](50) NULL,
	[password] [varchar](50) NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Validacion]    Script Date: 2/6/2023 12:46:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Validacion](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nroOrden] [int] NULL,
	[nombre] [varchar](50) NULL,
	[audioMensajeValidacion] [varchar](50) NULL,
	[idOpcion] [int] NOT NULL,
	[idSubopcion] [int] NOT NULL,
 CONSTRAINT [PK_Validacion] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accion] ON 

INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (1, N'Denunciar un robo')
INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (2, N'Comunicar un saldo')
INSERT [dbo].[Accion] ([id], [descripcion]) VALUES (3, N'Dar de baja una tarjeta')
SET IDENTITY_INSERT [dbo].[Accion] OFF
GO
SET IDENTITY_INSERT [dbo].[CambioEstado] ON 

INSERT [dbo].[CambioEstado] ([id], [fechaHoraInicio], [idLlamada], [idEstado]) VALUES (3, CAST(N'2023-05-23T00:00:00.000' AS DateTime), 2, 1)
SET IDENTITY_INSERT [dbo].[CambioEstado] OFF
GO
SET IDENTITY_INSERT [dbo].[CategoriaLlamada] ON 

INSERT [dbo].[CategoriaLlamada] ([id], [nroOrden], [nombre], [audioMensajeOpciones], [mensajeOpciones]) VALUES (1, 1, N'Robo', NULL, NULL)
SET IDENTITY_INSERT [dbo].[CategoriaLlamada] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 

INSERT [dbo].[Cliente] ([id], [dni], [nombre], [apellido], [nroCelular]) VALUES (1, 12312312, N'Juan', N'Gutierrez', 153351153)
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Estado] ON 

INSERT [dbo].[Estado] ([id], [nombre]) VALUES (1, N'Iniciada  ')
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (2, N'EnCurso   ')
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (3, N'Finalizada')
INSERT [dbo].[Estado] ([id], [nombre]) VALUES (4, N'Cancelada ')
SET IDENTITY_INSERT [dbo].[Estado] OFF
GO
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (1, N'Cantidad de hijos', 1, 1, N'cantidad', 1)
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (2, N'Nombre de mascota', 2, 2, N'nombre', 1)
INSERT [dbo].[InformacionCliente] ([idInfoCliente], [datoAValidar], [idOpcionCorrecta], [idValidacion], [tipo], [idCliente]) VALUES (3, N'Edad', 3, 3, N'cantidad', 1)
GO
SET IDENTITY_INSERT [dbo].[Llamada] ON 

INSERT [dbo].[Llamada] ([idLlamada], [descripcionOperador], [detalleAccionRequerida], [duracion], [encuestaEnviada], [observacionAuditor], [idCliente], [idAccion], [idSubOpcionLlamada], [idOpcionLlamada], [idUsuario]) VALUES (2, N'Ha sido confirmada...                                                                               ', N'Denunciar un robo                                                                                   ', CAST(N'00:00:19.5794327' AS Time), 0, N'                                                                                                    ', 1, 1, 1, 1, 1)
SET IDENTITY_INSERT [dbo].[Llamada] OFF
GO
SET IDENTITY_INSERT [dbo].[OpcionLlamada] ON 

INSERT [dbo].[OpcionLlamada] ([id], [nroOrden], [nombre], [audioMensajesSubopciones], [mensajeSubopciones], [idCategoria]) VALUES (1, 1, N'Solicitar nueva tarjeta', NULL, NULL, 1)
SET IDENTITY_INSERT [dbo].[OpcionLlamada] OFF
GO
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (1, N'2', N'2', 1)
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (2, N'Ramses', N'Ramses', 2)
INSERT [dbo].[OpcionValidacion] ([idOpcionValidacion], [correcta], [descripcion], [idValidacion]) VALUES (3, N'32', N'32', 3)
GO
SET IDENTITY_INSERT [dbo].[SubOpcionLlamada] ON 

INSERT [dbo].[SubOpcionLlamada] ([id], [nroOrden], [nombre], [idOpcion]) VALUES (1, N'1         ', N'Comunicarse con Operador', 1)
SET IDENTITY_INSERT [dbo].[SubOpcionLlamada] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id], [activo], [fechaAlta], [nombreUsuario], [password]) VALUES (1, NULL, NULL, N'r2d2', NULL)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Validacion] ON 

INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (1, 1, N'Cantidad de hijos', NULL, 1, 1)
INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (2, 2, N'Nombre de mascota', NULL, 1, 1)
INSERT [dbo].[Validacion] ([id], [nroOrden], [nombre], [audioMensajeValidacion], [idOpcion], [idSubopcion]) VALUES (3, 3, N'Edad', NULL, 1, 1)
SET IDENTITY_INSERT [dbo].[Validacion] OFF
GO
ALTER TABLE [dbo].[CambioEstado]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstado_Estado] FOREIGN KEY([idEstado])
REFERENCES [dbo].[Estado] ([id])
GO
ALTER TABLE [dbo].[CambioEstado] CHECK CONSTRAINT [FK_CambioEstado_Estado]
GO
ALTER TABLE [dbo].[CambioEstado]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstado_Llamada] FOREIGN KEY([idLlamada])
REFERENCES [dbo].[Llamada] ([idLlamada])
GO
ALTER TABLE [dbo].[CambioEstado] CHECK CONSTRAINT [FK_CambioEstado_Llamada]
GO
ALTER TABLE [dbo].[InformacionCliente]  WITH CHECK ADD  CONSTRAINT [fk_informacion_opcionValidacion] FOREIGN KEY([idOpcionCorrecta])
REFERENCES [dbo].[OpcionValidacion] ([idOpcionValidacion])
GO
ALTER TABLE [dbo].[InformacionCliente] CHECK CONSTRAINT [fk_informacion_opcionValidacion]
GO
ALTER TABLE [dbo].[InformacionCliente]  WITH CHECK ADD  CONSTRAINT [fk_informacionCliente_cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[InformacionCliente] CHECK CONSTRAINT [fk_informacionCliente_cliente]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Accion] FOREIGN KEY([idAccion])
REFERENCES [dbo].[Accion] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Accion]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Cliente]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_OpcionLlamada] FOREIGN KEY([idOpcionLlamada])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_OpcionLlamada]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [fk_llamada_subopcion] FOREIGN KEY([idSubOpcionLlamada])
REFERENCES [dbo].[SubOpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [fk_llamada_subopcion]
GO
ALTER TABLE [dbo].[Llamada]  WITH CHECK ADD  CONSTRAINT [FK_Llamada_Usuario] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([id])
GO
ALTER TABLE [dbo].[Llamada] CHECK CONSTRAINT [FK_Llamada_Usuario]
GO
ALTER TABLE [dbo].[OpcionLlamada]  WITH CHECK ADD  CONSTRAINT [fk_opcion_categoria] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[CategoriaLlamada] ([id])
GO
ALTER TABLE [dbo].[OpcionLlamada] CHECK CONSTRAINT [fk_opcion_categoria]
GO
ALTER TABLE [dbo].[OpcionValidacion]  WITH CHECK ADD  CONSTRAINT [fk_opcionValidacion_validacion] FOREIGN KEY([idValidacion])
REFERENCES [dbo].[Validacion] ([id])
GO
ALTER TABLE [dbo].[OpcionValidacion] CHECK CONSTRAINT [fk_opcionValidacion_validacion]
GO
ALTER TABLE [dbo].[SubOpcionLlamada]  WITH CHECK ADD  CONSTRAINT [fk_subopcion_opcion] FOREIGN KEY([idOpcion])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[SubOpcionLlamada] CHECK CONSTRAINT [fk_subopcion_opcion]
GO
ALTER TABLE [dbo].[Validacion]  WITH CHECK ADD  CONSTRAINT [fk_validacion_opcion] FOREIGN KEY([idOpcion])
REFERENCES [dbo].[OpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Validacion] CHECK CONSTRAINT [fk_validacion_opcion]
GO
ALTER TABLE [dbo].[Validacion]  WITH CHECK ADD  CONSTRAINT [fk_validacion_subopcion] FOREIGN KEY([idSubopcion])
REFERENCES [dbo].[SubOpcionLlamada] ([id])
GO
ALTER TABLE [dbo].[Validacion] CHECK CONSTRAINT [fk_validacion_subopcion]
GO
