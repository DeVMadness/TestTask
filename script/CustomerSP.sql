CREATE PROCEDURE CreateCustomer
    @UserID INT,
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(20)
AS
BEGIN
    INSERT INTO Customer (UserID, Name, Email, Phone)
    VALUES (@UserID, @Name, @Email, @Phone)
END


CREATE PROCEDURE GetCustomerByID
    @CustomerID INT
AS
BEGIN
    SELECT * FROM Customer
    WHERE CustomerID = @CustomerID
END

CREATE PROCEDURE UpdateCustomer
    @CustomerID INT,
    @UserID INT,
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(20)
AS
BEGIN
    UPDATE Customer
    SET UserID = @UserID, Name = @Name, Email = @Email, Phone = @Phone
    WHERE CustomerID = @CustomerID
END



CREATE PROCEDURE DeleteCustomer
    @CustomerID INT
AS
BEGIN
    DELETE FROM Customer
    WHERE CustomerID = @CustomerID
END
