-- create table Customer(
--     CustomerId INT IDENTITY(1,1) PRIMARY KEY,
--     [Name] NVARCHAR(100),
--     [Email] VARCHAR(40) unique,
--     [Phone] VARCHAR(50) unique
-- );

create table Location (
    LocationId INT IDENTITY(1,1) PRIMARY KEY,
    CustomerId INT,
    [Address] NVARCHAR(200),
	FOREIGN KEY (CustomerId) REFERENCES Customer(CustomerId)
);