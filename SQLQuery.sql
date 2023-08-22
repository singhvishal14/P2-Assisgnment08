CREATE DATABASE AdvancedDb;
drop DATABASE AdvancedDb;

USE AdvancedDb;


CREATE TABLE Employees (
    EmployeeId INT PRIMARY KEY,
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    BirthDate DATE,
    Salary FLOAT
);


CREATE TABLE Products (
    ProductId INT PRIMARY KEY,
    ProductName NVARCHAR(50),
    PDescription NVARCHAR(50),
    ReleaseDate DATE,
    Price FLOAT
);


CREATE TABLE Orders (
    OrderId INT PRIMARY KEY,
    OrderDate DATETIME,
    Quantity SMALLINT,
    Discount FLOAT,
    IsShipped BIT
);
select * from Employees
select * from Products
select * from Orders