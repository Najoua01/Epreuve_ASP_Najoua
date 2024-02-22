CREATE TABLE [dbo].[Commande]
(
	[Id_Commande] INT NOT NULL PRIMARY KEY, 
	[DateCommande] DATETIME NOT NULL,
    [SessionPanier] INT NOT NULL
)
