DROP TABLE IF EXISTS HHRRCargo;

CREATE TABLE
    HHRRCargo(
        id int AUTO_INCREMENT primary key,
        NombreCargo VARCHAR(350) NOT NULL
    );

SELECT id,`NombreCargo` FROM hhrrcargo;

insert into
    hhrrcargo (id, `NombreCargo`)
values ($id, $NombreCargo);

update hhrrcargo
set
    NombreCargo = NombreCargo
where id = 'id';

delete from hhrrcargo where id = $id;