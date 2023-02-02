INSERT INTO
    `empresa`(
        `Nombre`,
        `Descripcion`,
        `Dirrecion`,
        `Representante`,
        `fechaIngreso`
    )
VALUES (
        'Aplus Security',
        'Empresa de seguridad',
        'Entre 3er',
        'Sergio Olmos',
        '2022-01-01'
    );

--contactos

INSERT INTO
    `contacto`(
        `NombreCompleto`,
        `Dirrecion`,
        `Telefono`,
        `Celular`,
        `EmpresaId`
    )
VALUES (
        'Sergio Olmos',
        '3er y 4 ato anillo radias 16',
        '3366999',
        '66996666',
        '1'
    );

INSERT INTO
    `usuario`(
        `User`,
        `nombreCompleto`,
        `Estado`,
        `Password`,
        `EmpresaId`
    )
VALUES (
        'Sergio',
        'Sergio Olmos',
        '1',
        'Sergio123?',
        '1'
    )