CREATE PROCEDURE [dbo].[SP_Categorie_Update]
	
	@nomCategorie NVARCHAR(64)
AS
		UPDATE [Categorie]
			SET [NomCategorie] = @nomCategorie
			WHERE [NomCategorie] = @NomCategorie