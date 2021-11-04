SELECT * FROM Products
SELECT * FROM Addresses
SELECT * FROM Users

DELETE FROM Users WHERE Id=3;

SELECT Users.FirstName, Users.LastName, Users.Email, AddressLine, Addresses.City
FROM Users
INNER JOIN Addresses
ON Users.Id = Users.Id;