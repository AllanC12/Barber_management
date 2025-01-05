-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: barber_admin
-- ------------------------------------------------------
-- Server version	8.0.37

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
-- Table structure for table `clients`
--

DROP TABLE IF EXISTS `clients`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `clients` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `LastName` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Birthday` date NOT NULL,
  `Address` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Favorite_Service` varchar(100) DEFAULT NULL,
  `Observation` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `clients`
--

LOCK TABLES `clients` WRITE;
/*!40000 ALTER TABLE `clients` DISABLE KEYS */;
INSERT INTO `clients` VALUES (1,'Allan','Candido','2000-03-12','Avenida Manuel Fernandes Lima ','low fade','Nunca passar máquina abaixo de 1.5'),(2,'Alice','Silva','1990-05-14','Rua das Flores, 123, São Paulo','Corte de cabelo','Cliente fiel, visita mensalmente'),(3,'João','Souza','1985-12-21','Avenida Brasil, 456, Rio de Janeiro','Manicure','Prefere horários matutinos'),(4,'Maria','Oliveira','1992-08-10','Rua Principal, 789, Belo Horizonte','Pedicure','Alérgica a produtos com fragrância forte'),(5,'Pedro','Santos','1988-03-05','Travessa do Sol, 101, Curitiba','Corte de barba','Reclama de atrasos frequentes'),(6,'Julia','Ferreira','1995-07-22','Praça das Árvores, 234, Salvador','Maquiagem','Solicita maquiagens naturais'),(7,'Carlos','Lima','1980-11-30','Rua Verde, 567, Porto Alegre','Massagem','Prefere massagem relaxante'),(8,'Ana','Costa','1993-04-18','Avenida das Nações, 890, Brasília','Tratamento capilar','Cliente nova, indicada por outra cliente'),(9,'Lucas','Pereira','1987-09-12','Rua Azul, 345, Recife','Corte infantil','Leva os filhos para atendimento'),(10,'Fernanda','Barbosa','1991-06-25','Rua Amarela, 678, Fortaleza','Spa facial','Prefere horários vespertinos'),(11,'Roberto','Gomes','1984-01-15','Avenida Central, 901, Manaus','Tintura capilar','Sempre solicita tons de castanho escuro'),(12,'Roberto','Mata','1969-03-12','Avenida Central, 123, Manaus','Barba','Sempre chega atrasado');
/*!40000 ALTER TABLE `clients` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-01-05 16:57:59
