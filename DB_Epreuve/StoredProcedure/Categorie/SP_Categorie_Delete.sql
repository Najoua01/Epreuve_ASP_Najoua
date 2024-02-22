CREATE PROCEDURE [dbo].[SP_Categorie_Delete]
	@NomCategorie NVARCHAR(64)
AS
	DELETE FROM [Categorie]
		WHERE [NomCategorie] = @NomCategorie
