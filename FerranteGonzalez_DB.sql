

--use master

--go

--create database FerranteGonzalez_DB
--go

use FerranteGonzalez_DB
go

create table Paises(
	IDPais int not null primary key identity(1,1),
	Nombre varchar(50) unique not null,
	Estado BIT not null,
	)
go
create table Localidades(
	IDLocalidad bigint not null primary key identity(1,1),
	Nombre varchar(50) not null,
	IDPais int not null foreign key references Paises(IDPais),
	Estado BIT not null,
	)
go
create table TipoUsuario(
	IDTipoUsuario int not null primary key identity(1,1),
	TipoUsuario char(1) not null check(TipoUsuario = 'A' or TipoUsuario = 'S' or TipoUsuario = 'C'),
	Estado bit not null
)
go
create table Usuarios(
	IDUsuario bigint not null primary key identity(1,1),
	Usuario varchar(50) not null unique,
	UPassword varchar(50) not null,
	Apellido varchar(50) not null,
	Nombre varchar(50) not null,
	Telefono varchar(20),
	Mail varchar(100) not null,
	IDLocalidad bigint not null foreign key references Localidades(IDLocalidad),
	IDTipoUsuario int not null foreign key references TipoUsuario(IDTipoUsuario),
	URLUsuario varchar(300) not null,
	FechaCreacion date not null,
	EstadoUsuario bit not null
)
go
create table TipoServicio(
	IDTipoServicio int not null primary key identity(1,1),
	TipoServicio varchar(20) not null,
	Estado bit not null
)
go
create table Servicios(
	IDServicio bigint not null primary key identity(1,1),
	IDTipoServicio int not null foreign key references TipoServicio(IDTipoServicio),
	Precio money not null,
	Descripcion varchar(250),
	Slots int check(Slots >= 0),
	EstadoServicio bit not null,

)
go
create table ServicioContratado(
	IDServicio bigint not null foreign key references Servicios(IDServicio),
	IDUsuario bigint not null foreign key references Usuarios(IDUsuario),
	IDDelegado1 bigint foreign key references Usuarios(IDUsuario),
	IDDelegado2 bigint foreign key references Usuarios(IDUsuario),
	FechaInicio date,
	FechaFin date,
	GrupoSoporte varchar(30) not null,
	EstadoSXC bit not null,

	Primary key(IDServicio, IDUsuario)
)
go

create table Tickets(
	IDTicket bigint not null primary key identity(1,1),
	NombreGrupoSoporte varchar(30) not null,
	Descripcion varchar(1000) not null,
	FechaApertura date not null,
	FechaCierre date,
	IDUsuario bigint not null foreign key references Usuarios(IDUsuario),
	EstadoTicket char(1) not null check (EstadoTicket = 'A' or EstadoTicket = 'R' or EstadoTicket = 'C' or EstadoTicket = 'P'),
	Solucion varchar(100) not null,
	Estado bit not null
)

alter table ServicioContratado
add constraint CHK_ServicioContratado
check(FechaInicio < FechaFin)