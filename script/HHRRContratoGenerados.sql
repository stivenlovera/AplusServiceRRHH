DROP TABLE IF EXISTS HHRRContratoGenerados;

CREATE TABLE
    HHRRContratoGenerados(
        id int AUTO_INCREMENT primary key,
        fechaGeneracion DATETIME Not NULL,
        hhrrcolaboradorId int NOT NULL,
        HHRRPlantillaContrato int  NOT NULL
    );