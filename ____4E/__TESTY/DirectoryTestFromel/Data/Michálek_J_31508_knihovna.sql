-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Čtv 31. říj 2024, 15:12
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
-- Databáze: `knihovna`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `autor`
--

CREATE TABLE `autor` (
  `autor_id` int(11) NOT NULL,
  `jmeno` varchar(255) NOT NULL,
  `narodnost` varchar(100) DEFAULT NULL,
  `datum_narozeni` date DEFAULT NULL,
  `datum_umrti` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `autor`
--

INSERT INTO `autor` (`autor_id`, `jmeno`, `narodnost`, `datum_narozeni`, `datum_umrti`) VALUES
(1, 'Karel Čapek', 'Česká', '1890-01-09', '1938-12-25'),
(2, 'Franz Kafka', 'Česká', '1883-07-03', '1924-06-03'),
(3, 'Gabriel Garcia Marquez', 'Kolumbijská', '1927-03-06', '2014-04-17'),
(4, 'Haruki Murakami', 'Japonská', '1949-01-12', NULL),
(5, 'J.K. Rowling', 'Britská', '1965-07-31', NULL),
(6, 'George Orwell', 'Britská', '1903-06-25', '1950-01-21'),
(7, 'Jane Austen', 'Britská', '1775-12-16', '1817-07-18'),
(8, 'Mark Twain', 'Americká', '1835-11-30', '1910-04-21'),
(9, 'Leo Tolstoy', 'Ruská', '1828-09-09', '1910-11-20'),
(10, 'Hermann Hesse', 'Německá', '1877-07-02', '1962-08-09');

-- --------------------------------------------------------

--
-- Struktura tabulky `knihy`
--

CREATE TABLE `knihy` (
  `kniha_id` int(11) NOT NULL,
  `nazev` varchar(255) NOT NULL,
  `isbn` varchar(13) NOT NULL,
  `autor_id` int(11) DEFAULT NULL,
  `zanr_id` int(11) DEFAULT NULL,
  `vydavatel_id` int(11) DEFAULT NULL,
  `rok_vydani` year(4) DEFAULT NULL,
  `pocet_stran` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `knihy`
--

INSERT INTO `knihy` (`kniha_id`, `nazev`, `isbn`, `autor_id`, `zanr_id`, `vydavatel_id`, `rok_vydani`, `pocet_stran`) VALUES
(1, 'R.U.R.', '1234567890123', 1, 1, 1, '1920', 120),
(2, 'Proměna', '1234567890124', 2, 6, 2, '1915', 90),
(3, 'Sto roků samoty', '1234567890125', 3, 5, 3, '1967', 417),
(4, 'Norské dřevo', '1234567890126', 4, 5, 4, '1987', 296),
(5, 'Harry Potter a Kámen mudrců', '1234567890127', 5, 2, 5, '1997', 223),
(6, '1984', '1234567890128', 6, 5, 6, '1949', 328),
(7, 'Pýcha a předsudek', '1234567890129', 7, 5, 7, '0000', 279),
(8, 'Dobrodružství Toma Sawyera', '1234567890130', 8, 9, 8, '0000', 275),
(9, 'Vojna a mír', '1234567890131', 9, 7, 9, '0000', 1225),
(10, 'Siddhárta', '1234567890132', 10, 5, 10, '1922', 152);

-- --------------------------------------------------------

--
-- Struktura tabulky `vydavatel`
--

CREATE TABLE `vydavatel` (
  `vydavatel_id` int(11) NOT NULL,
  `nazev` varchar(255) NOT NULL,
  `sidliste` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `vydavatel`
--

INSERT INTO `vydavatel` (`vydavatel_id`, `nazev`, `sidliste`) VALUES
(1, 'Albatros', 'Praha'),
(2, 'Paseka', 'Praha'),
(3, 'Odeon', 'Praha'),
(4, 'Penguin Books', 'Londýn'),
(5, 'Vintage', 'New York'),
(6, 'Crown Publishing', 'New York'),
(7, 'Grada', 'Praha'),
(8, 'Host', 'Brno'),
(9, 'BB art', 'Praha'),
(10, 'Little, Brown and Company', 'Boston');

-- --------------------------------------------------------

--
-- Struktura tabulky `zanr`
--

CREATE TABLE `zanr` (
  `zanr_id` int(11) NOT NULL,
  `nazev` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `zanr`
--

INSERT INTO `zanr` (`zanr_id`, `nazev`) VALUES
(1, 'Sci-fi'),
(2, 'Fantasy'),
(3, 'Klasická literatura'),
(4, 'Detektivka'),
(5, 'Román'),
(6, 'Drama'),
(7, 'Historický román'),
(8, 'Horor'),
(9, 'Dobrodružství'),
(10, 'Poezie');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`autor_id`);

--
-- Indexy pro tabulku `knihy`
--
ALTER TABLE `knihy`
  ADD PRIMARY KEY (`kniha_id`),
  ADD UNIQUE KEY `isbn` (`isbn`),
  ADD KEY `autor_id` (`autor_id`),
  ADD KEY `zanr_id` (`zanr_id`),
  ADD KEY `vydavatel_id` (`vydavatel_id`);

--
-- Indexy pro tabulku `vydavatel`
--
ALTER TABLE `vydavatel`
  ADD PRIMARY KEY (`vydavatel_id`);

--
-- Indexy pro tabulku `zanr`
--
ALTER TABLE `zanr`
  ADD PRIMARY KEY (`zanr_id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `autor`
--
ALTER TABLE `autor`
  MODIFY `autor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `knihy`
--
ALTER TABLE `knihy`
  MODIFY `kniha_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `vydavatel`
--
ALTER TABLE `vydavatel`
  MODIFY `vydavatel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `zanr`
--
ALTER TABLE `zanr`
  MODIFY `zanr_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `knihy`
--
ALTER TABLE `knihy`
  ADD CONSTRAINT `knihy_ibfk_1` FOREIGN KEY (`autor_id`) REFERENCES `autor` (`autor_id`),
  ADD CONSTRAINT `knihy_ibfk_2` FOREIGN KEY (`zanr_id`) REFERENCES `zanr` (`zanr_id`),
  ADD CONSTRAINT `knihy_ibfk_3` FOREIGN KEY (`vydavatel_id`) REFERENCES `vydavatel` (`vydavatel_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
