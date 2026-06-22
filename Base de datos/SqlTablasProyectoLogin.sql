--Se crea la base de datos
create database ProyectoLogin

go

--Se usa la base de datos
use ProyectoLogin

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

--Tablas geograficas
create table Nacionalidades(
IdNacionalidad int primary key identity,
Nacionalidad nvarchar(50)not null,
);

go

create table Provincias(
IdProvincia int primary key identity,
Provincia nvarchar(50)not null,
IdNacionalidad int not null,

foreign key (IdNacionalidad) references Nacionalidades(IdNacionalidad)
);

go

create table Partidos(
IdPartido int primary key identity,
Partido nvarchar(50) not null,
IdProvincia int not null,

foreign key (IdProvincia) references Provincias(IdProvincia)
);

go

create table Localidades(
IdLocalidad int primary key identity,
Localidad nvarchar(50)not null,
IdPartido int not null,
IdProvincia int not null,

foreign key (IdPartido) references Partidos(IdPartido),
foreign key (IdProvincia) references Provincias(IdProvincia)
);

go

create table Direcciones(
IdDireccion int primary key identity,
Calle nvarchar(150)not null,
Numero nvarchar(20)not null,
Piso nvarchar(10)null,
Departamento nvarchar(10)null,
Codigo_Postal int not null,
IdLocalidad int not null,

foreign key (IdLocalidad) references Localidades(IdLocalidad),
);

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
go

--Tablas de entidades reales
create table Empleados(
IdEmpleado int primary key identity,
Nombre nvarchar(50)not null,
Apellido nvarchar(50)not null,
Documento nvarchar(50)not null,
Sexo nvarchar (50)not null,
Genero nvarchar(50)not null,
Fecha_Nac date not null,
Telefono nvarchar(50)not null,
Mail nvarchar(50) not null,
IdDireccion int not null,
Activo bit default 0 not null,
Fecha_Registro datetime default getdate(),
Fecha_Alta datetime,

foreign key (IdDireccion) references Direcciones(IdDireccion)
);

go

create table Telefonos(
IdTelefono int primary key identity,
CodigoArea nvarchar (10)not null,
Telefono nvarchar(50)not null,
IdEmpleado int,
TipoTelefono nvarchar (50)not null,

foreign key (IdEmpleado) references Empleados(IdEmpleado),
);

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

--Tablas de Sistema
create table Roles(
IdRol int primary key identity,
Rol nvarchar(50)not null,
Descripcion nvarchar(100)not null
);

go

create table Permisos(
IdPermiso int primary key identity,
Permiso nvarchar (50)not null,
Descripcion nvarchar(100)not null
);

go

create table Usuarios(
IdUsuario int primary key identity,
NombreUsuario nvarchar(50)not null,
IdRol int not null,
IdContraseña int null,
Bloqueado bit default 0 not null,
BloqueadoHasta datetime null,
PrimeraVez bit default 1 not null,
Intentos_Sesion int default 3 not null,
TiempoResetIntentos datetime null,
Fecha_Ultimo_Login datetime,

foreign key (IdRol) references Roles(IdRol)
);

go

create table Contraseñas(
IdContraseña int primary key identity,
HashContraseña nvarchar(100) not null,


);

go

create table Historial_Contraseña(
IdHistorial int primary key identity,
Contraseña_Pasada nvarchar(100)not null,
Fecha_Modificasion datetime not null,
IdUsuario int not null,

foreign key (IdUsuario) references Usuarios(IdUsuario)
);

go

create table Pregunta_Seguridad(
IdPregunta int primary key identity,
Pregunta nvarchar(50)not null
);

go

create table Respuesta_Seguridad(
IdRespuesta int primary key identity,
Respuesta nvarchar(50)not null,
IdUsuario int not null,

foreign key (IdUsuario) references Usuarios(IdUsuario)
);

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

--Tablas de normalizacion
create table EmpleadoDireccion (
IdEmpleado int,
IdDireccion int,
primary key (IdEmpleado, IdDireccion),
foreign key (IdEmpleado) references Empleados(IdEmpleado),
foreign key (IdDireccion) references Direcciones(IdDireccion)
);

go

create table EmpleadoTelefono(
IdEmpTel int primary key identity,
IdEmpleado int,
IdTelefono int,

foreign key (IdEmpleado) references Empleados(IdEmpleado),
foreign key (IdTelefono) references Telefonos(IdTelefono),
);

go

create table Rol_Permiso(
IdRol int not null,
IdPermiso int not null,
Duracion datetime

foreign key (IdRol) references Roles(IdRol),
foreign key (IdPermiso) references Permisos(IdPermiso)
);

go

create table Usuario_Rol(
IdUsuario int not null,
IdRol int not null
primary key (IdUsuario,IdRol)
);

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

--Settings
create table Bitacora(
IdBitacora int primary key identity
);

go

create table Configuraciones(
IdConfiguracion int primary key identity
);







