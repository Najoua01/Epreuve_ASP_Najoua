CREATE PROCEDURE [dbo].[SP_Media_GetBy]
	@Id_Media INT
AS
	SELECT [Id_Media],
			[Nom],
			[Url],
			[Id_Produit]
	FROM [Media]
	WHERE [Id_Media] = @Id_Media
