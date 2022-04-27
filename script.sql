CREATE DATABASE ProyectoFinal
USE `ProyectoFinal` ;
CREATE SCHEMA IF NOT EXISTS `proyectofinal` DEFAULT CHARACTER SET utf8 ;




CREATE TABLE IF NOT EXISTS `proyectofinal`.`usuario` (
  `CodigoUsuario` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Rol` VARCHAR(15) NULL,
  `Clave` VARCHAR(45) NULL,
  `EstaActivo` tinyint,
  PRIMARY KEY (`CodigoUsuario`))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `proyectofinal`.`producto` (
  `CodigoProducto` VARCHAR(45) NOT NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Precio` DECIMAL(18,2) NULL,
  `Existencia` INT NULL,
  PRIMARY KEY (`CodigoProducto`))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `proyectofinal`.`factura` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `IdentidadCliente` VARCHAR(20) NULL DEFAULT NULL,
  `Cliente` VARCHAR(45) NULL DEFAULT NULL,
  `Fecha` TIMESTAMP NULL DEFAULT NULL,
  PRIMARY KEY (`Id`))
ENGINE = InnoDB


CREATE TABLE IF NOT EXISTS `proyectofinal`.`detalleFactura` (
  `Id` INT NOT NULL AUTO_INCREMENT,
  `IdFactura` INT NULL,
  `CodigoProducto` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Cantidad` INT NULL,
  `Precio` DECIMAL NULL,
  `Total` DECIMAL NULL,
  PRIMARY KEY (`Id`),
  INDEX `FK_detalleFactura_pedidos_idx` (`IdFactura` ASC) VISIBLE,
  INDEX `FK_detalleFactura_producto_idx` (`CodigoProducto` ASC) VISIBLE,
  CONSTRAINT `FK_detalleFactura_factura`
    FOREIGN KEY (`IdFactura`)
    REFERENCES `proyectofinal`.`factura` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_detalleFactura_producto`
    FOREIGN KEY (`CodigoProducto`)
    REFERENCES `proyectofinal`.`producto` (`CodigoProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

/*Inserts para la tabla de usuarios*/
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('SLARA', 'Seydi Lara', 'Administrador', '111', '1');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('LMEJIA', 'Luesbelin Mejia', 'Usuario', '222', '0');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('GGARCIA', 'Gerson Garcia', 'Administrador', '123', '1');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('EPAVON', 'Erick Pavon', 'Administrador', '456', '0');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('ECRUZ', 'Eleazar Cruz', 'Usuario', '125', '0');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('DVELASQUEZ', 'Dago Velasquez', 'Administrador', '789', '1');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('DOSORIO', 'Dallin Osorio', 'Administrador', '000', '1');
INSERT INTO `proyectofinal`.`usuario` (`CodigoUsuario`, `Nombre`, `Rol`, `Clave`, `EstaActivo`) VALUES ('CJEFF', 'Jeff Cocas', 'Usuario', '555', '0');

/*Inserts para la tabla de Productos*/
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A130', 'Cadena', '1100.00', '40');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A129', 'Velocimetro', '1400.00', '15');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A128', 'Escape', '800.00', '60');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A127', 'Volante', '2000.00', '23');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A126', 'Motor', '6000.00', '15');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A125', 'Lubricante', '350.00', '30');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A124', 'Rin', '1200.00', '100');
INSERT INTO `proyectofinal`.`producto` (`CodigoProducto`, `Descripcion`, `Precio`, `Existencia`) VALUES ('A123', 'Casco', '1500.00', '50');

/*Inserts para la tabla de Detalle Factura*/
INSERT INTO `proyectofinal`.`detallefactura` (`IdFactura`, `CodigoProducto`, `Descripcion`, `Cantidad`, `Precio`, `Total`) VALUES ('1', 'A130', 'Cadena', '1', '1100.00','1100.00');
INSERT INTO `proyectofinal`.`detallefactura` (`IdFactura`, `CodigoProducto`, `Descripcion`, `Cantidad`, `Precio`, `Total`) VALUES ('2', 'A130', 'Velocimetro', '1', '1400.00','1400.00');