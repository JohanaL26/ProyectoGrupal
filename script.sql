CREATE DATABASE ProyectoFinal

CREATE SCHEMA IF NOT EXISTS `proyectofinal` DEFAULT CHARACTER SET utf8 ;
USE `ProyectoFinal` ;


CREATE TABLE IF NOT EXISTS `proyectofinal`.`usuario` (
  `CodigoUsuario` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Rol` VARCHAR(15) NULL,
  `Clave` VARCHAR(45) NULL,
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








