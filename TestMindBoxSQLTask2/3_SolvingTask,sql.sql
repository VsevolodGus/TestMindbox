SELECT p.Name as ProductName, 
	   c.Name as CategoryName
FROM Products p
	LEFT JOIN ProductCategories pc ON p.ID = pc.ProductID
	LEFT JOIN Categories c ON c.ID = pc.CategoryID
