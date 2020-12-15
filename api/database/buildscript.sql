USE [final_capstone]
GO
/****** Object:  Table [dbo].[match]    Script Date: 12/15/2020 1:40:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[match](
	[matchnumber] [int] NOT NULL,
	[isActive] [bit] NOT NULL,
	[scoreteam1] [int] NULL,
	[scoreteam2] [int] NULL,
	[team1winner] [bit] NOT NULL,
	[team2winner] [bit] NOT NULL,
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
/****** Object:  Table [dbo].[participants]    Script Date: 12/15/2020 1:40:13 PM ******/
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
/****** Object:  Table [dbo].[rounds]    Script Date: 12/15/2020 1:40:13 PM ******/
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
/****** Object:  Table [dbo].[tournament]    Script Date: 12/15/2020 1:40:13 PM ******/
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
/****** Object:  Table [dbo].[users]    Script Date: 12/15/2020 1:40:13 PM ******/
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
ALTER TABLE [dbo].[match] ADD  CONSTRAINT [DF_match_isActive]  DEFAULT ((1)) FOR [isActive]
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

--populate default data
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');

GO