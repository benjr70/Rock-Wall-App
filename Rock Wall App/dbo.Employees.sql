CREATE TABLE [dbo].[Employees]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [First Name] VARCHAR(50) NOT NULL, 
    [Last Name] VARCHAR(50) NULL, 
    [Email] VARCHAR(50) NULL, 
    [Phone Number] INT NULL, 
    [DataEmployed] DATE NULL, 
    [UserName] VARCHAR(50) NULL, 
    [Password] CHAR(32) NULL
)
