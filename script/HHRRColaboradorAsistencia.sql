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

insert into
    hhrrcolaboradorasistencia (
        `horaEntrada`,
        `horaSalida`,
        descripcion,
        `HHRRColaboradorId`
    )
values (
        '08:00:00',
        -- 03:59
        '12:00:00',
        -- 08:05
        'puente',
        1
    ), (
        '16:00:00',
        '20:00:00',
        'puente',
        1
    );

insert into
    hhrrcolaboradorasistencia (
        `horaEntrada`,
        `horaSalida`,
        descripcion,
        `HHRRColaboradorId`
    )
values (
        '09:00:00',
        '17:00:00',
        'recorido',
        2
    );

