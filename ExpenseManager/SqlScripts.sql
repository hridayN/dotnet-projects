/*
-- use ExpenseManager

CREATE TABLE PaymentMethod(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100) NOT NULL,
DueDate DATETIME NOT NULL
);

CREATE TABLE ExpenseCategory(
Id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100) NOT NULL
);

CREATE TABLE Expenses (
Id INT PRIMARY KEY IDENTITY(1,1),
Description VARCHAR(100) NOT NULL,
PaymentMethodId INT FOREIGN KEY REFERENCES dbo.PaymentMethod(Id) NOT NULL,
ExpenseCategoryId INT FOREIGN KEY REFERENCES dbo.ExpenseCategory(Id) NOT NULL
);

-- Add column DueDate to Expense table
ALTER TABLE dbo.Expenses
ADD DueDate DATE NOT NULL

-- Drop column DueDate
ALTER TABLE PaymentMethod
DROP COLUMN DueDate

-- Add column BillingDate to PaymentMethod table
ALTER TABLE PaymentMethod
ADD BillingDate INT NOT NULL

-- Add column ExpenseDate to Expense table
ALTER TABLE dbo.Expenses
ADD ExpenseDate DATE NOT NULL
*/

--INSERT INTO Expenses (Description, PaymentMethodId, ExpenseCategoryId) VALUES ('Storing Null', NULL, NULL);
