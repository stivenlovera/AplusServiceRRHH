DROP TABLE IF EXISTS HHRRCajaSalud;

CREATE TABLE
    HHRRCajaSalud(
        id int AUTO_INCREMENT primary key,
        NombreCajaSalud VARCHAR(350) NOT NULL
    );

SELECT id,`NombreCajaSalud` FROM hhrrcajasalud;

insert into
    hhrrcajasalud (id, `NombreCajaSalud`)
values ($id, $NombreCajaSalud);

update hhrrcajasalud
set
    NombreCajaSalud = NombreCajaSalud
where id = 'id';

delete from hhrrcajasalud where id = $id;