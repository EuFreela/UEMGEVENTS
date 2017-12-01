--
-- File generated with SQLiteStudio v3.1.1 on ter nov 7 20:45:35 2017
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: cidades
CREATE TABLE `cidades` (
  `idcidades` INTEGER AUTO_INCREMENT,
  `codCidade` INT NOT NULL,
  `nomeCidade` VARCHAR(255) NULL,
  `uf` VARCHAR(3) NULL,
  PRIMARY KEY (`codCidade`),
   CONSTRAINT `idcidades_UNIQUE`  UNIQUE (`idcidades` ASC));
INSERT INTO cidades (idcidades, codCidade, nomeCidade, uf) VALUES (1, 1, 'Passos', 'MG');

-- Table: curso
CREATE TABLE `curso` (
  `idcurso` INTEGER AUTO_INCREMENT,
  `codCurso` INT NOT NULL,
  `nomeCurso` VARCHAR(255) NOT NULL,
  `instituicaoCurso` VARCHAR(255) NOT NULL,
  `cidades_codCidade` INT NOT NULL,
  PRIMARY KEY (`codCurso`),
   CONSTRAINT   `idcurso_UNIQUE` UNIQUE (`idcurso` ASC),
   CONSTRAINT  `fk_curso_cidades1_idx` UNIQUE (`cidades_codCidade` ASC),
  CONSTRAINT `fk_curso_cidades1`
    FOREIGN KEY (`cidades_codCidade`)
    REFERENCES `cidades` (`codCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
INSERT INTO curso (idcurso, codCurso, nomeCurso, instituicaoCurso, cidades_codCidade) VALUES (1, 1, 'Sistemas de Informação', 'UEMG', 1);

-- Table: evento
CREATE TABLE `evento` (
  `idevento` INT NOT NULL,
  `titutloEvento` VARCHAR(255) NOT NULL,
  `dataEvento` DATE NOT NULL,
  `horarioInicial` DATETIME NOT NULL,
  `horarioFinal` DATETIME NOT NULL,
  `usuarios_idusuarios` INT NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  PRIMARY KEY (`idevento`),
  CONSTRAINT `fk_evento_usuarios1_idx` UNIQUE (`usuarios_idusuarios` ASC),
  CONSTRAINT `fk_evento_palestrante1_idx` UNIQUE (`palestrante_idpalestrante` ASC),
  CONSTRAINT `fk_evento_usuarios1`
    FOREIGN KEY (`usuarios_idusuarios`)
    REFERENCES `usuarios` (`idusuarios`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_evento_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION);

-- Table: infoPalestrante
CREATE TABLE `infoPalestrante` (
  `idinfoPalestrante` INTEGER AUTO_INCREMENT,
  `telefoneFixo` VARCHAR(12) NULL,
  `celular` VARCHAR(13) NULL,
  `email` VARCHAR(100) NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  `cidades_codCidade` INT NOT NULL,
  PRIMARY KEY (`idinfoPalestrante`),
   CONSTRAINT `fk_informacoes_palestrante1_idx`  UNIQUE (`palestrante_idpalestrante` ASC),
   CONSTRAINT `fk_informacoes_cidades1_idx`  UNIQUE (`cidades_codCidade` ASC),
  CONSTRAINT `fk_informacoes_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_informacoes_cidades1`
    FOREIGN KEY (`cidades_codCidade`)
    REFERENCES `cidades` (`codCidade`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);

-- Table: inscricao
CREATE TABLE `inscricao` (
  `idinscricao` INT NOT NULL,
  `codInscricao` VARCHAR(255) NOT NULL,
  `usuarios_idusuarios` INT NOT NULL,
  `evento_idevento` INT NOT NULL,
  PRIMARY KEY (`idinscricao`),
  CONSTRAINT `fk_inscricao_usuarios1_idx` UNIQUE (`usuarios_idusuarios` ASC),
  CONSTRAINT `fk_inscricao_evento1_idx` UNIQUE (`evento_idevento` ASC),
  CONSTRAINT `fk_inscricao_usuarios1`
    FOREIGN KEY (`usuarios_idusuarios`)
    REFERENCES `usuarios` (`idusuarios`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_inscricao_evento1`
    FOREIGN KEY (`evento_idevento`)
    REFERENCES `evento` (`idevento`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION);

-- Table: palestrante
CREATE TABLE `palestrante` (
  `idpalestrante` INTEGER AUTO_INCREMENT,
  `codPalestrante` VARCHAR(45) NOT NULL,
  `nomePalestrante` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`idpalestrante`));

-- Table: perfil
CREATE TABLE `perfil` (
  `idperfil` INTEGER AUTO_INCREMENT,
  `codPerfil` INT NOT NULL,
  `nomePerfil` VARCHAR(100) NOT NULL,
  `descricao` TEXT NULL,
  PRIMARY KEY (`codPerfil`),
  CONSTRAINT `idperfil_UNIQUE`  UNIQUE (`idperfil` ASC));
INSERT INTO perfil (idperfil, codPerfil, nomePerfil, descricao) VALUES (2, 2, 'Aluno', NULL);
INSERT INTO perfil (idperfil, codPerfil, nomePerfil, descricao) VALUES (1, 1, 'Administrador', NULL);

-- Table: periodo
CREATE TABLE `periodo` (
  `idperiodo`  INTEGER AUTO_INCREMENT,
  `codPeriodo` INT NOT NULL,
  `nomePeriodo` VARCHAR(100) NOT NULL,
  `descricao` TEXT NULL,
  PRIMARY KEY (`codPeriodo`),
   CONSTRAINT `idperiodo_UNIQUE` UNIQUE (`idperiodo` ASC));
INSERT INTO periodo (idperiodo, codPeriodo, nomePeriodo, descricao) VALUES (1, 1, '1º Príodo', 'Primeiro Período');
INSERT INTO periodo (idperiodo, codPeriodo, nomePeriodo, descricao) VALUES (4, 4, '4º Periodo', 'Quarto Período');
INSERT INTO periodo (idperiodo, codPeriodo, nomePeriodo, descricao) VALUES (3, 3, '3º Período', 'Terceiro Período');
INSERT INTO periodo (idperiodo, codPeriodo, nomePeriodo, descricao) VALUES (2, 2, '2º Período', 'Segundo Período');

-- Table: teste
CREATE TABLE teste (id INT PRIMARY KEY, nome VARCHAR (255));
INSERT INTO teste (id, nome) VALUES (1, 'mmmmm');

-- Table: titulacao
CREATE TABLE `titulacao` (
  `idtitulacao` INTEGER AUTO_INCREMENT,
  `codTitulacao` VARCHAR(45) NOT NULL,
  `nomeTitulacao` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`codTitulacao`),
  CONSTRAINT `idtitulacao_UNIQUE` UNIQUE (`idtitulacao` ASC));
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (5, '5', 'Pós Doutorado');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (4, '4', 'Doutor');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (3, '3', 'Mestrado');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (2, '2', 'Bacharelado');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (1, '1', 'Nenhum título');

