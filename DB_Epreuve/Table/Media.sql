﻿CREATE TABLE [dbo].[Media]
(
	[Id_Media] INT NOT NULL PRIMARY KEY, 
    [Nom] NVARCHAR(64) NULL, 
    [Url] NVARCHAR(256) NULL,
    [Id_Produit] INT NULL
)
