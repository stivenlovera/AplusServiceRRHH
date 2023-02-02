DROP TABLE IF EXISTS HHRRAdministracionPesion;

CREATE TABLE
    HHRRAdministracionPesion(
        id int AUTO_INCREMENT primary key,
        NombreAdministracionPesion VARCHAR(350) NOT NULL
    );

SELECT id,`NombreAdministracionPesion` FROM hhrradministracionpesion;

insert into
    hhrradministracionpesion (
        id,
        `NombreAdministracionPesion`
    )
values (
        $id,
        $NombreAdministracionPesion
    );

update
    hhrradministracionpesion
set
    NombreAdministracionPesion = NombreAdministracionPesion
where id = 'id';

delete from hhrradministracionpesion where id = $id;