-- 3. feladat
SELECT DISTINCT `tipus`
FROM `hajo`;
-- 4. feladat
SELECT MIN(`dij`) AS 'Minimum'
FROM `hajo`;
-- 5. feladat
SELECT `nev`, `utas`, `dij`
FROM `hajo`
ORDER BY `utas` DESC
LIMIT 3;
-- 6. feladat
SELECT `tipus`, ROUND(AVG(`dij`), 2) AS 'Átlagos vitelidíj'
FROM `hajo`
GROUP BY `tipus`;
-- 7. feladat
SELECT `nev`, (`utas`*`dij`) AS 'Bevétel'
FROM `hajo`;
-- 8. feladat
SELECT `hajoazon`, COUNT(`azon`) AS 'Bérelt'
FROM `tura`
GROUP BY `hajoazon`;
-- 9. feladat

-- 10. feladat

-- 11. feladat

-- 12. feladat

-- 13. feladat

-- 14. feladat

-- 15. feladat

