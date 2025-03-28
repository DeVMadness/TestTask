create procedure InsertUser	
	@Name NVARCHAR(100)
AS
BEGIN
	Insert Into [User] (Name) 
	VALUES (@Name)
END

CREATE PROCEDURE GetUsers
AS
BEGIN
    SELECT UserID, Name
    FROM [User];
END;


CREATE PROCEDURE GetUsersById
    @UserID INT
AS
BEGIN
    SELECT UserID, Name
    FROM [User]
    WHERE UserID = @UserID;
END;

CREATE PROCEDURE UpdateUsers
    @UserID INT,
    @Name NVARCHAR(100)
AS
BEGIN
    UPDATE [User]
    SET Name = @Name
    WHERE UserID = @UserID;
END;

CREATE PROCEDURE DeleteUser
    @UserID INT
AS
BEGIN
    DELETE FROM [User]
    WHERE UserID = @UserID;
END;

