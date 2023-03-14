CREATE PROCEDURE USP_List_ps
@cText varchar(50) = ''
AS
	SELECT code_ps, 
		   description_ps
	FROM TB_POINT_OF_SALE
	WHERE state = 1 
	AND
	UPPER(TRIM(CAST(code_ps as char))+
	TRIM(description_ps))
	LIKE '%' +
	UPPER(TRIM(@cText)) + '%'
	ORDER BY 1;
GO;


CREATE PROCEDURE UPS_Save_ps
@nOption int = 0,  
@nCode   int = 0,
@nDescription varchar (50) = ''
AS
IF @nOption = 1 --New Register
	BEGIN
		INSERT INTO TB_POINT_OF_SALE(description_ps, state)
							   values(@nDescription,1)
	END;
ELSE	--Update Register
	BEGIN
		UPDATE TB_POINT_OF_SALE SET description_ps = @nDescription
								WHERE code_ps = @nCode;
	END;
GO;


CREATE PROCEDURE USP_Delete_ps
@nCode int = 0
AS
	UPDATE TB_POINT_OF_SALE SET STATE = 0 WHERE code_ps= @nCode;
GO