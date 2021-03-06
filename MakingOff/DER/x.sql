-- MySQL Script generated by MySQL Workbench
-- Mon Nov  6 23:05:35 2017
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering


-- -----------------------------------------------------
-- Table `mydb`.`palestrante`
-- -----------------------------------------------------
CREATE TABLE `palestrante` (
  `idpalestrante` INT NOT NULL AUTO_INCREMENT,
  `codPalestrante` VARCHAR(45) NOT NULL,
  `nomePalestrante` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`idpalestrante`))



-- -----------------------------------------------------
-- Table `mydb`.`titulacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`titulacao` (
  `idtitulacao` INT NOT NULL AUTO_INCREMENT,
  `codTitulacao` VARCHAR(45) NOT NULL,
  `nomeTitulacao` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`codTitulacao`),
  UNIQUE INDEX `idtitulacao_UNIQUE` (`idtitulacao` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`titulos`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`titulos` (
  `idtitulos` INT NOT NULL,
  `NomeIntituicaoTitulo` VARCHAR(255) NOT NULL,
  `dataTitulo` DATETIME NOT NULL,
  `titulacao_codTitulacao` VARCHAR(45) NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  PRIMARY KEY (`idtitulos`),
  INDEX `fk_titulos_titulacao_idx` (`titulacao_codTitulacao` ASC),
  INDEX `fk_titulos_palestrante1_idx` (`palestrante_idpalestrante` ASC),
  CONSTRAINT `fk_titulos_titulacao`
    FOREIGN KEY (`titulacao_codTitulacao`)
    REFERENCES `mydb`.`titulacao` (`codTitulacao`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_titulos_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `mydb`.`palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`cidades`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`cidades` (
  `idcidades` INT NOT NULL,
  `codCidade` INT NOT NULL,
  `nomeCidade` VARCHAR(255) NULL,
  `uf` VARCHAR(3) NULL,
  PRIMARY KEY (`codCidade`),
  UNIQUE INDEX `idcidades_UNIQUE` (`idcidades` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`infoPalestrante`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`infoPalestrante` (
  `idinfoPalestrante` INT NOT NULL,
  `telefoneFixo` VARCHAR(12) NULL,
  `celular` VARCHAR(13) NULL,
  `email` VARCHAR(100) NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  `cidades_codCidade` INT NOT NULL,
  PRIMARY KEY (`idinfoPalestrante`),
  INDEX `fk_informacoes_palestrante1_idx` (`palestrante_idpalestrante` ASC),
  INDEX `fk_informacoes_cidades1_idx` (`cidades_codCidade` ASC),
  CONSTRAINT `fk_informacoes_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `mydb`.`palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_informacoes_cidades1`
    FOREIGN KEY (`cidades_codCidade`)
    REFERENCES `mydb`.`cidades` (`codCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`perfil` (
  `idperfil` INT NOT NULL,
  `codPerfil` INT NOT NULL,
  `nomePerfil` VARCHAR(100) NOT NULL,
  `descricao` TEXT NULL,
  PRIMARY KEY (`codPerfil`),
  UNIQUE INDEX `idperfil_UNIQUE` (`idperfil` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`usuarios`
-- -----------------------------------------------------
CREATE TABLE `usuarios` (
  `idusuarios` INTEGER,
  `codUsuario` INT NULL,
  `ativo` BIT(1) NOT NULL,
  `nomeUsuario` VARCHAR(100) NULL,
  `email` VARCHAR(100) NULL,
  `username` VARCHAR(100) NOT NULL unique,
  `passwd` VARCHAR(255) NOT NULL,
  `perfil_codPerfil` INT NOT NULL,
   PRIMARY KEY (`idusuarios`),
  CONSTRAINT `fk_usuarios_perfil1_idx`,
  CONSTRAINT `username_UNIQUE` UNIQUE (`username` ASC),
  CONSTRAINT `fk_usuarios_perfil1`
    FOREIGN KEY (`perfil_codPerfil`)
    REFERENCES `perfil` (`codPerfil`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)


-- -----------------------------------------------------
-- Table `mydb`.`periodo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`periodo` (
  `idperiodo` INT NOT NULL,
  `codPeriodo` INT NOT NULL,
  `nomePeriodo` VARCHAR(100) NOT NULL,
  `descricao` TEXT NULL,
  PRIMARY KEY (`codPeriodo`),
  UNIQUE INDEX `idperiodo_UNIQUE` (`idperiodo` ASC))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`curso` (
  `idcurso` INT NOT NULL,
  `codCurso` INT NOT NULL,
  `nomeCurso` VARCHAR(255) NOT NULL,
  `instituicaoCurso` VARCHAR(255) NOT NULL,
  `cidades_codCidade` INT NOT NULL,
  PRIMARY KEY (`codCurso`),
  UNIQUE INDEX `idcurso_UNIQUE` (`idcurso` ASC),
  INDEX `fk_curso_cidades1_idx` (`cidades_codCidade` ASC),
  CONSTRAINT `fk_curso_cidades1`
    FOREIGN KEY (`cidades_codCidade`)
    REFERENCES `mydb`.`cidades` (`codCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`infoUser`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`infoUser` (
  `idinfoUser` INT NOT NULL,
  `cpf` VARCHAR(15) NULL,
  `usuarios_idusuarios` INT NOT NULL,
  `periodo_codPeriodo` INT NOT NULL,
  `curso_codCurso` INT NOT NULL,
  PRIMARY KEY (`idinfoUser`),
  INDEX `fk_infoUser_usuarios1_idx` (`usuarios_idusuarios` ASC),
  INDEX `fk_infoUser_periodo1_idx` (`periodo_codPeriodo` ASC),
  INDEX `fk_infoUser_curso1_idx` (`curso_codCurso` ASC),
  CONSTRAINT `fk_infoUser_usuarios1`
    FOREIGN KEY (`usuarios_idusuarios`)
    REFERENCES `mydb`.`usuarios` (`idusuarios`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_infoUser_periodo1`
    FOREIGN KEY (`periodo_codPeriodo`)
    REFERENCES `mydb`.`periodo` (`codPeriodo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_infoUser_curso1`
    FOREIGN KEY (`curso_codCurso`)
    REFERENCES `mydb`.`curso` (`codCurso`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`evento`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`evento` (
  `idevento` INT NOT NULL,
  `titutloEvento` VARCHAR(255) NOT NULL,
  `dataEvento` DATE NOT NULL,
  `horarioInicial` DATETIME NOT NULL,
  `horarioFinal` DATETIME NOT NULL,
  `usuarios_idusuarios` INT NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  PRIMARY KEY (`idevento`),
  INDEX `fk_evento_usuarios1_idx` (`usuarios_idusuarios` ASC),
  INDEX `fk_evento_palestrante1_idx` (`palestrante_idpalestrante` ASC),
  CONSTRAINT `fk_evento_usuarios1`
    FOREIGN KEY (`usuarios_idusuarios`)
    REFERENCES `mydb`.`usuarios` (`idusuarios`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_evento_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `mydb`.`palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`inscricao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`inscricao` (
  `idinscricao` INT NOT NULL,
  `codInscricao` VARCHAR(255) NOT NULL,
  `usuarios_idusuarios` INT NOT NULL,
  `evento_idevento` INT NOT NULL,
  PRIMARY KEY (`idinscricao`),
  INDEX `fk_inscricao_usuarios1_idx` (`usuarios_idusuarios` ASC),
  INDEX `fk_inscricao_evento1_idx` (`evento_idevento` ASC),
  CONSTRAINT `fk_inscricao_usuarios1`
    FOREIGN KEY (`usuarios_idusuarios`)
    REFERENCES `mydb`.`usuarios` (`idusuarios`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_inscricao_evento1`
    FOREIGN KEY (`evento_idevento`)
    REFERENCES `mydb`.`evento` (`idevento`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
