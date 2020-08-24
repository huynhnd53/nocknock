USE [NockNock]
GO
/****** Object:  User [as]    Script Date: 8/24/2020 8:24:34 PM ******/
CREATE USER [as] FOR LOGIN [as] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [as]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](32) NOT NULL,
	[Password] [nvarchar](32) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Article]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Article](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](100) NOT NULL,
	[content] [ntext] NOT NULL,
	[author] [varchar](50) NOT NULL,
	[datePost] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comment]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comment](
	[CommentID] [int] IDENTITY(1,1) NOT NULL,
	[PostID] [int] NOT NULL,
	[ProfileID] [int] NOT NULL,
	[CommentContent] [nvarchar](999) NOT NULL,
	[NotiID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CommentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Follow]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Follow](
	[FollowerID] [int] NOT NULL,
	[FollowedID] [int] NOT NULL,
	[NotiID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[FollowerID] ASC,
	[FollowedID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hashtag]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hashtag](
	[HashtagName] [nvarchar](255) NOT NULL,
	[PostID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Message](
	[MessageID] [int] IDENTITY(1,1) NOT NULL,
	[SenderID] [int] NOT NULL,
	[ReceiverID] [int] NOT NULL,
	[MessageContent] [nvarchar](999) NOT NULL,
	[MessageDate] [datetime] NOT NULL,
	[MarkAsReaded] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MessageID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Notification]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Notification](
	[NotiID] [int] IDENTITY(1,1) NOT NULL,
	[SenderID] [int] NOT NULL,
	[TargetID] [int] NOT NULL,
	[PostID] [int] NULL,
	[TypeNoti] [nvarchar](50) NULL,
	[NotiDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[NotiID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Post]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Post](
	[PostID] [int] IDENTITY(1,1) NOT NULL,
	[ProfileID] [int] NOT NULL,
	[PostContent] [nvarchar](999) NULL,
	[PostDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Profile]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profile](
	[ProfileID] [int] IDENTITY(1,1) NOT NULL,
	[AccountID] [int] NULL,
	[ProfileName] [nvarchar](32) NOT NULL,
	[Bio] [nvarchar](255) NULL,
	[Email] [nvarchar](100) NULL,
	[Phone] [nvarchar](10) NULL,
	[Gender] [bit] NULL,
	[DateOfBirth] [datetime] NULL,
	[ProfilePhoto] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ProfileID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reaction]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reaction](
	[TypeID] [int] NOT NULL,
	[PostID] [int] NOT NULL,
	[ProfileID] [int] NOT NULL,
	[NotiID] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReactionType]    Script Date: 8/24/2020 8:24:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReactionType](
	[TypeID] [int] NOT NULL,
	[TypeName] [nvarchar](50) NOT NULL,
	[IconSource] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (1, N'mra', N'mra')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (2, N'mrb', N'mrb')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (3, N'thuyndt', N'123456')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (4, N'yoseobie', N'sayhi')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (5, N'mrc', N'mrc')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (6, N'mrd', N'mrd')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (10, N'soo', N'123')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (11, N'mre', N'mre')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (12, N'dinhhuynh533', N'huynh')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (13, N'account1', N'passacc')
INSERT [dbo].[Account] ([AccountID], [Username], [Password]) VALUES (14, N'mrtoan', N'toan')
SET IDENTITY_INSERT [dbo].[Account] OFF
SET IDENTITY_INSERT [dbo].[Comment] ON 

INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (1, 6, 4, N'Hello', 3)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (3, 5, 1, N'chào c?u', 17)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (5, 9, 1, N'gi? tình phôi pha
', 26)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (10, 36, 1, N'oke', 31)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (11, 36, 1, N'hmm', 33)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (12, 42, 1, N'chào nha', 37)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (15, 42, 5, N'only one key thui nho', 41)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (16, 42, 5, N'gì dâyy', 42)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (17, 6, 2, N'mình cung chào c?u nhé', 43)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (18, 44, 3, N'ah yeah', 45)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (19, 42, 3, N'c?u thích hát bài gì nh?', 46)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (20, 9, 3, N'oops', 49)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (21, 5, 3, N'hi Lâm', 50)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (22, 1, 6, N'chào cou nh?. Thanks for following mình', 55)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (23, 23, 6, N'hj', 57)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (24, 1, 4, N'không có gì nhaa', 58)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (25, 1, 4, N'tui like bài c?a tui', 60)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (26, 1, 4, N'huhu', 61)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (27, 9, 2, N'chào c?u nha', 62)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (28, 9, 3, N'test 1', 66)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (29, 20, 3, N'o t? chua follow c?u nh?', 67)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (30, 5, 1, N'mình chua follow nhau mà v?n comment bài c?a nhau ? ', 68)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (31, 24, 1, N'okeconde
', 72)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (32, 5, 3, N'd? gi? mình follow c?u l?i nhé', 80)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (33, 7, 3, N'hi', 82)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (34, 9, 5, N'mình làm quen nhé', 87)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (35, 20, 5, N'h?c bài di', 89)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (36, 6, 2, N'tui là Johny', 90)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (37, 20, 1, N'oke nha', 93)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (38, 9, 5, N'uuuu', 94)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (40, 9, 3, N'yes', 98)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (41, 9, 3, N'', 99)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (45, 46, 5, N'xóa bài di nhé', 103)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (46, 46, 5, N'c?m on cou', 104)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (47, 46, 5, N'hmm', 105)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (48, 48, 2, N'well
', 107)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (49, 48, 2, N'you look bad', 108)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (50, 38, 1, N'help me?', 110)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (51, 38, 1, N'try this million thing', 111)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (52, 46, 1, N'nhung t ko thik xóa bài d?i', 113)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (53, 9, 1, N'did i say anything that i like you ?', 119)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (54, 53, 5, N'we''ll be alright', 127)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (55, 48, 5, N'hi johny', 128)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (56, 46, 6, N'chao nha', 131)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (57, 35, 6, N'mi khoe hong', 132)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (58, 35, 6, N'hong khoe lam', 133)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (59, 53, 2, N'hey wwhat''s wrong', 137)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (60, 54, 1, N'watch u bleeding', 142)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (61, 22, 1, N'Không có gì vui l?m dâu', 143)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (62, 22, 1, N'its was true', 145)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (63, 46, 1, N'days turn in', 146)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (64, 55, 2, N'aaaa', 149)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (65, 55, 2, N'hhhh', 150)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (66, 48, 2, N'ddi awn thui nao', 152)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (67, 48, 2, N'toan an db an cut', 153)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (68, 55, 2, N'dcm doi qua', 154)
INSERT [dbo].[Comment] ([CommentID], [PostID], [ProfileID], [CommentContent], [NotiID]) VALUES (69, 48, 1, N'hellooo ', 187)
SET IDENTITY_INSERT [dbo].[Comment] OFF
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (1, 2, 156)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (1, 3, 12)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (1, 4, 157)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (1, 6, 79)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (1, 8, 186)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (2, 1, 138)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (2, 3, 51)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (2, 5, 147)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (3, 1, 83)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 1, 166)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 2, 167)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 5, 162)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 6, 53)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 8, 163)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (4, 9, 164)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 1, 84)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 2, 129)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 3, 85)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 4, 162)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 6, 163)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 8, 164)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (5, 9, 166)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (6, 4, 123)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 1, 178)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 2, 179)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 3, 180)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 4, 181)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 5, 182)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 6, 183)
INSERT [dbo].[Follow] ([FollowerID], [FollowedID], [NotiID]) VALUES (12, 8, 184)
SET IDENTITY_INSERT [dbo].[Message] ON 

INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (1, 2, 6, N'Content User 2 send to User 6', CAST(N'2020-01-02T07:59:00.000' AS DateTime), 0)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (2, 2, 6, N'Content User 2 send to User 6', CAST(N'2020-01-02T08:10:00.000' AS DateTime), 0)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (3, 1, 4, N'Content User 1 send to User 4', CAST(N'2020-01-02T06:01:00.000' AS DateTime), 1)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (4, 4, 1, N'Content User 4 send to User 1', CAST(N'2020-01-02T06:02:22.000' AS DateTime), 1)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (5, 1, 4, N'Content User 1 send to User 4', CAST(N'2020-01-02T06:03:45.000' AS DateTime), 1)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (6, 3, 5, N'Content User 3 send to User 5', CAST(N'2020-01-02T12:59:59.000' AS DateTime), 1)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (7, 5, 3, N'Content User 5 send to User 3', CAST(N'2020-01-02T13:01:32.000' AS DateTime), 1)
INSERT [dbo].[Message] ([MessageID], [SenderID], [ReceiverID], [MessageContent], [MessageDate], [MarkAsReaded]) VALUES (8, 3, 5, N'Content User 3 send to User 5', CAST(N'2020-01-02T13:59:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[Message] OFF
SET IDENTITY_INSERT [dbo].[Notification] ON 

INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (2, 3, 2, 6, N'Like', CAST(N'2020-07-03T16:12:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (3, 4, 2, 6, N'Comment', CAST(N'2020-07-04T11:59:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (4, 2, 4, 1, N'Like', CAST(N'2020-07-02T13:59:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (9, 1, 3, 5, N'Like', CAST(N'2020-02-20T16:16:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (12, 1, 3, NULL, N'Follow', CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (17, 1, 3, 5, N'Comment', CAST(N'2020-07-25T17:12:32.433' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (25, 1, 3, 9, N'Like', CAST(N'2020-07-25T17:23:16.893' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (26, 1, 3, 9, N'Comment', CAST(N'2020-07-25T17:23:23.190' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (31, 1, 1, 36, N'Comment', CAST(N'2020-07-25T17:33:46.730' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (33, 1, 1, 36, N'Comment', CAST(N'2020-07-25T17:33:55.383' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (35, 5, 5, 42, N'Like', CAST(N'2020-07-25T18:08:40.563' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (36, 1, 5, 42, N'Like', CAST(N'2020-07-25T19:40:22.247' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (37, 1, 5, 42, N'Comment', CAST(N'2020-07-25T19:40:34.167' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (38, 1, 1, 36, N'Like', CAST(N'2020-07-25T19:41:20.387' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (41, 5, 5, 42, N'Comment', CAST(N'2020-07-25T19:47:50.557' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (42, 5, 5, 42, N'Comment', CAST(N'2020-07-25T20:16:25.737' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (43, 2, 2, 6, N'Comment', CAST(N'2020-07-25T20:17:37.420' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (45, 3, 5, 44, N'Comment', CAST(N'2020-07-25T20:18:05.110' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (46, 3, 5, 42, N'Comment', CAST(N'2020-07-25T20:18:16.313' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (49, 3, 3, 9, N'Comment', CAST(N'2020-07-25T20:19:28.060' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (50, 3, 3, 5, N'Comment', CAST(N'2020-07-25T20:19:49.203' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (51, 2, 3, NULL, N'Follow', CAST(N'2020-07-20T00:00:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (53, 4, 6, NULL, N'Follow', CAST(N'2020-07-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (55, 6, 4, 1, N'Comment', CAST(N'2020-07-25T20:26:17.817' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (56, 6, 6, 23, N'Like', CAST(N'2020-07-25T20:26:32.717' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (57, 6, 6, 23, N'Comment', CAST(N'2020-07-25T20:26:37.113' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (58, 4, 4, 1, N'Comment', CAST(N'2020-07-25T20:28:18.240' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (59, 4, 4, 1, N'Like', CAST(N'2020-07-25T20:28:40.520' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (60, 4, 4, 1, N'Comment', CAST(N'2020-07-25T20:28:47.097' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (61, 4, 4, 1, N'Comment', CAST(N'2020-07-25T20:29:13.730' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (62, 2, 3, 9, N'Comment', CAST(N'2020-07-25T21:11:06.537' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (63, 2, 3, 5, N'Like', CAST(N'2020-07-25T21:15:03.460' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (64, 3, 3, 5, N'Like', CAST(N'2020-07-25T21:15:54.720' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (65, 3, 3, 9, N'Like', CAST(N'2020-07-25T21:15:59.850' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (66, 3, 3, 9, N'Comment', CAST(N'2020-07-25T21:16:09.287' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (67, 3, 1, 20, N'Comment', CAST(N'2020-07-25T21:29:03.160' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (68, 1, 3, 5, N'Comment', CAST(N'2020-07-25T21:29:40.623' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (70, 1, 6, 23, N'Like', CAST(N'2020-07-25T23:48:16.383' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (71, 1, 6, 24, N'Like', CAST(N'2020-07-25T23:48:25.680' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (72, 1, 6, 24, N'Comment', CAST(N'2020-07-25T23:48:29.980' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (73, 1, 8, 27, N'Like', CAST(N'2020-07-25T23:48:35.020' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (79, 1, 6, NULL, N'Follow', CAST(N'2020-07-25T23:54:48.130' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (80, 3, 3, 5, N'Comment', CAST(N'2020-07-25T23:55:49.933' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (81, 3, 1, 20, N'Like', CAST(N'2020-07-25T23:56:27.617' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (82, 3, 1, 7, N'Comment', CAST(N'2020-07-25T23:56:38.593' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (83, 3, 1, NULL, N'Follow', CAST(N'2020-07-25T23:56:44.333' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (84, 5, 1, NULL, N'Follow', CAST(N'2020-07-25T23:57:24.660' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (85, 5, 3, NULL, N'Follow', CAST(N'2020-07-25T23:57:40.537' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (86, 5, 3, 9, N'Like', CAST(N'2020-07-25T23:57:59.640' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (87, 5, 3, 9, N'Comment', CAST(N'2020-07-25T23:58:05.477' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (88, 5, 1, 20, N'Like', CAST(N'2020-07-25T23:58:40.830' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (89, 5, 1, 20, N'Comment', CAST(N'2020-07-25T23:58:49.377' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (90, 2, 2, 6, N'Comment', CAST(N'2020-07-25T23:59:20.900' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (91, 2, 3, 9, N'Like', CAST(N'2020-07-25T23:59:28.383' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (93, 1, 1, 20, N'Comment', CAST(N'2020-07-26T00:27:56.293' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (94, 5, 3, 9, N'Comment', CAST(N'2020-07-26T00:28:34.210' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (98, 3, 3, 9, N'Comment', CAST(N'2020-07-26T00:38:24.427' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (99, 3, 3, 9, N'Comment', CAST(N'2020-07-26T00:38:30.720' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (103, 5, 1, 46, N'Comment', CAST(N'2020-07-26T00:40:44.467' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (104, 5, 1, 46, N'Comment', CAST(N'2020-07-26T00:40:50.307' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (105, 5, 1, 46, N'Comment', CAST(N'2020-07-26T00:40:56.140' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (107, 2, 2, 48, N'Comment', CAST(N'2020-07-26T00:53:04.763' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (108, 2, 2, 48, N'Comment', CAST(N'2020-07-26T00:53:10.323' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (110, 1, 6, 38, N'Comment', CAST(N'2020-07-26T20:12:14.027' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (111, 1, 6, 38, N'Comment', CAST(N'2020-07-26T20:12:20.337' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (112, 1, 1, 46, N'Like', CAST(N'2020-07-26T20:14:55.097' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (113, 1, 1, 46, N'Comment', CAST(N'2020-07-26T20:15:05.303' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (119, 1, 3, 9, N'Comment', CAST(N'2020-07-26T20:26:14.223' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (121, 6, 4, 1, N'Like', CAST(N'2020-07-26T20:26:49.583' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (123, 6, 4, NULL, N'Follow', CAST(N'2020-07-26T20:27:06.027' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (124, 6, 6, 38, N'Like', CAST(N'2020-07-26T20:27:18.357' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (127, 5, 5, 53, N'Comment', CAST(N'2020-07-26T20:42:20.103' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (128, 5, 2, 48, N'Comment', CAST(N'2020-07-26T20:42:30.253' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (129, 5, 2, NULL, N'Follow', CAST(N'2020-07-26T20:43:04.613' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (130, 6, 1, 46, N'Like', CAST(N'2020-07-26T22:50:47.847' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (131, 6, 1, 46, N'Comment', CAST(N'2020-07-26T22:50:52.187' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (132, 6, 1, 35, N'Comment', CAST(N'2020-07-26T22:50:59.510' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (133, 6, 1, 35, N'Comment', CAST(N'2020-07-26T22:51:03.837' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (134, 6, 1, 45, N'Like', CAST(N'2020-07-26T22:51:08.767' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (135, 6, 1, 34, N'Like', CAST(N'2020-07-26T22:51:14.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (136, 2, 5, 53, N'Like', CAST(N'2020-07-27T00:48:17.713' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (137, 2, 5, 53, N'Comment', CAST(N'2020-07-27T00:48:24.377' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (138, 2, 1, NULL, N'Follow', CAST(N'2020-07-27T00:48:36.553' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (139, 2, 1, 45, N'Like', CAST(N'2020-07-27T00:48:44.450' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (140, 2, 1, 46, N'Like', CAST(N'2020-07-27T00:51:04.487' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (142, 1, 1, 54, N'Comment', CAST(N'2020-07-27T01:02:56.160' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (143, 1, 6, 22, N'Comment', CAST(N'2020-07-27T01:04:23.873' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (144, 1, 6, 22, N'Like', CAST(N'2020-07-27T01:06:03.210' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (145, 1, 6, 22, N'Comment', CAST(N'2020-07-27T01:06:31.990' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (146, 1, 1, 46, N'Comment', CAST(N'2020-07-27T01:07:26.773' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (147, 2, 5, NULL, N'Follow', CAST(N'2020-07-27T15:40:53.413' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (148, 2, 1, 55, N'Like', CAST(N'2020-07-27T16:08:38.123' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (149, 2, 1, 55, N'Comment', CAST(N'2020-07-27T16:08:41.470' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (150, 2, 1, 55, N'Comment', CAST(N'2020-07-27T16:08:44.443' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (151, 2, 2, 48, N'Like', CAST(N'2020-07-27T19:23:21.643' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (152, 2, 2, 48, N'Comment', CAST(N'2020-07-27T19:23:28.830' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (153, 2, 2, 48, N'Comment', CAST(N'2020-07-27T19:23:35.827' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (154, 2, 1, 55, N'Comment', CAST(N'2020-07-27T19:24:05.697' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (156, 1, 2, NULL, N'Follow', CAST(N'2020-07-28T16:48:05.503' AS DateTime))
GO
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (157, 1, 4, NULL, N'Follow', CAST(N'2020-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (162, 4, 5, NULL, N'Follow', CAST(N'2020-03-02T12:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (163, 4, 8, NULL, N'Follow', CAST(N'2020-03-02T12:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (164, 4, 9, NULL, N'Follow', CAST(N'2020-01-02T12:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (166, 4, 1, NULL, N'Follow', CAST(N'2020-03-02T15:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (167, 4, 2, NULL, N'Follow', CAST(N'2020-03-02T21:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (168, 5, 4, NULL, N'Follow', CAST(N'2020-03-02T15:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (169, 5, 6, NULL, N'Follow', CAST(N'2020-03-02T21:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (170, 5, 8, NULL, N'Follow', CAST(N'2020-03-02T12:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (171, 5, 9, NULL, N'Follow', CAST(N'2020-03-02T12:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (172, 9, 1, NULL, N'Follow', CAST(N'2020-03-02T10:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (173, 9, 2, NULL, N'Follow', CAST(N'2020-03-02T09:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (174, 9, 3, NULL, N'Follow', CAST(N'2020-03-02T14:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (175, 9, 4, NULL, N'Follow', CAST(N'2020-03-02T17:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (176, 9, 5, NULL, N'Follow', CAST(N'2020-03-02T19:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (177, 9, 6, NULL, N'Follow', CAST(N'2020-03-02T20:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (178, 12, 1, NULL, N'Follow', CAST(N'2020-01-02T15:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (179, 12, 2, NULL, N'Follow', CAST(N'2020-02-02T21:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (180, 12, 3, NULL, N'Follow', CAST(N'2020-03-02T03:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (181, 12, 4, NULL, N'Follow', CAST(N'2020-03-02T07:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (182, 12, 5, NULL, N'Follow', CAST(N'2020-01-02T10:12:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (183, 12, 6, NULL, N'Follow', CAST(N'2020-03-02T04:21:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (184, 12, 8, NULL, N'Follow', CAST(N'2020-03-02T22:29:11.000' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (185, 12, 1, NULL, N'Follow', CAST(N'2020-07-29T14:29:49.060' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (186, 1, 8, NULL, N'Follow', CAST(N'2020-07-29T15:25:31.740' AS DateTime))
INSERT [dbo].[Notification] ([NotiID], [SenderID], [TargetID], [PostID], [TypeNoti], [NotiDate]) VALUES (187, 1, 2, 48, N'Comment', CAST(N'2020-07-30T20:41:55.517' AS DateTime))
SET IDENTITY_INSERT [dbo].[Notification] OFF
SET IDENTITY_INSERT [dbo].[Post] ON 

INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (1, 4, N'Content post 2 of 4 User', CAST(N'2020-01-02T10:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (2, 1, N'Content post 3 of 1 User', CAST(N'2020-01-03T15:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (3, 6, N'Content post 4 of 6 User', CAST(N'2020-01-04T07:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (4, 5, N'Content post 5 of 5 User', CAST(N'2020-01-05T20:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (5, 3, N'Content post 6 of 3 User', CAST(N'2020-01-06T22:00:00.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (6, 2, N'Xin chao moi nguoi', CAST(N'2020-07-20T11:23:23.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (7, 1, N'Hello there', CAST(N'2020-02-09T18:19:10.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (9, 3, N'Day la post thu 2', CAST(N'2020-05-12T11:11:11.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (19, 1, N'ahihi', CAST(N'2020-07-23T15:44:40.377' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (20, 1, N'say hi mn oi', CAST(N'2020-07-23T17:37:50.233' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (21, 1, N'oke la bla bla', CAST(N'2020-07-23T17:38:00.623' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (22, 6, N'co gi vui ko mn oi', CAST(N'2020-07-23T17:39:39.753' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (23, 6, N'minh co 2 post chua nhi', CAST(N'2020-07-23T17:42:58.277' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (24, 6, N'oke mn nho', CAST(N'2020-07-23T17:43:06.040' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (25, 6, N'slo slo', CAST(N'2020-07-23T17:45:12.520' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (26, 8, N'chao mn', CAST(N'2020-07-23T23:51:06.643' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (27, 8, N'hello', CAST(N'2020-07-24T01:44:30.167' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (28, 8, N'aloo', CAST(N'2020-07-24T01:44:37.313' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (29, 8, N'mình dang nghe bài này hay l?m á mn', CAST(N'2020-07-24T01:44:45.670' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (30, 1, N'mn khoe ko :v', CAST(N'2020-07-24T02:19:58.230' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (31, 1, N'hiiii', CAST(N'2020-07-24T02:22:20.180' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (32, 1, N'Don''t tell me how to love
you love yourself', CAST(N'2020-07-24T02:24:45.750' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (33, 1, N'bullshit', CAST(N'2020-07-24T02:31:04.263' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (34, 1, N'only bitch', CAST(N'2020-07-24T02:31:11.803' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (35, 1, N'wut', CAST(N'2020-07-24T02:31:16.873' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (36, 1, N'haaaaaaaaaaaaaaaaaaa', CAST(N'2020-07-24T02:31:22.770' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (37, 6, N'alo', CAST(N'2020-07-24T02:44:58.000' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (38, 6, N'chào mn nhìu
mình tên là Lâm chí thanh', CAST(N'2020-07-24T02:55:45.847' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (39, 2, N'????', CAST(N'2020-07-24T03:31:53.490' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (41, 5, N'alooooo', CAST(N'2020-07-25T18:08:27.337' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (42, 5, N'hi guys', CAST(N'2020-07-25T18:08:37.263' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (43, 5, N'talk is kinda overrate today', CAST(N'2020-07-25T19:44:31.233' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (44, 5, N'bring it all out', CAST(N'2020-07-25T19:46:22.197' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (45, 1, N'f done', CAST(N'2020-07-25T23:51:16.017' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (46, 1, N'mm', CAST(N'2020-07-25T23:55:07.167' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (47, 5, N'hi guys', CAST(N'2020-07-25T23:57:17.577' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (48, 2, N'moshimoshi', CAST(N'2020-07-25T23:59:47.683' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (50, 5, N'tatan', CAST(N'2020-07-26T00:40:12.137' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (53, 5, N'who makes you happier', CAST(N'2020-07-26T20:42:10.650' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (54, 1, N'i did dream of something really funny last night, but..i''m not gonna tell ya', CAST(N'2020-07-27T01:02:44.463' AS DateTime))
INSERT [dbo].[Post] ([PostID], [ProfileID], [PostContent], [PostDate]) VALUES (55, 1, N'i was only seventeen', CAST(N'2020-07-27T01:07:03.310' AS DateTime))
SET IDENTITY_INSERT [dbo].[Post] OFF
SET IDENTITY_INSERT [dbo].[Profile] ON 

INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (1, 1, N'Nguy?n Lâm ', N'Bio of ALam', N'mra@gmail.com', N'09888888', 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'stranger.png')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (2, 2, N'Johny', N'Bio of B', N'mrb@gmail.com', N'09888888', 0, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'baek.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (3, 3, N'Jennie Kim', N'Bio of C', N'mrc@gmail.com', N'09888888', 0, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'exo.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (4, 4, N'Yang Baekhyun', N'Bio of D', N'mrd@gmail.com', N'09888888', 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'blackpink.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (5, 5, N'Hoàng Anh', N'Bio of E', N'mre@gmail.com', N'09888888', 0, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'hope.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (6, 6, N'Lee Dong Wook', N'Bio of F', N'mrf@gmail.com', N'09888888', 1, CAST(N'1990-01-01T00:00:00.000' AS DateTime), N'minh.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (8, 10, N'Soohyuk kute', N'alo', N'hihihih@email.com', N'208343', 0, CAST(N'2000-12-12T00:00:00.000' AS DateTime), N'soo.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (9, 11, N'Dao Quoc Toan', N'Toan Buscu', N'toandq@gmail.com', N'0129999931', 0, CAST(N'2000-10-10T00:00:00.000' AS DateTime), N'toandq.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (10, 12, N'Ðình Huynh', N'My name Huynh', N'huynh@gmail.com', N'913131313', 1, CAST(N'2000-10-10T00:00:00.000' AS DateTime), N'huynhQuay.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (11, 13, N'Hu?ng Minh Ð?c', N'My shirt color ping', N'duc@gmail.com', N'913131313', 0, CAST(N'2004-11-10T00:00:00.000' AS DateTime), N'duc.jpg')
INSERT [dbo].[Profile] ([ProfileID], [AccountID], [ProfileName], [Bio], [Email], [Phone], [Gender], [DateOfBirth], [ProfilePhoto]) VALUES (12, 14, N'Toan Real', N'My favarite is buscu', N'toancc+@gmail.com', N'913131313', 0, CAST(N'2000-04-09T00:00:00.000' AS DateTime), N'toanreal.jpg')
SET IDENTITY_INSERT [dbo].[Profile] OFF
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 6, 3, 2)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 1, 2, 4)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 5, 1, 9)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 23, 1, 70)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 9, 1, 25)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 53, 2, 136)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 42, 5, 35)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 42, 1, 36)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 36, 1, 38)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 24, 1, 71)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 45, 2, 139)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 23, 6, 56)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 1, 4, 59)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 5, 2, 63)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 5, 3, 64)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 9, 3, 65)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 27, 1, 73)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 46, 2, 140)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 20, 3, 81)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 9, 5, 86)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 20, 5, 88)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 9, 2, 91)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 46, 1, 112)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 1, 6, 121)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 38, 6, 124)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 22, 1, 144)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 46, 6, 130)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 45, 6, 134)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 34, 6, 135)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 55, 2, 148)
INSERT [dbo].[Reaction] ([TypeID], [PostID], [ProfileID], [NotiID]) VALUES (1, 48, 2, 151)
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (1, N'Like', N'like.img')
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (2, N'Haha', N'haha.img')
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (3, N'Sad', N'sad.img')
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (4, N'Angry', N'angry.img')
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (5, N'WOW', N'wow.img')
INSERT [dbo].[ReactionType] ([TypeID], [TypeName], [IconSource]) VALUES (6, N'Heart', N'heart.img')
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([NotiID])
REFERENCES [dbo].[Notification] ([NotiID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
GO
ALTER TABLE [dbo].[Comment]  WITH CHECK ADD FOREIGN KEY([ProfileID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Follow]  WITH CHECK ADD FOREIGN KEY([FollowedID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Follow]  WITH CHECK ADD FOREIGN KEY([FollowerID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Follow]  WITH CHECK ADD FOREIGN KEY([NotiID])
REFERENCES [dbo].[Notification] ([NotiID])
GO
ALTER TABLE [dbo].[Hashtag]  WITH CHECK ADD FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD FOREIGN KEY([ReceiverID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Message]  WITH CHECK ADD FOREIGN KEY([SenderID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Notification]  WITH CHECK ADD FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
GO
ALTER TABLE [dbo].[Notification]  WITH CHECK ADD FOREIGN KEY([SenderID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Notification]  WITH CHECK ADD FOREIGN KEY([TargetID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Post]  WITH CHECK ADD FOREIGN KEY([ProfileID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Profile]  WITH CHECK ADD FOREIGN KEY([AccountID])
REFERENCES [dbo].[Account] ([AccountID])
GO
ALTER TABLE [dbo].[Reaction]  WITH CHECK ADD FOREIGN KEY([NotiID])
REFERENCES [dbo].[Notification] ([NotiID])
GO
ALTER TABLE [dbo].[Reaction]  WITH CHECK ADD FOREIGN KEY([PostID])
REFERENCES [dbo].[Post] ([PostID])
GO
ALTER TABLE [dbo].[Reaction]  WITH CHECK ADD FOREIGN KEY([ProfileID])
REFERENCES [dbo].[Profile] ([ProfileID])
GO
ALTER TABLE [dbo].[Reaction]  WITH CHECK ADD FOREIGN KEY([TypeID])
REFERENCES [dbo].[ReactionType] ([TypeID])
GO
