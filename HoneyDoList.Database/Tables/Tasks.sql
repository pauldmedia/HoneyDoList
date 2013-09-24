CREATE TABLE [dbo].[Tasks]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NULL, 
    [DueDate] DATETIME NULL, 
    [Priority] INT NULL, 
    [Note] NVARCHAR(500) NULL
)
