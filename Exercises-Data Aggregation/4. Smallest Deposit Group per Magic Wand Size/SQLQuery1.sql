SELECT TOP(2) DepositGroup 
  FROM WizzardDeposits
   GROUP By DepositGroup
   ORDER BY AVG(MagicWandSize)
