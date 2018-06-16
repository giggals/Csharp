SELECT e.EmployeeID , e.FirstName , p.[Name] AS ProjectName
  FROM Employees AS e
JOIN EmployeesProjects AS emp
ON emp.EmployeeID = e.EmployeeID AND e.EmployeeID = 24
LEFT  JOIN Projects AS p
ON p.ProjectID = emp.ProjectID  AND YEAR(p.StartDate) < 2005 