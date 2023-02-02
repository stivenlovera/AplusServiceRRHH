DROP TABLE IF EXISTS HHRRBanco;

CREATE TABLE
    HHRRBanco(
        id int AUTO_INCREMENT primary key,
        NombreBanco VARCHAR(350) NOT NULL
    );

SELECT id,`NombreBanco` FROM hhrrbanco;

insert into
    hhrrbanco (id, `NombreBanco`)
values ($id, $NombreBanco);

update hhrrbanco set NombreBanco = NombreBanco where id = 'id';

delete from hhrrbanco where id = $id;