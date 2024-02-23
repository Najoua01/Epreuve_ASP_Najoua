CREATE PROCEDURE [dbo].[SP_Produit_Insert]
		@nom NVARCHAR(64),
		@description NVARCHAR(MAX),
		@prix INT,
		@ecoScore NCHAR(1),
		@NomCategorie NVARCHAR(64)
AS
	INSERT INTO [Produit] ([Nom],[Description],[Prix],[EcoScore],[NomCategorie])
		OUTPUT [inserted].[Id_Produit]
		VALUES ( @nom, @description, @prix, @ecoScore, @NomCategorie)