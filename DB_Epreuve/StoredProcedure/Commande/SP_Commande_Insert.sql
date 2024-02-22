CREATE PROCEDURE [dbo].[SP_Commande_Insert]
		@id_Commande INT,
		@datCommande DATETIME,
		@sessionPanier INT
AS
	INSERT INTO [Commande] ([Id_Commande],[DateCommande],[SessionPanier])
		OUTPUT [inserted].[Id_Commande]
		VALUES ( @id_Commande, @datCommande, @sessionPanier)