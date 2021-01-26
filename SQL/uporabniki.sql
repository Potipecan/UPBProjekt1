
-- doda uporabnika - prijava
CREATE OR REPLACE FUNCTION register_user(
	a_ime VARCHAR(40),
	a_priimek VARCHAR(40),
	a_uime VARCHAR(100),
	a_email VARCHAR(100),
	a_naslov VARCHAR(100),
	a_kraj_id INT,
	a_geslo VARCHAR(255)
)
RETURNS SETOF uporabniki AS
$$
DECLARE
	result uporabniki%ROWTYPE;
	uid INT;
BEGIN
	uid := -1;
	INSERT INTO uporabniki (ime, priimek, uime, email, naslov, kraj_id, geslo)
	VALUES (a_ime, a_priimek, a_uime, a_email, a_naslov, a_kraj_id, MD5(a_geslo))
	RETURNING id INTO uid
	
	INSERT INTO nastavitve(font, temno, uporabnik_id)
	VALUES ('Arial', TRUE, uid);
	
	RETURN QUERY
	SELECT * FROM uporabniki WHERE id = uid;
END;
$$ LANGUAGE 'plpgsql';


-- dobi uporabnika - vpis
CREATE FUNCTION get_user(
	a_uime VARCHAR(100),
	a_geslo VARCHAR(255)
)
RETURNS SETOF uporabniki AS
$$
BEGIN
	RETURN QUERY
	SELECT *
	FROM uporabniki
	WHERE uime = a_uime
	AND geslo = MD5(a_geslo);
END;
$$ LANGUAGE 'plpgsql'

-- odstrani uporabnika - izbris računa in vseh povezanih informacij
CREATE OR REPLACE FUNCTION delete_user(a_id INT, a_geslo VARCHAR(100))
RETURNS BOOLEAN AS
$$
DECLARE
	num INT; 
BEGIN
	DELETE FROM uporabniki
	WHERE id = a_id AND geslo = md5(a_geslo)
	RETURNING * INTO num;
	
	IF num > 0 THEN RETURN TRUE;
	ELSE RETURN FALSE; END IF;
END;
$$ LANGUAGE 'plpgsql';

-- urejanje uporabnika
CREATE OR REPLACE FUNCTION update_user(
	a_id INT,
	a_ime VARCHAR(40),
	a_priimek VARCHAR(40),
	a_uime VARCHAR(100),
	a_email VARCHAR(100),
	a_naslov VARCHAR(100),
	a_kraj_id INT,
	a_pass_chk VARCHAR(255),
	a_geslo VARCHAR(255) DEFAULT NULL
)
RETURNS SETOF uporabniki AS
$$
DECLARE
	res uporabniki%ROWTYPE;
	tgeslo VARCHAR(255);
BEGIN
	IF a_geslo IS NOT NULL THEN tgeslo := MD5(a_geslo);
	ELSE SELECT INTO tgeslo geslo FROM uporabniki WHERE uime = a_uime AND geslo = MD5(a_pass_chk);
	END IF;
	
	UPDATE uporabniki
	SET ime = a_ime, 
	priimek = a_priimek, 
	u_ime = a_uime, 
	email = a_email, 
	naslov = a_naslov, 
	kraj_id = a_kraj_id,
	geslo = tgeslo
	WHERE id = a_id
	AND geslo = MD5(a_pass_chk)
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';



CREATE FUNCTION get_user_by_id(a_id INT)
RETURNS SETOF uporabniki AS
$$
BEGIN
	RETURN QUERY
	SELECT * FROM uporabniki WHERE id = a_id;
END;
$$ LANGUAGE 'plpgsql';