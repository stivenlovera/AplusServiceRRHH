-- Active: 1673442535968@@127.0.0.1@3306@aplus_empresas

SELECT id,`NombreDepartamento`,`HHRRPaisId` FROM hhrrdepartamento;

update 
  hhrrdepartamento 
set 
  NombreDepartamento = NombreDepartamento,
  HHRRPaisId = HHRRPaisId
where 
  id = 'id';
  
  insert into 
    hhrrdepartamento (
      id, 
      `NombreDepartamento`, 
      `HHRRPaisId`
    )
  values
    (
      $id, 
      $NombreDepartamento, 
      $HHRRPaisId
    );
    
    update 
      hhrrdepartamento 
    set 
      NombreDepartamento = NombreDepartamento,
      HHRRPaisId = HHRRPaisId
    where 
      id = 'id';
      
      delete from 
        hhrrdepartamento 
      where 
        id = $id;