--se usa la base de datos
use ProyectoLogin
go
--aca se crea una nueva tabla para las "Politicas de Seguridad"
create table PoliticasSeguridad (
    IdPolitica int primary key identity(1,1),
    LongitudMinima int default 8 NOT NULL,
    RequiereMayusculas bit default 0 NOT NULL,
    RequiereNumeros bit default 0 NOT NULL,
    RequiereEspeciales bit default 0 NOT NULL,
    NoRepetirContraseñas bit default 0 NOT NULL,
    CantidadPreguntasRequeridas int default 3 NOT NULL
);
go

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--aca se insertan valores predeterminados a los campos anterioremente creados  
insert into PoliticasSeguridad (LongitudMinima, RequiereMayusculas, RequiereNumeros, RequiereEspeciales, NoRepetirContraseñas, CantidadPreguntasRequeridas)
values (8, 0, 0, 0, 0, 3);
go