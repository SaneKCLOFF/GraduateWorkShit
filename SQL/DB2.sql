CREATE DATABASE ScheduleDataBase
GO
USE ScheduleDataBase
GO

--СОЗДАНИЕ ДАЗ БАННЫХ
CREATE TABLE Specialties
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(100) NOT NULL
)

CREATE TABLE Teachers
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	LastName VARCHAR(50) NOT NULL,
	FirstName VARCHAR(50) NOT NULL,
	MiddleName VARCHAR(50) NOT NULL,
)

CREATE TABLE Subjects
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
	TeacherId INT REFERENCES Teachers(ID)
)

CREATE TABLE Groups
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
	SpecialtyId INT REFERENCES Specialties(ID) NOT NULL,
	DateOfEnrollment DATE NOT NULL,
)

CREATE TABLE Cabinets
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Number INT NOT NULL,
)

CREATE TABLE Timetable
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	[Time] VARCHAR(11) NOT NULL,
)

CREATE TABLE ClassTypes
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(25) NOT NULL,
)

CREATE TABLE Classes
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	SubjectId INT REFERENCES Subjects(ID) NOT NULL,
	GroupId INT REFERENCES Groups(ID) NOT NULL,
	CabinetId INT REFERENCES Cabinets(ID) NOT NULL,
	TimetableID INT REFERENCES Timetable(ID) NOT NULL,
	ClassTypeID INT REFERENCES ClassTypes(ID) NOT NULL,
	DateOfClass DATE NOT NULL
)
GO

INSERT INTO [dbo].[Specialties]
           ([Title])
     VALUES
           ('Информационные системы и программирование'),
		   ('Какая-то специальность')
GO

INSERT INTO [dbo].[Teachers]
           ([LastName]
           ,[FirstName]
           ,[MiddleName])
     VALUES
           ('Лукьянов', 'Иван', 'Львович'),
		   ('Попова', 'Виктория', 'Александровна'),
		   ('Дементьева', 'Алёна', 'Фёдоровна')
GO

INSERT INTO [dbo].[Subjects]
           ([Title]
           ,[TeacherId])
     VALUES
           ('Математика',1),
		   ('Русский язык',2),
		   ('Литература',3),
		   ('Физика',1),
		   ('Английский язык',2),
		   ('Химия',3)
GO

INSERT INTO [dbo].[Groups]
           ([Title]
		   ,[SpecialtyId]
           ,[DateOfEnrollment])
     VALUES
           ('ИСП',1,'01/09/2019')
GO

INSERT INTO [dbo].[Cabinets]
           ([Number])
     VALUES
           (232),
		   (224),
		   (231),
		   (234)
GO

INSERT INTO [dbo].[Timetable]
           ([Time])
     VALUES
           ('8:00-9:20'),
		   ('9:30-10:50'),
		   ('11:00-12:20')
GO

INSERT INTO [dbo].[ClassTypes]
           ([Title])
     VALUES
           ('Практика'),
		   ('Лекция')
GO

INSERT INTO [dbo].[Classes]
           ([SubjectId]
           ,[GroupId]
           ,[CabinetId]
           ,[TimetableID]
           ,[ClassTypeID]
		   ,[DateOfClass])
     VALUES
           (1,1,2,1,2,'27/02/2023'),
		   (2,1,2,2,2,'27/02/2023'),
		   (4,1,2,3,1,'27/02/2023')

GO



--DROP TABLE Classes
--DROP TABLE ClassTypes
--DROP TABLE Timetable
--DROP TABLE Cabinets
--DROP TABLE Groups
--DROP TABLE Subjects
--DROP TABLE Teachers
--DROP TABLE Specialties