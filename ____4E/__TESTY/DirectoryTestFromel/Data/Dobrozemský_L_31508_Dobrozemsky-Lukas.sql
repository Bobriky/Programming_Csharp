-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Počítač: 127.0.0.1
-- Vytvořeno: Stř 30. říj 2024, 20:53
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
-- Databáze: `db_books`
--

-- --------------------------------------------------------

--
-- Struktura tabulky `authors`
--

CREATE TABLE `authors` (
  `author_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `birthdate` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `authors`
--

INSERT INTO `authors` (`author_id`, `name`, `birthdate`) VALUES
('1', 'George Orwell', '1903-06-25'),
('10', 'Haruki Murakami', '1949-01-12'),
('2', 'J.K. Rowling', '1965-07-31'),
('3', 'J.R.R. Tolkien', '1892-01-03'),
('4', 'Franz Kafka', '1883-06-03'),
('5', 'Gabriel García Márquez', '1927-04-14'),
('6', 'Jane Austen', '1775-12-16'),
('7', 'Ernest Hemingway', '1899-06-28'),
('8', 'Ray Bradbury', '1920-08-22'),
('9', 'Fyodor Dostoevsky', '1821-10-11');

-- --------------------------------------------------------

--
-- Struktura tabulky `book_tb`
--

CREATE TABLE `book_tb` (
  `book_id` varchar(50) NOT NULL,
  `title` varchar(50) NOT NULL,
  `author_id` varchar(50) NOT NULL,
  `genre` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Vypisuji data pro tabulku `book_tb`
--

INSERT INTO `book_tb` (`book_id`, `title`, `author_id`, `genre`) VALUES
('1', '1984', '1', 'Dystopian'),
('10', 'Norwegian Wood', '10', 'Romance, Realism'),
('2', 'Harry Potter and the Philosopher', '2', 'Fantasy'),
('3', 'The Lord of the Rings', '3', 'Fantasy'),
('4', 'The Metamorphosis', '4', 'Existential Literature'),
('5', 'One Hundred Years of Solitude', '5', 'Magical Realism'),
('6', 'Pride and Prejudice', '6', 'Romance'),
('7', 'The Old Man and the Sea', '7', 'Adventure, Novella'),
('8', 'Fahrenheit 451', '8', 'Sci-Fi, Dystopian'),
('9', 'Crime and Punishment', '9', 'Psychological Novel');

-- --------------------------------------------------------

--
-- Struktura tabulky `loans`
--

CREATE TABLE `loans` (
  `loan_id` varchar(50) NOT NULL,
  `book_id` varchar(50) NOT NULL,
  `user_id` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

-- --------------------------------------------------------

--
-- Struktura tabulky `users`
--

CREATE TABLE `users` (
  `user_id` varchar(50) NOT NULL,
  `name` varchar(50) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_czech_ci;

--
-- Indexy pro exportované tabulky
--

--
-- Indexy pro tabulku `authors`
--
ALTER TABLE `authors`
  ADD PRIMARY KEY (`author_id`);

--
-- Indexy pro tabulku `book_tb`
--
ALTER TABLE `book_tb`
  ADD PRIMARY KEY (`book_id`),
  ADD KEY `author_id` (`author_id`);

--
-- Indexy pro tabulku `loans`
--
ALTER TABLE `loans`
  ADD PRIMARY KEY (`loan_id`),
  ADD KEY `book_id` (`book_id`),
  ADD KEY `user_id` (`user_id`);

--
-- Indexy pro tabulku `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- Omezení pro exportované tabulky
--

--
-- Omezení pro tabulku `book_tb`
--
ALTER TABLE `book_tb`
  ADD CONSTRAINT `book_tb_ibfk_1` FOREIGN KEY (`author_id`) REFERENCES `authors` (`author_id`);

--
-- Omezení pro tabulku `loans`
--
ALTER TABLE `loans`
  ADD CONSTRAINT `loans_ibfk_1` FOREIGN KEY (`book_id`) REFERENCES `book_tb` (`book_id`),
  ADD CONSTRAINT `loans_ibfk_2` FOREIGN KEY (`user_id`) REFERENCES `users` (`user_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
