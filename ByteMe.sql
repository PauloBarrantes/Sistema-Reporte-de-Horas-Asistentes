
USE DB_BYTEME;
---------------------------------------------------------------------------------------------
------------------------------- Creaci�n de las tablas --------------------------------------
---------------------------------------------------------------------------------------------
CREATE TABLE Empleado(
	Email varchar(100) not null primary key,
	Contrase�a varchar (255) not null,
	NombreEmp binary(64) not null,
	Apellido1 varchar(60) not null,
	Apellido2 varchar(60)
	salt UNIQUEIDENTIFIER
);

CREATE TABLE Asistente(
	Email varchar(100) not null ,
	Carn� varchar(6) not null,
	C�dula varchar(9) not null,
	Carrera varchar(50),
	Tel�fono varchar(8),
	HorasAcumuladas int ,



	PRIMARY KEY (Email),
	FOREIGN KEY (Email) References Empleado(Email) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Admin(
	Email varchar(100) not null,
	Rol int not null,
	PRIMARY KEY (Email),
	FOREIGN KEY (Email) References Empleado(Email)

);

CREATE TABLE Proyecto(
	Nombre varchar(50) not null,
	Estado varchar (20)  DEFAULT 'vigente',


	PRIMARY KEY (Nombre)
);


CREATE TABLE Periodo(
	Ciclo varchar(25) not null,
	A�o int  not null,


	PRIMARY KEY (Ciclo,A�o)
);

CREATE TABLE BloqueDeReporte(
	NombreProyecto varchar(50) not null,
	Fecha Date not null,
	HoraInicial Time not null,
	HoraFinal Time not null

	PRIMARY KEY(NombreProyecto, Fecha, HoraInicial)
	FOREIGN KEY (NombreProyecto) REFERENCES Proyecto(Nombre)

);

CREATE TABLE HorarioDelPeriodo(
	Email varchar(100) not null,
	Ciclo varchar(25) not null,
	A�o int not null,


	PRIMARY KEY (Email, Ciclo, A�o),
	FOREIGN KEY (Ciclo, A�o) REFERENCES Periodo(Ciclo, A�o),
	FOREIGN KEY (Email) REFERENCES Asistente(Email)


);

CREATE TABLE BloqueDeHorario (
	Email varchar(100) not null,
	Ciclo varchar(25) not null,
	A�o int not null,
	Dia date not null,
	HoraInicial time not null,
	HoraFinal time not null,


	PRIMARY KEY (Email, Ciclo, A�o,Dia, HoraInicial),
	FOREIGN KEY (Email,Ciclo, A�o) REFERENCES HorarioDelPeriodo(Email,Ciclo, A�o),
	CONSTRAINT inicioNormal CHECK (HoraInicial >= '08:00:00.0000000' AND HoraInicial <= '17:00:00.0000000 ') ,
	CONSTRAINT finNormal CHECK (HoraFinal >= '08:00:00.0000000' AND HoraFinal <= '17:00:00.0000000 ')

);

CREATE TABLE Nombramiento(
	Email varchar(100) not null,
	ID varchar (10) not null,
	Ciclo varchar(25) not null,
	A�o int not null,
	CantidadHoras int not null,
	EntidadNombradora int  not null,
	TipoAsistente int not null,

	FOREIGN KEY (Ciclo, A�o) REFERENCES Periodo(Ciclo, A�o),
	FOREIGN KEY (Email) REFERENCES Asistente(Email),
	PRIMARY KEY (Email,Ciclo, A�o, ID )

);



---------------------------------------------------------------------------------------------
--------------------------- Creaci�n de los procesos almacenados ---------------------------
---------------------------------------------------------------------------------------------





-------------------------Procedimiento Almacenado 1 ------------------------------
GO
CREATE PROCEDURE AgregarAsistente
	--Parametros
	@email varchar(100),
	@contrase�a Nvarchar(50),
	@nombre varchar(50),
	@apellido1 varchar(60),
	@apellido2 varchar(60),
	@carn� varchar(6) ,
	@c�dula varchar(9) ,
	@carrera varchar(50),
	@tel�fono varchar(8),
	@horasAcumuladas int
AS

BEGIN
	DECLARE @salt UNIQUEIDENTIFIER=NEWID()

	BEGIN TRY
		INSERT INTO Empleado VALUES(@email, HASHBYTES('SHA2_512', @contrase�a+CAST(@salt AS NVARCHAR(36))),
		@nombre,@apellido1,@apellido2, @salt);
	END TRY



	INSERT INTO Asistente VALUES(@email,@carn�, @c�dula,@carrera ,@tel�fono,@horasAcumuladas);
END;

EXEC AgregarAsistente 'paulobarrantes@gmail.com', '123456', 'Paulo','Barrantes','Aguilar',
						'B60930', '117080092', 'Computacion', '83096579','50'

SELECT *  FROM ASISTENTE;
-------------------------Procedimiento Almacenado 2 ------------------------------

go
CREATE PROCEDURE EliminarEmpleado
	@email varchar(100)
AS
DELETE FROM Empleado WHERE Empleado.Email = @email;

EXEC EliminarEmpleado 'paulobarrantes@gmail.com'

-------------------------Procedimiento Almacenado 3 ------------------------------

GO
CREATE PROCEDURE AgregarBloqueHoras
	@nombreProyecto varchar(50),
	@fecha Date,
	@horaInicial Time ,
	@horaFinal Time
AS

	BEGIN
		INSERT INTO BloqueDeReporte VALUES(
			@nombreProyecto,
			@fecha,
			@horaInicial,
			@horaFinal
		);
	END;


-------------------------Procedimiento Almacenado 4 ------------------------------

GO
CREATE PROCEDURE AgregarNombramiento
	@email varchar(100),
	@id varchar (10),
	@ciclo varchar(25),
	@a�o int,
	@cantidadHoras int,
	@entidadNombradora int,
	@tipoAsistente int

AS

BEGIN
	INSERT INTO Nombramiento VALUES(
		@email,
		@id ,
		@ciclo,
		@a�o ,
		@cantidadHoras,
		@entidadNombradora,
		@tipoAsistente
	);

END;
-------------------------Procedimiento Almacenado 5 ------------------------------


CREATE PROCEDURE Login
	@loginEmail Varchar(100)
	@loginPassword Varchar(255)
	@isInDB bit = 0 OUTPUT
AS
BEGIN

	SET NOCOUNT ON
	@email varchar(100)
	IF EXIST (SELECT TOP 1 Email From Empleado Where Email = @loginEmail)
		BEGIN
			SET @email =(SELECT TOP 1 Email From Empleado Where Email = @loginEmail
			AND Contrase�a�=HASHBYTES('SHA2_512', @pPassword+CAST(Salt AS
				NVARCHAR(36))))

			IF(@email IS NULL)
				SET @isInDB = 0;
			ELSE
				SET @isInDB = 1;
		END

	ELSE
		SET @isInDB = 0;

END

---------------------------------------------------------------------------------------------
------------------------------ Creaci�n de los TRIGGERS ------------------------------------
---------------------------------------------------------------------------------------------

GO
CREATE TRIGGER GG
ON EMPLEADO
AFTER INSERT
	AS
		BEGIN

		END;
