CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@nomCategorie NVARCHAR(64)
AS
	INSERT INTO [Categorie] ([NomCategorie])
		OUTPUT [inserted].[NomCategorie]
		VALUES ( @nomCategorie)

