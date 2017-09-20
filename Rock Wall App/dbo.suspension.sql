CREATE TABLE [dbo].[suspension]
(
	[Idnumber] INT NOT NULL PRIMARY KEY, 
    [Description] VARCHAR(1000) NULL, 
    [Belay] BIT NULL, 
    [lead] BIT NULL, 
    [Suspension] BIT NULL
)
