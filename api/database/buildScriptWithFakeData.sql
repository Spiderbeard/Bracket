USE [final_capstone]
GO
/****** Object:  Table [dbo].[match]    Script Date: 12/15/2020 5:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[match](
	[matchnumber] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
	[scoreteam1] [int] NULL,
	[scoreteam2] [int] NULL,
	[team1winner] [bit] NULL,
	[team2winner] [bit] NULL,
	[round_id] [int] NOT NULL,
	[match_id] [int] IDENTITY(1,1) NOT NULL,
	[team1] [int] NOT NULL,
	[team2] [int] NOT NULL,
 CONSTRAINT [PK_match] PRIMARY KEY CLUSTERED 
(
	[match_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[participants]    Script Date: 12/15/2020 5:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[participants](
	[participant_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[isActive] [bit] NOT NULL,
 CONSTRAINT [PK_participants] PRIMARY KEY CLUSTERED 
(
	[participant_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rounds]    Script Date: 12/15/2020 5:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rounds](
	[roundnumber] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
	[tournament_id] [bigint] NOT NULL,
	[round_id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_rounds] PRIMARY KEY CLUSTERED 
(
	[round_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tournament]    Script Date: 12/15/2020 5:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tournament](
	[tournament_id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[numberofparticipants] [int] NOT NULL,
	[currentround] [int] NOT NULL,
	[organizer_id] [int] NOT NULL,
 CONSTRAINT [PK_tournament] PRIMARY KEY CLUSTERED 
(
	[tournament_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/15/2020 5:21:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password_hash] [varchar](200) NOT NULL,
	[salt] [varchar](200) NOT NULL,
	[user_role] [varchar](50) NOT NULL,
	[email] [nvarchar](50) NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[match] ON 
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (1, 1, NULL, NULL, NULL, NULL, 1, 1, 1, 4)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (2, 1, NULL, NULL, NULL, NULL, 1, 3, 7, 6)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (3, 1, NULL, NULL, NULL, NULL, 1, 4, 8, 9)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (4, 1, NULL, NULL, NULL, NULL, 1, 5, 10, 11)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (5, 1, NULL, NULL, NULL, NULL, 1, 6, 12, 13)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (6, 1, NULL, NULL, NULL, NULL, 1, 7, 14, 15)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (7, 1, NULL, NULL, NULL, NULL, 1, 8, 16, 17)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (8, 1, NULL, NULL, NULL, NULL, 1, 9, 18, 19)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (9, 1, NULL, NULL, NULL, NULL, 2, 10, 1, 7)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (10, 1, NULL, NULL, NULL, NULL, 2, 11, 8, 10)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (11, 1, NULL, NULL, NULL, NULL, 2, 12, 12, 14)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (12, 1, NULL, NULL, NULL, NULL, 2, 13, 16, 18)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (13, 1, NULL, NULL, NULL, NULL, 3, 14, 1, 8)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (14, 1, NULL, NULL, NULL, NULL, 3, 15, 12, 16)
GO
INSERT [dbo].[match] ([matchnumber], [isActive], [scoreteam1], [scoreteam2], [team1winner], [team2winner], [round_id], [match_id], [team1], [team2]) VALUES (15, 1, NULL, NULL, NULL, NULL, 4, 16, 1, 12)
GO
SET IDENTITY_INSERT [dbo].[match] OFF
GO
SET IDENTITY_INSERT [dbo].[participants] ON 
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (1, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (4, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (6, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (7, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (8, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (9, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (10, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (11, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (12, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (13, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (14, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (15, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (16, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (17, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (18, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (19, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (20, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (21, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (22, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (23, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (24, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (25, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (26, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (27, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (28, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (29, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (30, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (31, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (32, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (33, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (34, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (35, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (36, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (37, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (38, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (39, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (40, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (41, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (42, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (43, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (44, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (45, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (46, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (47, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (48, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (49, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (50, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (51, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (52, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (53, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (54, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (55, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (56, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (57, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (58, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (59, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (60, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (61, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (62, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (63, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (64, N'dummy', 1)
GO
INSERT [dbo].[participants] ([participant_id], [name], [isActive]) VALUES (65, N'dummy', 1)
GO
SET IDENTITY_INSERT [dbo].[participants] OFF
GO
SET IDENTITY_INSERT [dbo].[rounds] ON 
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (1, 1, 1, 1)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (2, 1, 1, 2)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (3, 1, 1, 3)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (4, 1, 1, 4)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (1, 1, 2, 5)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (2, 1, 2, 6)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (3, 1, 2, 7)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (4, 1, 2, 8)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (1, 1, 3, 9)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (2, 1, 3, 10)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (3, 1, 3, 11)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (4, 1, 3, 12)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (1, 1, 6, 14)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (2, 1, 6, 15)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (3, 1, 6, 16)
GO
INSERT [dbo].[rounds] ([roundnumber], [isActive], [tournament_id], [round_id]) VALUES (4, 1, 6, 17)
GO
SET IDENTITY_INSERT [dbo].[rounds] OFF
GO
SET IDENTITY_INSERT [dbo].[tournament] ON 
GO
INSERT [dbo].[tournament] ([tournament_id], [name], [numberofparticipants], [currentround], [organizer_id]) VALUES (1, N'Fake Tournament', 16, 1, 1)
GO
INSERT [dbo].[tournament] ([tournament_id], [name], [numberofparticipants], [currentround], [organizer_id]) VALUES (2, N'Pokemon Tournament', 16, 1, 1)
GO
INSERT [dbo].[tournament] ([tournament_id], [name], [numberofparticipants], [currentround], [organizer_id]) VALUES (3, N'Magic the Gathering Tournament', 16, 1, 2)
GO
INSERT [dbo].[tournament] ([tournament_id], [name], [numberofparticipants], [currentround], [organizer_id]) VALUES (6, N'Dungeon Crawl Classics', 16, 1, 3)
GO
INSERT [dbo].[tournament] ([tournament_id], [name], [numberofparticipants], [currentround], [organizer_id]) VALUES (7, N'Ultimate Deveoper Hack-Off', 16, 1, 4)
GO
SET IDENTITY_INSERT [dbo].[tournament] OFF
GO
SET IDENTITY_INSERT [dbo].[users] ON 
GO
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt], [user_role], [email]) VALUES (1, N'user', N'Jg45HuwT7PZkfuKTz6IB90CtWY4=', N'LHxP4Xh7bN0=', N'user', NULL)
GO
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt], [user_role], [email]) VALUES (2, N'admin', N'YhyGVQ+Ch69n4JMBncM4lNF/i9s=', N'Ar/aB2thQTI=', N'admin', NULL)
GO
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt], [user_role], [email]) VALUES (3, N'fakeuser', N'sdfasdf', N'asdfsd', N'user', NULL)
GO
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt], [user_role], [email]) VALUES (4, N'another fake user', N'blahblah', N'blah', N'user', NULL)
GO
INSERT [dbo].[users] ([user_id], [username], [password_hash], [salt], [user_role], [email]) VALUES (5, N'ultimate fake user', N'dflksdji', N'aldufoeij', N'user', NULL)
GO
SET IDENTITY_INSERT [dbo].[users] OFF
GO
ALTER TABLE [dbo].[match] ADD  CONSTRAINT [DF_match_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[participants] ADD  CONSTRAINT [DF_participants_isActive]  DEFAULT ((1)) FOR [isActive]
GO
ALTER TABLE [dbo].[match]  WITH CHECK ADD  CONSTRAINT [FK_match_participants_team1] FOREIGN KEY([team1])
REFERENCES [dbo].[participants] ([participant_id])
GO
ALTER TABLE [dbo].[match] CHECK CONSTRAINT [FK_match_participants_team1]
GO
ALTER TABLE [dbo].[match]  WITH CHECK ADD  CONSTRAINT [FK_match_participants_team2] FOREIGN KEY([team2])
REFERENCES [dbo].[participants] ([participant_id])
GO
ALTER TABLE [dbo].[match] CHECK CONSTRAINT [FK_match_participants_team2]
GO
ALTER TABLE [dbo].[match]  WITH CHECK ADD  CONSTRAINT [FK_match_round] FOREIGN KEY([round_id])
REFERENCES [dbo].[rounds] ([round_id])
GO
ALTER TABLE [dbo].[match] CHECK CONSTRAINT [FK_match_round]
GO
ALTER TABLE [dbo].[rounds]  WITH CHECK ADD  CONSTRAINT [FK_rounds_tournament] FOREIGN KEY([tournament_id])
REFERENCES [dbo].[tournament] ([tournament_id])
GO
ALTER TABLE [dbo].[rounds] CHECK CONSTRAINT [FK_rounds_tournament]
GO
ALTER TABLE [dbo].[tournament]  WITH CHECK ADD  CONSTRAINT [FK_tournament_users1] FOREIGN KEY([organizer_id])
REFERENCES [dbo].[users] ([user_id])
GO
ALTER TABLE [dbo].[tournament] CHECK CONSTRAINT [FK_tournament_users1]
GO
