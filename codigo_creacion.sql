create database mydb character set UTF8;

USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Partido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Partido` (
  `id` INT NOT NULL,
  `equipo_visitante` VARCHAR(45) NOT NULL,
  `equipo_local` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Mercado`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Mercado` (
  `id` INT NOT NULL,
  `dinero_apostado_under` DECIMAL(2) NOT NULL,
  `dinero_apostado_over` DECIMAL(2) NOT NULL,
  `cuota_under` DECIMAL(2) NOT NULL,
  `cuota_over` DECIMAL(2) NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `id_partido` INT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `id_partido_idx` (`id_partido` ASC) ,
  CONSTRAINT `id_partido`
    FOREIGN KEY (`id_partido`)
    REFERENCES `mydb`.`Partido` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Usuario` (
  `email` VARCHAR(45) NOT NULL,
  `edad` INT NOT NULL,
  `nombre` VARCHAR(45) NOT NULL,
  `apellidos` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`email`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Apuesta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Apuesta` (
  `id` INT NOT NULL,
  `tipo` VARCHAR(45) NOT NULL,
  `cuota` DECIMAL(2) NOT NULL,
  `dinero_apostado` DECIMAL(2) NOT NULL,
  `id_mercado` INT NOT NULL,
  `email_usuario` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `id_mercado_idx` (`id_mercado` ASC) ,
  INDEX `email_usuario_idx` (`email_usuario` ASC) ,
  CONSTRAINT `id_mercado`
    FOREIGN KEY (`id_mercado`)
    REFERENCES `mydb`.`Mercado` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `email_usuario`
    FOREIGN KEY (`email_usuario`)
    REFERENCES `mydb`.`Usuario` (`email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Cuenta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Cuenta` (
  `nombre` VARCHAR(45) NOT NULL PRIMARY key,
  `num_tarjeta` VARCHAR(45) NOT NULL,
  `em_us` VARCHAR(45) NOT NULL,
  CONSTRAINT `em_us`
    FOREIGN KEY (`em_us`)
    REFERENCES `mydb`.`Usuario` (`email`)
	 )
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;