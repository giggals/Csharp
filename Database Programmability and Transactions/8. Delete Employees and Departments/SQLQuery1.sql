CREATE PROCEDURE usp_DeleteEmployeesFromDepartment(@departmentId INT)
AS
  DELETE FROM Departments
        WHERE DepartmentID = @departmentId 
  

