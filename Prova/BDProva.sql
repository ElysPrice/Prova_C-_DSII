use master
create database assistenciaETEC
use assistenciaETEC
go


CREATE TABLE tbCliente (
	idCli			INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nomeCli			varchar(130) NOT NULL,
	telefoneCli		varchar(12) NOT NULL,
	dataNasCli		varchar(9) NOT NULL,
	RGCli			varchar (10) NOT NULL,
	CPFCli			varchar(12) NOT NULL,
	enderecoCli		varchar (200) NOT NULL,
	emailCli		varchar (150) NOT NULL
)

CREATE TABLE tbCel (
	idCel			INT PRIMARY KEY IDENTITY (1,1) NOT NULL,
	nomeCel			varchar(65) NOT NULL,
	modeloCel		varchar(40) NOT NULL,
	anoCel			varchar(5) NOT NULL,
	montadoraCel	varchar (35) NOT NULL,
)

CREATE TABLE tbCelCli(
	idCli		INT NOT NULL,
	idCel		INT NOT NULL
)

ALTER TABLE tbCelCli	ADD CONSTRAINT fk_Celular_Cel FOREIGN KEY(idCel) REFERENCES tbCel(idCel),
						CONSTRAINT fk_Cliente_Cli FOREIGN KEY (idCli) REFERENCES tbCliente(idCli)
						
INSERT INTO tbCliente VALUES ('Regina', '222222222', '23/08/1999', '112223334', '11122233344', 'Rua dos Legais', 'reginab@gmail.com')
SELECT * FROM tbCliente

