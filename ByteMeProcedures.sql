USE DB_BYTEME;

---------------------------------------------------------------------------------------------
--------------------------- Creación de los procesos almacenados ---------------------------
---------------------------------------------------------------------------------------------

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

DROP PROCEDURE AgregarBloqueHoras

-------------------------Procedimiento Almacenado 4 ------------------------------

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
EXEC AgregarNombramiento 'paulobarrantes@gmail.com', 'A12345', 'I-Ciclo',2018,10,'UCR',0;


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
END;


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
				END
		END
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
    @emailNuevo varchar(100),
		@emailViejo varchar(100),
    @carrera varchar(50),
    @carne int,
    @telefono varchar(8),
    @estado bit OUTPUT
AS
BEGIN
	BEGIN TRY
    UPDATE Empleado
    SET    Email = @emailNuevo,
             NombreEmp = @nombre,
            Apellido1 = @apellido1,
            Apellido2 = @apellido2;
		WHERE Email = @emailViejo;
    UPDATE Asistente
    SET Cedula = @cedula,
            Carne = @carne,
            Carrera = @carrera,
            Telefono = @telefono;
		WHERE Email = @emailViejo;
		SET @estado = 1
	END TRY
	BEGIN CATCH
		SET @estado = ERROR_MESSAGE()
		PRINT N'Eror'
	END CATCH
END;


-------------------------Procedimiento Almacenado 11 ------------------------------

GO
CREATE PROCEDURE AgregarBloqueHorario
	@email varchar(100),
	@ciclo varchar(25),
	@anno int,
	@dia varchar(25),
	@horaInicio TIME,
	@horaFinal TIME,
	@estado int OUTPUT
AS
BEGIN
	BEGIN TRY
		INSERT INTO BloqueDeHorario(Email, Ciclo, Anno, Dia, HoraInicial, HoraFinal) VALUES(@email, @ciclo, @anno, @dia, @horaInicio, @horaFinal)
		SET @estado = 1
	END TRY
	BEGIN CATCH
		SET @estado = ERROR_MESSAGE()
		PRINT N'Eror'

	END CATCH
END;

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
