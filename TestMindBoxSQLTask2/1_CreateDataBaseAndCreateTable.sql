IF DB_ID('MindBoxTest') IS NULL
	Create DataBase MindBoxTest;


Use MindBoxTest;
IF NOT EXISTS (SELECT *
                 FROM INFORMATION_SCHEMA.TABLES
					WHERE TABLE_NAME = 'Products')
BEGIN 
	Create Table Products 
	(
		ID INT Primary KEY IDENTITY(1,1),
		Name nvarchar(100) NOT NULL
	)
END


IF NOT EXISTS (SELECT *
                 FROM INFORMATION_SCHEMA.TABLES
					WHERE TABLE_NAME = 'Categories')
BEGIN 
	Create Table Categories 
	(
		ID INT Primary KEY IDENTITY(1,1),
		Name nvarchar(100) NOT NULL
	)
END


IF NOT EXISTS (SELECT *
                 FROM INFORMATION_SCHEMA.TABLES
					WHERE TABLE_NAME = 'ProductCategories')
BEGIN 
	Create Table ProductCategories 
	(
		ProductID INT NOT NULL,
		FOREIGN KEY (ProductID) REFERENCES Products(ID),

		CategoryID INT NOT NULL,
		FOREIGN KEY (ProductID) REFERENCES Products(ID),

		PRIMARY KEY (ProductID, CategoryID)
	)
END

