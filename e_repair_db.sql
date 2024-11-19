-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 19, 2024 at 05:42 AM
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
-- Table structure for table `customers`
--

CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL,
  `first_name` varchar(100) NOT NULL,
  `last_name` varchar(100) NOT NULL,
  `middle_name` varchar(100) NOT NULL,
  `contact_number` varchar(100) NOT NULL,
  `address` varchar(255) NOT NULL,
  `gender` enum('Male','Female') NOT NULL,
  `email` varchar(100) NOT NULL,
  `total_paid` decimal(10,2) NOT NULL DEFAULT 0.00,
  `last_transaction` datetime DEFAULT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` varchar(100) DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL,
  `added_by` int(11) NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `middle_name`, `contact_number`, `address`, `gender`, `email`, `total_paid`, `last_transaction`, `archived`, `archived_by`, `date_archived`, `added_by`, `date_added`) VALUES
(1, 'fname', 'lname', 'mname', '123', 'address', 'Female', '', 0.00, NULL, 0, '', NULL, 40, '2024-11-19 11:58:43');

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
  `admin_position` enum('Owner','Manager','Team Leader') NOT NULL,
  `personnel_destination` varchar(255) DEFAULT NULL,
  `profile_path` varchar(255) NOT NULL,
  `email` varchar(50) NOT NULL,
  `password` varchar(255) NOT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` varchar(100) NOT NULL,
  `last_accessed` datetime DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL,
  `added_by` int(11) NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `firstname`, `middlename`, `lastname`, `sex`, `birthdate`, `civilstatus`, `address`, `contact_number`, `employment_status`, `date_hired`, `sss_no`, `pagibig_no`, `tin_no`, `job_type`, `admin_position`, `personnel_destination`, `profile_path`, `email`, `password`, `archived`, `archived_by`, `last_accessed`, `date_archived`, `added_by`, `date_added`) VALUES
(40, 'Godwin', '', 'Galvez', 'Male', '2003-12-26', 'Single', 'asd', 'asd', 'asdd', '2024-11-01', '', '', '', 'Admin', 'Owner', NULL, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-tima-miroshnichenko-6498965.jpg', 'asdd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '0', '2024-11-19 12:24:57', NULL, 40, '2024-11-09 14:51:29'),
(50, 'asd', '', 'asd', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'asd', '2024-11-01', '', 'pag-ibig', '', 'Admin', 'Team Leader', NULL, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-mikhail-nilov-7887259.jpg', 'asd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '', '2024-11-19 11:50:47', NULL, 40, '2024-11-14 23:44:04'),
(51, 'asdasd', 'dasd', 'as', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-01', 'asdasd', 'asdasd', '', 'Admin', 'Manager', NULL, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-ellis-1389429.jpg', 'asddd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '', NULL, NULL, 40, '2024-11-15 01:47:17'),
(52, 'asdasd', 'asd', 'asd', 'Male', '2024-11-01', 'Single', 'asd', '123', 'Full Time', '2024-11-01', '', '', '', 'Admin', 'Team Leader', NULL, 'C:\\Users\\User\\Downloads\\img_2257.jpg', 'asdddasd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '', NULL, NULL, 0, '2024-11-15 16:32:53');

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `service_id` int(11) DEFAULT NULL,
  `item_category` varchar(100) NOT NULL,
  `item_name` varchar(100) NOT NULL,
  `item_description` varchar(255) NOT NULL,
  `serial_number` varchar(255) NOT NULL,
  `hazardous_classification` enum('Flammable','Corrosive','Explosive','Toxic','Radioactive','Safe') NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  `total_value` decimal(10,2) NOT NULL DEFAULT 0.00,
  `item_status` enum('Damaged','Reserved','Used','New') NOT NULL,
  `physical_location` varchar(100) NOT NULL,
  `restock_date` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `added_by` int(11) NOT NULL,
  `archived_status` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` int(11) DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_id` int(11) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `technician_id` int(11) NOT NULL,
  `cashier_id` int(11) NOT NULL COMMENT 'Can act as added by',
  `device_type` varchar(100) NOT NULL,
  `device_model` varchar(255) NOT NULL,
  `device_brand` varchar(100) NOT NULL,
  `operating_system` varchar(100) NOT NULL,
  `storage_capacity` varchar(100) NOT NULL,
  `problem_description` varchar(255) NOT NULL,
  `repair_notes` varchar(255) NOT NULL,
  `service_status` enum('Pending','Finished','Onhold','Canceled') NOT NULL DEFAULT 'Pending',
  `technician_fee` decimal(10,2) NOT NULL DEFAULT 0.00,
  `parts_cost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `paid` tinyint(1) NOT NULL DEFAULT 0,
  `total_paid` decimal(10,2) DEFAULT NULL,
  `customer_change` decimal(10,2) DEFAULT NULL,
  `payment_method` varchar(100) NOT NULL,
  `date_completed` datetime DEFAULT NULL,
  `date_claimed` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
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

INSERT INTO `suppliers` (`supplier_id`, `company_name`, `company_description`, `contact_person`, `contact_number`, `company_email`, `location`, `supplier_type`, `supplier_contract`, `bank_details`, `payment_terms`, `estimated_delivery_time`, `total_paid`, `company_picture_path`, `date_added`, `added_by`, `archived`, `archived_by`, `date_archived`) VALUES
(2, 'asd', 'asd', 'asd', 'asd', 'asd', 'asd', 'Manufacturer', 'Bilateral', 'BDO', 'Cash on Delivery', 'asd', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\guitarist-high-resolution-logo-transparent.png', '2024-11-15 14:35:14', 40, 0, NULL, NULL),
(3, 'asdasd', 'sadsadas', 'ddddasdad', 'asdda', 'asddasd', 'asddada', 'asdsadad', 'asdasd', 'sada', 'asdasda', 'asdadas', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\pexels-mikhail-nilov-7887259.jpg', '2024-11-15 14:44:25', 40, 0, NULL, NULL),
(4, 'asd', 'asda', 'asdas', 'sadasd', 'dasd', 'asdsad', 'Manufacturer', 'Express', 'BDO', 'Cash on Delivery', 'asda', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\qrcode_135066278_e010f46e5bf5ff3b112d7ff4f798e390.png', '2024-11-18 21:24:24', 40, 0, NULL, NULL);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customers`
--
ALTER TABLE `customers`
  ADD PRIMARY KEY (`customer_id`),
  ADD KEY `cashier_constraint` (`added_by`);

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
  ADD KEY `supplier_constraint` (`supplier_id`),
  ADD KEY `service_const` (`service_id`);

--
-- Indexes for table `services`
--
ALTER TABLE `services`
  ADD PRIMARY KEY (`service_id`),
  ADD KEY `customer_const` (`customer_id`),
  ADD KEY `technician_const` (`technician_id`),
  ADD KEY `cashier_const` (`cashier_id`);

--
-- Indexes for table `suppliers`
--
ALTER TABLE `suppliers`
  ADD PRIMARY KEY (`supplier_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customers`
--
ALTER TABLE `customers`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=54;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customers`
--
ALTER TABLE `customers`
  ADD CONSTRAINT `cashier_constraint` FOREIGN KEY (`added_by`) REFERENCES `employees` (`employee_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `service_const` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `supplier_constraint` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `services`
--
ALTER TABLE `services`
  ADD CONSTRAINT `cashier_const` FOREIGN KEY (`cashier_id`) REFERENCES `employees` (`employee_id`),
  ADD CONSTRAINT `customer_const` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`),
  ADD CONSTRAINT `technician_const` FOREIGN KEY (`technician_id`) REFERENCES `employees` (`employee_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
