CREATE TABLE
    HHRRFormacionPrincipal(
        id int AUTO_INCREMENT primary key,
        NombreFormacionPrincipal VARCHAR(350) NOT NULL
    );

SELECT id,`NombreFormacionPrincipal` FROM hhrrformacionprincipal;

insert into
    hhrrformacionprincipal (
        id,
        `NombreFormacionPrincipal`
    )
values (
        $id,
        $NombreFormacionPrincipal
    );

update hhrrformacionprincipal
set
    NombreFormacionPrincipal = NombreFormacionPrincipal
where id = 'id';

delete from hhrrformacionprincipal where id = $id;