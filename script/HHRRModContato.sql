DROP TABLE IF EXISTS HHRRModContrato;

CREATE TABLE
    HHRRModContrato(
        id int AUTO_INCREMENT primary key,
        NombreModContrato VARCHAR(350) NOT NULL,
        dias int NOT NULL,
    );

DROP TABLE IF EXISTS HHRRPlantillaContrato;

CREATE TABLE
    HHRRPlantillaContrato(
        id int AUTO_INCREMENT primary key,
        nombreDoc VARCHAR(350) NOT NULL,
        descripcion VARCHAR(350) NOT NULL,
        fechaEmision DATE NOT NULL
    );