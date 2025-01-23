-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Pon 28. říj 2024, 19:40
-- Verze serveru: 10.4.32-MariaDB
-- Verze PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `czyz_tomas`
--
CREATE DATABASE IF NOT EXISTS `czyz_tomas` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `czyz_tomas`;

-- --------------------------------------------------------

--
-- Struktura tabulky `motorky`
--

CREATE TABLE `motorky` (
  `ID` int(4) NOT NULL,
  `Značka` varchar(50) NOT NULL,
  `Objem Motoru` int(4) NOT NULL,
  `Typ` varchar(50) NOT NULL,
  `Řidičské Oprávnění` varchar(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `motorky`
--

INSERT INTO `motorky` (`ID`, `Značka`, `Objem Motoru`, `Typ`, `Řidičské Oprávnění`) VALUES
(1, 'HONDA', 50, 'závodní', 'AM'),
(2, 'SUZUKI', 125, 'okruhová', 'A1'),
(3, 'YAMAHA', 250, 'cruiser', 'A2'),
(4, 'BMW', 300, 'chopper', 'A2'),
(5, 'DUCATI', 350, 'bobber', 'A2'),
(6, 'APRILIA', 450, 'naháč', 'A2'),
(7, 'TRIUMPH', 500, 'cestovní ', 'A2'),
(8, 'BENELLI', 650, 'endura', 'A2'),
(9, 'KTM', 660, 'scramblery', 'A2'),
(10, 'CFMOTO', 750, 'skutr', 'A'),
(11, 'JAWA', 800, 'moped', 'A'),
(12, 'HARLEJ', 850, 'závodní', 'A'),
(13, 'KAWASAKI', 900, 'okruhová', 'A'),
(14, 'HONDA', 1000, 'cruiser', 'A'),
(15, 'SUZUKI', 1100, 'chopper', 'A'),
(16, 'YAMAHA', 1200, 'bobber', 'A'),
(17, 'BMW', 1250, 'naháč', 'A');

-- --------------------------------------------------------

--
-- Struktura tabulky `objem`
--

CREATE TABLE `objem` (
  `Objem` int(4) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `objem`
--

INSERT INTO `objem` (`Objem`) VALUES
(50),
(125),
(250),
(300),
(350),
(450),
(500),
(650),
(660),
(750),
(800),
(850),
(900),
(1000),
(1100),
(1200),
(1250);

-- --------------------------------------------------------

--
-- Struktura tabulky `typ`
--

CREATE TABLE `typ` (
  `typ` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `typ`
--

INSERT INTO `typ` (`typ`) VALUES
('bobber'),
('cestovní '),
('chopper'),
('cruiser'),
('endura'),
('moped'),
('naháč'),
('okruhová'),
('scramblery'),
('skutr'),
('závodní');

-- --------------------------------------------------------

--
-- Struktura tabulky `znacky`
--

CREATE TABLE `znacky` (
  `Značka` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `znacky`
--

INSERT INTO `znacky` (`Značka`) VALUES
('APRILIA'),
('BENELLI'),
('BMW'),
('CFMOTO'),
('DUCATI'),
('HARLEJ'),
('HONDA'),
('JAWA'),
('KAWASAKI'),
('KTM'),
('SUZUKI'),
('TRIUMPH'),
('YAMAHA');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `motorky`
--
ALTER TABLE `motorky`
  ADD PRIMARY KEY (`ID`),
  ADD UNIQUE KEY `Značka` (`Značka`,`Objem Motoru`,`Typ`),
  ADD KEY `Typ` (`Typ`),
  ADD KEY `Objem Motoru` (`Objem Motoru`);

--
-- Indexy pro tabulku `objem`
--
ALTER TABLE `objem`
  ADD PRIMARY KEY (`Objem`);

--
-- Indexy pro tabulku `typ`
--
ALTER TABLE `typ`
  ADD PRIMARY KEY (`typ`);

--
-- Indexy pro tabulku `znacky`
--
ALTER TABLE `znacky`
  ADD PRIMARY KEY (`Značka`);

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `motorky`
--
ALTER TABLE `motorky`
  ADD CONSTRAINT `motorky_ibfk_1` FOREIGN KEY (`Typ`) REFERENCES `typ` (`typ`),
  ADD CONSTRAINT `motorky_ibfk_2` FOREIGN KEY (`Značka`) REFERENCES `znacky` (`Značka`),
  ADD CONSTRAINT `motorky_ibfk_3` FOREIGN KEY (`Objem Motoru`) REFERENCES `objem` (`Objem`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
