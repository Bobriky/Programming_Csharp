-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Čtv 31. říj 2024, 15:23
-- Verze serveru: 10.4.28-MariaDB
-- Verze PHP: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `knihkupectvi`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `ctenari`
--

CREATE TABLE `ctenari` (
  `id_ctenar` int(11) NOT NULL,
  `jmeno` varchar(100) DEFAULT NULL,
  `prijmeni` varchar(100) DEFAULT NULL,
  `email` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `ctenari`
--

INSERT INTO `ctenari` (`id_ctenar`, `jmeno`, `prijmeni`, `email`) VALUES
(1, 'Jan', 'Novák', 'jan.novak@example.com'),
(2, 'Petr', 'Svoboda', 'petr.svoboda@example.com'),
(3, 'Marie', 'Dvořáková', 'marie.dvorakova@example.com'),
(4, 'Eva', 'Kučerová', 'eva.kucerova@example.com'),
(5, 'Tomáš', 'Klein', 'tomas.klein@example.com'),
(6, 'Jana', 'Havlíčková', 'jana.havlickova@example.com'),
(7, 'David', 'Horák', 'david.horak@example.com'),
(8, 'Anna', 'Cikánová', 'anna.cikanova@example.com'),
(9, 'Martin', 'Zelený', 'martin.zeleny@example.com'),
(10, 'Lucie', 'Králová', 'lucie.kralova@example.com');

-- --------------------------------------------------------

--
-- Struktura tabulky `knihy`
--

CREATE TABLE `knihy` (
  `id_kniha` int(11) NOT NULL,
  `nazev` varchar(255) DEFAULT NULL,
  `autor` varchar(255) DEFAULT NULL,
  `rok_vydani` year(4) DEFAULT NULL,
  `zanr` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `knihy`
--

INSERT INTO `knihy` (`id_kniha`, `nazev`, `autor`, `rok_vydani`, `zanr`) VALUES
(1, '1984', 'George Orwell', '1949', 'Dystopie'),
(2, 'Pýcha a předsudek', 'Jane Austen', '0000', 'Román'),
(3, 'Moby Dick', 'Herman Melville', '0000', 'Dobrodružný'),
(4, 'Hamlet', 'William Shakespeare', '0000', 'Drama'),
(5, 'Kronika města Třebíče', 'J. K. T.', '2000', 'Historie'),
(6, 'Fahrenheit 451', 'Ray Bradbury', '1953', 'Dystopie'),
(7, 'Bídníci', 'Victor Hugo', '0000', 'Román'),
(8, 'Válka světů', 'H.G. Wells', '0000', 'Sci-fi'),
(9, 'Zločin a trest', 'Fjodor Dostojevskij', '0000', 'Psychologický román'),
(10, 'Malý princ', 'Antoine de Saint-Exupéry', '1943', 'Pohádka');

-- --------------------------------------------------------

--
-- Struktura tabulky `vypujcky`
--

CREATE TABLE `vypujcky` (
  `id_vypujcka` int(11) NOT NULL,
  `id_kniha` int(11) DEFAULT NULL,
  `id_ctenar` int(11) DEFAULT NULL,
  `datum_vypujcky` date DEFAULT NULL,
  `datum_vraceni` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `vypujcky`
--

INSERT INTO `vypujcky` (`id_vypujcka`, `id_kniha`, `id_ctenar`, `datum_vypujcky`, `datum_vraceni`) VALUES
(1, 1, 1, '2024-01-10', '2024-01-20'),
(2, 2, 2, '2024-01-15', '2024-01-25'),
(3, 3, 3, '2024-02-01', NULL),
(4, 4, 4, '2024-02-05', '2024-02-15'),
(5, 5, 5, '2024-03-01', NULL),
(6, 6, 6, '2024-03-10', NULL),
(7, 7, 7, '2024-03-15', '2024-03-25'),
(8, 8, 8, '2024-04-01', '2024-04-10'),
(9, 9, 9, '2024-04-05', NULL),
(10, 10, 10, '2024-04-15', '2024-04-20');

-- --------------------------------------------------------

--
-- Struktura tabulky `zanry`
--

CREATE TABLE `zanry` (
  `id_zanr` int(11) NOT NULL,
  `nazev_zanru` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `zanry`
--

INSERT INTO `zanry` (`id_zanr`, `nazev_zanru`) VALUES
(1, 'Dystopie'),
(2, 'Román'),
(3, 'Dobrodružný'),
(4, 'Drama'),
(5, 'Historie'),
(6, 'Sci-fi'),
(7, 'Psychologický román'),
(8, 'Pohádka'),
(9, 'Thriller'),
(10, 'Fantasy');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `ctenari`
--
ALTER TABLE `ctenari`
  ADD PRIMARY KEY (`id_ctenar`);

--
-- Indexy pro tabulku `knihy`
--
ALTER TABLE `knihy`
  ADD PRIMARY KEY (`id_kniha`);

--
-- Indexy pro tabulku `vypujcky`
--
ALTER TABLE `vypujcky`
  ADD PRIMARY KEY (`id_vypujcka`),
  ADD KEY `id_kniha` (`id_kniha`),
  ADD KEY `id_ctenar` (`id_ctenar`);

--
-- Indexy pro tabulku `zanry`
--
ALTER TABLE `zanry`
  ADD PRIMARY KEY (`id_zanr`);

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `vypujcky`
--
ALTER TABLE `vypujcky`
  ADD CONSTRAINT `vypujcky_ibfk_1` FOREIGN KEY (`id_kniha`) REFERENCES `knihy` (`id_kniha`),
  ADD CONSTRAINT `vypujcky_ibfk_2` FOREIGN KEY (`id_ctenar`) REFERENCES `ctenari` (`id_ctenar`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
