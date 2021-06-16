use FerranteGonzalez_DB
go

INSERT into Paises(Nombre)
VALUES('Argentina'),('Brasil'),('Chile');

--select * from Paises

insert into Localidades(Nombre, IDPais)
VALUES('Buenos Aires', 1),('Santa Fe', 1);

--select * from Localidades

insert into TipoUsuario(TipoUsuario)
VALUES('A'),('S'),('C');

--select * from TipoUsuario

insert into Usuarios(Usuario, UPassword, Apellido, Nombre, IDLocalidad, IDTipoUsuario, FechaCreacion,EstadoUsuario)
VALUES ('admin','admin', 'ROTA', 'HOST', 1, 1, GETDATE(), 1), ('Test', 'Test','Testado', 'Jorge Bolanños', 2, 3, GETDATE(), 1);

--select * from Usuarios

insert into TipoServicio(TipoServicio)
VALUES ('rFactor'), ('rFactor2'),('Asseto Corsa'), ('CS:GO'), ('CS 1.6'), ('Automobilista'), ('STC V3');

--select * from TipoServicio

insert into Servicios(IDTipoServicio, Slots, Descripcion, EstadoServicio)
VALUES (1, 20, 'rFactor Liveracers Lite, 20 slots 30 dias', 1),(3, 30,'Servidor Asseto Corsa + Admin',1 );

--select * from servicios

--select ts.TipoServicio, IDServicio, Slots from Servicios
--join TipoServicio as ts o n ts.IDTipoServicio = IDServicio

insert into ClienteXServicio(IDServicio, IDUsuario, FechaInicio, FechaFin, GrupoSoporte, EstadoSXC)
VALUES(2,2, GETDATE() , GETDATE()+1, 'rFactorTest',1)

select * from ClienteXServicio