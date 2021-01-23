CREATE FUNCTION get_settings(a_uid INT)
RETURNS SETOF nastavitve AS
$$
BEGIN
	RETURN QUERY
	SELECT * FROM nastavitve WHERE uporabnik_id = a_uid;
END;
$$ LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION set_settings(a_uid INT, a_darkmode BOOLEAN, a_font VARCHAR(50))
RETURNS SETOF nastavitve AS
$$
DECLARE
	res nastavitve%ROWTYPE;
BEGIN
	UPDATE nastavitve
	SET temno = a_darkmode, font = a_font
	WHERE uporabnik_id = a_uid
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';

