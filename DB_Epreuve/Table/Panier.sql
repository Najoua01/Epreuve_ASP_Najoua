CREATE TABLE [dbo].[Panier]
(
	[Id_Panier] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Quantite] INT NOT NULL,
    [Prix] DECIMAL(10, 2) NOT NULL,
    [Id_Produit] INT NOT NULL,
    [SessionPanier] INT NOT NULL,
    CONSTRAINT [FK_Panier_Produit] FOREIGN KEY (Id_Produit) REFERENCES [Produit]([Id_Produit])
)
  