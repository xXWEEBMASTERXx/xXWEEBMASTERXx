-- 2. feladat
CREATE DATABASE `allatmenhely`
CHARACTER SET utf8
COLLATE utf8_hungarian_ci;
-- 3. feladat
CREATE TABLE `allatmenhely`.`menhelyek` (`id` INT NOT NULL AUTO_INCREMENT , `nev` TEXT NOT NULL , `cim` TEXT NOT NULL , `web` TEXT NOT NULL , `adoszam` CHAR(13) NOT NULL , `bankszamlaszam` CHAR(26) NOT NULL , PRIMARY KEY (`id`))  
-- 4. feladat
CREATE TABLE `allatmenhely`.`allatok` (`id` INT NOT NULL AUTO_INCREMENT , `nev` TEXT NOT NULL , `kor` INT NOT NULL , `tipus` TEXT NOT NULL , `fajta` TEXT NOT NULL , `ivartalanitott` BOOLEAN NOT NULL , `nem` TEXT NOT NULL , `behozva` DATE NOT NULL , `menhely_id` INT NOT NULL , PRIMARY KEY (`id`))
-- 5. feladat

-- 6. feladat

-- 7. feladat

-- 8. feladat

-- 9. feladat

-- 10. feladat

-- 11. feladat

-- 12. feladat

-- 13. feladat

-- 14. feladat

-- 15. feladat

-- 16. feladat

-- 17. feladat

-- 18. feladat
