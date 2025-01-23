-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 09:20
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
-- Databáze: `dbauto`
--
CREATE DATABASE IF NOT EXISTS `dbauto` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `dbauto`;

-- --------------------------------------------------------

--
-- Struktura tabulky `tbauto`
--

CREATE TABLE `tbauto` (
  `pkAuto` int(11) NOT NULL,
  `Značka` varchar(45) NOT NULL,
  `Model` varchar(45) NOT NULL,
  `Barva` varchar(20) DEFAULT NULL,
  `Motor` varchar(3) NOT NULL,
  `Nový` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `tbauto`
--

INSERT INTO `tbauto` (`pkAuto`, `Značka`, `Model`, `Barva`, `Motor`, `Nový`) VALUES
(1, 'Pontiac', 'kupe', 'MODRÁ-ZÁKLADNÍ', 'LPG', 0),
(2, 'Bentley', 'pickup', 'ŠEDÁ-ZÁKLADNÍ', 'DIS', 1),
(3, 'Aston Martin', 'pickup', 'ČERVENÁ-METAL', 'BEN', 1),
(4, 'Pontiac', 'kupe', 'FIALOVÁ-PASTEL', 'BEN', 1),
(5, 'McLaren', 'kupe', 'FIALOVÁ-SVĚTLÁ', 'LPG', 0),
(6, 'Dacia', 'kupe', 'NEZJIŠTĚNO', 'LPG', 1),
(7, 'Hyundai', 'kombi', 'ORANŽOVÁ-TMAVÁ', 'ELE', 1),
(8, 'BMW', 'kombi', 'FIALOVÁ-ZÁKLADNÍ', 'DIS', 0),
(9, 'Mercedes-Benz', 'kombi', 'MODRÁ-ZÁKLADNÍ', 'DIS', 0),
(10, 'Saab', 'kupe', 'FIALOVÁ-METAL', 'BEN', 1),
(11, 'Mitsubishi', 'kombi', 'ŽLUTÁ-ZÁKLADNÍ', 'LPG', 1),
(12, 'Kia', 'kupe', 'FIALOVÁ-ZÁKLADNÍ', 'BEN', 1),
(13, 'Seat', 'suv', 'ŠEDÁ-METAL', 'DIS', 1),
(14, 'Audi', 'pickup', 'ZELENÁ', 'LPG', 1),
(15, 'Volkswagen', 'pickup', 'FIALOVÁ-ZÁKLADNÍ', 'BEN', 1),
(16, 'Lancia', 'kombi', 'MODRÁ-PASTEL', 'BEN', 0),
(17, 'Pontiac', 'kombi', 'HNĚDÁ-PASTEL', 'DIS', 1),
(18, 'Chevrolet', 'kombi', 'ČERVENÁ-PASTEL', 'LPG', 1),
(19, 'Audi', 'kupe', 'ČERVENÁ', 'ELE', 0),
(20, 'DS', 'kombi', 'MODROZEL-ZÁKLADNÍ', 'BEN', 0),
(21, 'Ĺ koda', 'kupe', 'FIALOVÁ-PASTEL', 'LPG', 0),
(22, 'Pontiac', 'pickup', 'STŘÍBRNÁ', 'BEN', 1),
(23, 'Ferrari', 'pickup', 'ZEL-ŽLUTÁ-METAL', 'DIS', 1),
(24, 'Pontiac', 'kombi', 'ORANŽOVÁ-ZÁKLADNÍ', 'ELE', 0),
(25, 'Dodge', 'suv', 'ČERVENÁ-METAL', 'ELE', 0),
(26, 'Rolls Royce', 'suv', 'ZEL-ŽLUTÁ-PASTEL', 'BEN', 1),
(27, 'Lancia', 'kupe', 'MODROZEL-ZÁKLADNÍ', 'ELE', 1),
(28, 'BMW', 'pickup', 'ZEL-ŽLUTÁ-TMAVÁ', 'BEN', 1),
(29, 'Peugeot', 'pickup', 'ZEL-ŽLUTÁ-PASTEL', 'BEN', 1),
(30, 'Lancia', 'kombi', 'BÍLÁ', 'DIS', 1),
(31, 'Subaru', 'kombi', 'ČERVENÁ-PASTEL', 'BEN', 1),
(32, 'Nissan', 'suv', 'HNĚDÁ', 'BEN', 0),
(33, 'Ford', 'kombi', 'HNĚDÁ-PASTEL', 'BEN', 1),
(34, 'Toyota', 'kupe', 'ORANŽOVÁ-PASTEL', 'DIS', 0),
(35, 'Mini', 'kombi', 'MODROZEL-TMAVÁ', 'ELE', 0),
(36, 'Lotus', 'pickup', 'ŽLUTÁ-PASTEL', 'DIS', 0),
(37, 'Alfa Romeo', 'pickup', 'ZELENÁ-METAL', 'DIS', 0),
(38, 'Audi', 'kupe', 'ZELENÁ-ZÁKLADNÍ', 'BEN', 0),
(39, 'Alfa Romeo', 'pickup', 'ČERVENÁ-ZÁKLADNÍ', 'ELE', 1),
(40, 'KTM', 'kupe', 'MODRÁ-PASTEL', 'BEN', 1),
(41, 'Citroen', 'kupe', 'STŘÍBRNÁ-METAL', 'DIS', 1),
(42, 'Lotus', 'kupe', 'ŽLUTÁ-ZÁKLADNÍ', 'LPG', 0),
(43, 'Ford', 'suv', 'ŽLUTÁ-PASTEL', 'BEN', 1),
(44, 'Tesla', 'kupe', 'HNĚDÁ-PASTEL', 'ELE', 1),
(45, 'Peugeot', 'kupe', 'ŽLUTÁ-METAL', 'BEN', 0),
(46, 'Peugeot', 'suv', 'STŘÍBRNÁ-METAL', 'LPG', 1),
(47, 'Lamborghini', 'suv', 'ŠEDÁ-TMAVÁ', 'DIS', 0),
(48, 'Dodge', 'suv', 'ZELENÁ-TMAVÁ', 'ELE', 1),
(49, 'Mercedes-Benz', 'kombi', 'STŘÍBRNÁ-METAL', 'LPG', 1),
(50, 'Daewoo', 'kombi', 'MODROZEL-PASTEL', 'DIS', 1),
(51, 'Lancia', 'pickup', 'MODROZEL-TMAVÁ', 'LPG', 0),
(52, 'Ferrari', 'kombi', 'STŘÍBRNÁ', 'ELE', 0),
(53, 'Land Rover', 'pickup', 'ČERVENÁ', 'DIS', 1),
(54, 'Tesla', 'pickup', 'ŽLUTÁ', 'DIS', 1),
(55, 'Renault', 'kupe', 'FIALOVÁ', 'BEN', 0),
(56, 'Honda', 'kupe', 'ŠEDÁ-PASTEL', 'DIS', 1),
(57, 'Ford', 'suv', 'MODROZEL-PASTEL', 'ELE', 1),
(58, 'Nissan', 'kupe', 'ČERVENÁ-METAL', 'ELE', 1),
(59, 'Chrysler', 'kupe', 'MODRÁ-TMAVÁ', 'BEN', 0),
(60, 'Cadilac', 'kombi', 'ZEL-ŽLUTÁ-TMAVÁ', 'LPG', 0),
(61, 'Mazda', 'suv', 'MODROZEL-TMAVÁ', 'ELE', 1),
(62, 'Audi', 'pickup', 'ŠEDÁ-TMAVÁ', 'LPG', 1),
(63, 'Tatra', 'kupe', 'ORANŽOVÁ-TMAVÁ', 'LPG', 0),
(64, 'Lamborghini', 'suv', 'ČERVENÁ', 'DIS', 0),
(65, 'Seat', 'kombi', 'ČERVENÁ-SVĚTLÁ', 'BEN', 1),
(66, 'Honda', 'pickup', 'FIALOVÁ-SVĚTLÁ', 'DIS', 0),
(67, 'Ford', 'kupe', 'ČERNÁ-METAL', 'DIS', 0),
(68, 'Bentley', 'kombi', 'ŠEDÁ-PASTEL', 'LPG', 0),
(69, 'Volvo', 'kombi', 'ŽLUTÁ-METAL', 'DIS', 0),
(70, 'Lada', 'kupe', 'ZELENÁ-METAL', 'BEN', 1),
(71, 'Toyota', 'kupe', 'HNĚDÁ-SVĚTLÁ', 'DIS', 0),
(72, 'Mercedes-Benz', 'pickup', 'MĚSTSKÁ POLICIE', 'LPG', 0),
(73, 'Toyota', 'pickup', 'ZLATÁ', 'DIS', 1),
(74, 'Mazda', 'pickup', 'FIALOVÁ-ZÁKLADNÍ', 'DIS', 0),
(75, 'Hummer', 'kombi', 'ŠEDÁ-PASTEL', 'DIS', 0),
(76, 'Lamborghini', 'pickup', 'ČERVENÁ-PASTEL', 'ELE', 0),
(77, 'Jaguar', 'pickup', 'ORANŽOVÁ-SVĚTLÁ', 'DIS', 0),
(78, 'Lamborghini', 'suv', 'MODROZEL-SVĚTLÁ', 'LPG', 0),
(79, 'BMW', 'kombi', 'ŠEDÁ-TMAVÁ', 'BEN', 1),
(80, 'Subaru', 'kupe', 'ŽLUTÁ-ZÁKLADNÍ', 'DIS', 1),
(81, 'Lotus', 'kupe', 'ZELENÁ-PASTEL', 'LPG', 1),
(82, 'Ferrari', 'kombi', 'ORANŽOVÁ', 'LPG', 0),
(83, 'Hummer', 'kombi', 'ORANŽOVÁ-METAL', 'ELE', 1),
(84, 'Ford', 'kupe', 'ŠEDÁ-PASTEL', 'LPG', 0),
(85, 'Hyundai', 'kombi', 'ČERVENÁ-PASTEL', 'LPG', 0),
(86, 'Hyundai', 'suv', 'ŽLUTÁ', 'DIS', 1),
(87, 'Subaru', 'pickup', 'POLICIE ČR', 'DIS', 1),
(88, 'Subaru', 'suv', 'FIALOVÁ', 'LPG', 1),
(89, 'Jeep', 'kupe', 'ORANŽOVÁ', 'BEN', 1),
(90, 'Pontiac', 'suv', 'HNĚDÁ-ZÁKLADNÍ', 'DIS', 1),
(91, 'Audi', 'kupe', 'BÍLÁ', 'BEN', 0),
(92, 'Chevrolet', 'kombi', 'MODRÁ-SVĚTLÁ', 'DIS', 1),
(93, 'Alfa Romeo', 'kombi', 'NEZADÁNO', 'BEN', 0),
(94, 'Lamborghini', 'kupe', 'ŽLUTÁ-METAL', 'ELE', 0),
(95, 'Mercedes-Benz', 'kombi', 'MODRÁ', 'ELE', 1),
(96, 'Renault', 'pickup', 'BÍLÁ', 'DIS', 1),
(97, 'Mercedes-Benz', 'pickup', 'ZELENÁ-METAL', 'BEN', 1),
(98, 'Audi', 'pickup', 'ČERVENÁ-PASTEL', 'BEN', 1),
(99, 'Chevrolet', 'kombi', 'MODRÁ-SVĚTLÁ', 'LPG', 0),
(100, 'Toyota', 'kombi', 'ORANŽOVÁ-TMAVÁ', 'ELE', 1),
(101, 'Lexus', 'suv', 'MODRÁ-TMAVÁ', 'BEN', 1),
(102, 'Tesla', 'kupe', 'HNĚDÁ-TMAVÁ', 'ELE', 0),
(103, 'Mazda', 'kupe', 'STŘÍBRNÁ', 'ELE', 0),
(104, 'Ford', 'suv', 'ZELENÁ-METAL', 'DIS', 0),
(105, 'Audi', 'suv', 'MODROZEL-METAL', 'DIS', 0),
(106, 'Kia', 'pickup', 'ORANŽOVÁ', 'DIS', 0),
(107, 'Mercedes-Benz', 'pickup', 'FIALOVÁ-PASTEL', 'DIS', 0),
(108, 'Citroen', 'suv', 'MODRÁ-PASTEL', 'BEN', 0),
(109, 'Pontiac', 'kupe', 'ČERNÁ-METAL', 'BEN', 0),
(110, 'Volvo', 'kombi', 'ZELENÁ-SVĚTLÁ', 'LPG', 0),
(111, 'Honda', 'kupe', 'STŘÍBRNÁ', 'ELE', 1),
(112, 'DS', 'pickup', 'ČERVENÁ', 'DIS', 1),
(113, 'Lamborghini', 'suv', 'MODRÁ', 'BEN', 1),
(114, 'Hyundai', 'suv', 'MODROZEL-METAL', 'LPG', 1),
(115, 'Chevrolet', 'kupe', 'ŽLUTÁ', 'ELE', 1),
(116, 'Mini', 'kombi', 'ČERVENÁ', 'ELE', 1),
(117, 'Dodge', 'kupe', 'ZEL-ŽLUTÁ-TMAVÁ', 'BEN', 1),
(118, 'Bentley', 'pickup', 'HNĚDÁ', 'DIS', 0),
(119, 'Opel', 'suv', 'MODROZEL-SVĚTLÁ', 'ELE', 1),
(120, 'Land Rover', 'pickup', 'FIALOVÁ-ZÁKLADNÍ', 'ELE', 1),
(121, 'Renault', 'pickup', 'MODRÁ-PASTEL', 'BEN', 1),
(122, 'Saab', 'suv', 'HNĚDÁ-METAL', 'ELE', 0),
(123, 'Porsche', 'suv', 'ZEL-ŽLUTÁ-PASTEL', 'BEN', 0),
(124, 'Kia', 'suv', 'ORANŽOVÁ-SVĚTLÁ', 'LPG', 1),
(125, 'Mercedes-Benz', 'suv', 'MODROZEL-METAL', 'ELE', 0),
(126, 'KTM', 'kombi', 'HNĚDÁ-PASTEL', 'LPG', 1),
(127, 'Bentley', 'pickup', 'ŽLUTÁ-TMAVÁ', 'LPG', 0),
(128, 'Volkswagen', 'kupe', 'ŽLUTÁ', 'LPG', 0),
(129, 'Fiat', 'kupe', 'ŠEDÁ', 'DIS', 0),
(130, 'Toyota', 'suv', 'POLICIE ČR', 'BEN', 0),
(131, 'Kia', 'suv', 'ZELENÁ-SVĚTLÁ', 'ELE', 1),
(132, 'Tatra', 'suv', 'FIALOVÁ-METAL', 'BEN', 0),
(133, 'Aston Martin', 'pickup', 'ZLATÁ-METAL', 'ELE', 0),
(134, 'Citroen', 'suv', 'BÍLÁ', 'LPG', 1),
(135, 'Land Rover', 'suv', 'ORANŽOVÁ-SVĚTLÁ', 'ELE', 0),
(136, 'Mini', 'suv', 'HNĚDÁ-METAL', 'ELE', 0),
(137, 'Cadilac', 'kombi', 'ČERVENÁ-TMAVÁ', 'LPG', 1),
(138, 'Daewoo', 'kombi', 'ŽLUTÁ-SVĚTLÁ', 'LPG', 1),
(139, 'Audi', 'kombi', 'MODROZEL-TMAVÁ', 'BEN', 1),
(140, 'KTM', 'kombi', 'ŽLUTÁ-ZÁKLADNÍ', 'ELE', 0),
(141, 'Toyota', 'kupe', 'MODROZEL-METAL', 'DIS', 1),
(142, 'Mercedes-Benz', 'kombi', 'ORANŽOVÁ-METAL', 'ELE', 0),
(143, 'Toyota', 'kombi', 'STŘÍBRNÁ', 'BEN', 1),
(144, 'Mazda', 'pickup', 'ČERNÁ-METAL', 'ELE', 1),
(145, 'Hummer', 'suv', 'ŽLUTÁ-ZÁKLADNÍ', 'DIS', 0),
(146, 'Lamborghini', 'kupe', 'ZELENÁ-SVĚTLÁ', 'BEN', 1),
(147, 'Jaguar', 'kupe', 'FIALOVÁ-METAL', 'ELE', 1),
(148, 'Lamborghini', 'kombi', 'ZEL-ŽLUTÁ-ZÁKLADNÍ', 'LPG', 1),
(149, 'BMW', 'kombi', 'ZELENÁ-SVĚTLÁ', 'DIS', 0),
(150, 'Subaru', 'kombi', 'MĚSTSKÁ POLICIE', 'ELE', 0),
(151, 'Lotus', 'kupe', 'HNĚDÁ-SVĚTLÁ', 'ELE', 0),
(152, 'Ferrari', 'kupe', 'HNĚDÁ', 'BEN', 0),
(153, 'Hummer', 'pickup', 'ORANŽOVÁ-ZÁKLADNÍ', 'DIS', 1),
(154, 'Ford', 'suv', 'ČERVENÁ-ZÁKLADNÍ', 'LPG', 0),
(155, 'Hyundai', 'kupe', 'ZELENÁ-SVĚTLÁ', 'DIS', 0),
(156, 'Hyundai', 'pickup', 'HNĚDÁ-PASTEL', 'ELE', 0),
(157, 'Subaru', 'suv', 'ZELENÁ-TMAVÁ', 'ELE', 1),
(158, 'Subaru', 'suv', 'ŽLUTÁ-PASTEL', 'LPG', 1),
(159, 'Jeep', 'kupe', 'BÍLÁ', 'LPG', 1),
(160, 'Pontiac', 'pickup', 'ZELENÁ-METAL', 'BEN', 1),
(161, 'Audi', 'kupe', 'MODRÁ-SVĚTLÁ', 'BEN', 1),
(162, 'Kia', 'pickup', 'ORANŽOVÁ-SVĚTLÁ', 'LPG', 1),
(163, 'Subaru', 'suv', 'ORANŽOVÁ-TMAVÁ', 'LPG', 1),
(164, 'BMW', 'pickup', 'HNĚDÁ-ZÁKLADNÍ', 'BEN', 1),
(165, 'Alfa Romeo', 'pickup', 'ORANŽOVÁ-ZÁKLADNÍ', 'LPG', 1),
(166, 'Bentley', 'suv', 'ŽLUTÁ-ZÁKLADNÍ', 'DIS', 0),
(167, 'Saab', 'kupe', 'STŘÍBRNÁ-METAL', 'ELE', 1),
(168, 'Saab', 'pickup', 'ŽLUTÁ-ZÁKLADNÍ', 'DIS', 1),
(169, 'Suzuki', 'pickup', 'ORANŽOVÁ-TMAVÁ', 'DIS', 0),
(170, 'Isuzu', 'kupe', 'MODROZEL-SVĚTLÁ', 'ELE', 0),
(171, 'Tesla', 'suv', 'ŠEDÁ-METAL', 'BEN', 1),
(172, 'Fiat', 'pickup', 'ŠEDÁ-SVĚTLÁ', 'ELE', 0),
(173, 'Mitsubishi', 'kombi', 'HNĚDÁ-SVĚTLÁ', 'LPG', 1),
(174, 'Bentley', 'pickup', 'MODRÁ', 'DIS', 0),
(175, 'Hummer', 'suv', 'MODROZEL-ZÁKLADNÍ', 'LPG', 0),
(176, 'Rolls Royce', 'kombi', 'FIALOVÁ-TMAVÁ', 'ELE', 0),
(177, 'GMC', 'kombi', 'ZLATÁ', 'LPG', 1),
(178, 'Cadilac', 'kupe', 'ŽLUTÁ-METAL', 'ELE', 1),
(179, 'Jaguar', 'pickup', 'MODRÁ-SVĚTLÁ', 'BEN', 1),
(180, 'Honda', 'pickup', 'MODRÁ-SVĚTLÁ', 'DIS', 1),
(181, 'Audi', 'kupe', 'HNĚDÁ', 'BEN', 1),
(182, 'Lexus', 'kombi', 'MODRÁ', 'BEN', 0),
(183, 'Toyota', 'pickup', 'ČERNÁ', 'BEN', 0),
(184, 'Cadilac', 'kombi', 'HNĚDÁ-METAL', 'DIS', 0),
(185, 'Aston Martin', 'pickup', 'ŠEDÁ-SVĚTLÁ', 'LPG', 0),
(186, 'Kia', 'kupe', 'FIALOVÁ-ZÁKLADNÍ', 'LPG', 0),
(187, 'Ferrari', 'pickup', 'FIALOVÁ-METAL', 'ELE', 0),
(188, 'GMC', 'kupe', 'ŠEDÁ', 'DIS', 1),
(189, 'Mazda', 'kupe', 'ČERVENÁ', 'DIS', 1),
(190, 'Lexus', 'pickup', 'POLICIE ČR', 'ELE', 1),
(191, 'Porsche', 'pickup', 'ZEL-ŽLUTÁ-SVĚTLÁ', 'LPG', 1),
(192, 'Lexus', 'kupe', 'MODROZEL-SVĚTLÁ', 'LPG', 0),
(193, 'Mini', 'kombi', 'ČERNÁ', 'BEN', 1),
(194, 'Ferrari', 'kombi', 'FIALOVÁ-METAL', 'BEN', 1),
(195, 'Honda', 'suv', 'HNĚDÁ', 'DIS', 0),
(196, 'Bentley', 'pickup', 'ORANŽOVÁ-TMAVÁ', 'BEN', 1),
(197, 'Lancia', 'kupe', 'BÍLÁ', 'DIS', 0),
(198, 'Lada', 'pickup', 'ŽLUTÁ-PASTEL', 'ELE', 1),
(199, 'Mitsubishi', 'kombi', 'ČERNÁ-METAL', 'LPG', 0),
(200, 'KTM', 'kombi', 'ORANŽOVÁ-ZÁKLADNÍ', 'ELE', 1),
(201, 'Land Rover', 'suv', 'ŽLUTÁ-TMAVÁ', 'BEN', 0),
(202, 'Mazda', 'kombi', 'ŠEDÁ-ZÁKLADNÍ', 'LPG', 1),
(203, 'BMW', 'pickup', 'STŘÍBRNÁ-METAL', 'LPG', 0),
(204, 'Peugeot', 'pickup', 'ŠEDÁ-SVĚTLÁ', 'LPG', 1),
(205, 'Jeep', 'kombi', 'MODRÁ', 'LPG', 1),
(206, 'Lada', 'kombi', 'ŽLUTÁ-PASTEL', 'DIS', 1),
(207, 'Fiat', 'kupe', 'MODROZEL-TMAVÁ', 'LPG', 0),
(208, 'Mercedes-Benz', 'suv', 'MODRÁ-PASTEL', 'BEN', 1),
(209, 'Mazda', 'pickup', 'ČERVENÁ-METAL', 'DIS', 1),
(210, 'GMC', 'pickup', 'ZLATÁ-METAL', 'LPG', 1),
(211, 'Volvo', 'pickup', 'MODRÁ-SVĚTLÁ', 'ELE', 1),
(212, 'Opel', 'suv', 'HNĚDÁ-SVĚTLÁ', 'BEN', 0),
(213, 'Peugeot', 'pickup', 'ČERNÁ', 'DIS', 1),
(214, 'Daewoo', 'kombi', 'HNĚDÁ-METAL', 'LPG', 0),
(215, 'Toyota', 'suv', 'ZELENÁ-PASTEL', 'ELE', 1),
(216, 'Lada', 'pickup', 'ZLATÁ-METAL', 'BEN', 1),
(217, 'Lotus', 'kupe', 'ČERNÁ-METAL', 'LPG', 1),
(218, 'Volvo', 'suv', 'STŘÍBRNÁ-METAL', 'ELE', 1),
(219, 'Saab', 'kombi', 'ORANŽOVÁ-ZÁKLADNÍ', 'BEN', 0),
(220, 'McLaren', 'kombi', 'ORANŽOVÁ-TMAVÁ', 'DIS', 0),
(221, 'Bentley', 'kupe', 'ŽLUTÁ', 'LPG', 1),
(222, 'Isuzu', 'pickup', 'HNĚDÁ-TMAVÁ', 'BEN', 1),
(223, 'Cadilac', 'suv', 'ČERVENÁ', 'ELE', 0),
(224, 'Fiat', 'kupe', 'ŽLUTÁ-TMAVÁ', 'LPG', 1),
(225, 'Volvo', 'kombi', 'BÍLÁ', 'DIS', 1),
(226, 'Bugatti', 'kupe', 'ORANŽOVÁ', 'DIS', 0),
(227, 'Dodge', 'kombi', 'FIALOVÁ-ZÁKLADNÍ', 'ELE', 1),
(228, 'Dodge', 'kupe', 'ŽLUTÁ-ZÁKLADNÍ', 'BEN', 0),
(229, 'Suzuki', 'suv', 'FIALOVÁ-SVĚTLÁ', 'ELE', 0),
(230, 'Citroen', 'kupe', 'MĚSTSKÁ POLICIE', 'BEN', 0),
(231, 'Volvo', 'kupe', 'ORANŽOVÁ-SVĚTLÁ', 'LPG', 0),
(232, 'Isuzu', 'suv', 'ZELENÁ-PASTEL', 'ELE', 1),
(233, 'McLaren', 'kupe', 'HNĚDÁ-METAL', 'ELE', 0),
(234, 'Bentley', 'suv', 'STŘÍBRNÁ', 'DIS', 1),
(235, 'KTM', 'kombi', 'ZEL-ŽLUTÁ-SVĚTLÁ', 'LPG', 1),
(236, 'McLaren', 'suv', 'ZEL-ŽLUTÁ-TMAVÁ', 'LPG', 0),
(237, 'Bugatti', 'pickup', 'ČERNÁ', 'DIS', 0),
(238, 'Toyota', 'suv', 'ŠEDÁ-TMAVÁ', 'BEN', 0),
(239, 'Tatra', 'kupe', 'ZELENÁ-METAL', 'LPG', 1),
(240, 'Audi', 'suv', 'ORANŽOVÁ-TMAVÁ', 'LPG', 1),
(241, 'Tesla', 'pickup', 'ZEL-ŽLUTÁ-ZÁKLADNÍ', 'BEN', 1),
(242, 'Mitsubishi', 'kupe', 'HNĚDÁ-SVĚTLÁ', 'LPG', 1),
(243, 'Jaguar', 'kombi', 'ŠEDÁ-ZÁKLADNÍ', 'DIS', 1),
(244, 'Audi', 'pickup', 'STŘÍBRNÁ-METAL', 'BEN', 0),
(245, 'Alfa Romeo', 'suv', 'ORANŽOVÁ', 'LPG', 1),
(246, 'Lotus', 'suv', 'ZLATÁ-METAL', 'DIS', 1),
(247, 'Dacia', 'suv', 'ČERVENÁ-METAL', 'BEN', 0),
(248, 'Pontiac', 'suv', 'ZELENÁ-METAL', 'ELE', 1),
(249, 'Nissan', 'suv', 'MODRÁ', 'BEN', 1);

-- --------------------------------------------------------

--
-- Struktura tabulky `tbbarva`
--

CREATE TABLE `tbbarva` (
  `Nazev` varchar(25) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `tbbarva`
--

INSERT INTO `tbbarva` (`Nazev`) VALUES
('BÍLÁ'),
('ČERNÁ'),
('ČERNÁ-METAL'),
('ČERVENÁ'),
('ČERVENÁ-METAL'),
('ČERVENÁ-PASTEL'),
('ČERVENÁ-SVĚTLÁ'),
('ČERVENÁ-TMAVÁ'),
('ČERVENÁ-ZÁKLADNÍ'),
('FIALOVÁ'),
('FIALOVÁ-METAL'),
('FIALOVÁ-PASTEL'),
('FIALOVÁ-SVĚTLÁ'),
('FIALOVÁ-TMAVÁ'),
('FIALOVÁ-ZÁKLADNÍ'),
('HNĚDÁ'),
('HNĚDÁ-METAL'),
('HNĚDÁ-PASTEL'),
('HNĚDÁ-SVĚTLÁ'),
('HNĚDÁ-TMAVÁ'),
('HNĚDÁ-ZÁKLADNÍ'),
('MODRÁ'),
('MODRÁ-PASTEL'),
('MODRÁ-SVĚTLÁ'),
('MODRÁ-TMAVÁ'),
('MODRÁ-ZÁKLADNÍ'),
('MODROZEL-METAL'),
('MODROZEL-PASTEL'),
('MODROZEL-SVĚTLÁ'),
('MODROZEL-TMAVÁ'),
('MODROZEL-ZÁKLADNÍ'),
('NEZADÁNO'),
('NEZJIŠTĚNO'),
('ORANŽOVÁ'),
('ORANŽOVÁ-METAL'),
('ORANŽOVÁ-PASTEL'),
('ORANŽOVÁ-SVĚTLÁ'),
('ORANŽOVÁ-TMAVÁ'),
('ORANŽOVÁ-ZÁKLADNÍ'),
('POLICIEČR'),
('ŠEDÁ'),
('ŠEDÁ-METAL'),
('ŠEDÁ-PASTEL'),
('ŠEDÁ-SVĚTLÁ'),
('ŠEDÁ-TMAVÁ'),
('ŠEDÁ-ZÁKLADNÍ'),
('STŘÍBRNÁ'),
('STŘÍBRNÁ-METAL'),
('ZEL-ŽLUTÁ-METAL'),
('ZEL-ŽLUTÁ-PASTEL'),
('ZEL-ŽLUTÁ-SVĚTLÁ'),
('ZEL-ŽLUTÁ-TMAVÁ'),
('ZEL-ŽLUTÁ-ZÁKLADNÍ'),
('ZELENÁ'),
('ZELENÁ-METAL'),
('ZELENÁ-PASTEL'),
('ZELENÁ-SVĚTLÁ'),
('ZELENÁ-TMAVÁ'),
('ZELENÁ-ZÁKLADNÍ'),
('ZLATÁ'),
('ZLATÁ-METAL'),
('ŽLUTÁ'),
('ŽLUTÁ-METAL'),
('ŽLUTÁ-PASTEL'),
('ŽLUTÁ-SVĚTLÁ'),
('ŽLUTÁ-TMAVÁ'),
('ŽLUTÁ-ZÁKLADNÍ');

-- --------------------------------------------------------

--
-- Struktura tabulky `tbmotor`
--

CREATE TABLE `tbmotor` (
  `pkMotor` varchar(3) NOT NULL,
  `Název` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `tbmotor`
--

INSERT INTO `tbmotor` (`pkMotor`, `Název`) VALUES
('BEN', 'Benzín'),
('DIS', 'Nafta'),
('ELE', 'Elektrika'),
('LPG', 'Plyn'),
('VOD', 'Vodík');

-- --------------------------------------------------------

--
-- Struktura tabulky `tbznacka`
--

CREATE TABLE `tbznacka` (
  `pkNazev` varchar(45) NOT NULL,
  `stat` varchar(3) DEFAULT NULL,
  `Mesto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vypisuji data pro tabulku `tbznacka`
--

INSERT INTO `tbznacka` (`pkNazev`, `stat`, `Mesto`) VALUES
('Alfa Romeo', '', 0),
('Aston Martin', '', 0),
('Audi', '', 0),
('Bentley', '', 0),
('BMW', '', 0),
('Bugatti', '', 0),
('Cadilac', '', 0),
('Chevrolet', '', 0),
('Chrysler', '', 0),
('Citroen', '', 0),
('Dacia', '', 0),
('Daewoo', '', 0),
('Dodge', '', 0),
('DS', '', 0),
('Ferrari', '', 0),
('Fiat', '', 0),
('Ford', '', 0),
('GMC', '', 0),
('Honda', '', 0),
('Hummer', '', 0),
('Hyundai', '', 0),
('Isuzu', '', 0),
('Jaguar', '', 0),
('Jeep', '', 0),
('Kia', '', 0),
('KTM', '', 0),
('Lada', '', 0),
('Lamborghini', '', 0),
('Lancia', '', 0),
('Land Rover', '', 0),
('Lexus', '', 0),
('Lotus', '', 0),
('Mazda', '', 0),
('McLaren', '', 0),
('Mercedes-Benz', '', 0),
('Mini', '', 0),
('Mitsubishi', '', 0),
('Nissan', '', 0),
('Opel', '', 0),
('Peugeot', '', 0),
('Pontiac', 'USA', 0),
('Porsche', '', 0),
('Renault', '', 0),
('Rolls Royce', '', 0),
('Saab', '', 0),
('Seat', '', 0),
('Škoda', '', 0),
('Subaru', '', 0),
('Suzuki', '', 0),
('Tatra', '', 0),
('Tesla', '', 0),
('Toyota', '', 0),
('Volkswagen', '', 0),
('Volvo', '', 0);

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `tbauto`
--
ALTER TABLE `tbauto`
  ADD PRIMARY KEY (`pkAuto`),
  ADD KEY `Motor` (`Motor`),
  ADD KEY `Značka` (`Značka`);

--
-- Indexy pro tabulku `tbbarva`
--
ALTER TABLE `tbbarva`
  ADD PRIMARY KEY (`Nazev`);

--
-- Indexy pro tabulku `tbmotor`
--
ALTER TABLE `tbmotor`
  ADD PRIMARY KEY (`pkMotor`);

--
-- Indexy pro tabulku `tbznacka`
--
ALTER TABLE `tbznacka`
  ADD PRIMARY KEY (`pkNazev`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `tbauto`
--
ALTER TABLE `tbauto`
  MODIFY `pkAuto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=250;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `tbauto`
--
ALTER TABLE `tbauto`
  ADD CONSTRAINT `tbauto_ibfk_1` FOREIGN KEY (`Motor`) REFERENCES `tbmotor` (`pkMotor`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
