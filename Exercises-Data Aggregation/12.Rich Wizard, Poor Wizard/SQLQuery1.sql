SELECT SUM(e.Diff) AS [TotalSum] FROM (
SELECT	DepositAmount - LEAD(DepositAmount) OVER (ORDER BY Id) AS Diff
  FROM WizzardDeposits
  ) AS e