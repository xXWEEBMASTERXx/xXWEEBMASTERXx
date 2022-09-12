-- 3. feladat
SELECT * FROM `tanulok`
-- 4. feladat
SELECT `vnev`, `knev` FROM `tanulok`
-- 5. feladat
SELECT * FROM `tanulok` WHERE `nem` = 'N'
-- 6. feladat
SELECT `vnev`, `knev` FROM `tanulok` ORDER BY `vnev` ASC
-- 7. feladat
SELECT `vnev`, `knev`, `magassag` FROM `tanulok` WHERE `nem` = 'F'
-- 8. feladat
SELECT `vnev`, `knev`, `szul_hely`, `szul_ido` FROM `tanulok` WHERE `szul_hely` = 'Miskolc'
-- 9. feladat
SELECT * FROM `tanulok` WHERE `nagycsalados` = 1
-- 10. feladat
SELECT `vnev`, `knev`, `magassag` FROM `tanulok` WHERE `magassag` < 180
-- 11. feladat
SELECT * FROM `tanulok` WHERE `magassag` >= 185
-- 12. feladat
SELECT * FROM `tanulok` WHERE `magassag` < 185
-- 13. feladat
SELECT `vnev`, `knev` FROM `tanulok` WHERE `magassag` = 182
-- 14. feladat
SELECT * FROM `tanulok` ORDER BY `atlag` DESC
-- 15. feladat
SELECT `vnev`, `knev`, `szul_ido` FROM `tanulok` WHERE `nem` = 'F' ORDER BY `szul_ido` DESC
-- 16. feladat
SELECT `vnev`, `knev`, `szul_ido` FROM `tanulok` WHERE `nem` = 'F' AND `szul_hely` = 'Budapest' ORDER BY `szul_ido` DESC
-- 17. feladat
SELECT * FROM `tanulok` WHERE `nem` = 'N' AND `magassag` BETWEEN 160 AND 170 AND `nagycsalados` = 1 ORDER BY `szul_ido` DESC;
-- 18. feladat
SELECT * FROM `tanulok` WHERE `nem` = 'N' AND `szul_hely` = 'Miskolc' AND `magassag` >= 185