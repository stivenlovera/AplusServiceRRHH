DROP TABLE IF EXISTS HHRRTipoCuenta;

CREATE TABLE
    HHRRTipoCuenta(
        id int AUTO_INCREMENT primary key,
        NombreTipoCuenta VARCHAR(350) NOT NULL
    );
    
SELECT id,`NombreTipoCuenta` FROM hhrrtipocuenta;

insert into
    hhrrtipocuenta (id, `NombreTipoCuenta`)
values ($id, $NombreTipoCuenta);

update hhrrtipocuenta
set
    NombreTipoCuenta = NombreTipoCuenta
where id = 'id';

delete from
    hhrrtipocuenta
where id = $id;