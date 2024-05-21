create database loja_de_carros;

use loja_de_carros;

CREATE TABLE `veiculos` (
	`veiculo_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `renavan` VARCHAR(11) NOT NULL UNIQUE,
    `placa` VARCHAR(7) NOT NULL UNIQUE,
    `marca_id` INT NOT NULL,
	`tipo_id` INT NOT NULL,
    `ano_fabricacao` DATE NOT NULL,
    `data_cadastro` datetime NOT NULL DEFAULT NOW(),
	`data_alteracao` datetime DEFAULT NULL,
    `descricao` TINYTEXT DEFAULT NULL,
    FOREIGN KEY(`tipo_id`) REFERENCES `tipos_de_veiculos`(`tipo_id`),
    FOREIGN KEY(`marca_id`) REFERENCES `marcas`(`marca_id`)
);

CREATE TABLE `marcas` (
	`marca_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `marca` varchar(50) default NULL UNIQUE
);

CREATE TABLE `modelos` (
	`modelo_id` INT NOT NULL AUTO_INCREMENT,
	`marca_id` INT NOT NULL,
    `modelo` VARCHAR(50) NOT NULL,
    `ano_modelo` DATE NOT NULL,
    FOREIGN KEY(`marca_id`) REFERENCES `marcas`(`marca_id`),
    PRIMARY KEY(`modelo_id`, `marca_id`)
);

CREATE TABLE `tipos_de_veiculos` (
	`tipo_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `tipo` VARCHAR(30)
);

CREATE TABLE `situacoes` (
	`situacao_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
	`situacao` ENUM('A VISTA', 'FINANCIAMENTO', 'DISPONIVEL', 'INDISPONIVEL'),
    `valor_de_compra` DECIMAL(10, 2) NOT NULL,
	`data_de_compra` DATETIME NOT NULL DEFAULT NOW(),
    `valor_de_venda` DECIMAL(10, 2) DEFAULT NULL,
    `data_de_venda` DATETIME DEFAULT NULL,
    `observacao` TINYTEXT DEFAULT NULL,
    `veiculo_id` INT NOT NULL,
    FOREIGN KEY(`veiculos_id`) REFERENCES `veiculos`(`veiculo_id`)
);

INSERT INTO
`situacoes`(
	situacao, valor_de_compra, data_de_compra,
    observacao, veiculo_id)
VALUES
	('DISPONIVEL', 100000, '2024-05-20 21:59:12', 'apenas um carro', 1),
    ('DISPONIVEL', 150000, '2024-05-20 21:59:12', 'apenas um carro', 2),
    ('DISPONIVEL', 180000, '2024-05-20 21:59:12', 'apenas um carro', 3),
    ('DISPONIVEL', 220000, '2024-05-20 21:59:12', 'apenas um carro', 4),
    ('DISPONIVEL', 120000, '2024-05-20 21:59:12', 'apenas um carro', 5),
    ('DISPONIVEL', 120000, '2024-05-20 21:59:12', 'apenas um carro', 6),
    ('DISPONIVEL', 160000, '2024-05-20 21:59:12', 'apenas um carro', 7),
    ('DISPONIVEL', 120000, '2024-05-20 21:59:12', 'apenas um carro', 8),
    ('DISPONIVEL', 80000, '2024-05-20 21:59:12', 'apenas um carro', 9),
    ('DISPONIVEL', 170000, '2024-05-20 21:59:12', 'apenas um carro', 10);

alter table situacoes add column veiculo_id int not null;
alter table situacoes add foreign key(veiculo_id) references veiculos(veiculo_id);

drop table veiculos;

CREATE TABLE `clientes` (
	`cliente_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nome_cliente` varchar(90) NOT NULL,
    `tipo_documento` ENUM('CPF', 'CNPJ') NOT NULL,
    `documento_cliente` varchar(14),
    `telefone_cliente` varchar(11)
);

