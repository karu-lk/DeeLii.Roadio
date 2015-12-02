CREATE TABLE [dbo].[POI]
(
	[POIId] INT NOT NULL PRIMARY KEY,
    [POICategoryId] INT NULL,
    [POIName] NVARCHAR(200) NULL, 
    [POIDescription] NVARCHAR(400) NULL, 
    [NearestCity] NVARCHAR(200) NULL, 
    [NearestVillage] NVARCHAR(50) NULL, 
    [NearestStateHighway] NVARCHAR(50) NULL, 
    [Latitude] NUMERIC(12, 8) NULL, 
    [Longitude] NUMERIC(12, 8) NULL, 
    CONSTRAINT [FK_POI_POICategory_POICategoryId] FOREIGN KEY ([POICategoryId]) REFERENCES [POICategory]([POICategoryId])
)
