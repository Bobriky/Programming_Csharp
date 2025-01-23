-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 18:29
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
-- Databáze: `aktivity_hasilik`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `aktivity`
--

CREATE TABLE `aktivity` (
  `aktivita_id` int(11) NOT NULL,
  `název` varchar(255) NOT NULL,
  `popis` text NOT NULL,
  `datum_a_cas` datetime(6) NOT NULL,
  `instruktor_id` int(11) NOT NULL,
  `kapacita` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `aktivity`
--

INSERT INTO `aktivity` (`aktivita_id`, `název`, `popis`, `datum_a_cas`, `instruktor_id`, `kapacita`) VALUES
(1, 'Fotbal', 'Základy a začátky ve fotbale.', '2024-10-31 10:00:00.000000', 1, 10),
(2, 'Volejbal', 'Potřebný úvod do volejbalu.', '2024-11-08 16:00:00.000000', 2, 5),
(3, 'Futsal', 'Úvod do futsalu.', '2024-12-02 17:00:00.000000', 3, 10);

-- --------------------------------------------------------

--
-- Struktura tabulky `instruktoři`
--

CREATE TABLE `instruktoři` (
  `instruktor_id` int(11) NOT NULL,
  `jméno` varchar(255) NOT NULL,
  `příjmení` varchar(255) NOT NULL,
  `specializace` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `instruktoři`
--

INSERT INTO `instruktoři` (`instruktor_id`, `jméno`, `příjmení`, `specializace`, `email`) VALUES
(0, 'Josef\r\nPetr', 'Novák\r\nHvízdal', 'fotbal\r\nvolejbal', 'novakj@seznam.cz\r\nhvizdalp@seznam.cz'),
(0, 'Adam', 'Kozák', 'futsal', 'kozaka@seznam.cz');

-- --------------------------------------------------------

--
-- Struktura tabulky `rezervace`
--

CREATE TABLE `rezervace` (
  `rezervace_id` int(11) NOT NULL,
  `aktivita_id` int(11) NOT NULL,
  `uzivatel_id` int(11) NOT NULL,
  `datum_rezervace` date NOT NULL,
  `stav` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

-- --------------------------------------------------------

--
-- Struktura tabulky `uživatelé`
--

CREATE TABLE `uživatelé` (
  `uzivatel_id` int(11) NOT NULL,
  `jméno` varchar(255) NOT NULL,
  `příjmení` int(11) NOT NULL,
  `datum_narození` date NOT NULL,
  `email` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
