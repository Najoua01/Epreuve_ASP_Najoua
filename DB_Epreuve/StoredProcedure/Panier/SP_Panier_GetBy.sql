CREATE PROCEDURE [dbo].[SP_Panier_GetBy]
	@Id_Panier INT
AS
	SELECT [Id_Panier],
			[Quantite],
			[Id_Produit],
			[SessionPanier]
	FROM [Panier]
	WHERE [Id_Panier] = @Id_Panier