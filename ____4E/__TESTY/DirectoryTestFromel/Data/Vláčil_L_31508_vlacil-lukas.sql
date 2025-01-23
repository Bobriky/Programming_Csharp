-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 20:20
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
-- Databáze: `car_bazar_database`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `cars`
--

CREATE TABLE `cars` (
  `car_id` int(11) NOT NULL,
  `model` varchar(100) NOT NULL,
  `brand` varchar(100) NOT NULL,
  `year` year(4) NOT NULL,
  `price` decimal(10,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `cars`
--

INSERT INTO `cars` (`car_id`, `model`, `brand`, `year`, `price`) VALUES
(1, 'E36', 'BMW', '1998', 25000),
(2, 'E46', 'BMW', '2004', 35000),
(3, 'X5', 'BMW', '2007', 50000),
(4, 'Raptor', 'Ford', '2002', 82000),
(5, 'Twingo', 'Renoult', '2002', 12000),
(6, 'Spider', 'Ferrari', '2016', 2000000),
(7, '206', 'Peugeot', '2004', 23000),
(8, 'Tranzit', 'Ford', '2004', 100000),
(9, 'Lancer', 'Mitshubishi', '2008', 77000),
(10, 'Camaro', 'Chevrolet', '2008', 540000);

-- --------------------------------------------------------

--
-- Struktura tabulky `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `phone` varchar(9) NOT NULL,
  `email` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `customers`
--

INSERT INTO `customers` (`customer_id`, `name`, `phone`, `email`) VALUES
(1, 'Jan Novak', '600222320', 'jan.novak@email.com'),
(2, 'Petr Svoboda', '603456789', ' petr.svoboda@email.com'),
(3, 'Eva Dvorakova', '604567890', 'eva.dvorakova@email.com'),
(4, 'Tomas Horak', '605678901', 'tomas.horak@email.com'),
(5, 'Martina Polakova', '606789012', 'martina.polakova@email.com'),
(6, 'Zdichcal Uzdichcal', '607890123', 'ZdichcalUzdichcal@email.com'),
(7, 'katerina.kralova\r\n', '608901234', 'katerina.kralova@email.com\r\n'),
(8, 'david.vacek', ' 60903123', 'david.vacek@email.com'),
(9, 'Petra Blazkova', '610123456', 'PetraBlazkova@seznam.cz'),
(10, 'Lukas Kucera', '611234567', 'LukasKucera@email.com');

-- --------------------------------------------------------

--
-- Struktura tabulky `sales`
--

CREATE TABLE `sales` (
  `sale_id` int(11) NOT NULL,
  `car_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `sale_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`car_id`);

--
-- Indexy pro tabulku `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexy pro tabulku `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `car_id` (`car_id`),
  ADD KEY `customer_id` (`customer_id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `cars`
--
ALTER TABLE `cars`
  MODIFY `car_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `sales`
--
ALTER TABLE `sales`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `sales` (`sale_id`),
  ADD CONSTRAINT `sales_ibfk_2` FOREIGN KEY (`sale_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `sales_ibfk_3` FOREIGN KEY (`customer_id`) REFERENCES `workers` (`worker_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
