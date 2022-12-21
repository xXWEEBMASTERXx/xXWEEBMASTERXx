-- 3. feladat
SELECT * FROM `napfogyatkozas`
-- 4. feladat
SELECT DISTINCT `tipus` FROM `napfogyatkozas`
-- 5. feladat
SELECT * FROM `napfogyatkozas` WHERE `szelesseg` IS NULL;
-- 6. feladat
SELECT `datum`,`ido`,`tipus` FROM `napfogyatkozas` WHERE `megfigyelheto` LIKE 'Észak-Amerika';
-- 7. feladat
SELECT `datum`, `ido`, `megfigyelheto` FROM `napfogyatkozas` WHERE `tipus` = "Teljes" OR `tipus` = "Gyűrűs";
-- 8. feladat
SELECT `datum`, `ido` FROM `napfogyatkozas` WHERE (`tipus` = 'Teljes' OR `tipus` = "Gyűrűs") AND `megfigyelheto` = 'Afrika';
-- 9. feladat
SELECT `datum`, `ido`, `megfigyelheto` FROM `napfogyatkozas` WHERE `megfigyelheto` IN ("Dél-Amerika" OR "Észak és Közép-Amerika" OR "Dél-Amerika északnyugati oldala" OR "Kelet-Ázsia" OR "Észak-Amerika nyugati partja" OR "Dél-Afrika" OR "Észak-Amerika északnyugati partja" OR "Dél-Amerika déli része" OR "Északnyugat-Ázsia" OR "Észak és Dél-Amerika" OR "Nyugat-Ázsia" OR "Kelet-Ausztrália" OR "Észak-Amerika északkeleti része" OR "Délkelet-Ázsia" OR "Észak-Amerika északi része" OR "Indiai-óceán déli része");
-- 10. feladat
SELECT `datum`, `ido` FROM `napfogyatkozas` WHERE `tipus` = "Teljes" AND `megfigyelheto` LIKE '%Magyarországon%'; 
-- 11. feladat
SELECT DISTINCT `tipus` FROM `napfogyatkozas` 
-- 12. feladat
SELECT `datum`, `ido`, `idotartam` FROM `napfogyatkozas` WHERE `tipus` = 'Teljes' 
-- 13. feladat
SELECT * FROM `napfogyatkozas` WHERE `megfigyelheto` LIKE "%,%";
-- 14. feladat
SELECT * FROM `napfogyatkozas` WHERE (`megfigyelheto` LIKE "%Alaszka" OR `megfigyelheto` LIKE "%Hawaii") AND `tipus` = "Részleges"; 