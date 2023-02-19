/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [RoomId]
      ,[Type]
      ,[Description]
      ,[ExtraBed]
  FROM [HotelCalifornia].[dbo].[Rooms]

SELECT * FROM Rooms;
SELECT * FROM Rooms WHERE Description = 'Single Room';
SELECT * FROM Rooms WHERE ExtraBed = 'Yes';
SELECT * FROM Rooms ORDER BY RoomId DESC;
