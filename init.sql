USE [master]
GO
/****** Object:  Database [TicketingSystem]    Script Date: 11.4.2022. 08:31:58 ******/
CREATE DATABASE [TicketingSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TicketingSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicketingSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TicketingSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TicketingSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TicketingSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TicketingSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TicketingSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TicketingSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TicketingSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TicketingSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TicketingSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TicketingSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TicketingSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TicketingSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TicketingSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TicketingSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TicketingSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TicketingSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TicketingSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TicketingSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TicketingSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TicketingSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TicketingSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TicketingSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [TicketingSystem] SET  MULTI_USER 
GO
ALTER DATABASE [TicketingSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TicketingSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TicketingSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TicketingSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TicketingSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TicketingSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TicketingSystem', N'ON'
GO
ALTER DATABASE [TicketingSystem] SET QUERY_STORE = OFF
GO
USE [TicketingSystem]
GO
/****** Object:  Table [dbo].[categories]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categories](
	[category_id] [int] IDENTITY(1,1) NOT NULL,
	[category_name] [varchar](30) NOT NULL,
 CONSTRAINT [PK_categories] PRIMARY KEY CLUSTERED 
(
	[category_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[comments]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[comments](
	[comment_id] [int] IDENTITY(1,1) NOT NULL,
	[the_content] [text] NOT NULL,
	[employee_id] [int] NOT NULL,
	[ticket_id] [int] NOT NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[comment_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[employees]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[employees](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[first_name] [varchar](30) NOT NULL,
	[last_name] [varchar](30) NOT NULL,
	[username] [varchar](30) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [text] NOT NULL,
	[ssh_key] [text] NULL,
 CONSTRAINT [PK_employees] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[priorities]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[priorities](
	[priority_id] [int] IDENTITY(1,1) NOT NULL,
	[priority_name] [varchar](50) NOT NULL,
	[priority_color] [char](9) NOT NULL,
 CONSTRAINT [PK_priorities] PRIMARY KEY CLUSTERED 
(
	[priority_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [varchar](30) NOT NULL,
 CONSTRAINT [PK_roles] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles_employees]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles_employees](
	[role_employee_id] [int] IDENTITY(1,1) NOT NULL,
	[role_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
 CONSTRAINT [PK_roles_employees] PRIMARY KEY CLUSTERED 
(
	[role_employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[statuses]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[statuses](
	[status_id] [int] IDENTITY(1,1) NOT NULL,
	[status_name] [varchar](30) NOT NULL,
	[status_color] [char](9) NOT NULL,
 CONSTRAINT [PK_statuses] PRIMARY KEY CLUSTERED 
(
	[status_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tickets]    Script Date: 11.4.2022. 08:31:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tickets](
	[ticket_id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](30) NOT NULL,
	[contents] [text] NOT NULL,
	[created_at] [date] NOT NULL,
	[employee_id] [int] NOT NULL,
	[category_id] [int] NULL,
	[status_id] [int] NULL,
	[priority_id] [int] NULL,
	[assigned_to] [int] NULL,
	[edited_at] [date] NULL,
 CONSTRAINT [PK_tickets] PRIMARY KEY CLUSTERED 
(
	[ticket_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tickets] ADD  CONSTRAINT [DF_tickets_created_at]  DEFAULT (getdate()) FOR [created_at]
GO
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_employees] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employees] ([employee_id])
GO
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [FK_comments_employees]
GO
ALTER TABLE [dbo].[comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_tickets] FOREIGN KEY([ticket_id])
REFERENCES [dbo].[tickets] ([ticket_id])
GO
ALTER TABLE [dbo].[comments] CHECK CONSTRAINT [FK_comments_tickets]
GO
ALTER TABLE [dbo].[roles_employees]  WITH CHECK ADD  CONSTRAINT [FK_roles_employees_employees] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employees] ([employee_id])
GO
ALTER TABLE [dbo].[roles_employees] CHECK CONSTRAINT [FK_roles_employees_employees]
GO
ALTER TABLE [dbo].[roles_employees]  WITH CHECK ADD  CONSTRAINT [FK_roles_employees_roles] FOREIGN KEY([role_id])
REFERENCES [dbo].[roles] ([role_id])
GO
ALTER TABLE [dbo].[roles_employees] CHECK CONSTRAINT [FK_roles_employees_roles]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_categories] FOREIGN KEY([category_id])
REFERENCES [dbo].[categories] ([category_id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_categories]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_employees] FOREIGN KEY([assigned_to])
REFERENCES [dbo].[employees] ([employee_id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_employees]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_employees_emp_id] FOREIGN KEY([employee_id])
REFERENCES [dbo].[employees] ([employee_id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_employees_emp_id]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_priorities] FOREIGN KEY([priority_id])
REFERENCES [dbo].[priorities] ([priority_id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_priorities]
GO
ALTER TABLE [dbo].[tickets]  WITH CHECK ADD  CONSTRAINT [FK_tickets_statuses] FOREIGN KEY([status_id])
REFERENCES [dbo].[statuses] ([status_id])
GO
ALTER TABLE [dbo].[tickets] CHECK CONSTRAINT [FK_tickets_statuses]
GO
USE [master]
GO
ALTER DATABASE [TicketingSystem] SET  READ_WRITE 
GO
