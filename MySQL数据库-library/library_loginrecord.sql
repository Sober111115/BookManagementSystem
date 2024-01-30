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
-- Table structure for table `loginrecord`
--

DROP TABLE IF EXISTS `loginrecord`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `loginrecord` (
  `UserName` char(10) DEFAULT NULL,
  `LoginTime` char(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `loginrecord`
--

LOCK TABLES `loginrecord` WRITE;
/*!40000 ALTER TABLE `loginrecord` DISABLE KEYS */;
INSERT INTO `loginrecord` VALUES ('1','2024年1月25日 18:57:48'),('2','2024年1月25日 18:59:35'),('999','2024年1月25日 18:59:44'),('999','2024年1月25日 19:03:11'),('999','2024年1月25日 19:03:18'),('1','2024年1月25日 19:04:43'),('2','2024年1月25日 19:06:11'),('999','2024年1月25日 19:06:28'),('999','2024年1月25日 19:09:49'),('999','2024年1月25日 22:35:33'),('999','2024年1月25日 22:46:28'),('999','2024年1月25日 22:58:11'),('999','2024年1月25日 23:02:17'),('999','2024年1月25日 23:02:47'),('1','2024年1月25日 23:56:34'),('3','2024年1月25日 23:58:11'),('999','2024年1月25日 23:58:20'),('999','2024年1月26日 0:05:49'),('999','2024年1月26日 0:09:23'),('999','2024年1月26日 0:14:43'),('999','2024年1月26日 0:14:49'),('1','2024年1月26日 0:24:28'),('3','2024年1月26日 0:26:05'),('888','2024年1月26日 0:26:15'),('888','2024年1月26日 0:29:19'),('888','2024年1月26日 0:29:52'),('1','2024年1月26日 0:35:24'),('2','2024年1月26日 0:37:05'),('999','2024年1月26日 0:37:15'),('1','2024年1月26日 0:44:01'),('2','2024年1月26日 0:45:41'),('999','2024年1月26日 0:45:53'),('999','2024年1月26日 0:45:58'),('999','2024年1月26日 0:49:25'),('2','2024年1月26日 1:22:36'),('999','2024年1月26日 1:23:26'),('2','2024年1月26日 1:50:39'),('5','2024年1月26日 1:51:29'),('5','2024年1月26日 1:52:11'),('9','2024年1月26日 1:52:59'),('999','2024年1月26日 2:30:56'),('999','2024年1月26日 3:09:09');
/*!40000 ALTER TABLE `loginrecord` ENABLE KEYS */;
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
