﻿CREATE TABLE [dbo].[Boulder]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Name] NVARCHAR(50) NOT NULL, 
	[Location] NVARCHAR(50) NOT NULL, 
    [Grade] NVARCHAR(50) NOT NULL 
)
