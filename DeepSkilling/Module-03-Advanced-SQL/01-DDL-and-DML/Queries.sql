-- ==========================================
-- Module 03 - DDL and DML
-- SQL Server
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
-- Create Table (Only if it doesn't exist)
------------------------------------------------

IF OBJECT_ID('Students', 'U') IS NULL
BEGIN
    CREATE TABLE Students
    (
        StudentID INT PRIMARY KEY,
        Name VARCHAR(100),
        Department VARCHAR(30),
        Age INT,
        Marks INT
    );
END
GO

------------------------------------------------
-- Clear Existing Data
------------------------------------------------

DELETE FROM Students;
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Students
VALUES
(101,'Bhavya','CSE',20,95),
(102,'Rahul','ECE',21,88),
(103,'Anitha','IT',20,91);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- Update Record
------------------------------------------------

UPDATE Students
SET Marks = 98
WHERE StudentID = 101;
GO

------------------------------------------------
-- Display Updated Records
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- Delete Record
------------------------------------------------

DELETE FROM Students
WHERE StudentID = 102;
GO

------------------------------------------------
-- Display Final Records
------------------------------------------------

SELECT * FROM Students;
GO

------------------------------------------------
-- DDL Examples (Run only when needed)
------------------------------------------------

-- ALTER TABLE Students
-- ADD Email VARCHAR(100);

-- ALTER TABLE Students
-- DROP COLUMN Email;

------------------------------------------------
-- Optional (Do NOT run unless required)
------------------------------------------------

-- TRUNCATE TABLE Students;

-- DROP TABLE Students;