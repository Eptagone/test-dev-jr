-- MSSQL: 2022

USE Practice04;

-- Si ya existe, borrarlo.
IF EXISTS (
SELECT *
    FROM INFORMATION_SCHEMA.ROUTINES
WHERE SPECIFIC_SCHEMA = N'dbo'
    AND SPECIFIC_NAME = N'insertOrUpdate'
    AND ROUTINE_TYPE = N'PROCEDURE'
)
DROP PROCEDURE dbo.insertOrUpdate
GO

-- Crear un nuevo procedimiento almacenado llamado "insertOrUpdate".
CREATE PROCEDURE dbo.insertOrUpdate
    @mode int
AS
BEGIN
    -- Si el modo es 1, insertar un nuevo registro.
    IF @mode = 1
    BEGIN
        INSERT INTO Oficinas (ID, Nombre, Direccion, Ciudad, Estado, Pais, Division)
        VALUES (1, 'The Office', 'Direccion 1', 'Monterrey', 'Nuevo Leon', 'Mexico', 1)
    END
    -- Si el modo es 0, actualizar el campo direccion del registro con ID = 1.
    ELSE IF @mode = 0
    BEGIN
        UPDATE Oficinas
        SET Direccion = 'Direccion 2'
        WHERE ID = 1
    END
END

-- Borrar todos los registros.
TRUNCATE TABLE Oficinas;

-- Ver registros actuales.
SELECT * FROM Oficinas;

-- Insertar un nuevo registro.
EXEC dbo.insertOrUpdate 1;

-- Ver registros actuales.
SELECT * FROM Oficinas;

-- Actualizar un registro existente.
EXEC dbo.insertOrUpdate 0;

-- Ver registros finales.
SELECT * FROM Oficinas;
