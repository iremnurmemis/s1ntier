CREATE TABLE [dbo].[Userss]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NOT NULL, 
    [PasswordHash] VARBINARY(500) NOT NULL, 
    [PasswordSalt] VARBINARY(500) NOT NULL, 
    [Status] BIT NOT NULL
)

