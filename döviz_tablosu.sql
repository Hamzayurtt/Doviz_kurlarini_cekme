USE [döviz]
GO
/****** Object:  Table [dbo].[döviz_tablosu]    Script Date: 15.08.2023 15:11:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[döviz_tablosu](
	[Tarih] [smalldatetime] NOT NULL,
	[Dolar] [float] NULL,
	[Euro] [float] NULL,
	[Sterlin] [float] NULL,
	[Arap_Riyali] [float] NULL,
	[Kuveyt_Dinarı] [float] NULL,
	[İsviçre_Frangı] [float] NULL,
 CONSTRAINT [PK_döviz_tablosu] PRIMARY KEY CLUSTERED 
(
	[Tarih] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-05-23T14:33:00' AS SmallDateTime), 19.87, 21.48, 24.76, 22.21, 5.33, 65.93)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-05-23T14:34:00' AS SmallDateTime), 19.87, 21.48, 24.76, 22.21, 5.33, 65.93)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-05-23T15:55:00' AS SmallDateTime), 19.89, 21.46, 24.71, 22.14, 5.33, 65.97)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-06-10T14:45:00' AS SmallDateTime), 23.50, 25.31, 29.55, 26.16, 6.30, 77.96)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-06-10T15:27:00' AS SmallDateTime), 23.50, 25.31, 29.55, 26.16, 6.30, 77.96)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-08-02T13:48:00' AS SmallDateTime), 27.02, 29.67, 34.68, 30.97, 7.24, 89.57)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-08-11T14:07:00' AS SmallDateTime), 27.08, 29.83, 34.60, 31.06, 7.26, 89.78)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-08-11T14:08:00' AS SmallDateTime), 27.08, 29.83, 34.60, 31.06, 7.26, 89.78)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-08-13T11:41:00' AS SmallDateTime), 27.09, 29.78, 34.49, 30.98, 7.26, 89.77)
INSERT [dbo].[döviz_tablosu] ([Tarih], [Dolar], [Euro], [Sterlin], [Arap_Riyali], [Kuveyt_Dinarı], [İsviçre_Frangı]) VALUES (CAST(N'2023-08-15T14:58:00' AS SmallDateTime), 27.10, 29.66, 34.46, 30.98, 7.26, 89.80)
GO
ALTER TABLE [dbo].[döviz_tablosu] ADD  CONSTRAINT [DF_döviz_tablosu_Tarih]  DEFAULT (getdate()) FOR [Tarih]
GO
