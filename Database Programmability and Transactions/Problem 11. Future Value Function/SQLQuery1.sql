CREATE FUNCTION ufn_CalculateFutureValue(@sum DECIMAL(15,4), @yearlyInterestRate FLOAT ,
@numberOfYears INT)
RETURNS DECIMAL(15,4)
AS
BEGIN
	DECLARE @result DECIMAL(15,4);
	SET @result = @sum * POWER((1 + @yearlyInterestRate),@numberOfYears)
	RETURN @result
END

SELECT dbo.ufn_CalculateFutureValue(1000, 0.1, 5)