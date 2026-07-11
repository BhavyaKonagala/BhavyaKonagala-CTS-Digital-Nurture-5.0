-- ==========================================
-- Module 03 - Stored Procedures and UDFs
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
-- Remove Existing Objects
------------------------------------------------

IF OBJECT_ID('GetStudents','P') IS NOT NULL
    DROP PROCEDURE GetStudents;
GO

IF OBJECT_ID('GetStudentByID','P') IS NOT NULL
    DROP PROCEDURE GetStudentByID;
GO

IF OBJECT_ID('GetBonus','FN') IS NOT NULL
    DROP FUNCTION GetBonus;
GO

IF OBJECT_ID('GetCSEStudents','TF') IS NOT NULL
    DROP FUNCTION GetCSEStudents;
GO

IF OBJECT_ID('Students','U') IS NOT NULL
    DROP TABLE Students;
GO

------------------------------------------------
-- Create Table
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
-- Insert Records
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE',95),
(102,'Rahul','ECE',88),
(103,'Anitha','IT',91),
(104,'Kiran','CSE',85);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- Stored Procedure
------------------------------------------------

CREATE PROCEDURE GetStudents
AS
BEGIN
    SELECT * FROM Students;
END;
GO

------------------------------------------------
-- Execute Procedure
------------------------------------------------

EXEC GetStudents;
GO

------------------------------------------------
-- Stored Procedure with Parameter
------------------------------------------------

CREATE PROCEDURE GetStudentByID
    @ID INT
AS
BEGIN
    SELECT *
    FROM Students
    WHERE StudentID=@ID;
END;
GO

------------------------------------------------
-- Execute Procedure
------------------------------------------------

EXEC GetStudentByID 101;
GO

------------------------------------------------
-- Scalar Function
------------------------------------------------

CREATE FUNCTION GetBonus
(
    @Marks INT
)
RETURNS INT
AS
BEGIN
    RETURN @Marks+5;
END;
GO

------------------------------------------------
-- Execute Scalar Function
------------------------------------------------

SELECT
Name,
Marks,
dbo.GetBonus(Marks) AS BonusMarks
FROM Students;
GO

------------------------------------------------
-- Table Valued Function
------------------------------------------------

CREATE FUNCTION GetCSEStudents()
RETURNS TABLE
AS
RETURN
(
    SELECT *
    FROM Students
    WHERE Department='CSE'
);
GO

------------------------------------------------
-- Execute Table Valued Function
------------------------------------------------

SELECT *
FROM dbo.GetCSEStudents();
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP PROCEDURE GetStudents;
-- DROP PROCEDURE GetStudentByID;
-- DROP FUNCTION GetBonus;
-- DROP FUNCTION GetCSEStudents;
-- DROP TABLE Students;