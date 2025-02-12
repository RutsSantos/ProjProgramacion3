USE [master]
GO
/****** Object:  Database [inventario]    Script Date: 8/19/2020 4:35:55 PM ******/
CREATE DATABASE [inventario]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'inventario', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\inventario.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'inventario_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\inventario_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [inventario] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [inventario].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [inventario] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [inventario] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [inventario] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [inventario] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [inventario] SET ARITHABORT OFF 
GO
ALTER DATABASE [inventario] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [inventario] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [inventario] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [inventario] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [inventario] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [inventario] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [inventario] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [inventario] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [inventario] SET  DISABLE_BROKER 
GO
ALTER DATABASE [inventario] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [inventario] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [inventario] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [inventario] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [inventario] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [inventario] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [inventario] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [inventario] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [inventario] SET  MULTI_USER 
GO
ALTER DATABASE [inventario] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [inventario] SET DB_CHAINING OFF 
GO
ALTER DATABASE [inventario] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [inventario] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [inventario] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [inventario] SET QUERY_STORE = OFF
GO
USE [inventario]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[codigo_cliente] [int] IDENTITY(1,1) NOT NULL,
	[nombre_cliente] [varchar](50) NULL,
	[sexo] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](15) NULL,
	[estado] [bit] NULL,
	[fecha_de_nacimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[departamento]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[departamento](
	[codigo_departamento] [int] IDENTITY(1,1) NOT NULL,
	[nombre_departamento] [varchar](50) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalles]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalles](
	[numero_factura] [int] NOT NULL,
	[cantidad_vendida] [real] NULL,
	[codigo_producto] [int] NOT NULL,
	[precio_de_venta] [real] NULL,
	[unidad_producto] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[codigo_producto] [int] IDENTITY(1,1) NOT NULL,
	[nombre_producto] [varchar](50) NULL,
	[codigo_departamento] [int] NOT NULL,
	[codigo_suplidor] [int] NOT NULL,
	[cantidad_existente] [real] NULL,
	[punto_reo] [real] NULL,
	[codigo_unidad] [int] NOT NULL,
	[estado] [bit] NULL,
	[precio_de_venta] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[suplidor]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[suplidor](
	[codigo_suplidor] [int] IDENTITY(1,1) NOT NULL,
	[nombre_suplidor] [varchar](50) NULL,
	[sexo] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[telefono] [varchar](15) NULL,
	[estado] [bit] NULL,
	[fecha_de_nacimiento] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_suplidor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidad]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidad](
	[codigo_unidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre_unidad] [varchar](50) NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_unidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[codigo_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre_usuario] [varchar](50) NULL,
	[contrasena] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[numero_factura] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NULL,
	[codigo_cliente] [int] NOT NULL,
	[estado] [bit] NULL,
	[total] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[numero_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[detalles]  WITH CHECK ADD  CONSTRAINT [FK_detalles_producto] FOREIGN KEY([codigo_producto])
REFERENCES [dbo].[producto] ([codigo_producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalles] CHECK CONSTRAINT [FK_detalles_producto]
GO
ALTER TABLE [dbo].[detalles]  WITH CHECK ADD  CONSTRAINT [FK_detalles_venta] FOREIGN KEY([numero_factura])
REFERENCES [dbo].[venta] ([numero_factura])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[detalles] CHECK CONSTRAINT [FK_detalles_venta]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_departamento] FOREIGN KEY([codigo_departamento])
REFERENCES [dbo].[departamento] ([codigo_departamento])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_departamento]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_suplidor] FOREIGN KEY([codigo_suplidor])
REFERENCES [dbo].[suplidor] ([codigo_suplidor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_suplidor]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_unidad] FOREIGN KEY([codigo_unidad])
REFERENCES [dbo].[unidad] ([codigo_unidad])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_unidad]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_venta_cliente] FOREIGN KEY([codigo_cliente])
REFERENCES [dbo].[cliente] ([codigo_cliente])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_venta_cliente]
GO
/****** Object:  StoredProcedure [dbo].[activarCliente]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[activarCliente]

   @codigo_cliente int

AS

    IF EXISTS (SELECT codigo_cliente FROM cliente WHERE codigo_cliente = @codigo_cliente )

        UPDATE cliente SET estado = 1 WHERE codigo_cliente =  @codigo_cliente

GO
/****** Object:  StoredProcedure [dbo].[activarDepartamento]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[activarDepartamento]

   @codigo_departamento int

AS

    IF EXISTS (SELECT codigo_departamento FROM departamento WHERE codigo_departamento = @codigo_departamento)

        UPDATE departamento SET estado = 1 WHERE codigo_departamento =  @codigo_departamento

GO
/****** Object:  StoredProcedure [dbo].[activarProducto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[activarProducto]

   @codigo_producto int

AS

    IF EXISTS (SELECT codigo_producto FROM producto WHERE codigo_producto = @codigo_producto)

        UPDATE producto SET estado = 1 WHERE codigo_producto =  @codigo_producto

GO
/****** Object:  StoredProcedure [dbo].[activarSuplidor]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[activarSuplidor]

   @codigo_suplidor int

AS

    IF EXISTS (SELECT codigo_suplidor FROM suplidor WHERE codigo_suplidor = @codigo_suplidor)

        UPDATE suplidor SET estado = 1 WHERE codigo_suplidor =  @codigo_suplidor

GO
/****** Object:  StoredProcedure [dbo].[activarUnidad]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[activarUnidad]

   @codigo_unidad int

AS

    IF EXISTS (SELECT codigo_unidad FROM unidad WHERE codigo_unidad  = @codigo_unidad )

        UPDATE unidad  SET estado = 1 WHERE codigo_unidad  =  @codigo_unidad

GO
/****** Object:  StoredProcedure [dbo].[consultarCliente]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarCliente]

@codigo_cliente int

AS

  SELECT * FROM cliente WHERE codigo_cliente = @codigo_cliente;

GO
/****** Object:  StoredProcedure [dbo].[consultarDepartamento]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarDepartamento]

@codigo_departamento int

AS

  SELECT * FROM departamento WHERE codigo_departamento = @codigo_departamento;

GO
/****** Object:  StoredProcedure [dbo].[consultarForeingKeyProducto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarForeingKeyProducto]

@codigo_producto int

AS

  DECLARE @codigo_suplidor INT;

  DECLARE @codigo_departamento INT;

  DECLARE @codigo_unidad INT;

  SELECT @codigo_suplidor = codigo_suplidor, @codigo_departamento = codigo_departamento, @codigo_unidad = codigo_unidad 

  FROM producto WHERE codigo_producto = @codigo_producto;

  EXEC activarDepartamento @codigo_departamento;

  EXEC activarSuplidor @codigo_unidad;

  EXEC activarUnidad @codigo_unidad;

GO
/****** Object:  StoredProcedure [dbo].[consultarProducto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarProducto]

@codigo_producto int

AS

  SELECT * FROM producto WHERE codigo_producto = @codigo_producto;

GO
/****** Object:  StoredProcedure [dbo].[consultarProductoFull]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarProductoFull]

@codigo_producto int 

AS

  IF @codigo_producto IS NULL

    SELECT  producto.codigo_producto,

      producto.nombre_producto,

      departamento.codigo_departamento,

      departamento.nombre_departamento,

      suplidor.nombre_suplidor,

      producto.cantidad_existente,

      unidad.nombre_unidad,

      producto.precio_de_venta

    FROM producto

    INNER JOIN departamento

      ON producto.codigo_departamento = departamento.codigo_departamento

    INNER JOIN suplidor

      ON producto.codigo_suplidor = suplidor.codigo_suplidor

    INNER JOIN unidad

      ON producto.codigo_unidad =  unidad.codigo_unidad

  ELSE

    SELECT  producto.codigo_producto,

      producto.nombre_producto,

      departamento.codigo_departamento,

      departamento.nombre_departamento,

      suplidor.nombre_suplidor,

      producto.cantidad_existente,

      unidad.nombre_unidad,

      producto.precio_de_venta

    FROM producto

    INNER JOIN departamento

      ON producto.codigo_departamento = departamento.codigo_departamento

    INNER JOIN suplidor

      ON producto.codigo_suplidor = suplidor.codigo_suplidor

    INNER JOIN unidad

      ON producto.codigo_unidad =  unidad.codigo_unidad

    WHERE producto.codigo_producto = @codigo_producto;

GO
/****** Object:  StoredProcedure [dbo].[consultarSuplidor]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarSuplidor]

@codigo_suplidor int

AS

  SELECT * FROM suplidor WHERE codigo_suplidor = @codigo_suplidor;

GO
/****** Object:  StoredProcedure [dbo].[consultarUnidad]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarUnidad]

@codigo_unidad int

AS

  SELECT * FROM unidad WHERE codigo_unidad = @codigo_unidad;

GO
/****** Object:  StoredProcedure [dbo].[consultarUsuario]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarUsuario]

@contrasena varchar(50),

@nombre_usuario varchar(50)

AS

  SELECT * FROM usuarios WHERE nombre_usuario = @nombre_usuario AND contrasena = @contrasena;

GO
/****** Object:  StoredProcedure [dbo].[consultarVentas]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[consultarVentas]

@numero_factura int

AS 

  IF @numero_factura IS NULL

  SELECT venta.numero_factura, venta.fecha, venta.total, cliente.nombre_cliente, cliente.codigo_cliente ,cliente.sexo, producto.codigo_producto, producto.nombre_producto, detalles.cantidad_vendida, detalles.precio_de_venta, detalles.cantidad_vendida * detalles.precio_de_venta AS importe, departamento.codigo_departamento, departamento.nombre_departamento, unidad.nombre_unidad, suplidor.nombre_suplidor, venta.estado

  FROM venta

  INNER JOIN detalles

    ON venta.numero_factura = detalles.numero_factura

  INNER JOIN cliente

    ON venta.codigo_cliente = cliente.codigo_cliente

  INNER JOIN producto

    ON detalles.codigo_producto = producto.codigo_producto

  INNER JOIN departamento

	ON producto.codigo_departamento = departamento.codigo_departamento

  INNER JOIN unidad

    ON producto.codigo_unidad = unidad.codigo_unidad

  INNER JOIN suplidor

    ON producto.codigo_suplidor = suplidor.codigo_suplidor

  ELSE

  SELECT venta.numero_factura, venta.fecha, venta.total, cliente.nombre_cliente, cliente.codigo_cliente ,cliente.sexo, producto.codigo_producto, producto.nombre_producto, detalles.cantidad_vendida, detalles.precio_de_venta, detalles.cantidad_vendida * detalles.precio_de_venta AS importe, departamento.codigo_departamento, departamento.nombre_departamento, unidad.nombre_unidad, suplidor.nombre_suplidor, venta.estado

  FROM venta

  INNER JOIN detalles

    ON venta.numero_factura = detalles.numero_factura

  INNER JOIN cliente

    ON venta.codigo_cliente = cliente.codigo_cliente

  INNER JOIN producto

    ON detalles.codigo_producto = producto.codigo_producto

  INNER JOIN departamento

	ON producto.codigo_departamento = departamento.codigo_departamento

  INNER JOIN unidad

    ON producto.codigo_unidad = unidad.codigo_unidad

  INNER JOIN suplidor

    ON producto.codigo_suplidor = suplidor.codigo_suplidor	

  WHERE venta.numero_factura = @numero_factura

GO
/****** Object:  StoredProcedure [dbo].[eliminarCliente]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarCliente]

   @codigo_cliente int

AS

    IF EXISTS (SELECT codigo_cliente FROM cliente WHERE codigo_cliente = @codigo_cliente)

        DELETE FROM cliente WHERE codigo_cliente = @codigo_cliente

GO
/****** Object:  StoredProcedure [dbo].[eliminarDepartamento]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarDepartamento]

   @codigo_departamento int

AS

    IF EXISTS (SELECT codigo_departamento FROM departamento WHERE codigo_departamento = @codigo_departamento)

        DELETE FROM departamento WHERE codigo_departamento= @codigo_departamento

GO
/****** Object:  StoredProcedure [dbo].[eliminarProducto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarProducto]

   @codigo_producto int

AS

    IF EXISTS (SELECT codigo_producto FROM producto WHERE codigo_producto = @codigo_producto)

        DELETE FROM producto WHERE codigo_producto = @codigo_producto

GO
/****** Object:  StoredProcedure [dbo].[eliminarSuplidor]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarSuplidor]

   @codigo_suplidor int

AS

    IF EXISTS (SELECT codigo_suplidor FROM suplidor WHERE codigo_suplidor = @codigo_suplidor)

        DELETE FROM suplidor WHERE codigo_suplidor = @codigo_suplidor

GO
/****** Object:  StoredProcedure [dbo].[eliminarUnidad]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[eliminarUnidad]

   @codigo_unidad int

AS

    IF EXISTS (SELECT codigo_unidad FROM unidad WHERE codigo_unidad = @codigo_unidad)

        DELETE FROM unidad WHERE codigo_unidad = @codigo_unidad

GO
/****** Object:  StoredProcedure [dbo].[upsertCliente]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertCliente]

    @codigo_cliente int,

    @nombre_cliente varchar(50),

    @sexo varchar(50),

    @email varchar(50),

    @telefono varchar(50),

    @estado bit,

    @fecha_de_nacimiento date

AS

	SET IDENTITY_INSERT cliente ON

    IF NOT EXISTS (SELECT codigo_cliente FROM cliente WHERE codigo_cliente = @codigo_cliente)

        INSERT INTO cliente (codigo_cliente, nombre_cliente,sexo, email, telefono, estado, fecha_de_nacimiento) VALUES (@codigo_cliente, @nombre_cliente, @sexo, @email, @telefono, @estado, @fecha_de_nacimiento)

    ELSE 

        UPDATE cliente SET nombre_cliente =  @nombre_cliente, sexo = @sexo, email =  @email, telefono =  @telefono, estado =  @estado, fecha_de_nacimiento = @fecha_de_nacimiento WHERE codigo_cliente =  @codigo_cliente

    SELECT @codigo_cliente AS codigo_cliente

GO
/****** Object:  StoredProcedure [dbo].[upsertDepartamento]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertDepartamento]

   @codigo_departamento int,

   @nombre_departamento varchar(50),

   @estado bit

AS

	SET IDENTITY_INSERT departamento ON

    IF NOT EXISTS (SELECT codigo_departamento FROM departamento WHERE codigo_departamento = @codigo_departamento)

        INSERT INTO departamento (codigo_departamento, nombre_departamento , estado) VALUES (@codigo_departamento, @nombre_departamento , @estado)

    ELSE 

        UPDATE departamento SET nombre_departamento = @nombre_departamento, estado = @estado WHERE codigo_departamento =  @codigo_departamento

GO
/****** Object:  StoredProcedure [dbo].[upsertDetalles]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertDetalles]

@numero_factura int,

@codigo_producto int,

@cantidad_vendida float,

@precio_de_venta float,

@unidad_producto varchar(50)

AS

  INSERT INTO detalles (numero_factura, cantidad_vendida, codigo_producto, precio_de_venta, unidad_producto) VALUES (@numero_factura, @cantidad_vendida, @codigo_producto, @precio_de_venta, @unidad_producto)

  UPDATE producto SET cantidad_existente = cantidad_existente - @cantidad_vendida WHERE codigo_producto = @codigo_producto

GO
/****** Object:  StoredProcedure [dbo].[upsertProducto]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertProducto]

   @codigo_producto int, 

   @nombre_producto varchar(50), 

   @codigo_departamento int, 

   @codigo_suplidor int, 

   @cantidad_existente float(2), 

   @punto_reo float(2), 

   @codigo_unidad int, 

   @estado bit, 

   @precio_de_venta money

AS

	SET IDENTITY_INSERT producto ON

    IF NOT EXISTS (SELECT codigo_producto FROM producto WHERE codigo_producto = @codigo_producto)

        INSERT INTO producto (codigo_producto, nombre_producto, codigo_departamento, codigo_suplidor, cantidad_existente, punto_reo, codigo_unidad, estado, precio_de_venta) VALUES (@codigo_producto, @nombre_producto, @codigo_departamento, @codigo_suplidor, @cantidad_existente, @punto_reo, @codigo_unidad, @estado, @precio_de_venta)

    ELSE 

        UPDATE producto SET nombre_producto = @nombre_producto,  codigo_departamento = @codigo_departamento,  codigo_suplidor = @codigo_suplidor,  cantidad_existente = @cantidad_existente,  punto_reo = @punto_reo,  codigo_unidad = @codigo_unidad,  estado = @estado,  precio_de_venta = @precio_de_venta  WHERE codigo_producto =  @codigo_producto

GO
/****** Object:  StoredProcedure [dbo].[upsertSuplidor]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertSuplidor]

    @codigo_suplidor int, 

    @nombre_suplidor varchar(50), 

    @sexo varchar(50), 

    @email varchar(50), 

    @telefono varchar(50), 

    @estado bit,

    @fecha_de_nacimiento date

AS

	SET IDENTITY_INSERT suplidor ON

    IF NOT EXISTS (SELECT codigo_suplidor FROM suplidor WHERE codigo_suplidor = @codigo_suplidor)

        INSERT INTO suplidor (codigo_suplidor, nombre_suplidor,sexo, email, telefono, estado, fecha_de_nacimiento) VALUES (@codigo_suplidor, @nombre_suplidor,@sexo, @email, @telefono, @estado, @fecha_de_nacimiento)

    ELSE 

        UPDATE suplidor SET nombre_suplidor = @nombre_suplidor, sexo = @sexo, email = @email, telefono = @telefono, estado = @estado, fecha_de_nacimiento = @fecha_de_nacimiento WHERE codigo_suplidor =  @codigo_suplidor

GO
/****** Object:  StoredProcedure [dbo].[upsertUnidad]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertUnidad]

   @codigo_unidad int,

   @nombre_unidad varchar(50),

   @estado bit

AS

	SET IDENTITY_INSERT unidad ON

    IF NOT EXISTS (SELECT codigo_unidad FROM unidad WHERE codigo_unidad = @codigo_unidad)

        INSERT INTO unidad (codigo_unidad, nombre_unidad, estado) VALUES (@codigo_unidad, @nombre_unidad, @estado)

    ELSE 

        UPDATE unidad SET nombre_unidad = @nombre_unidad, estado = @estado WHERE codigo_unidad = @codigo_unidad

GO
/****** Object:  StoredProcedure [dbo].[upsertVentas]    Script Date: 8/19/2020 4:35:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[upsertVentas]

@codigo_cliente int, 

@total float

AS

  INSERT INTO venta(fecha, codigo_cliente, estado, total) VALUES (GETDATE(), @codigo_cliente, 1, @total )

  SELECT TOP 1 * FROM venta ORDER BY numero_factura DESC

GO
USE [master]
GO
ALTER DATABASE [inventario] SET  READ_WRITE 
GO
