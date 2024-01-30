-- MySQL dump 10.13  Distrib 8.0.18, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: library
-- ------------------------------------------------------
-- Server version	8.0.18

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
-- Table structure for table `loaninfo`
--

DROP TABLE IF EXISTS `loaninfo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loaninfo` (
  `BookNum` char(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BookName` char(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Borrower` char(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `BorrowTime` datetime NOT NULL,
  `ShouldReturnTime` datetime DEFAULT NULL,
  `IsReturn` char(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ReturnTime` datetime DEFAULT NULL,
  `Punishment` int(10) DEFAULT '0',
  `IsBroken` char(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT '否',
  `IsLost` char(10) DEFAULT NULL,
  `IsOverTime` char(10) DEFAULT NULL,
  PRIMARY KEY (`Borrower`,`BorrowTime`),
  KEY `书名` (`BookName`,`BookNum`),
  CONSTRAINT `loaninfo_ibfk_2` FOREIGN KEY (`Borrower`) REFERENCES `user_info` (`UserName`) ON DELETE RESTRICT ON UPDATE RESTRICT
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loaninfo`
--

LOCK TABLES `loaninfo` WRITE;
/*!40000 ALTER TABLE `loaninfo` DISABLE KEYS */;
INSERT INTO `loaninfo` VALUES ('a','大学物理实验','1','2024-01-26 00:35:58','2024-02-26 00:35:58','是',NULL,200,'是','是','否'),('1','zzz','1','2024-01-26 00:44:31','2024-02-26 00:44:31','是','2024-01-26 00:44:52',0,'否','否','否'),('2','22222222','1','2024-01-26 00:44:37','2024-02-26 00:44:37','是',NULL,500,'是','是','否'),('1','zzz','9','2024-01-26 01:54:13','2024-02-26 01:54:13','是','2024-01-26 02:28:22',0,'否','否','否'),('2','22222222','9','2024-01-26 02:27:26','2024-02-26 02:27:26','否',NULL,500,'是','是','否');
/*!40000 ALTER TABLE `loaninfo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-26  4:14:50
