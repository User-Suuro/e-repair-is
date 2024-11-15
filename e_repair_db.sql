-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 15, 2024 at 05:57 AM
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
  `archived_by` varchar(100) NOT NULL,
  `last_accessed` datetime DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `firstname`, `middlename`, `lastname`, `sex`, `birthdate`, `civilstatus`, `address`, `contact_number`, `employment_status`, `date_hired`, `sss_no`, `pagibig_no`, `tin_no`, `job_type`, `total_employee_added`, `admin_position`, `personnel_destination`, `no_customers_handled`, `no_pending_services`, `no_finished_services`, `profile_path`, `email`, `password`, `added_by`, `archived`, `archived_by`, `last_accessed`, `date_archived`, `date_added`) VALUES
(40, 'Godwin', '', 'Galvez', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'asdd', '2024-11-01', '', '', '', 'Admin', NULL, 'Owner', NULL, 0, 0, 0, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-tima-miroshnichenko-6498965.jpg', 'asdd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, 0, '0', '2024-11-15 12:55:49', NULL, '2024-11-09 14:51:29'),
(50, 'asd', '', 'asd', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'asd', '2024-11-01', '', '', '', 'Admin', 0, 'Owner', NULL, 0, 0, 0, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-mikhail-nilov-7887259.jpg', 'asd', '7wrYoFwRdp8wUN4v6YQWiw==', 40, 0, '', NULL, NULL, '2024-11-14 23:44:04'),
(51, 'asdas', 'dasd', 'as', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Part Time', '2024-11-01', '', '', '', 'Admin', 0, 'Manager', NULL, 0, 0, 0, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-ellis-1389429.jpg', 'asddd', '7wrYoFwRdp8wUN4v6YQWiw==', 40, 0, '', NULL, NULL, '2024-11-15 01:47:17');

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
  `quantity` int(11) NOT NULL DEFAULT 0,
  `total_value` decimal(10,2) NOT NULL DEFAULT 0.00,
  `item_status` enum('Damaged','Reserved','Used','New') NOT NULL,
  `physical_location` varchar(100) NOT NULL,
  `restock_date` datetime NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `added_by` int(11) NOT NULL,
  `archived_status` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` varchar(100) NOT NULL,
  `date_archived` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `suppliers`
--

CREATE TABLE `suppliers` (
  `supplier_id` int(11) NOT NULL,
  `company_name` varchar(100) NOT NULL,
  `company_description` varchar(255) NOT NULL,
  `contact_person` varchar(100) NOT NULL,
  `contact_number` varchar(100) NOT NULL,
  `company_email` varchar(100) NOT NULL,
  `location` varchar(100) NOT NULL,
  `supplier_type` varchar(100) NOT NULL,
  `supplier_contract` varchar(100) NOT NULL,
  `bank_details` varchar(100) NOT NULL,
  `payment_terms` varchar(100) NOT NULL,
  `estimated_delivery_time` varchar(100) DEFAULT NULL,
  `no_supplied_item` int(11) NOT NULL DEFAULT 0,
  `total_paid` decimal(10,2) NOT NULL DEFAULT 0.00,
  `company_picture_path` varchar(255) NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `added_by` int(11) NOT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` varchar(100) DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `suppliers`
--

INSERT INTO `suppliers` (`supplier_id`, `company_name`, `company_description`, `contact_person`, `contact_number`, `company_email`, `location`, `supplier_type`, `supplier_contract`, `bank_details`, `payment_terms`, `estimated_delivery_time`, `no_supplied_item`, `total_paid`, `company_picture_path`, `date_added`, `added_by`, `archived`, `archived_by`, `date_archived`) VALUES
(1, 'asdd', 'asd', '', 'asd', 'asd', 'asd', 'hatdog', 'asd', 'BDO', 'Cash on Delivery', 'asd', 0, 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\pexels-tima-miroshnichenko-6498965.jpg', '2024-11-15 00:38:03', 0, 0, '', NULL);

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
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `supplier_constraint` (`supplier_id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=52;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `supplier_constraint` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
