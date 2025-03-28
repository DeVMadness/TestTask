CREATE PROCEDURE CreateProduct
    @Name NVARCHAR(100),
    @Price DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Product (Name, Price)
    VALUES (@Name, @Price)
END

CREATE PROCEDURE GetProductByID
    @ProductID INT
AS
BEGIN
    SELECT * FROM Product
    WHERE ProductID = @ProductID
END

CREATE PROCEDURE UpdateProduct
    @ProductID INT,
    @Name NVARCHAR(100),
    @Price DECIMAL(10, 2)
AS
BEGIN
    UPDATE Product
    SET Name = @Name, Price = @Price
    WHERE ProductID = @ProductID
END



CREATE PROCEDURE DeleteProduct
    @ProductID INT
AS
BEGIN
    DELETE FROM Product
    WHERE ProductID = @ProductID
END

CREATE PROCEDURE GetProducts
AS
BEGIN
    SELECT * FROM Product
END