-- Table: titulos
CREATE TABLE `titulos` (
  `idtitulos` INTEGER AUTO_INCREMENT,
  `NomeIntituicaoTitulo` VARCHAR(255) NOT NULL,
  `dataTitulo` DATETIME NOT NULL,
  `titulacao_codTitulacao` VARCHAR(45) NOT NULL,
  `palestrante_idpalestrante` INT NOT NULL,
  PRIMARY KEY (`idtitulos`),
   CONSTRAINT `fk_titulos_titulacao_idx` UNIQUE (`titulacao_codTitulacao` ASC),
   CONSTRAINT `fk_titulos_palestrante1_idx` UNIQUE  (`palestrante_idpalestrante` ASC),
  CONSTRAINT `fk_titulos_titulacao`
    FOREIGN KEY (`titulacao_codTitulacao`)
    REFERENCES `titulacao` (`codTitulacao`)
    CONSTRAINT `fk_titulos_palestrante1`
    FOREIGN KEY (`palestrante_idpalestrante`)
    REFERENCES `palestrante` (`idpalestrante`)
    ON DELETE RESTRICT
    ON UPDATE NO ACTION);

-- Table: usuarios
CREATE TABLE usuarios (idusuarios INTEGER PRIMARY KEY AUTOINCREMENT, ativo BIT (1) NOT NULL, nomeUsuario VARCHAR (100), email VARCHAR (100) UNIQUE, username VARCHAR (100) NOT NULL UNIQUE, passwd VARCHAR (255) NOT NULL, perfil_codPerfil INT NOT NULL, CONSTRAINT fk_usuarios_perfil1_idx UNIQUE (username ASC), CONSTRAINT fk_usuarios_perfil1 FOREIGN KEY (perfil_codPerfil) REFERENCES perfil (codPerfil) ON DELETE NO ACTION ON UPDATE NO ACTION);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (1, 1, 'Administrador', 'admin@admin.com', 'admin', 'dc76e9f0c0006e8f919e0c515c66dbba3982f785', 1);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (2, 1, 'lameck', 'lameck@gmail.com', 'lameck', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 2);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (3, 1, 'marcos', 'marcos@marcos.com', 'marcos', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 2);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
