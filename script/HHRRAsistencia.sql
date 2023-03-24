-- Active: 1679545701306@@159.203.172.137@3306@aplus_empresas

DROP TABLE IF EXISTS HHRRAsistencia;

CREATE TABLE
    HHRRAsistencia(
        id int AUTO_INCREMENT primary key,
        fechaRegistro DATETIME NULL,
        fechaEntrada DATETIME NULL,
        fechaSalida DATETIME NULL,
        horaEntrada TIME NULL,
        horaSalida TIME NULL,
        nota TEXT NULL,
        HHRRColaboradorId INT NOT NULL
    );

SELECT
    a.*,
    c.`Nombre1`,
    c.`Nombre2`,
    c.`Nombre3`,
    c.`ApellidoPaterno`,
    c.`ApellidoMaterno`,
    c.`ApellidoCasado`
FROM hhrrasistencia as a
    inner JOIN hhrrcolaborador as c on c.`Id` = a.id;

--esto lo crea el job cada 24 horas

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
        '2023-02-22',
        NULL,
        NULL,
        NULL,
        NULL,
        'puente',
        '1'
    );

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
        '2023-02-22',
        NULL,
        NULL,
        NULL,
        NULL,
        'puente',
        '1'
    );

-- registro de insercion manual o automatico controlador

--verificar si existe datos

SELECT
    a.id,
    a.`HHRRColaboradorId`,
    a.`fechaRegistro`,
    a.`fechaEntrada`,
    a.`fechaSalida`,
    a.`horaEntrada`,
    a.`horaSalida`,
    a.nota
FROM hhrrasistencia as a
WHERE
    a.`fechaRegistro` = '2023-02-22'
    and a.`HHRRColaboradorId` = '1';

update hhrrasistencia
set
    fechaEntrada = '2023-02-22',
    fechaSalida = '2023-02-22',
    horaEntrada = '08:01:00', -- 4:13:59 horas atraso
    horaSalida = '12:12:59',
    nota = ''
where
    fechaRegistro = '2023-02-22'
    AND HHRRColaboradorId = '1'
    AND id = 1;

delete from hhrrasistencia where id = '{id}';



SELECT * FROM HHRRHorario as h INNER JOIN HHRRDia as d on h.id=d.HHRRHorarioId