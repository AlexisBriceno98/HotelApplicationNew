/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [GuestId]
      ,[Name]
      ,[Age]
  FROM [HotelCalifornia].[dbo].[Guests]

SELECT * FROM Guests;

SELECT Name, Age FROM Guests;

SELECT * FROM Guests ORDER BY Name ASC;

