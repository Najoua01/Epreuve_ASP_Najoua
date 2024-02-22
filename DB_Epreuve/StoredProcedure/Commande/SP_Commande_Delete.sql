CREATE PROCEDURE [dbo].[SP_Commande_Delete]
	@id_Commande INT
AS
	DELETE FROM [Commande]
		WHERE [Id_Commande] = @id_Commande