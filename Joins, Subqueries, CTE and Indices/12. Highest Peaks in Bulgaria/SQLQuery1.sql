SELECT c.CountryCode , m.MountainRange , p.PeakName , p.Elevation
FROM Countries AS c
JOIN MountainsCountries AS mc
ON mc.CountryCode = c.CountryCode AND mc.CountryCode= 'BG'
JOIN Mountains AS m
  ON mc.MountainId = m.Id
JOIN Peaks AS p
ON p.MountainId = mc.MountainId AND P.Elevation > 2835
ORDER BY p.Elevation DESC