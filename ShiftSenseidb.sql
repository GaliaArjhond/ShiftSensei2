-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: shiftsenseidb
-- ------------------------------------------------------
-- Server version	8.0.40

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admin`
--

DROP TABLE IF EXISTS `admin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `admin` (
  `adminId` int NOT NULL AUTO_INCREMENT,
  `adminLicense` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) DEFAULT NULL,
  `phoneNumber` int DEFAULT NULL,
  PRIMARY KEY (`adminId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admin`
--

LOCK TABLES `admin` WRITE;
/*!40000 ALTER TABLE `admin` DISABLE KEYS */;
/*!40000 ALTER TABLE `admin` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `deletionlogs`
--

DROP TABLE IF EXISTS `deletionlogs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `deletionlogs` (
  `logId` int NOT NULL AUTO_INCREMENT,
  `nurseId` int NOT NULL,
  `reason` text NOT NULL,
  `deletionDate` datetime NOT NULL,
  PRIMARY KEY (`logId`),
  KEY `nurseId` (`nurseId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `deletionlogs`
--

LOCK TABLES `deletionlogs` WRITE;
/*!40000 ALTER TABLE `deletionlogs` DISABLE KEYS */;
INSERT INTO `deletionlogs` VALUES (7,0,'','2024-12-08 03:27:04'),(8,0,'','2024-12-08 03:27:38'),(9,0,'','2024-12-08 05:21:24'),(10,0,'','2024-12-08 05:22:06');
/*!40000 ALTER TABLE `deletionlogs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `department`
--

DROP TABLE IF EXISTS `department`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `department` (
  `departmentId` int NOT NULL AUTO_INCREMENT,
  `departmentName` varchar(100) NOT NULL,
  PRIMARY KEY (`departmentId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `department`
--

LOCK TABLES `department` WRITE;
/*!40000 ALTER TABLE `department` DISABLE KEYS */;
INSERT INTO `department` VALUES (1,'Emergency Room (ER)'),(2,'Intensive Care Unit (ICU)'),(3,'Surgical Department (OR)'),(4,'Maternity Ward (MW)'),(5,'Pediatrics (PED)'),(6,'Cardiology (CAR)'),(7,'Oncology (ONC)'),(8,'Orthopedics (ORT)'),(9,'Neonatal Intensive Care Unit (NICU)'),(10,'Psychiatry(PSY)');
/*!40000 ALTER TABLE `department` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `explvls`
--

DROP TABLE IF EXISTS `explvls`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `explvls` (
  `expLvlsId` int NOT NULL AUTO_INCREMENT,
  `levelName` varchar(100) NOT NULL,
  PRIMARY KEY (`expLvlsId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `explvls`
--

LOCK TABLES `explvls` WRITE;
/*!40000 ALTER TABLE `explvls` DISABLE KEYS */;
INSERT INTO `explvls` VALUES (1,'Entry-Level (EL)'),(2,'Junior Nurse (JN)'),(3,'Intermediate Nurse (IN)'),(4,'Senior Nurse (SN)'),(5,'Expert Nurse (EN)'),(6,'Nurse Practitioner (NP)'),(7,'Clinical Nurse Specialist (CNS)');
/*!40000 ALTER TABLE `explvls` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nurse`
--

DROP TABLE IF EXISTS `nurse`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nurse` (
  `nurseId` int NOT NULL AUTO_INCREMENT,
  `nurseLicense` varchar(50) NOT NULL,
  `passwordHash` varchar(100) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `mname` varchar(50) DEFAULT NULL,
  `Lname` varchar(50) NOT NULL,
  `email` varchar(250) NOT NULL,
  `address` text,
  `phoneNumber` varchar(15) DEFAULT NULL,
  `dateOfBirth` datetime DEFAULT NULL,
  `bio` text,
  `gender` enum('Male','Female','Other') DEFAULT NULL,
  `SecurityQuestionId` int DEFAULT NULL,
  `SecurityAnswerHash` varchar(255) DEFAULT NULL,
  `expLvlsId` int DEFAULT NULL,
  `departmentId` int DEFAULT NULL,
  `positionId` int DEFAULT NULL,
  `isActive` tinyint(1) DEFAULT '1',
  `createAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updateAt` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  `startDate` date DEFAULT NULL,
  `endDate` date DEFAULT NULL,
  `startTime` time DEFAULT NULL,
  `endTime` time DEFAULT NULL,
  `shiftassignmentID` int DEFAULT NULL,
  PRIMARY KEY (`nurseId`),
  UNIQUE KEY `email` (`email`),
  KEY `expLvlsId` (`expLvlsId`),
  KEY `departmentId` (`departmentId`),
  KEY `positionId` (`positionId`),
  KEY `SecurityQuestionId` (`SecurityQuestionId`),
  KEY `fk_shiftassignment` (`shiftassignmentID`),
  CONSTRAINT `fk_shiftassignment` FOREIGN KEY (`shiftassignmentID`) REFERENCES `shifts` (`shiftId`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `nurse_ibfk_1` FOREIGN KEY (`expLvlsId`) REFERENCES `explvls` (`expLvlsId`),
  CONSTRAINT `nurse_ibfk_2` FOREIGN KEY (`departmentId`) REFERENCES `department` (`departmentId`),
  CONSTRAINT `nurse_ibfk_3` FOREIGN KEY (`positionId`) REFERENCES `position` (`positionId`),
  CONSTRAINT `nurse_ibfk_4` FOREIGN KEY (`SecurityQuestionId`) REFERENCES `securityquestion` (`securityQuestionId`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nurse`
--

LOCK TABLES `nurse` WRITE;
/*!40000 ALTER TABLE `nurse` DISABLE KEYS */;
/*!40000 ALTER TABLE `nurse` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `position`
--

DROP TABLE IF EXISTS `position`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `position` (
  `positionId` int NOT NULL AUTO_INCREMENT,
  `positionName` varchar(100) NOT NULL,
  PRIMARY KEY (`positionId`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `position`
--

LOCK TABLES `position` WRITE;
/*!40000 ALTER TABLE `position` DISABLE KEYS */;
INSERT INTO `position` VALUES (1,'Registered Nurse (RN)'),(2,'Nurse Practitioner (NP)'),(3,'Charge Nurse(CN)'),(4,'Head Nurse(HN)'),(5,'Clinical Nurse Specialist (CNS)'),(6,'Licensed Practical Nurse (LPN)'),(7,'Nursing Assistant (CNA)'),(8,'Nurse Anesthetist (CRNA)'),(9,'Operating Room Nurse (Perioperative Nurse)'),(10,'Nurse Educator (NE)');
/*!40000 ALTER TABLE `position` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `securityquestion`
--

DROP TABLE IF EXISTS `securityquestion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `securityquestion` (
  `securityQuestionId` int NOT NULL AUTO_INCREMENT,
  `SecurityQuestion` varchar(250) NOT NULL,
  PRIMARY KEY (`securityQuestionId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `securityquestion`
--

LOCK TABLES `securityquestion` WRITE;
/*!40000 ALTER TABLE `securityquestion` DISABLE KEYS */;
INSERT INTO `securityquestion` VALUES (1,'What is your mother\'s maiden name?'),(2,'What was the name of your first pet?'),(3,'What is the name of the city where you were born?'),(4,'What is your favorite color?'),(5,'What was the make and model of your first car?'),(6,'What was the name of your elementary school?');
/*!40000 ALTER TABLE `securityquestion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shiftassignments`
--

DROP TABLE IF EXISTS `shiftassignments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shiftassignments` (
  `assignmentId` int NOT NULL AUTO_INCREMENT,
  `nurseId` int DEFAULT NULL,
  `shiftId` int DEFAULT NULL,
  `status` enum('Assigned','Unassigned') DEFAULT 'Unassigned',
  `assignedDate` date DEFAULT NULL,
  PRIMARY KEY (`assignmentId`),
  KEY `nurseId` (`nurseId`),
  KEY `shiftId` (`shiftId`),
  CONSTRAINT `shiftassignments_ibfk_1` FOREIGN KEY (`nurseId`) REFERENCES `nurse` (`nurseId`),
  CONSTRAINT `shiftassignments_ibfk_2` FOREIGN KEY (`shiftId`) REFERENCES `shifts` (`shiftId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shiftassignments`
--

LOCK TABLES `shiftassignments` WRITE;
/*!40000 ALTER TABLE `shiftassignments` DISABLE KEYS */;
/*!40000 ALTER TABLE `shiftassignments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shifts`
--

DROP TABLE IF EXISTS `shifts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shifts` (
  `shiftId` int NOT NULL AUTO_INCREMENT,
  `nurseId` int DEFAULT NULL,
  `shiftName` varchar(100) DEFAULT NULL,
  `startDate` datetime DEFAULT NULL,
  `endDate` datetime DEFAULT NULL,
  `startTime` time DEFAULT NULL,
  `endTime` time DEFAULT NULL,
  `departmentId` int DEFAULT NULL,
  `fairDistributionChecked` tinyint(1) DEFAULT NULL,
  `shiftTypeId` int DEFAULT NULL,
  PRIMARY KEY (`shiftId`),
  KEY `nurseId` (`nurseId`),
  KEY `fk_department` (`departmentId`),
  KEY `fk_shiftType` (`shiftTypeId`),
  CONSTRAINT `fk_department` FOREIGN KEY (`departmentId`) REFERENCES `department` (`departmentId`),
  CONSTRAINT `fk_shiftType` FOREIGN KEY (`shiftTypeId`) REFERENCES `shifttype` (`shiftId`),
  CONSTRAINT `shifts_ibfk_1` FOREIGN KEY (`nurseId`) REFERENCES `nurse` (`nurseId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shifts`
--

LOCK TABLES `shifts` WRITE;
/*!40000 ALTER TABLE `shifts` DISABLE KEYS */;
/*!40000 ALTER TABLE `shifts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shifttype`
--

DROP TABLE IF EXISTS `shifttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shifttype` (
  `shiftId` int NOT NULL AUTO_INCREMENT,
  `shiftTypeName` varchar(100) NOT NULL,
  PRIMARY KEY (`shiftId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shifttype`
--

LOCK TABLES `shifttype` WRITE;
/*!40000 ALTER TABLE `shifttype` DISABLE KEYS */;
INSERT INTO `shifttype` VALUES (1,'Day'),(2,'Night'),(3,'Evening');
/*!40000 ALTER TABLE `shifttype` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-12-09 21:00:22
