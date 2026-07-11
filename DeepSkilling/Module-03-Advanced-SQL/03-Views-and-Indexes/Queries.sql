-- ==========================================
-- Module 03 - Views and Indexes
-- ==========================================

USE CollegeDB;
GO

------------------------------------------------
-- Remove Existing View
------------------------------------------------

IF OBJECT_ID('StudentView', 'V') IS NOT NULL
BEGIN
    DROP VIEW StudentView;
END
GO

------------------------------------------------
-- Remove Existing Tables
------------------------------------------------

IF OBJECT_ID('Enrollments', 'U') IS NOT NULL
BEGIN
    DROP TABLE Enrollments;
END
GO

IF OBJECT_ID('Students', 'U') IS NOT NULL
BEGIN
    DROP TABLE Students;
END
GO

------------------------------------------------
-- Create Students Table
------------------------------------------------

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(30),
    Age INT,
    Marks INT
);
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE',20,95),
(102,'Rahul','ECE',21,88),
(103,'Anitha','IT',20,91),
(104,'Kiran','CSE',22,85);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- Create View
------------------------------------------------

CREATE VIEW StudentView
AS
SELECT
    StudentID,
    Name,
    Department,
    Marks
FROM Students;
GO

------------------------------------------------
-- View Records
------------------------------------------------

SELECT * FROM StudentView;
GO

------------------------------------------------
-- Create Non-Clustered Index
------------------------------------------------

IF NOT EXISTS
(
    SELECT *
    FROM sys.indexes
    WHERE name='IX_Student_Name'
)
BEGIN
    CREATE INDEX IX_Student_Name
    ON Students(Name);
END
GO

------------------------------------------------
-- Search using Index
------------------------------------------------

SELECT *
FROM Students
WHERE Name='Bhavya';
GO

------------------------------------------------
-- Display All Records
------------------------------------------------

SELECT *
FROM Students;
GO

------------------------------------------------
-- Optional Cleanup (Do NOT Run)
------------------------------------------------

-- DROP VIEW StudentView;

-- DROP INDEX IX_Student_Name ON Students;

-- DROP TABLE Students;