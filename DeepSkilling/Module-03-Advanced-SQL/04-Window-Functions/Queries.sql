-- ==========================================
-- Module 03 - Window Functions
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
    EmpName VARCHAR(100),
    Department VARCHAR(50),
    Salary INT
);
GO

------------------------------------------------
-- Insert Records
------------------------------------------------

INSERT INTO Employees
VALUES
(101,'Bhavya','IT',65000),
(102,'Rahul','IT',55000),
(103,'Anitha','HR',50000),
(104,'Kiran','HR',45000),
(105,'Ravi','Finance',70000),
(106,'Sneha','Finance',62000);
GO

------------------------------------------------
-- Display Records
------------------------------------------------

SELECT * FROM Employees;
GO

------------------------------------------------
-- ROW_NUMBER()
------------------------------------------------

SELECT
EmpName,
Department,
Salary,
ROW_NUMBER() OVER
(
PARTITION BY Department
ORDER BY Salary DESC
) AS RowNum
FROM Employees;
GO

------------------------------------------------
-- RANK()
------------------------------------------------

SELECT
EmpName,
Department,
Salary,
RANK() OVER
(
ORDER BY Salary DESC
) AS RankNo
FROM Employees;
GO

------------------------------------------------
-- DENSE_RANK()
------------------------------------------------

SELECT
EmpName,
Department,
Salary,
DENSE_RANK() OVER
(
ORDER BY Salary DESC
) AS DenseRank
FROM Employees;
GO

------------------------------------------------
-- OVER()
------------------------------------------------

SELECT
EmpName,
Department,
Salary,
AVG(Salary) OVER() AS AverageSalary
FROM Employees;
GO

------------------------------------------------
-- PARTITION BY
------------------------------------------------

SELECT
EmpName,
Department,
Salary,
AVG(Salary) OVER
(
PARTITION BY Department
) AS DepartmentAverage
FROM Employees;
GO

------------------------------------------------
-- GROUP BY
------------------------------------------------

SELECT
Department,
COUNT(*) AS Employees,
AVG(Salary) AS AverageSalary
FROM Employees
GROUP BY Department;
GO

------------------------------------------------
-- Optional Cleanup
------------------------------------------------

-- DROP TABLE Employees;