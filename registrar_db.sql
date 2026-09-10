-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2026 at 12:34 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `registrar_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbldocuments`
--

CREATE TABLE `tbldocuments` (
  `DocumentID` int(11) NOT NULL,
  `DocumentName` varchar(100) NOT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Fee` decimal(10,2) NOT NULL,
  `Status` enum('Active','Inactive') NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbldocuments`
--

INSERT INTO `tbldocuments` (`DocumentID`, `DocumentName`, `Description`, `Fee`, `Status`) VALUES
(1, 'Transcript of Records', 'Official academic record', 150.00, 'Active'),
(2, 'Certificate of Enrollment', 'Proof of current enrollment', 50.00, 'Active'),
(3, 'Certificate of Good Moral', 'Character reference document', 100.00, 'Active'),
(4, 'Certification', 'General purpose certification', 50.00, 'Active'),
(5, 'Honorable Dismissal', 'Transfer clearance document', 100.00, 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblrequest`
--

CREATE TABLE `tblrequest` (
  `RequestID` int(11) NOT NULL,
  `RequestNo` varchar(20) NOT NULL,
  `StudentID` varchar(20) NOT NULL,
  `RequestDate` date NOT NULL,
  `TotalAmount` decimal(10,2) NOT NULL DEFAULT 0.00,
  `PaymentStatus` enum('Unpaid','Paid') NOT NULL DEFAULT 'Unpaid',
  `ORNo` varchar(30) DEFAULT NULL,
  `ORDate` date DEFAULT NULL,
  `Status` enum('Pending','Processing','Ready for Release','Released','Cancelled') NOT NULL DEFAULT 'Pending',
  `CreatedBy` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblrequest`
--

INSERT INTO `tblrequest` (`RequestID`, `RequestNo`, `StudentID`, `RequestDate`, `TotalAmount`, `PaymentStatus`, `ORNo`, `ORDate`, `Status`, `CreatedBy`) VALUES
(1, 'REQ-2026-00001', '20260001', '2026-08-18', 150.00, 'Unpaid', NULL, NULL, 'Pending', 2),
(2, 'REQ-2026-00002', '20260002', '2026-08-18', 100.00, 'Unpaid', NULL, NULL, 'Pending', 2),
(3, 'REQ-2026-00003', '20260003', '2026-08-19', 50.00, 'Unpaid', NULL, NULL, 'Pending', 3),
(4, 'REQ-2026-00004', '20260004', '2026-08-19', 150.00, 'Paid', 'OR-1001', '2026-08-19', 'Processing', 2),
(5, 'REQ-2026-00005', '20260005', '2026-08-20', 100.00, 'Paid', 'OR-1002', '2026-08-20', 'Processing', 3),
(6, 'REQ-2026-00006', '20260006', '2026-08-20', 200.00, 'Paid', 'OR-1003', '2026-08-20', 'Processing', 2),
(7, 'REQ-2026-00007', '20260007', '2026-08-21', 50.00, 'Paid', 'OR-1004', '2026-08-21', 'Ready for Release', 3),
(8, 'REQ-2026-00008', '20260008', '2026-08-21', 100.00, 'Paid', 'OR-1005', '2026-08-21', 'Ready for Release', 2),
(9, 'REQ-2026-00009', '20260009', '2026-08-22', 150.00, 'Paid', 'OR-1006', '2026-08-22', 'Ready for Release', 3),
(10, 'REQ-2026-00010', '20260010', '2026-08-22', 100.00, 'Paid', 'OR-1007', '2026-08-22', 'Released', 2),
(11, 'REQ-2026-00011', '20260011', '2026-08-23', 50.00, 'Paid', 'OR-1008', '2026-08-23', 'Released', 3),
(12, 'REQ-2026-00012', '20260012', '2026-08-23', 300.00, 'Paid', 'OR-1009', '2026-08-23', 'Released', 2),
(13, 'REQ-2026-00013', '20260013', '2026-08-24', 150.00, 'Unpaid', NULL, NULL, 'Cancelled', 3),
(14, 'REQ-2026-00014', '20260014', '2026-08-24', 50.00, 'Unpaid', NULL, NULL, 'Cancelled', 2),
(15, 'REQ-2026-00015', '20260015', '2026-08-25', 100.00, 'Unpaid', NULL, NULL, 'Cancelled', 3);

-- --------------------------------------------------------

--
-- Table structure for table `tblrequestdetails`
--

CREATE TABLE `tblrequestdetails` (
  `RequestDetailID` int(11) NOT NULL,
  `RequestID` int(11) NOT NULL,
  `DocumentID` int(11) NOT NULL,
  `Quantity` int(11) NOT NULL DEFAULT 1,
  `Amount` decimal(10,2) NOT NULL,
  `Subtotal` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblrequestdetails`
--

INSERT INTO `tblrequestdetails` (`RequestDetailID`, `RequestID`, `DocumentID`, `Quantity`, `Amount`, `Subtotal`) VALUES
(1, 1, 1, 1, 150.00, 150.00),
(2, 2, 3, 1, 100.00, 100.00),
(3, 3, 2, 1, 50.00, 50.00),
(4, 4, 1, 1, 150.00, 150.00),
(5, 5, 5, 1, 100.00, 100.00),
(6, 6, 1, 1, 150.00, 150.00),
(7, 6, 2, 1, 50.00, 50.00),
(8, 7, 4, 1, 50.00, 50.00),
(9, 8, 3, 1, 100.00, 100.00),
(10, 9, 1, 1, 150.00, 150.00),
(11, 10, 5, 1, 100.00, 100.00),
(12, 11, 2, 1, 50.00, 50.00),
(13, 12, 1, 2, 150.00, 300.00),
(14, 13, 1, 1, 150.00, 150.00),
(15, 14, 2, 1, 50.00, 50.00),
(16, 15, 3, 1, 100.00, 100.00);

-- --------------------------------------------------------

--
-- Table structure for table `tblstudents`
--

CREATE TABLE `tblstudents` (
  `StudentID` varchar(20) NOT NULL,
  `LRN` varchar(20) DEFAULT NULL,
  `LastName` varchar(50) NOT NULL,
  `FirstName` varchar(50) NOT NULL,
  `MiddleName` varchar(50) DEFAULT NULL,
  `Course` varchar(100) DEFAULT NULL,
  `YearLevel` varchar(20) DEFAULT NULL,
  `Section` varchar(20) DEFAULT NULL,
  `ContactNo` varchar(20) DEFAULT NULL,
  `Status` enum('Active','Inactive') NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblstudents`
--

INSERT INTO `tblstudents` (`StudentID`, `LRN`, `LastName`, `FirstName`, `MiddleName`, `Course`, `YearLevel`, `Section`, `ContactNo`, `Status`) VALUES
('20260001', '136245789012', 'Apuli', 'Gweneth', 'Llaguno', 'BS Information Technology', '3rd Year', 'A', '09171234501', 'Active'),
('20260002', '136245789013', 'Lim', 'Mikhaela', 'Janna', 'BS Computer Science', '2nd Year', 'B', '09171234502', 'Active'),
('20260003', '136245789014', 'Arceta', 'Maraiah', 'Queen', 'BS Information Technology', '4th Year', 'A', '09171234503', 'Active'),
('20260004', '136245789015', 'Robles', 'Jhoanna', 'Christine', 'BS Accountancy', '1st Year', 'C', '09171234504', 'Active'),
('20260005', '136245789016', 'Catacutan', 'Sheena', 'Mae', 'BS Information Technology', '2nd Year', 'A', '09171234505', 'Active'),
('20260006', '136245789017', 'Sevilleja', 'Stacey', 'Aubrey', 'BS Business Administration', '3rd Year', 'B', '09171234506', 'Active'),
('20260007', '136245789018', 'Vergara', 'Maria', 'Nicolette', 'BS Computer Science', '1st Year', 'A', '09171234507', 'Active'),
('20260008', '136245789019', 'Ricalde', 'Maryloi', 'Yves', 'BS Accountancy', '4th Year', 'C', '09171234508', 'Active'),
('20260009', '136245789020', 'Reyes', 'Adrian', 'Jiggs', 'BS Information Technology', '2nd Year', 'B', '09171234509', 'Active'),
('20260010', '136245789021', 'Cuyco', 'Jessie', 'Cristy', 'BS Business Administration', '1st Year', 'A', '09171234510', 'Active'),
('20260011', '136245789022', 'Mendoza', 'Patrick', 'Ramos', 'BS Computer Science', '3rd Year', 'A', '09171234511', 'Active'),
('20260012', '136245789023', 'Juan', 'Xavier', 'Kim', 'BS Information Technology', '1st Year', 'B', '09171234512', 'Active'),
('20260013', '136245789024', 'Timbreza', 'Jim', 'Albert', 'BS Accountancy', '2nd Year', 'A', '09171234513', 'Active'),
('20260014', '136245789025', 'Evangelista', 'Federico', 'Avast', 'BS Business Administration', '4th Year', 'C', '09171234514', 'Active'),
('20260015', '136245789026', 'Go', 'Riley', 'Mark', 'BS Computer Science', '2nd Year', 'B', '09171234515', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `tblusers`
--

CREATE TABLE `tblusers` (
  `UserID` int(11) NOT NULL,
  `Username` varchar(50) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `FullName` varchar(100) NOT NULL,
  `Role` enum('Administrator','Registrar Staff') NOT NULL,
  `Status` enum('Active','Inactive') NOT NULL DEFAULT 'Active'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tblusers`
--

INSERT INTO `tblusers` (`UserID`, `Username`, `Password`, `FullName`, `Role`, `Status`) VALUES
(1, 'admin', 'admin123', 'Romer Balinsoy', 'Administrator', 'Active'),
(2, 'staff01', 'staff123', 'Ryle Salvador', 'Registrar Staff', 'Active'),
(3, 'staff02', 'staff123', 'Lorenz Maga', 'Registrar Staff', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbldocuments`
--
ALTER TABLE `tbldocuments`
  ADD PRIMARY KEY (`DocumentID`);

--
-- Indexes for table `tblrequest`
--
ALTER TABLE `tblrequest`
  ADD PRIMARY KEY (`RequestID`),
  ADD UNIQUE KEY `RequestNo` (`RequestNo`),
  ADD KEY `fk_request_student` (`StudentID`),
  ADD KEY `fk_created_by` (`CreatedBy`);

--
-- Indexes for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  ADD PRIMARY KEY (`RequestDetailID`),
  ADD KEY `RequestID` (`RequestID`),
  ADD KEY `DocumentID` (`DocumentID`);

--
-- Indexes for table `tblstudents`
--
ALTER TABLE `tblstudents`
  ADD PRIMARY KEY (`StudentID`);

--
-- Indexes for table `tblusers`
--
ALTER TABLE `tblusers`
  ADD PRIMARY KEY (`UserID`),
  ADD UNIQUE KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbldocuments`
--
ALTER TABLE `tbldocuments`
  MODIFY `DocumentID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tblrequest`
--
ALTER TABLE `tblrequest`
  MODIFY `RequestID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  MODIFY `RequestDetailID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `tblusers`
--
ALTER TABLE `tblusers`
  MODIFY `UserID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tblrequest`
--
ALTER TABLE `tblrequest`
  ADD CONSTRAINT `fk_created_by` FOREIGN KEY (`CreatedBy`) REFERENCES `tblusers` (`UserID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_request_student` FOREIGN KEY (`StudentID`) REFERENCES `tblstudents` (`StudentID`) ON UPDATE CASCADE;

--
-- Constraints for table `tblrequestdetails`
--
ALTER TABLE `tblrequestdetails`
  ADD CONSTRAINT `fk_document_id` FOREIGN KEY (`DocumentID`) REFERENCES `tbldocuments` (`DocumentID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `fk_request_id` FOREIGN KEY (`RequestID`) REFERENCES `tblrequest` (`RequestID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
