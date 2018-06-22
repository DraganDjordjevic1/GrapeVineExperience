CREATE TABLE [dbo].[Booking]
(
	[ClientID] INT NOT NULL,
	[TourName] nvarchar(15) not null,
	[eventDate] DATETIME not null,
	[Payment] MONEY not null,
	[dateBooked] DATETIME not null,

	
	CONSTRAINT FK_Booking_ClientID FOREIGN KEY (ClientID) REFERENCES [Client](ClientID),
	
	CONSTRAINT FK_BOOKING_TourName FOREIGN KEY (TourName) REFERENCES [Tour](TourName)
	
)
