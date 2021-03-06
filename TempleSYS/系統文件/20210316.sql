USE [DBWeb]
GO
/****** Object:  Table [dbo].[TempleBoard]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleBoard](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[BoSDate] [datetime] NULL,
	[BoEDate] [datetime] NULL,
	[BoContent] [nvarchar](max) NULL,
	[BoPeo] [bigint] NULL,
	[IsDelete] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleBoard] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleBTS]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleBTS](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Years] [nvarchar](10) NULL,
	[OrderNo] [nvarchar](30) NULL,
	[UserName] [nvarchar](50) NULL,
	[Birth] [datetime] NULL,
	[OldBirth] [nvarchar](30) NULL,
	[Zodiac] [nvarchar](10) NULL,
	[Money] [decimal](10, 0) NULL,
	[Phone] [nvarchar](30) NULL,
	[BTSType] [nvarchar](20) NULL,
	[GetPeo] [bigint] NULL,
	[AccId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleBTS] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleClient]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleClient](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ClientName] [nvarchar](100) NULL,
	[Gender] [nvarchar](5) NULL,
	[Idno] [nvarchar](20) NULL,
	[CellPhone1] [nvarchar](30) NULL,
	[CellPhone2] [nvarchar](30) NULL,
	[HomePhone1] [nvarchar](30) NULL,
	[HomePhone2] [nvarchar](30) NULL,
	[Birthday] [nvarchar](10) NULL,
	[Lbirthday] [nvarchar](10) NULL,
	[Bhour] [nvarchar](10) NULL,
	[PostZone] [nvarchar](10) NULL,
	[Address] [nvarchar](100) NULL,
	[ChYears] [nvarchar](10) NULL,
	[ZodiacSign] [nvarchar](10) NULL,
	[AddrNo] [nvarchar](10) NULL,
	[AddrMaster] [nvarchar](3) NULL,
	[OpenNum] [nvarchar](3) NULL,
	[Dingshu] [nvarchar](3) NULL,
	[IsDelete] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleClient] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleDon]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleDon](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Years] [nvarchar](10) NULL,
	[OrderNo] [nvarchar](30) NULL,
	[PurdueDate] [datetime] NULL,
	[Memo] [nvarchar](max) NULL,
	[Money] [decimal](25, 0) NULL,
	[ItemNo] [nvarchar](10) NULL,
	[GetPeo] [bigint] NULL,
	[AccId] [bigint] NULL,
	[TCId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleDon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleMember]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleMember](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](20) NULL,
	[Address] [nvarchar](100) NULL,
	[CellPhone01] [nvarchar](20) NULL,
	[HomePhone01] [nvarchar](20) NULL,
	[CellPhone02] [nvarchar](20) NULL,
	[HomePhone02] [nvarchar](20) NULL,
	[IsDelete] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](50) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](50) NULL,
 CONSTRAINT [PK_TempleMember] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemplePars]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemplePars](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[GPNo] [nvarchar](20) NULL,
	[ItemNo] [nvarchar](20) NULL,
	[ItemName] [nvarchar](200) NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TemplePars] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TemplePurdue]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TemplePurdue](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Years] [nvarchar](10) NULL,
	[OrderNo] [nvarchar](30) NULL,
	[PurdueDate] [datetime] NULL,
	[Memo] [nvarchar](max) NULL,
	[Money] [decimal](25, 0) NULL,
	[ItemNo] [nvarchar](10) NULL,
	[GetPeo] [bigint] NULL,
	[AccId] [bigint] NULL,
	[TCId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TemplePurdue] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleQx]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleQx](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[ModalName] [nvarchar](1) NULL,
	[QxName] [nvarchar](1) NULL,
	[url] [nvarchar](1) NULL,
	[bh] [nvarchar](1) NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](1) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](1) NULL,
 CONSTRAINT [PK_TempleQx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleRole]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleRole](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](30) NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleRole] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleRoleQx]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleRoleQx](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TempleRoleId] [bigint] NULL,
	[TempleQxId] [bigint] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleRoleQx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TempleUser]    Script Date: 2021/3/16 下午 10:44:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TempleUser](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UAccount] [varchar](50) NULL,
	[UPwd] [varchar](50) NULL,
	[UName] [nvarchar](50) NULL,
	[URoleId] [bigint] NULL,
	[URoleNameId] [bigint] NULL,
	[ExtRole] [nvarchar](200) NULL,
	[IsDelete] [int] NULL,
	[CreateDate] [datetime] NULL,
	[CreateName] [varchar](20) NULL,
	[UpdateDate] [datetime] NULL,
	[UpdateName] [varchar](20) NULL,
 CONSTRAINT [PK_TempleUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
