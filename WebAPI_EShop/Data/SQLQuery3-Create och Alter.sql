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