USE AssignmentDatabase
SELECT *
FROM Products
WHERE Price > 30

SELECT FirstName, LastName, Roles, Mail
FROM Users
WHERE FirstName LIKE 'A%'
ORDER BY Mail

SELECT SUBSTRING(ProductName, 1, 1) AS 'First Letter', COUNT(ProductName) as 'Count'
FROM Products
GROUP BY SUBSTRING(ProductName, 1, 1)

SELECT OrderId, COUNT(quantity) as 'How many products'
FROM OrderItems
GROUP BY OrderId

SELECT Products.ProductName, COUNT(ProductName) as 'How many of ProductName'
	FROM OrderItems INNER JOIN Products
	ON OrderItems.ProductId = Products.ID
GROUP BY ProductName


 
SELECT Orders.ID, SUM(OrderItems.Quantity* Products.Price) as 'Total Order Price'
	FROM Orders
	INNER JOIN OrderItems
	ON Orders.ID = OrderItems.OrderId
	INNER JOIN Products
	ON Products.ID = OrderItems.ProductId
GROUP BY Orders.ID
  
SELECT ProductName,Tags
FROM Products
WHERE Quantity > 10

SELECT *
FROM Users
WHERE FirstName LIKE 'D%'

SELECT Quantity, COUNT(Quantity) as 'How many products'
FROM Products
GROUP BY Quantity
HAVING Quantity > 10


SELECT *
FROM Orders
WHERE Price > 100 AND Price < 200