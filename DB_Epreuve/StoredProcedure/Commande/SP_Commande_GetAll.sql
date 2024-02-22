CREATE PROCEDURE [dbo].[SP_Commande_GetAll]
	
AS
	SELECT [Id_Commande],
			[DateCommande],
			[SessionPanier]
	FROM [Commande]
