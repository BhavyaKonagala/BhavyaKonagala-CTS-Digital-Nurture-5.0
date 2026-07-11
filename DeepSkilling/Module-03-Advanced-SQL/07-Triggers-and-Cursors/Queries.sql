-- ==========================================
-- Module 03 - Triggers and Cursors
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

IF OBJECT_ID('StudentLog','U') IS NOT NULL
    DROP TABLE StudentLog;
GO

IF OBJECT_ID('Students','U') IS NOT NULL
    DROP TABLE Students;
GO

IF OBJECT_ID('tr_InsertStudent','TR') IS NOT NULL
    DROP TRIGGER tr_InsertStudent;
GO

------------------------------------------------
-- Create Tables
------------------------------------------------

CREATE TABLE Students
(
    StudentID INT PRIMARY KEY,
    Name VARCHAR(100),
    Department VARCHAR(30),
    Marks INT
);

CREATE TABLE StudentLog
(
    LogID INT IDENTITY(1,1) PRIMARY KEY,
    Message VARCHAR(200)
);
GO

------------------------------------------------
-- Create Trigger
------------------------------------------------

CREATE TRIGGER tr_InsertStudent
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentLog(Message)
    VALUES('A new student record was inserted.');
END;
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE',95),
(102,'Rahul','ECE',88),
(103,'Anitha','IT',91);
GO

------------------------------------------------
-- Display Students
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- Display Trigger Log
------------------------------------------------

SELECT * FROM StudentLog;
GO

------------------------------------------------
-- Cursor Example
------------------------------------------------

DECLARE @StudentName VARCHAR(100);

DECLARE StudentCursor CURSOR FOR
SELECT Name
FROM Students;

OPEN StudentCursor;

FETCH NEXT FROM StudentCursor INTO @StudentName;

WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT @StudentName;
    FETCH NEXT FROM StudentCursor INTO @StudentName;
END

CLOSE StudentCursor;
DEALLOCATE StudentCursor;
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP TRIGGER tr_InsertStudent;
-- DROP TABLE StudentLog;
-- DROP TABLE Students;