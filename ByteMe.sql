
USE DB_BYTEME;
---------------------------------------------------------------------------------------------
------------------------------- Creación de las tablas --------------------------------------
---------------------------------------------------------------------------------------------
CREATE TABLE Empleado(
	Email varchar(100) not null primary key,
	Contrasena binary (64) not null,
	NombreEmp varchar(50) not null,
	Apellido1 varchar(60) not null,
	Apellido2 varchar(60),
	Sexo varchar(1) ,
	salt UNIQUEIDENTIFIER
);
SELECT * FROM Empleado JOIN Asistente  On Asistente.Email = 'paulobarrantes@gmail.com' WHERE Empleado.Email = 'paulobarrantes@gmail.com'


CREATE TABLE Asistente(
	Email varchar(100) not null ,
	Carne varchar(6) not null,
	Cedula varchar(9) not null,
	Carrera varchar(50),
	Telefono varchar(8),
	HorasAcumuladas int ,

		PRIMARY KEY (Email),
	FOREIGN KEY (Email) References Empleado(Email) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Admin(
	Email varchar(100) not null,
	Rol int not null,
	PRIMARY KEY (Email),
	FOREIGN KEY (Email) References Empleado(Email)ON DELETE NO ACTION ON UPDATE CASCADE

);

CREATE TABLE Proyecto(
	Nombre varchar(50) not null,
	Estado varchar (20)  DEFAULT 'vigente',

	PRIMARY KEY (Nombre)
);


CREATE TABLE Periodo(
	Ciclo varchar(25) not null,
	Anno int  not null,


	PRIMARY KEY (Ciclo,Anno)
);

CREATE TABLE BloqueDeReporte(	
	Email varchar(100) not null,
	NombreProyecto varchar(50) not null,
	Fecha Date not null,
	HoraInicial Time not null,
	HoraFinal Time not null

	PRIMARY KEY(Email,NombreProyecto, Fecha, HoraInicial)
	
	FOREIGN KEY (NombreProyecto) REFERENCES Proyecto(Nombre) ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (Email) REFERENCES Asistente(Email)ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE HorarioDelPeriodo(
	Email varchar(100) not null,
	Ciclo varchar(25) not null,
	Anno int not null,


	PRIMARY KEY (Email, Ciclo, Anno),
	FOREIGN KEY (Ciclo, Anno) REFERENCES Periodo(Ciclo, Anno ),
	FOREIGN KEY (Email) REFERENCES Asistente(Email)ON DELETE CASCADE ON UPDATE CASCADE


);

CREATE TABLE BloqueDeHorario (
	Email varchar(100) not null,
	Ciclo varchar(25) not null,
	Anno int not null,
	Dia varchar(25) not null,
	HoraInicial time not null,
	HoraFinal time not null,


	PRIMARY KEY (Email, Ciclo, Anno,Dia, HoraInicial),
	FOREIGN KEY (Email,Ciclo, Anno) REFERENCES HorarioDelPeriodo(Email,Ciclo, Anno),
	CONSTRAINT inicioNormal CHECK (HoraInicial >= '08:00:00.0000000' AND HoraInicial <= '17:00:00.0000000 ') ,
	CONSTRAINT finNormal CHECK (HoraFinal >= '08:00:00.0000000' AND HoraFinal <= '17:00:00.0000000 ')

);

CREATE TABLE Nombramiento(
	Email varchar(100) not null,
	ID varchar (10) not null,
	Ciclo varchar(25) not null,
	Anno int not null,
	CantidadHoras int not null,
	EntidadNombradora varchar(10)  not null,
	TipoAsistente int not null,

	FOREIGN KEY (Ciclo, Anno) REFERENCES Periodo(Ciclo, Anno),
	FOREIGN KEY (Email) REFERENCES Asistente(Email),
	PRIMARY KEY (Email,Ciclo, Anno, ID )

);
select * from Nombramiento

DROP Table Nombramiento;
DROP TABLE BloqueDeHorario;
DROP TABLE HorarioDelPeriodo;
DROP TABLE BloqueDeReporte;
DROP TABLE Periodo;
DROP TABLE Proyecto;
DROP TABLE Admin;
DROP TABLE Asistente;
DROP TABLE Empleado;


---------------------------------------------------------------------------------------------
--------------------------- Creación de los procesos almacenados ---------------------------
---------------------------------------------------------------------------------------------


SELECT * FROM EMPLEADO;


-------------------------Procedimiento Almacenado 1 ------------------------------
GO
CREATE PROCEDURE AgregarAsistente
	--Parametros
	@email varchar(100),
	@contrasena Nvarchar(50),
	@nombre varchar(50),
	@apellido1 varchar(60),
	@apellido2 varchar(60),
	@carne varchar(6) ,
	@cedula varchar(9) ,
	@carrera varchar(50),
	@telefono varchar(8),
	@horasAcumuladas int,
	@estado bit OUTPUT
AS


BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID();

	BEGIN TRY
		INSERT INTO Empleado(Email, Contrasena, NombreEmp, Apellido1, Apellido2, salt) VALUES(@email, HASHBYTES('SHA2_512', @contrasena+CAST(@salt AS NVARCHAR(36))),@nombre,@apellido1,@apellido2, @salt);
		INSERT INTO Asistente(Email, Carne, Cedula, Carrera, Telefono, HorasAcumuladas) VALUES(@email,@carne, @cedula,@carrera ,@telefono,@horasAcumuladas);
		SET @estado = 1 
	END TRY
	BEGIN CATCH
		SET @estado = ERROR_MESSAGE()
		PRINT N'Eror'
		
	END CATCH


END;

DROP PROCEDURE AgregarAsistente

EXEC AgregarAsistente 'paulobarrantes@gmail.com', '123456', 'Paulo','Barrantes','Aguilar',
						'B60930', '117080092', 'Computacion', '83096579','50'

SELECT *  FROM ASISTENTE;
DROP PROCEDURE AgregarAsistente;
-------------------------Procedimiento Almacenado 2 ------------------------------
GO
CREATE PROCEDURE EliminarEmpleado
	@email varchar(100)
AS
DELETE FROM Empleado WHERE Empleado.Email = @email;
EXEC EliminarEmpleado 'k@gmail.com'


-------------------------Procedimiento Almacenado 3 ------------------------------

GO
CREATE PROCEDURE AgregarBloqueHoras
	@email varchar(100),
	@nombreProyecto varchar(50),
	@fecha Date,
	@horaInicial Time ,
	@horaFinal Time,
	@salida int OUTPUT
AS
	BEGIN
	BEGIN TRY
		INSERT INTO BloqueDeReporte(Email,NombreProyecto, Fecha, HoraInicial, HoraFinal) VALUES(
			@email,
			@nombreProyecto,
			@fecha,
			@horaInicial,
			@horaFinal
		);
		SET @salida = 1
	END TRY
	BEGIN CATCH
		SET @salida = ERROR_MESSAGE()
		PRINT N'Eror'
	END CATCH;
	END;

	drop procedure AgregarBloqueHoras

-------------------------Procedimiento Almacenado 4 ------------------------------
select * from empleado
GO
CREATE PROCEDURE AgregarNombramiento
	@email varchar(100),
	@id varchar (10),
	@ciclo varchar(25),
	@anno int,
	@cantidadHoras int,
	@entidadNombradora varchar(10),
	@tipoAsistente int,	
	@isInDB bit = 0 OUTPUT
AS

BEGIN
	INSERT INTO Nombramiento (Email, ID, Ciclo, Anno, CantidadHoras, EntidadNombradora, TipoAsistente)VALUES(
		@email,
		@id ,
		@ciclo,
		@anno ,
		@cantidadHoras,
		@entidadNombradora,
		@tipoAsistente
	);
	SET @isInDB = 1;
END;


INSERT INTO Periodo VALUES('I-Ciclo',2018);
exec AgregarNombramiento 'paulobarrantes@gmail.com', 'A12345', 'I-Ciclo',2018,10,'UCR',0;
-------------------------Procedimiento Almacenado 5 ------------------------------

GO
CREATE PROCEDURE Login @loginEmail Varchar(100), @loginPassword Nvarchar (50), @isInDB bit = 0 OUTPUT
AS
BEGIN
	DECLARE @email varchar(100)

	SET NOCOUNT ON

	IF EXISTS (SELECT TOP 1 Email From Empleado Where Email = @loginEmail)
		BEGIN
			SET @email =(SELECT TOP 1 Email From Empleado Where Email = @loginEmail
			AND Contrasena =HASHBYTES('SHA2_512', @loginPassword+CAST(Salt AS
				NVARCHAR(36))))

			IF(@email IS NULL)
				SET @isInDB = 0;
			ELSE
				SET @isInDB = 1;
		END

	ELSE
		SET @isInDB = 0;

END
-------------------------Procedimiento Almacenado 6 ------------------------------
GO
CREATE PROCEDURE AgregarPersonal
	--Parametros
	@email varchar(100),
	@contrasena Nvarchar(50),
	@nombre varchar(50),
	@apellido1 varchar(60),
	@apellido2 varchar(60),
	@rol int ,
	@estado bit OUTPUT
AS


BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID();

	BEGIN TRY
		INSERT INTO Empleado(Email, Contrasena, NombreEmp, Apellido1, Apellido2, salt) VALUES(@email, HASHBYTES('SHA2_512', @contrasena+CAST(@salt AS NVARCHAR(36))),@nombre,@apellido1,@apellido2, @salt);
		INSERT INTO Admin(Email, Rol) VALUES(@email,@rol);
		SET @estado = 1 
	END TRY
	BEGIN CATCH
		SET @estado = ERROR_MESSAGE()
		PRINT N'Eror'
		
	END CATCH
END;
EXEC AgregarPersonal 'admin@gmail.com', '123456', 'Admin','SuperAdmin','GG','1',2
EXEC AgregarPersonal 'secre@gmail.com', '123456', 'Secre','SuperSecre','GG','2',2
-------------------------Procedimiento Almacenado 7 ------------------------------
GO
CREATE PROCEDURE AgregarProyecto

	@nombre varchar(50),
	@estado varchar(20),
	@salida bit OUTPUT
AS

BEGIN
	BEGIN TRY
		INSERT INTO Proyecto (Nombre, Estado)VALUES(
			@nombre, @estado
		);
	END TRY
	BEGIN CATCH 
		SET @salida = ERROR_MESSAGE();

	END CATCH

END;
EXEC AgregarProyecto 'PR_Parrita','Activo',1

-------------------------Procedimiento Almacenado 8 ------------------------------
GO
CREATE PROCEDURE CambiarContrasena
	--Parametros
	@email varchar(100),
	@contrasena Nvarchar(50),
	
	@estado bit OUTPUT
AS


BEGIN
	--DECLARE @salt UNIQUEIDENTIFIER=NEWID();

	BEGIN TRY
		UPDATE Empleado 
		SET Empleado.Contrasena =  HASHBYTES('SHA2_512', @contrasena+CAST(Empleado.salt AS NVARCHAR(36)))
		WHERE Empleado.Email = @email;
		
		SET @estado = 1 
	END TRY
	BEGIN CATCH
		SET @estado = ERROR_MESSAGE()
		PRINT N'Eror'
		
	END CATCH
END;

EXEC CambiarContrasena 'paulobarrantes1@gmail.com','gg2',1

-------------------------Procedimiento Almacenado 9 ------------------------------
GO
CREATE PROCEDURE Rol
	--Parametros
	@email varchar(100),
	@rol int OUTPUT
	-- 0 Asistente
	-- 1 Administrador
	-- 2 Secretaria
AS


BEGIN
	
	IF (SELECT COUNT(*) FROM Asistente Where Asistente.Email = @email) = 1
		BEGIN
			PRINT N'ASISTENTE'
			SET @rol = 0
		END;
	ELSE
		BEGIN
			PRINT N'Empleado Administrativo'
			IF (SELECT Admin.Rol FROM Admin WHERE Admin.Email = @email) = 1
				BEGIN
					SET @rol = 1
					PRINT N'Administrador'
				END;
			ELSE
				BEGIN
					SET @rol = 2
					PRINT N'Secretaria'
				END;
		END;


END;
SELECT * FROM Nombramiento;
EXEC Rol 'admin@gmail.com',1
-------------------------Procedimiento Almacenado 10 ------------------------------

GO
CREATE PROCEDURE editarPerfil
    @nombre varchar(50),
    @apellido1 varchar (60),
    @apellido2 varchar(60),
    @cedula varchar(9),
    @email varchar(100),
    @carrera varchar(50),
    @carne int,
    @telefono varchar(8),
    @estado bit OUTPUT
AS

BEGIN
    UPDATE Empleado 
    SET    Email = @email,
             NombreEmp = @nombre,
            Apellido1 = @apellido1,
            Apellido2 = @apellido2;
    UPDATE Asistente 
    SET Cedula = @cedula,
            Carne = @carne,
            Carrera = @carrera,
            Telefono = @telefono;
    SET @estado = 1;
END;
-------------------------Procedimiento Almacenado 11 ------------------------------
GO
CREATE PROCEDURE AgregarBloqueHorario
	@email varchar(100),
	@ciclo varchar(25),
	@anno int,
	@dia varchar(25),
	@horaInicio TIME,
	@horaFinal TIME

---------------------------------------------------------------------------------------------
------------------------------ Creacion de los TRIGGERS ------------------------------------
---------------------------------------------------------------------------------------------

GO
CREATE TRIGGER GG
ON EMPLEADO
AFTER INSERT
	AS
		BEGIN

		END;
