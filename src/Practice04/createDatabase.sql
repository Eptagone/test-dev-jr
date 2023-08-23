-- Crear una nueva base de datos llamada "Practice04".

USE master
GO

-- Crear la base de datos si no existe.
IF NOT EXISTS (
    SELECT [name]
        FROM sys.databases
        WHERE [name] = N'Practice04'
)
CREATE DATABASE Practice04
GO