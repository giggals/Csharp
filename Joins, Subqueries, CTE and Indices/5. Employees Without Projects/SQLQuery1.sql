SELECT TOP(3) e.EmployeeID ,e.FirstName
 FROM Employees AS e
 LEFT JOIN EmployeesProjects AS emp
 ON e.EmployeeID = emp.EmployeeID	
 WHERE emp.EmployeeID IS NULL
 ORDER BY e.EmployeeID

