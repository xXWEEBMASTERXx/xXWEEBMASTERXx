-- 3. feladat
SELECT *
FROM `felhokarcolok`;
-- 4. feladat
SELECT *
FROM `felhokarcolok`
WHERE `varos` = 'Chicago';
-- 5. feladat
SELECT `nev`,`emeletek`
FROM `felhokarcolok`
WHERE `felhasznalas` = 'lakóépület';
-- 6. feladat
SELECT `nev`,`emeletek`
FROM `felhokarcolok`;
WHERE `nev` LIKE '_1%'
-- 7. feladat
SELECT COUNT(`id`) as 'db'
FROM `felhokarcolok`;
-- 8. feladat
SELECT COUNT(`orszagkod`) as 'db'
FROM `felhokarcolok`
WHERE `orszagkod` = 'US';
-- 9. feladat
SELECT COUNT(`id`) as '`db`'
FROM `felhokarcolok`
WHERE `befejezes_eve` >= 1997 and `befejezes_eve` <= 2005
-- 10. feladat
SELECT ROUND(AVG(`emeletek`),0) as 'atlag_emelet'
FROM `felhokarcolok`
WHERE `nev` LIKE '%Tower%'
-- 11. feladat
SELECT `nev`, CONCAT(ROUND(`magassag`, 0), ' m')
FROM `felhokarcolok`
ORDER BY `magassag` DESC
LIMIT 3
-- 12. feladat
SELECT `nev`, `orszagkod`, IFNULL(`varos`, 'ismeretlen') as `varos_neve`, `befejezes_eve`, `anyag`
FROM `felhokarcolok`
WHERE `befejezes_eve` >= 1990 AND `befejezes_eve` < 2000 AND (`anyag` = 'acel' or `anyag` = 'kompozit') AND (`orszagkod` = 'CN'or `orszagkod` = 'RU' or `orszagkod` = 'MY')
ORDER BY `orszagkod`
-- 13. feladat
SELECT MAX(`emeletek`) AS 'legtobb_emelet'
FROM `felhokarcolok`
-- 14. feladat
SELECT MIN(`befejezes_eve`) AS 'elso', MAX(`befejezes_eve`) AS 'utolso'
FROM `felhokarcolok`
-- 15. feladat
SELECT ROUND(SUM(`magassag`),1) as 'osszes_`magassag`'
FROM `felhokarcolok`
WHERE `varos` = 'Hong Kong'
-- 16. feladat
SELECT `orszagkod`, COUNT(`id`) as 'db'
FROM `felhokarcolok`
GROUP by `orszagkod`
ORDER BY `db` DESC
-- 17. feladat
SELECT `felhasznalas`, AVG(`emeletek`) as '`emeletek`_atlagos_szama'
FROM `felhokarcolok`
GROUP by `felhasznalas`
ORDER BY 2
-- 18. feladat
SELECT `orszagkod`, ROUND(AVG(2022-`befejezes_eve`), 1) as 'atlag_kor'
FROM `felhokarcolok`
GROUP by `orszagkod`
ORDER BY `atlag_kor`
-- 19. feladat
SELECT `anyag`, COUNT(id) as `db`
FROM `felhokarcolok`
WHERE `befejezes_eve` >=1900 AND `befejezes_eve` < 2000 AND `anyag` IS NOT NULL
GROUP by `anyag`
-- 20. feladat
SELECT `varos`
FROM `felhokarcolok`
group by `varos`
ORDER BY avg(`magassag`) DESC
LIMIT 1
-- 21. feladat
SELECT `nev`, `magassag`, `emeletek`, (`magassag`*100)/`emeletek` as 'egy_emelet_cm'
FROM `felhokarcolok`
ORDER BY 4 desc
-- 22. feladat
SELECT `orszagkod`, `varos`, COUNT(id) as 'db', ROUND(AVG(`magassag`),1) as `atlag_magassag`
FROM `felhokarcolok`
GROUP BY `varos`
order BY `db` DESC, `atlag_magassag` ASC
-- 23. feladat
SELECT `varos`, Round(MAX(`magassag`)-MIN(`magassag`),1) AS 'kulonbseg'
FROM `felhokarcolok`
GROUP BY `varos`
ORDER BY 2 DESC