alter table PoliticaContraseña add NoContenerUsuario bit default 1 not null
alter table Usuarios add foreign key (IdEmpleado) references Empleados(IdEmpleado)

alter table Contraseñas add IdUsuario int null
alter table Contraseñas add foreign key (IdUsuario) references Usuarios(IdUsuario)

alter table Empleados add CodigoAcceso nvarchar (10) null
alter table Empleados add VencimientoCodigo datetime

update Empleados set Activo = 0 where IdEmpleado = 1
update Empleados set CodigoAcceso = null where IdEmpleado = 1
update Empleados set Mail = 'tumail@gmail.com' where IdEmpleado = 1
update Empleados set VencimientoCodigo = null where IdEmpleado = 1

update Empleados set CodigoAcceso = 'bGCnsT' where IdEmpleado = 1
update Empleados set VencimientoCodigo = NULL  where IdEmpleado = 1

select p.IdPregunta,u.IdUsuario,p.Pregunta
from RespuestaSeguridad r
inner join PreguntaSeguridad p on p.IdPregunta = r.IdPregunta
inner join Usuarios u on u.IdUsuario = r.IdUsuario
where r.IdUsuario = 2

drop table Contraseñas

ALTER TABLE Contraseñas
DROP column IdUsuario


drop table PoliticaContraseña

dbcc CHECKIDENT ('Empleados',RESEED,0)
select * from Usuarios
select * from Empleados
select * from Roles
select * from Usuario_Rol

SELECT fk.name
FROM sys.foreign_keys fk
JOIN sys.tables t
    ON fk.parent_object_id = t.object_id
WHERE t.name = 'Contraseñas';

update Usuarios set Fecha_Ultimo_Login = null where NombreUsuario = 'admin'
update Usuarios set Intentos_Sesion = 3 where NombreUsuario = 'admin'
update Usuarios set TiempoResetIntentos = null where NombreUsuario = 'admin'
update Usuarios set Bloqueado = 0 where NombreUsuario = 'admin'
update Usuarios set BloqueadoHasta = null where NombreUsuario = 'admin'


---------------------------------------------------------------
---------------------------------------------------------------
update Empleados set Activo = 0 where IdEmpleado = 1
exec sp_CargarCodigoAcceso
    @Codigo = 'bGCnsT',
    @Documento ='12345678';

select * from Empleados

DECLARE @Mensaje NVARCHAR(200);
DECLARE @Documento NVARCHAR(50);

EXEC sp_ValidaryDarAltaEmpleado
    @Codigo = 'bGCnsT',
    @Mensaje = @Mensaje OUTPUT,
    @Documento = @Documento OUTPUT;

SELECT @Mensaje AS Mensaje,
       @Documento AS Documento;

SELECT Documento, CodigoAcceso
FROM Empleados
WHERE CodigoAcceso = 'bGCnsT';

SELECT *
FROM Empleados
WHERE Documento = '12345678';

SELECT DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Empleados'
AND COLUMN_NAME = 'Documento';

UPDATE Empleados
SET CodigoAcceso = 'bGCnsT'
WHERE Documento = '12345678';

SELECT @@ROWCOUNT AS FilasAfectadas;

EXEC sp_CargarEmpleadoSesion
    @Documento = '12345678';

    SELECT *
FROM EmpleadoDireccion
WHERE IdEmpleado = (
    SELECT IdEmpleado
    FROM Empleados
    WHERE Documento = '12345678'
);

SELECT *
FROM Direcciones
WHERE IdDireccion = 1;

    SELECT
        e.Nombre,
        e.Apellido,
        e.Documento,
        e.Sexo,
        e.Genero,
        e.Fecha_Nac,
        e.Telefono,
        e.Mail,
        d.Calle,
        d.Numero,
        d.Piso,
        d.Departamento,
        d.CodigoPostal,
        l.Localidad
    FROM Empleados e
    LEFT JOIN EmpleadoDireccion ed
        ON e.IdEmpleado = ed.IdEmpleado
    LEFT JOIN Direcciones d
        ON ed.IdDireccion = d.IdDireccion
    LEFT JOIN Localidades l
        ON d.IdLocalidad = l.IdLocalidad
    WHERE e.Documento = '12345678';

        select e.Nombre,e.Apellido,e.Documento,e.Sexo,e.Genero,e.Fecha_Nac,e.Telefono,e.Mail,d.Calle,d.Numero,d.Piso,d.Departamento,d.CodigoPostal,l.Localidad
    from Empleados e
    inner join EmpleadoDireccion ed ON e.IdEmpleado = ed.IdEmpleado
    inner join Direcciones d ON ed.IdDireccion = d.IdDireccion
    inner join Localidades l ON d.IdLocalidad = l.IdLocalidad
    where e.Documento = '12345678';

    SELECT e.IdEmpleado,
       e.Documento,
       ed.IdDireccion
FROM Empleados e
LEFT JOIN EmpleadoDireccion ed
    ON e.IdEmpleado = ed.IdEmpleado
WHERE e.Documento = '12345678';
-------------------------------------------------------------------------
-------------------------------------------------------------------------

update Usuarios set IdContraseña = 1

delete from Roles where IdRol = 1
dbcc CHECKIDENT ('Roles',RESEED,1)
delete from Contraseñas
truncate table Contraseñas
truncate table Usuarios


SELECT 
    u.IdUsuario,
    u.NombreUsuario,
    r.Rol,
    c.HashContraseña,
    u.PrimeraVez,
    u.Intentos_Sesion,
    u.Fecha_Ultimo_Login 
FROM Usuarios u
INNER JOIN Roles r ON r.IdRol = u.IdRol
INNER JOIN Contraseñas c ON c.IdContraseña = u.IdContraseña;

SELECT u.IdUsuario,u.NombreUsuario,r.Rol,c.HashContraseña,u.PrimeraVez,u.Intentos_Sesion,u.TiempoResetIntentos,u.Fecha_Ultimo_Login,u.Bloqueado,u.BloqueadoHasta,u.TiempoResetIntentos
        FROM Usuarios u
        INNER JOIN Roles r ON r.IdRol = u.IdRol
        INNER JOIN Contraseñas c ON c.IdContraseña = u.IdContraseña
        WHERE u.NombreUsuario = 'admin'
        --HAY UN ERROR ACA



insert into Usuarios(NombreUsuario,IdRol,IdContraseña,PrimeraVez,Intentos_Sesion,Fecha_Ultimo_Login) values('Admin',1,1,0,3,getdate())

--Para cambiar la contraint de Activo que estaba en default 1 a 0, primero la elimino y luego creo una nueva
alter table Empleados
drop constraint
DF__Empleados__Activ__4F7CD00D;

GO

alter table Empleados
add constraint DF_Empleados_Activo
default((0)) for Activo;

go

exec sp_help 'Contraseñas'

ALTER TABLE Contraseñas
DROP CONSTRAINT FK__Contraseñ__IdUsu__17750979;

SELECT name
FROM sys.foreign_keys
WHERE parent_object_id = OBJECT_ID('Contraseñas');

ALTER TABLE Contraseñas
DROP CONSTRAINT FK__Contra__IdUsuario__177F90F9;
