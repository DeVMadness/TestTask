CREATE PROCEDURE CreateOrder
    @CustomerID INT
AS
BEGIN
    INSERT INTO [Order] (CustomerID)
    VALUES (@CustomerID)
END


CREATE PROCEDURE GetOrderByID
    @OrderID INT
AS
BEGIN
    SELECT * FROM [Order]
    WHERE OrderID = @OrderID
END


CREATE PROCEDURE UpdateOrder
    @OrderID INT,
    @CustomerID INT
AS
BEGIN
    UPDATE [Order]
    SET CustomerID = @CustomerID
    WHERE OrderID = @OrderID
END


CREATE PROCEDURE DeleteOrder
    @OrderID INT
AS
BEGIN
    DELETE FROM [Order]
    WHERE OrderID = @OrderID
END
