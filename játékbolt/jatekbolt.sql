CREATE DATABASE IF NOT EXISTS `játékbolt` DEFAULT CHARACTER SET utf8 COLLATE utf8_hungarian_ci;
USE `játékbolt`;

DROP TABLE IF EXISTS `jatekok`;
CREATE TABLE IF NOT EXISTS `jatekok` (
  `cikkszam` varchar(13) NOT NULL,
  `nev` varchar(64) DEFAULT NULL,
  `ar` int(5) DEFAULT NULL,
  `kor_min` int(2) DEFAULT NULL,
  `kor_max` int(11) DEFAULT NULL,
  `jatekosok_min` int(1) DEFAULT NULL,
  `jatekosok_max` int(2) DEFAULT NULL,
  `nyelv` varchar(7) DEFAULT NULL,
  `kategoriak` varchar(49) DEFAULT NULL,
  `kiado` varchar(19) DEFAULT NULL,
  `weboldal` varchar(29) DEFAULT NULL,
  PRIMARY KEY (`cikkszam`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `jatekok` (`cikkszam`, `nev`, `ar`, `kor_min`, `kor_max`, `jatekosok_min`, `jatekosok_max`, `nyelv`, `kategoriak`, `kiado`, `weboldal`) VALUES
('DB105', 'Harry Potter: Roxforti csata társasjáték', 19990, 11, NULL, 2, 4, 'magyar', 'deck-buildig, kooperatív, kártyajáték, kiegészítő', 'The Op', 'https://theop.games'),
('GDR44', 'Uno Flip kártyajáték', 2790, 7, NULL, 2, 10, 'magyar', 'kártyajáték,kompetitív, kártyajáték', 'Mattel Inc.', 'https://mattel.com'),
('GWDES', 'A Tiltott Sivatag társasjáték', 8490, 10, NULL, 2, 5, 'magyar', 'kooperatív, táblajáték', 'Gamewright', 'https://gamewright.com'),
('HPHOGW', 'Harry Potter Hogwarts Battle Monster box angol nyelvű kiegészítő', 10490, 11, NULL, 2, 4, 'magyar', 'deck-buildig, kooperatív, kártyajáték', 'The Op', 'https://theop.games'),
('WM00396-ML1-6', 'Rick and Morty 1000 db puzzle', 5490, 3, 100, 1, 6, 'francia', 'puzzle', 'Winning Moves Games', 'https://www.winning-moves.com');
COMMIT;