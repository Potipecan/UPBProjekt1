
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
RETURNS INT AS
$$
DECLARE
	uid INT;
BEGIN
	uid := -1;
	INSERT INTO uporabniki (ime, priimek, uime, email, naslov, kraj_id, geslo)
	VALUES (a_ime, a_priimek, a_uime, a_email, a_naslov, a_kraj_id, MD5(a_geslo))
	RETURNING id INTO uid;
	
	INSERT INTO nastavitve(font, temno, uporabnik_id)
	VALUES ('Arial', TRUE, uid);
	
	RETURN uid;
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

-- odstrani uporabnika - izbris računa
CREATE OR REPLACE FUNCTION delete_user(a_id INT)
RETURNS INT AS
$$
DECLARE
	res INT;
	po polozaji%ROWTYPE; 
BEGIN
	FOR po IN SELECT * FROM polozaji WHERE uporabnik_id = a_id
	LOOP
		DELETE FROM dela
		WHERE polozaj_id = po.id;
		
		DELETE FROM polozaji
		WHERE id = po.id;
	END LOOP;	
	
	DELETE FROM nastavitve
	WHERE uporabnik_id = a_id;
	
	DELETE FROM uporabniki
	WHERE id = a_id
	RETURNING * INTO res;
	
	RETURN res;
END;
$$ LANGUAGE 'plpgsql';

-- urejanje uporabnika
CREATE FUNCTION update_user(
	a_id INT,
	a_ime VARCHAR(40),
	a_priimek VARCHAR(40),
	a_uime VARCHAR(100),
	a_email VARCHAR(100),
	a_naslov VARCHAR(100),
	a_kraj_id INT,
	a_geslo VARCHAR(255),
	a_pass_chk VARCHAR(255)
)
RETURNS SETOF uporabniki AS
$$
DECLARE
	res uporabniki%ROWTYPE;
BEGIN
	UPDATE uporabniki
	SET ime = a_ime, 
	priimek = a_priimek, 
	u_ime = a_uime, 
	email = a_email, 
	naslov = a_naslov, 
	kraj_id = a_kraj_id,
	geslo = MD5(a_geslo)
	WHERE id = a_id
	AND geslo = MD5(a_pass_chk)
	RETURNING * INTO res;
	
	RETURN NEXT res;
END;
$$ LANGUAGE 'plpgsql';