/*
Created: 22. 12. 2020
Modified: 24. 01. 2021
Model: PostgreSQL 10
Database: PostgreSQL 10
*/


-- Create tables section -------------------------------------------------

-- Table uporabniki

CREATE TABLE "uporabniki"(
 "id" Serial NOT NULL,
 "ime" Character varying(50) NOT NULL,
 "priimek" Character varying(50) NOT NULL,
 "uime" Character varying(50) NOT NULL,
 "email" Character varying(255) NOT NULL,
 "naslov" Character varying(100) NOT NULL,
 "kraj_id" Integer NOT NULL,
 "st_projektov" Integer DEFAULT 0 NOT NULL,
 "st_opravljenih_pro" Integer DEFAULT 0 NOT NULL,
 "geslo" Character varying(255) NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table uporabniki

CREATE INDEX "IX_Relationship2" ON "uporabniki" ("kraj_id")
;

-- Add keys for table uporabniki

ALTER TABLE "uporabniki" ADD CONSTRAINT "PK_uporabniki" PRIMARY KEY ("id")
;

ALTER TABLE "uporabniki" ADD CONSTRAINT "uime" UNIQUE ("uime")
;

ALTER TABLE "uporabniki" ADD CONSTRAINT "email" UNIQUE ("email")
;

-- Table kraji

CREATE TABLE "kraji"(
 "id" Serial NOT NULL,
 "ime" Character varying(100) NOT NULL,
 "posta" Character varying(20) NOT NULL,
 "kratica" Character varying(20)
)
WITH (
 autovacuum_enabled=true)
;

-- Add keys for table kraji

ALTER TABLE "kraji" ADD CONSTRAINT "PK_kraji" PRIMARY KEY ("id")
;

-- Table projekti

CREATE TABLE "projekti"(
 "id" Serial NOT NULL,
 "naslov" Character varying(100) NOT NULL,
 "opis" Text,
 "polozaj" Character varying(100) NOT NULL,
 "aktiven" Boolean DEFAULT true NOT NULL,
 "stranka" Character varying(100) NOT NULL,
 "st_ur" Real DEFAULT 0 NOT NULL,
 "uporabnik_id" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table projekti

CREATE INDEX "IX_Relationship14" ON "projekti" ("uporabnik_id")
;

-- Add keys for table projekti

ALTER TABLE "projekti" ADD CONSTRAINT "PK_projekti" PRIMARY KEY ("id")
;

-- Table delo

CREATE TABLE "delo"(
 "id" Serial NOT NULL,
 "d_od" Timestamp NOT NULL,
 "d_do" Timestamp,
 "komentar" Text,
 "projekt_id" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table delo

CREATE INDEX "IX_Relationship15" ON "delo" ("projekt_id")
;

-- Add keys for table delo

ALTER TABLE "delo" ADD CONSTRAINT "PK_delo" PRIMARY KEY ("id")
;

-- Table arhiv

CREATE TABLE "arhiv"(
 "id" Serial NOT NULL,
 "ime" Character varying(50) NOT NULL,
 "priimek" Character varying(50) NOT NULL,
 "uime" Character varying(50) NOT NULL,
 "email" Character varying(255) NOT NULL,
 "naslov" Character varying(100) NOT NULL,
 "st_projektov" Integer DEFAULT 0 NOT NULL,
 "st_opravljenih_pro" Integer NOT NULL,
 "datum" Timestamp NOT NULL,
 "original_id" Integer NOT NULL,
 "kraj_id" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table arhiv

CREATE INDEX "IX_Relationship11" ON "arhiv" ("original_id")
;

CREATE INDEX "IX_Relationship12" ON "arhiv" ("kraj_id")
;

-- Add keys for table arhiv

ALTER TABLE "arhiv" ADD CONSTRAINT "PK_arhiv" PRIMARY KEY ("id")
;

-- Table nastavitve

CREATE TABLE "nastavitve"(
 "id" Serial NOT NULL,
 "font" Character varying(100) NOT NULL,
 "temno" Boolean DEFAULT true NOT NULL,
 "uporabnik_id" Integer NOT NULL
)
WITH (
 autovacuum_enabled=true)
;

-- Create indexes for table nastavitve

CREATE INDEX "IX_Relationship13" ON "nastavitve" ("uporabnik_id")
;

-- Add keys for table nastavitve

ALTER TABLE "nastavitve" ADD CONSTRAINT "PK_nastavitve" PRIMARY KEY ("id")
;
-- Create foreign keys (relationships) section ------------------------------------------------- 

ALTER TABLE "uporabniki" ADD CONSTRAINT "Relationship2" FOREIGN KEY ("kraj_id") REFERENCES "kraji" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;

ALTER TABLE "arhiv" ADD CONSTRAINT "Relationship11" FOREIGN KEY ("original_id") REFERENCES "uporabniki" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;

ALTER TABLE "arhiv" ADD CONSTRAINT "Relationship12" FOREIGN KEY ("kraj_id") REFERENCES "kraji" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;

ALTER TABLE "nastavitve" ADD CONSTRAINT "Relationship13" FOREIGN KEY ("uporabnik_id") REFERENCES "uporabniki" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;

ALTER TABLE "projekti" ADD CONSTRAINT "Relationship14" FOREIGN KEY ("uporabnik_id") REFERENCES "uporabniki" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;

ALTER TABLE "delo" ADD CONSTRAINT "Relationship15" FOREIGN KEY ("projekt_id") REFERENCES "projekti" ("id") ON DELETE CASCADE ON UPDATE CASCADE
;




