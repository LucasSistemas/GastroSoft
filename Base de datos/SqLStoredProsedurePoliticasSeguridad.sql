USE ProyectoLogin;
GO

---------------------------------------------------------------------------------------------------
--                               OBTENER POLÍTICAS DE SEGURIDAD
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_ObtenerConfiguracionSeguridad
AS
BEGIN
    SET NOCOUNT ON;
    SELECT TOP 1 
        LongitudMinima, 
        RequiereMayusculas, 
        RequiereNumeros, 
        RequiereEspeciales, 
        NoRepetirContraseñas, 
        CantidadPreguntasRequeridas 
    FROM PoliticasSeguridad;
END;
GO

---------------------------------------------------------------------------------------------------
--                              MODIFICAR POLÍTICAS DE SEGURIDAD
---------------------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE sp_ModificarConfiguracionSeguridad
    @Longitud INT,
    @Mayus BIT,
    @Num BIT,
    @Esp BIT,
    @NoRep BIT,
    @CantPreg INT
AS
BEGIN
    SET NOCOUNT ON;
    
    UPDATE PoliticasSeguridad 
    SET 
        LongitudMinima = @Longitud, 
        RequiereMayusculas = @Mayus, 
        RequiereNumeros = @Num, 
        RequiereEspeciales = @Esp, 
        NoRepetirContraseñas = @NoRep, 
        CantidadPreguntasRequeridas = @CantPreg;
END;
GO