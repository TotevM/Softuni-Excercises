CREATE DATABASE Demo

--1
CREATE TABLE Passports
(
PasswordID INT PRIMARY KEY IDENTITY(101,1),
PassportNumber VARCHAR(60) NOT NULL,
)

CREATE TABLE Persons
(
PersonID INT PRIMARY KEY IDENTITY,
FirstName VARCHAR(60) NOT NULL,
Salary DECIMAL(10,2) NOT NULL,
PassportID INT REFERENCES Passports(PasswordID) UNIQUE
)

INSERT INTO Passports(PassportNumber)
VALUES('N34FG21B'),('K65LO4R7'),('ZE657QP2')

INSERT INTO Persons(FirstName,Salary,PassportID)
			VALUES	('Roberto',43300,102),
					('Tom', 56100,103),
					('Yana',60200,101)

--2
CREATE TABLE Manufacturers
(
	ManufacturerID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(32) NOT NULL,
	EstablishedOn DATETIME2
)

CREATE TABLE Models
(
	ModelID INT PRIMARY KEY IDENTITY(101, 1),
	[Name] VARCHAR(32) NOT NULL,
	ManufacturerID INT FOREIGN KEY REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Manufacturers
	VALUES  ('BMW', '07/03/1916'),
				('Tesla', '01/01/2003'),
				('Lada', '01/05/1966')

INSERT INTO Models
	VALUES  ('X1', 1),
			('i6', 1),
			('Model S', 2),
			('Model X', 2),
			('Model 3', 2),
			('Nova', 3)

--3
			CREATE TABLE Students
(
	StudentID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(32) NOT NULL
)
CREATE TABLE Exams
(
	ExamID INT PRIMARY KEY IDENTITY(101, 1),
	[Name] VARCHAR(32) NOT NULL
)
CREATE TABLE StudentsExams
(
	StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
	ExamID INT FOREIGN KEY REFERENCES Exams(ExamID),
	CONSTRAINT PK_StudentsExams PRIMARY KEY(StudentID, ExamID) -- Composite primary key
)
INSERT INTO Students
	VALUES('Mila'),
			('Toni'),
			('Ron')

INSERT INTO Exams
	VALUES('SpringMVC'),
			('Neo4j'),
			('Oracle 11g')

INSERT INTO StudentsExams
	VALUES (1, 101),
			(1, 102),
			(2, 101),
			(3, 103),
			(2, 102),
			(2, 103)

--4
CREATE TABLE Teachers
(
	TeacherID INT PRIMARY KEY,
	[Name] VARCHAR(32) NOT NULL,
	ManagerID INT REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers VALUES(101, 'John', NULL)
INSERT INTO Teachers VALUES(106, 'Greta', 101)
INSERT INTO Teachers VALUES(105, 'Mark', 101)
INSERT INTO Teachers VALUES(104, 'Ted', 105)
INSERT INTO Teachers VALUES(102, 'Maya', 106)
INSERT INTO Teachers VALUES(103, 'Silvia', 106)

--5
CREATE TABLE ItemTypes
(
	ItemTypeID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(32) NOT NULL
)

CREATE TABLE Items
(
	ItemID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(128) NOT NULL,
	ItemTypeID INT FOREIGN KEY REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Cities
(
	CityID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(64) NOT NULL
)

CREATE TABLE Customers
(
	CustomerID INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(64) NOT NULL,
	Birthday DATETIME2,
	CityID INT FOREIGN KEY REFERENCES Cities(CityID)
)
CREATE TABLE Orders
(
	OrderID INT PRIMARY KEY IDENTITY,
	CustomerID INT FOREIGN KEY REFERENCES Customers(CustomerID)
)
CREATE TABLE OrderItems
(
	OrderID INT FOREIGN KEY REFERENCES Orders(OrderID),
	ItemID INT FOREIGN KEY REFERENCES Items(ItemID),
	CONSTRAINT pk_orderitems PRIMARY KEY(OrderID, ItemID)
)

--08
CREATE TABLE Subjects
(
SubjectID INT PRIMARY KEY IDENTITY,
SubjectName VARCHAR(60)
)

CREATE TABLE Majors
(
MajorID INT PRIMARY KEY IDENTITY,
[Name] VARCHAR(60)
)

CREATE TABLE Students
(
StudentID INT PRIMARY KEY IDENTITY,
StudentNumber INT,
StudentName VARCHAR(60),
MajorID INT FOREIGN KEY REFERENCES Majors(MajorID)
)

CREATE TABLE Payments
(
PaymentsID INT PRIMARY KEY IDENTITY,
PaymentDate DATETIME2,
PaymentAmount DECIMAL(10,2),
StudentID INT FOREIGN KEY REFERENCES Students(StudentID)
)

CREATE TABLE Agenda
(
StudentID INT FOREIGN KEY REFERENCES Students(StudentID),
SubjectID INT FOREIGN KEY REFERENCES Subjects(SubjectID),
 CONSTRAINT PK_StudentSubject PRIMARY KEY(StudentID,SubjectID)
)


--09
USE Geography

SELECT MountainRange, PeakName, Elevation FROM Peaks
JOIN Mountains ON Peaks.MountainId = Mountains.Id
WHERE MountainRange = 'Rila'
ORDER BY Elevation DESC