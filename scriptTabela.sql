USE [lucasseABETOtTBI]
GO

/****** Object:  Table [dbo].[Rastreadores]    Script Date: 28/11/2013 10:46:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Rastreadores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Serial] [float] NOT NULL,
	[StatusSO] [bit] NOT NULL,
	[LatitudeGPS] [nvarchar](max) NULL,
	[LongitudeGPS] [nvarchar](max) NULL,
	[AltitudeGPS] [nvarchar](max) NULL,
	[VelocidadeGPS] [nvarchar](max) NULL,
	[DateTimeGPS] [datetime] NOT NULL,
	[DateTimeService] [datetime] NOT NULL,
	[NumeroDeSatelites] [smallint] NOT NULL,
	[QualidadeSinalGPS] [smallint] NOT NULL,
	[QualidadeSinalGSM] [smallint] NOT NULL,
	[Observacao] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.Rastreadores] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)
)

GO

