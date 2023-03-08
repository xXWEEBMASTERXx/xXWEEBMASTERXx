-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2023. Már 08. 11:05
-- Kiszolgáló verziója: 10.4.24-MariaDB
-- PHP verzió: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `mozi`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `film`
--

CREATE TABLE `film` (
  `Azonosító` int(11) NOT NULL,
  `Cím` text COLLATE utf8_hungarian_ci NOT NULL,
  `Hossz` int(11) NOT NULL,
  `Hang` int(11) NOT NULL,
  `Felirat` text COLLATE utf8_hungarian_ci NOT NULL,
  `Év` date NOT NULL,
  `Korhatár` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `terem`
--

CREATE TABLE `terem` (
  `Név` int(11) NOT NULL,
  `Férőhely` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `vetítés`
--

CREATE TABLE `vetítés` (
  `VetítésKezdete` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_hungarian_ci;

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `film`
--
ALTER TABLE `film`
  ADD PRIMARY KEY (`Azonosító`);

--
-- A tábla indexei `terem`
--
ALTER TABLE `terem`
  ADD PRIMARY KEY (`Név`);

--
-- A tábla indexei `vetítés`
--
ALTER TABLE `vetítés`
  ADD PRIMARY KEY (`VetítésKezdete`);

--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `vetítés`
--
ALTER TABLE `vetítés`
  ADD CONSTRAINT `vetítés_ibfk_1` FOREIGN KEY (`VetítésKezdete`) REFERENCES `film` (`Azonosító`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
