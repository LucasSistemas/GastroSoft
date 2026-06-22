--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                        GEOGRAFIA
---------------------------------------------------------------------------------------------------

-- 1. NACIONALIDADES (Continuando tu lista)
insert into Nacionalidades (Nacionalidad) values ('Argentina')
insert into Nacionalidades (Nacionalidad) values ('Brasil')
insert into Nacionalidades (Nacionalidad) values ('Uruguay')
insert into Nacionalidades (Nacionalidad) values ('Chile')
insert into Nacionalidades (Nacionalidad) values ('Bolivia')
insert into Nacionalidades (Nacionalidad) values ('Peru')

-- 2. PROVINCIAS
-- Si CABA es ID 1, Buenos Aires será ID 2
insert into Provincias (Provincia, IdNacionalidad) VALUES ('Provincia de Buenos Aires', 1);
insert into Provincias (Provincia, IdNacionalidad) VALUES ('Buenos Aires', 1);
insert into Provincias (Provincia, IdNacionalidad) VALUES ('Cordoba', 1);
insert into Provincias (Provincia, IdNacionalidad) VALUES ('Santa Fe', 1);

-- 3. PARTIDOS (Para la Provincia de Buenos Aires, asumiendo IdProvincia = 1)
insert into Partidos (Partido,IdProvincia) values ('Lomas de Zamora',1)
insert into Partidos (Partido,IdProvincia) values ('Lanus',1)
insert into Partidos (Partido,IdProvincia) values ('Avellaneda',1)
insert into Partidos (Partido,IdProvincia) values ('Adrogue',1)
insert into Partidos (Partido,IdProvincia) values ('Florencio Varela',1)
insert into Partidos (Partido,IdProvincia) values ('Claypole',1)
insert into Partidos (Partido, IdProvincia) values ('Quilmes', 1);
insert into Partidos (Partido, IdProvincia) values ('Berazategui', 1);
insert into Partidos (Partido, IdProvincia) values ('La Matanza', 1);
insert into Partidos (Partido, IdProvincia) values ('Moron', 1);

-- Departamentos de Córdoba (IdProvincia = 3)
insert into Partidos (Partido, IdProvincia) values ('Capital', 3);
insert into Partidos (Partido, IdProvincia) values ('Colon', 3);
insert into Partidos (Partido, IdProvincia) values ('Punilla', 3);
insert into Partidos (Partido, IdProvincia) values ('Rio Cuarto', 3);
insert into Partidos (Partido, IdProvincia) values ('San Justo', 3);
insert into Partidos (Partido, IdProvincia) values ('Calamuchita', 3);
insert into Partidos (Partido, IdProvincia) values ('Santa Maria', 3);
insert into Partidos (Partido, IdProvincia) values ('General San Martin', 3);

-- 4. LOCALIDADES
--Localidades para Lomas de Zamora
insert into Localidades (Localidad,IdPartido) values ('Lomas de Zamora',1)
insert into Localidades (Localidad,IdPartido) values ('Temperley',1)
insert into Localidades (Localidad,IdPartido) values ('Lavallol',1)
insert into Localidades (Localidad,IdPartido) values ('Turdera',1)
insert into Localidades (Localidad,IdPartido) values ('Banfield',1)
insert into Localidades (Localidad,IdPartido) values ('Remedios de Escalada',2)
insert into Localidades (Localidad,IdPartido) values ('Gerli',2)

-- Para Lanús (Tu IdPartido = 2)
insert into Localidades (Localidad, IdPartido) values ('Lanus Este', 2);
insert into Localidades (Localidad, IdPartido) values ('Lanus Oeste', 2);
insert into Localidades (Localidad, IdPartido) values ('Monte Chingolo', 2);

-- Para Avellaneda (Tu IdPartido = 3)
insert into Localidades (Localidad, IdPartido) values ('Avellaneda Centro', 3);
insert into Localidades (Localidad, IdPartido) values ('Wilde', 3);
insert into Localidades (Localidad, IdPartido) values ('Dock Sud', 3);
insert into Localidades (Localidad, IdPartido) values ('Sarandi', 3);

-- Para Adrogué/Almirante Brown (Tu IdPartido = 4)
insert into Localidades (Localidad, IdPartido) values ('Jose Marmol', 4);
insert into Localidades (Localidad, IdPartido) values ('Rafael Calzada', 4);
insert into Localidades (Localidad, IdPartido) values ('Glew', 4);

-- Para Florencio Varela (Tu IdPartido = 5)
insert into Localidades (Localidad, IdPartido) values ('Bosques', 5);
insert into Localidades (Localidad, IdPartido) values ('Gobernador Costa', 5);

-- Localidades para el Departamento Capital (IdPartido = 11)
insert into Localidades (Localidad, IdPartido) values ('Cordoba City',11);

-- Localidades para Colon (IdPartido = 12)
insert into Localidades (Localidad, IdPartido) values ('Jesus Maria', 12);
insert into Localidades (Localidad, IdPartido) values ('Villa Allende', 12);
insert into Localidades (Localidad, IdPartido) values ('La Calera', 12);

-- Localidades para Punilla (IdPartido = 13)
insert into Localidades (Localidad, IdPartido) values ('Villa Carlos Paz', 13);
insert into Localidades (Localidad, IdPartido) values ('Cosquin', 13);
insert into Localidades (Localidad, IdPartido) values ('La Falda', 13);

-- Localidades para Rio Cuarto (IdPartido = 14)
insert into Localidades (Localidad, IdPartido) values ('Rio Cuarto', 14);
insert into Localidades (Localidad, IdPartido) values ('Vicuña Mackenna', 14);

-- Localidades para San Justo (IdPartido = 15)
insert into Localidades (Localidad, IdPartido) values ('San Francisco', 15);
insert into Localidades (Localidad, IdPartido) values ('Arroyito', 15);

-- Localidades para Santa Maria (IdPartido = 15)
insert into Localidades (Localidad, IdPartido) values ('Alta Gracia', 17);
insert into Localidades (Localidad, IdPartido) values ('Malagueño', 17);
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                     USUARIO,ROL,CONTRASEÑA DE ADMIN 
---------------------------------------------------------------------------------------------------

--Roles
insert into Roles(Rol,Descripcion)values('AdminMaster','Control total del sistema')

--Usuarios
insert into Usuarios(NombreUsuario,IdRol,IdContraseña,PrimeraVez,Intentos_Sesion,Fecha_Ultimo_Login) values('admin',1,1,0,3,getdate())

--Contraseña
insert into Contraseñas(HashContraseña)values('4976ca28d46c8bc0272cbbd32a3e34b28eafcfcd5835ba04dd79d400fdcf5092')

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                        BITACORA
---------------------------------------------------------------------------------------------------