﻿CREATE TABLE [dbo].[TempUsers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserName] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NULL, 
    [EmailAdress] NVARCHAR(100) NULL
)
