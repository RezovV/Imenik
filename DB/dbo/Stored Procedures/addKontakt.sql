﻿CREATE PROCEDURE addKontakt
(
	@id int,
	@ime text,
	@prezime text,
	@email text,
	@datum_kre date,
	@vrijeme_kre time,
	@datum_pro date
)
as
begin
	INSERT INTO dbo.Kontakti
	(
	id,
	ime,
	prezime,
	email,
	datum_kre,
	vrijeme_kre,
	datum_pro
	) 
	VALUES
	(
	@id,
	@ime,
	@prezime,
	@email,
	@datum_kre,
	@vrijeme_kre,
	@datum_pro
	)
end