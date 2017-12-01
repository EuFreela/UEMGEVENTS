--
-- File generated with SQLiteStudio v3.1.1 on ter nov 7 23:56:51 2017
--
-- Text encoding used: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Table: curso
CREATE TABLE curso (idCurso INTEGER PRIMARY KEY AUTOINCREMENT, codCurso INTEGER NOT NULL, nomeCurso VARCHAR (255) NOT NULL, instituicaoCurso VARCHAR (255) NOT NULL, cidade VARCHAR (255) NOT NULL, estados_idEstados INTEGER REFERENCES estados (idEstados) DEFERRABLE INITIALLY DEFERRED);
INSERT INTO curso (idCurso, codCurso, nomeCurso, instituicaoCurso, cidade, estados_idEstados) VALUES (1, 1, 'Sistemas de Informação', 'UEMG', 'Passos', 13);

-- Table: estados
CREATE TABLE estados (idEstados INTEGER PRIMARY KEY AUTOINCREMENT, codEstado INTEGER NOT NULL, nomeEstado VARCHAR (255) NOT NULL, uf NOT NULL);
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (1, 1, 'Acre', 'AC');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (2, 2, 'Alagoas', 'AL');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (3, 3, 'Amapá', 'AP');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (4, 4, 'Amazonas', 'AM');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (5, 5, 'Bahia', 'BA');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (6, 6, 'Ceará', 'CE');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (7, 7, 'Distrito Federal', 'DF');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (8, 8, 'Espírito Santo', 'ES');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (9, 9, 'Goiás', 'GO');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (10, 10, 'Maranhão', 'MA');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (11, 11, 'Mato Grosso', 'MT');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (12, 12, 'Mato Grosso do Sul', 'MS');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (13, 13, 'Minas Gerais', 'MG');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (14, 14, 'Pará', 'PA');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (15, 15, 'Paraíba', 'PB');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (16, 16, 'Paraná', 'PR');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (17, 17, 'Pernambuco', 'PE');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (18, 18, 'Piauí', 'PI');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (19, 19, 'Rio de Janeiro', 'RJ');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (20, 20, 'Rio Grande do Norte', 'RN');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (21, 21, 'Rio Grande do Sul', 'RS');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (22, 22, 'Rondônia', 'RO');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (23, 23, 'Roraima', 'RR');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (24, 24, 'Santa Catarina', 'SC');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (25, 25, 'São Paulo', 'SP');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (26, 26, 'Sergipe', 'SE');
INSERT INTO estados (idEstados, codEstado, nomeEstado, uf) VALUES (27, 27, 'Tocantins', 'TO');

-- Table: evento
CREATE TABLE evento (idEvento INTEGER PRIMARY KEY AUTOINCREMENT, tituloEvento NOT NULL, dataEvento DATE NOT NULL, horarioInicial TIME NOT NULL, horarioFinal TIME NOT NULL, usuarios_idUsuarios INTEGER REFERENCES usuarios (idusuarios) DEFERRABLE INITIALLY DEFERRED, palestrante_idPalestrante INTEGER REFERENCES palestrante (idpalestrante) DEFERRABLE INITIALLY DEFERRED);

-- Table: infoPalestrante
CREATE TABLE infoPalestrante (idinfopalestrante INTEGER PRIMARY KEY AUTOINCREMENT, telefoneFixo VARCHAR (12), celular VARCHAR (13), email varchr (255) NOT NULL, cidade VARCHAR (255) NOT NULL, palestrante_idpalestrante INTEGER REFERENCES palestrante (idpalestrante) DEFERRABLE INITIALLY DEFERRED NOT NULL, estados_idestados INTEGER REFERENCES estados (idEstados) DEFERRABLE INITIALLY DEFERRED NOT NULL);

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
CREATE TABLE palestrante (idpalestrante INTEGER PRIMARY KEY AUTOINCREMENT, codPaltesrante INTEGER NOT NULL, nomePaletsrante VARCHAR (255) NOT NULL);

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
CREATE TABLE titulacao (idtitulacao INTEGER PRIMARY KEY AUTOINCREMENT, codTitulacao INTEGER NOT NULL, nomeTitulacao VARCHAR (255) NOT NULL);
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (1, 1, 'Nenhum Título');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (2, 2, 'Bacharelado');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (3, 3, 'Mestrado');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (4, 4, 'Doutordo');
INSERT INTO titulacao (idtitulacao, codTitulacao, nomeTitulacao) VALUES (5, 5, 'Pós Doutorado');

-- Table: titulos
CREATE TABLE titulos (idTitulos INTEGER PRIMARY KEY AUTOINCREMENT, nomeInstituicaoTitulo VARCHAR (255) NOT NULL, dataTitulo DATE NOT NULL, titulacao_idtitulacao INTEGER NOT NULL REFERENCES titulacao (idtitulacao) DEFERRABLE INITIALLY DEFERRED, palestrante_idpalestrante INTEGER NOT NULL REFERENCES palestrante (idpalestrante) DEFERRABLE INITIALLY DEFERRED);

-- Table: usuarios
CREATE TABLE usuarios (idusuarios INTEGER PRIMARY KEY AUTOINCREMENT, ativo BIT (1) NOT NULL, nomeUsuario VARCHAR (100), email VARCHAR (100) UNIQUE, username VARCHAR (100) NOT NULL UNIQUE, passwd VARCHAR (255) NOT NULL, perfil_codPerfil INT NOT NULL, CONSTRAINT fk_usuarios_perfil1_idx UNIQUE (username ASC), CONSTRAINT fk_usuarios_perfil1 FOREIGN KEY (perfil_codPerfil) REFERENCES perfil (codPerfil) ON DELETE NO ACTION ON UPDATE NO ACTION);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (1, 1, 'Administrador', 'admin@admin.com', 'admin', 'dc76e9f0c0006e8f919e0c515c66dbba3982f785', 1);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (2, 1, 'lameck', 'lameck@gmail.com', 'lameck', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 2);
INSERT INTO usuarios (idusuarios, ativo, nomeUsuario, email, username, passwd, perfil_codPerfil) VALUES (3, 1, 'marcos', 'marcos@marcos.com', 'marcos', '40bd001563085fc35165329ea1ff5c5ecbdbbeef', 2);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
