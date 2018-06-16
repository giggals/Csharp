CREATE PROCEDURE usp_EmployeesBySalaryLevel(@salaryLevel VARCHAR(7))
AS 
    SELECT FirstName , LastName
	  FROM Employees
	 WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel


	 EXEC dbo.usp_EmployeesBySalaryLevel 'High'