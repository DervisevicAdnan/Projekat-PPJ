/*
Navicat MySQL Data Transfer

Source Server         : sql
Source Server Version : 50018
Source Host           : localhost:3306
Source Database       : projektni_ppj

Target Server Type    : MYSQL
Target Server Version : 50018
File Encoding         : 65001

Date: 2022-04-28 11:38:40
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `artikal`
-- ----------------------------
DROP TABLE IF EXISTS `artikal`;
CREATE TABLE `artikal` (
  `artikal_id` int(11) NOT NULL auto_increment,
  `naziv_artikla` varchar(255) NOT NULL,
  `vrsta_artikla` varchar(255) default NULL,
  `cijena` double default NULL,
  PRIMARY KEY  (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of artikal
-- ----------------------------
INSERT INTO `artikal` VALUES ('1', 'hljeb', 'hljeb', '1');
INSERT INTO `artikal` VALUES ('2', 'Ulje', 'Hrana', '3');
INSERT INTO `artikal` VALUES ('3', 'Šećer', 'hrana', '2');

-- ----------------------------
-- Table structure for `kupac`
-- ----------------------------
DROP TABLE IF EXISTS `kupac`;
CREATE TABLE `kupac` (
  `kupac_id` int(11) NOT NULL auto_increment,
  `ime` varchar(50) NOT NULL,
  `prezime` varchar(100) NOT NULL,
  `grad` varchar(100) default NULL,
  `adresa` varchar(150) default NULL,
  `telefon` varchar(20) default NULL,
  `user` varchar(50) default NULL,
  `pass` varchar(50) default NULL,
  PRIMARY KEY  (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of kupac
-- ----------------------------
INSERT INTO `kupac` VALUES ('1', 'Adnan', 'Dervisevic', 'Sarajevo', 'Vojnicko polje', '060 00 00 000', 'admin', 'admin');
INSERT INTO `kupac` VALUES ('2', 'Bakir', 'Kustura', 'Sarajevo', 'Kolonija', '033 333 333', 'bake', 'bake123');
INSERT INTO `kupac` VALUES ('3', 'Adi', 'Drakovac', 'Sarajevo', 'Buća Potok', '061 111 111', 'adi', 'adi1');

-- ----------------------------
-- Table structure for `narudzbenica`
-- ----------------------------
DROP TABLE IF EXISTS `narudzbenica`;
CREATE TABLE `narudzbenica` (
  `narudzbenica_id` int(11) NOT NULL auto_increment,
  `kupac_id` int(11) NOT NULL,
  `datum_narudzbe` date NOT NULL,
  PRIMARY KEY  (`narudzbenica_id`),
  KEY `kupac` (`kupac_id`),
  CONSTRAINT `kupac` FOREIGN KEY (`kupac_id`) REFERENCES `kupac` (`kupac_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of narudzbenica
-- ----------------------------
INSERT INTO `narudzbenica` VALUES ('1', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('2', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('3', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('4', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('5', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('6', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('7', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('8', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('9', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('13', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('14', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('15', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('16', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('17', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('18', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('19', '1', '2022-04-04');
INSERT INTO `narudzbenica` VALUES ('20', '2', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('21', '2', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('22', '3', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('23', '3', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('24', '3', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('25', '3', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('26', '3', '2022-04-28');
INSERT INTO `narudzbenica` VALUES ('27', '3', '2022-04-28');

-- ----------------------------
-- Table structure for `skladiste`
-- ----------------------------
DROP TABLE IF EXISTS `skladiste`;
CREATE TABLE `skladiste` (
  `id` int(11) NOT NULL auto_increment,
  `artikal_id` int(11) default NULL,
  `kolicina_stanje` int(11) default NULL,
  PRIMARY KEY  (`id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `skladiste_ibfk_1` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of skladiste
-- ----------------------------
INSERT INTO `skladiste` VALUES ('1', '1', '8');
INSERT INTO `skladiste` VALUES ('2', '2', '22');
INSERT INTO `skladiste` VALUES ('3', '3', '9');

-- ----------------------------
-- Table structure for `stavka_narudzbenice`
-- ----------------------------
DROP TABLE IF EXISTS `stavka_narudzbenice`;
CREATE TABLE `stavka_narudzbenice` (
  `stavka_id` int(11) NOT NULL auto_increment,
  `narudzbenica_id` int(11) default NULL,
  `artikal_id` int(11) default NULL,
  `kolicina` int(11) default NULL,
  PRIMARY KEY  (`stavka_id`),
  KEY `narudzbenica_id` (`narudzbenica_id`),
  KEY `artikal_id` (`artikal_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_1` FOREIGN KEY (`narudzbenica_id`) REFERENCES `narudzbenica` (`narudzbenica_id`),
  CONSTRAINT `stavka_narudzbenice_ibfk_2` FOREIGN KEY (`artikal_id`) REFERENCES `artikal` (`artikal_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of stavka_narudzbenice
-- ----------------------------
INSERT INTO `stavka_narudzbenice` VALUES ('4', '14', '1', '2');
INSERT INTO `stavka_narudzbenice` VALUES ('5', '15', '1', '2');
INSERT INTO `stavka_narudzbenice` VALUES ('6', '16', '1', '3');
INSERT INTO `stavka_narudzbenice` VALUES ('7', '17', '1', '1');
INSERT INTO `stavka_narudzbenice` VALUES ('8', '18', '1', '2');
INSERT INTO `stavka_narudzbenice` VALUES ('9', '20', '2', '3');
INSERT INTO `stavka_narudzbenice` VALUES ('10', '20', '1', '5');
INSERT INTO `stavka_narudzbenice` VALUES ('12', '21', '1', '5');
INSERT INTO `stavka_narudzbenice` VALUES ('13', '21', '3', '2');
INSERT INTO `stavka_narudzbenice` VALUES ('14', '21', '2', '5');
INSERT INTO `stavka_narudzbenice` VALUES ('15', '22', '1', '5');
INSERT INTO `stavka_narudzbenice` VALUES ('16', '22', '3', '4');
INSERT INTO `stavka_narudzbenice` VALUES ('17', '23', '2', '20');
INSERT INTO `stavka_narudzbenice` VALUES ('23', '27', '2', '10');
