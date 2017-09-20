CREATE TABLE [dbo].[Suspenstions]
(
	[Idnum] INT NOT NULL, 
    [Description] VARCHAR(1000) NULL, 
    [Belay] BIT NULL DEFAULT 0, 
    [Lead] BIT NULL DEFAULT 0, 
    [Suspenstions] BIT NULL DEFAULT 0 
)
