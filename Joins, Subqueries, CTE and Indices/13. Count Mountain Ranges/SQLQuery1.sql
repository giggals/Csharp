SELECT mc.CountryCode ,
 COUNT (mc.MountainId) AS MountainRange
  FROM MountainsCountries AS mc
WHERE mc.CountryCode IN('RU','BG','US')
GROUP BY mc.CountryCode

