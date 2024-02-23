CREATE TABLE [dbo].[Commande]
(
	[Id_Commande] INT IDENTITY NOT NULL PRIMARY KEY, 
	[DateCommande] DATETIME NOT NULL,
    [SessionPanier] INT NOT NULL
)
