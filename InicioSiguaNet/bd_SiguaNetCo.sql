-- INSTRUCCIONES PARA CORRERLO
--Primero correr        CREATE DATABASE [bd_SiguaNet]
--Segundo correr		USE [bd_SiguaNet]
--Tercero correr		CREATE SCHEMA [ges]
--Cuarto correr			TODO, excepto los primeros TRES pasos



USE [master]
GO
/****** Object:  Database [bd_SiguaNet]    Script Date: 30/7/2020 02:10:03 ******/
CREATE DATABASE [bd_SiguaNet]
go
USE [bd_SiguaNet]
GO
/****** Object:  Schema [ges]    Script Date: 30/7/2020 02:10:03 ******/
CREATE SCHEMA [ges]
GO
/****** Object:  Table [dbo].[ADMINISTRADORES]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINISTRADORES](
	[numeroIdentidad] [varchar](13) NOT NULL,
	[contrasena] [nvarchar](80) NOT NULL,
	[correo] [nvarchar](50) NULL,
 CONSTRAINT [PK_ADMINISTRADORES] PRIMARY KEY CLUSTERED 
(
	[numeroIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CLIENTES]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CLIENTES](
	[numeroIdentidad] [varchar](13) NOT NULL,
	[idPaquete] [int] NOT NULL,
	[pagosCliente] [int] NOT NULL,
	[estadoC] [varchar](30) NOT NULL,
 CONSTRAINT [PK_CLIENTES] PRIMARY KEY CLUSTERED 
(
	[numeroIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DATOS_PERSONAS]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DATOS_PERSONAS](
	[numeroIdentidad] [varchar](13) NOT NULL,
	[nombres] [varchar](25) NOT NULL,
	[primerApellido] [varchar](15) NOT NULL,
	[segundoApellido] [varchar](15) NULL,
	[numeroTelefono] [int] NOT NULL,
	[numeroCasa] [int] NOT NULL,
	[idSector] [int] NOT NULL,
	[referenciasDireccion] [varchar](80) NULL,
 CONSTRAINT [PK_DATOS_PERSONAS] PRIMARY KEY CLUSTERED 
(
	[numeroIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FACTURA]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURA](
	[idFactura] [int] IDENTITY(1,1) NOT NULL,
	[numeroIdentidadC] [varchar](13) NOT NULL,
	[fechaPago] [varchar](25) NOT NULL,
	[mesPago] [varchar](20) NULL,
 CONSTRAINT [PK_FACTURA] PRIMARY KEY CLUSTERED 
(
	[idFactura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GESTION_TICKETS]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GESTION_TICKETS](
	[idTicket] [int] IDENTITY(1,1) NOT NULL,
	[numeroIdentidadC] [varchar](13) NOT NULL,
	[idPersonal] [int] NOT NULL,
	[estado] [varchar](20) NOT NULL,
	[Prioridad] [varchar](30) NULL,
	[idOperacion] [int] NOT NULL,
	[notas] [varchar](120) NULL,
	[fechaInicio] [varchar](25) NOT NULL,
	[fechaFin] [varchar](25) NULL,
 CONSTRAINT [PK_GESTION_TICKETS] PRIMARY KEY CLUSTERED 
(
	[idTicket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INVENTARIO]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INVENTARIO](
	[idTipoAparato] [int] IDENTITY(1,1) NOT NULL,
	[nombreTipo] [varchar](20) NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_INVENTARIO] PRIMARY KEY CLUSTERED 
(
	[idTipoAparato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OPERACIONES]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OPERACIONES](
	[idOperacion] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](80) NULL,
	[nombreOperacion] [varchar](40) NOT NULL,
 CONSTRAINT [PK_OPERACIONES] PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAL]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAL](
	[idPersonal] [int] IDENTITY(1,1) NOT NULL,
	[numeroIdentidad] [varchar](13) NOT NULL,
	[idVehiculo] [int] NULL,
	[estado] [varchar](15) NOT NULL,
 CONSTRAINT [PK_PERSONAL_1] PRIMARY KEY CLUSTERED 
(
	[idPersonal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PLANES_INTERNET]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PLANES_INTERNET](
	[idPaquete] [int] IDENTITY(1,1) NOT NULL,
	[nombrePaquete] [varchar](40) NOT NULL,
	[velocidad] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_PLANES_INTERNET] PRIMARY KEY CLUSTERED 
(
	[idPaquete] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECURSOS_MOTORES]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECURSOS_MOTORES](
	[idVehiculo] [int] IDENTITY(1,1) NOT NULL,
	[matricula] [varchar](8) NOT NULL,
	[modelo] [varchar](40) NOT NULL,
 CONSTRAINT [PK_RECURSOS_MOTORES] PRIMARY KEY CLUSTERED 
(
	[idVehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SECTORES]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SECTORES](
	[idSector] [int] IDENTITY(1,1) NOT NULL,
	[barrio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_SECTORES] PRIMARY KEY CLUSTERED 
(
	[idSector] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[DATOS_PERSONAS] ([numeroIdentidad], [nombres], [primerApellido], [segundoApellido], [numeroTelefono], [numeroCasa], [idSector], [referenciasDireccion]) VALUES (N'1208199300145', N'Geovany Manuel', N'Sanchez', N'Gutierres', 99345687, 25, 1, N'Contiguo a farmacia Siman')
GO
INSERT [dbo].[DATOS_PERSONAS] ([numeroIdentidad], [nombres], [primerApellido], [segundoApellido], [numeroTelefono], [numeroCasa], [idSector], [referenciasDireccion]) VALUES (N'1208199500367', N'Francisco Jose', N'Martinez', N'Obrador', 87345687, 18, 4, N'Contiguo a farmacia Siman')
GO
SET IDENTITY_INSERT [dbo].[INVENTARIO] ON 
GO
INSERT [dbo].[INVENTARIO] ([idTipoAparato], [nombreTipo], [cantidad]) VALUES (1, N'Enrutadores', 20)
GO
INSERT [dbo].[INVENTARIO] ([idTipoAparato], [nombreTipo], [cantidad]) VALUES (2, N'Antenas', 20)
GO
SET IDENTITY_INSERT [dbo].[INVENTARIO] OFF
GO
SET IDENTITY_INSERT [dbo].[OPERACIONES] ON 
GO
INSERT [dbo].[OPERACIONES] ([idOperacion], [descripcion], [nombreOperacion]) VALUES (1, N'Instalación del servicio por primera vez', N'Instalación')
GO
INSERT [dbo].[OPERACIONES] ([idOperacion], [descripcion], [nombreOperacion]) VALUES (2, N'Se hace el cambio del cliente a otro paquete', N'Actualización')
GO
INSERT [dbo].[OPERACIONES] ([idOperacion], [descripcion], [nombreOperacion]) VALUES (3, N'Se le da soporte a los componentes que sean necesarios', N'Soporte técnico')
GO
INSERT [dbo].[OPERACIONES] ([idOperacion], [descripcion], [nombreOperacion]) VALUES (4, N'Se realiza un corte de nuestro servicio', N'Corte por solicitud')
GO
SET IDENTITY_INSERT [dbo].[OPERACIONES] OFF
GO
SET IDENTITY_INSERT [dbo].[PERSONAL] ON 
GO
INSERT [dbo].[PERSONAL] ([idPersonal], [numeroIdentidad], [idVehiculo], [estado]) VALUES (1, N'1208199300145', NULL, N'Libre')
GO
INSERT [dbo].[PERSONAL] ([idPersonal], [numeroIdentidad], [idVehiculo], [estado]) VALUES (2, N'1208199500367', NULL, N'Libre')
GO
SET IDENTITY_INSERT [dbo].[PERSONAL] OFF
GO
SET IDENTITY_INSERT [dbo].[PLANES_INTERNET] ON 
GO
INSERT [dbo].[PLANES_INTERNET] ([idPaquete], [nombrePaquete], [velocidad], [precio]) VALUES (1, N'Paquete básico', 6, 800)
GO
INSERT [dbo].[PLANES_INTERNET] ([idPaquete], [nombrePaquete], [velocidad], [precio]) VALUES (2, N'Paquete avanzado', 15, 1200)
GO
INSERT [dbo].[PLANES_INTERNET] ([idPaquete], [nombrePaquete], [velocidad], [precio]) VALUES (3, N'Paquete plus', 20, 2500)
GO
INSERT [dbo].[PLANES_INTERNET] ([idPaquete], [nombrePaquete], [velocidad], [precio]) VALUES (4, N'Fibra optica', 45, 3800)
GO
SET IDENTITY_INSERT [dbo].[PLANES_INTERNET] OFF
GO
SET IDENTITY_INSERT [dbo].[RECURSOS_MOTORES] ON 
GO
INSERT [dbo].[RECURSOS_MOTORES] ([idVehiculo], [matricula], [modelo]) VALUES (1, N'SFK-429', N'Ford Ranger')
GO
INSERT [dbo].[RECURSOS_MOTORES] ([idVehiculo], [matricula], [modelo]) VALUES (2, N'RTX-267', N'Ford Ranger 4x4')
GO
INSERT [dbo].[RECURSOS_MOTORES] ([idVehiculo], [matricula], [modelo]) VALUES (3, N'DHG-814', N'Nissan Frontier')
GO
SET IDENTITY_INSERT [dbo].[RECURSOS_MOTORES] OFF
GO
SET IDENTITY_INSERT [dbo].[SECTORES] ON 
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (1, N'Cede Central')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (2, N'San Miguel')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (3, N'San Juan')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (4, N'El Porvenir')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (5, N'El Carmen')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (6, N'La Potra')
GO
INSERT [dbo].[SECTORES] ([idSector], [barrio]) VALUES (7, N'Los Profesores')
GO
SET IDENTITY_INSERT [dbo].[SECTORES] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_PERSONAL]    Script Date: 30/7/2020 02:10:03 ******/
ALTER TABLE [dbo].[PERSONAL] ADD  CONSTRAINT [IX_PERSONAL] UNIQUE NONCLUSTERED 
(
	[numeroIdentidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ADMINISTRADORES]  WITH CHECK ADD  CONSTRAINT [FK_ADMINISTRADORES_PERSONAL] FOREIGN KEY([numeroIdentidad])
REFERENCES [dbo].[PERSONAL] ([numeroIdentidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ADMINISTRADORES] CHECK CONSTRAINT [FK_ADMINISTRADORES_PERSONAL]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_DATOS_PERSONAS] FOREIGN KEY([numeroIdentidad])
REFERENCES [dbo].[DATOS_PERSONAS] ([numeroIdentidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES_DATOS_PERSONAS]
GO
ALTER TABLE [dbo].[CLIENTES]  WITH CHECK ADD  CONSTRAINT [FK_CLIENTES_PLANES_INTERNET] FOREIGN KEY([idPaquete])
REFERENCES [dbo].[PLANES_INTERNET] ([idPaquete])
GO
ALTER TABLE [dbo].[CLIENTES] CHECK CONSTRAINT [FK_CLIENTES_PLANES_INTERNET]
GO
ALTER TABLE [dbo].[DATOS_PERSONAS]  WITH CHECK ADD  CONSTRAINT [FK_DATOS_PERSONAS_SECTORES] FOREIGN KEY([idSector])
REFERENCES [dbo].[SECTORES] ([idSector])
GO
ALTER TABLE [dbo].[DATOS_PERSONAS] CHECK CONSTRAINT [FK_DATOS_PERSONAS_SECTORES]
GO
ALTER TABLE [dbo].[FACTURA]  WITH CHECK ADD  CONSTRAINT [FK_FACTURA_CLIENTES] FOREIGN KEY([numeroIdentidadC])
REFERENCES [dbo].[CLIENTES] ([numeroIdentidad])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[FACTURA] CHECK CONSTRAINT [FK_FACTURA_CLIENTES]
GO
ALTER TABLE [dbo].[GESTION_TICKETS]  WITH CHECK ADD  CONSTRAINT [FK_GESTION_TICKETS_CLIENTES] FOREIGN KEY([numeroIdentidadC])
REFERENCES [dbo].[CLIENTES] ([numeroIdentidad])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[GESTION_TICKETS] CHECK CONSTRAINT [FK_GESTION_TICKETS_CLIENTES]
GO
ALTER TABLE [dbo].[GESTION_TICKETS]  WITH CHECK ADD  CONSTRAINT [FK_GESTION_TICKETS_OPERACIONES] FOREIGN KEY([idOperacion])
REFERENCES [dbo].[OPERACIONES] ([idOperacion])
GO
ALTER TABLE [dbo].[GESTION_TICKETS] CHECK CONSTRAINT [FK_GESTION_TICKETS_OPERACIONES]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_DATOS_PERSONAS] FOREIGN KEY([numeroIdentidad])
REFERENCES [dbo].[DATOS_PERSONAS] ([numeroIdentidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PERSONAL_DATOS_PERSONAS]
GO
ALTER TABLE [dbo].[PERSONAL]  WITH CHECK ADD  CONSTRAINT [FK_PERSONAL_RECURSOS_MOTORES] FOREIGN KEY([idVehiculo])
REFERENCES [dbo].[RECURSOS_MOTORES] ([idVehiculo])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[PERSONAL] CHECK CONSTRAINT [FK_PERSONAL_RECURSOS_MOTORES]
GO
/****** Object:  StoredProcedure [dbo].[consultaDatosTecnico]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaDatosTecnico](@idPersonal int)
as begin

	select CONCAT(DP.nombres, ' ', DP.primerApellido) as 'Nombre', DP.numeroTelefono as 'Teléfono' from DATOS_PERSONAS DP
		inner join PERSONAL PE 
		on DP.numeroIdentidad = PE.numeroIdentidad 
		where PE.idPersonal = @idPersonal and DP.numeroIdentidad = PE.numeroIdentidad and PE.estado <> 'Eliminado'
end
GO
/****** Object:  StoredProcedure [dbo].[consultaEstadoTickets]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaEstadoTickets](@codigoOP int)
as begin

 if @codigoOP = 1
	begin
		select gt.idTicket as 'Id ticket', gt.estado as 'Estado ticket', gt.Prioridad as 'Prioridad operación', dp.numeroIdentidad as 'Identidad Cliente', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre Cliente', 
	op.idOperacion as 'Id Operacion', op.nombreOperacion as 'Nombre Operacion', gt.notas as 'Notas ticket',   pli.nombrePaquete as 'Paquete', cl.pagosCliente as 'Cant Pagos Cliente',
	op.descripcion as 'Descripcion Operacion', p.idPersonal as 'Id personal' ,CONCAT(dpp.nombres, ' ', dpp.primerApellido) as 'Nombre Empleado', fechaInicio as 'Fecha Inicio', fechaFin as 'Fecha Fin'
			from OPERACIONES op 
			inner join GESTION_TICKETS gt on op.idOperacion = gt.idOperacion
			inner join CLIENTES cl on gt.numeroIdentidadC = cl.numeroIdentidad
			inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad 
			inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete
			inner join PERSONAL p on gt.idPersonal = p.idPersonal
			inner join DATOS_PERSONAS dpp on p.numeroIdentidad = dpp.numeroIdentidad
			where gt.estado = 'Realizado'
			end
	if @codigoOP = 2
	begin
		select gt.idTicket as 'Id ticket', gt.estado as 'Estado ticket', gt.Prioridad as 'Prioridad operación', dp.numeroIdentidad as 'Identidad Cliente', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre Cliente', 
	op.idOperacion as 'Id Operacion', op.nombreOperacion as 'Nombre Operacion', gt.notas as 'Notas Ticket',   pli.nombrePaquete as 'Paquete', cl.pagosCliente as 'Cant Pagos Cliente',
	op.descripcion as 'Descripcion Operacion', p.idPersonal as 'Id personal', CONCAT(dpp.nombres, ' ', dpp.primerApellido) as 'Nombre Empleado', fechaInicio as 'Fecha Inicio', fechaFin as 'Fecha Fin'
			from OPERACIONES op 
			inner join GESTION_TICKETS gt on op.idOperacion = gt.idOperacion
			inner join CLIENTES cl on gt.numeroIdentidadC = cl.numeroIdentidad
			inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad 
			inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete
			inner join PERSONAL p on gt.idPersonal = p.idPersonal
			inner join DATOS_PERSONAS dpp on p.numeroIdentidad = dpp.numeroIdentidad
			where gt.estado = 'Pendiente' and cl.estadoC <> 'Eliminado'	
			end
end
GO
/****** Object:  StoredProcedure [dbo].[consultaInformacionCliente]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaInformacionCliente]( @numeroIdentidad varchar(13))
as begin
	
		if exists(select numeroIdentidad from CLIENTES WHERE numeroIdentidad = @numeroIdentidad and estadoC <> 'Eliminado') and 
				exists(select numeroIdentidad FROM DATOS_PERSONAS where numeroIdentidad = @numeroIdentidad)
		begin
			select CLI.numeroIdentidad as 'Numero de Indentidad', CONCAT(DP.nombres, ' ', DP.primerApellido, ' ', DP.segundoApellido) as 'Nombre', 
			DP.numeroTelefono as 'Numero Telefono', DP.referenciasDireccion as 'Referencias Direccion'from DATOS_PERSONAS DP
			inner join CLIENTES CLI
			on DP.numeroIdentidad = CLI.numeroIdentidad 
			where CLI.numeroIdentidad = @numeroIdentidad and CLI.estadoC <> 'Eliminado'
		end
		else
			raiserror('No existe un numero de identidad con ese valor, ¡por favor ingrese uno valido!',16,1)
end
GO
/****** Object:  StoredProcedure [dbo].[consultaInformacionClienteLety]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaInformacionClienteLety](@numeroIdentidad varchar(13))
as begin
	
		if exists(select numeroIdentidad from CLIENTES WHERE numeroIdentidad = @numeroIdentidad and estadoC <> 'Eliminado') and 
				exists(select numeroIdentidad FROM DATOS_PERSONAS where numeroIdentidad = @numeroIdentidad)
		begin
			select dp.numeroIdentidad as 'Numero de Indentidad', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre', 
			dp.numeroTelefono as 'Numero Telefono', dp.numeroCasa as 'Numero Casa', se.barrio as 'Barrio', 
			dp.referenciasDireccion as 'Referencias Direccion', pli.nombrePaquete as 'Precio Paquete', c.pagosCliente as 'Cant Pagos Cliente'  from SECTORES se
			inner join DATOS_PERSONAS dp on se.idSector = dp.idSector
			inner join CLIENTES c on dp.numeroIdentidad = c.numeroIdentidad
			inner join PLANES_INTERNET pli on c.idPaquete = pli.idPaquete 
			where dp.numeroIdentidad = @numeroIdentidad and c.estadoC <> 'Eliminado'
		end
		else
			raiserror('No existe un numero de identidad con ese valor, ¡por favor ingrese uno valido!',16,1)
end
GO
/****** Object:  StoredProcedure [dbo].[consultaInformacionClientes]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaInformacionClientes]
as begin
        select dp.numeroIdentidad as 'Numero de Indentidad', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre', 
            dp.numeroTelefono as 'Numero Telefono', dp.numeroCasa as 'Numero Casa', se.barrio as 'Barrio', 
            dp.referenciasDireccion as 'Referencias Direccion', pli.nombrePaquete as 'Precio Paquete', c.estadoC as 'Estado', c.pagosCliente as 'Cant Pagos Cliente'  from SECTORES se
            inner join DATOS_PERSONAS dp on se.idSector = dp.idSector
            inner join CLIENTES c on dp.numeroIdentidad = c.numeroIdentidad
            inner join PLANES_INTERNET pli on c.idPaquete = pli.idPaquete
			where c.estadoC <> 'Eliminado'
end
GO
/****** Object:  StoredProcedure [dbo].[consultaInformacionClienteTicket]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaInformacionClienteTicket]( @numeroIdentidad varchar(13))
as begin
	
		if exists(select numeroIdentidadC from GESTION_TICKETS WHERE numeroIdentidadC = @numeroIdentidad) and (select estadoC from CLIENTES WHERE numeroIdentidad = @numeroIdentidad) <> 'Eliminado'
		begin
			select gt.idTicket, gt.Prioridad, CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre Cliente', op.nombreOperacion as 'Nombre Operacion', gt.notas as 'Notas Ticket', pli.nombrePaquete as 'Paquete', cl.pagosCliente as 'Cant Pagos Cliente',
					op.descripcion as 'Descripcion Operacion', CONCAT(dpp.nombres, ' ', dpp.primerApellido) as 'Nombre Empleado', fechaInicio as 'Fecha Inicio', fechaFin as 'Fecha Fin'
					from OPERACIONES op 
					inner join GESTION_TICKETS gt on op.idOperacion = gt.idOperacion
					inner join CLIENTES cl on gt.numeroIdentidadC = cl.numeroIdentidad
					inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad 
					inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete
					inner join PERSONAL p on gt.idPersonal = p.idPersonal
					inner join DATOS_PERSONAS dpp on p.numeroIdentidad = dpp.numeroIdentidad where gt.numeroIdentidadC = @numeroIdentidad
		end
		else
			raiserror('No existe un numero de identidad con ese valor, ¡por favor ingrese uno valido!',16,1)
end
GO
/****** Object:  StoredProcedure [dbo].[consultaInformacionFacturas]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaInformacionFacturas]( @numeroIdentidad varchar(13))
as begin
	
		if exists(select numeroIdentidadC from FACTURA WHERE numeroIdentidadC = @numeroIdentidad) or exists(select numeroIdentidad from CLIENTES WHERE numeroIdentidad = @numeroIdentidad)
		begin
			select f.idFactura as 'ID Factura', f.numeroIdentidadC as 'Numero Identidad', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre', 
			pli.nombrePaquete as 'Nombre Paquete', pli.precio as 'Precio', f.fechaPago, f.mesPago as 'Mes Pago'  from FACTURA f
			inner join CLIENTES cl on f.numeroIdentidadC = cl.numeroIdentidad
			inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad
			inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete where f.numeroIdentidadC = @numeroIdentidad
		end
		else
			raiserror('No existe un numero de identidad con ese valor, ¡por favor ingrese uno valido!',16,1)
end
GO
/****** Object:  StoredProcedure [dbo].[consultaPaqueteCliente]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaPaqueteCliente](@numeroIdentidad varchar(13))
as begin
		
		select CLI.idPaquete, PLI.nombrePaquete, PLI.velocidad, PLI.precio
		from CLIENTES CLI
		inner join PLANES_INTERNET PLI on CLI.idPaquete = PLI.idPaquete 
		where CLI.numeroIdentidad  = @numeroIdentidad and CLI.idPaquete = PLI.idPaquete and CLI.estadoC <> 'Eliminado'
end
GO
/****** Object:  StoredProcedure [dbo].[consultaPersonal]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------------------------------------------PERSONAL----------------------------------------------------------------------------------
------------------CONSULTAS------------------------------------------
CREATE procedure [dbo].[consultaPersonal](@idPersonal int)
as begin
	if exists(select idPersonal from PERSONAL where idPersonal = @idPersonal and estado <> 'Eliminado')

		select CONCAT(DP.nombres, ' ', DP.primerApellido, ' ', DP.segundoApellido) as 'Nombre completo', PE.numeroIdentidad as 'Numero de Identidad',
		DP.numeroTelefono as 'Teléfono', DP.numeroCasa as 'Número de casa', DP.idSector as 'Número sector', 
		DP.referenciasDireccion as 'Referencias', PE.idVehiculo as 'Número vehiculo', PE.estado as 'Estado'
		from DATOS_PERSONAS DP

		inner join PERSONAL PE 
		on DP.numeroIdentidad = PE.numeroIdentidad 
		where PE.idPersonal = @idPersonal and PE.estado <> 'Eliminado'

	else
		raiserror('No existe personal con ese id, ¡por favor ingrese uno valido!',16,1)
End

GO
/****** Object:  StoredProcedure [dbo].[consultaRecursosMotores]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-----------------------------------------------------------------RECURSOS MOTORES----------------------------------------------------------------------
CREATE procedure [dbo].[consultaRecursosMotores](@idVehiculo int)
as begin 
	
	if exists(select idVehiculo from RECURSOS_MOTORES where idVehiculo = @idVehiculo)
	begin
		select PE.idPersonal as 'ID encargado', concat(DP.nombres, ' ', DP.primerApellido) as 'Encargado', 
		RM.idVehiculo as 'ID vehículo', RM.modelo as 'Modelo', RM.matricula as 'Matrícula' 
		from DATOS_PERSONAS DP
		
		inner join PERSONAL PE
		on DP.numeroIdentidad = PE.numeroIdentidad 
		inner join RECURSOS_MOTORES RM
		on PE.idVehiculo = RM.idVehiculo 
		where RM.idVehiculo = @idVehiculo and PE.estado <> 'Eliminado'
	end

	else
		raiserror('No existe un recurso motor con ese id, ¡por favor ingrese uno valido!',16,1)
End
GO
/****** Object:  StoredProcedure [dbo].[consultaTicketsClientes]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[consultaTicketsClientes] 
as begin
	select gt.idTicket as 'Id ticket', gt.estado as 'Estado ticket', gt.Prioridad as 'Prioridad operación', dp.numeroIdentidad as 'Identidad Cliente', CONCAT(dp.nombres, ' ', dp.primerApellido, ' ', dp.segundoApellido) as 'Nombre Cliente', 
	op.nombreOperacion as 'Nombre Operacion', gt.notas as 'Notas Ticket',   pli.nombrePaquete as 'Paquete', cl.pagosCliente as 'Cant Pagos Cliente',
	op.descripcion as 'Descripcion Operacion', CONCAT(dpp.nombres, ' ', dpp.primerApellido) as 'Nombre Empleado', fechaInicio as 'Fecha Inicio', fechaFin as 'Fecha Fin'
		from OPERACIONES op 
		inner join GESTION_TICKETS gt on op.idOperacion = gt.idOperacion
		inner join CLIENTES cl on gt.numeroIdentidadC = cl.numeroIdentidad
		inner join DATOS_PERSONAS dp on cl.numeroIdentidad = dp.numeroIdentidad 
		inner join PLANES_INTERNET pli on cl.idPaquete = pli.idPaquete
		inner join PERSONAL p on gt.idPersonal = p.idPersonal
		inner join DATOS_PERSONAS dpp on p.numeroIdentidad = dpp.numeroIdentidad
		where cl.estadoC <> 'Eliminado'
end
GO
/****** Object:  StoredProcedure [dbo].[consultaTodoPersonal]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[consultaTodoPersonal]
as begin
		select CONCAT(DP.nombres, ' ', DP.primerApellido, ' ', DP.segundoApellido) as 'Nombre completo', PE.numeroIdentidad as 'Numero de Identidad',
		DP.numeroTelefono as 'Teléfono', DP.numeroCasa as 'Número de casa', DP.idSector as 'Número sector', 
		DP.referenciasDireccion as 'Referencias', PE.idVehiculo as 'Número vehiculo', PE.estado as 'Estado'
		from DATOS_PERSONAS DP

		inner join PERSONAL PE 
		on DP.numeroIdentidad = PE.numeroIdentidad 
		where PE.estado <> 'Eliminado'
End
GO
/****** Object:  StoredProcedure [dbo].[consultaTodoRecursosMotores]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[consultaTodoRecursosMotores]
as begin 
	select PE.idPersonal as 'ID encargado', concat(DP.nombres, ' ', DP.primerApellido) as 'Encargado', 
	RM.idVehiculo as 'ID vehículo', RM.modelo as 'Modelo', RM.matricula as 'Matrícula' 
	from DATOS_PERSONAS DP
		
	inner join PERSONAL PE
	on DP.numeroIdentidad = PE.numeroIdentidad 
	inner join RECURSOS_MOTORES RM
	on PE.idVehiculo = RM.idVehiculo 
	where PE.estado <> 'Eliminado'
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesAdministradores]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OperacionesAdministradores](@numeroIdentidad varchar(13), @contrasena varchar(20), @correo varchar(50), @codigoOP int)
as begin
	if @codigoOP = 1
	begin
		if exists(select numeroIdentidad from ADMINISTRADORES where numeroIdentidad = @numeroIdentidad)
			raisError('Ya existe un registro con este ID', 16, 1)
		else if exists(select numeroIdentidad from PERSONAL where numeroIdentidad = @numeroIdentidad)
			insert into ADMINISTRADORES values(@numeroIdentidad, @contrasena, @correo)
		else
			raisError('No existe un registro con este ID en la tabla PERSONAL, creelo', 16, 1)
	end

	if @codigoOP = 2
	begin
		if exists(select numeroIdentidad from ADMINISTRADORES where numeroIdentidad = @numeroIdentidad)
		update ADMINISTRADORES set numeroIdentidad = @numeroIdentidad, contrasena = @contrasena, correo = @correo where numeroIdentidad = @numeroIdentidad
	else
		raiserror('No existe un Numero de Identidad con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[operacionesFactura]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[operacionesFactura] (@idFactura int, @numeroIdentidadC varchar(13), @fechaPago varchar(25), @codigoOP int)
as begin
	DECLARE @mes varchar(20)

	begin
	if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 1
		set @mes = 'Enero'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 2
		set @mes = 'Febrero'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 3
		set @mes = 'Marzo'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 4
		set @mes = 'Abril'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 5
		set @mes = 'Mayo'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 6
		set @mes = 'Junio'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 7
		set @mes = 'Julio'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 8
		set @mes = 'Agosto'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 9
		set @mes = 'Septiembre'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 10
		set @mes = 'Octubre'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 11
		set @mes = 'Noviembre'
	else if (select pagosCliente from CLIENTES where numeroIdentidad = @numeroIdentidadC) = 12
		set @mes = 'Diciembre'
	end

	if @codigoOP = 1
	begin
	if exists(select numeroIdentidad from CLIENTES where numeroIdentidad = @numeroIdentidadC)
		insert into FACTURA values (@numeroIdentidadC, @fechaPago, @mes)	
	else
		raiserror('El numero de identidad no ha sido registrado, ¡por favor ingrese uno valido!',16,1)
	end
	begin
	if @codigoOP = 2
	if exists(select idFactura from FACTURA where idFactura = @idFactura)
		update FACTURA set numeroIdentidadC = @numeroIdentidadC, fechaPago = @fechaPago, mesPago = @mes where idFactura = @idFactura
	else
		raiserror('No existe una Factura con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesGestionTickets]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OperacionesGestionTickets](@idTicket int, @numeroIdentidadC varchar(13), @idPersonal int, @estado varchar(20), @prioridad varchar(30), @idOperacion int, @nota varchar(120), @fechaInicio varchar(25), @fechaFin varchar(25), @codigoOP int)
as begin
	if @codigoOP = 1
	begin
	if  exists(select numeroIdentidad from CLIENTES where numeroIdentidad = @numeroIdentidadC) and exists(select idPersonal from PERSONAL where idPersonal = @idPersonal)
		insert into GESTION_TICKETS(numeroIdentidadC, idPersonal, estado, Prioridad, idOperacion, notas, fechaInicio, fechaFin)
			values(@numeroIdentidadC, @idPersonal, @estado, @prioridad, @idOperacion, @nota, @fechaInicio, @fechaFin)
	else
		raiserror('NO existe un numero de identidad ni empleado con ese id, ¡por favor ingrese uno valido!',16,1)
	end

	begin
	if @codigoOP = 2
		if exists(select idTicket from GESTION_TICKETS where idTicket = @idTicket)
		update GESTION_TICKETS set numeroIdentidadC = @numeroIdentidadC, idPersonal = @idPersonal, estado = @estado, Prioridad =@prioridad, idOperacion = @idOperacion, notas = @nota, fechaInicio = @fechaInicio, fechaFin = @fechaFin where idTicket = @idTicket
	else
		raiserror('No existe una Ticket con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesInventario]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------OPERACIONES-INVENTARIO--------------------------------------------------
CREATE procedure [dbo].[OperacionesInventario]
@idTipoAparato as int, @nombreTipo as varchar(20), @cantidad as int, @codigoOP as int
as begin
	if @codigoOP = 1
	begin
	insert into INVENTARIO values(@nombreTipo, @cantidad)
	end

	begin
	if @codigoOP = 2
	if exists(select idTipoAparato from INVENTARIO where idTipoAparato = @idTipoAparato) 
	update INVENTARIO set nombreTipo = @nombreTipo, cantidad = @cantidad where idTipoAparato = @idTipoAparato
	else
	raiserror('No existe un tipo de aparato con ese id, ¡por favor ingrese uno valido!',16,1)
	end
	end
GO
/****** Object:  StoredProcedure [dbo].[operacionesPersonaCL]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[operacionesPersonaCL](@numeroIdentidad varchar(13), @nombres varchar(25), @primerApellido varchar (15), @segundoApellido varchar(15), @numeroTelefono int, @numeroCasa int,
@idSector int, @referenciasDireccion varchar(80), @idPaquete int, @pagosCliente int, @estadoC varchar(30), @codigoOP int)
as begin
	if @codigoOP = 1
	begin
	if exists(select numeroIdentidad from DATOS_PERSONAS where numeroIdentidad = @numeroIdentidad)
	
	insert into CLIENTES(numeroIdentidad, idPaquete, pagosCliente, estadoC)
		values(@numeroIdentidad, @idPaquete, @pagosCliente, @estadoC)

		else IF exists(select numeroIdentidad from CLIENTES where numeroIdentidad = @numeroIdentidad)
			raisError('Ya existe un registro', 16, 1)
		else
		begin
		insert into DATOS_PERSONAS(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion) 
		values(@numeroIdentidad, @nombres, @primerApellido, @segundoApellido, @numeroTelefono, @numeroCasa, @idSector, @referenciasDireccion)
		
		insert into CLIENTES(numeroIdentidad, idPaquete, pagosCliente, estadoC)
		values(@numeroIdentidad, @idPaquete, @pagosCliente, @estadoC)
		end
	
	end
	
	if @codigoOP = 2
	begin
	if exists(select numeroIdentidad from CLIENTES where numeroIdentidad = @numeroIdentidad)
	begin
		update DATOS_PERSONAS set numeroIdentidad = @numeroIdentidad, nombres = @nombres, primerApellido = @primerApellido, segundoApellido = @segundoApellido, numeroTelefono = @numeroTelefono, numeroCasa = @numeroCasa, idSector = @idSector, referenciasDireccion = @referenciasDireccion where numeroIdentidad = @numeroIdentidad
		update CLIENTES set numeroIdentidad = @numeroIdentidad, idPaquete = @idPaquete, pagosCliente = @pagosCliente, estadoC = @estadoC where numeroIdentidad = @numeroIdentidad
		end
	else
		raiserror('No existe un Numero de Identidad con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesPersonaPE]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------OPERACIONES-PERSONAS EMPLEADOS--------------------------------------------------

CREATE procedure [dbo].[OperacionesPersonaPE](@numeroIdentidad varchar(13), @nombres varchar(25), @primerApellido varchar (15), @segundoApellido varchar(15), @numeroTelefono int, @numeroCasa int,
@idSector int, @referenciasDireccion varchar(80), @idVehiculo int, @estado varchar(15), @codigoOP int)
as begin
	if @codigoOP = 1
	begin
	if exists(select numeroIdentidad from DATOS_PERSONAS WHERE numeroIdentidad = @numeroIdentidad)
		insert into PERSONAL(numeroIdentidad, idVehiculo, estado) values(@numeroIdentidad, @idVehiculo, @estado)
	else IF exists(select numeroIdentidad from PERSONAL where numeroIdentidad = @numeroIdentidad)
			raisError('Ya existe un registro', 16, 1)
		else
		begin
		insert into DATOS_PERSONAS(numeroIdentidad, nombres, primerApellido, segundoApellido, numeroTelefono, numeroCasa, idSector, referenciasDireccion) 
		values(@numeroIdentidad, @nombres, @primerApellido, @segundoApellido, @numeroTelefono, @numeroCasa, @idSector, @referenciasDireccion)
		
		insert into PERSONAL(numeroIdentidad, idVehiculo, estado)
		values(@numeroIdentidad, @idVehiculo, @estado)
		end
	end

	if @codigoOP = 2
	begin
		if exists(select numeroIdentidad from PERSONAL where numeroIdentidad = @numeroIdentidad)
		begin
		update DATOS_PERSONAS set numeroIdentidad = @numeroIdentidad, nombres = @nombres, primerApellido = @primerApellido, segundoApellido = @segundoApellido, numeroTelefono = @numeroTelefono, numeroCasa = @numeroCasa, idSector = @idSector, referenciasDireccion = @referenciasDireccion where numeroIdentidad = @numeroIdentidad
		update PERSONAL set numeroIdentidad = @numeroIdentidad, idVehiculo = @idVehiculo, estado = @estado where numeroIdentidad = @numeroIdentidad
		end
	else
		raiserror('No existe un Numero de Identidad con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesPlanesInternet]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[OperacionesPlanesInternet] 
@idPaquete as int, @nombrePaquete as varchar(40), @velocidad as int, @precio as float, @codigoOP as int
as begin
	if @codigoOP = 1
	begin
		insert into PLANES_INTERNET values(@nombrePaquete, @velocidad, @precio)
	end

	begin
	if @codigoOP = 2
	if exists(select idPaquete from PLANES_INTERNET where idPaquete = @idPaquete)
		update PLANES_INTERNET set nombrePaquete = @nombrePaquete, velocidad = @velocidad, precio = @precio where idPaquete = @idPaquete
	else
		raiserror('No existe un plan con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesRecursosMotores]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------OPERACIONES-RECURSOS MOTORES-------------------------------

CREATE procedure [dbo].[OperacionesRecursosMotores] (@idVehiculo int, @matricula varchar(7), @modelo varchar(30), @codigoOP int)
as begin

	if @codigoOP = 1
	begin
		insert into RECURSOS_MOTORES values(@matricula, @modelo)
	end

	if @codigoOP = 2
	begin
	if exists(select idVehiculo from RECURSOS_MOTORES where idVehiculo = @idVehiculo) 
		update RECURSOS_MOTORES set matricula = @matricula, modelo = @modelo where idVehiculo = @idVehiculo
	else
		raiserror('No existe un vehículo con ese id, ¡por favor ingrese uno valido!',16,1)
		end
end
GO
/****** Object:  StoredProcedure [dbo].[OperacionesSectores]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

---------------------------------OPERACIONES-SECTORES-------------------------------------
CREATE procedure [dbo].[OperacionesSectores]
@idSector as int, @barrio as varchar(50), @codigoOP int
as begin
	if @codigoOP = 1
	begin
	insert into SECTORES values(@barrio)
	end

	begin
	if @codigoOP = 2
	if exists(select idSector from SECTORES where idSector = @idSector) 
	update SECTORES set barrio = @barrio where idSector = @idSector
	else
	raiserror('No existe un sector con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[operacionesTickets]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------------------OPERACIONES-TICKETS--------------------------------------------

CREATE procedure [dbo].[operacionesTickets](@idOperacion int, @descripcion varchar(80), @nombreOperacion varchar(40), @codigoOP int)
as begin
	if @codigoOP = 1
	begin
		insert into OPERACIONES values(@descripcion, @nombreOperacion)
	end

	if @codigoOP = 2
	begin
	if exists(select idOperacion from OPERACIONES where idOperacion = @idOperacion)
		update OPERACIONES set descripcion = @descripcion, nombreOperacion = @nombreOperacion where idOperacion = @idOperacion
	else
		raiserror('No existe una Operacion con ese id, ¡por favor ingrese uno valido!',16,1)
	end
end
GO
/****** Object:  Trigger [dbo].[trCLIENTES_cantPagos]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trCLIENTES_cantPagos] on [dbo].[CLIENTES] after UPDATE
as begin
		update CLIENTES set pagosCliente = 0 from CLIENTES c
		inner join inserted i on c.numeroIdentidad = i.numeroIdentidad and c.pagosCliente = 13

end
GO
ALTER TABLE [dbo].[CLIENTES] ENABLE TRIGGER [trCLIENTES_cantPagos]
GO
/****** Object:  Trigger [dbo].[trActualizaFecha]    Script Date: 30/7/2020 02:10:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[trActualizaFecha] on [dbo].[GESTION_TICKETS] after UPDATE
as begin

	if (select estado from inserted) = 'Realizado'
		update GESTION_TICKETS set fechaFin = FORMAT(GETDATE() , 'dd/MM/yyyy HH:mm:ss') from GESTION_TICKETS gs
		inner join inserted i on gs.idTicket = i.idTicket and gs.estado = 'Realizado'
	else
		update GESTION_TICKETS set fechaFin = NULL from GESTION_TICKETS gs
		inner join inserted i on gs.idTicket = i.idTicket and gs.estado = 'Pendiente'

end
GO
ALTER TABLE [dbo].[GESTION_TICKETS] ENABLE TRIGGER [trActualizaFecha]
GO
USE [master]
GO
ALTER DATABASE [bd_SiguaNet] SET  READ_WRITE 
GO
