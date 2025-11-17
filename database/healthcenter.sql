-- phpMyAdmin SQL Dump
-- version 4.8.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Dec 12, 2019 at 10:54 AM
-- Server version: 10.1.33-MariaDB
-- PHP Version: 7.2.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `healthcenter`
--

-- --------------------------------------------------------

--
-- Table structure for table `activate_admin`
--

CREATE TABLE `activate_admin` (
  `code` varchar(100) NOT NULL,
  `ID` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `activate_admin`
--

INSERT INTO `activate_admin` (`code`, `ID`) VALUES
('1234', 1);

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `ID` int(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Password` varchar(100) NOT NULL,
  `RecoveryNumber` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`ID`, `UserName`, `Password`, `RecoveryNumber`) VALUES
(12, 'kelemex', 'aowYPDd+67/1MIHl+xEDtw==', 12345),
(14, 'claire', '5LvncAJoyT4=', 19982019);

-- --------------------------------------------------------

--
-- Table structure for table `medicine`
--

CREATE TABLE `medicine` (
  `ID` int(100) NOT NULL,
  `medicine_name` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `medicine`
--

INSERT INTO `medicine` (`ID`, `medicine_name`) VALUES
(1, 'None'),
(2, 'Paracetamol'),
(4, 'Biogesic'),
(5, 'Pain Killer');

-- --------------------------------------------------------

--
-- Table structure for table `patient`
--

CREATE TABLE `patient` (
  `PatientNumber` int(100) NOT NULL,
  `FirstName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) NOT NULL,
  `LastName` varchar(100) NOT NULL,
  `DateofRegistration` varchar(100) NOT NULL,
  `Attending_Physician` varchar(100) NOT NULL,
  `Purpose_of_Coming` varchar(100) NOT NULL,
  `Medicines_Received` varchar(100) NOT NULL,
  `BirthDate` varchar(100) NOT NULL,
  `Age` int(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `ContactNumber` varchar(100) NOT NULL,
  `Height` varchar(100) NOT NULL,
  `Weight` varchar(100) NOT NULL,
  `BloodP` varchar(100) NOT NULL,
  `PatientIDName` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `patient`
--

INSERT INTO `patient` (`PatientNumber`, `FirstName`, `MiddleName`, `LastName`, `DateofRegistration`, `Attending_Physician`, `Purpose_of_Coming`, `Medicines_Received`, `BirthDate`, `Age`, `Gender`, `Address`, `ContactNumber`, `Height`, `Weight`, `BloodP`, `PatientIDName`) VALUES
(1, 'Brian', '\"Mayor\"', 'Irons', 'Dec,10,2019', 'Dr. William Birkin', 'Weekly Checkup', 'None', 'Jan,21,1998', 21, 'Male', 'Racoon City', '911', '6 ft', '60 kg', 'Normal (Less than 120)', 'brian-irons.png'),
(2, 'Jill', '\"Pro\"', 'Valentine', 'Dec,10,2019', 'Dr. Annette Birkin', 'Blood Pressure Check', 'None', 'Mar,22,1996', 23, 'Female', 'Racoon City', '1111-2222', '5.5 ft', '55 kg', 'Normal (Less than 120)', 'jill-valentine.png');

-- --------------------------------------------------------

--
-- Table structure for table `physician`
--

CREATE TABLE `physician` (
  `ID` int(100) NOT NULL,
  `doctorname` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `physician`
--

INSERT INTO `physician` (`ID`, `doctorname`) VALUES
(1, 'None'),
(2, 'Dr. Angela Ziegler'),
(3, 'Dr. William Birkin'),
(4, 'Dr. Annette Birkin'),
(9, 'Dr. Kirby');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `activate_admin`
--
ALTER TABLE `activate_admin`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `medicine`
--
ALTER TABLE `medicine`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `patient`
--
ALTER TABLE `patient`
  ADD PRIMARY KEY (`PatientNumber`);

--
-- Indexes for table `physician`
--
ALTER TABLE `physician`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `activate_admin`
--
ALTER TABLE `activate_admin`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;

--
-- AUTO_INCREMENT for table `medicine`
--
ALTER TABLE `medicine`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;

--
-- AUTO_INCREMENT for table `patient`
--
ALTER TABLE `patient`
  MODIFY `PatientNumber` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `physician`
--
ALTER TABLE `physician`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
