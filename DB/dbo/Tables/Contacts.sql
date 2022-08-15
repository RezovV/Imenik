CREATE TABLE [dbo].[Kontakti] (
    [id]          INT      NOT NULL,
    [ime]         TEXT     NOT NULL,
    [prezime]     TEXT     NOT NULL,
    [tel_broj]    TEXT     NOT NULL,
    [email]       TEXT     NOT NULL,
    [datum_kre]   DATE     NOT NULL,
    [vrijeme_kre] TIME (0) NOT NULL,
    [datum_pro]   DATE     NOT NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

