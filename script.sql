USE [master]
GO
/****** Object:  Database [viragbolt]    Script Date: 4/7/2023 1:56:02 PM ******/
CREATE DATABASE [viragbolt]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'viragbolt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\viragbolt.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'viragbolt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\viragbolt_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [viragbolt] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [viragbolt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [viragbolt] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [viragbolt] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [viragbolt] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [viragbolt] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [viragbolt] SET ARITHABORT OFF 
GO
ALTER DATABASE [viragbolt] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [viragbolt] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [viragbolt] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [viragbolt] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [viragbolt] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [viragbolt] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [viragbolt] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [viragbolt] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [viragbolt] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [viragbolt] SET  DISABLE_BROKER 
GO
ALTER DATABASE [viragbolt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [viragbolt] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [viragbolt] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [viragbolt] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [viragbolt] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [viragbolt] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [viragbolt] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [viragbolt] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [viragbolt] SET  MULTI_USER 
GO
ALTER DATABASE [viragbolt] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [viragbolt] SET DB_CHAINING OFF 
GO
ALTER DATABASE [viragbolt] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [viragbolt] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [viragbolt] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [viragbolt] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [viragbolt] SET QUERY_STORE = ON
GO
ALTER DATABASE [viragbolt] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [viragbolt]
GO
/****** Object:  Table [dbo].[viragkategoriak]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viragkategoriak](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](50) NOT NULL,
	[megjegyzes] [nvarchar](500) NULL,
 CONSTRAINT [PK_viragkategoriak] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[viragok]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[viragok](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](50) NOT NULL,
	[kategoriaid] [int] NOT NULL,
	[szin] [nvarchar](50) NOT NULL,
	[mennyiseg] [int] NOT NULL,
	[egysegar] [float] NOT NULL,
 CONSTRAINT [PK_viragok] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_viragok]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_viragok]
AS
SELECT        dbo.viragok.id, dbo.viragok.nev AS virágnév, dbo.viragok.kategoriaid, dbo.viragok.szin, dbo.viragok.mennyiseg, dbo.viragok.egysegar, dbo.viragkategoriak.nev
FROM            dbo.viragkategoriak INNER JOIN
                         dbo.viragok ON dbo.viragkategoriak.id = dbo.viragok.kategoriaid
GO
/****** Object:  Table [dbo].[ertekesites]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ertekesites](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[viragid] [int] NOT NULL,
	[mennyiseg] [int] NULL,
 CONSTRAINT [PK_ertekesites] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[vevok]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[vevok](
	[email] [nvarchar](100) NOT NULL,
	[nev] [nvarchar](150) NOT NULL,
	[lakcim] [nvarchar](150) NULL,
 CONSTRAINT [PK_vevok] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[v_ertekesitesek]    Script Date: 4/7/2023 1:56:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[v_ertekesitesek]
AS
SELECT        dbo.ertekesites.id, dbo.ertekesites.email, dbo.vevok.nev, dbo.ertekesites.viragid, dbo.viragok.nev AS virágnév, dbo.ertekesites.mennyiseg, dbo.viragok.szin
FROM            dbo.ertekesites INNER JOIN
                         dbo.vevok ON dbo.ertekesites.email = dbo.vevok.email INNER JOIN
                         dbo.viragok ON dbo.ertekesites.viragid = dbo.viragok.id
GO
ALTER TABLE [dbo].[viragok] ADD  CONSTRAINT [DF_viragok_mennyiseg]  DEFAULT ((0)) FOR [mennyiseg]
GO
ALTER TABLE [dbo].[viragok] ADD  CONSTRAINT [DF_viragok_egysegar]  DEFAULT ((0)) FOR [egysegar]
GO
ALTER TABLE [dbo].[ertekesites]  WITH CHECK ADD  CONSTRAINT [FK_ertekesites_ertekesites] FOREIGN KEY([email])
REFERENCES [dbo].[vevok] ([email])
GO
ALTER TABLE [dbo].[ertekesites] CHECK CONSTRAINT [FK_ertekesites_ertekesites]
GO
ALTER TABLE [dbo].[ertekesites]  WITH CHECK ADD  CONSTRAINT [FK_ertekesites_viragok] FOREIGN KEY([viragid])
REFERENCES [dbo].[viragok] ([id])
GO
ALTER TABLE [dbo].[ertekesites] CHECK CONSTRAINT [FK_ertekesites_viragok]
GO
ALTER TABLE [dbo].[viragok]  WITH CHECK ADD  CONSTRAINT [FK_viragok_viragkategoriak] FOREIGN KEY([kategoriaid])
REFERENCES [dbo].[viragkategoriak] ([id])
GO
ALTER TABLE [dbo].[viragok] CHECK CONSTRAINT [FK_viragok_viragkategoriak]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "ertekesites"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vevok"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 119
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "viragok"
            Begin Extent = 
               Top = 120
               Left = 246
               Bottom = 250
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ertekesitesek'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_ertekesitesek'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "viragkategoriak"
            Begin Extent = 
               Top = 19
               Left = 119
               Bottom = 132
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "viragok"
            Begin Extent = 
               Top = 16
               Left = 364
               Bottom = 146
               Right = 534
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_viragok'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'v_viragok'
GO
USE [master]
GO
ALTER DATABASE [viragbolt] SET  READ_WRITE 
GO
