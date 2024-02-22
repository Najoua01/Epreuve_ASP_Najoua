CREATE PROCEDURE [dbo].[SP_Media_GetAll]
	
AS
	SELECT [Id_Media],
			[Nom],
			[Url],
			[Id_Produit]
	FROM [Media]
