CREATE TABLE [dbo].[Contacts] (
    [Id]         INT      NOT NULL,
    [Name]       TEXT     NOT NULL,
    [Surname]    TEXT     NOT NULL,
    [Tel_number] TEXT     NOT NULL,
    [Email]      TEXT     NOT NULL,
    [Date_cre]   DATE     NOT NULL,
    [Time_cre]   TIME (0) NOT NULL,
    [Date_cha]   DATE     NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

