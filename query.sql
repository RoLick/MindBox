CREATE TABLE Product
(
	ID INT NOT NULL PRIMARY KEY,
	"Name" TEXT
);

CREATE TABLE Category
(
	ID INT NOT NULL PRIMARY KEY,
	"Name" TEXT
);

CREATE TABLE ProductCategory (
	ProductId INT FOREIGN KEY REFERENCES Product(Id),
	CategoryId INT FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO Product (ID, "Name")
VALUES 
(1, 'IPhone'),
(2, 'NVidia RTX 4090'),
(3, 'Noname keyboard');

INSERT INTO Category
VALUES
	(1, 'Phone'),
	(2, 'Smartphone'),
	(3, 'Videocart'),
	(4, 'Eat');

INSERT INTO ProductCategory
VALUES
	(1, 1),
	(1, 2),
	(2, 3);

SELECT p."Name", c.Name 
FROM Product p
LEFT JOIN ProductCategory pc on p.ID = pc.ProductId
LEFT JOIN Category c on c.ID = pc.CategoryId;
