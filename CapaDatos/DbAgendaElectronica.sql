CREATE DATABASE AgendaElectronica;

USE AgendaElectronica;

CREATE TABLE Contactos
(
	Id NVARCHAR(255) PRIMARY KEY NOT NULL,
	Codigo AS('COD-'+RIGHT(Id,4)) UNIQUE,
	Nombre NVARCHAR(50),
	Apellido NVARCHAR(50),
	FechaNacimiento DATE,
	Direccion NVARCHAR(100),
	Genero NVARCHAR(1),
	EstadoCivil NVARCHAR(2),
	Movil NVARCHAR(15),
	Telefono NVARCHAR(15),
	CoreoElectronico NVARCHAR(50)
);

--STORE PROCEDURE
GO
CREATE PROCEDURE SP_BUSCAR
	@Buscar NVARCHAR(30)
AS
	SELECT *
	FROM Contactos
	WHERE Nombre LIKE '%'+@Buscar+'%' OR Apellido LIKE '%'+@Buscar+'%';

GO
CREATE PROCEDURE SP_INSERTAR
	@Id NVARCHAR(255),
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@FechaNacimiento DATE,
	@Direccion NVARCHAR(100),
	@Genero NVARCHAR(1),
	@EstadoCivil NVARCHAR(2),
	@Movil NVARCHAR(15),
	@Telefono NVARCHAR(15),
	@CoreoElectronico NVARCHAR(50)
AS
	INSERT INTO Contactos VALUES
	(
		@Id, 
		@Nombre,
		@Apellido, 
		@FechaNacimiento, 
		@Direccion, 
		@Genero, 
		@EstadoCivil, 
		@Movil, 
		@Telefono, 
		@CoreoElectronico
	);

GO
CREATE PROCEDURE SP_MODIFICAR
	@Id NVARCHAR(255),
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@FechaNacimiento DATE,
	@Direccion NVARCHAR(100),
	@Genero NVARCHAR(1),
	@EstadoCivil NVARCHAR(2),
	@Movil NVARCHAR(15),
	@Telefono NVARCHAR(15),
	@CoreoElectronico NVARCHAR(50)
AS
	UPDATE Contactos
	SET Nombre = @Nombre,
		Apellido = @Apellido,
		FechaNacimiento = @FechaNacimiento,
		Direccion = @Direccion,
		Genero = @Genero,
		EstadoCivil = @EstadoCivil,
		Movil = @Movil,
		Telefono = @Telefono,
		CoreoElectronico = @CoreoElectronico
	WHERE Id = @Id;

GO
CREATE PROCEDURE SP_ELIMINAR
	@Id NVARCHAR(255)
AS
	DELETE FROM Contactos 
	WHERE Id = @Id;