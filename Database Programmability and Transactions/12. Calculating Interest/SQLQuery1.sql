CREATE PROCEDURE usp_CalculateFutureValueForAccount(@accountId INT, @interestRate FLOAT)
AS 
    SELECT a.Id AS [AccountId] ,
				 ah.FirstName ,
				 ah.LastName , 
				 a.Balance AS [Current Balance],
				 dbo.ufn_CalculateFutureValue(Balance ,@interestRate ,5)
	  FROM AccountHolders AS ah
	  JOIN Accounts As a
	    ON a.AccountHolderId = ah.Id
		WHERE a.Id = @accountId

		EXEC dbo.usp_CalculateFutureValueForAccount 1,0.1
     