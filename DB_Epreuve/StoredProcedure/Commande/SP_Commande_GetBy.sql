CREATE PROCEDURE [dbo].[SP_Commande_GetBy]
	@Id_Commande INT
AS
	SELECT [Id_Commande],
			[DateCommande],
			[SessionPanier]
	FROM [Commande]
	WHERE [Id_Commande] = @Id_Commande
