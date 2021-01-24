CREATE FUNCTION add_delo(
	a_od TIMESTAMP,
	a_proid INT,
	a_do TIMESTAMP DEFAULT NULL,
	a_komentar TEXT DEFAULT NULL
) RETURNS SETOF delo AS
$$
DECLARE
	res delo%ROWTYPE;
BEGIN
	INSERT INTO delo(d_od, d_do, komentar, projekt_id)
	VALUES (a_od, a_do, a_komentar, a_proid)
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION edit_delo(
	a_id INT,
	a_od TIMESTAMP,
	a_proid INT,
	a_do TIMESTAMP DEFAULT NULL,
	a_komentar TEXT DEFAULT NULL
) RETURNS SETOF delo AS
$$
DECLARE
	res delo%ROWTYPE;
BEGIN
	UPDATE delo
	SET d_od = a_od, d_do = a_do, komentar = a_komentar, projekt_id = a_proid
	WHERE id = a_id
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION get_delo(a_id INT DEFAULT NULL)
RETURNS SETOF delo AS
$$
DECLARE
	res delo%ROWTYPE;
BEGIN
	RETURN QUERY
	SELECT * FROM delo
	WHERE a_id IS NULL
	OR id = a_id;
END;
$$ LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION delete_delo(a_deloid INT, a_projektid INT)
RETURNS BOOLEAN AS
$$
DECLARE
	res INT;
BEGIN
	DELETE FROM projekti
	WHERE id = a_deloid
	AND projekt_id = a_projekt_id
	RETURNING * INTO res;
	
	IF res > 0 THEN RETURN TRUE;
	ELSE RETURN FALSE; END IF;
END;
$$ LANGUAGE 'plpgsql';

