CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_Produit INT,
	@nom NVARCHAR(64),
	@description NVARCHAR(MAX),
	@prix INT,
	@ecoScore NCHAR(1),
	@NomCategorie NVARCHAR(64)
AS
	UPDATE [Produit] 
		SET [Nom] = @nom ,
			[Description] = @description ,
			[Prix] = @prix ,
			[EcoScore] = @ecoScore,
			[NomCategorie] = @NomCategorie
		WHERE [Id_Produit] = @id_Produit