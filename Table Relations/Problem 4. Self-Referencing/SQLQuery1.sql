CREATE TABLE Teachers (
  TeacherID INT NOT NULL,
  [Name] NVARCHAR(32) NOT NULL,
  ManagerID INT 

  CONSTRAINT PK_Teachers
  PRIMARY KEY(TeacherID),

  CONSTRAINT FK_ManagerID_TeacherID
  FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers VALUES 
(101 ,'John' , NUll),
(102 ,'Maya' , 106),
(103 ,'Silvia' ,  106),
(104 ,'Ted' , 105),
(105 ,'Mark' , 101),
(106 ,'Greta' , 101)