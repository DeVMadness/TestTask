CREATE PROCEDURE CreateOrderProduct
    @OrderID INT,
    @ProductID INT,
    @Quantity INT
AS
BEGIN
    INSERT INTO OrderProduct (OrderID, ProductID, Quantity)
    VALUES (@OrderID, @ProductID, @Quantity)
END


CREATE PROCEDURE GetOrderProductByOrderIDAndProductID
    @OrderID INT,
    @ProductID INT
AS
BEGIN
    SELECT * FROM OrderProduct
    WHERE OrderID = @OrderID AND ProductID = @ProductID
END

CREATE PROCEDURE UpdateOrderProduct
    @OrderID INT,
    @ProductID INT,
    @Quantity INT
AS
BEGIN
    UPDATE OrderProduct
    SET Quantity = @Quantity
    WHERE OrderID = @OrderID AND ProductID = @ProductID
END


CREATE PROCEDURE DeleteOrderProduct
    @OrderID INT,
    @ProductID INT
AS
BEGIN
    DELETE FROM OrderProduct
    WHERE OrderID = @OrderID AND ProductID = @ProductID
END
