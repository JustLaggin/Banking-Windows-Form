-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 22, 2024 at 01:53 PM
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
-- Database: `banking_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `historyinfo`
--

CREATE TABLE `historyinfo` (
  `id` int(11) NOT NULL,
  `amount` int(11) NOT NULL,
  `Time` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `action` text NOT NULL,
  `receiver` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `historyinfo`
--

INSERT INTO `historyinfo` (`id`, `amount`, `Time`, `action`, `receiver`) VALUES
(11, 100, '2024-12-17 05:56:44', 'Withdraw', '1'),
(11, -100, '2024-12-17 12:57:42', 'Withdraw', 'Self'),
(11, 500, '2024-12-17 12:57:49', 'Deposit', 'Self'),
(11, 500, '2024-12-17 13:03:58', 'Deposit', 'Self'),
(11, 100, '2024-12-17 13:04:15', 'Withdraw', '5'),
(11, 0, '2024-12-17 13:05:50', 'Deposit', 'Self'),
(11, 0, '2024-12-17 13:14:10', 'Withdraw', 'Self'),
(11, 0, '2024-12-17 13:14:12', 'Deposit', 'Self');

-- --------------------------------------------------------

--
-- Table structure for table `logininfo`
--

CREATE TABLE `logininfo` (
  `id` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `logininfo`
--

INSERT INTO `logininfo` (`id`, `username`, `password`) VALUES
(0, 'admin', 'secret'),
(1, 'johnsmith', 'password123'),
(2, 'janedoe', 'securepass456'),
(3, 'alicejohnson', 'mypassword789'),
(4, 'robertbrown', 'qwerty987'),
(5, 'emilydavis', 'pass2023'),
(6, 'michaelwilson', 'abc123xyz'),
(7, 'lindamartinez', 'helloWorld1'),
(8, 'davidgarcia', 'userpass555'),
(9, 'sarahrodriguez', 'strongpass777'),
(10, 'jamesmartinez', 'ilovebank123'),
(11, '123', '123');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `id` int(100) NOT NULL,
  `FirstName` text NOT NULL,
  `LastName` text NOT NULL,
  `Birthday` date NOT NULL,
  `Address` text NOT NULL,
  `Balance` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`id`, `FirstName`, `LastName`, `Birthday`, `Address`, `Balance`) VALUES
(1, 'John', 'Smith', '1990-05-15', '123 Maple St, City A', 1350),
(2, 'Jane', 'Doe', '1985-03-22', '456 Oak St, City B', 3426),
(3, 'Alice', 'Johnson', '1992-07-08', '789 Pine St, City C', 587),
(4, 'Robert', 'Brown', '1988-11-12', '321 Cedar St, City D', 2450),
(5, 'Emily', 'Davis', '1995-09-30', '654 Birch St, City E', 1880),
(6, 'Michael', 'Wilson', '1993-02-17', '987 Elm St, City F', 3091),
(7, 'Linda', 'Martinez', '1990-06-25', '123 Spruce St, City G', 675),
(8, 'David', 'Garcia', '1987-10-03', '456 Chestnut St, City H', 2140),
(9, 'Sarah', 'Rodriguez', '1991-01-14', '789 Walnut St, City I', 3981),
(10, 'James', 'Martinez', '1984-12-09', '321 Poplar St, City J', 1296),
(11, 'a', 's', '2024-12-07', 'here', 2400);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `logininfo`
--
ALTER TABLE `logininfo`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `logininfo`
--
ALTER TABLE `logininfo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
