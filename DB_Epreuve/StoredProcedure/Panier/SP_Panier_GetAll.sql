CREATE PROCEDURE [dbo].[SP_Panier_GetAll]

AS
	SELECT [Id_Panier],
			[Quantite],
			[Prix],
			[Id_Produit],
			[SessionPanier]
	FROM [Panier]

