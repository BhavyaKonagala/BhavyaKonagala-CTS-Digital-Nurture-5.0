-- ==========================================
-- Module 03 - Exception Handling and Transactions
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
-- Remove Existing Table
------------------------------------------------

IF OBJECT_ID('Accounts','U') IS NOT NULL
    DROP TABLE Accounts;
GO

------------------------------------------------
-- Create Table
------------------------------------------------

CREATE TABLE Accounts
(
    AccountID INT PRIMARY KEY,
    AccountHolder VARCHAR(100),
    Balance MONEY
);
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Accounts
VALUES
(101,'Bhavya',10000),
(102,'Rahul',15000);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Accounts;
GO

------------------------------------------------
-- TRY...CATCH Example
------------------------------------------------

BEGIN TRY

    PRINT 'Transaction Started';

    UPDATE Accounts
    SET Balance = Balance - 2000
    WHERE AccountID = 101;

    UPDATE Accounts
    SET Balance = Balance + 2000
    WHERE AccountID = 102;

    PRINT 'Transaction Successful';

END TRY

BEGIN CATCH

    PRINT 'Error Occurred';

    PRINT ERROR_MESSAGE();

END CATCH;
GO

------------------------------------------------
-- Display Updated Records
------------------------------------------------

SELECT * FROM Accounts;
GO

------------------------------------------------
-- Transaction Example
------------------------------------------------

BEGIN TRANSACTION

UPDATE Accounts
SET Balance = Balance - 500
WHERE AccountID = 101;

UPDATE Accounts
SET Balance = Balance + 500
WHERE AccountID = 102;

COMMIT TRANSACTION;
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Accounts;
GO

------------------------------------------------
-- Rollback Example
------------------------------------------------

BEGIN TRANSACTION

UPDATE Accounts
SET Balance = Balance - 1000
WHERE AccountID = 101;

ROLLBACK TRANSACTION;
GO

------------------------------------------------
-- Display Final Records
------------------------------------------------

SELECT * FROM Accounts;
GO

------------------------------------------------
-- THROW Example
------------------------------------------------

BEGIN TRY

    THROW 50001,'Custom Exception Raised',1;

END TRY

BEGIN CATCH

    PRINT ERROR_MESSAGE();

END CATCH;
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP TABLE Accounts;