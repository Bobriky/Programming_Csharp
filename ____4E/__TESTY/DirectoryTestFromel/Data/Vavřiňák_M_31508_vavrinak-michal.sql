-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: localhost
-- Vytvořeno: Stř 30. říj 2024, 17:27
-- Verze serveru: 10.4.28-MariaDB
-- Verze PHP: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáze: `eshop_db`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `Kategorie`
--

CREATE TABLE `Kategorie` (
  `id` int(11) NOT NULL,
  `nazev` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `Kategorie`
--

INSERT INTO `Kategorie` (`id`, `nazev`) VALUES
(1, 'Elektronika'),
(2, 'Oblečení'),
(3, 'Potraviny'),
(4, 'Drogerie'),
(5, 'Gaming'),
(6, 'Hudba'),
(7, 'Auto-moto'),
(8, 'Hračky'),
(9, 'Velké spotřebiče'),
(10, 'Domácí potřeby');

-- --------------------------------------------------------

--
-- Struktura tabulky `Objednavky`
--

CREATE TABLE `Objednavky` (
  `id` int(11) NOT NULL,
  `zakaznik_id` int(11) NOT NULL,
  `datum` date NOT NULL,
  `produkt_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `Objednavky`
--

INSERT INTO `Objednavky` (`id`, `zakaznik_id`, `datum`, `produkt_id`) VALUES
(1, 11, '2024-10-30', 2),
(2, 10, '2024-01-05', 4),
(3, 2, '2024-02-10', 5),
(4, 6, '2024-10-30', 7),
(5, 3, '2024-04-20', 11),
(6, 1, '2024-05-25', 1),
(7, 4, '2024-06-30', 2),
(8, 5, '2024-07-05', 3),
(9, 8, '2024-08-10', 6),
(10, 9, '2024-09-15', 9),
(11, 2, '2024-10-20', 10),
(12, 7, '2024-11-25', 1),
(13, 11, '2024-12-01', 12),
(14, 1, '2024-01-02', 4),
(15, 3, '2024-02-07', 5),
(16, 2, '2024-03-12', 6),
(17, 4, '2024-04-17', 7),
(18, 5, '2024-05-22', 8),
(19, 6, '2024-06-27', 9),
(20, 7, '2024-07-02', 10),
(21, 8, '2024-08-08', 11),
(22, 9, '2024-09-13', 12),
(23, 10, '2024-10-18', 1),
(24, 11, '2024-11-23', 2),
(25, 1, '2024-12-28', 3),
(26, 2, '2024-01-01', 4),
(27, 3, '2024-02-04', 5),
(28, 4, '2024-03-09', 6),
(29, 5, '2024-04-14', 7),
(30, 6, '2024-05-19', 8);

-- --------------------------------------------------------

--
-- Struktura tabulky `Produkty`
--

CREATE TABLE `Produkty` (
  `id` int(11) NOT NULL,
  `nazev` varchar(255) NOT NULL,
  `cena` decimal(10,0) NOT NULL,
  `kategorie_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `Produkty`
--

INSERT INTO `Produkty` (`id`, `nazev`, `cena`, `kategorie_id`) VALUES
(1, 'Chungus lednička z Amériky', 39990, 9),
(2, 'Plyšák Kocourek Boris - 25 cm', 729, 8),
(3, 'SEVEROCHEMA Ředidlo S6300 700 ml', 100, 10),
(4, 'Rick Astley – Never Gonna Give You Up (1987, Vinyl)', 70, 6),
(5, 'Objevte své lepší já (CD)', 600, 6),
(6, 'iPhone 16 Pro Max 1TB pouštní titan', 47990, 1),
(7, 'Mac mini M4 2024', 17490, 1),
(8, 'Babičin zlatý řetízek', 29990, 2),
(9, 'Taška Birkin od Hermès', 109990, 2),
(10, 'PlayStation 5 Pro', 20290, 5),
(11, 'Škoda Felicia 1.6 rally', 150000, 7),
(12, 'Jablko', 20, 3);

-- --------------------------------------------------------

--
-- Struktura tabulky `Zakaznici`
--

CREATE TABLE `Zakaznici` (
  `id` int(11) NOT NULL,
  `jmeno` varchar(50) NOT NULL,
  `prijmeni` varchar(50) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_czech_ci;

--
-- Vypisuji data pro tabulku `Zakaznici`
--

INSERT INTO `Zakaznici` (`id`, `jmeno`, `prijmeni`, `email`) VALUES
(1, 'Eliška', 'Šťastná', 'eliska.stastna@gmail.com'),
(2, 'Honzík', 'Mikárek', 'honzik.mikarek@icloud.com'),
(3, 'Jarda', 'Babl', 'jarda.babl@seznam.cz'),
(4, 'Janina', 'Černá', 'janina.cerna@gmail.com'),
(5, 'Klára', 'Světlá', 'klara.svetla@seznam.cz'),
(6, 'Lukáš', 'Nekonečný', 'lukas.nekonecny@gmail.com'),
(7, 'Majkl', 'Valenta', 'majkl.valenta@icloud.com'),
(8, 'Marek', 'Zelený', 'marek.zeleny@gmail.com'),
(9, 'Petra', 'Kocourková', 'petra.kocourkova@seznam.cz'),
(10, 'Radim', 'Černej', 'radim.cernej@gmail.com'),
(11, 'Sajmn', 'Froml', 'sajmn.froml@icloud.com'),
(12, 'Tomáš', 'Hlava', 'tomas.hlava@seznam.cz');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `Kategorie`
--
ALTER TABLE `Kategorie`
  ADD PRIMARY KEY (`id`);

--
-- Indexy pro tabulku `Objednavky`
--
ALTER TABLE `Objednavky`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_objednavky_zakaznici` (`zakaznik_id`),
  ADD KEY `fk_objednavky_produkty` (`produkt_id`);

--
-- Indexy pro tabulku `Produkty`
--
ALTER TABLE `Produkty`
  ADD PRIMARY KEY (`id`),
  ADD KEY `fk_produkty_kategorie` (`kategorie_id`);

--
-- Indexy pro tabulku `Zakaznici`
--
ALTER TABLE `Zakaznici`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `Kategorie`
--
ALTER TABLE `Kategorie`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `Objednavky`
--
ALTER TABLE `Objednavky`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=61;

--
-- AUTO_INCREMENT pro tabulku `Produkty`
--
ALTER TABLE `Produkty`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- AUTO_INCREMENT pro tabulku `Zakaznici`
--
ALTER TABLE `Zakaznici`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=13;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `Objednavky`
--
ALTER TABLE `Objednavky`
  ADD CONSTRAINT `fk_objednavky_produkty` FOREIGN KEY (`produkt_id`) REFERENCES `Produkty` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_objednavky_zakaznici` FOREIGN KEY (`zakaznik_id`) REFERENCES `Zakaznici` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Omezení pro tabulku `Produkty`
--
ALTER TABLE `Produkty`
  ADD CONSTRAINT `fk_produkty_kategorie` FOREIGN KEY (`kategorie_id`) REFERENCES `Kategorie` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
