-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas

DROP TABLE IF EXISTS HHRRAsistencia;

CREATE TABLE
    HHRRAsistencia(
        id int AUTO_INCREMENT primary key,
        fechaRegistro DATETIME NOT NULL,
        fechaEntrada DATETIME NOT NULL,
        fechaSalida DATETIME NOT NULL,
        horaEntrada DATETIME NOT NULL,
        horaSalida DATETIME NOT NULL,
        nota DATETIME NOT NULL,
        HHRRColaboradorId INT NOT NULL
    );

SELECT
    asistencia.*,
    c.`Nombre1`,
    c.`Nombre2`,
    c.`Nombre3`,
    c.`ApellidoPaterno`,
    c.`ApellidoMaterno`,
    c.`ApellidoCasado`,
    cargo.`NombreCargo`
FROM
    hhrrasistencia as asistencia
    inner JOIN hhrrcolaborador as c on c.`Id` = asistencia.id
    inner JOIN hhrrcargo as cargo on c.`Cargo` = cargo.id;

insert into
    hhrrasistencia (
        fechaRegistro,
        fechaEntrada,
        fechaSalida,
        horaEntrada,
        horaSalida,
        nota,
        HHRRColaboradorId
    )
values (
        '{fechaRegistro}',
        '{fechaEntrada}',
        '{fechaSalida}',
        '{horaEntrada}',
        '{horaSalida}',
        '{nota}',
        '{HHRRColaboradorId}'
    );

update hhrrasistencia
set
    fechaRegistro = '{fechaRegistro}',
    fechaEntrada = '{fechaEntrada}',
    fechaSalida = '{fechaSalida}',
    horaEntrada = '{horaEntrada}',
    horaSalida = '{horaSalida}',
    nota = '{nota}',
    HHRRColaboradorId = '{HHRRColaboradorId}'
where id = '{id}';

delete from hhrrasistencia where id = '{id}';