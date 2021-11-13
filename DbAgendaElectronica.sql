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
	Genero NVARCHAR(15),
	EstadoCivil NVARCHAR(15),
	Movil NVARCHAR(15),
	Telefono NVARCHAR(15),
	CorreoElectronico NVARCHAR(50)
);

--STORE PROCEDURE
GO
CREATE PROCEDURE SP_FINDBYID
	@Id NVARCHAR(255)
AS
	SELECT *
	FROM Contactos
	WHERE Id = @Id
	ORDER BY Nombre ASC;

GO
CREATE PROCEDURE SP_FILTRAR
	@Filtrar NVARCHAR(30)
AS
	SELECT *
	FROM Contactos
	WHERE Nombre LIKE '%'+@Filtrar+'%' 
		OR Apellido LIKE '%'+@Filtrar+'%'
		OR Movil LIKE '%'+@Filtrar+'%'
		OR Telefono LIKE '%'+@Filtrar+'%'
	ORDER BY Nombre ASC;

GO
CREATE PROCEDURE SP_INSERTAR
	@Id NVARCHAR(255),
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@FechaNacimiento DATE,
	@Direccion NVARCHAR(100),
	@Genero NVARCHAR(15),
	@EstadoCivil NVARCHAR(15),
	@Movil NVARCHAR(15),
	@Telefono NVARCHAR(15),
	@CorreoElectronico NVARCHAR(50)
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
		@CorreoElectronico
	);

GO
CREATE PROCEDURE SP_MODIFICAR
	@Id NVARCHAR(255),
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@FechaNacimiento DATE,
	@Direccion NVARCHAR(100),
	@Genero NVARCHAR(15),
	@EstadoCivil NVARCHAR(15),
	@Movil NVARCHAR(15),
	@Telefono NVARCHAR(15),
	@CorreoElectronico NVARCHAR(50)
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
		CorreoElectronico = @CorreoElectronico
	WHERE Id = @Id;

GO
CREATE PROCEDURE SP_ELIMINAR
	@Id NVARCHAR(255)
AS
	DELETE FROM Contactos 
	WHERE Id = @Id;