CREATE TABLE `movimentacoes`(
	`cliente_id` INT NOT NULL,
    `movimentacao_id` INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `veiculo_id` Int NOT NULL,
    `status_movi` ENUM ('VENDA' , 'COMPRA') NOT NULL,
    `valor_movi` DECIMAL (10,2),
    FOREIGN KEY (`cliente_id`) REFERENCES `clientes`(`cliente_id`),
    FOREIGN KEY (`veiculo_id`) REFERENCES `veiculos` (`veiculos_id`)
);

DROP TABLE `carros`;

DROP TABLE `marcas`;

DROP TABLE `modelos`;

alter table situacoes modify situacao enum('A VISTA', 'FINANCIADO', 'DISPONIVEL', 'INDISPONIVEL') NOT NULL DEFAULT 'DISPONIVEL';

INSERT INTO `marcas`(`marca`)
VALUES
		('Toyota'),
		('Honda'),
		('Nissan'),
		('Ford'),
		('Chevrolet'),
		('Hyundai'),
		('Kia'),
		('BMW'),
		('Mercedes-Benz'),
		('Audi'),
        ('BYD'),
        ('LADA'),
        ('Alpine');
        
INSERT INTO `modelos` (`marca_id`, `modelo`, `ano_modelo`)
VALUES
		(1, 'Corolla', '2010-01-01'),
		(2, 'Civic', '2012-01-01'),
		(4, 'Fiesta', '2015-01-01'),
		(5, 'Cruze', '2018-01-01'),
		(8, 'Series 3', '2019-01-01'),
		(9, 'C-Class', '2016-01-01'),
		(10, 'A4', '2014-01-01'),
		(6, 'Elantra', '2013-01-01'),
		(3, 'Sentra', '2011-01-01'),
		(7, 'Optima', '2017-01-01');
        
INSERT INTO `tipos_de_veiculos` (`tipo`)
VALUES
		('Sedan'),
		('SUV'),
		('Moto'),
		('Caminhonete'),
		('Utilitario'),
		('Minivan'),
		('Picape'),
		('Van'),
		('Eletrico');

select * from tipos_de_veiculos;
select * from veiculos;

INSERT INTO `veiculos` (`renavan`, `placa`, `marca_id`, `tipo_id`, `ano_fabricacao`, `descricao`)
VALUES
		('12345678901', 'ABC1234', 1, 1, '2019-01-01', 'Descrição do veículo 1'),
		('23456789012', 'DEF5678', 2, 2, '2020-01-01', 'Descrição do veículo 2'),
		('34567890123', 'GHI9012', 3, 3, '2018-01-01', 'Descrição do veículo 3'),
		('45678901234', 'JKL3456', 4, 4, '2017-01-01', 'Descrição do veículo 4'),
		('56789012345', 'MNO7890', 5, 5, '2016-01-01', 'Descrição do veículo 5'),
		('67890123456', 'PQR1234', 6, 6, '2015-01-01', 'Descrição do veículo 6'),
		('78901234567', 'STU5678', 7, 7, '2014-01-01', 'Descrição do veículo 7'),
		('89012345678', 'VWX9012', 8, 8, '2013-01-01', 'Descrição do veículo 8'),
		('90123456789', 'YZA3456', 9, 9, '2012-01-01', 'Descrição do veículo 9'),
		('01234567890', 'BCD7890', 6, 1, '2011-01-01', 'Descrição do veículo 10'),
		('12345678901', 'EFG1234', 4, 1, '2010-01-01', 'Descrição do veículo 11'),
		('23456789012', 'HIJ5678', 5, 2, '2009-01-01', 'Descrição do veículo 12'),
		('34567890123', 'KLM9012', 2, 3, '2008-01-01', 'Descrição do veículo 13'),
		('45678901234', 'NOP3456', 1, 4, '2007-01-01', 'Descrição do veículo 14'),
		('56789012345', 'QRS7890', 3, 5, '2006-01-01', 'Descrição do veículo 15');
