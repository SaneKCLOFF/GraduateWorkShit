CREATE DATABASE SalesServicesDataBase
GO 
USE SalesServicesDataBase
GO

--СОЗДАНИЕ ТАБЛИЦ
CREATE TABLE Roles
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
)
GO
CREATE TABLE Statuses
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
)
CREATE TABLE Users
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	LastName VARCHAR(25) NOT NULL,
	FirstName VARCHAR(25) NOT NULL,
	MiddleName VARCHAR(25) NOT NULL,
	DateOfBirth DATE NOT NULL,
	[Login] VARCHAR(25) NOT NULL,
	[Password] VARCHAR(25) NOT NULL,
	RoleId INT REFERENCES Roles(Id) NOT NULL,
	Phone VARCHAR(11) NOT NULL,
	Email VARCHAR(100) NOT NULL,
	DateOfRegister DATE NOT NULL,
	NumberOfPurchases INT NOT NULL,
	NumberOfServices INT NOT NULL,
)
CREATE TABLE ProductCategories
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
)
CREATE TABLE Products
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	CategoryId INT REFERENCES ProductCategories(ID),
	Title VARCHAR(50) NOT NULL,
	Picture VARCHAR(max) NOT NULL,
	[Description] VARCHAR(max) NULL,
	Cost DECIMAL(10,2) NOT NULL,
	CountInStock INT NOT NULL,
	Discount INT NOT NULL,
	DateOfAdd DATE NOT NULL
)
CREATE TABLE [Services]
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	Title VARCHAR(50) NOT NULL,
	[Description] VARCHAR(max) NULL,
	CostPerHour DECIMAL(10,2) NOT NULL,
	DateOfAdd DATE NOT NULL
)
CREATE TABLE UserProducts
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	ProductId INT REFERENCES Products(Id) NOT NULL,
	UserId INT REFERENCES Users(Id) NOT NULL,
	Quantity INT NOT NULL,
	DateOfOrder DATE NOT NULL,
	StatusId INT REFERENCES Statuses(Id) NOT NULL,
	DateOfCompletion DATE NULL
)
CREATE TABLE UserServices
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	ServiceId INT REFERENCES [Services](Id),
	UserId INT REFERENCES Users(Id),
	DateOfOrder DATE NOT NULL,
	StatusId INT REFERENCES Statuses(Id) NOT NULL,
	DateOfCompletion DATE NULL
)
CREATE TABLE FavoriteUserProducts
(
	ID INT IDENTITY PRIMARY KEY NOT NULL,
	ProductId INT REFERENCES Products(Id) NOT NULL,
	UserId INT REFERENCES Users(Id),
	DateOfAdd DATE NOT NULL
)

--ВНЕСЕНИЕ ДАННЫХ
INSERT INTO Roles(Title)
VALUES
('Администратор'),
('Пользователь'),
('Редактор')

INSERT INTO Statuses(Title)
VALUES
('Ожидает начала выполнения'),
('В процессе'),
('Выполнен')

INSERT INTO Users(LastName,FirstName,MiddleName,DateOfBirth,[Login],[Password],RoleId,Phone,Email,DateOfRegister,NumberOfPurchases,NumberOfServices)
VALUES
('Аксёнов','Александр','Игоревич','20/03/2003','admin','admin123',1,'4356345','gavno@mail.ru','01/01/2020',0,0)

INSERT INTO ProductCategories(Title)
VALUES
('Бухгалтерия'),
('Зарплата и управление'),
('Торговля'),
('Отраслевые решения'),
('Лицензии'),
('Упраленческий учёт'),
('Некоммерческие организации')

