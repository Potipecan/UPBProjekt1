CREATE OR REPLACE FUNCTION add_projekt(
	a_naslov VARCHAR(100),
	a_polozaj VARCHAR(100),	
	a_stranka VARCHAR(100),
	a_uporabnik_id INT,
	a_opis TEXT DEFAULT NULL,
	a_aktiven BOOLEAN DEFAULT TRUE
) RETURNS SETOF projekti AS
$$
DECLARE 
	res projekti%ROWTYPE;
BEGIN

	INSERT INTO projekti(naslov, opis, polozaj, aktiven, stranka, uporabnik_id)
	VALUES (a_naslov, a_opis, a_polozaj, a_aktiven, a_stranka, a_uporabnik_id)
	RETURNING *INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION edit_projekt(
	a_id INT,
	a_naslov VARCHAR(100),
	a_polozaj VARCHAR(100),	
	a_stranka VARCHAR(100),
	a_uporabnik_id INT,
	a_opis TEXT DEFAULT NULL,
	a_aktiven BOOLEAN DEFAULT TRUE
) RETURNS SETOF projekti AS
$$
DECLARE 
	res projekti%ROWTYPE;
BEGIN
	UPDATE projekti
	SET naslov = a_naslov, polozaj = a_polozaj, stranka = a_stranka, opis = a_opis, aktiven = a_aktiven
	WHERE id = a_id
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';

CREATE OR REPLACE FUNCTION get_projekti(a_userid INT, a_projektid INT DEFAULT NULL)
RETURNS SETOF projekti AS
$$
BEGIN
	RETURN QUERY
	SELECT * FROM projekti
	WHERE uporabnik_id = a_userid
	AND (id = a_projektid OR a_projektid < 0);
END;
$$ LANGUAGE 'plpgsql';

CREATE FUNCTION delete_projekt(a_userid INT, a_projektid INT)
RETURNS BOOLEAN AS
$$
DECLARE
	res INT;
BEGIN
	DELETE FROM projekti
	WHERE id = a_projektid
	AND uporabnik_id = a_userid
	RETURNING * INTO res;
	
	IF res > 0 THEN RETURN TRUE;
	ELSE RETURN FALSE; END IF;
END;
$$ LANGUAGE 'plpgsql';