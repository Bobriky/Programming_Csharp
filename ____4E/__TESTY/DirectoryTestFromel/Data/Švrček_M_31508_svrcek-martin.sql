-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 30, 2024 at 07:17 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `švrček_martin`
--

-- --------------------------------------------------------

--
-- Table structure for table `cars`
--

CREATE TABLE `cars` (
  `car_id` int(11) NOT NULL,
  `model` varchar(50) NOT NULL,
  `manufacturer_id` int(11) DEFAULT NULL,
  `year` year(4) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL,
  `dealership_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `cars`
--

INSERT INTO `cars` (`car_id`, `model`, `manufacturer_id`, `year`, `price`, `dealership_id`) VALUES
(1, 'Camry', 1, '2022', 30000.00, 1),
(2, 'Mustang', 2, '2021', 55000.00, 2),
(3, 'Golf', 3, '2020', 25000.00, 3),
(4, 'Elantra', 4, '2023', 22000.00, 4),
(5, 'Civic', 5, '2022', 27000.00, 5),
(6, 'Silverado', 6, '2021', 45000.00, 6),
(7, 'C-Class', 7, '2023', 40000.00, 7),
(8, '3 Series', 8, '2022', 42000.00, 8),
(9, 'Sorento', 9, '2020', 28000.00, 9),
(10, 'Altima', 10, '2023', 24000.00, 10);

-- --------------------------------------------------------

--
-- Table structure for table `dealerships`
--

CREATE TABLE `dealerships` (
  `dealership_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `location` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `dealerships`
--

INSERT INTO `dealerships` (`dealership_id`, `name`, `location`) VALUES
(1, 'Auto World', 'New York, USA'),
(2, 'Best Cars', 'Los Angeles, USA'),
(3, 'Car House', 'Berlin, Germany'),
(4, 'DriveWell', 'Tokyo, Japan'),
(5, 'CarzMart', 'Seoul, South Korea'),
(6, 'Speedy Motors', 'Munich, Germany'),
(7, 'RideAway', 'Chicago, USA'),
(8, 'AutoPlace', 'London, UK'),
(9, 'Prime Auto', 'Paris, France'),
(10, 'Top Wheels', 'Rome, Italy');

-- --------------------------------------------------------

--
-- Table structure for table `manufacturers`
--

CREATE TABLE `manufacturers` (
  `manufacturer_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `country` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `manufacturers`
--

INSERT INTO `manufacturers` (`manufacturer_id`, `name`, `country`) VALUES
(1, 'Toyota', 'Japan'),
(2, 'Ford', 'USA'),
(3, 'Volkswagen', 'Germany'),
(4, 'Hyundai', 'South Korea'),
(5, 'Honda', 'Japan'),
(6, 'Chevrolet', 'USA'),
(7, 'Mercedes-Benz', 'Germany'),
(8, 'BMW', 'Germany'),
(9, 'Kia', 'South Korea'),
(10, 'Nissan', 'Japan');

-- --------------------------------------------------------

--
-- Table structure for table `sales`
--

CREATE TABLE `sales` (
  `sale_id` int(11) NOT NULL,
  `car_id` int(11) DEFAULT NULL,
  `sale_date` date DEFAULT NULL,
  `price_sold` decimal(10,2) DEFAULT NULL,
  `customer_name` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `sales`
--

INSERT INTO `sales` (`sale_id`, `car_id`, `sale_date`, `price_sold`, `customer_name`) VALUES
(1, 1, '2024-01-10', 29500.00, 'John Doe'),
(2, 2, '2024-02-15', 54000.00, 'Jane Smith'),
(3, 3, '2024-03-20', 24500.00, 'Frank Miller'),
(4, 4, '2024-04-25', 21500.00, 'Emily Davis'),
(5, 5, '2024-05-30', 26500.00, 'James Wilson'),
(6, 6, '2024-06-05', 44000.00, 'Maria Hernandez'),
(7, 7, '2024-07-10', 39000.00, 'David Brown'),
(8, 8, '2024-08-15', 41000.00, 'Sarah Johnson'),
(9, 9, '2024-09-20', 27500.00, 'Chris Lee'),
(10, 10, '2024-10-25', 23500.00, 'Patricia Young');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `cars`
--
ALTER TABLE `cars`
  ADD PRIMARY KEY (`car_id`),
  ADD KEY `manufacturer_id` (`manufacturer_id`),
  ADD KEY `dealership_id` (`dealership_id`);

--
-- Indexes for table `dealerships`
--
ALTER TABLE `dealerships`
  ADD PRIMARY KEY (`dealership_id`);

--
-- Indexes for table `manufacturers`
--
ALTER TABLE `manufacturers`
  ADD PRIMARY KEY (`manufacturer_id`);

--
-- Indexes for table `sales`
--
ALTER TABLE `sales`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `car_id` (`car_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `cars`
--
ALTER TABLE `cars`
  MODIFY `car_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `dealerships`
--
ALTER TABLE `dealerships`
  MODIFY `dealership_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `manufacturers`
--
ALTER TABLE `manufacturers`
  MODIFY `manufacturer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `sales`
--
ALTER TABLE `sales`
  MODIFY `sale_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `cars`
--
ALTER TABLE `cars`
  ADD CONSTRAINT `cars_ibfk_1` FOREIGN KEY (`manufacturer_id`) REFERENCES `manufacturers` (`manufacturer_id`),
  ADD CONSTRAINT `cars_ibfk_2` FOREIGN KEY (`dealership_id`) REFERENCES `dealerships` (`dealership_id`);

--
-- Constraints for table `sales`
--
ALTER TABLE `sales`
  ADD CONSTRAINT `sales_ibfk_1` FOREIGN KEY (`car_id`) REFERENCES `cars` (`car_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
