-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas

DROP TABLE IF EXISTS HHRRColaborador;

CREATE TABLE
    HHRRColaborador(
        Id int AUTO_INCREMENT primary key,
        Ci TEXT NULL,
        Nombre1 TEXT NULL,
        Nombre2 TEXT NULL,
        Nombre3 TEXT NULL,
        ApellidoPaterno TEXT NULL,
        ApellidoMaterno TEXT NULL,
        ApellidoCasado TEXT NULL,
        FechaNacimiento DATETIME NULL,
        VencimientoDocumento DATETIME NULL,
        VencimientoLicConducir DATETIME NULL,
        LugarNacimiento TEXT NULL,
        LicenciaConducir TEXT NULL,
        TelefonoFijo TEXT NULL,
        Celular TEXT NULL,
        TelefonoFijoTrabajo TEXT NULL,
        ContactoEmegencia TEXT NULL,
        TelefonoEmergencia TEXT NULL,
        ViviendaPropia TEXT NULL,
        VehiculoPropio TEXT NULL,
        TipoSangre TEXT NULL,
        FactorSangre TEXT NULL,
        Dirrecion TEXT NULL,
        Email TEXT NULL,
        TipoDocumento TEXT NULL,
        Nacionalidad TEXT NULL,
        Departamento TEXT NULL,
        EstadoCivil TEXT NULL,
        ConyugeNombreCompleto TEXT NULL,
        ConyugeLugarNacimiento TEXT NULL,
        ConyugeFechaNacimiento TEXT NULL,
        CodigoColaborador TEXT NULL,
        FechaIngreso DATETIME NULL,
        FechaIngresoVacaciones DATETIME NULL,
        FechaIngresoVacacionesAnt DATETIME NULL,
        FechaIngresoBonoAntiguedad DATETIME NULL,
        Oficina INT NULL,
        ModohaberBasico INT NULL,
        HaberBasico INT NULL,
        ModoQuincena INT NULL,
        HaberQuincena INT NULL,
        TelefonoLaboral INT NULL,
        CelularLaboral TEXT NULL,
        DirrecionLaboral INT NULL,
        EmailLaboral TEXT NULL,
        MotivoContrato TEXT NULL,
        FechaFinalizacion DATETIME NULL,
        FechaRatificacion DATETIME NULL,
        ExcliblePlanilla INT NULL,
        AguinaldoMes1 INT NULL,
        Aplica2aguinaldo INT NULL,
        AplicaRetroactivos INT NULL,
        AplicaPrima INT NULL,
        EnviarBoletaPago INT NULL,
        Indemnizacion INT NULL,
        PorcentajeCentroCosto INT NULL,
        CuentaBancaria INT NULL,
        AplicaAFP INT NULL,
        NroAFP INT NULL,
        Jubilado INT NULL,
        AportaAFP INT NULL,
        AplicaCajaSalud INT NULL,
        NroAsegurado TEXT NULL,
        Discapacidad INT NULL,
        RequiereApruebeVacaciones INT NULL,
        ValorLunes decimal NULL,
        ValorMartes decimal NULL,
        ValorMiercoles decimal NULL,
        ValorJueves decimal NULL,
        ValorViernes decimal NULL,
        ValorSabado decimal NULL,
        ValorDomingo decimal NULL,
        CodigoAsistencia INT NULL,
        DiasporMes INT NULL,
        ControlarAsistencia INT NULL,
        BonoExtra INT NULL,
        BonoExtraNocturna INT NULL,
        HorasParaHorasExtras INT NULL,
        HorasPorDia INT NULL,
        DescuentoPorFalta INT NULL,
        DescuentoPorAtraso INT NULL,
        Dominicales INT NULL,
        TrabajaDomingo INT NULL,
        HorasPlanillas INT NULL,
        Unidad INT NULL,
        Sucursal INT NULL,
        Cargo INT NULL,
        Clasificacionlaboral INT NULL,
        TipoContrato INT NULL,
        InformacionContable INT NULL,
        CentroCosto INT NULL,
        FormaPago INT NULL,
        TipoCuenta INT NULL,
        Banco INT NULL,
        AdministracionPensiones INT NULL,
        CajaSalud INT NULL,
        FormacionPrincial INT NULL,
        Sexo INT NULL
    );

