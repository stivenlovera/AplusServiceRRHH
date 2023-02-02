DROP TABLE IF EXISTS HHRRTipoDocumento;

CREATE TABLE
    HHRRTipoDocumento(
        id int AUTO_INCREMENT primary key,
        TipoDocumento VARCHAR(350) NOT NULL
    );

INSERT INTO
    `HHRRTipoDocumento`(`id`, `TipoDocumento`)
VALUES ('1', 'Cedula de itentidad'), (
        '2',
        'libreta de servicio militar'
    );

SELECT id,TipoDocumento FROM hhrrtipodocumento;

update hhrrtipodocumento
set
    TipoDocumento = TipoDocumento
where id = 'id';

delete from 
  hhrrtipodocumento 
where 
  id = $id;