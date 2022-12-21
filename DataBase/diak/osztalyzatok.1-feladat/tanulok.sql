
CREATE DATABASE IF NOT EXISTS `tanulok`
DEFAULT CHARACTER SET utf8
COLLATE utf8_hungarian_ci;

USE `tanulok`;

DROP TABLE IF EXISTS `jegy`;
CREATE TABLE `jegy` (
  `id` int(11) NOT NULL,
  `nev` varchar(25) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `osztaly` varchar(5) COLLATE utf8_hungarian_ci DEFAULT NULL,
  `matematika` int(11) NOT NULL,
  `angol` int(11) NOT NULL,
  `prog_elm` int(11) NOT NULL,
  `prog_gyak` int(11) NOT NULL,
  `tortenelem` int(11) NOT NULL,
  `fizika` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

INSERT INTO `jegy` (`id`, `nev`, `osztaly`, `matematika`, `angol`, `prog_elm`, `prog_gyak`, `tortenelem`, `fizika`) VALUES
(1, 'Nagy Emese', '9c', 3, 5, 1, 2, 4, 4),
(2, 'Tóth Csaba', '9d', 1, 4, 2, 1, 3, 1),
(3, 'Kiss Zoltán', '9a', 2, 2, 2, 4, 4, 1),
(4, 'Kővári Ágnes', '9b', 3, 2, 4, 1, 2, 5),
(5, 'Szolnoki János', '10a', 2, 3, 4, 3, 1, 5),
(6, 'Kovács Andrea', '9a', 2, 3, 5, 2, 3, 4),
(7, 'Molnár Ábrahám', '9d', 1, 3, 2, 5, 5, 1),
(8, 'Szűcs Edina', '9c', 4, 4, 3, 1, 5, 3),
(9, 'Balogh Zoltán', '9a', 3, 5, 4, 5, 2, 3),
(10, 'Váradi Mária', '9c', 2, 5, 5, 5, 3, 4);

ALTER TABLE `jegy`
  ADD PRIMARY KEY (`id`),
  ADD KEY `matematika_index` (`matematika`),
  ADD KEY `angol_index` (`angol`),
  ADD KEY `prog_elm_index` (`prog_elm`),
  ADD KEY `prog_gyak_index` (`prog_gyak`),
  ADD KEY `tortenelem_index` (`tortenelem`),
  ADD KEY `fizika_index` (`fizika`);

ALTER TABLE `jegy`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;