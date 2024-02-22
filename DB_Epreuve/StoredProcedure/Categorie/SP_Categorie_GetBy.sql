CREATE PROCEDURE [dbo].[SP_Categorie_GetBy]
	@NomCategorie NVARCHAR(64)
AS
	SELECT [NomCategorie]
	FROM [Categorie]
	WHERE [NomCategorie] = @NomCategorie
