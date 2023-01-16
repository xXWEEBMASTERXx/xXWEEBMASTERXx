-- 3. feladat:
SELECT `nev`, `jaras`, `terulet`
FROM `varos`
WHERE `nev` LIKE '%vásár%';
-- 4. feladat:
SELECT SUM(`nepesseg`) AS "Lakosság száma"
FROM `varos`
WHERE `jaras` = 'komáromi';
-- 5. feladat:
SELECT * 
FROM `megye`
WHERE `nev` LIKE "V%";
-- 6. feladat:
SELECT DISTINCT COUNT(`vtip`) AS "Városfajták száma"
FROM `varostipus`;
-- 7. feladat:
SELECT `megye`.`nev`, `megye`.`nagytaj`, `varos`.`nev`, `varos`.`vtipid`, `varos`.`megyeid`, `varos`.`jaras`, `varos`.`kisterseg`, `varos`.`nepesseg`, `varos`.`terulet`
FROM `megye` 
	INNER JOIN `varos` ON `varos`.`megyeid` = `megye`.`id`
ORDER BY `varos`.`kisterseg`;
-- 8. feladat:
SELECT `nev`, `terulet`
FROM `varos`
WHERE `terulet` > 200 AND `vtipid` = 2;
-- 9. feladat:
SELECT `nev`,`nepesseg`
FROM `varos`
WHERE `nepesseg` > 15000 AND `megyeid` = 7;
-- 10. feladat:
SELECT `megye`.`nev` AS "Megye", `varos`.`kisterseg`, COUNT(`varos`.`id`) AS "Városok száma", SUM(`varos`.`nepesseg`) AS "Népesség"
FROM `varos`,`megye`
WHERE (`varos`.`megyeid` = 19 OR `varos`.`megyeid` = 21) AND `varos`.`terulet` BETWEEN 100 AND 200
GROUP BY `varos`.`kisterseg`;
-- 11. feladat:

-- 12. feladat:

-- 13. feladat:
