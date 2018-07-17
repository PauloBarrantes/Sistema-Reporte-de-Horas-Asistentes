
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
	FOREIGN KEY (Email) REFERENCES Asistente(Email) ON UPDATE CASCADE,
	PRIMARY KEY (Email,Ciclo, Anno, ID )
);

DROP TABLE Nombramiento;
DROP TABLE BloqueDeHorario;
DROP TABLE HorarioDelPeriodo;
DROP TABLE BloqueDeReporte;
DROP TABLE Periodo;
DROP TABLE Proyecto;
DROP TABLE Admin;
DROP TABLE Asistente;
DROP TABLE Empleado;