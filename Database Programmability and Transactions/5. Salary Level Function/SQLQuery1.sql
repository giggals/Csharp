CREATE  FUNCTION ufn_GetSalaryLevel(@salary DECIMAL(18,4)) 
RETURNS VARCHAR(7)
AS
BEGIN
   DECLARE @salaryLevel NVARCHAR(7);
   IF(@salary < 30000)
   BEGIN
      SET  @salaryLevel = 'Low';
   END
   ELSE IF (@salary >= 30000 AND @salary <= 50000)
   BEGIN 
        SET @salaryLevel = 'Average'
   END
   ELSE SET @salaryLevel = 'High'
   RETURN @salaryLevel;
END


  SELECT Salary ,
         dbo.ufn_GetSalaryLevel(Salary) AS SalaryLevel
	FROM Employees
	



--	•	If salary is < 30000 return “Low”
--•	If salary is between 30000 and 50000 (inclusive) return “Average”
--•	If salary is > 50000 return “High”
