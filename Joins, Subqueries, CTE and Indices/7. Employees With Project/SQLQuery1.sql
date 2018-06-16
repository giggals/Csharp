SELECT TOP(5) e.EmployeeID ,e.FirstName , p.[Name] AS ProjectName
  FROM Employees AS e
JOIN EmployeesProjects AS emp
ON  emp.EmployeeID = e.EmployeeID
JOIN Projects AS p
ON emp.ProjectID = p.ProjectID AND p.StartDate > 13/08/2002
WHERE p.EndDate IS NULL
ORDER BY EmployeeID



