USE [Телеком Нева Связь]
GO
/****** Object:  Table [dbo].[Данные по оборудованию]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Данные по оборудованию](
	[ID оборудования] [int] NOT NULL,
	[Наименование оборудования] [varchar](100) NULL,
	[Тип] [int] NULL,
	[Серийный номер] [varchar](100) NULL,
	[MAC-адрес] [varchar](100) NULL,
	[IP-адрес] [varchar](100) NULL,
	[Номер телефона] [varchar](100) NULL,
	[Дата установки] [date] NULL,
 CONSTRAINT [PK_Данные по оборудованию] PRIMARY KEY CLUSTERED 
(
	[ID оборудования] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Данные по подключению абонентов]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Данные по подключению абонентов](
	[Порт] [int] NOT NULL,
	[Оборудование] [int] NULL,
	[Адрес] [varchar](100) NULL,
	[Тип порта] [int] NULL,
	[Имя] [varchar](100) NULL,
	[Фамилия] [varchar](100) NULL,
	[Отчество] [varchar](100) NULL,
 CONSTRAINT [PK_Данные по подключению абонентов] PRIMARY KEY CLUSTERED 
(
	[Порт] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Пользователи]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Пользователи](
	[ID пользователя] [int] NOT NULL,
	[Имя] [varchar](100) NULL,
	[Фамилия] [varchar](100) NULL,
	[Отчество] [varchar](100) NULL,
	[Номер] [varchar](100) NULL,
	[Пароль] [varchar](100) NULL,
	[Почта] [varchar](100) NULL,
	[Номер телефона] [varchar](20) NULL,
	[Роль] [int] NULL,
 CONSTRAINT [PK_Пользователи] PRIMARY KEY CLUSTERED 
(
	[ID пользователя] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Роли]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Роли](
	[ID Роли] [int] NOT NULL,
	[Наименование] [varchar](100) NULL,
 CONSTRAINT [PK_Роли] PRIMARY KEY CLUSTERED 
(
	[ID Роли] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Тип оборудования]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Тип оборудования](
	[ID типа оборудования] [int] NOT NULL,
	[Тип оборудования] [varchar](100) NULL,
 CONSTRAINT [PK_Тип оборудования] PRIMARY KEY CLUSTERED 
(
	[ID типа оборудования] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Тип порта]    Script Date: 12.05.2022 17:47:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Тип порта](
	[ID типа порта] [int] NOT NULL,
	[Тип порта] [varchar](100) NULL,
 CONSTRAINT [PK_Тип порта] PRIMARY KEY CLUSTERED 
(
	[ID типа порта] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Данные по оборудованию]  WITH CHECK ADD  CONSTRAINT [FK_Данные по оборудованию_Тип оборудования] FOREIGN KEY([Тип])
REFERENCES [dbo].[Тип оборудования] ([ID типа оборудования])
GO
ALTER TABLE [dbo].[Данные по оборудованию] CHECK CONSTRAINT [FK_Данные по оборудованию_Тип оборудования]
GO
ALTER TABLE [dbo].[Данные по подключению абонентов]  WITH CHECK ADD  CONSTRAINT [FK_Данные по подключению абонентов_Данные по оборудованию] FOREIGN KEY([Оборудование])
REFERENCES [dbo].[Данные по оборудованию] ([ID оборудования])
GO
ALTER TABLE [dbo].[Данные по подключению абонентов] CHECK CONSTRAINT [FK_Данные по подключению абонентов_Данные по оборудованию]
GO
ALTER TABLE [dbo].[Данные по подключению абонентов]  WITH CHECK ADD  CONSTRAINT [FK_Данные по подключению абонентов_Тип оборудования] FOREIGN KEY([Оборудование])
REFERENCES [dbo].[Тип оборудования] ([ID типа оборудования])
GO
ALTER TABLE [dbo].[Данные по подключению абонентов] CHECK CONSTRAINT [FK_Данные по подключению абонентов_Тип оборудования]
GO
ALTER TABLE [dbo].[Данные по подключению абонентов]  WITH CHECK ADD  CONSTRAINT [FK_Данные по подключению абонентов_Тип порта] FOREIGN KEY([Тип порта])
REFERENCES [dbo].[Тип порта] ([ID типа порта])
GO
ALTER TABLE [dbo].[Данные по подключению абонентов] CHECK CONSTRAINT [FK_Данные по подключению абонентов_Тип порта]
GO
ALTER TABLE [dbo].[Пользователи]  WITH CHECK ADD  CONSTRAINT [FK_Пользователи_Роли] FOREIGN KEY([Роль])
REFERENCES [dbo].[Роли] ([ID Роли])
GO
ALTER TABLE [dbo].[Пользователи] CHECK CONSTRAINT [FK_Пользователи_Роли]
GO
