CREATE TABLE [dbo].[AccountTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [First Name] VARCHAR(50) NOT NULL, 
    [Last Name] VARCHAR(50) NULL, 
    [Account Type] VARCHAR(50) NOT NULL, 
    [Gender] BIT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Waver signed] INT NULL
)
