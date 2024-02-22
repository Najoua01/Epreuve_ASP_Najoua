CREATE PROCEDURE [dbo].[SP_Panier_Insert]
		@quantite INT,
		@prix DECIMAL (10,2),
		@id_Produit INT,
		@sessionPanier INT
AS
	INSERT INTO [Panier] ([Quantite],[Prix],[Id_Produit],[SessionPanier])
		OUTPUT [inserted].[Id_Panier]
		VALUES ( @quantite, @prix, @id_Produit, @sessionPanier)