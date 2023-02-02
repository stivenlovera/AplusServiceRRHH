DROP TABLE IF EXISTS HHRRTipoContrato;

CREATE TABLE
    HHRRTipoContrato(
        id int AUTO_INCREMENT primary key,
        NombreTipoContrato VARCHAR(350) NOT NULL
    );

SELECT id,`NombreTipoContrato` FROM hhrrtipocontrato;

insert into
    hhrrtipocontrato (id, `NombreTipoContrato`)
values ($id, $NombreTipoContrato);

update hhrrtipocontrato
set
    NombreTipoContrato = NombreTipoContrato
where id = 'id';

delete from
    hhrrtipocontrato
where id = $id;