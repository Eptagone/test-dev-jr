-- MSSQL: 2022

USE Practice04;

-- Borra la secuencia "IDOFICINA_SEC" si ya existe.
IF EXISTS (
    SELECT *
        FROM sys.sequences
        WHERE [name] = N'IDOFICINA_SEC'
)
DROP SEQUENCE IDOFICINA_SEC
GO
-- Crear una nueva secuencia llamada "IDOFICINA_SEC".
CREATE SEQUENCE IDOFICINA_SEC
    START WITH 100
    INCREMENT BY 1;

-- Crear un nuevo trigger llamado "OficinaInsertTrigger".
GO
CREATE OR ALTER TRIGGER OficinaInsertTrigger
    ON Oficinas
    INSTEAD OF INSERT
AS
BEGIN
    -- Insertar el valor de la secuencia IDOFICINA_SEC en el campo ID.
    INSERT INTO Oficinas
        (ID, Nombre, Direccion, Ciudad, Estado, Pais, Division)
    SELECT NEXT VALUE FOR IDOFICINA_SEC, Nombre, Direccion, Ciudad, Estado, Pais, Division
    FROM inserted;
END
GO

-- Borrar todos los registros.
TRUNCATE TABLE Oficinas;

-- Ver registros actuales.
SELECT * FROM Oficinas;

-- Insertar un nuevo registro.
INSERT INTO Oficinas
    (Nombre, Direccion, Ciudad, Estado, Pais, Division)
VALUES
    ('The Office', 'Direccion 1', 'Monterrey', 'Nuevo Leon', 'Mexico', 1),
    ('The Office 2', 'Direccion 1', 'Guadalupe', 'Nuevo Leon', 'Mexico', 1),
    ('The Office 3', 'Direccion 1', 'San Pedro Garza Garcia', 'Nuevo Leon', 'Mexico', 1);

-- Ver registros actuales.
SELECT * FROM Oficinas;