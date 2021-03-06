-- MySQL Script generated by MySQL Workbench
-- Wed Jun 24 22:41:40 2020
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema crmchoqmol
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema crmchoqmol
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `crmchoqmol` DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish2_ci ;
USE `crmchoqmol` ;

-- -----------------------------------------------------
-- Table `crmchoqmol`.`roles`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`roles` (
  `IdRol` INT NOT NULL AUTO_INCREMENT,
  `Rol` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`IdRol`),
  UNIQUE INDEX `IdRol_UNIQUE` (`IdRol` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`usuarios` (
  `CedulaUsuario` VARCHAR(20) NOT NULL,
  `NombreCompleto` VARCHAR(100) NOT NULL,
  `Correo` VARCHAR(50) NOT NULL,
  `Telefono` VARCHAR(50) NOT NULL,
  `Direccion` VARCHAR(100) NOT NULL,
  `Usuario` VARCHAR(100) NOT NULL,
  `Clave` VARCHAR(255) NOT NULL,
  `Estado` TINYINT(1) NULL,
  `IdRol` INT NOT NULL,
  PRIMARY KEY (`CedulaUsuario`),
  UNIQUE INDEX `CedulaUsuario_UNIQUE` (`CedulaUsuario` ASC) VISIBLE,
  INDEX `fk_usuarios_roles_idx` (`IdRol` ASC) VISIBLE,
  CONSTRAINT `fk_usuarios_roles`
    FOREIGN KEY (`IdRol`)
    REFERENCES `crmchoqmol`.`roles` (`IdRol`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`clientes`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`clientes` (
  `CedulaCliente` VARCHAR(20) NOT NULL,
  `NombreCompleto` VARCHAR(100) NOT NULL,
  `Telefono` VARCHAR(100) NOT NULL,
  `Direccion` VARCHAR(100) NOT NULL,
  `Correo` VARCHAR(100) NOT NULL,
  `TipoCliente` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`CedulaCliente`),
  UNIQUE INDEX `CedulaCliente_UNIQUE` (`CedulaCliente` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`pedidos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`pedidos` (
  `IdPedido` INT NOT NULL AUTO_INCREMENT,
  `FechaPedido` DATETIME NOT NULL,
  `FechaEntrega` DATETIME NULL,
  `Estado` TINYINT(1) NOT NULL,
  `ValorPedido` FLOAT NOT NULL,
  `CedulaUsuario` VARCHAR(20) NULL,
  `CedulaCliente` VARCHAR(20) NULL,
  PRIMARY KEY (`IdPedido`),
  UNIQUE INDEX `IdPedido_UNIQUE` (`IdPedido` ASC) VISIBLE,
  INDEX `fk_pedidos_clientes_idx` (`CedulaCliente` ASC) VISIBLE,
  INDEX `fk_pedidos_usuarios_idx` (`CedulaUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_pedidos_usuarios`
    FOREIGN KEY (`CedulaUsuario`)
    REFERENCES `crmchoqmol`.`usuarios` (`CedulaUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedidos_clientes`
    FOREIGN KEY (`CedulaCliente`)
    REFERENCES `crmchoqmol`.`clientes` (`CedulaCliente`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`productos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`productos` (
  `IdProducto` INT NOT NULL AUTO_INCREMENT,
  `NombreProducto` VARCHAR(100) NOT NULL,
  `Precio` FLOAT NOT NULL,
  `Estado` TINYINT(1) NOT NULL,
  `Tamaño` VARCHAR(20) NOT NULL,
  `` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`IdProducto`),
  UNIQUE INDEX `IdProducto_UNIQUE` (`IdProducto` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`pedidoproductos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`pedidoproductos` (
  `IdPedidoProducto` INT NOT NULL AUTO_INCREMENT,
  `IdPedido` INT NULL,
  `IdProducto` INT NULL,
  `Precio` FLOAT NULL,
  `Cantidad` INT NULL,
  `IdEntrada` INT NULL,
  PRIMARY KEY (`IdPedidoProducto`),
  INDEX `fk_pedidoproductos_productos_idx` (`IdProducto` ASC) VISIBLE,
  INDEX `fk_pedidoproductos_pedidos_idx` (`IdPedido` ASC) VISIBLE,
  CONSTRAINT `fk_pedidoproductos_productos`
    FOREIGN KEY (`IdProducto`)
    REFERENCES `crmchoqmol`.`productos` (`IdProducto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_pedidoproductos_pedidos`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `crmchoqmol`.`pedidos` (`IdPedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`entradas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`entradas` (
  `IdEntrada` INT NOT NULL AUTO_INCREMENT,
  `FechaEntrada` DATETIME NOT NULL,
  `Estado` TINYINT(1) NOT NULL,
  `CostoTotal` FLOAT NOT NULL,
  `FechaElaboracion` DATETIME NOT NULL,
  `FechaVencimiento` DATETIME NOT NULL,
  `Lote` VARCHAR(50) NOT NULL,
  `CedulaUsuario` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`IdEntrada`),
  UNIQUE INDEX `IdEntrada_UNIQUE` (`IdEntrada` ASC) VISIBLE,
  INDEX `fk_entradas_usuarios_idx` (`CedulaUsuario` ASC) VISIBLE,
  CONSTRAINT `fk_entradas_usuarios`
    FOREIGN KEY (`CedulaUsuario`)
    REFERENCES `crmchoqmol`.`usuarios` (`CedulaUsuario`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `crmchoqmol`.`entradaproductos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `crmchoqmol`.`entradaproductos` (
  `IdEntradaProductos` INT NOT NULL AUTO_INCREMENT,
  `IdEntrada` INT NULL,
  `IdProducto` INT NULL,
  `Cantidad` INT NULL,
  `CostoUnitario` FLOAT NULL,
  PRIMARY KEY (`IdEntradaProductos`),
  UNIQUE INDEX `IdEntradaProductos_UNIQUE` (`IdEntradaProductos` ASC) VISIBLE,
  INDEX `fk_entradaproductos_productos_idx` (`IdProducto` ASC) VISIBLE,
  INDEX `fk_entradaproductos_entradas_idx` (`IdEntrada` ASC) VISIBLE,
  CONSTRAINT `fk_entradaproductos_productos`
    FOREIGN KEY (`IdProducto`)
    REFERENCES `crmchoqmol`.`pedidos` (`IdPedido`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_entradaproductos_entradas`
    FOREIGN KEY (`IdEntrada`)
    REFERENCES `crmchoqmol`.`entradas` (`IdEntrada`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
