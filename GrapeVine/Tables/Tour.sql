CREATE TABLE [dbo].[Tour]
(
	[TourName] nvarchar(15) not null,
	[Description] nvarchar(250) not null,

	CONSTRAINT PK_Tour PRIMARY KEY (TourName)
)
