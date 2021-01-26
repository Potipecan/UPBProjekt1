CREATE OR REPLACE FUNCTION add_kraj(a_ime VARCHAR(100), a_koda VARCHAR(10), a_kr VARCHAR(10) DEFAULT NULL)
RETURNS SETOF kraji AS
$$
DECLARE
	res kraji%ROWTYPE;
BEGIN
	INSERT INTO kraji (ime, posta, kratica)
	VALUES (a_ime, a_koda, a_kr)
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION all_kraji()
RETURNS SETOF kraji AS
$$
BEGIN
	RETURN QUERY
	SELECT * FROM kraji;
END;
$$ LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION update_kraj(a_id INT, a_ime VARCHAR(100), a_koda VARCHAR(10), a_kr VARCHAR(10) DEFAULT NULL)
RETURNS SETOF kraji AS
$$
DECLARE 
	res kraji%ROWTYPE;
BEGIN
	UPDATE kraji
	SET ime = a_ime, posta = a_koda, kratica = a_kr
	WHERE id = a_id
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';


CREATE OR REPLACE FUNCTION delete_kraj(a_id INT)
RETURNS BOOLEAN AS
$$
DECLARE
	o INT;
BEGIN
	DELETE FROM kraji
	WHERE id = a_id
	RETURNING id INTO o;
	
	IF o IS NULL THEN 
		RETURN FALSE; 
	END IF;
	RETURN TRUE;
END;
$$ LANGUAGE 'plpgsql';
