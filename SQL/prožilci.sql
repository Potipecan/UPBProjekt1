CREATE OR REPLACE FUNCTION make_archive()
RETURNS TRIGGER AS
$$
BEGIN
	IF tg_op == 'CREATE'
	OR OLD.ime != NEW.ime
	OR OLD.priimek != NEW.priimek
	OR OLD.uime != NEW.uime
	OR OLD.email != NEW.email
	OR OLD.naslov != NEW.naslov
	OR OLD.kraj_id != NEW.kraj_id
	THEN
		INSERT INTO arhiv (ime, priimek, uime, email, naslov, kraj_id, st_projektov, st_opravljenih_pro, datum, original_id)
		VALUES (
			NEW.ime,
			NEW.priimek,
			NEW.uime,
			NEW.email,
			NEW.naslov,
			NEW.kraj_id,
			NEW.st_projektov,
			NEW.st_opravljenih_pro,
			CURRENT_TIMESTAMP,
			NEW.id
		);
	END IF;
	RETURN NULL;
END;
$$ LANGUAGE 'plpgsql';

CREATE TRIGGER trig_make_archive
AFTER INSERT OR UPDATE
ON uporabniki FOR EACH STATEMENT
EXECUTE PROCEDURE make_archive();

CREATE OR REPLACE FUNCTION count_projects()
RETURNS TRIGGER AS
$$
DECLARE
	uid INT;
	comp INT;
	allp INT;
BEGIN
	IF tg_op = 'INSERT' THEN uid := NEW.uporabnik_id;
	ELSE uid := OLD.uporabnik_id; END IF;

	SELECT INTO allp, comp COUNT(*), COUNT(*) FILTER(WHERE NOT aktiven)
	FROM projekti
	WHERE uporabnik_id = uid;
	
	UPDATE uporabniki
	SET st_projektov = allp, st_opravljenih_pro = comp
	WHERE id = uid;
	
	RETURN NULL;
END;
$$ LANGUAGE 'plpgsql';

CREATE TRIGGER trig_count_projects
AFTER INSERT OR UPDATE OR DELETE
ON projekti FOR EACH STATEMENT
EXECUTE PROCEDURE count_projects();

CREATE OR REPLACE FUNCTION count_hours()
RETURNS TRIGGER AS
$$
DECLARE
	pid INT;
	h INT;
BEGIN
	IF tg_op = 'DELETE' AND OLD.d_do IS NOT NULL
	THEN 
		pid := OLD.project_id;
		h := -EXTRACT(epoch FROM OLD.d_do - OLD.d_od) / 3600;
	ELSE IF NEW.d_do IS NOT NULL
	THEN
		pid := NEW.project_id;
		h := EXTRACT(epoch FROM NEW.d_do - OLD.d_od) / 3600;
	END IF;
	END IF;
		
	UPDATE projekti
	SET st_ur = st_ur + h
	WHERE id = pid;
	
	RETURN NULL;
END;
$$ LANGUAGE 'plpgsql';

CREATE TRIGGER trig_count_hours
AFTER INSERT OR UPDATE
ON delo FOR EACH STATEMENT
EXECUTE PROCEDURE count_hours();
