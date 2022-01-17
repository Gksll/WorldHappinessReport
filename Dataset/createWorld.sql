USE [master
GO

/****** Object:  Database [World]    Script Date: 17.01.2022 22:40:28 ******/
CREATE DATABASE [World]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'World', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\World.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'World_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\World_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [World].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [World] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [World] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [World] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [World] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [World] SET ARITHABORT OFF 
GO

ALTER DATABASE [World] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [World] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [World] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [World] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [World] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [World] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [World] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [World] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [World] SET  DISABLE_BROKER 
GO

ALTER DATABASE [World] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [World] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [World] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [World] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [World] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [World] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [World] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [World] SET RECOVERY FULL 
GO

ALTER DATABASE [World] SET  MULTI_USER 
GO

ALTER DATABASE [World] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [World] SET DB_CHAINING OFF 
GO

ALTER DATABASE [World] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [World] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [World] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [World] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [World] SET QUERY_STORE = OFF
GO

ALTER DATABASE [World] SET  READ_WRITE 
GO

