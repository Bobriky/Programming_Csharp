-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Úte 22. říj 2024, 22:59
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
-- Databáze: `obchod_d`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `kategorie`
--

CREATE TABLE `kategorie` (
  `kategorie_id` int(11) NOT NULL,
  `nazev` varchar(100) NOT NULL,
  `popis` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `kategorie`
--

INSERT INTO `kategorie` (`kategorie_id`, `nazev`, `popis`) VALUES
(1, 'Elektronika', 'Produkty elektronického charakteru'),
(2, 'Oblečení', 'Oděvy a módní doplňky'),
(3, 'Sportovní vybavení', 'Vybavení pro sport a outdoor'),
(4, 'Domácí potřeby', 'Potřeby pro domácnost a kuchyni'),
(5, 'Hračky', 'Hračky pro děti různého věku'),
(6, 'Knihy', 'Knihy všech žánrů'),
(7, 'Nábytek', 'Nábytek pro domácnost a kanceláře'),
(8, 'Kosmetika', 'Kosmetické a pečující produkty'),
(9, 'Automobilové příslušenství', 'Vše pro auta a motorky'),
(10, 'Zdraví a fitness', 'Pomůcky pro zdraví a fitness');

-- --------------------------------------------------------

--
-- Struktura tabulky `objednavky`
--

CREATE TABLE `objednavky` (
  `objednavka_id` int(11) NOT NULL,
  `zakaznik_id` int(11) DEFAULT NULL,
  `datum_objednavky` date NOT NULL,
  `stav_objednavky` varchar(50) DEFAULT NULL,
  `celkova_cena` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `objednavky`
--

INSERT INTO `objednavky` (`objednavka_id`, `zakaznik_id`, `datum_objednavky`, `stav_objednavky`, `celkova_cena`) VALUES
(1, 1, '2024-01-10', 'Doručeno', 29999.98),
(2, 2, '2024-01-15', 'Odesláno', 15999.99),
(3, 3, '2024-02-02', 'Zpracovává se', 2599.98),
(4, 4, '2024-02-10', 'Vytvořeno', 14999.99),
(5, 5, '2024-03-05', 'Doručeno', 2399.98),
(6, 6, '2024-03-12', 'Odesláno', 1599.99),
(7, 7, '2024-03-15', 'Zpracovává se', 1999.99),
(8, 8, '2024-03-20', 'Vytvořeno', 19999.99),
(9, 9, '2024-04-01', 'Doručeno', 599.99),
(10, 10, '2024-04-10', 'Odesláno', 14999.99);

-- --------------------------------------------------------

--
-- Struktura tabulky `objednavky_produkty`
--

CREATE TABLE `objednavky_produkty` (
  `objednavka_id` int(11) NOT NULL,
  `produkt_id` int(11) NOT NULL,
  `mnozstvi` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `objednavky_produkty`
--

INSERT INTO `objednavky_produkty` (`objednavka_id`, `produkt_id`, `mnozstvi`) VALUES
(1, 1, 1),
(1, 2, 1),
(2, 1, 1),
(3, 3, 2),
(4, 5, 1),
(5, 4, 2),
(6, 6, 1),
(7, 7, 1),
(8, 1, 1),
(8, 9, 1),
(9, 8, 1),
(10, 9, 1);

-- --------------------------------------------------------

--
-- Struktura tabulky `produkty`
--

CREATE TABLE `produkty` (
  `produkt_id` int(11) NOT NULL,
  `nazev` varchar(255) NOT NULL,
  `popis` text DEFAULT NULL,
  `cena` decimal(10,2) NOT NULL,
  `skladem` int(11) NOT NULL,
  `kategorie_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `produkty`
--

INSERT INTO `produkty` (`produkt_id`, `nazev`, `popis`, `cena`, `skladem`, `kategorie_id`) VALUES
(1, 'iPhone 13', 'Nejnovější Apple smartphone', 24999.99, 20, 1),
(2, 'Samsung Galaxy S21', 'Vlajkový telefon Samsungu', 19999.99, 15, 1),
(3, 'Nike Air Max', 'Stylové sportovní boty', 2999.99, 50, 2),
(4, 'Adidas Triko', 'Pánské sportovní triko', 799.99, 100, 2),
(5, 'Horské kolo', 'Kolo pro outdoor a horskou cyklistiku', 14999.99, 10, 3),
(6, 'Mixér Philips', 'Výkonný mixér do kuchyně', 1599.99, 30, 4),
(7, 'Lego Star Wars', 'Stavebnice pro děti', 1999.99, 25, 5),
(8, 'Kniha - Pán prstenů', 'Fantasy kniha od Tolkiena', 599.99, 100, 6),
(9, 'Psací stůl', 'Moderní psací stůl do kanceláře', 4999.99, 10, 7),
(10, 'Proteinový prášek', 'Protein pro sportovce', 999.99, 75, 10);

-- --------------------------------------------------------

--
-- Struktura tabulky `zakaznici`
--

CREATE TABLE `zakaznici` (
  `zakaznik_id` int(11) NOT NULL,
  `jmeno` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL,
  `telefon` varchar(15) DEFAULT NULL,
  `adresa` varchar(255) DEFAULT NULL,
  `registrace_datum` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `zakaznici`
--

INSERT INTO `zakaznici` (`zakaznik_id`, `jmeno`, `email`, `telefon`, `adresa`, `registrace_datum`) VALUES
(1, 'Jan Novák', 'jan.novak@email.cz', '123456789', 'Praha, Česká republika', '2023-01-15'),
(2, 'Petr Svoboda', 'petr.svoboda@email.cz', '987654321', 'Brno, Česká republika', '2023-02-20'),
(3, 'Lucie Dvořáková', 'lucie.dvorakova@email.cz', '564738291', 'Ostrava, Česká republika', '2023-03-10'),
(4, 'Karel Novotný', 'karel.novotny@email.cz', '432156789', 'Plzeň, Česká republika', '2023-04-01'),
(5, 'Michaela Horáková', 'michaela.horakova@email.cz', '789456123', 'Liberec, Česká republika', '2023-04-25'),
(6, 'Tomáš Černý', 'tomas.cerny@email.cz', '258369147', 'Hradec Králové, Česká republika', '2023-05-05'),
(7, 'Veronika Veselá', 'veronika.vesela@email.cz', '147852369', 'Ústí nad Labem, Česká republika', '2023-06-12'),
(8, 'David Procházka', 'david.prochazka@email.cz', '369852147', 'Pardubice, Česká republika', '2023-07-20'),
(9, 'Jana Malá', 'jana.mala@email.cz', '159753486', 'Olomouc, Česká republika', '2023-08-02'),
(10, 'Adam Král', 'adam.kral@email.cz', '753951486', 'Zlín, Česká republika', '2023-09-14');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `kategorie`
--
ALTER TABLE `kategorie`
  ADD PRIMARY KEY (`kategorie_id`);

--
-- Indexy pro tabulku `objednavky`
--
ALTER TABLE `objednavky`
  ADD PRIMARY KEY (`objednavka_id`),
  ADD KEY `zakaznik_id` (`zakaznik_id`);

--
-- Indexy pro tabulku `objednavky_produkty`
--
ALTER TABLE `objednavky_produkty`
  ADD PRIMARY KEY (`objednavka_id`,`produkt_id`),
  ADD KEY `produkt_id` (`produkt_id`);

--
-- Indexy pro tabulku `produkty`
--
ALTER TABLE `produkty`
  ADD PRIMARY KEY (`produkt_id`),
  ADD KEY `kategorie_id` (`kategorie_id`);

--
-- Indexy pro tabulku `zakaznici`
--
ALTER TABLE `zakaznici`
  ADD PRIMARY KEY (`zakaznik_id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `kategorie`
--
ALTER TABLE `kategorie`
  MODIFY `kategorie_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `objednavky`
--
ALTER TABLE `objednavky`
  MODIFY `objednavka_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `produkty`
--
ALTER TABLE `produkty`
  MODIFY `produkt_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `zakaznici`
--
ALTER TABLE `zakaznici`
  MODIFY `zakaznik_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `objednavky`
--
ALTER TABLE `objednavky`
  ADD CONSTRAINT `objednavky_ibfk_1` FOREIGN KEY (`zakaznik_id`) REFERENCES `zakaznici` (`zakaznik_id`);

--
-- Omezení pro tabulku `objednavky_produkty`
--
ALTER TABLE `objednavky_produkty`
  ADD CONSTRAINT `objednavky_produkty_ibfk_1` FOREIGN KEY (`objednavka_id`) REFERENCES `objednavky` (`objednavka_id`),
  ADD CONSTRAINT `objednavky_produkty_ibfk_2` FOREIGN KEY (`produkt_id`) REFERENCES `produkty` (`produkt_id`);

--
-- Omezení pro tabulku `produkty`
--
ALTER TABLE `produkty`
  ADD CONSTRAINT `produkty_ibfk_1` FOREIGN KEY (`kategorie_id`) REFERENCES `kategorie` (`kategorie_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
