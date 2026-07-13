--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                    REGISTRAR EMPLEADO
---------------------------------------------------------------------------------------------------
--Prosedimieto almacenado
CREATE OR ALTER PROCEDURE sp_Registro_Empleado
    @Nombre             NVARCHAR(50),
    @Apellido           NVARCHAR(50),
    @Documento         NVARCHAR(50),
    @Sexo              NVARCHAR(50),
    @Genero            NVARCHAR(50),
    @Fecha_Nac         DATE,
    @Telefono          NVARCHAR(50) = NULL,
    @Mail              NVARCHAR(50) = NULL,

    @Calle             NVARCHAR(50),
    @Numero            NVARCHAR(50),
    @Piso              NVARCHAR(50) = NULL,
    @Departamento      NVARCHAR(50) = NULL,
    @CodigoPostal      INT,
    @IdLocalidad       INT,
    
    @IdEmpleado        INT OUTPUT

AS
BEGIN
    SET NOCOUNT ON;
    -- Declaro el parametro id de la direccion
    DECLARE @IdDireccion INT;

    -- Inicializar parámetro de salida
    SET @IdEmpleado = 0;
    
    BEGIN TRY
        BEGIN TRANSACTION;

        -- =====================================================
        -- 1° PARTE: BUSCO LA EXISTENCIA DE LA DIRECCION
        -- =====================================================

        SELECT @IdDireccion = IdDireccion
        FROM Direcciones 
        WHERE Calle = @Calle 
        and Numero = @Numero 
        and Piso = @Piso 
        and Departamento = @Departamento 
        and CodigoPostal = @CodigoPostal 
        and IdLocalidad = @IdLocalidad;

        -- =====================================================
        -- 2° PARTE: SI NO EXISTE, INSERTAR LA DIRECCION
        -- =====================================================

        -- Insertar la dirección
        IF @IdDIRECCION IS NULL
        BEGIN
            INSERT INTO Direcciones (Calle, Numero, Piso, Departamento,CodigoPostal, IdLocalidad)
            VALUES (@Calle, @Numero, @Piso, @Departamento,@CodigoPostal, @IdLocalidad);
        
            -- Obtener el ID de la dirección recien insertada
            SET @IdDireccion = SCOPE_IDENTITY();
        END

        -- ========== VALIDACIONES ==========
        
        -- Validar que el documento no exista
        IF EXISTS (SELECT 1 FROM Empleados WHERE Documento = @Documento)
        BEGIN
            RAISERROR('Ya existe un empleado registrado con el documento indicado.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        
        -- Validar fecha de nacimiento (no puede ser futura)
        IF @Fecha_Nac > GETDATE()
        BEGIN
            RAISERROR('La fecha de nacimiento no puede ser futura.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END

        
        -- ========== INSERCIÓN ==========
        INSERT INTO Empleados (
            Nombre, Apellido, Documento, Sexo, Genero, 
            Fecha_Nac, Telefono, Mail, IdDireccion, Activo)
        VALUES (
            @Nombre, @Apellido, @Documento, @Sexo, @Genero, 
            @Fecha_Nac, @Telefono, @Mail, @IdDireccion, 1
        );

        SET @IdEmpleado = SCOPE_IDENTITY();
        
        COMMIT TRANSACTION;
        
    END TRY
    BEGIN CATCH
        -- Si hay error, rollback
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;
    END CATCH
END
GO
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                       INICIAR SESION
---------------------------------------------------------------------------------------------------
Create or alter procedure sp_Iniciar_Sesion
    @Usuario    nvarchar (50)
as
begin
    -- 1. Verificar que el usuario existe
    IF EXISTS (select 1 from Usuarios where NombreUsuario= @Usuario)
    BEGIN
        -- 2. Devuelve todos los datos del usuario
        SELECT u.IdUsuario,u.NombreUsuario,r.Rol,c.HashContraseña,u.PrimeraVez,u.Intentos_Sesion,u.TiempoResetIntentos,u.Fecha_Ultimo_Login,u.Bloqueado,u.BloqueadoHasta,e.Documento
        FROM Usuarios u
        INNER JOIN Roles r ON r.IdRol = u.IdRol
        INNER JOIN Contraseñas c ON c.IdContraseña = u.IdContraseña
        LEFT JOIN Empleados e on e.IdEmpleado = u.IdEmpleado
        WHERE u.NombreUsuario = @Usuario  
    end
    else
    BEGIN
        -- Credenciales inválidas - devolver vacío
        SELECT NULL WHERE 1=0;
    END
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                             Actualizar Fecha Ultimo Login
---------------------------------------------------------------------------------------------------
create or alter procedure sp_Actualizar_FechaUltimoLogin
    @Usuario nvarchar (50)
as
begin
    UPDATE Usuarios
    SET Fecha_Ultimo_Login = GETDATE()
    WHERE NombreUsuario = @Usuario;
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                       Restar Intentos
---------------------------------------------------------------------------------------------------
create or alter procedure sp_RestarIntentos
    @Usuario nvarchar (50)
as
    DECLARE @Intentos INT
begin
    --Cargo la variable intetos con el resultado del select
    select @Intentos = Intentos_Sesion 
    from Usuarios 
    where NombreUsuario = @Usuario

    --Verifica que si es 0,no siga restando
    IF (@Intentos > 0)
    BEGIN

    --Resta un intento
    update Usuarios
    set Intentos_Sesion = Intentos_Sesion -1
    where NombreUsuario = @Usuario

    --Para volver a tener los intentos de sesion debera esperar 1 hora
    update Usuarios
    set TiempoResetIntentos = Dateadd(hour,1,GETDATE())
    where NombreUsuario = @Usuario

    --Selecciona los intentos que le quedan luego de restar 1 intento
    select Intentos_Sesion
    from Usuarios
    where NombreUsuario = @Usuario
    end
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                                       Reiniciar Intentos
---------------------------------------------------------------------------------------------------
create or alter procedure sp_ReiniciarIntentos
    @Usuario nvarchar (50)
as

begin
    Update Usuarios
    set Intentos_Sesion = 3
    where NombreUsuario = @Usuario

    update Usuarios
    set TiempoResetIntentos = null
    where NombreUsuario = @Usuario

end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////


---------------------------------------------------------------------------------------------------
--                                       Bloquear Usuario
---------------------------------------------------------------------------------------------------
create or alter procedure sp_BloquearUsuario
    @Usuario nvarchar (50)
as
begin
    --Bloquea el usuario
    update Usuarios
    set Bloqueado = 1
    where NombreUsuario = @Usuario

    --Establece la duracion del bloqueo
    update Usuarios
    set BloqueadoHasta = Dateadd(minute,10,GETDATE())
    where NombreUsuario = @Usuario and Intentos_Sesion <= 0
     
    select Bloqueado
    from Usuarios
    where NombreUsuario = @Usuario
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                  Validar y Dar Alta Empleado 
---------------------------------------------------------------------------------------------------
create or alter procedure sp_ValidaryDarAltaEmpleado
    @Codigo nvarchar (25),
    @Mensaje nvarchar(200) output,
    @Documento nvarchar (50) output
as
    declare @FechaVencimiento datetime
begin
    --Valida el codigo
    if exists (select 1 from Empleados where CodigoAcceso = @Codigo)
    begin

        --Carga la variable @FechaVencimiento con le fecha de vencimiento del codigo
        select @FechaVencimiento = VencimientoCodigo
        from Empleados
        where @Codigo = CodigoAcceso

        --Carga la variable @Documento con el documento del empleado que tiene este codigo
        select @Documento = Documento
        from Empleados
        where @Codigo = CodigoAcceso

        if (@FechaVencimiento > getdate())
        begin
            
            --Da Alta al empleado
            update Empleados 
            set Activo = 1
            where Documento = @Documento

            --Coloca la fecha que fue dada el alta
            update Empleados
            set Fecha_Alta = GETDATE()
            where Documento = @Documento

            --Borra el codigo
            update Empleados
            set CodigoAcceso = null
            where Documento = @Documento

            --Borra la fecha de vencimiento
            update Empleados
            set VencimientoCodigo = null
            where Documento = @Documento

            -- Mensaje de exito
            set @Mensaje = 'Código de acceso válido. Continúe con la creación del usuario.';
        end
        else
        begin
            -- Mensaje de error
            set @Mensaje = 'El codigo fue caducado! Comuniquese con el administrador e intentelo de nuevo.';
        end
    end
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                      Cargar Codigo Para Alta
---------------------------------------------------------------------------------------------------
create or alter procedure sp_CargarCodigoAcceso
    @Codigo nvarchar (25),
    @Documento nvarchar (50)
as
begin
    --Carga el codigo
    update Empleados
    set CodigoAcceso = @Codigo
    where Documento = @Documento

    --Coloca la fecha de vencimiento del codigo
    update Empleados
    set VencimientoCodigo = Dateadd(day,1,GETDATE())
    where Documento = @Documento
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                      Cargar Empleado Sesion
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_CargarEmpleadoSesion
    @Documento NVARCHAR(50)
AS
BEGIN
    SELECT e.Nombre,e.Apellido,e.Documento,e.Sexo,e.Genero,e.Fecha_Nac,e.Telefono,e.Mail,d.Calle,d.Numero,d.Piso,d.Departamento,d.CodigoPostal,l.Localidad
    FROM Empleados e
    INNER JOIN Direcciones d
        ON e.IdDireccion = d.IdDireccion
    INNER JOIN Localidades l
        ON d.IdLocalidad = l.IdLocalidad
    WHERE e.Documento = @Documento;
END

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                               OBTENER POLÍTICAS DE SEGURIDAD
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_ObtenerConfiguracionSeguridad
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 
        Longitud, 
        Mayusculas, 
        Numeros, 
        CaracteresEspeciales, 
        NoRepiteContraseña, 
        CantidadPreguntas,
        ValidarDatosPersonales
    FROM PoliticaContraseña;
END;
GO
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                              MODIFICAR POLÍTICAS DE SEGURIDAD
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_ModificarConfiguracionSeguridad
    @Longitud INT,
    @Mayusculas BIT,
    @Numeros BIT,
    @CaracteresEspeciales BIT,
    @NoRepiteContraseña BIT,
    @CantidadPreguntas INT,
    @ValidarDatosPersonales BIT
AS
BEGIN
    SET NOCOUNT ON;

    
    UPDATE PoliticaContraseña 
    SET 
        Longitud = @Longitud, 
        Mayusculas = @Mayusculas, 
        Numeros = @Numeros, 
        CaracteresEspeciales = @CaracteresEspeciales,
        NoRepiteContraseña = @NoRepiteContraseña, 
        CantidadPreguntas = @CantidadPreguntas,
        ValidarDatosPersonales = @ValidarDatosPersonales;
END;
GO

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                               OBTENER PREGUNTAS DE SEGURIDAD Y ALEATORIAS
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_ObtenerPreguntasAleatorias
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Cantidad INT;

    -- Primero se Busca cuántas preguntas exigen las politicas actuales
    SELECT TOP 1 @Cantidad = CantidadPreguntas FROM PoliticaContraseña;
    
    -- Si por algún motivo no hay políticas creadas, por defecto se traeran 3
    IF @Cantidad IS NULL SET @Cantidad = 3;

    -- Y por ultimo se elligen pregtuntas de forma aleatoria usando NEWID(), gracias papa sql
    SELECT TOP (@Cantidad) IdPregunta, Pregunta 
    FROM PreguntaSeguridad
    ORDER BY NEWID();
END;
GO

--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                               GUARDAR RESPUESTAS DE LAS PREGUNTAS DE SEGURIDAD
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_GuardarRespuestaUsuario
    @IdUsuario INT,
    @IdPregunta INT,
    @Respuesta NVARCHAR(250)
AS
BEGIN
    SET NOCOUNT ON;

    -- se inserta la respuesta
    INSERT INTO RespuestaSeguridad (IdUsuario, IdPregunta, RespuestaHash)
    VALUES (@IdUsuario, @IdPregunta, @Respuesta);

    --- actualizamos al usuario para que ya no sea su "Primera Vez"
    UPDATE Usuarios 
    SET PrimeraVez = 0 
    WHERE IdUsuario = @IdUsuario;
END;
GO
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--/////////////////////////////////////////////////////////V//////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
---------------------------------------------------------------------------------------------------
--                              CREAR NUEVO USUARIO
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_CrearNuevoUsuario
    @Usuario nvarchar (50),
    @HashContraseña nvarchar (100),
    @Documento nvarchar (50)
as
    declare @IdEmpleado int
    declare @IdContraseña int
begin
    --Se carga la variable @IdEmpleado
    select @IdEmpleado = IdEmpleado
    from Empleados
    where Documento = @Documento

    --Se ingresa la contraseña
    insert into Contraseñas(HashContraseña)
    values(@HashContraseña)

    -- Se obtiene el id de la ultimo registro
    SET @IdContraseña = SCOPE_IDENTITY();

    --Se ingresa el usuario
    insert into Usuarios(NombreUsuario,IdRol,IdContraseña,PrimeraVez,Intentos_Sesion,Fecha_Ultimo_Login,IdEmpleado) 
    values(@Usuario,2,@IdContraseña,1,3,getdate(),@IdEmpleado)

end