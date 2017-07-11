CREATE TABLE [dbo].[SampleTable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(MAX) NOT NULL DEFAULT 'Admin', 
    [LastName] NCHAR(10) NULL 
)