INSERT INTO
    `hhrrcolaborador`(
        `Ci`,
        `Nombre1`,
        `Nombre2`,
        `Nombre3`,
        `ApellidoPaterno`,
        `ApellidoMaterno`,
        `ApellidoCasado`,
        `FechaNacimiento`,
        `VencimientoDocumento`,
        `VencimientoLicConducir`,
        `LugarNacimiento`,
        `LicenciaConducir`,
        `TelefonoFijo`,
        `Celular`,
        `TelefonoFijoTrabajo`,
        `ContactoEmegencia`,
        `TelefonoEmergencia`,
        `TipoSangre`,
        `FactorSangre`,
        `Dirrecion`,
        `Email`,
        `TipoDocumento`,
        `Nacionalidad`,
        `Departamento`,
        `EstadoCivil`,
        `ConyugeNombreCompleto`,
        `ConyugeLugarNacimiento`,
        `ConyugeFechaNacimiento`,
        `CodigoColaborador`,
        `FechaIngreso`,
        `FechaIngresoVacaciones`,
        `FechaIngresoVacacionesAnt`,
        `FechaIngresoBonoAntiguedad`,
        `Oficina`,
        `ModohaberBasico`,
        `HaberBasico`,
        `ModoQuincena`,
        `HaberQuincena`,
        `TelefonoLaboral`,
        `CelularLaboral`,
        `DirrecionLaboral`,
        `EmailLaboral`,
        `MotivoContrato`,
        `FechaFinalizacion`,
        `FechaRatificacion`,
        `ExcliblePlanilla`,
        `AguinaldoMes1`,
        `Aplica2aguinaldo`,
        `AplicaRetroactivos`,
        `AplicaPrima`,
        `EnviarBoletaPago`,
        `Indemnizacion`,
        `PorcentajeCentroCosto`,
        `CuentaBancaria`,
        `AplicaAFP`,
        `NroAFP`,
        `Jubilado`,
        `AportaAFP`,
        `AplicaCajaSalud`,
        `NroAsegurado`,
        `Discapacidad`,
        `RequiereApruebeVacaciones`,
        `ValorLunes`,
        `ValorMartes`,
        `ValorMiercoles`,
        `ValorJueves`,
        `ValorViernes`,
        `ValorSabado`,
        `ValorDomingo`,
        `CodigoAsistencia`,
        `DiasporMes`,
        `ControlarAsistencia`,
        `BonoExtra`,
        `BonoExtraNocturna`,
        `HorasParaHorasExtras`,
        `HorasPorDia`,
        `DescuentoPorFalta`,
        `DescuentoPorAtraso`,
        `Dominicales`,
        `TrabajaDomingo`,
        `HorasPlanillas`,
        `Unidad`,
        `Sucursal`,
        `Cargo`,
        `Clasificacionlaboral`,
        `TipoContrato`,
        `InformacionContable`,
        `CentroCosto`,
        `FormaPago`,
        `TipoCuenta`,
        `Banco`,
        `AdministracionPensiones`,
        `CajaSalud`,
        `FormacionPrincial`,
        `Sexo`
    )
VALUES (
        '8963497',
        'Ali',
        'Stiven',
        '',
        'Lovera',
        'Huarachi',
        '',
        '1991-09-01',
        '2025-01-12',
        '2025-01-12',
        '',
        'Santa Cruz',
        '',
        '',
        '75679775',
        '',
        '',
        '',
        'or',
        '+',
        'barrio toborochi',
        'stiven@gmail.com',
        '1',
        '1',
        '1',
        '1',
        '',
        '2023-01-01',
        'lh00001',
        '2023-01-01',
        '2023-01-01',
        '2023-01-01',
        '2023-01-01',
        '1',
        '1',
        '1',
        '2800',
        '2',
        '0',
        '',
        '75679755',
        'En algun lugar de bolivia',
        'alovera♦gmail.com',
        '2023-01-12',
        '2023-01-12',
        '1',
        '1',
        '1',
        '2',
        '2',
        '2',
        '2',
        '2',
        '1',
        '0.6',
        '100996632',
        '1',
        '99666632',
        '1',
        '',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1112211',
        '26',
        '1',
        '1',
        '1',
        '1',
        '1',
        '8',
        '1',
        '1',
        '0',
        '0',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1',
        '1'
    );

SELECT * from hhrrcolaborador ;

SELECT
    c.id,
    c.Nombre1,
    c.Nombre2,
    c.Nombre3,
    c.ApellidoPaterno,
    c.ApellidoMaterno,
    c.ApellidoCasado,
    cargo.NombreCargo,
    unidad.NombreUnidad,
    sucursal.NombreSucursal,
    oficina.NombreOficina
FROM hhrrcolaborador as c
    inner JOIN hhrrcargo as cargo on cargo.id = c.Cargo
    INNER JOIN hhrrunidad as unidad on unidad.id = c.Unidad
    INNER JOIN hhrrsucursal as sucursal on sucursal.id = c.Sucursal
    INNER JOIN hhrroficina as oficina on c.Oficina = oficina.id