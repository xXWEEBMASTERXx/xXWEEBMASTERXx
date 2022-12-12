NÉV: Gyányi Dániel
1.feadat ------------
SELECT `nev`, `magassag`
FROM `jatekos`
ORDER BY `nev` ASC
2.feadat ------------
SELECT `jatekos`.`nev`, `jegyzokonyv`.`be`, `jegyzokonyv`.`ki`
FROM `jatekos`, `jegyzokonyv`
WHERE `jatekos`.`nev` = 'Víg péter'
GROUP BY `jatekos`.`nev`;
3.feadat ------------
SELECT SUM(`jegyzokonyv`.`bjo`) AS `Magas Viktor Góljai`
FROM `jegyzokonyv`
WHERE `jegyzokonyv`.`mez` = '10';
4.feadat ------------ a mintakép nem jó
SELECT `jatekos`.`nev`, SUM(`jegyzokonyv`.`bjo`) AS "Jó Dobás", SUM(`jegyzokonyv`.`bkis`) AS "kísérlet"
FROM `jegyzokonyv`, `jatekos`
GROUP BY `jegyzokonyv`.`mez`, `jatekos`.`mez`;
5.feadat ------------ 
SELECT DISTINCT `jatekos`.`nev`
FROM `jatekos`, `jegyzokonyv`
WHERE `jegyzokonyv`.`be` BETWEEN '00:35:00.000000' AND '00:40:00.000000';
6.feadat ------------ a mintakép nem jó
SELECT (SUM(`harom`)*3)+((SUM(`bjo`)-SUM(`harom`))*2) AS "szerzett pont"
FROM `jegyzokonyv`;
7.feadat ------------
SELECT `jatekos`.`nev`, (SUM(`jegyzokonyv`.`harom`)*3)+((SUM(`jegyzokonyv`.`bjo`)-SUM(`jegyzokonyv`.`harom`))*2) AS "Dobott Pontjai"
FROM `jatekos`, `jegyzokonyv`
GROUP BY `jegyzokonyv`.`mez`, `jatekos`.`nev`;
8.feadat ------------
SELECT `jatekos`.`nev` AS "Legtöbbet játszó játékos", MAX(`jegyzokonyv`.`ki`-`jegyzokonyv`.`be`) AS "Pályán Töltött Percek"
FROM `jatekos`, `jegyzokonyv`
LIMIT 1;
9.feadat ------------
SELECT AVG(SUM(`harom`)*3)+((SUM(`bjo`)-SUM(`harom`))*2) AS "pontátlag"
FROM `jegyzokonyv`;
10.feadat ------------
SELECT `jatekos`.`mez`, `jatekos`.`magassag`, `jatekos`.`magassag`, `jatekos`.`poszt`, `jegyzokonyv`.`be`, `jegyzokonyv`.`ki`, `jegyzokonyv`.`bkis`, `jegyzokonyv`.`bjo`, `jegyzokonyv`.`harom`
FROM `jatekos`, `jegyzokonyv`  
ORDER BY `jatekos`.`mez` ASC;