SELECT c.CountryName AS [Country],p.PeakName AS [Highest Peak Name], MAX(p.Elevation) 
AS [Highest Peak Elevation] ,m.MountainRange
  FROM Countries AS c
LEFT JOIN MountainsCountries AS mc
ON mc.CountryCode = c.CountryCode
LEFT JOIN Mountains AS m
ON m.Id = mc.MountainId
LEFT JOIN Peaks AS p
ON p.MountainId = m.Id 
GROUP BY c.CountryName,p.PeakName , p.Elevation , m.MountainRange
