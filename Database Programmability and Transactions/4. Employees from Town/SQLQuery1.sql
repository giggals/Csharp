CREATE PROCEDURE usp_GetEmployeesFromTown(@townName VARCHAR(32))
AS
   SELECT e.FirstName , e.LastName
     FROM Employees AS e
      JOIN Addresses AS a
	    ON a.AddressID = e.AddressID
      JOIN Towns AS t
	    ON t.TownID = a.TownID AND t.Name = @townName


	EXEC dbo.usp_GetEmployeesFromTown 'Sofia'