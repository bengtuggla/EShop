SELECT * FROM Users
SELECT * FROM Addresses

DELETE FROM Users WHERE Id=3;

SELECT Users.FirstName, Users.LastName, Users.Email, AddressLine, Addresses.City
FROM Users
INNER JOIN Addresses
ON Users.Id = Users.Id;