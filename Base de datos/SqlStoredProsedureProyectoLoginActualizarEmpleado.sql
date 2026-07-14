use ProyectoLogin

go

CREATE OR ALTER PROCEDURE sp_CargarEmpleadoSesion --este sp ya estaba creado
    @Documento NVARCHAR(50)
AS
BEGIN
    -- Agregamos e.IdEmpleado al inicio del SELECT
    SELECT 
        e.IdEmpleado, 
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
        d.Codigo_Postal,
        l.Localidad
    FROM Empleados e
    INNER JOIN Direcciones d
        ON e.IdDireccion = d.IdDireccion
    INNER JOIN Localidades l
        ON d.IdLocalidad = l.IdLocalidad
    WHERE e.Documento = @Documento;
END
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
--///////////////////////////////////////////////////////////////////////////
GO

CREATE PROCEDURE sp_Actualizar_Empleado
    @IdEmpleado INT,
    @Nombre NVARCHAR(50),
    @Apellido NVARCHAR(50),
    @Documento NVARCHAR(50),
    @Sexo NVARCHAR(50),
    @Genero NVARCHAR(50),
    @Fecha_Nac DATE,
    @Telefono NVARCHAR(50),
    @Mail NVARCHAR(50),
    @Calle NVARCHAR(150),
    @Numero NVARCHAR(20),
    @Piso NVARCHAR(10) = NULL,
    @Departamento NVARCHAR(10) = NULL,
    @CodigoPostal INT,
    @IdLocalidad INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Obtenemos el IdDireccion asignado a este empleado
        DECLARE @IdDireccion INT;
        
        SELECT @IdDireccion = IdDireccion 
        FROM Empleados 
        WHERE IdEmpleado = @IdEmpleado;

        -- Si el empleado existe, procedemos a actualizar
        IF @IdDireccion IS NOT NULL
        BEGIN
            -- 2. Actualizamos la tabla de Direcciones primero
            UPDATE Direcciones
            SET Calle = @Calle,
                Numero = @Numero,
                Piso = @Piso,
                Departamento = @Departamento,
                Codigo_Postal = @CodigoPostal,
                IdLocalidad = @IdLocalidad
            WHERE IdDireccion = @IdDireccion;

            -- 3. Actualizamos la tabla de Empleados después
            UPDATE Empleados
            SET Nombre = @Nombre,
                Apellido = @Apellido,
                Documento = @Documento,
                Sexo = @Sexo,
                Genero = @Genero,
                Fecha_Nac = @Fecha_Nac,
                Telefono = @Telefono,
                Mail = @Mail
            WHERE IdEmpleado = @IdEmpleado;

            COMMIT TRANSACTION;
        END
        ELSE
        BEGIN
            -- Si no se encontró el empleado, cancelamos la transacción
            ROLLBACK TRANSACTION;
            RAISERROR('El empleado especificado no existe.', 16, 1);
        END

    END TRY
    BEGIN CATCH
        -- En caso de cualquier error (ej. claves foráneas), deshacemos los cambios
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        -- Repercutimos el error para que la capa de datos (C#) lo capture en el catch
        DECLARE @ErrorMessage NVARCHAR(4000) = ERROR_MESSAGE();
        DECLARE @ErrorSeverity INT = ERROR_SEVERITY();
        DECLARE @ErrorState INT = ERROR_STATE();
        
        RAISERROR(@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_ObtenerRespuestasSeguridad
    @IdUsuario INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        RS.IdRespuestaSeguridad,
        RS.IdPregunta,
        P.Pregunta,
        RS.Respuesta
    FROM RespuestaSeguridad RS
    INNER JOIN PreguntaSeguridad P ON RS.IdPregunta = P.IdPregunta
    WHERE RS.IdUsuario = @IdUsuario;
END;
GO
------------------------------------------------------------------------------------------------------------------
CREATE PROCEDURE sp_ActualizarRespuestaSeguridad
    @IdUsuario INT,
    @IdPregunta INT,
    @NuevaRespuesta NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    -- Verificamos si ya existe el registro para ese usuario y esa pregunta
    IF EXISTS (SELECT 1 FROM Respuesta_Seguridad WHERE IdUsuario = @IdUsuario AND IdPregunta = @IdPregunta)
    BEGIN
        UPDATE Respuesta_Seguridad
        SET Respuesta = @NuevaRespuesta
        WHERE IdUsuario = @IdUsuario AND IdPregunta = @IdPregunta;
        
        PRINT 'Respuesta de seguridad actualizada con éxito.';
    END
    ELSE
    BEGIN
        RAISERROR('Error: El usuario no tiene registrada una respuesta para esa pregunta.', 16, 1);
    END
END;
GO