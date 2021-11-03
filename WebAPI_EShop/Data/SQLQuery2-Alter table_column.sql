ALTER TABLE Products
ADD ImageUrl nvarchar(max) not null;

ALTER TABLE Products
DROP COLUMN urlImg;

ALTER TABLE Users
ADD Password string not null;