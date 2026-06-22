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
        and Codigo_Postal = @CodigoPostal 
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
        -- 2. Obtener los roles del usuario
        SELECT u.IdUsuario,u.NombreUsuario,r.Rol,c.HashContraseña,u.PrimeraVez,u.Intentos_Sesion,u.TiempoResetIntentos,u.Fecha_Ultimo_Login,u.Bloqueado,u.BloqueadoHasta,u.TiempoResetIntentos
        FROM Usuarios u
        INNER JOIN Roles r ON r.IdRol = u.IdRol
        INNER JOIN Contraseñas c ON c.IdContraseña = u.IdContraseña
        WHERE u.NombreUsuario = @Usuario
    END
    ELSE
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
    update Usuarios
    set Bloqueado = 1
    where NombreUsuario = @Usuario

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
--                                      Dar Alta Empleado 
---------------------------------------------------------------------------------------------------
create or alter procedure sp_DarAltaEmpleado
    @Documento int
as
begin
    update Empleados 
    set Activo = 0 
    where Documento = @Documento

    update Empleados
    set Fecha_Alta = GETDATE()
    where Documento = @Documento
end

go
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////

---------------------------------------------------------------------------------------------------
--                                      
---------------------------------------------------------------------------------------------------