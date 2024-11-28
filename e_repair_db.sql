-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 28, 2024 at 04:04 AM
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
  `added_by` int(11) DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `first_name`, `last_name`, `middle_name`, `contact_number`, `address`, `gender`, `email`, `total_paid`, `last_transaction`, `archived`, `archived_by`, `date_archived`, `added_by`, `date_added`) VALUES
(5, 'asd', 'asd', 'asd', 'asd', 'asd', 'Male', 'asd', 0.00, NULL, 1, '40', '2024-11-23 08:15:43', 40, '2024-11-22 22:15:36'),
(6, 'sdfasdasd', 'asdasd', '', '123', 'asdasd', 'Male', 'asdasd', 0.00, NULL, 0, NULL, NULL, 40, '2024-11-23 12:27:41'),
(8, 'asdasd', 'asd', 'adsa', '', '', 'Female', 'asd', 0.00, NULL, 0, NULL, NULL, 40, '2024-11-25 06:04:23');

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `employee_id` int(11) NOT NULL,
  `firstname` varchar(100) NOT NULL,
  `middlename` varchar(100) DEFAULT NULL,
  `lastname` varchar(100) NOT NULL,
  `sex` enum('Male','Female') NOT NULL,
  `birthdate` date NOT NULL,
  `civilstatus` enum('Single','Married','Widowed','Divorced') NOT NULL,
  `address` varchar(100) NOT NULL,
  `contact_number` varchar(100) NOT NULL,
  `employment_status` enum('Full Time','Part Time','Contractual','Temporary') NOT NULL,
  `date_hired` date NOT NULL,
  `sss_no` varchar(100) DEFAULT NULL,
  `pagibig_no` varchar(100) DEFAULT NULL,
  `tin_no` varchar(100) DEFAULT NULL,
  `profile_path` varchar(255) NOT NULL,
  `email` varchar(100) NOT NULL,
  `password` varchar(255) NOT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` varchar(100) DEFAULT NULL,
  `last_accessed` datetime DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL,
  `added_by` int(11) NOT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `job_type` enum('Super Admin','Admin','Technician','Cashier','Utility Personnel') NOT NULL,
  `admin_position` enum('Owner','Manager','Team Leader') NOT NULL,
  `personnel_destination` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `employees`
--

INSERT INTO `employees` (`employee_id`, `firstname`, `middlename`, `lastname`, `sex`, `birthdate`, `civilstatus`, `address`, `contact_number`, `employment_status`, `date_hired`, `sss_no`, `pagibig_no`, `tin_no`, `profile_path`, `email`, `password`, `archived`, `archived_by`, `last_accessed`, `date_archived`, `added_by`, `date_added`, `job_type`, `admin_position`, `personnel_destination`) VALUES
(40, 'Godwin', '', 'Galvez', 'Male', '2003-12-26', 'Single', 'asd', 'asd', 'Part Time', '2024-11-01', '', '', '', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-tima-miroshnichenko-6498965.jpg', 'asdd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '0', '2024-11-28 09:48:47', NULL, 40, '2024-11-09 14:51:29', 'Super Admin', 'Owner', NULL),
(50, '12312312', 'middlename', '12312', 'Female', '2024-11-22', 'Divorced', 'asdsad', 'asdadsada', 'Part Time', '2024-11-01', '12312', 'pag-ibig', '', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-mikhail-nilov-7887259.jpg', 'asdasd', 'wGS57RbwGWUqNHDFtLIMdA==', 0, '0', '2024-11-20 17:08:08', NULL, 40, '2024-11-14 23:44:04', 'Technician', 'Owner', NULL),
(62, 'asd', 'middlename', 'asd', 'Male', '2024-11-01', 'Single', 'as', 'dasd', 'Part Time', '2024-11-01', 'asd', 'asd', 'asd', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\pexels-ellis-1389429.jpg', 'asdddd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '0', NULL, NULL, 40, '2024-11-23 01:05:46', 'Admin', 'Owner', NULL),
(63, 'tech', 'middlename', 'asd', 'Female', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-24', 'ad', 'sad', '', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Employee Profiles\\qrcode_135065957_df13f3200dda9d8b4a43af28f070c84f.png', 'asddddd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, '0', NULL, NULL, 40, '2024-11-24 20:18:19', 'Technician', 'Owner', NULL),
(65, 'asd', 'asdsa', 'dad', 'Male', '2024-11-01', 'Single', 'asd', 'asdsad', 'Part Time', '2024-11-01', '', '', '', '', 'asd', '7wrYoFwRdp8wUN4v6YQWiw==', 0, NULL, '2024-11-26 13:54:09', NULL, 40, '2024-11-26 13:33:34', 'Admin', 'Manager', NULL),
(66, 'asd', 'asd', 'asd', 'Male', '2024-11-01', 'Single', 'asd', 'asd', 'Full Time', '2024-11-01', '', '', '', 'C:\\Users\\User\\Downloads\\pexels-pixabay-33597.jpg', 'asddasd', '7wrYoFwRdp8wUN4v6YQWiw==', 1, '40', NULL, '2024-11-27 03:43:02', 40, '2024-11-26 14:04:08', 'Admin', 'Owner', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `inventory`
--

CREATE TABLE `inventory` (
  `inventory_id` int(11) NOT NULL,
  `supplier_id` int(11) NOT NULL,
  `item_category` enum('PCB','Battery','LCD','Motherboard') NOT NULL,
  `item_name` varchar(100) NOT NULL,
  `item_description` varchar(255) NOT NULL,
  `serial_number` varchar(255) NOT NULL,
  `hazardous_classification` enum('Safe','Corrosive','Explosive','Flammable') NOT NULL,
  `quantity` int(11) NOT NULL DEFAULT 0,
  `total_cost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `physical_location` varchar(100) NOT NULL,
  `restock_date` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `added_by` int(11) NOT NULL,
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` int(11) DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

CREATE TABLE `items` (
  `item_id` int(11) NOT NULL,
  `invetory_id` int(11) NOT NULL,
  `service_id` int(11) DEFAULT NULL,
  `used` tinyint(1) NOT NULL,
  `cost` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `logs`
--

CREATE TABLE `logs` (
  `log_id` int(11) NOT NULL,
  `user_id` int(11) NOT NULL,
  `transaction` varchar(255) NOT NULL,
  `events` varchar(255) DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `services`
--

CREATE TABLE `services` (
  `service_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `technician_id` int(11) DEFAULT NULL,
  `cashier_id` int(11) DEFAULT NULL COMMENT 'Can act as added by',
  `device_type` enum('Mobile Phone','Tablet','PC','Laptop') NOT NULL,
  `device_model` varchar(255) NOT NULL,
  `device_brand` varchar(100) NOT NULL,
  `device_profile_path` varchar(255) NOT NULL,
  `operating_system` varchar(100) NOT NULL,
  `storage_capacity` varchar(100) NOT NULL,
  `problem_description` varchar(255) NOT NULL,
  `repair_notes` varchar(255) DEFAULT NULL,
  `service_status` enum('Pending','Finished','Onhold','Canceled') NOT NULL DEFAULT 'Pending',
  `technician_fee` decimal(10,2) NOT NULL DEFAULT 0.00,
  `parts_used` int(11) NOT NULL DEFAULT 0,
  `parts_cost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `total_cost` decimal(10,2) NOT NULL DEFAULT 0.00,
  `total_paid` decimal(10,2) DEFAULT 0.00,
  `paid` tinyint(1) NOT NULL DEFAULT 0,
  `customer_change` decimal(10,2) DEFAULT 0.00,
  `payment_method` enum('Cash On Hand','BDO','GCASH','Debit Card') DEFAULT NULL,
  `date_completed` datetime DEFAULT NULL,
  `date_claimed` datetime DEFAULT NULL,
  `date_added` datetime NOT NULL DEFAULT current_timestamp(),
  `archived` tinyint(1) NOT NULL DEFAULT 0,
  `archived_by` int(11) DEFAULT NULL,
  `date_archived` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `services`
--

INSERT INTO `services` (`service_id`, `customer_id`, `technician_id`, `cashier_id`, `device_type`, `device_model`, `device_brand`, `device_profile_path`, `operating_system`, `storage_capacity`, `problem_description`, `repair_notes`, `service_status`, `technician_fee`, `parts_used`, `parts_cost`, `total_cost`, `total_paid`, `paid`, `customer_change`, `payment_method`, `date_completed`, `date_claimed`, `date_added`, `archived`, `archived_by`, `date_archived`) VALUES
(8, 6, 62, 40, 'Mobile Phone', 'asd', 'asd', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Device Pictures\\cash-register-bold.png', '', 'asd', 'asd', '1', 'Pending', 0.00, 0, 0.00, 0.00, 0.00, 0, 0.00, NULL, '2024-11-27 02:56:42', NULL, '2024-11-24 00:32:17', 0, 0, NULL),
(9, 6, 50, 40, 'PC', 'asd', 'asd', 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Device Pictures\\3-removebg-preview.png', 'asd', 'asd', 'sad', NULL, 'Pending', 0.00, 0, 0.00, 0.00, 0.00, 0, 0.00, NULL, NULL, NULL, '2024-11-24 16:53:15', 0, NULL, NULL),
(10, 6, 63, 40, 'Mobile Phone', 'dasd', 'asdas', 'C:\\Users\\User\\Downloads\\img_2257.jpg', 'asd', 'ada', 'asd', 'Finished', 'Finished', 100.00, 0, 0.00, 100.00, 100.00, 1, 0.00, 'Cash On Hand', '2024-11-27 03:43:48', '2024-11-27 19:40:31', '2024-11-27 03:10:30', 0, NULL, NULL);

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
  `supplier_type` enum('Manufacturer',' Distributor','Retailer') NOT NULL,
  `supplier_contract` enum('Express','Implied','Bilateral') NOT NULL,
  `bank_details` enum('BDO','LandBank','GCASH','PNB','None') NOT NULL,
  `payment_terms` enum('Cash on Delivery','Cash on Hand','Debit Card') NOT NULL,
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
(2, 'asd', 'asd', 'asd', 'asd', 'asd', 'asd', 'Manufacturer', '', 'BDO', 'Cash on Delivery', 'asd', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\guitarist-high-resolution-logo-transparent.png', '2024-11-15 14:35:14', 40, 1, '40', '2024-11-26 18:15:54'),
(3, 'asdasd', 'sadsadas', 'ddddasdad', 'asdda', 'asddasd', 'asddada', '', '', '', 'Cash on Delivery', 'asdadas', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\pexels-mikhail-nilov-7887259.jpg', '2024-11-15 14:44:25', 40, 1, '40', '2024-11-19 17:14:22'),
(4, 'asd', 'asda', 'asdas', 'sadasd', 'dasd', 'asdsad', 'Manufacturer', '', 'BDO', 'Cash on Delivery', 'asda', 0.00, 'C:\\Users\\User\\AppData\\Roaming\\E-Repair Images\\Supplier Profiles\\qrcode_135066278_e010f46e5bf5ff3b112d7ff4f798e390.png', '2024-11-18 21:24:24', 40, 1, '40', '2024-11-23 06:31:38'),
(5, 'asd', 'asda', 'asda', 'adsad', 'dasd', 'asdsad', 'Manufacturer', 'Express', 'BDO', 'Cash on Delivery', 'asdasd', 0.00, 'C:\\Users\\User\\Downloads\\A.png', '2024-11-26 18:15:32', 40, 0, NULL, NULL);

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
-- Indexes for table `inventory`
--
ALTER TABLE `inventory`
  ADD PRIMARY KEY (`inventory_id`),
  ADD KEY `supplier_constraint` (`supplier_id`);

--
-- Indexes for table `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`item_id`),
  ADD KEY `inventory_const` (`invetory_id`),
  ADD KEY `service_const` (`service_id`);

