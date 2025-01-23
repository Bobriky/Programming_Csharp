-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Ned 27. říj 2024, 12:26
-- Verze serveru: 10.4.32-MariaDB
-- Verze PHP: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `memecoindb`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `memecoiny`
--

CREATE TABLE `memecoiny` (
  `memecoin_id` int(11) NOT NULL,
  `nazev` varchar(50) NOT NULL,
  `symbol` varchar(10) NOT NULL,
  `max_zasoba` bigint(20) DEFAULT NULL,
  `aktualni_cena` decimal(18,8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `memecoiny`
--

INSERT INTO `memecoiny` (`memecoin_id`, `nazev`, `symbol`, `max_zasoba`, `aktualni_cena`) VALUES
(1, 'Ponke', 'PNK', 1000000000, 0.00250000),
(2, 'Bobo', 'BOB', 500000000, 0.00075000),
(3, 'Brett', 'BRT', 250000000, 0.00120000),
(4, 'Tremp', 'TRP', 100000000, 0.00500000),
(5, 'Fwog', 'FWG', 750000000, 0.00030000),
(6, 'MAGA', 'MGA', 1000000000, 0.00400000),
(7, 'Dogecoin', 'DOGE', 129000000000, 0.06500000),
(8, 'Shiba Inu', 'SHIB', 1000000000000000, 0.00001000),
(9, 'Floki Inu', 'FLOKI', 100000000000, 0.00040000),
(10, 'Baby Doge', 'BABYDOGE', 420000000000000, 0.00000090);

-- --------------------------------------------------------

--
-- Struktura tabulky `penezenky`
--

CREATE TABLE `penezenky` (
  `penezenka_id` int(11) NOT NULL,
  `uzivatel_id` int(11) DEFAULT NULL,
  `memecoin_id` int(11) DEFAULT NULL,
  `zustatek` decimal(18,8) DEFAULT 0.00000000
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `penezenky`
--

INSERT INTO `penezenky` (`penezenka_id`, `uzivatel_id`, `memecoin_id`, `zustatek`) VALUES
(1, 1, 1, 5000.00000000),
(2, 1, 2, 1000000.00000000),
(3, 2, 1, 2000.00000000),
(4, 3, 3, 100000.00000000),
(5, 4, 4, 500.00000000),
(6, 5, 5, 20000.00000000),
(7, 6, 6, 100000.00000000),
(8, 7, 7, 7500.00000000),
(9, 8, 8, 35000.00000000),
(10, 9, 9, 500000.00000000),
(11, 10, 10, 150000.00000000);

-- --------------------------------------------------------

--
-- Struktura tabulky `transakce`
--

CREATE TABLE `transakce` (
  `transakce_id` int(11) NOT NULL,
  `penezenka_id` int(11) DEFAULT NULL,
  `typ_transakce` enum('vklad','vyber') NOT NULL,
  `mnozstvi` decimal(18,8) NOT NULL,
  `datum_transakce` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `transakce`
--

INSERT INTO `transakce` (`transakce_id`, `penezenka_id`, `typ_transakce`, `mnozstvi`, `datum_transakce`) VALUES
(1, 1, 'vklad', 5000.00000000, '2024-04-10 12:00:00'),
(2, 1, 'vyber', 1000.00000000, '2024-04-12 15:30:00'),
(3, 2, 'vklad', 2000.00000000, '2024-05-05 09:00:00'),
(4, 3, 'vklad', 100000.00000000, '2024-06-01 08:45:00'),
(5, 4, 'vklad', 500.00000000, '2024-06-10 11:30:00'),
(6, 5, 'vklad', 20000.00000000, '2024-07-15 13:00:00'),
(7, 6, 'vklad', 100000.00000000, '2024-07-20 16:45:00'),
(8, 7, 'vyber', 500.00000000, '2024-08-10 10:20:00'),
(9, 8, 'vklad', 35000.00000000, '2024-08-15 14:10:00'),
(10, 9, 'vyber', 1500.00000000, '2024-08-20 12:30:00'),
(11, 10, 'vklad', 50000.00000000, '2024-09-01 09:15:00');

-- --------------------------------------------------------

--
-- Struktura tabulky `uzivatele`
--

CREATE TABLE `uzivatele` (
  `uzivatel_id` int(11) NOT NULL,
  `jmeno` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL,
  `datum_registrace` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `uzivatele`
--

INSERT INTO `uzivatele` (`uzivatel_id`, `jmeno`, `email`, `datum_registrace`) VALUES
(1, 'Jan Novak', 'jan.novak@example.com', '2024-01-01'),
(2, 'Petra Svobodova', 'petra.svobodova@example.com', '2024-02-15'),
(3, 'Karel Dvorak', 'karel.dvorak@example.com', '2024-03-20'),
(4, 'Anna Prochazkova', 'anna.prochazkova@example.com', '2024-03-25'),
(5, 'Jiri Benes', 'jiri.benes@example.com', '2024-04-02'),
(6, 'Eva Vankova', 'eva.vankova@example.com', '2024-04-10'),
(7, 'Lukas Urban', 'lukas.urban@example.com', '2024-04-15'),
(8, 'Tomas Havel', 'tomas.havel@example.com', '2024-04-20'),
(9, 'Marek Svoboda', 'marek.svoboda@example.com', '2024-04-25'),
(10, 'Alena Cerna', 'alena.cerna@example.com', '2024-05-01');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `memecoiny`
--
ALTER TABLE `memecoiny`
  ADD PRIMARY KEY (`memecoin_id`);

--
-- Indexy pro tabulku `penezenky`
--
ALTER TABLE `penezenky`
  ADD PRIMARY KEY (`penezenka_id`),
  ADD KEY `uzivatel_id` (`uzivatel_id`),
  ADD KEY `memecoin_id` (`memecoin_id`);

--
-- Indexy pro tabulku `transakce`
--
ALTER TABLE `transakce`
  ADD PRIMARY KEY (`transakce_id`),
  ADD KEY `penezenka_id` (`penezenka_id`);

--
-- Indexy pro tabulku `uzivatele`
--
ALTER TABLE `uzivatele`
  ADD PRIMARY KEY (`uzivatel_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `memecoiny`
--
ALTER TABLE `memecoiny`
  MODIFY `memecoin_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `penezenky`
--
ALTER TABLE `penezenky`
  MODIFY `penezenka_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pro tabulku `transakce`
--
ALTER TABLE `transakce`
  MODIFY `transakce_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;

--
-- AUTO_INCREMENT pro tabulku `uzivatele`
--
ALTER TABLE `uzivatele`
  MODIFY `uzivatel_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `penezenky`
--
ALTER TABLE `penezenky`
  ADD CONSTRAINT `penezenky_ibfk_1` FOREIGN KEY (`uzivatel_id`) REFERENCES `uzivatele` (`uzivatel_id`) ON DELETE CASCADE,
  ADD CONSTRAINT `penezenky_ibfk_2` FOREIGN KEY (`memecoin_id`) REFERENCES `memecoiny` (`memecoin_id`) ON DELETE CASCADE;

--
-- Omezení pro tabulku `transakce`
--
ALTER TABLE `transakce`
  ADD CONSTRAINT `transakce_ibfk_1` FOREIGN KEY (`penezenka_id`) REFERENCES `penezenky` (`penezenka_id`) ON DELETE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
