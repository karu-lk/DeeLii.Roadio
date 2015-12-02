CREATE TABLE [dbo].[POIBookmark]
(
	[POIBookmarkId] INT NOT NULL PRIMARY KEY, 
    [POIId] INT NULL, 
    [BookmarkId] INT NULL, 
    [Distance] NUMERIC(4, 2) NULL, 
    CONSTRAINT [FK_POIBookmark_POI_POIId] FOREIGN KEY ([POIId]) REFERENCES [POI]([POIId]), 
    CONSTRAINT [FK_POIBookmark_Bookmark_BookmarkId] FOREIGN KEY ([BookmarkId]) REFERENCES [Bookmark]([BookmarkId])
)
