CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT IDENTITY NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(64) NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Prix] DECIMAL(10, 2) NOT NULL, 
    [EcoScore] NCHAR(1) NOT NULL, 
    [NomCategorie] NVARCHAR(64) NOT NULL,
    CONSTRAINT [FK_Produit_Categorie] FOREIGN KEY (NomCategorie) REFERENCES [Categorie]([NomCategorie])    
)
