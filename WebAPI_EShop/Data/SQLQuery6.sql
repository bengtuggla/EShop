SELECT * FROM Orders
ALTER TABLE Orders
DROP COLUMN OrderDate;
INSERT INTO Orders (UserId, OurReference, Status)
VALUES (4, 'Nils', 'OK');


