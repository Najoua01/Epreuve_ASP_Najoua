CREATE PROCEDURE [dbo].[SP_Media_Update]
	@id_Media INT,
	@nom NVARCHAR(64),
	@url NVARCHAR(256),
	@id_Produit INT = NULL
AS
	UPDATE [Media]
		SET [Nom] = @nom,
			[Url] = @url,
			[Id_Produit] = @id_Produit
		WHERE [Id_Media] = @id_Media