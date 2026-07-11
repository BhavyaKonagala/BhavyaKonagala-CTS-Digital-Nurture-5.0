-- ==========================================
-- Module 03 - MERGE, PIVOT and UNPIVOT
-- ==========================================

------------------------------------------------
-- Create Database (Only if it doesn't exist)
------------------------------------------------

IF DB_ID('CollegeDB') IS NULL
BEGIN
    CREATE DATABASE CollegeDB;
END
GO

USE CollegeDB;
GO

------------------------------------------------
-- Remove Existing Tables
------------------------------------------------

IF OBJECT_ID('StudentsNew','U') IS NOT NULL
    DROP TABLE StudentsNew;
GO

IF OBJECT_ID('Students','U') IS NOT NULL
    DROP TABLE Students;
GO

------------------------------------------------
-- Create Source Table
------------------------------------------------

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(30),
    Marks INT
);
GO

------------------------------------------------
-- Create Target Table
------------------------------------------------

CREATE TABLE StudentsNew
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(30),
    Marks INT
);
GO

------------------------------------------------
-- Insert Source Records
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE',95),
(102,'Rahul','ECE',88),
(103,'Anitha','IT',91);
GO

------------------------------------------------
-- Insert Target Records
------------------------------------------------

INSERT INTO StudentsNew
VALUES
(101,'Bhavya','CSE',90),
(104,'Kiran','CSE',85);
GO

------------------------------------------------
-- Display Tables
------------------------------------------------

SELECT * FROM Students;
SELECT * FROM StudentsNew;
GO

------------------------------------------------
-- MERGE
------------------------------------------------

MERGE StudentsNew AS Target
USING Students AS Source
ON Target.StudentID = Source.StudentID

WHEN MATCHED THEN
UPDATE SET
Target.Name=Source.Name,
Target.Department=Source.Department,
Target.Marks=Source.Marks

WHEN NOT MATCHED THEN
INSERT(StudentID,Name,Department,Marks)
VALUES
(
Source.StudentID,
Source.Name,
Source.Department,
Source.Marks
);
GO

------------------------------------------------
-- Display MERGE Result
------------------------------------------------

SELECT * FROM StudentsNew;
GO

------------------------------------------------
-- PIVOT Example
------------------------------------------------

SELECT *
FROM
(
SELECT Department,Marks
FROM Students
) AS SourceTable

PIVOT
(
AVG(Marks)
FOR Department IN
(
[CSE],
[ECE],
[IT]
)
) AS PivotTable;
GO

------------------------------------------------
-- UNPIVOT Example
------------------------------------------------

CREATE TABLE DepartmentMarks
(
CSE INT,
ECE INT,
IT INT
);

INSERT INTO DepartmentMarks
VALUES
(95,88,91);

SELECT *
FROM DepartmentMarks;

SELECT Department,
Marks
FROM DepartmentMarks

UNPIVOT
(
Marks
FOR Department IN
(
CSE,
ECE,
IT
)
) AS UnpivotTable;
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP TABLE DepartmentMarks;
-- DROP TABLE Students;
-- DROP TABLE StudentsNew;