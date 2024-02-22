CREATE PROCEDURE [dbo].[SP_Media_Insert]
	@nom NVARCHAR(64),
	@url NVARCHAR(256),
	@id_Produit INT
AS
	INSERT INTO [Media] ([Nom],[Url],[Id_Produit])
		OUTPUT [inserted].[Id_Media]
		VALUES ( @nom, @url, @id_Produit)