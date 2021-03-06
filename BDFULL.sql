USE [master]
GO
/****** Object:  Database [correoele]    Script Date: 17/08/2018 18:40:35 ******/
CREATE DATABASE [correoele]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'sistemacorreo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\sistemacorreo.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'sistemacorreo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\sistemacorreo_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [correoele] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [correoele].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [correoele] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [correoele] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [correoele] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [correoele] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [correoele] SET ARITHABORT OFF 
GO
ALTER DATABASE [correoele] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [correoele] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [correoele] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [correoele] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [correoele] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [correoele] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [correoele] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [correoele] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [correoele] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [correoele] SET  DISABLE_BROKER 
GO
ALTER DATABASE [correoele] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [correoele] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [correoele] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [correoele] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [correoele] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [correoele] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [correoele] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [correoele] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [correoele] SET  MULTI_USER 
GO
ALTER DATABASE [correoele] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [correoele] SET DB_CHAINING OFF 
GO
ALTER DATABASE [correoele] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [correoele] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [correoele] SET DELAYED_DURABILITY = DISABLED 
GO
USE [correoele]
GO
/****** Object:  Table [dbo].[contacto]    Script Date: 17/08/2018 18:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[contacto](
	[idusuario] [int] NOT NULL,
	[iddetalle_usuario] [int] NOT NULL,
	[iddetalle_contacto] [int] NOT NULL,
	[aceptado] [bit] NOT NULL,
	[fecha_agregado] [timestamp] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[mail]    Script Date: 17/08/2018 18:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mail](
	[idmail] [int] IDENTITY(1,1) NOT NULL,
	[iddetalle_remitente] [int] NOT NULL,
	[iddetalle_destinatario] [int] NOT NULL,
	[asunto] [text] NOT NULL,
	[contenido] [text] NULL,
	[fechaenvio] [timestamp] NOT NULL,
 CONSTRAINT [PK_mail] PRIMARY KEY CLUSTERED 
(
	[idmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[usuario]    Script Date: 17/08/2018 18:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idusuario] [int] IDENTITY(1,1) NOT NULL,
	[direccion] [varchar](60) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[iddetalle] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idusuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario_detalle]    Script Date: 17/08/2018 18:40:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario_detalle](
	[iddetalle] [int] IDENTITY(1,1) NOT NULL,
	[nick] [varchar](60) NULL,
	[nombre] [varchar](60) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[fechacreacion] [timestamp] NOT NULL,
 CONSTRAINT [PK_detalle] PRIMARY KEY CLUSTERED 
(
	[iddetalle] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[contacto] ADD  CONSTRAINT [DF_contacto_aceptado]  DEFAULT ((0)) FOR [aceptado]
GO
ALTER TABLE [dbo].[contacto]  WITH CHECK ADD  CONSTRAINT [FK_contacto_usuario] FOREIGN KEY([idusuario])
REFERENCES [dbo].[usuario] ([idusuario])
GO
ALTER TABLE [dbo].[contacto] CHECK CONSTRAINT [FK_contacto_usuario]
GO
ALTER TABLE [dbo].[contacto]  WITH CHECK ADD  CONSTRAINT [FK_contacto_usuario_detalle] FOREIGN KEY([iddetalle_usuario])
REFERENCES [dbo].[usuario_detalle] ([iddetalle])
GO
ALTER TABLE [dbo].[contacto] CHECK CONSTRAINT [FK_contacto_usuario_detalle]
GO
ALTER TABLE [dbo].[contacto]  WITH CHECK ADD  CONSTRAINT [FK_contacto_usuario_detalle1] FOREIGN KEY([iddetalle_contacto])
REFERENCES [dbo].[usuario_detalle] ([iddetalle])
GO
ALTER TABLE [dbo].[contacto] CHECK CONSTRAINT [FK_contacto_usuario_detalle1]
GO
ALTER TABLE [dbo].[mail]  WITH CHECK ADD  CONSTRAINT [FK_mail_usuario_detalle] FOREIGN KEY([iddetalle_remitente])
REFERENCES [dbo].[usuario_detalle] ([iddetalle])
GO
ALTER TABLE [dbo].[mail] CHECK CONSTRAINT [FK_mail_usuario_detalle]
GO
ALTER TABLE [dbo].[mail]  WITH CHECK ADD  CONSTRAINT [FK_mail_usuario_detalle1] FOREIGN KEY([iddetalle_destinatario])
REFERENCES [dbo].[usuario_detalle] ([iddetalle])
GO
ALTER TABLE [dbo].[mail] CHECK CONSTRAINT [FK_mail_usuario_detalle1]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_usuario_detalle] FOREIGN KEY([iddetalle])
REFERENCES [dbo].[usuario_detalle] ([iddetalle])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_usuario_detalle]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Remitente' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mail', @level2type=N'COLUMN',@level2name=N'iddetalle_remitente'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'destinatario' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mail', @level2type=N'COLUMN',@level2name=N'iddetalle_destinatario'
GO
USE [master]
GO
ALTER DATABASE [correoele] SET  READ_WRITE 
GO
