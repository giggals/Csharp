SELECT e.FirstName , e.LastName , e.HireDate ,d.[Name] AS DeptName
  FROM Employees AS e
  JOIN Departments AS d
    ON d.DepartmentID = e.DepartmentID AND e.HireDate > 01/01/1999
	WHERE d.[Name] IN('Sales' , 'Finance')
ORDER BY HireDate ASC
 
