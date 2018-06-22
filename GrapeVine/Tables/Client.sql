CREATE TABLE [dbo].[Client]
(
	[ClientID] int not null,
	[firstName] nvarchar(25) not null,
	[surname] nvarchar(50) not null,
	[Gender] nvarchar(5) not null,

	CONSTRAINT PK_Client PRIMARY KEY (ClientID)
	
)
