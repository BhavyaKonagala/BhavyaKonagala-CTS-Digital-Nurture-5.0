-- ==========================================
-- Module 03 - CTE and Recursive CTE
-- ==========================================

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

IF OBJECT_ID('Employees', 'U') IS NOT NULL
BEGIN
    DROP TABLE Employees;
END
GO

------------------------------------------------
-- Create Employees Table
------------------------------------------------

CREATE TABLE Employees
(
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50),
    ManagerID INT NULL,
    Salary INT
);
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Employees
VALUES
(1,'CEO',NULL,100000),
(2,'Manager A',1,80000),
(3,'Manager B',1,78000),
(4,'Employee A',2,50000),
(5,'Employee B',2,48000),
(6,'Employee C',3,45000);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Employees;
GO

------------------------------------------------
-- Common Table Expression (CTE)
------------------------------------------------

WITH HighSalaryEmployees AS
(
    SELECT EmpID,EmpName,Salary
    FROM Employees
    WHERE Salary>50000
)

SELECT *
FROM HighSalaryEmployees;
GO

------------------------------------------------
-- Recursive CTE
------------------------------------------------

WITH EmployeeHierarchy AS
(
    SELECT
        EmpID,
        EmpName,
        ManagerID,
        1 AS Level
    FROM Employees
    WHERE ManagerID IS NULL

    UNION ALL

    SELECT
        E.EmpID,
        E.EmpName,
        E.ManagerID,
        EH.Level+1
    FROM Employees E
    INNER JOIN EmployeeHierarchy EH
    ON E.ManagerID=EH.EmpID
)

SELECT *
FROM EmployeeHierarchy;
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP TABLE Employees;