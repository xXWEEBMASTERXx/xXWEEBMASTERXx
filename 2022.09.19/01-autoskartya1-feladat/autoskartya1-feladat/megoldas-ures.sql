-- 3. feladat
SELECT *  FROM `autoskartya`
-- 4. feladat
SELECT `gyartmany`,`tipus`,`vegsebesseg`,`gyorsulas` FROM `autoskartya` WHERE (`vegsebesseg` >= 220 AND `gyorsulas` <= 6.5) AND (`tipus` LIKE '%Sport%' OR `tipus` LIKE '%GT%' OR `tipus` LIKE '%RS%');
-- 5. feladat
SELECT `gyartmany`,`tipus` FROM `autoskartya` WHERE (`vegsebesseg` > 240 OR `loero` >= 200) AND (`orszag` = 'Németország');
-- 6. feladat
SELECT * FROM `autoskartya` WHERE (`orszag`= 'Japán' AND `fogyasztas` <= 6) OR (`hengerurtartalom` <= 1400 AND `fogyasztas` <= 7);
-- 7. feladat
SELECT `gyartmany`, `tipus`, `gyartasi_ev` FROM `autoskartya` WHERE `kilowatt` >= 150 and `gyartmany` IN ('Bentley', 'BMW', 'Mercedes', 'Volvo') ORDER BY `autoskartya`.`gyartasi_ev` DESC;
-- 8. feladat
SELECT DISTINCT `gyartmany` FROM `autoskartya` ORDER BY `gyartmany` ASC;
-- 9. feladat

-- 10. feladat

-- 11. feladat