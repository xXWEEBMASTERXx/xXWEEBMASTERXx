-- 3. feladat
SELECT `nev`
FROM `ugyfel`;
-- 4. feladat
SELECT *
FROM `ugyfel`;
-- 5. feladat
SELECT `nev`, `szulev`
FROM `ugyfel`;
WHERE `irszam` BETWEEN 1152 and 2752;
-- 6. feladat
SELECT SUM(osszeg) AS 'Összes befizetés'
FROM `befiz`;
-- 7. feladat
SELECT AVG(osszeg) AS 'Átlagos befizetés'
FROM `befiz`;
-- 8. feladat
SELECT MIN(osszeg) AS 'Minimum' Max(osszeg) AS 'Maximum'
FROM `befiz`;
-- 9. feladat
SELECT COUNT(azon) AS 'Befizetések száma'
FROM `befiz`;
-- 10. feladat
SELECT `befiz`.`osszeg`, `befiz`.`datum`
FROM `befiz` 
	LEFT JOIN `ugyfel` ON `befiz`.`azon` = `ugyfel`.`azon`
WHERE `ugyfel`.`nev` = 'Török Bálint';
-- 11. feladat
SELECT SUM(`befiz`.`osszeg`) AS 'Nagy Károly befizetése'
FROM `befiz` 
	LEFT JOIN `ugyfel` ON `befiz`.`azon` = `ugyfel`.`azon`
WHERE `ugyfel`.`nev` = 'Nagy Károly';
-- 12. feladat
SELECT SUM(`befiz`.`osszeg`) AS 'Külföldi összeg'
FROM `befiz` 
	LEFT JOIN `ugyfel` ON `befiz`.`azon` = `ugyfel`.`azon`
WHERE NOT `ugyfel`.`orsz` = 'H';
-- 13. feladat
SELECT `ugyfel`.`nev`, SUM(`befiz`.`osszeg`) AS 'Befizetett'
FROM `ugyfel` 
	LEFT JOIN `befiz` ON `befiz`.`azon` = `ugyfel`.`azon`
GROUP BY `ugyfel`.`nev`;
-- 14. feladat

-- 15. feladat

-- 16. feladat

-- 17. feladat
