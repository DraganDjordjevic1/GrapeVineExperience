/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/


if '$(LoadTestData)' = 'true'
BEGIN

DELETE FROM Booking;
DELETE FROM TourEvent;
DELETE FROM Tour;
DELETE FROM Client;

INSERT INTO Client(ClientID, firstName, surname, Gender) VALUES
(1, 'Taylor', 'Price', 'M'),
(2, 'Ellyse', 'Gamble', 'F'),
(3, 'Tilly', 'Tan', 'F');

		
INSERT INTO Tour(TourName, [Description]) VALUES
('West', 'Tour of wineries and outlets of the Geelong and Otways region' ),
('East', 'Tour of wineries and outlets of the Yarra Valley' ),
('South', 'Tour of wineries and outlets of Mornington Penisula' ),
('North', 'Tour of wineries and outlets of the Bedigo and Castlemaine region' );

INSERT INTO TourEvent(TourName, eventFee, eventDate) VALUES
(
'North', $200,
CONVERT(DATETIME, '01/09/2016', 101)
),

(
'North', $225,
CONVERT(DATETIME, '02/13/2016', 101)
),

(
'South', $200,
CONVERT(DATETIME, '01/16/2016', 101)
),

(
'West', $225,
CONVERT(DATETIME, '01/29/2016', 101)
);


INSERT INTO Booking(ClientID, TourName, Payment, dateBooked, eventDate) VALUES
(
1, 'North', $200,
CONVERT(DATETIME,'12/10/2015', 101), 
CONVERT(DATETIME,'9/01/2016', 101) 
),

(
2, 'North', $200,
CONVERT(DATETIME,'12/16/2015', 101), 
CONVERT(DATETIME,'01/13/2016', 101) 
),


(
1, 'North', $225,
CONVERT(DATETIME,'01/08/2016', 101), 
CONVERT(DATETIME,'02/13/2016', 101) 
),

(
2, 'North', $225,
CONVERT(DATETIME,'01/14/2016', 101), 
CONVERT(DATETIME,'02/13/2016', 101) 
),

(
3, 'North', $225,
CONVERT(DATETIME,'02/03/2016', 101), 
CONVERT(DATETIME,'02/13/2016', 101) 
),

(
1, 'South', $200,
CONVERT(DATETIME,'12/10/2015', 101), 
CONVERT(DATETIME,'01/16/2016', 101) 
),

(
1, 'South', 200,
CONVERT(DATETIME,'12/18/2015', 101), 
CONVERT(DATETIME,'01/16/2016', 101) 
),

(
3, 'South', $200,
CONVERT(DATETIME,'01/09/2016', 101), 
CONVERT(DATETIME,'01/16/2016', 101)
),

(
2, 'West', $200,
CONVERT(DATETIME,'12/17/2015', 101), 
CONVERT(DATETIME,'01/29/2016', 101)
),

(
3, 'West', $200,
CONVERT(DATETIME,'12/18/2015', 101), 
CONVERT(DATETIME,'01/29/2016', 101) 
);


END;