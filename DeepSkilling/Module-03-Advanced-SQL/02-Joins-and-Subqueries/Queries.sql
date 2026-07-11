-- ==========================================
-- Module 03 - Joins and Subqueries
-- ==========================================

USE CollegeDB;
GO

------------------------------------------------
-- Drop Tables if Already Exist
------------------------------------------------

IF OBJECT_ID('Enrollments', 'U') IS NOT NULL
    DROP TABLE Enrollments;

IF OBJECT_ID('Students', 'U') IS NOT NULL
    DROP TABLE Students;

GO

------------------------------------------------
-- Create Students Table
------------------------------------------------

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(30)
);

------------------------------------------------
-- Create Enrollments Table
------------------------------------------------

CREATE TABLE Enrollments
(
    EnrollmentID INT PRIMARY KEY,
    StudentID INT,
    Course VARCHAR(50),
    FOREIGN KEY(StudentID) REFERENCES Students(StudentID)
);

------------------------------------------------
-- Insert Data
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE'),
(102,'Rahul','ECE'),
(103,'Anitha','IT'),
(104,'Kiran','CSE');

INSERT INTO Enrollments
VALUES
(1,101,'SQL'),
(2,101,'Python'),
(3,103,'Java'),
(4,104,'C#');

------------------------------------------------
-- INNER JOIN
------------------------------------------------

SELECT
S.StudentID,
S.Name,
E.Course
FROM Students S
INNER JOIN Enrollments E
ON S.StudentID=E.StudentID;

------------------------------------------------
-- LEFT JOIN
------------------------------------------------

SELECT
S.StudentID,
S.Name,
E.Course
FROM Students S
LEFT JOIN Enrollments E
ON S.StudentID=E.StudentID;

------------------------------------------------
-- RIGHT JOIN
------------------------------------------------

SELECT
S.StudentID,
S.Name,
E.Course
FROM Students S
RIGHT JOIN Enrollments E
ON S.StudentID=E.StudentID;

------------------------------------------------
-- Subquery
------------------------------------------------

SELECT *
FROM Students
WHERE StudentID IN
(
SELECT StudentID
FROM Enrollments
);

------------------------------------------------
-- Scalar Subquery
------------------------------------------------

SELECT Name
FROM Students
WHERE StudentID=
(
SELECT MIN(StudentID)
FROM Students
);