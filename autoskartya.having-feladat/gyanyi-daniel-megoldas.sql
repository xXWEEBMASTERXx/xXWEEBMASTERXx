-- 3. feladat
SELECT gyartasi_ev, orszag, COUNT(id) as db
FROM `autoskartya`
GROUP BY orszag
ORDER BY gyartasi_ev ASC, orszag ASC;
-- 4. feladat
SELECT gyartmany, concat(round(AVG(kilowatt), 2), " kw") as `atlagos_teljesitmeny`
FROM `autoskartya`
GROUP BY gyartmany
ORDER BY `atlagos_teljesitmeny`;
-- 5. feladat
SELECT gyartmany, max(`gyorsulas`)
FROM `autoskartya`
GROUP BY gyartmany
ORDER BY gyorsulas;
-- 6. feladat
SELECT gyartmany, tipus, MIN(gyorsulas) as gyorsulas
FROM `autoskartya`
WHERE gyartmany = "Opel" OR gyartmany = "Volvo" OR gyartmany = "Fiat"
GROUP BY gyartmany
ORDER BY gyorsulas
LIMIT 1;
-- 7. feladat
SELECT gyartmany, MAX(hengerurtartalom)
FROM `autoskartya`
GROUP BY gyartmany
ORDER BY hengerurtartalom DESC;
-- 8. feladat
SELECT gyartasi_ev, gyartmany, ROUND(AVG(fogyasztas), 2) AS `atlag`
FROM `autoskartya`
GROUP BY gyartasi_ev, gyartmany
ORDER BY gyartmany ASC, gyartasi_ev DESC;
-- 9. feladat
SELECT `gyartmany`, SUM(`loero`) AS 'ossz_loero'
FROM `autoskartya`
GROUP BY `gyartmany`
HAVING `ossz_loero` >= 300  
ORDER BY `ossz_loero` DESC;
-- 10. feladat
SELECT `gyartmany`, COUNT(`id`) AS 'db'
FROM `autoskartya`
GROUP BY `gyartmany`
HAVING `db` >= 2
ORDER BY `gyartmany` DESC;
-- 11. feladat
SELECT `gyartasi_ev`, `orszag`
FROM `autoskartya`
GROUP BY `gyartasi_ev`
HAVING COUNT(`tipus`) > 1  
ORDER BY `gyartasi_ev` ASC;
-- 12. feladat
SELECT `gyartmany`
FROM `autoskartya`
WHERE `orszagkod` = "D" OR `orszagkod` = "S"
GROUP BY `gyartmany`
HAVING COUNT(`id`) >= 2
ORDER BY `gyartmany` DESC;
-- 13. feladat

-- 14. feladat

-- 15. feladat

-- 16. feladat

-- 17. feladat

-- 18. feladat
