DROP TABLE IF EXISTS HHRRUnidad;

CREATE TABLE
    HHRRUnidad(
        id int AUTO_INCREMENT primary key,
        NombreUnidad VARCHAR(350) NOT NULL
    );

SELECT id,`NombreUnidad` FROM hhrrunidad;

insert into
    hhrrunidad (id, `NombreUnidad`)
values ($id, $NombreUnidad);

update hhrrunidad
set
    NombreUnidad = NombreUnidad
where id = 'id';

delete from hhrrunidad where id = $id;