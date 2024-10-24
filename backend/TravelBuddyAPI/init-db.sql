IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'TravelBuddyTestDatabase')
BEGIN
    CREATE DATABASE TravelBuddyTestDatabase;
END
GO
