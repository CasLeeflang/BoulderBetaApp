CREATE TABLE [dbo].[Post]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserId] INT NOT NULL, 
    [BoulderId] INT NOT NULL, 
    [NofRatings] INT NOT NULL, 
    [TotRating] INT NOT NULL, 
    [VideoUrl] NVARCHAR(100) NOT NULL
)
