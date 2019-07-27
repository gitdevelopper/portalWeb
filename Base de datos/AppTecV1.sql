
/*
CREATE DATABASE SeguridadAppTecBD;
CREATE DATABASE AppTecBD;


*/
USE AppTecBD;


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[AdminsID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[LastNameP] [varchar](20) NOT NULL,
	[LastNameM] [varchar](20) NOT NULL,
	[Users] [varchar](50) NOT NULL,
	[Pass] [varchar](200) NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[Photo] [varchar](max) NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autentication]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autentication](
	[IdToken] [int] IDENTITY(1,1) NOT NULL,
	[User] [varchar](100) NOT NULL,
	[Pass] [varchar](100) NOT NULL,
	[Token] [varchar](700) NOT NULL,
	[Inssued] [datetime] NOT NULL,
	[Deleted] [datetime] NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdToken] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Binnacle]    Script Date: 28/06/2019 07:48:17 p. m. ******/


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Binnacle](
	[BinnacleID] [int] IDENTITY(1,1) NOT NULL,
	[Actions] [varchar](200) NOT NULL,
	[Users] [varchar](200) NOT NULL,
	[Error] [varchar](300) NOT NULL,
	[Messages] [varchar](200) NULL,
	[DateTime] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BinnacleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Careers]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Careers](
	[CareersID] [int] IDENTITY(1,1) NOT NULL,
	[Key] [varchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CareersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Classrooms]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classrooms](
	[ClassroomID] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [varchar](100) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[ClassRoomTypeID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassroomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassRoomType]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassRoomType](
	[ClassRoomTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Description] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ClassRoomTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Degree]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Degree](
	[DegreeID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DegreeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DegreeSubjects]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DegreeSubjects](
	[DegreeSubjectsID] [int] IDENTITY(1,1) NOT NULL,
	[DegreeID] [int] NOT NULL,
	[SubjectsID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DegreeSubjectsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EducationLevels]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EducationLevels](
	[EducationLevelID] [int] IDENTITY(1,1) NOT NULL,
	[Level] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EducationLevelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employers](
	[EmployersID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[LastNameP] [varchar](20) NOT NULL,
	[LastNameM] [varchar](20) NOT NULL,
	[RFC] [varchar](20) NOT NULL,
	[RolesID] [int] NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployersID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Groups]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Groups](
	[GroupsID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](200) NOT NULL,
	[UserModification] [varchar](200) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[GroupsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Institutions]    Script Date: 28/06/2019 07:48:17 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institutions](
	[InstitutionID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Direction] [varchar](250) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[EducationLevelID] [int] NOT NULL,
	[Logo] [varchar](200) NOT NULL,
	[Director] [varchar](200) NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[InstitutionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lessons]    Script Date: 28/06/2019 07:48:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lessons](
	[LessonsID] [int] IDENTITY(1,1) NOT NULL,
	[Days] [varchar](15) NOT NULL,
	[EmployersID] [int] NOT NULL,
	[HousStart] [time](7) NOT NULL,
	[HourFinish] [time](7) NOT NULL,
	[ClassroomID] [int] NOT NULL,
	[SubjectsID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LessonsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 28/06/2019 07:48:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolesID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RolesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 28/06/2019 07:48:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Speciality](
	[SpecialityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](200) NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SpecialityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 28/06/2019 07:48:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[StudentsID] [int] IDENTITY(1,1) NOT NULL,
	[Enrollment] [varchar](100) NOT NULL,
	[Name] [varchar](30) NOT NULL,
	[LastNameP] [varchar](20) NOT NULL,
	[LastNameM] [varchar](20) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[InstitutionID] [int] NOT NULL,
	[GroupsID] [int] NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
	[DegreeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subjects]    Script Date: 28/06/2019 07:48:18 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subjects](
	[SubjectsID] [int] IDENTITY(1,1) NOT NULL,
	[Clave] [varchar](50) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Credits] [int] NOT NULL,
	[CareersID] [int] NOT NULL,
	[SpecialityID] [int] NOT NULL,
	[DateTimeCreation] [datetime] NOT NULL,
	[DateTimeModification] [datetime] NOT NULL,
	[UserCreation] [varchar](250) NOT NULL,
	[UserModification] [varchar](250) NOT NULL,
	[Status] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[SubjectsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO



SET IDENTITY_INSERT [dbo].[Admins] ON 
GO
INSERT [dbo].[Admins] ([AdminsID], [Name], [LastNameP], [LastNameM], [Users], [Pass], [InstitutionID], [Photo], [DateTimeCreation], [DateTimeModification], [UserCreation], [UserModification], [Status]) VALUES (1, N'Super ', N'Admin', N'Base de datos', N'SuperPowerUser', N'passwordAppTec', 1, N'', CAST(N'2019-06-25T09:11:49.000' AS DateTime), CAST(N'2019-06-25T09:11:52.000' AS DateTime), N'SuperPowerUser', N'SuperPowerUser', 1)
GO
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO





SET IDENTITY_INSERT [dbo].[ClassRoomType] ON 
GO
INSERT [dbo].[ClassRoomType] ([ClassRoomTypeID], [Name], [Description]) VALUES (1, N'Salon', N'Salon de clases')
GO
INSERT [dbo].[ClassRoomType] ([ClassRoomTypeID], [Name], [Description]) VALUES (2, N'Lab', N'Labotatorio')
GO
SET IDENTITY_INSERT [dbo].[ClassRoomType] OFF
GO








SET IDENTITY_INSERT [dbo].[EducationLevels] ON 
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (1, N'Telesecundaria')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (2, N'Secundaria Gral')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (3, N'Secundaria Tecnica')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (4, N'Bachillerato Gral')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (5, N'CTIS')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (6, N'BTIS')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (7, N'Bachillerato Digital')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (8, N'Preparatoria')
GO
INSERT [dbo].[EducationLevels] ([EducationLevelID], [Level]) VALUES (9, N'Universidad')
GO
SET IDENTITY_INSERT [dbo].[EducationLevels] OFF
GO







SET IDENTITY_INSERT [dbo].[Institutions] ON 
GO
INSERT [dbo].[Institutions] ([InstitutionID], [Name], [Direction], [Phone], [EducationLevelID], [Logo], [Director], [DateTimeCreation], [DateTimeModification], [UserCreation], [UserModification], [Status]) VALUES (1, N'Instituto Tecnologico Superior de Tepeaca', N'75200 Tepeaca, Pue.', N'34242', 9, N'', N'Mtro. Eliseo Ramirez', CAST(N'2019-06-25T09:00:44.000' AS DateTime), CAST(N'2019-06-25T09:00:49.000' AS DateTime), N'SuperPowerUser', N'SuperPowerUser', N'1')
GO
SET IDENTITY_INSERT [dbo].[Institutions] OFF
GO






SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([RolesID], [Name]) VALUES (1, N'Administracion')
GO
INSERT [dbo].[Roles] ([RolesID], [Name]) VALUES (2, N'Mantenimiento')
GO
INSERT [dbo].[Roles] ([RolesID], [Name]) VALUES (3, N'Direccion')
GO
INSERT [dbo].[Roles] ([RolesID], [Name]) VALUES (4, N'Profesor')
GO
INSERT [dbo].[Roles] ([RolesID], [Name]) VALUES (7, N'Jefatura de Academia')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO









ALTER TABLE [dbo].[Admins]  WITH CHECK ADD  CONSTRAINT [Fk_AdminsInstitutions] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Admins] CHECK CONSTRAINT [Fk_AdminsInstitutions]
GO
ALTER TABLE [dbo].[Careers]  WITH CHECK ADD  CONSTRAINT [Fk_CareesInst] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Careers] CHECK CONSTRAINT [Fk_CareesInst]
GO
ALTER TABLE [dbo].[Classrooms]  WITH CHECK ADD  CONSTRAINT [Fk_ClassRoomInst] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Classrooms] CHECK CONSTRAINT [Fk_ClassRoomInst]
GO
ALTER TABLE [dbo].[Classrooms]  WITH CHECK ADD  CONSTRAINT [Fk_ClassroomsClassRoomType] FOREIGN KEY([ClassRoomTypeID])
REFERENCES [dbo].[ClassRoomType] ([ClassRoomTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Classrooms] CHECK CONSTRAINT [Fk_ClassroomsClassRoomType]
GO
ALTER TABLE [dbo].[DegreeSubjects]  WITH CHECK ADD  CONSTRAINT [Fk_DegreeSubjectsDegree] FOREIGN KEY([DegreeID])
REFERENCES [dbo].[Degree] ([DegreeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[DegreeSubjects] CHECK CONSTRAINT [Fk_DegreeSubjectsDegree]
GO
ALTER TABLE [dbo].[DegreeSubjects]  WITH CHECK ADD  CONSTRAINT [Fk_DegreeSubjectsSubj] FOREIGN KEY([SubjectsID])
REFERENCES [dbo].[Subjects] ([SubjectsID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[DegreeSubjects] CHECK CONSTRAINT [Fk_DegreeSubjectsSubj]
GO
ALTER TABLE [dbo].[Employers]  WITH CHECK ADD  CONSTRAINT [Fk_EmployeInst] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Employers] CHECK CONSTRAINT [Fk_EmployeInst]
GO
ALTER TABLE [dbo].[Employers]  WITH CHECK ADD  CONSTRAINT [FK_EmployeRols] FOREIGN KEY([RolesID])
REFERENCES [dbo].[Roles] ([RolesID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO


ALTER TABLE [dbo].[Employers] CHECK CONSTRAINT [FK_EmployeRols]
GO
ALTER TABLE [dbo].[Institutions]  WITH CHECK ADD  CONSTRAINT [fk_nivel] FOREIGN KEY([EducationLevelID])
REFERENCES [dbo].[EducationLevels] ([EducationLevelID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Institutions] CHECK CONSTRAINT [fk_nivel]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [Fk_ClassLesson] FOREIGN KEY([ClassroomID])
REFERENCES [dbo].[Classrooms] ([ClassroomID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [Fk_ClassLesson]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [Fk_LessonsEmployers] FOREIGN KEY([EmployersID])
REFERENCES [dbo].[Employers] ([EmployersID])
GO



ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [Fk_LessonsEmployers]
GO
ALTER TABLE [dbo].[Lessons]  WITH CHECK ADD  CONSTRAINT [Fk_LessonSubj] FOREIGN KEY([SubjectsID])
REFERENCES [dbo].[Subjects] ([SubjectsID])
GO


ALTER TABLE [dbo].[Lessons] CHECK CONSTRAINT [Fk_LessonSubj]
GO
ALTER TABLE [dbo].[Speciality]  WITH CHECK ADD  CONSTRAINT [Fk_SpecialityInstitution] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
GO



ALTER TABLE [dbo].[Speciality] CHECK CONSTRAINT [Fk_SpecialityInstitution]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [Fk_StudenDegree] FOREIGN KEY([DegreeId])
REFERENCES [dbo].[Degree] ([DegreeID])
GO



ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [Fk_StudenDegree]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [Fk_StudentsGroups] FOREIGN KEY([GroupsID])
REFERENCES [dbo].[Groups] ([GroupsID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [Fk_StudentsGroups]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [Fk_StudentsInst] FOREIGN KEY([InstitutionID])
REFERENCES [dbo].[Institutions] ([InstitutionID])
GO



ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [Fk_StudentsInst]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [Fk_CareesSubje] FOREIGN KEY([CareersID])
REFERENCES [dbo].[Careers] ([CareersID])
GO



ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [Fk_CareesSubje]
GO
ALTER TABLE [dbo].[Subjects]  WITH CHECK ADD  CONSTRAINT [Fk_SpecialitySubjects] FOREIGN KEY([SpecialityID])
REFERENCES [dbo].[Speciality] ([SpecialityID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO



ALTER TABLE [dbo].[Subjects] CHECK CONSTRAINT [Fk_SpecialitySubjects]
GO

/*
USE [master]
GO
ALTER DATABASE [Apptec] SET  READ_WRITE 
GO

*/
