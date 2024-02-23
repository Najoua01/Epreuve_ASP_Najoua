CREATE PROCEDURE [dbo].[SP_Commande_Update]
	@id_Commande INT,
	@dateCommande DATETIME,
	@sessionPanier INT

AS
	UPDATE [Commande] 
		SET [DateCommande] = @dateCommande,
			[SessionPanier] = @sessionPanier
		WHERE [Id_Commande] = @id_Commande
