CREATE PROCEDURE [dbo].[SP_Panier_Update]
	@id_Panier INT,
	@quantite INT,
	@Prix DECIMAL (10,2),
	@id_Produit INT,
	@sessionPanier INT
AS
	UPDATE [Panier] 
		SET [Id_Panier] = @id_Panier,
			[Quantite] = @quantite,
			[Prix] = @Prix,
			[Id_Produit] = @id_Produit,
			[SessionPanier]= @sessionPanier
		WHERE [Id_Panier] = @id_Panier