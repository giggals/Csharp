CREATE PROCEDURE usp_GetHoldersWithBalanceHigherThan(@money DECIMAL(15,2))
AS
	SELECT ah.FirstName , ah.LastName
		FROM Accounts AS a
	  JOIN AccountHolders As ah
	  ON ah.Id = a.AccountHolderId 	
	  GROUP BY ah.FirstName , ah.LastName
	  HAVING SUM(a.Balance) > @money
	  

	  EXEC dbo.usp_GetHoldersWithBalanceHigherThan 123.23