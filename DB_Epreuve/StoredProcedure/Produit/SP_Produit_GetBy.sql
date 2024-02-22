CREATE PROCEDURE [dbo].[SP_Produit_GetBy]
	@Id_Produit INT
AS
	SELECT [Id_Produit],
			[Nom],
			[Description], 
            [Prix], 
            [EcoScore],
            [NomCategorie]
	FROM [Produit]
	WHERE [Id_Produit] = @Id_Produit