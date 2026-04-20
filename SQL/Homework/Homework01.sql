
DROP DATABASE IF EXISTS [SEDCACADEMYDB]
GO

CREATE DATABASE SEDCACADEMYDB
GO

USE SEDCACADEMYDB
GO

CREATE TABLE Student(
[ID] int IDENTITY(1,1),
[FirstName] nvarchar(100) NOT NULL,
[LastName] nvarchar(100) NOT NULL,
[DateOfBirth] Date NULL,
[EnrolledDate] Date NULL,
[Gender] nchar(1) NULL,
[NationalIDNumber] nvarchar(20) NULL,
[StudentCardNumber] nvarchar(20) NULL,
CONSTRAINT [PK_Student] PRIMARY KEY (ID)
)
GO

CREATE TABLE Teacher(
[ID] int IDENTITY(1,1),
[FirstName] nvarchar(100) NOT NULL,
[LastName] nvarchar(100) NOT NULL,
[DateOfBirth] Date NULL,
[AcademicRank] nvarchar(10) NULL,
[HireDate] Date NULL,
CONSTRAINT [PK_Teacher] PRIMARY KEY (ID)
)
GO

CREATE TABLE Course(
[ID] int IDENTITY(1,1),
[Name] nvarchar(100) NULL,
[Credit] INT NULL,
[AcademicYear] Date NULL,
[Semester] nvarchar(20) NULL,
CONSTRAINT [PK_Course] PRIMARY KEY(ID)
)
GO

CREATE TABLE Grade(
[ID] int IDENTITY(1,1),
[StudentID] int NULL,
[CourseID] int NULL,
[TeacherID] int NULL,
[Grade] int NOT NULL,
[Comment] nvarchar(MAX) NULL,
[CreatedDate] Date NULL,
CONSTRAINT [PK_Grade] PRIMARY KEY(ID)
)
GO

CREATE TABLE AchievementType(
[ID] int IDENTITY(1,1),
[Name] nvarchar(100) NULL,
[Description] nvarchar(MAX) NULL,
CONSTRAINT [PK_AchievementType] PRIMARY KEY(ID)
)
GO

CREATE Table GradeDetails(
[ID] int IDENTITY(1,1),
[AchievementTypeID] int NULL,
[AchivementPoints] int NULL,
[AchievementMaxPoints] int NULL,
[AchievementDate] Date Null,
CONSTRAINT [PK_GradeDetails] PRIMARY KEY(ID)
)
GO