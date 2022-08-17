USE [Agua]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 31/07/2022 12:30:37 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Foto] [varbinary](max) NULL,
	[Documento] [varchar](15) NULL,
	[Nombre] [varchar](40) NULL,
	[Usuario] [varchar](10) NULL,
	[Rol] [varchar](10) NULL,
	[Password] [varchar](500) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
