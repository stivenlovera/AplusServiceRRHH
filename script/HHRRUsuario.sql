-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas

DROP TABLE IF EXISTS HHRRUsuario;

CREATE TABLE
    HHRRUsuario(
        id int AUTO_INCREMENT primary key,
        usuario TEXT NOT NULL,
        contrasena TEXT NOT NULL,
        HHRRcolaboradorId INT NOT NULL
    );

DROP TABLE IF EXISTS HHRRUsuarioRol;

CREATE TABLE
    HHRRUsuarioRol(
        id int AUTO_INCREMENT primary key,
        HHRRRolId INT NOT NULL,
        HHRRUsuarioId INT NOT NULL
    );

DROP TABLE IF EXISTS HHRRRol;

CREATE TABLE
    HHRRRol(
        id INT AUTO_INCREMENT primary key,
        nombre TEXT NOT NULL,
        descripcion TEXT NOT NULL
    );

SELECT
    U.id,
    c.`Nombre1`,
    c.`Nombre2`,
    c.`Nombre3`,
    c.`ApellidoPaterno`,
    c.`ApellidoMaterno`,
    c.`ApellidoCasado`,
    u.usuario,
    u.contrasena,
    rol.nombre as nombreRol
FROM hhrrusuario as u
    INNER JOIN hhrrusuariorol as ur on u.id = ur.`HHRRUsuarioId`
    INNER JOIN hhrrrol as rol on rol.id = ur.`HHRRRolId`
    INNER JOIN hhrrcolaborador c on c.`Id` = u.`HHRRcolaboradorId`;