-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Čtv 31. říj 2024, 15:28
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
-- Databáze: `knihovna_1`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `autori`
--

CREATE TABLE `autori` (
  `autor_id` int(11) NOT NULL,
  `jmeno` varchar(50) DEFAULT NULL,
  `prijmeni` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `autori`
--

INSERT INTO `autori` (`autor_id`, `jmeno`, `prijmeni`) VALUES
(1, 'Karel', 'Čapek'),
(2, 'Bohumil', 'Hrabal'),
(3, 'Franz', 'Kafka'),
(4, 'Milan', 'Kundera'),
(5, 'Václav', 'Havel'),
(6, 'Josef', 'Škvorecký'),
(7, 'Jaroslav', 'Hašek'),
(8, 'Jan', 'Neruda'),
(9, 'Romain', 'Rolland'),
(10, 'Ota', 'Filip');

-- --------------------------------------------------------

--
-- Struktura tabulky `knihy`
--

CREATE TABLE `knihy` (
  `kniha_id` int(11) NOT NULL,
  `nazev` varchar(100) DEFAULT NULL,
  `autor_id` int(11) DEFAULT NULL,
  `zanr_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `knihy`
--

INSERT INTO `knihy` (`kniha_id`, `nazev`, `autor_id`, `zanr_id`) VALUES
(1, 'R.U.R.', 1, 3),
(2, 'Příliš hlučná samota', 2, 1),
(3, 'Proces', 3, 1),
(4, 'Nesnesitelná lehkost bytí', 4, 1),
(5, 'Dějiny zločinu', 2, 5),
(6, 'Osudy dobrého vojáka Švejka', 7, 1),
(7, 'Povídky malostranské', 8, 1),
(8, 'Mistr a Markétka', 3, 4),
(9, 'Kafkovy povídky', 3, 1),
(10, 'Jak jsem se naučil žít', 4, 1);

-- --------------------------------------------------------

--
-- Struktura tabulky `zanry`
--

CREATE TABLE `zanry` (
  `zanr_id` int(11) NOT NULL,
  `nazev` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `zanry`
--

INSERT INTO `zanry` (`zanr_id`, `nazev`) VALUES
(1, 'Fikce'),
(2, 'Drama'),
(3, 'Sci-Fi'),
(4, 'Fantasy'),
(5, 'Detektivka'),
(6, 'Romantika'),
(7, 'Historie'),
(8, 'Klasika'),
(9, 'Horor'),
(10, 'Biografie');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `autori`
--
ALTER TABLE `autori`
  ADD PRIMARY KEY (`autor_id`);

--
-- Indexy pro tabulku `knihy`
--
ALTER TABLE `knihy`
  ADD PRIMARY KEY (`kniha_id`),
  ADD KEY `autor_id` (`autor_id`),
  ADD KEY `zanr_id` (`zanr_id`);

--
-- Indexy pro tabulku `zanry`
--
ALTER TABLE `zanry`
  ADD PRIMARY KEY (`zanr_id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `autori`
--
ALTER TABLE `autori`
  MODIFY `autor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `knihy`
--
ALTER TABLE `knihy`
  MODIFY `kniha_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `zanry`
--
ALTER TABLE `zanry`
  MODIFY `zanr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `knihy`
--
ALTER TABLE `knihy`
  ADD CONSTRAINT `knihy_ibfk_1` FOREIGN KEY (`autor_id`) REFERENCES `autori` (`autor_id`),
  ADD CONSTRAINT `knihy_ibfk_2` FOREIGN KEY (`zanr_id`) REFERENCES `zanry` (`zanr_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
