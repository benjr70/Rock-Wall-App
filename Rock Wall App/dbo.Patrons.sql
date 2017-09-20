CREATE TABLE [dbo].[Patrons] (
    [Id]          INT          NOT NULL,
    [First Name]  VARCHAR (50) NOT NULL,
    [Last Name]   VARCHAR (50) NOT NULL,
    [Signature]   IMAGE        NULL,
    [Gender]      CHAR (1)     NOT NULL,
    [Email]       VARCHAR (50) NULL,
    [Belaycert] BIT          NULL,
    [leadcert]  BIT          NULL,
    [Suspension]  BIT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

