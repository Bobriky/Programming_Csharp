-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 19:03
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
-- Databáze: `anime`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `anime`
--

CREATE TABLE `anime` (
  `anime_id` int(7) NOT NULL,
  `name` varchar(255) DEFAULT NULL,
  `autor_id` int(7) NOT NULL,
  `genre_id` int(7) NOT NULL,
  `mainCharacter_id` int(7) NOT NULL,
  `release_date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `anime`
--

INSERT INTO `anime` (`anime_id`, `name`, `autor_id`, `genre_id`, `mainCharacter_id`, `release_date`) VALUES
(1, 'That Time I Got Reincarnated as a Slime', 1, 16, 1, '2018-03-16'),
(2, 'Mushoku Tensei', 2, 16, 2, '2018-10-09'),
(3, 'No Game No Life', 3, 2, 3, '2014-03-07'),
(4, 'Seven Deadly Sins', 4, 1, 4, '2013-12-18'),
(5, 'One Punch Man', 5, 5, 5, '2016-10-19'),
(6, 'Attack on Titan', 6, 3, 6, '2018-10-13'),
(7, 'Hunter x Hunter', 7, 18, 7, '2018-01-20'),
(8, 'Dragon Ball', 8, 13, 8, '2017-12-22'),
(9, 'Tokyo Ghoul', 9, 1, 9, '2018-04-20'),
(10, 'Demon Slayer', 10, 2, 10, '2020-10-15');

-- --------------------------------------------------------

--
-- Struktura tabulky `autor`
--

CREATE TABLE `autor` (
  `autor_id` int(7) NOT NULL,
  `jmeno` varchar(100) NOT NULL,
  `prijmeni` varchar(100) NOT NULL,
  `datum_narozeni` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `autor`
--

INSERT INTO `autor` (`autor_id`, `jmeno`, `prijmeni`, `datum_narozeni`) VALUES
(1, 'Fuse', '', '1984-11-25'),
(2, 'Rifujin na', 'Magonote', '1980-04-19'),
(3, 'Yuu', 'Kamiya', '1984-11-10'),
(4, 'Nakaba', 'Suzuki', '1977-02-08'),
(5, 'ONE', '', '1986-10-29'),
(6, 'Hajime', 'Isayama', '1986-08-29'),
(7, 'Yoshihiro', 'Togashi', '1966-04-27'),
(8, 'Akira', 'Toriyama', '1955-04-05'),
(9, 'Sui', 'Ishida', '1986-12-28'),
(10, 'Koyoharu', 'Gotouge', '1988-05-05');

-- --------------------------------------------------------

--
-- Struktura tabulky `genre`
--

CREATE TABLE `genre` (
  `genre_id` int(7) NOT NULL,
  `hlavni_zanr` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `genre`
--

INSERT INTO `genre` (`genre_id`, `hlavni_zanr`) VALUES
(1, 'Akční'),
(2, 'Fantasy'),
(3, 'Sci-Fi'),
(4, 'Romantika'),
(5, 'Komedie'),
(6, 'Drama'),
(7, 'Horor'),
(8, 'Mystery'),
(9, 'Thriller'),
(10, 'Sportovní'),
(11, 'Dobrodružný'),
(12, 'Slice of Life'),
(13, 'Nadpřirozený'),
(14, 'Mecha'),
(15, 'Historický'),
(16, 'Isekai'),
(17, 'Detektivní'),
(18, 'Shounen'),
(19, 'Shoujo'),
(20, 'Seinen');

-- --------------------------------------------------------

--
-- Struktura tabulky `maincharacter`
--

CREATE TABLE `maincharacter` (
  `mainCharacter_id` int(7) NOT NULL,
  `jmeno` varchar(50) NOT NULL,
  `prijmeni` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `maincharacter`
--

INSERT INTO `maincharacter` (`mainCharacter_id`, `jmeno`, `prijmeni`) VALUES
(1, 'Rimuru', 'Tempest'),
(2, 'Rudeus', 'Greyrat'),
(3, 'Sora', ''),
(4, 'Meliodas', ''),
(5, 'Saitama', ''),
(6, 'Eren', 'Yeager'),
(7, 'Gon', 'Freecss'),
(8, 'Goku', ''),
(9, 'Kaneki', 'Ken'),
(10, 'Tanjiro', 'Kamado');

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `anime`
--
ALTER TABLE `anime`
  ADD PRIMARY KEY (`anime_id`),
  ADD KEY `autor_id` (`autor_id`),
  ADD KEY `genre_id` (`genre_id`),
  ADD KEY `mainCharacter_id` (`mainCharacter_id`);

--
-- Indexy pro tabulku `autor`
--
ALTER TABLE `autor`
  ADD PRIMARY KEY (`autor_id`);

--
-- Indexy pro tabulku `genre`
--
ALTER TABLE `genre`
  ADD PRIMARY KEY (`genre_id`);

--
-- Indexy pro tabulku `maincharacter`
--
ALTER TABLE `maincharacter`
  ADD PRIMARY KEY (`mainCharacter_id`);

--
-- AUTO_INCREMENT pro tabulky
--

--
-- AUTO_INCREMENT pro tabulku `anime`
--
ALTER TABLE `anime`
  MODIFY `anime_id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `autor`
--
ALTER TABLE `autor`
  MODIFY `autor_id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT pro tabulku `genre`
--
ALTER TABLE `genre`
  MODIFY `genre_id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT pro tabulku `maincharacter`
--
ALTER TABLE `maincharacter`
  MODIFY `mainCharacter_id` int(7) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `anime`
--
ALTER TABLE `anime`
  ADD CONSTRAINT `anime_ibfk_1` FOREIGN KEY (`autor_id`) REFERENCES `autor` (`autor_id`),
  ADD CONSTRAINT `anime_ibfk_2` FOREIGN KEY (`genre_id`) REFERENCES `genre` (`genre_id`),
  ADD CONSTRAINT `anime_ibfk_3` FOREIGN KEY (`mainCharacter_id`) REFERENCES `maincharacter` (`mainCharacter_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
