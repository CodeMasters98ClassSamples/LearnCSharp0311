--ALTER PROCEDURE AddStudent
--(
--	@FirstName		NVARCHAR(150),
--	@LastName		NVARCHAR(150),
--	@PhoneNumber	NVARCHAR(11),
--	@Referer		NVARCHAR(150),
--	@University		NVARCHAR(150)
--)
--AS
--BEGIN
--	DECLARE @UserId INT

--	INSERT INTO dbo.[User](FirstName, LastName, PhoneNumber)
--	VALUES(@FirstName, @LastName, @PhoneNumber)

--	SET @UserId = (SELECT TOP 1 Id FROM dbo.[User] WHERE PhoneNumber = @PhoneNumber ORDER BY ID DESC)

--	INSERT INTO dbo.Student(UserId,Referer,University)
--	VALUES(@UserId,@Referer,@University)
--END

--EXEC dbo.AddStudent @FirstName = 'Mahsa',@LastName='Mahsa',@PhoneNumber='09122111111',@Referer='Mahsa',@University = 'Mahsa'