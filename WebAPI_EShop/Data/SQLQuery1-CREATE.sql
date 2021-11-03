CREATE TABLE Products (
	Id int not null identity primary key,
	Name nvarchar(150) not null,
	Description nvarchar(max) not null,
	Price money not null
)

GO

CREATE TABLE Addresses (
	Id int not null identity primary key,
	AddressLine nvarchar(100) not null,
	HouseNr smallint null,
	ZipCode char(6) not null,
	City nvarchar(50) not null
)
GO
CREATE TABLE Users (
	Id int not null identity primary key,
	FirstName nvarchar(50) not null,
	LastName nvarchar(50) not null,
	Email varchar(100) not null unique
)
GO

CREATE TABLE UserAddresses (
	Id int not null identity primary key,
	UserId int not null references Users(Id),
	AddressId int not null references Addresses(Id)
)
GO
CREATE TABLE Orders (
	Id int not null identity primary key,
	UserId int not null references Users(id),
	OrderDate datetimeoffset not null,
	OurReference nvarchar(100) null,
	Status nvarchar(50) not null
)
GO

CREATE TABLE OrderLines (
	OrderId int not null references Orders(Id),
	ProductId int not null references Products(Id),
	Quantity int not null default 1,
	UnitPrice money not null default 0

	primary key (OrderId, ProductId)
)
GO
CREATE TABLE Categories(
	Id int not null identity primary key,
	Name nvarchar(100) not null unique,
)
GO
CREATE TABLE SubCategories(
	Id int not null identity primary key,
	Name nvarchar(100) not null unique,
	CategoryId int not null references Categories(id)
)
GO
ALTER TABLE Products
ADD SubCategoryId int not null references SubCategories(id);
