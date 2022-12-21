-- 3. feladat
SELECT *
FROM `jegy`;
-- 4. feladat
SELECT `matematika`,`angol`
FROM `jegy`
WHERE `nev` = "Tóth Csaba";
-- 5. feladat
SELECT `nev`,`osztaly`,`matematika`,`angol`,`prog_elm`,`prog_gyak`,`tortenelem`,`fizika`
FROM `jegy`
WHERE `osztaly` = "9a";
-- 6. feladat
SELECT ((SUM(`matematika`)+SUM(`angol`)+SUM(`prog_elm`)+SUM(`prog_gyak`)+SUM(`tortenelem`)+SUM(`fizika`))/ 6) AS "átlag"
FROM `jegy`
WHERE `nev` = "Kovács Andrea";
-- 7. feladat
SELECT COUNT(`osztaly`) AS "db"
FROM `jegy`
WHERE `osztaly` Like "%9%";
-- 8. feladat
SELECT COUNT(`osztaly`) AS "db"
FROM `jegy`
WHERE `osztaly` Like "%a%";
-- 9. feladat

-- 10. feladat

-- 11. feladat

-- 12. feladat