-- 3. feladat
SELECT `fnev` AS 'futo', `szulev`
FROM `futok`
WHERE `ffi` = 0;
-- 4. feladat

-- 5. feladat
SELECT `futok`.`fnev` AS `futo`, `eredmenyek`.`ido`
FROM `futok` 
	LEFT JOIN `eredmenyek` ON `eredmenyek`.`futo` = `futok`.`fid`
LIMIT 10;
-- 6. feladat
SELECT `futok`.`csapat`, `eredmenyek`.`ido`
FROM `futok` 
	LEFT JOIN `eredmenyek` ON `eredmenyek`.`futo` = `futok`.`fid`
GROUP BY `futok`.`csapat`;
-- 7. feladat

-- 8. feladat

-- 9. feladat
