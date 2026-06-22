alter table Usuarios add IdContraseña int null
alter table Usuarios add foreign key (IdContraseña) references Contraseñas(IdContraseña)
alter table Empleados set Activo bit default 0 not null 

update Empleados set Activo = 0 where IdEmpleado = 1


dbcc CHECKIDENT ('Empleados',RESEED,0)
select * from Empleados

select * from Contraseñas


update Usuarios set Fecha_Ultimo_Login = null where NombreUsuario = 'admin'
update Usuarios set Intentos_Sesion = 3 where NombreUsuario = 'admin'
update Usuarios set TiempoResetIntentos = null where NombreUsuario = 'admin'
update Usuarios set Bloqueado = 0 where NombreUsuario = 'admin'
update Usuarios set BloqueadoHasta = null where NombreUsuario = 'admin'

select * from Usuarios


update Usuarios set IdContraseña = 1

dbcc CHECKIDENT ('Contraseñas',RESEED,0)
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

exec sp_help 'Empleados'