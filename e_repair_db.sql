-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 11, 2024 at 03:57 AM
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
-- Database: `e_repair_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` int(11) NOT NULL,
  `firstname` varchar(50) NOT NULL,
  `middlename` varchar(50) DEFAULT NULL,
  `lastname` varchar(50) NOT NULL,
  `sex` enum('Male','Female') NOT NULL,
  `birthdate` date NOT NULL,
  `civilstatus` enum('Single','Married','Widowed','Divorced') NOT NULL,
  `address` varchar(50) NOT NULL,
  `contact_number` varchar(50) NOT NULL,
  `employment_status` varchar(100) NOT NULL,
  `date_hired` date NOT NULL,
  `sss_no` varchar(50) DEFAULT NULL,
  `pagibig_no` varchar(50) DEFAULT NULL,
  `tin_no` varchar(50) DEFAULT NULL,
  `job_type` enum('Admin','Technician','Cashier','Utility Personnel') NOT NULL,
  `total_employee_added` int(10) DEFAULT 0,
  `admin_position` enum('Owner','Manager','Team Leader') NOT NULL,
  `personnel_destination` varchar(255) DEFAULT NULL,
  `no_customers_handled` int(10) DEFAULT 0,
  `no_pending_services` int(10) DEFAULT 0,
  `no_finished_services` int(10) DEFAULT 0,
  `profile_path` varchar(255) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `added_by` int(11) NOT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `last_accessed` datetime DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `firstname`, `middlename`, `lastname`, `sex`, `birthdate`, `civilstatus`, `address`, `contact_number`, `employment_status`, `date_hired`, `sss_no`, `pagibig_no`, `tin_no`, `job_type`, `total_employee_added`, `admin_position`, `personnel_destination`, `no_customers_handled`, `no_pending_services`, `no_finished_services`, `profile_path`, `email`, `password`, `added_by`, `archived`, `last_accessed`, `date_archived`, `date_added`) VALUES
(38, 'godwin', 'aasd', 'galvez', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-01', '', '', '', 'Admin', NULL, 'Owner', NULL, 0, 0, 0, 'C:\\Users\\User\\Pictures\\364810251_305153655376483_2165899882752645065_n.jpg', 'godwin@email.com', '7wrYoFwRdp8wUN4v6YQWiw==', 0, 1, NULL, NULL, '2024-11-09 13:46:26'),
(40, 'Godwin', '', 'Galvez', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-01', '', '', '', 'Admin', NULL, 'Team Leader', NULL, 0, 0, 0, 'C:\\Users\\User\\Pictures\\my-passport-photo.jpg', 'asdd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, 0, '2024-11-11 10:54:17', NULL, '2024-11-09 14:51:29'),
(41, 'asdsa', 'd', 'asdsa', 'Male', '2024-11-01', 'Single', 'sad', 'asdad', 'Full Time', '2024-11-01', 'asda', 'da', '', 'Admin', 0, 'Owner', NULL, 0, 0, 0, 'C:\\Users\\User\\Pictures\\IMG_7099-4.jpg', 'asd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, 1, '2024-11-11 10:19:25', '2024-11-11 10:19:33', '2024-11-09 15:01:03'),
(42, 'asd', 'asd', 'sda', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-01', '', '', '', 'Utility Personnel', 0, 'Owner', 'asd', 0, 0, 0, 'C:\\Users\\User\\Pictures\\my-passport-photo.jpg', 'asdasd', '7wrYoFwRdp8wUN4v6YQWiw==', 41, 0, NULL, NULL, '2024-11-11 01:06:21');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `item_category` varchar(100) NOT NULL,
  `item_name` varchar(100) NOT NULL,
  `item_description` varchar(255) NOT NULL,
  `serial_number` varchar(255) NOT NULL,
  `hazardous_classification` enum('Flammable','Corrosive','Explosive','Toxic','Radioactive','Safe') NOT NULL,
  `quantity` int(10) NOT NULL DEFAULT 0,
  `total_value` decimal(10,2) NOT NULL DEFAULT 0.00,
  `item_status` enum('Damaged','Reserved','Used','New') NOT NULL,
  `physical_location` varchar(100) NOT NULL,
  `restock_date` datetime NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `employees`
--
ALTER TABLE `employees`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=43;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
