CREATE TABLE [dbo].[TourEvent]
(
	[TourName] nvarchar(15) not null,
	[eventDate] DATETIME not null,
	[eventFee] MONEY not null,

	
	CONSTRAINT FK_TourEventName FOREIGN KEY (TourName) REFERENCES [Tour](TourName)
)
