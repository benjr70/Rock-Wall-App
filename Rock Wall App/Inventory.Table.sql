CREATE TABLE [dbo].[Table]
(
	[item] VARCHAR(50) NOT NULL , 
    [ItemId] INT NOT NULL, 
    [purchaseDate] INT NULL, 
    [Cost] FLOAT NULL, 
    [ReplacementDate] INT NULL, 
    PRIMARY KEY ([ItemId])
)
