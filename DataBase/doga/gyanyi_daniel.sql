-- 2.feladat
CREATE DATABASE IF NOT EXISTS `autókölcsönző`
CHARACTER SET = 'utf8'
COLLATE = 'utf8_hungarian_ci';
-- 3.feladat
CREATE TABLE `autókölcsönző`.`auto` (`azonosito` INT NOT NULL AUTO_INCREMENT , `tipus` TEXT NOT NULL , `gyarto` TEXT NOT NULL , `ajtoszam` INT NOT NULL , `gyartasi_ev` INT NOT NULL , `kilometer_ora` INT NOT NULL , `ár` INT NOT NULL , PRIMARY KEY (`azonosito`)) ENGINE = InnoDB;
-- 4.feladat
CREATE TABLE `autókölcsönző`.`szemely` (`azonosito` INT NOT NULL AUTO_INCREMENT , `nev` TEXT NOT NULL , `auto_azonosito` INT NOT NULL , PRIMARY KEY (`azonosito`)) ENGINE = InnoDB; 
-- 5.feladat
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Horváth Dániel',2);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Kovács Viktória',3);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Molnár Gergő',7);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Szabó Anna',8);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Nagy Ádám',1);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Tóth Zoltán',4);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Kiss Orsolya',5);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Bíró Máté',5);
INSERT INTO szemely(nev,auto_azonosito) VALUES ('Farkas Kata',1);
-- 6.feladat
SELECT * FROM `auto` ORDER BY `ar` DESC LIMIT 1; 
-- 7.feladat
SELECT `auto`.`ar`, `auto`.`gyartas_ev`, `szemely`.`nev`
FROM `auto`, `szemely`
ORDER BY `auto`.`gyartas_ev`;
-- 8.feladat

-- 9.feladat
UPDATE `szemely` SET `auto_azonosito` = '3' WHERE `szemely`.`nev` = 'Kiss Orsolya'
-- 10.feladat
ALTER TABLE `auto` ADD `kolcsonozheto_e` BOOLEAN NOT NULL DEFAULT TRUE AFTER `ar`; 
-- 11.feladat
DELETE FROM auto WHERE `auto`.`tipus` = 'q7'