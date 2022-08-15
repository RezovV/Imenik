CREATE PROCEDURE [dbo].[addContact]
(
	@id int,
	@name text,
	@surname text,
	@tel_number text,
	@email text,
	@date_cre date,
	@time_cre time,
	@date_cha date
)
as
begin
	INSERT INTO dbo.Contacts
	(
	id,
	name,
	surname,
	tel_number,
	email,
	date_cre,
	time_cre,
	date_cha
	) 
	VALUES
	(
	@id,
	@name,
	@surname,
	@tel_number,
	@email,
	@date_cre,
	@time_cre,
	@date_cha
	)
end