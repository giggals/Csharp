CREATE TABLE Students (
	StudentID INT IDENTITY NOT NULL ,
	[Name] NVARCHAR(32) NOT NULL,

	CONSTRAINT PK_Students
	PRIMARY KEY (StudentID)
)

CREATE TABLE Exams (
   ExamID INT NOT NULL,
   [Name] NVARCHAR(32) NOT NULL,

   CONSTRAINT PK_Exams
   PRIMARY KEY(ExamID)
)

CREATE TABLE StudentsExams (
   StudentID INT NOT NULL,
   ExamID INT NOT NULL,

   CONSTRAINT PK_StudentExams
   PRIMARY KEY (StudentID , ExamID),
   CONSTRAINT FK_StudentExams_Students
   FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
   CONSTRAINT FK_StudentExams_Exams
   FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
)


INSERT Students([Name]) VALUES
('Mila'),
('Toni'),
('Ron')

INSERT Exams(ExamID,[Name]) VALUES
(101, 'SpringMVC'),
(102, 'Neo4j'),
(103, 'Oracle 11g')

INSERT StudentsExams(StudentID, ExamID) VALUES
(1, 101),
(1, 102),
(2, 101),
(3, 103),
(2, 102),
(2, 103)