--
-- Indexes for table `logs`
--
ALTER TABLE `logs`
  ADD PRIMARY KEY (`log_id`);

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
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- AUTO_INCREMENT for table `employees`
--
ALTER TABLE `employees`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=67;

--
-- AUTO_INCREMENT for table `inventory`
--
ALTER TABLE `inventory`
  MODIFY `inventory_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `items`
--
ALTER TABLE `items`
  MODIFY `item_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `logs`
--
ALTER TABLE `logs`
  MODIFY `log_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `services`
--
ALTER TABLE `services`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `suppliers`
--
ALTER TABLE `suppliers`
  MODIFY `supplier_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `customers`
--
ALTER TABLE `customers`
  ADD CONSTRAINT `cashier_constraint` FOREIGN KEY (`added_by`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `inventory`
--
ALTER TABLE `inventory`
  ADD CONSTRAINT `supplier_constraint` FOREIGN KEY (`supplier_id`) REFERENCES `suppliers` (`supplier_id`) ON DELETE NO ACTION ON UPDATE NO ACTION;

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `inventory_const` FOREIGN KEY (`invetory_id`) REFERENCES `inventory` (`inventory_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `service_const` FOREIGN KEY (`service_id`) REFERENCES `services` (`service_id`) ON DELETE SET NULL ON UPDATE SET NULL;

--
-- Constraints for table `services`
--
ALTER TABLE `services`
  ADD CONSTRAINT `cashier_const` FOREIGN KEY (`cashier_id`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `customer_const` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE SET NULL ON UPDATE SET NULL,
  ADD CONSTRAINT `technician_const` FOREIGN KEY (`technician_id`) REFERENCES `employees` (`employee_id`) ON DELETE SET NULL ON UPDATE SET NULL;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
