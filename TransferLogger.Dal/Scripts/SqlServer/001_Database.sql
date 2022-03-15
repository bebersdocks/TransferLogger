﻿DECLARE @Version INT;

SET @Version = 1.000;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'DbInfo')
BEGIN

CREATE TABLE Organization (
	OrganizationId INT IDENTITY(1,1) NOT NULL,
	OrganizationType INT NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Description NVARCHAR(60) NULL,
	Country INT NOT NULL,
	Url NVARCHAR(100) NULL
);

ALTER TABLE Organization ADD CONSTRAINT PK_Organization PRIMARY KEY (OrganizationId);

CREATE TABLE Program (
	ProgramId INT IDENTITY(1,1) NOT NULL,
	OrganizationId INT NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Cycle INT NOT NULL,
	Year INT NOT NULL
)

ALTER TABLE Program ADD CONSTRAINT PK_Program PRIMARY KEY (ProgramId);
ALTER TABLE Program ADD CONSTRAINT FK_ProgramOrganization FOREIGN KEY (OrganizationId) REFERENCES Organization(OrganizationId);

CREATE TABLE Course (
	CourseId INT IDENTITY(1,1) NOT NULL,
	CourseCode NVARCHAR(10) NOT NULL,
	OrganizationId INT NOT NULL,
	ProgramId INT NULL,
	Name NVARCHAR(30) NULL,
	Description NVARCHAR(60) NULL,
	Credits INT NULL,
	WeeklyHours INT NULL
);

ALTER TABLE Course ADD CONSTRAINT PK_Course PRIMARY KEY (CourseId);
ALTER TABLE Course ADD CONSTRAINT FK_CourseOrganization FOREIGN KEY (OrganizationId) REFERENCES Organization(OrganizationId);

CREATE TABLE Student (
	StudentId INT IDENTITY(1,1) NOT NULL,
	Reference NVARCHAR(15) NULL,
	Name NVARCHAR(30) NOT NULL,
	Middle NVARCHAR(30) NULL,
	Surname NVARCHAR(100) NOT NULL,
	DocumentNo NVARCHAR(15) NOT NULL,
	Phone NVARCHAR(15) NULL,
	Email NVARCHAR(60) NULL
);

ALTER TABLE Student ADD CONSTRAINT PK_Student PRIMARY KEY (StudentId);

CREATE TABLE Instructor (
	InstructorId INT IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Middle NVARCHAR(30) NULL,
	Surname NVARCHAR(100) NOT NULL,
	Phone NVARCHAR(15) NULL,
	Email NVARCHAR(60) NOT NULL
);

ALTER TABLE Instructor ADD CONSTRAINT PK_Instructor PRIMARY KEY (InstructorId);

CREATE TABLE Application (
	ApplicationId INT IDENTITY(1,1) NOT NULL,
	ApplicationStatus INT NOT NULL,
	StudentId INT NOT NULL,
	OrganizationId INT NOT NULL,
	CreatedAt DATETIME NOT NULL,
	SubmittedAt DATETIME NULL
);

ALTER TABLE Application ADD CONSTRAINT PK_Application PRIMARY KEY (ApplicationId);
ALTER TABLE Application ADD CONSTRAINT FK_ApplicationStudent FOREIGN KEY (StudentId) REFERENCES Student(StudentId);
ALTER TABLE Application ADD CONSTRAINT FK_ApplicationOrganization FOREIGN KEY (OrganizationId) REFERENCES Organization(OrganizationId);

CREATE TABLE ApplicationCourse (
	ApplicationId INT NOT NULL,
	CourseId INT NOT NULL,
	MatchedCourseId INT NULL,
	InstructorId INT NOT NULL,
	Status INT NULL,
	Comment NVARCHAR (300) NULL,
	Grade NVARCHAR (8) NOT NULL
);

ALTER TABLE ApplicationCourse ADD CONSTRAINT FK_ApplicationCourseApplication FOREIGN KEY (ApplicationId) REFERENCES Application(ApplicationId); 
ALTER TABLE ApplicationCourse ADD CONSTRAINT FK_ApplicationCourseCourse FOREIGN KEY (CourseId) REFERENCES Course(CourseId);
ALTER TABLE ApplicationCourse ADD CONSTRAINT FK_ApplicationCourseMatchedCourse FOREIGN KEY (MatchedCourseId) REFERENCES Course(CourseId);
ALTER TABLE ApplicationCourse ADD CONSTRAINT FK_ApplicationCourseInstructor FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId);

CREATE TABLE ApplicationExcelLocation (
	ApplicationId INT NOT NULL,
	Path NVARCHAR(100) NOT NULL
);

ALTER TABLE ApplicationExcelLocation ADD CONSTRAINT FK_ApplicationExcelLocationApplication FOREIGN KEY (ApplicationId) REFERENCES Application(ApplicationId); 

CREATE TABLE DbInfo (
	Version decimal(6,3) NOT NULL,
	UpdatedAt DATETIME NOT NULL
);

INSERT INTO DbInfo (Version, UpdatedAt) VALUES (@Version,  GETUTCDATE());

END