use ProyectoLogin

go
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
insert into Roles(Rol,Descripcion)values('UsuarioGeneral','Acceso limitado a funcionalidades del sistema')

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
--                                        POLITICAS CONTRASEÑA
---------------------------------------------------------------------------------------------------
--aca se insertan valores predeterminados a los campos anterioremente creados  
insert into PoliticaContraseña (Longitud, Mayusculas, Numeros, CaracteresEspeciales, NoRepiteContraseña, CantidadPreguntas)values (8, 0, 0, 0, 0, 3);

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                        Permisos
---------------------------------------------------------------------------------------------------
INSERT INTO Permisos (Permiso, Descripcion) VALUES 
--AdminMaster(todos los permisos)		para agregar usar ('',''),    ;para finalizar la lista de permisos
('VER_USUARIOS', 'Permite ver el listado de usuarios del sistema'),
('GESTION_USUARIOS', 'Permite crear usuarios, asignarles empleados y editarlos'),
('BLOQUEAR_USUARIOS', 'Permite bloquear, desbloquear y resetear intentos de sesión de usuarios'),
('GESTION_ROLES', 'Permite crear roles y asignarles o quitarles permisos (Tabla Rol_Permiso)'),
('CONFIG_POLITICAS', 'Permite modificar las políticas de complejidad de contraseñas'),
('VER_BITACORA', 'Permite visualizar y filtrar el historial de acciones en la bitácora del sistema'),
--UsuarioGeneral(todos los de abajo)
('Acceso_EditarPerfil','Permite el acceso a la pantalla para modificar los propios datos'),
('Acceso_CambiarContrasena','Permite el acceso a la pantalla para cambiar la contraseña'),
--	UsuarioPedidos
('Acceso_Pedidos', 'Permite el acceso a la pantalla Pedidos'),
('Pedidos_AbrirMesa', 'Permite abrir mesas'),
('Pedidos_CerrarMesa', 'Permite abrir mesas'),
('Pedidos_NuevoPedidoBarra', 'Permite cargar un nuevo pedido en la barra'),
--	UsuarioStockMercaderia
('Acceso_StockMercaderia', 'Permite el acceso a la pantalla Stock de Mercaderia'),
('StockMercaderia_CargarExistencia', 'Permite cargar el stock existente'),
('StockMercaderia_ModificarProducto', 'Permite modificar los datos de los productos'),
('StockMercaderia_SolicitarMercaderia', 'Permite solicitar mercaderia'),
('StockMercaderia_VerListaProveedores', 'Permite ver la lista de proveedores'),
('StockMercaderia_EstablecerNiveles', 'Permite establecer los niveles de stock'),
--	UsuarioControlMozos
('Acceso_ControlMozos', 'Permite el acceso a la pantalla Control de Mozos'),
('ControlMozos_IngresarPago', 'Permite ingresar pago del mozo'),
--	UsuarioMenuRestaurante
('Acceso_MenuRestaurante', 'Permite el acceso a la pantalla Menu del Restaurante'),
('MenuRestaurante_AgregarMenuIndividual', 'Permite agregar un menu individual');

-- Le asignamos TODOS los permisos existentes al AdminMaster (IdRol = 1)

-- Usamos un INSERT basado en un SELECT para no hacerlo uno por uno
INSERT INTO Rol_Permiso (IdRol, IdPermiso, Duracion)
SELECT 1, IdPermiso, NULL FROM Permisos;
GO


-- Al UsuarioGeneral solo le damos permiso de editar su propio perfil y cambiar su contraseña (IdRol = 2)
INSERT INTO Rol_Permiso (IdRol, IdPermiso, Duracion) VALUES 
(2, (SELECT IdPermiso FROM Permisos WHERE Permiso = 'Acceso_EditarPerfil'), NULL),
(2, (SELECT IdPermiso FROM Permisos WHERE Permiso = 'Acceso_CambiarContrasena'), NULL);
GO

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                        Preguntas de Seguridad
---------------------------------------------------------------------------------------------------
INSERT INTO Pregunta_Seguridad (Pregunta)
VALUES 
(N'¿Cuál era el nombre de tu escuela?'),
(N'¿Cómo se llama tu mascota?'),
(N'¿Cuál es tu color favorito?'),
(N'¿Cuál es tu comida favorita?'),
(N'¿Cuál es tu deporte favorito?');
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                        Respuestas a preguntas de Seguridad del usuario admin
---------------------------------------------------------------------------------------------------
-- Borra respuestas de amin si las hubiera, la podriamos usar para resetear las respuestas de seguridad del usuario admin
DELETE FROM Respuesta_Seguridad 
WHERE IdUsuario = (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin');
GO

-- Cargamos las respuestas para las 5 preguntas del sistema
INSERT INTO Respuesta_Seguridad (IdPregunta, IdUsuario, Respuesta)
VALUES 
(
    (SELECT IdPregunta FROM Pregunta_Seguridad WHERE Pregunta LIKE '%escuela%'), 
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin'), 
    'Sarmiento'
),
(
    (SELECT IdPregunta FROM Pregunta_Seguridad WHERE Pregunta LIKE '%mascota%'), 
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin'), 
    'Firulais'
),
(
    (SELECT IdPregunta FROM Pregunta_Seguridad WHERE Pregunta LIKE '%color%'), 
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin'), 
    'Azul'
),
(
    (SELECT IdPregunta FROM Pregunta_Seguridad WHERE Pregunta LIKE '%comida%'), 
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin'), 
    'Asado'
),
(
    (SELECT IdPregunta FROM Pregunta_Seguridad WHERE Pregunta LIKE '%deporte%'), 
    (SELECT IdUsuario FROM Usuarios WHERE NombreUsuario = 'admin'), 
    'Futbol'
);
GO