-- MSSQL: 2022

USE Practice04;

IF NOT EXISTS (
    SELECT [name]
        FROM sys.tables
        WHERE [name] = N'Oficinas'
)
-- Crear una nueva tabla llamada "Oficinas":
CREATE TABLE Oficinas (
    ID INT PRIMARY KEY,
    Nombre VARCHAR(128) NOT NULL,
    Direccion VARCHAR(128) NOT NULL,
    Ciudad VARCHAR(128) NOT NULL,
    Estado VARCHAR(128) NOT NULL,
    Pais VARCHAR(128) NOT NULL,
    Division INT NOT NULL,
);