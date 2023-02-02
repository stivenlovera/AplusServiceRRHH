-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas

DROP DATABASE IF EXISTS AplusSecurity;

CREATE database
    AplusSecurity CHARACTER SET 'UTF8' COLLATE 'utf8_general_ci';

use AplusSecurity;

DROP TABLE IF EXISTS HHRRTipoDocumento;

CREATE TABLE
    HHRRTipoDocumento(
        id int AUTO_INCREMENT primary key,
        TipoDocumento VARCHAR(350) NOT NULL
    );

DROP TABLE IF EXISTS HHRRPais;

CREATE TABLE
    HHRRPais(
        id int AUTO_INCREMENT primary key,
        NombrePais VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRPais`(`id`, `NombrePais`)
VALUES ('1', 'Bolivia'), ('2', 'Argentina'), ('3', 'Brasil'), ('4', 'Peru'), ('5', 'Chile'), ('6', 'Colombia');

DROP TABLE IF EXISTS HHRRDepartamento;

CREATE TABLE
    HHRRDepartamento(
        id int AUTO_INCREMENT primary key,
        NombreDepartamento VARCHAR(350) NOT NULL,
        HHRRPaisId int NOT NULL
    );

INSERT INTO
    `HHRRDepartamento`(
        `id`,
        `NombreDepartamento`,
        `HHRRPaisId`
    )
VALUES ('1', 'La paz', '1'), ('2', 'Cochabamba', '1'), ('3', 'Santa cruz', '1'), ('4', 'Tarija', '1'), ('5', 'Beni', '1'), ('6', 'Pando', '1'), ('7', 'Potosi', '1'), ('8', 'Oruro', '1'), ('9', 'Chuquisaca', '1');

DROP TABLE IF EXISTS HHRREstadoCivil;

CREATE TABLE
    HHRREstadoCivil(
        id int AUTO_INCREMENT primary key,
        NombreEstadoCivil VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRREstadoCivil`(`id`, `NombreEstadoCivil`)
VALUES ('1', 'Soltero'), ('2', 'Casado');

DROP TABLE IF EXISTS HHRRSexo;
CREATE TABLE
    HHRRSexo(
        id int AUTO_INCREMENT primary key,
        NombreSexo VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRSexo`(`id`, `NombreSexo`)
VALUES ('1', 'Masculino'), ('2', 'Femenino');

DROP TABLE IF EXISTS HHRRUnidad;

CREATE TABLE
    HHRRUnidad(
        id int AUTO_INCREMENT primary key,
        NombreUnidad VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRUnidad`(`id`, `NombreUnidad`)
VALUES ('1', 'Comercial'), ('2', 'Adminitrativo');

DROP TABLE IF EXISTS HHRRCargo;

CREATE TABLE
    HHRRCargo(
        id int AUTO_INCREMENT primary key,
        NombreCargo VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRCargo`(`id`, `NombreCargo`)
VALUES ('1', 'Atencion al cliente'), ('2', 'Vendedor');

DROP TABLE IF EXISTS HHRRSucursal;

CREATE TABLE
    HHRRSucursal(
        id int AUTO_INCREMENT primary key,
        NombreSucursal VARCHAR(350) NOT NULL,
        Direccion VARCHAR(500) NOT NULL
    );

INSERT INTO
    `HHRRSucursal`(
        `id`,
        `NombreSucursal`,
        `Direccion`
    )
VALUES (
        '1',
        'Sucursal cotoca',
        'Barrio los pinos '
    ), (
        '2',
        'Casa Matriz',
        'Barrio los av  alemana'
    );

DROP TABLE IF EXISTS HHRROficina;

CREATE TABLE
    HHRROficina(
        id int AUTO_INCREMENT primary key,
        NombreOficina VARCHAR(350) NOT NULL,
        HHRRSucursalId int NOT NULL
    );

INSERT INTO
    `HHRROficina`(
        `id`,
        `NombreOficina`,
        `HHRRSucursalId`
    )
VALUES (
        '1',
        'Central - jorge Alvares',
        '1'
    ), (
        '2',
        'Central - Adrian Salvarierra',
        '1'
    ), (
        '3',
        'Sucursal Cotoca - Miguel Condori',
        '2'
    );

DROP TABLE IF EXISTS HHRRClasificacionLaboral;

CREATE TABLE
    HHRRClasificacionLaboral(
        id int AUTO_INCREMENT primary key,
        NombreClasificacionLaboral VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRClasificacionLaboral`(
        `id`,
        `NombreClasificacionLaboral`
    )
VALUES ('1', 'Atencion al cliente'), (
        '2',
        'Ventas del exterior (freelancer)'
    ), (
        '3',
        'Administrador ocupaciones de direccion'
    );

DROP TABLE IF EXISTS HHRRModContrato;

CREATE TABLE
    HHRRModContrato(
        id int AUTO_INCREMENT primary key,
        NombreModContrato VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRModContrato`(`id`, `NombreModContrato`)
VALUES ('1', 'Idefinido'), ('2', '6 meses'), ('3', '1 año');

DROP TABLE IF EXISTS HHRRTipoContrato;

CREATE TABLE
    HHRRTipoContrato(
        id int AUTO_INCREMENT primary key,
        NombreTipoContrato VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRTipoContrato`(`id`, `NombreTipoContrato`)
VALUES ('1', 'Escrito'), ('2', 'Verbal');

DROP TABLE IF EXISTS HHRRInformacionContable;

CREATE TABLE
    HHRRInformacionContable(
        id int AUTO_INCREMENT primary key,
        NombreInformacionContable VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRInformacionContable`(
        `id`,
        `NombreInformacionContable`
    )
VALUES ('1', 'No registrado');

DROP TABLE IF EXISTS HHRRCentroCosto;

CREATE TABLE
    HHRRCentroCosto(
        id int AUTO_INCREMENT primary key,
        NombreCentroCosto VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRCentroCosto`(`id`, `NombreCentroCosto`)
VALUES ('1', 'Pago servicio');

DROP TABLE IF EXISTS HHRRFormaPago;

CREATE TABLE
    HHRRFormaPago(
        id int AUTO_INCREMENT primary key,
        NombreFormaPago VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRFormaPago`(`id`, `NombreFormaPago`)
VALUES ('1', 'Banco'), ('2', 'Efectivo');

DROP TABLE IF EXISTS HHRRTipoCuenta;

CREATE TABLE
    HHRRTipoCuenta(
        id int AUTO_INCREMENT primary key,
        NombreTipoCuenta VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRTipoCuenta`(`id`, `NombreTipoCuenta`)
VALUES ('1', 'Cuenta ahorro'), ('2', 'Cuenta corriente');

DROP TABLE IF EXISTS HHRRBanco;

CREATE TABLE
    HHRRBanco(
        id int AUTO_INCREMENT primary key,
        NombreBanco VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRBanco`(`id`, `NombreBanco`)
VALUES ('1', 'Mercantil'), ('2', 'Economico'), ('3', 'BNB'), ('4', 'Fasil');

CREATE TABLE
    HHRRAdministracionPesion(
        id int AUTO_INCREMENT primary key,
        NombreAdministracionPesion VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRAdministracionPesion`(
        `id`,
        `NombreAdministracionPesion`
    )
VALUES ('1', 'AFP prevision');

CREATE TABLE
    HHRRCajaSalud(
        id int AUTO_INCREMENT primary key,
        NombreCajaSalud VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRCajaSalud`(`id`, `NombreCajaSalud`)
VALUES ('1', 'Caja petrolera'), ('2', 'Caja obrera');

CREATE TABLE
    HHRRFormacionPrincipal(
        id int AUTO_INCREMENT primary key,
        NombreFormacionPrincipal VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRFormacionPrincipal`(
        `id`,
        `NombreFormacionPrincipal`
    )
VALUES ('1', 'Ing. comercial'), (
        '2',
        'Lic. Administracion empresas'
    ), ('3', 'Lic. comercio exterior');

----REGISTRAR CARGOS