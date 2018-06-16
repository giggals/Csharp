CREATE PROCEDURE usp_GetTownsStartingWith(@letter VARCHAR(50))
AS
   SELECT [Name] AS Town 
   FROM Towns
   WHERE SUBSTRING([Name],1,LEN(@letter)) = @letter

 
 EXEC dbo.usp_GetTownsStartingWith 'Be'

    