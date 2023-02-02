-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas
DROP TABLE IF EXISTS HHRRPais;

CREATE TABLE
    HHRRPais(
        id int AUTO_INCREMENT primary key,
        NombrePais VARCHAR(350) NOT NULL
    );

SELECT id,`NombrePais` FROM hhrrpais;

insert into
    hhrrpais (id, `NombrePais`)
values ($id, $NombrePais);

update 
  hhrrpais 
set 
  NombrePais = NombrePais
where 
  id = 'id';
  
  delete from 
    hhrrpais 
  where 
    id = $id;