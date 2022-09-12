CREATE TABLE [dbo].[Contacts] (
    [Id]         INT      NOT NULL,
    [Name]       TEXT     NOT NULL,
    [Surname]    TEXT     NOT NULL,
    [TelephoneNumber] TEXT     NOT NULL,
    [Email]      TEXT     NOT NULL,
    [DateCreated]   DATE     NOT NULL,
    [TimeCreated]   TIME (0) NOT NULL,
    [DateChanged]   DATE     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

