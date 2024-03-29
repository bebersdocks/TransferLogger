﻿DECLARE @Version INT;

SET @Version = 1.000;

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = N'DbInfo')
BEGIN

CREATE TABLE Organization (
	OrganizationId INT IDENTITY(1,1) NOT NULL,
	OrganizationType INT NOT NULL,
	Name NVARCHAR(60) NOT NULL,
	Description NVARCHAR(100) NULL,
	Country INT NOT NULL,
	Url NVARCHAR(100) NULL
);

ALTER TABLE Organization ADD CONSTRAINT PK_Organization PRIMARY KEY (OrganizationId);
ALTER TABLE Organization ADD CONSTRAINT UC_Organization UNIQUE (OrganizationType, Name, Country); 

SET IDENTITY_INSERT Organization ON;

INSERT INTO Organization (OrganizationId, OrganizationType, Name, Country) 
VALUES (1, 3, 'YourOrganization', 236);

SET IDENTITY_INSERT Organization OFF;

CREATE TABLE Program (
	ProgramId INT IDENTITY(1,1) NOT NULL,
	OrganizationId INT NOT NULL,
	Name NVARCHAR(60) NOT NULL,
	Cycle INT NOT NULL,
	Year INT NOT NULL
)

ALTER TABLE Program ADD CONSTRAINT PK_Program PRIMARY KEY (ProgramId);
ALTER TABLE Program ADD CONSTRAINT FK_ProgramOrganization FOREIGN KEY (OrganizationId) REFERENCES Organization(OrganizationId);
ALTER TABLE Program ADD CONSTRAINT UC_Program UNIQUE (OrganizationId, Name, Cycle, Year); 

CREATE TABLE Course (
	CourseId INT IDENTITY(1,1) NOT NULL,
	CourseCode NVARCHAR(10) NOT NULL,
	ProgramId INT NOT NULL,
	Name NVARCHAR(100) NULL,
	Description NVARCHAR(300) NULL,
	Credits INT NULL,
	WeeklyHours INT NULL
);

ALTER TABLE Course ADD CONSTRAINT PK_Course PRIMARY KEY (CourseId);
ALTER TABLE Course ADD CONSTRAINT FK_CourseProgram FOREIGN KEY (ProgramId) REFERENCES Program(ProgramId);
ALTER TABLE Course ADD CONSTRAINT UC_Course UNIQUE (CourseCode, ProgramId); 

CREATE TABLE Student (
	StudentId INT IDENTITY(1,1) NOT NULL,
	Reference NVARCHAR(15) NULL,
	Name NVARCHAR(30) NOT NULL,
	Middle NVARCHAR(30) NULL,
	Surname NVARCHAR(100) NOT NULL,
	DocumentNo NVARCHAR(30) NULL,
	Phone NVARCHAR(30) NULL,
	Email NVARCHAR(100) NULL
);

ALTER TABLE Student ADD CONSTRAINT PK_Student PRIMARY KEY (StudentId);

CREATE TABLE Instructor (
	InstructorId INT IDENTITY(1,1) NOT NULL,
	Name NVARCHAR(30) NOT NULL,
	Middle NVARCHAR(30) NULL,
	Surname NVARCHAR(100) NOT NULL,
	Phone NVARCHAR(30) NULL,
	Email NVARCHAR(100) NOT NULL
);

ALTER TABLE Instructor ADD CONSTRAINT PK_Instructor PRIMARY KEY (InstructorId);
ALTER TABLE Instructor ADD CONSTRAINT UC_Instructor UNIQUE (Name, Surname, Email);

CREATE TABLE Application (
	ApplicationId INT IDENTITY(1,1) NOT NULL,
	ApplicationStatus INT NOT NULL,
	StudentId INT NOT NULL,
	SourceOrganizationId INT NOT NULL,
	TargetProgramId INT NOT NULL,
	ExcelLocation NVARCHAR(180) NULL,
	CreatedAt DATETIME NOT NULL,
	UpdatedAt DATETIME NULL,
	CompletedAt DATETIME NULL
);

ALTER TABLE Application ADD CONSTRAINT PK_Application PRIMARY KEY (ApplicationId);
ALTER TABLE Application ADD CONSTRAINT FK_ApplicationStudent FOREIGN KEY (StudentId) REFERENCES Student(StudentId);
ALTER TABLE Application ADD CONSTRAINT FK_ApplicationSourceOrganization FOREIGN KEY (SourceOrganizationId) REFERENCES Organization(OrganizationId);
ALTER TABLE Application ADD CONSTRAINT FK_ApplicationTargetProgram FOREIGN KEY (TargetProgramId) REFERENCES Program(ProgramId);

CREATE TABLE ApplicationAttachment (
	ApplicationAttachmentId INT IDENTITY(1,1) NOT NULL,
	ApplicationId INT NOT NULL,
	FileName NVARCHAR(100) NOT NULL,
	Data VARBINARY(MAX) NOT NULL
);

ALTER TABLE ApplicationAttachment ADD CONSTRAINT PK_ApplicationAttachment PRIMARY KEY (ApplicationAttachmentId);
ALTER TABLE ApplicationAttachment ADD CONSTRAINT FK_ApplicationAttachmentApplication FOREIGN KEY (ApplicationId) REFERENCES Application(ApplicationId);

CREATE TABLE Evaluation (
	EvaluationId INT IDENTITY(1,1) NOT NULL,
	EvaluationStatus INT NOT NULL,
	ApplicationId INT NOT NULL,
	CourseId INT NOT NULL,
	InstructorId INT NOT NULL,
	SuggestedCourseId INT NULL,
	MatchedCourseId INT NULL,
	LinkedEvaluationId INT NULL,
	Comment NVARCHAR (300) NULL
);

ALTER TABLE Evaluation ADD CONSTRAINT PK_Evaluation PRIMARY KEY (EvaluationId);
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationApplication FOREIGN KEY (ApplicationId) REFERENCES Application(ApplicationId); 
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationCourse FOREIGN KEY (CourseId) REFERENCES Course(CourseId);
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationInstructor FOREIGN KEY (InstructorId) REFERENCES Instructor(InstructorId);
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationSuggestedCourse FOREIGN KEY (SuggestedCourseId) REFERENCES Course(CourseId);
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationMatchedCourse FOREIGN KEY (MatchedCourseId) REFERENCES Course(CourseId);
ALTER TABLE Evaluation ADD CONSTRAINT FK_EvaluationLinkedEvaluation FOREIGN KEY (LinkedEvaluationId) REFERENCES Evaluation(EvaluationId);

CREATE TABLE DbInfo (
	Version decimal(6,3) NOT NULL,
	UpdatedAt DATETIME NOT NULL
);

INSERT INTO DbInfo (Version, UpdatedAt) VALUES (@Version,  GETUTCDATE());

END
