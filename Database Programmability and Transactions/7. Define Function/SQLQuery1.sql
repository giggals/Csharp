CREATE  FUNCTION ufn_IsWordComprised(@setOfLetters VARCHAR(MAX), @word VARCHAR(MAX))
RETURNS BIT
AS
BEGIN 
   DECLARE @index INT = 1;
   DECLARE @currentLetter CHAR(1);
   DECLARE @isComprised INT = 1;
   WHILE(@index <= LEN(@word))
   BEGIN
        SET @currentLetter = SUBSTRING(@word, @index ,1);
		SET @isComprised = CHARINDEX(@currentLetter , @setOfLetters)
		SET @index += 1;
		IF(@isComprised = 0)
		BEGIN
		    RETURN 0;
		END
   END

   RETURN @isComprised;
END



