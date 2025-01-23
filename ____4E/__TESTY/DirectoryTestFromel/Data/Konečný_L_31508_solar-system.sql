-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 30, 2024 at 07:14 PM
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
-- Database: `solar-system`
--

-- --------------------------------------------------------

--
-- Table structure for table `missions`
--

CREATE TABLE `missions` (
  `mission_id` int(11) NOT NULL,
  `planet_id` int(11) NOT NULL,
  `planet_name` int(11) DEFAULT NULL,
  `mission_name` varchar(100) DEFAULT NULL,
  `agency` varchar(100) DEFAULT NULL,
  `launch_year` year(4) DEFAULT NULL,
  `description` text DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `missions`
--

INSERT INTO `missions` (`mission_id`, `planet_id`, `planet_name`, `mission_name`, `agency`, `launch_year`, `description`) VALUES
(1, 1, 0, 'Mariner 10', 'NASA', '1973', 'First mission to fly by Mercury and Venus'),
(2, 1, 0, 'MESSENGER', 'NASA', '2004', 'Orbital mission to map Mercury and study its surface and environment'),
(3, 2, 0, 'Venera 7', 'Soviet Union', '1970', 'First spacecraft to land on Venus and transmit data'),
(4, 2, 0, 'Pioneer Venus Orbiter', 'NASA', '1978', 'Orbital mission to study Venus atmosphere and surface'),
(5, 2, 0, 'Venus Express', 'ESA', '2005', 'Orbital mission focused on Venus atmosphere and climate'),
(6, 4, 0, 'Mariner 4', 'NASA', '1964', 'First successful flyby of Mars, returning close-up images of the planet'),
(7, 4, 0, 'Mars Pathfinder', 'NASA', '1996', 'Delivered the Sojourner rover to Mars, studying atmosphere and surface'),
(8, 4, 0, 'Curiosity', 'NASA', '2011', 'Rover exploring Mars surface for signs of past life and climate history'),
(9, 4, 0, 'Mars 2020 Perseverance', 'NASA', '2020', 'Rover mission searching for signs of past life on Mars and testing oxygen production'),
(10, 5, 0, 'Pioneer 10', 'NASA', '1972', 'First mission to fly by Jupiter, studying its atmosphere and moons'),
(11, 4, 0, 'Galileo', 'NASA', '1989', 'Orbital mission focused on Jupiter and its largest moons'),
(12, 5, 0, 'Juno', 'NASA', '2011', 'Orbital mission to study Jupiter’s composition, gravity field, and magnetic field'),
(13, 5, 0, 'Pioneer 11', 'NASA', '1973', 'First spacecraft to encounter Saturn, providing close-up images'),
(14, 6, 0, 'Cassini-Huygens', 'NASA/ESA', '1997', 'Orbital mission to study Saturn and its moons, including the Titan lander'),
(15, 7, 0, 'Voyager 2', 'NASA', '1977', 'First and only mission to fly by Uranus, studying its atmosphere and moons'),
(16, 8, 0, 'Voyager 2', 'NASA', '1977', 'First and only mission to fly by Neptune, studying its atmosphere and rings');

-- --------------------------------------------------------

--
-- Table structure for table `planet`
--

CREATE TABLE `planet` (
  `id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `mass` decimal(16,6) NOT NULL,
  `diameter` decimal(16,6) NOT NULL,
  `density` decimal(16,6) NOT NULL,
  `gravity` decimal(16,6) NOT NULL,
  `escape_velocity` decimal(16,6) NOT NULL,
  `rotation_period` decimal(16,6) NOT NULL,
  `length_of_day` decimal(16,6) NOT NULL,
  `distance_from_sun` decimal(16,6) NOT NULL,
  `perihelion` decimal(16,6) NOT NULL,
  `aphelion` decimal(16,6) NOT NULL,
  `orbital_period` decimal(16,6) NOT NULL,
  `orbital_velocity` decimal(16,6) NOT NULL,
  `orbital_inclination` decimal(16,6) NOT NULL,
  `orbital_eccentricity` decimal(16,6) NOT NULL,
  `obliquity_to_orbit` decimal(16,6) NOT NULL,
  `surface_temperature` decimal(16,6) DEFAULT NULL,
  `surface_pressure` decimal(16,6) DEFAULT NULL,
  `number_of_moons` int(11) DEFAULT NULL,
  `has_ring_system` tinyint(1) NOT NULL,
  `missions` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `planet`
--

INSERT INTO `planet` (`id`, `name`, `mass`, `diameter`, `density`, `gravity`, `escape_velocity`, `rotation_period`, `length_of_day`, `distance_from_sun`, `perihelion`, `aphelion`, `orbital_period`, `orbital_velocity`, `orbital_inclination`, `orbital_eccentricity`, `obliquity_to_orbit`, `surface_temperature`, `surface_pressure`, `number_of_moons`, `has_ring_system`, `missions`) VALUES
(1, 'Mercury', 0.330000, 4879.000000, 5427.000000, 3.700000, 4.300000, 1407.600000, 4222.600000, 57.900000, 46.000000, 69.800000, 88.000000, 47.400000, 7.000000, 0.205000, 0.034000, 167.000000, 0.000000, 0, 0, 1),
(2, 'Venus', 4.870000, 12104.000000, 5243.000000, 8.900000, 10.400000, -5832.500000, 2802.000000, 108.200000, 107.500000, 108.900000, 224.700000, 35.000000, 3.400000, 0.007000, 177.400000, 464.000000, 92.000000, 0, 0, 2),
(3, 'Earth', 5.970000, 12756.000000, 5514.000000, 9.800000, 11.200000, 23.900000, 24.000000, 149.600000, 147.100000, 152.100000, 365.200000, 29.800000, 0.000000, 0.017000, 23.400000, 15.000000, 1.000000, 1, 0, 3),
(4, 'Mars', 0.642000, 6792.000000, 3933.000000, 3.700000, 5.000000, 24.600000, 24.700000, 227.900000, 206.600000, 249.200000, 687.000000, 24.100000, 1.900000, 0.094000, 25.200000, -65.000000, 0.010000, 2, 0, 4),
(5, 'Jupiter', 1898.000000, 142984.000000, 1326.000000, 23.100000, 59.500000, 9.900000, 9.900000, 778.600000, 740.500000, 816.600000, 4331.000000, 13.100000, 1.300000, 0.049000, 3.100000, -110.000000, NULL, 79, 0, 5),
(6, 'Saturn', 568.000000, 120536.000000, 687.000000, 9.000000, 35.500000, 10.700000, 10.700000, 1433.500000, 1352.600000, 1514.500000, 10747.000000, 9.700000, 2.500000, 0.057000, 26.700000, -140.000000, NULL, 62, 0, 6),
(7, 'Uranus', 86.800000, 51118.000000, 1271.000000, 8.700000, 21.300000, -17.200000, 17.200000, 2872.500000, 2741.300000, 3003.600000, 30589.000000, 6.800000, 0.800000, 0.046000, 97.800000, -195.000000, NULL, 27, 0, 7),
(8, 'Neptune', 102.000000, 49528.000000, 1638.000000, 11.000000, 23.500000, 16.100000, 16.100000, 4495.100000, 4444.500000, 4545.700000, 59800.000000, 5.400000, 1.800000, 0.011000, 28.300000, -200.000000, NULL, 14, 0, 8);

-- --------------------------------------------------------

--
-- Table structure for table `satellite`
--

CREATE TABLE `satellite` (
  `id` int(11) NOT NULL,
  `planet_id` int(11) NOT NULL,
  `name` varchar(255) NOT NULL,
  `gm` decimal(16,6) NOT NULL,
  `radius` decimal(16,6) NOT NULL,
  `density` decimal(16,6) DEFAULT NULL,
  `magnitude` decimal(16,6) DEFAULT NULL,
  `albedo` decimal(16,6) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_ci;

--
-- Dumping data for table `satellite`
--

INSERT INTO `satellite` (`id`, `planet_id`, `name`, `gm`, `radius`, `density`, `magnitude`, `albedo`) VALUES
(1, 3, 'Moon', 4902.801000, 1737.500000, 3.344000, -12.740000, 0.120000),
(2, 4, 'Phobos', 0.000711, 11.100000, 1.872000, 11.400000, 0.071000),
(3, 4, 'Deimos', 0.000099, 6.200000, 1.471000, 12.450000, 0.068000),
(4, 5, 'Io', 5959.916000, 1821.600000, 3.528000, 5.020000, 0.630000),
(5, 5, 'Europa', 3202.739000, 1560.800000, 3.013000, 5.290000, 0.670000),
(6, 5, 'Ganymede', 9887.834000, 2631.200000, 1.942000, 4.610000, 0.430000),
(7, 5, 'Callisto', 7179.289000, 2410.300000, 1.834000, 5.650000, 0.170000),
(8, 5, 'Amalthea', 0.138000, 83.450000, 0.849000, 14.100000, 0.090000),
(9, 5, 'Himalia', 0.450000, 85.000000, 2.600000, 14.200000, 0.040000),
(10, 5, 'Elara', 0.058000, 43.000000, 2.600000, 16.000000, 0.040000),
(11, 5, 'Pasiphae', 0.020000, 30.000000, 2.600000, 16.800000, 0.040000),
(12, 5, 'Sinope', 0.005000, 19.000000, 2.600000, 18.200000, 0.040000),
(13, 5, 'Lysithea', 0.004200, 18.000000, 2.600000, 18.100000, 0.040000),
(14, 5, 'Carme', 0.008800, 23.000000, 2.600000, 18.100000, 0.040000),
(15, 5, 'Ananke', 0.002000, 14.000000, 2.600000, 19.100000, 0.040000),
(16, 5, 'Leda', 0.000730, 10.000000, 2.600000, 19.200000, 0.040000),
(17, 5, 'Thebe', 0.100000, 49.300000, 3.000000, 16.000000, 0.047000),
(18, 5, 'Adrastea', 0.000500, 8.200000, 3.000000, 18.700000, 0.100000),
(19, 5, 'Metis', 0.008000, 21.500000, 3.000000, 17.500000, 0.061000),
(20, 5, 'Callirrhoe', 0.000058, 4.300000, 2.600000, 20.800000, 0.040000),
(21, 5, 'Themisto', 0.000046, 4.000000, 2.600000, 21.000000, 0.040000),
(22, 5, 'Megaclite', 0.000014, 2.700000, 2.600000, 21.700000, 0.040000),
(23, 5, 'Taygete', 0.000011, 2.500000, 2.600000, 21.900000, 0.040000),
(24, 5, 'Chaldene', 0.000005, 1.900000, 2.600000, 22.500000, 0.040000),
(25, 5, 'Harpalyke', 0.000008, 2.200000, 2.600000, 22.200000, 0.040000),
(26, 5, 'Kalyke', 0.000013, 2.600000, 2.600000, 21.800000, 0.040000),
(27, 5, 'Iocaste', 0.000013, 2.600000, 2.600000, 21.800000, 0.040000),
(28, 5, 'Erinome', 0.000003, 1.600000, 2.600000, 22.800000, 0.040000),
(29, 5, 'Isonoe', 0.000005, 1.900000, 2.600000, 22.500000, 0.040000),
(30, 5, 'Praxidike', 0.000029, 3.400000, 2.600000, 21.200000, 0.040000),
(31, 5, 'Autonoe', 0.000006, 2.000000, 2.600000, 22.000000, 0.040000),
(32, 5, 'Thyone', 0.000006, 2.000000, 2.600000, 22.300000, 0.040000),
(33, 5, 'Hermippe', 0.000006, 2.000000, 2.600000, 22.100000, 0.040000),
(34, 5, 'Aitne', 0.000003, 1.500000, 2.600000, 22.700000, 0.040000),
(35, 5, 'Eurydome', 0.000003, 1.500000, 2.600000, 22.700000, 0.040000),
(36, 5, 'Euanthe', 0.000003, 1.500000, 2.600000, 22.800000, 0.040000),
(37, 5, 'Euporie', 0.000001, 1.000000, 2.600000, 23.100000, 0.040000),
(38, 5, 'Orthosie', 0.000001, 1.000000, 2.600000, 23.100000, 0.040000),
(39, 5, 'Sponde', 0.000001, 1.000000, 2.600000, 23.000000, 0.040000),
(40, 5, 'Kale', 0.000001, 1.000000, 2.600000, 23.000000, 0.040000),
(41, 5, 'Pasithee', 0.000001, 1.000000, 2.600000, 23.200000, 0.040000),
(42, 5, 'Hegemone', 0.000003, 1.500000, 2.600000, 22.800000, 0.040000),
(43, 5, 'Mneme', 0.000001, 1.000000, 2.600000, 23.300000, 0.040000),
(44, 5, 'Aoede', 0.000006, 2.000000, 2.600000, 22.500000, 0.040000),
(45, 5, 'Thelxinoe', 0.000001, 1.000000, 2.600000, 23.500000, 0.040000),
(46, 5, 'Arche', 0.000003, 1.500000, 2.600000, 22.800000, 0.040000),
(47, 5, 'Kallichore', 0.000001, 1.000000, 2.600000, 23.700000, 0.040000),
(48, 5, 'Helike', 0.000006, 2.000000, 2.600000, 22.600000, 0.040000),
(49, 5, 'Carpo', 0.000003, 1.500000, 2.600000, 23.000000, 0.040000),
(50, 5, 'Eukelade', 0.000006, 2.000000, 2.600000, 22.600000, 0.040000),
(51, 5, 'Cyllene', 0.000001, 1.000000, 2.600000, 23.200000, 0.040000),
(52, 5, 'Kore', 0.000001, 1.000000, 2.600000, 23.600000, 0.040000),
(53, 5, 'Herse', 0.000001, 1.000000, 2.600000, 23.400000, 0.040000),
(54, 5, 'S/2000 J11', 0.000001, 1.000000, 2.600000, 22.400000, 0.040000),
(55, 5, 'S/2003 J2', 0.000001, 1.000000, 2.600000, 23.200000, 0.040000),
(56, 5, 'S/2003 J3', 0.000001, 1.000000, 2.600000, 23.400000, 0.040000),
(57, 5, 'S/2003 J4', 0.000001, 1.000000, 2.600000, 23.000000, 0.040000),
(58, 5, 'S/2003 J5', 0.000006, 2.000000, 2.600000, 22.400000, 0.040000),
(59, 5, 'S/2003 J9', 0.000000, 0.500000, 2.600000, 23.700000, 0.040000),
(60, 5, 'S/2003 J10', 0.000001, 1.000000, 2.600000, 23.600000, 0.040000),
(61, 5, 'S/2003 J12', 0.000000, 0.500000, 2.600000, 23.900000, 0.040000),
(62, 5, 'S/2003 J15', 0.000001, 1.000000, 2.600000, 23.500000, 0.040000),
(63, 5, 'S/2003 J16', 0.000001, 1.000000, 2.600000, 23.300000, 0.040000),
(64, 5, 'S/2003 J18', 0.000001, 1.000000, 2.600000, 23.400000, 0.040000),
(65, 5, 'S/2003 J19', 0.000001, 1.000000, 2.600000, 23.700000, 0.040000),
(66, 5, 'S/2003 J23', 0.000001, 1.000000, 2.600000, 23.600000, 0.040000),
(67, 5, 'S/2010 J1', 0.000001, 1.000000, 2.600000, 23.200000, 0.040000),
(68, 5, 'S/2010 J2', 0.000001, 1.000000, 2.600000, 24.000000, 0.040000),
(69, 5, 'S/2011 J1', 0.000001, 1.000000, 2.600000, 23.700000, 0.040000),
(70, 5, 'S/2011 J2', 0.000001, 1.000000, 2.600000, 23.500000, 0.040000),
(71, 6, 'Mimas', 2.502600, 198.200000, 1.150000, 12.800000, 0.962000),
(72, 6, 'Enceladus', 7.202700, 252.100000, 1.608000, 11.800000, 1.375000),
(73, 6, 'Tethys', 41.206700, 533.000000, 0.973000, 10.200000, 1.229000),
(74, 6, 'Dione', 73.114600, 561.700000, 1.476000, 10.400000, 0.998000),
(75, 6, 'Rhea', 153.942600, 764.300000, 1.233000, 9.600000, 0.949000),
(76, 6, 'Titan', 8978.138200, 2574.730000, 1.882000, 8.400000, 0.200000),
(77, 6, 'Hyperion', 0.372700, 135.000000, 0.544000, 14.400000, 0.300000),
(78, 6, 'Iapetus', 120.503800, 735.600000, 1.083000, 11.000000, 0.600000),
(79, 6, 'Phoebe', 0.553200, 106.500000, 1.638000, 16.400000, 0.081000),
(80, 6, 'Janus', 0.126300, 89.500000, 0.630000, 14.400000, 0.710000),
(81, 6, 'Epimetheus', 0.035100, 58.100000, 0.640000, 15.600000, 0.730000),
(82, 6, 'Helene', 0.000760, 17.600000, 0.500000, 18.400000, 1.670000),
(83, 6, 'Telesto', 0.000270, 12.400000, 0.500000, 18.500000, 1.000000),
(84, 6, 'Calypso', 0.000170, 10.700000, 0.500000, 18.700000, 1.340000),
(85, 6, 'Atlas', 0.000440, 15.100000, 0.460000, 19.000000, 0.400000),
(86, 6, 'Prometheus', 0.010740, 43.100000, 0.480000, 15.800000, 0.600000),
(87, 6, 'Pandora', 0.009240, 40.700000, 0.490000, 16.400000, 0.500000),
(88, 6, 'Pan', 0.000330, 14.100000, 0.420000, 19.400000, 0.500000),
(89, 6, 'Methone', 0.000001, 1.600000, 0.500000, NULL, NULL),
(90, 6, 'Pallene', 0.000002, 2.500000, 0.500000, NULL, NULL),
(91, 6, 'Polydeuces', 0.000000, 1.300000, 0.500000, NULL, NULL),
(92, 6, 'Daphnis', 0.000005, 3.800000, 0.340000, NULL, NULL),
(93, 6, 'Anthe', 0.000000, 0.900000, 0.500000, NULL, NULL),
(94, 6, 'Aegaeon', 0.000000, 0.300000, 0.500000, NULL, NULL),
(95, 6, 'Ymir', 0.000330, 9.000000, 2.300000, 21.900000, 0.060000),
(96, 6, 'Paaliaq', 0.000550, 11.000000, 2.300000, 21.100000, 0.060000),
(97, 6, 'Tarvos', 0.000180, 7.500000, 2.300000, 22.700000, 0.060000),
(98, 6, 'Ijiraq', 0.000080, 6.000000, 2.300000, 22.600000, 0.060000),
(99, 6, 'Suttungr', 0.000014, 3.500000, 2.300000, 23.900000, 0.060000),
(100, 6, 'Kiviuq', 0.000220, 8.000000, 2.300000, 22.100000, 0.060000),
(101, 6, 'Mundilfari', 0.000014, 3.500000, 2.300000, 23.800000, 0.060000),
(102, 6, 'Albiorix', 0.001400, 16.000000, 2.300000, 20.500000, 0.060000),
(103, 6, 'Skathi', 0.000021, 4.000000, 2.300000, 23.600000, 0.060000),
(104, 6, 'Erriapus', 0.000051, 5.000000, 2.300000, 23.400000, 0.060000),
(105, 6, 'Siarnaq', 0.002600, 20.000000, 2.300000, 19.900000, 0.060000),
(106, 6, 'Thrymr', 0.000014, 3.500000, 2.300000, 23.900000, 0.060000),
(107, 6, 'Narvi', 0.000023, 3.500000, 2.300000, 23.800000, 0.040000),
(108, 6, 'Aegir', 0.000000, 3.000000, 2.300000, 24.400000, 0.040000),
(109, 6, 'Bebhionn', 0.000000, 3.000000, 2.300000, 24.100000, 0.040000),
(110, 6, 'Bergelmir', 0.000000, 3.000000, 2.300000, 24.200000, 0.040000),
(111, 6, 'Bestla', 0.000000, 3.500000, 2.300000, 23.800000, 0.040000),
(112, 6, 'Farbauti', 0.000000, 2.500000, 2.300000, 24.700000, 0.040000),
(113, 6, 'Fenrir', 0.000000, 2.000000, 2.300000, 25.000000, 0.040000),
(114, 6, 'Fornjot', 0.000000, 3.000000, 2.300000, 24.600000, 0.040000),
(115, 6, 'Hati', 0.000000, 3.000000, 2.300000, 24.400000, 0.040000),
(116, 6, 'Hyrrokkin', 0.000000, 3.000000, 2.300000, 23.500000, 0.040000),
(117, 6, 'Kari', 0.000000, 3.000000, 2.300000, 23.900000, 0.040000),
(118, 6, 'Loge', 0.000000, 3.000000, 2.300000, 24.600000, 0.040000),
(119, 6, 'Skoll', 0.000000, 3.000000, 2.300000, 24.500000, 0.040000),
(120, 6, 'Surtur', 0.000000, 3.000000, 2.300000, 24.800000, 0.040000),
(121, 6, 'Jarnsaxa', 0.000000, 3.000000, 2.300000, 24.700000, 0.040000),
(122, 6, 'Greip', 0.000000, 3.000000, 2.300000, 24.400000, 0.040000),
(123, 6, 'Tarqeq', 0.000000, 3.000000, 2.300000, 23.900000, 0.040000),
(124, 6, 'S/2004 S7', 0.000000, 3.000000, 2.300000, 24.500000, 0.040000),
(125, 6, 'S/2004 S12', 0.000000, 2.500000, 2.300000, 24.800000, 0.040000),
(126, 6, 'S/2004 S13', 0.000000, 3.000000, 2.300000, 24.500000, 0.040000),
(127, 6, 'S/2004 S17', 0.000000, 2.000000, 2.300000, 25.200000, 0.040000),
(128, 6, 'S/2006 S1', 0.000000, 3.000000, 2.300000, 24.600000, 0.040000),
(129, 6, 'S/2006 S3', 0.000000, 2.500000, 2.300000, 24.600000, 0.040000),
(130, 6, 'S/2007 S2', 0.000000, 3.000000, 2.300000, 24.400000, 0.040000),
(131, 6, 'S/2007 S3', 0.000000, 2.000000, 2.300000, 24.900000, 0.040000),
(132, 7, 'Ariel', 86.400000, 578.900000, 1.592000, 13.700000, 0.390000),
(133, 7, 'Umbriel', 81.500000, 584.700000, 1.459000, 14.470000, 0.210000),
(134, 7, 'Titania', 228.200000, 788.900000, 1.662000, 13.490000, 0.270000),
(135, 7, 'Oberon', 192.400000, 761.400000, 1.559000, 13.700000, 0.230000),
(136, 7, 'Miranda', 4.400000, 235.800000, 1.214000, 15.790000, 0.320000),
(137, 7, 'Cordelia', 0.003000, 20.100000, 1.300000, 23.620000, 0.070000),
(138, 7, 'Ophelia', 0.003600, 21.400000, 1.300000, 23.260000, 0.070000),
(139, 7, 'Bianca', 0.006200, 27.000000, 1.300000, 22.520000, 0.065000),
(140, 7, 'Cressida', 0.022900, 41.000000, 1.300000, 21.580000, 0.069000),
(141, 7, 'Desdemona', 0.011900, 35.000000, 1.300000, 21.990000, 0.084000),
(142, 7, 'Juliet', 0.037200, 53.000000, 1.300000, 21.120000, 0.075000),
(143, 7, 'Portia', 0.112200, 70.000000, 1.300000, 20.420000, 0.069000),
(144, 7, 'Rosalind', 0.017000, 36.000000, 1.300000, 21.790000, 0.072000),
(145, 7, 'Belinda', 0.023800, 45.000000, 1.300000, 21.470000, 0.067000),
(146, 7, 'Puck', 0.193100, 81.000000, 1.300000, 19.750000, 0.104000),
(147, 7, 'Caliban', 0.020000, 36.000000, 1.500000, 22.400000, 0.040000),
(148, 7, 'Sycorax', 0.180000, 75.000000, 1.500000, 20.800000, 0.040000),
(149, 7, 'Prospero', 0.006600, 25.000000, 1.500000, 23.200000, 0.040000),
(150, 7, 'Setebos', 0.005800, 24.000000, 1.500000, 23.300000, 0.040000),
(151, 7, 'Stephano', 0.001700, 16.000000, 1.500000, 24.100000, 0.040000),
(152, 7, 'Trinculo', 0.000310, 9.000000, 1.500000, 25.400000, 0.040000),
(153, 7, 'Francisco', 0.000560, 11.000000, 1.500000, 25.000000, 0.040000),
(154, 7, 'Margaret', 0.000420, 10.000000, 1.500000, 25.200000, 0.040000),
(155, 7, 'Ferdinand', 0.000420, 10.000000, 1.500000, 25.100000, 0.040000),
(156, 7, 'Perdita', 0.001200, 13.000000, 1.300000, 23.600000, 0.070000),
(157, 7, 'Mab', 0.000600, 12.000000, 1.300000, 24.600000, 0.103000),
(158, 7, 'Cupid', 0.000200, 9.000000, 1.300000, 25.800000, 0.070000),
(159, 8, 'Triton', 1427.600000, 1353.400000, 2.059000, 13.540000, 0.719000),
(160, 8, 'Nereid', 2.060000, 170.000000, 1.500000, 19.200000, 0.155000),
(161, 8, 'Naiad', 0.013000, 33.000000, 1.300000, 23.910000, 0.072000),
(162, 8, 'Thalassa', 0.025000, 41.000000, 1.300000, 23.320000, 0.091000),
(163, 8, 'Despina', 0.140000, 75.000000, 1.300000, 22.000000, 0.090000),
(164, 8, 'Galatea', 0.250000, 88.000000, 1.300000, 21.850000, 0.079000),
(165, 8, 'Larissa', 0.330000, 97.000000, 1.300000, 21.490000, 0.091000),
(166, 8, 'Proteus', 3.360000, 210.000000, 1.300000, 19.750000, 0.096000),
(167, 8, 'Halimede', 0.012000, 31.000000, 1.500000, 24.500000, 0.040000),
(168, 8, 'Psamathe', 0.003300, 20.000000, 1.500000, 25.500000, 0.040000),
(169, 8, 'Sao', 0.004500, 22.000000, 1.500000, 25.500000, 0.040000),
(170, 8, 'Laomedeia', 0.003900, 21.000000, 1.500000, 25.500000, 0.040000),
(171, 8, 'Neso', 0.011000, 30.000000, 1.500000, 24.600000, 0.040000),
(172, 8, 'S/2004 N1', 0.000300, 9.000000, 1.300000, 26.500000, 0.100000);

-- --------------------------------------------------------

--
-- Table structure for table `surface_properties`
--

CREATE TABLE `surface_properties` (
  `planet_id` int(11) NOT NULL,
  `planet_name` varchar(50) DEFAULT NULL,
  `diameter` decimal(10,2) DEFAULT NULL,
  `mass` decimal(10,5) DEFAULT NULL,
  `gravity` decimal(5,2) DEFAULT NULL,
  `surface_type` varchar(100) DEFAULT NULL,
  `temperature` decimal(5,2) DEFAULT NULL,
  `day_length_hours` decimal(5,2) DEFAULT NULL,
  `orbital_period_days` decimal(10,2) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `atmosphere` varchar(3) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `surface_properties`
--

INSERT INTO `surface_properties` (`planet_id`, `planet_name`, `diameter`, `mass`, `gravity`, `surface_type`, `temperature`, `day_length_hours`, `orbital_period_days`, `description`, `atmosphere`) VALUES
(1, 'Mercury', 4879.40, 0.33011, 3.70, 'Rocky, cratered', 167.00, 999.99, 88.00, 'Mercury has a rocky surface covered in craters, resembling Earth\'s moon.', 'Yes'),
(2, 'Venus', 12104.00, 4.86750, 8.87, 'Rocky, volcanic', 464.00, 999.99, 224.70, 'Venus has a rocky surface with numerous volcanoes and extremely high surface temperatures due to a thick atmosphere.', 'Yes'),
(3, 'Earth', 12742.00, 5.97237, 9.81, 'Water and rocky', 15.00, 24.00, 365.20, 'Earth has a diverse surface with oceans, mountains, and a moderate climate suitable for life.', 'Yes'),
(4, 'Mars', 6779.00, 0.64171, 3.71, 'Rocky, dusty', -63.00, 24.60, 687.00, 'Mars has a dusty, rocky surface with the largest volcano and canyon in the solar system.', 'Yes'),
(5, 'Jupiter', 139820.00, 1898.20000, 24.79, 'Gas giant', -108.00, 9.90, 4331.60, 'Jupiter is a gas giant with no solid surface; its atmosphere is composed mainly of hydrogen and helium.', 'Yes'),
(6, 'Saturn', 116460.00, 568.34000, 10.44, 'Gas giant with rings', -139.00, 10.70, 10747.00, 'Saturn is a gas giant famous for its complex ring system, composed mostly of ice particles.', 'Yes'),
(7, 'Uranus', 50724.00, 86.81000, 8.69, 'Ice giant', -195.00, -17.20, 30589.00, 'Uranus is an ice giant with a methane-rich atmosphere, giving it a blue color.', 'Yes'),
(8, 'Neptune', 49244.00, 102.41300, 11.15, 'Ice giant', -201.00, 16.10, 59800.00, 'Neptune is an ice giant with extreme winds and storms, and a deep blue color due to methane in its atmosphere.', 'Yes');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `missions`
--
ALTER TABLE `missions`
  ADD PRIMARY KEY (`mission_id`),
  ADD KEY `planet_id` (`planet_id`);

--
-- Indexes for table `planet`
--
ALTER TABLE `planet`
  ADD PRIMARY KEY (`id`),
  ADD KEY `missions` (`missions`);

--
-- Indexes for table `satellite`
--
ALTER TABLE `satellite`
  ADD PRIMARY KEY (`id`),
  ADD KEY `planet_id` (`planet_id`);

--
-- Indexes for table `surface_properties`
--
ALTER TABLE `surface_properties`
  ADD PRIMARY KEY (`planet_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `planet`
--
ALTER TABLE `planet`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `satellite`
--
ALTER TABLE `satellite`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=178;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `missions`
--
ALTER TABLE `missions`
  ADD CONSTRAINT `missions_ibfk_1` FOREIGN KEY (`planet_id`) REFERENCES `planet` (`id`);

--
-- Constraints for table `satellite`
--
ALTER TABLE `satellite`
  ADD CONSTRAINT `satellite_r` FOREIGN KEY (`planet_id`) REFERENCES `planet` (`id`) ON DELETE CASCADE;

--
-- Constraints for table `surface_properties`
--
ALTER TABLE `surface_properties`
  ADD CONSTRAINT `surface_properties_ibfk_1` FOREIGN KEY (`planet_id`) REFERENCES `planet` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
