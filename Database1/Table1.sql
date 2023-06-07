CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [category] NVARCHAR(10) NULL, 
    [category2] NVARCHAR(10) NULL, 
    [FinancialCode] NVARCHAR(10) NULL, 
    [PostalCode] NVARCHAR(6) NULL, 
    [City] NCHAR(3) NULL, 
    [Address] NVARCHAR(50) NULL, 
    [Phone] NCHAR(10) NULL
)
