CREATE TABLE [dbo].[InventoryTable]
(
	[item] VARCHAR(50) NOT NULL , 
    [ItemId] INT NOT NULL IDENTITY, 
    [purchaseDate] INT NULL, 
    [Cost] FLOAT NULL, 
    [ReplacementDate] INT NULL, 
    PRIMARY KEY ([ItemId])
)
