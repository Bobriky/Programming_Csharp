-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 18:02
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
-- Databáze: `ukol`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `customer`
--

CREATE TABLE `customer` (
  `customer_ID` int(11) NOT NULL,
  `customer_name` varchar(30) NOT NULL,
  `customer_phonenum` varchar(30) DEFAULT NULL,
  `customer_mail` varchar(50) NOT NULL,
  `customer_zipcode` varchar(10) NOT NULL,
  `customer_city` varchar(30) NOT NULL,
  `customer_address` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `customer`
--

INSERT INTO `customer` (`customer_ID`, `customer_name`, `customer_phonenum`, `customer_mail`, `customer_zipcode`, `customer_city`, `customer_address`) VALUES
(28745613, 'Michaela Veselá', '+420 774 369 258', 'michaela.vesela@email.cz', '37001', 'České Budějovice', 'Lidická tř. 28'),
(34567182, 'Lukáš Hrubý', '+420 601 958 324', 'lukas.hruby@email.cz', '76001', 'Zlín', 'nám. Míru 7'),
(39481762, 'Petra Dvořáková', '+420 724 659 32', 'petra.dvorakova@email.cz', '60200', 'Brno', 'Joštova 12'),
(48291376, 'Eva Fišerová', '+420 605 732 891', 'eva.fiserova@email.cz', '70200', 'Ostrava', 'Stodolní 18'),
(52173498, 'Jan Novotný', '+420 736 241 58', 'jan.novotny@email.cz', '11000', 'Praha', 'Na Příkopech 15'),
(56129834, 'Karel Svoboda', '+420 602 745 963', 'karel.svoboda@email.cz', '77900', 'Olomouc', 'Horní náměstí 10'),
(67831249, 'Martin Kučera', '+420 731 985 467', 'martin.kucera@email.cz', '30100', 'Plzeň', 'Sady Pětatřicátníků 4'),
(81237659, 'Tereza Malá', '+420 720 123 456', 'tereza.mala@email.cz', '40001', 'Ústí nad Labem', 'Masarykova 25'),
(91348267, 'Alena Němcová', '+420 739 582 145', 'alena.nemcova@email.cz', '46001', 'Liberec', 'Moskevská 23'),
(93471826, 'Pavel Černý', '+420 603 758 912', 'pavel.cerny@email.cz', '50002', 'Hradec Králové', 'Gočárova třída 60');

-- --------------------------------------------------------

--
-- Struktura tabulky `order`
--

CREATE TABLE `order` (
  `order_ID` int(11) NOT NULL,
  `order_customerID` int(11) NOT NULL,
  `order_productID` int(11) NOT NULL,
  `order_shopID` int(11) NOT NULL,
  `order_price` int(15) NOT NULL,
  `order_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `order`
--

INSERT INTO `order` (`order_ID`, `order_customerID`, `order_productID`, `order_shopID`, `order_price`, `order_date`) VALUES
(9876789, 81237659, 13659827, 94721863, 500, '2024-10-21'),
(22456321, 48291376, 78213645, 58213746, 1250, '2024-10-10'),
(55553412, 52173498, 45923871, 18372495, 180, '2024-07-12'),
(55674589, 34567182, 34512987, 73122658, 350, '2024-09-12'),
(67885632, 56129834, 91827364, 81735692, 2200, '2024-04-11'),
(67888900, 67831249, 59278341, 38172964, 3450, '2024-02-14'),
(77363256, 28745613, 56321874, 53912847, 450, '2023-10-12'),
(78655432, 39481762, 28764519, 62819374, 1300, '2024-05-13'),
(89885367, 93471826, 78349216, 83776452, 1800, '2024-08-01'),
(99421245, 91348267, 43921857, 29481756, 3000, '2024-10-08');

-- --------------------------------------------------------

--
-- Struktura tabulky `product`
--

CREATE TABLE `product` (
  `product_ID` int(11) NOT NULL,
  `product_pcs` int(100) NOT NULL,
  `product_type` varchar(50) NOT NULL,
  `product_price` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `product`
--

INSERT INTO `product` (`product_ID`, `product_pcs`, `product_type`, `product_price`) VALUES
(13659827, 1, 'Vzduchový filtr', 500),
(28764519, 1, 'Vodní pumpa', 1300),
(34512987, 1, 'Sada žárovek H7', 350),
(43921857, 1, 'Autobaterie 12V 60Ah', 3000),
(45923871, 1, 'Olejový filtr', 180),
(56321874, 1, 'Stěrače přední', 450),
(59278341, 1, 'Spojková sada', 3450),
(78213645, 1, 'Brzdový kotouč', 1250),
(78349216, 1, 'Tlumič pérování', 1800),
(91827364, 1, 'Rozvodový řemen', 2200);

-- --------------------------------------------------------

--
-- Struktura tabulky `shop`
--

CREATE TABLE `shop` (
  `shop_ID` int(11) NOT NULL,
  `shop_name` varchar(30) NOT NULL,
  `shop_owner` varchar(50) NOT NULL,
  `shop_web` varchar(50) NOT NULL,
  `shop_ICO` varchar(10) NOT NULL,
  `shop_DIC` varchar(18) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `shop`
--

INSERT INTO `shop` (`shop_ID`, `shop_name`, `shop_owner`, `shop_web`, `shop_ICO`, `shop_DIC`) VALUES
(18372495, 'Auto Moto Díly Novotný', 'Pavel Novotný', 'www.automotodilynovotny.cz', '75643289', 'CZ75643289'),
(29481756, 'Autodíly Expert Praha', 'Tereza Svobodová', 'www.autodilyexpertPraha.cz', '85123976', 'CZ85123976'),
(38172964, 'Moto & Auto Parts Olomouc', 'Martin Kučera', 'www.motoautopartsolomouc.cz', '79231456', 'CZ79231456'),
(53912847, 'Motokuchař Tučný', 'Jan Boháček', 'www.tlustymotokuchar.cz', '72819365', 'CZ72819365'),
(58213746, 'Autodíly Plus Plzeň', 'Tomáš Veselý', 'www.autodilyplusplzen.cz', '62193847', 'CZ62193847'),
(62819374, 'Moto Servis a Díly Brno', 'Lukáš Hrubý', 'www.motoservisadilybrno.cz', '59381746', 'CZ59381746'),
(73122658, 'Dílenské Autokomponenty Libere', 'Petra Švecová', 'www.dilenskeautokomponentyliberec.cz', '73829465', 'CZ73829465'),
(81735692, 'Auto Moto Pro Brno', 'Jan Veselý', 'www.automoroprobrno.cz', '67382941', 'CZ67382941'),
(83776452, 'Motopneu', 'Milan Černý', 'www.motopneu.cz', '49590783', 'CZ49021256'),
(94721863, 'Profi Autodíly Praha', 'Kateřina Malá', 'www.profiautodilypraha.cz', '78823287', 'CZ88724621');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`customer_ID`);

--
-- Indexy pro tabulku `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`order_ID`),
  ADD KEY `order_customerID` (`order_customerID`),
  ADD KEY `order_productID` (`order_productID`),
  ADD KEY `order_shopID` (`order_shopID`),
  ADD KEY `order_price` (`order_price`);

--
-- Indexy pro tabulku `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`product_ID`),
  ADD KEY `product_price` (`product_price`);

--
-- Indexy pro tabulku `shop`
--
ALTER TABLE `shop`
  ADD PRIMARY KEY (`shop_ID`);

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`order_customerID`) REFERENCES `customer` (`customer_ID`),
  ADD CONSTRAINT `order_ibfk_2` FOREIGN KEY (`order_productID`) REFERENCES `product` (`product_ID`),
  ADD CONSTRAINT `order_ibfk_3` FOREIGN KEY (`order_shopID`) REFERENCES `shop` (`shop_ID`),
  ADD CONSTRAINT `order_ibfk_4` FOREIGN KEY (`order_price`) REFERENCES `product` (`product_price`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
