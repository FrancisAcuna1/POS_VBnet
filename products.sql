-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 11, 2024 at 02:26 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `kfc(pos)_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `ID` int(255) NOT NULL,
  `Date_of_Sales` varchar(255) NOT NULL,
  `Amount_Payable` varchar(255) NOT NULL,
  `Cash_Tendered` varchar(255) NOT NULL,
  `Change_Amount` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`ID`, `Date_of_Sales`, `Amount_Payable`, `Cash_Tendered`, `Change_Amount`) VALUES
(10, '1/8/2024 8:31:50 PM', '18985.00', '124121', '105136'),
(11, '1/8/2024 8:32:09 PM', '820.00', '900', '80'),
(12, '1/8/2024 8:33:38 PM', '265.00', '300', '35'),
(13, '1/8/2024 9:26:29 PM', '95.00', '124', '29'),
(14, '1/8/2024 9:28:31 PM', '95.00', '234', '139'),
(15, '1/8/2024 9:33:20 PM', '95.00', '214', '119'),
(16, '1/9/2024 4:53:28 PM', '2070.00', '2100', '30'),
(17, '1/9/2024 4:54:07 PM', '490.00', '500', '10'),
(18, '1/9/2024 4:57:48 PM', '265.00', '300', '35'),
(19, '1/9/2024 4:59:55 PM', '950.00', '950', '0'),
(20, '1/9/2024 10:01:15 PM', '265.00', '300', '35'),
(21, '1/9/2024 10:03:06 PM', '1170.00', '1200', '30'),
(22, '1/9/2024 10:24:51 PM', '345.00', '350', '5'),
(23, '1/9/2024 10:25:19 PM', '180.00', '180', '0'),
(24, '1/9/2024 10:25:53 PM', '95.00', '100', '5'),
(25, '1/11/2024 9:20:58 PM', '1470.00', '1500', '30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `ID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
