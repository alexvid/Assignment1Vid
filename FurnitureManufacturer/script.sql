CREATE TABLE `furnituremanufacturer`.`employee` (
   `ID` int(5)  NOT NULL auto_increment,
   `Username` varchar(45) DEFAULT NULL,
   `Password` varchar(45) DEFAULT NULL,
   `FirstName` varchar(45) DEFAULT NULL,
   `LastName` varchar(45) DEFAULT NULL,
   `Admin` boolean DEFAULT false,
   PRIMARY KEY (`ID`)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
 drop table `furnituremanufacturer`.`employee`;
 
 CREATE TABLE `furnituremanufacturer`.`product` (
   `ID` int(5)  NOT NULL auto_increment,
   `name` varchar(45) DEFAULT NULL,
   `price` varchar(45) DEFAULT NULL,
   `stock` int DEFAULT NULL,
   `description` varchar(300) DEFAULT NULL,
   PRIMARY KEY (`ID`)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
  drop table `furnituremanufacturer`.`product`;
  
   CREATE TABLE `furnituremanufacturer`.`order` (
   `ID` int(5)  NOT NULL auto_increment,
   `Customer` varchar(45) DEFAULT NULL,
   `Address` varchar(45) DEFAULT NULL,
   `DeliveryDate` date DEFAULT NULL,
   PRIMARY KEY (`ID`)
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
  drop table `furnituremanufacturer`.`order`;
  
   CREATE TABLE `OrderProducts` (
      `ID` int(5)  NOT NULL auto_increment,
   `IDOrder` int DEFAULT NULL,
   `IDProduct` int DEFAULT NULL,
   `Quantity` int DEFAULT NULL,
   KEY `IDOrder` (`IDOrder`),
   KEY `IDProduct` (`IDProduct`),
      PRIMARY KEY (`ID`),
   CONSTRAINT `IDOrder` FOREIGN KEY (`IDOrder`) REFERENCES `order` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
   CONSTRAINT `IDProduct` FOREIGN KEY (`IDProduct`) REFERENCES `product` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
 ) ENGINE=InnoDB DEFAULT CHARSET=utf8;
  drop table `furnituremanufacturer`.`OrderProducts`;
  
CREATE TABLE `history` (
`ID` int(5) NOT NULL auto_increment,
`IDEmployee` int DEFAULT NULL,
`IDOperation` int DEFAULT NULL,
`TableName` varchar(50) DEFAULT NULL,
`Date`date DEFAULT NULL,
KEY `IDEmployee` (`IDEmployee`),
PRIMARY KEY (`ID`),
CONSTRAINT `IDEmployee` FOREIGN KEY (`IDEmployee`) REFERENCES `employee` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
drop table `furnituremanufacturer`.`history`;

delimiter |
CREATE TRIGGER totalOrder before INSERT ON `OrderProducts`
	 FOR EACH ROW 
	
	 UPDATE `order` SET `order`.`Total`=(`order`.`Total`+NEW.`Quantity`*(select `price` FROM `product` where `product`.`ID`=NEW.`IDProduct`)) WHERE `order`.`ID`=NEW.`IDOrder`;
	
| delimiter ;




drop trigger totalOrder;
show triggers;
insert into `order`(`Customer`,`Address`,`DeliveryDate`) values('mirel','nu am casa','2002-02-01');


insert into `OrderProducts` values (1,1,2);








