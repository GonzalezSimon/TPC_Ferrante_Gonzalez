use FerranteGonzalez_DB
go

INSERT into Paises(Nombre,Estado)
VALUES('Argentina',1),('Brasil',1),('Chile',1);

--select * from Paises

insert into Localidades(Nombre, IDPais, Estado)
VALUES('Buenos Aires', 1, 1),('Santa Fe', 1,1 );

--select * from Localidades

insert into TipoUsuario(TipoUsuario, Estado)
VALUES('A',1),('S',1),('C',1);

--select * from TipoUsuario

insert into Usuarios(Usuario, UPassword, Apellido, Nombre,Telefono, Mail, IDLocalidad, IDTipoUsuario, URLUsuario, FechaCreacion,EstadoUsuario)
VALUES
('admin','admin', 'ROTA', 'HOST','+5491133413847', 'rotahost@gmail.com', 1, 1,'https://e00-marca.uecdn.es/assets/multimedia/imagenes/2020/07/29/15960315220897.png', GETDATE(), 1),
('Test', 'Test','Testado', 'Jorge Bolanños','+5491154875498','test@test.test', 2, 3,'https://e00-marca.uecdn.es/assets/multimedia/imagenes/2020/07/29/15960315220897.png', GETDATE(), 1);

--select * from Usuarios

insert into TipoServicio(TipoServicio, Estado)
VALUES ('rFactor',1), ('rFactor2',1),('Asseto Corsa',1), ('CS:GO',1), ('CS 1.6',1), ('Automobilista',1), ('STC V3',1);

--select * from TipoServicio

insert into Servicios(IDTipoServicio, Slots, Descripcion, EstadoServicio, Precio)
VALUES
-- rFactor 1 lite
(1, 20, 'rFactor Liveracers Lite, 20 slots 30 dias', 1, 950),
(1, 25, 'rFactor Liveracers Lite, 25 slots 30 dias', 1, 1150),
(1, 30, 'rFactor Liveracers Lite, 30 slots 30 dias', 1, 1350),
(1, 35, 'rFactor Liveracers Lite, 35 slots 30 dias', 1, 1550),
(1, 40, 'rFactor Liveracers Lite, 40 slots 30 dias', 1, 1750),
(1, 45, 'rFactor Liveracers Lite, 45 slots 30 dias', 1, 1900),
--rFactor 1 Log Analyzer
(1, 20, 'rFactor Liveracers Lite + Log Analyzer, 20 slots 30 dias', 1, 1150),
(1, 25, 'rFactor Liveracers Lite + Log Analyzer, 25 slots 30 dias', 1, 1350),
(1, 30, 'rFactor Liveracers Lite + Log Analyzer, 30 slots 30 dias', 1, 1550),
(1, 35, 'rFactor Liveracers Lite + Log Analyzer, 35 slots 30 dias', 1, 1750),
(1, 40, 'rFactor Liveracers Lite + Log Analyzer, 40 slots 30 dias', 1, 1950),
(1, 45, 'rFactor Liveracers Lite + Log Analyzer, 45 slots 30 dias', 1, 2100),
--rFactor 1 Live Premium
(1, 20, 'rFactor Liveracers Premium, 20 slots 30 dias', 1, 1700),
(1, 25, 'rFactor Liveracers Premium, 25 slots 30 dias', 1, 1900),
(1, 30, 'rFactor Liveracers Premium, 30 slots 30 dias', 1, 2100),
(1, 35, 'rFactor Liveracers Premium, 35 slots 30 dias', 1, 2300),
(1, 40, 'rFactor Liveracers Premium, 40 slots 30 dias', 1, 2500),
(1, 45, 'rFactor Liveracers Premium, 45 slots 30 dias', 1, 2700),

(3, 30,'Servidor Asseto Corsa + Admin', 1, 1750);

--select * from servicios

--select ts.TipoServicio, IDServicio, Slots from Servicios
--join TipoServicio as ts o n ts.IDTipoServicio = IDServicio

insert into ServicioContratado(IDServicio, IDUsuario, FechaInicio, FechaFin, GrupoSoporte, EstadoSXC)
VALUES(2,2, GETDATE() , GETDATE()+1, 'rFactorTest',1)

select u.Nombre, s.Precio, sc.FechaFin from ServicioContratado as SC
inner JOIN Servicios as s on s.IDServicio = sc.IDServicio
inner join Usuarios as u on u.IDUsuario = sc.IDUsuario

select u.IDUsuario, u.Usuario, u.UPassword, u.Apellido, u.Nombre, u.Telefono, u.Mail, u.IDLocalidad, u.IDTipoUsuario, u.URLUsuario, u.FechaCreacion, u.EstadoUsuario from Usuarios as U inner join TipoUsuario  as TU on tu.IDTipoUsuario = u.IDTipoUsuario inner join Localidades as L on l.IDLocalidad = u.IDLocalidad inner join Paises as P on p.IDPais = l.IDPais


insert into Tickets(NombreGrupoSoporte, Descripcion, FechaApertura, FechaCierre, IDUsuario, EstadoTicket, Solucion, Estado)
VALUES('RF01', 'Cambiar circuito buenosaires', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF02', 'Cambiar circuito santafe', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF03', 'Cambiar circuito posadas', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF04', 'Cambiar circuito monza', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF05', 'Cambiar circuito nur', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF06', 'Cambiar circuito milozi', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF07', 'Cambiar circuito monza', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF08', 'Cambiar circuito nur', GETDATE(), null, 2, 'A', 'prueba', 1),
('RF09', 'Cambiar circuito milozi', GETDATE(), null, 2, 'A', 'prueba', 1)

--select * from tickets
select IDTicket, NombreGrupoSoporte, Descripcion, Solucion, FechaApertura, FechaCierre, EstadoTicket, t.Estado, T.IDUsuario IDUsuario, u.Usuario, u.UPassword, U.Apellido, U.Nombre, U.Telefono, U.Mail, L.IDLocalidad, L.Nombre, L.Estado, P.IDPais, P.Nombre, P.Estado from Tickets T, Usuarios U, Localidades L, Paises P where U.IDUsuario = T.IDUsuario and L.IDLocalidad = U.IDLocalidad and P.IDPais = L.IDPais 

UPDATE Tickets
set EstadoTicket = 'C'
where IDTicket = 2;