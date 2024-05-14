CREATE DATABASE [booking-database-01]

CREATE TABLE Users (
    UserId INT PRIMARY KEY IDENTITY,
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    UserName NVARCHAR(50) NOT NULL,
    PasswordHash NVARCHAR(100) NOT NULL-- Almacenar el hash de la contraseña en lugar de la contraseña en texto plano
);

CREATE TABLE Customers (
    CustomerId INT PRIMARY KEY IDENTITY,
    FullName NVARCHAR(50) NOT NULL,
    DocumentNumber NVARCHAR(20) NOT NULL
);

CREATE TABLE Bookings (
    BookingId INT PRIMARY KEY IDENTITY,
    RegisterDate DATETIME NOT NULL,
    Code NVARCHAR(50) NOT NULL,
    Type NVARCHAR(50) NOT NULL,
	 UserId INT,
    CustomerId INT,
    FOREIGN KEY (UserId) REFERENCES Users(UserId),
    FOREIGN KEY (CustomerId) REFERENCES Customers(CustomerId)  
);
