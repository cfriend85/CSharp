--Stored Procedures

--Using input parameters
USE TestDB
GO

CREATE PROCEDURE dbo.GetCustomerByCity @City varchar(25)
AS
SELECT *
FROM [dbo].[Customer]
WHERE City = @City
GO

EXEC GetCustomerByCity 'Boston'



--Using input and output parameters
USE DBNAME
GO

CREATE PROCEDURE spGetEmployeeCountByGender
@Gender nchar(1), @EmployeeCount int OUTPUT--Sets this variable as the output
AS
BEGIN
SELECT @EmployeeCount = COUNT([BusinessEntityID])
FROM [HumanResources].[Employee]
WHERE Gender = @Gender
END

--Execute
DECLARE @EmpCountByGender int
EXECUTE spGetEmployeeCountByGender 'F', @EmpCountByGender OUTPUT--catches output variable from proc and assigns to this variable
PRINT @EmpCountByGender
GO



--Return Codes
USE DBNAME
GO

CREATEK PROCEDURE GetCategories
(
@Cat_Name varchar(20)
)
AS
BEGIN
SELECT *
FROM [dbo].[Category]
WHERE [Category_Name] LIKE '%' + @Cat_Name + '%' --% sign is the wildcard
IF @@ROWCOUNT > 0
    BEGIN
        PRINT @Cat_Name + ' category found!'
        RETURN(1)--1 being the success code
    END
ELSE
    BEGIN
        PRINT 'No category of ' +@CatName + ' was found'
        RETURN(0)--0 being the failure code
    END
END

EXEC GetCategories 'Movies'
GO


--Protect a Stored Procedure's source code
CREATE PROCEDURE ProtectedProcedure
WITH ENCRYPTION
AS
BEGIN
    PRINT 'This is a protected procedure'
END
GO

EXEC ProtectedProcedure