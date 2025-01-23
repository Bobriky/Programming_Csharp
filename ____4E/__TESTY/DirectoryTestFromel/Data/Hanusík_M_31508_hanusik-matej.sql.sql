-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 20:02
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
-- Databáze: `skola`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `predmety`
--

CREATE TABLE `predmety` (
  `idPredmet` int(11) NOT NULL,
  `nazevP` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `predmety`
--

INSERT INTO `predmety` (`idPredmet`, `nazevP`) VALUES
(0, 'český Jazyk\r\nmatematika\r\ndějepis\r\ntělesná Výchova\r\nmikroprocesorová Technika\r\nelektronika\r');

-- --------------------------------------------------------

--
-- Struktura tabulky `studenti`
--

CREATE TABLE `studenti` (
  `idStudent` int(11) NOT NULL,
  `jmeno` varchar(40) NOT NULL,
  `prijmeni` int(40) NOT NULL,
  `datumNarozeni` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

-- --------------------------------------------------------

--
-- Struktura tabulky `ucitele`
--

CREATE TABLE `ucitele` (
  `idUcitele` int(11) NOT NULL,
  `jmeno` varchar(50) NOT NULL,
  `prijmeni` varchar(50) NOT NULL,
  `predmet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

-- --------------------------------------------------------

--
-- Struktura tabulky `znamky`
--

CREATE TABLE `znamky` (
  `idZnamka` int(11) NOT NULL,
  `znamka` int(11) NOT NULL,
  `idStudent` int(11) NOT NULL,
  `idPredmet` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `predmety`
--
ALTER TABLE `predmety`
  ADD PRIMARY KEY (`idPredmet`);

--
-- Indexy pro tabulku `studenti`
--
ALTER TABLE `studenti`
  ADD PRIMARY KEY (`idStudent`);

--
-- Indexy pro tabulku `ucitele`
--
ALTER TABLE `ucitele`
  ADD PRIMARY KEY (`idUcitele`);

--
-- Indexy pro tabulku `znamky`
--
ALTER TABLE `znamky`
  ADD PRIMARY KEY (`idZnamka`),
  ADD UNIQUE KEY `idStudent` (`idStudent`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
