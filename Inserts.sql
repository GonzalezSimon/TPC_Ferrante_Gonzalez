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

--Select * from Juegos

--select * from TipoServicio

insert into Servicios(IDTipoServicio,IDJuego, Slots, Descripcion, EstadoServicio, Precio, URLServicio)
VALUES
--ARK--
(1,1, 20, 'ARK: Survival Evolved, 20 slots 30 dias', 1, 1200, 'Imgs/rflite.png'),
(1,1, 20, 'ARK: Survival Evolved, 30 slots 30 dias', 1, 1800, 'Imgs/rflite.png'),
(1,1, 20, 'ARK: Survival Evolved, 40 slots 30 dias', 1, 2300, 'Imgs/rflite.png'),
(1,1, 20, 'ARK: Survival Evolved, 50 slots 30 dias', 1, 2800, 'Imgs/rflite.png'),
-- rFactor 1 lite
(1,2, 20, 'rFactor Liveracers Lite, 20 slots 30 dias', 1, 950, 'Imgs/rflite.png'),
(1,2, 25, 'rFactor Liveracers Lite, 25 slots 30 dias', 1, 1150, 'Imgs/rflite.png'),
(1,2, 30, 'rFactor Liveracers Lite, 30 slots 30 dias', 1, 1350, 'Imgs/rflite.png'),
(1,2, 35, 'rFactor Liveracers Lite, 35 slots 30 dias', 1, 1550, 'Imgs/rflite.png'),
(1,2, 40, 'rFactor Liveracers Lite, 40 slots 30 dias', 1, 1750, 'Imgs/rflite.png'),
(1,2, 45, 'rFactor Liveracers Lite, 45 slots 30 dias', 1, 1900, 'Imgs/rflite.png'),
--rFactor 1 Log Analyzer
(1,2, 20, 'rFactor Liveracers Lite + Log Analyzer, 20 slots 30 dias', 1, 1150, 'Imgs/rflog.png'),
(1,2, 25, 'rFactor Liveracers Lite + Log Analyzer, 25 slots 30 dias', 1, 1350, 'Imgs/rflog.png'),
(1,2, 30, 'rFactor Liveracers Lite + Log Analyzer, 30 slots 30 dias', 1, 1550, 'Imgs/rflog.png'),
(1,2, 35, 'rFactor Liveracers Lite + Log Analyzer, 35 slots 30 dias', 1, 1750, 'Imgs/rflog.png'),
(1,2, 40, 'rFactor Liveracers Lite + Log Analyzer, 40 slots 30 dias', 1, 1950, 'Imgs/rflog.png'),
(1,2, 45, 'rFactor Liveracers Lite + Log Analyzer, 45 slots 30 dias', 1, 2100, 'Imgs/rflog.png'),
--rFactor 1 Live Premium
(1,2, 20, 'rFactor Liveracers Premium, 20 slots 30 dias', 1, 1700, 'Imgs/rfprem.png'),
(1,2, 25, 'rFactor Liveracers Premium, 25 slots 30 dias', 1, 1900, 'Imgs/rfprem.png'),
(1,2, 30, 'rFactor Liveracers Premium, 30 slots 30 dias', 1, 2100, 'Imgs/rfprem.png'),
(1,2, 35, 'rFactor Liveracers Premium, 35 slots 30 dias', 1, 2300, 'Imgs/rfprem.png'),
(1,2, 40, 'rFactor Liveracers Premium, 40 slots 30 dias', 1, 2500, 'Imgs/rfprem.png'),
(1,2, 45, 'rFactor Liveracers Premium, 45 slots 30 dias', 1, 2700, 'Imgs/rfprem.png');

--(3, 30,'Servidor Asseto Corsa + Admin', 1, 1750, 'Imgs/assettoc.png');


--select * from servicios

--select ts.TipoServicio, IDServicio, Slots from Servicios
--join TipoServicio as ts on ts.IDTipoServicio = IDServicio

select * from Suscripciones as s

insert into Suscripciones(IDServicio, IDUsuario, FechaInicio, FechaFin, GrupoSoporte, EstadoSXC)
VALUES
(2,2, GETDATE() , GETDATE()+1, 'rFactorTest',1),
(7,2, GETDATE() , GETDATE()+1, 'rFactorTest2',1),
(3,2, GETDATE() , GETDATE()+1, 'rFactorTest3',1),
(4,2, GETDATE() , GETDATE()+1, 'rFactorTest4',1),
(5,2, GETDATE() , GETDATE()+1, 'rFactorTest5',1),
(6,2, GETDATE() , GETDATE()+1, 'rFactorTest6',1)

select u.Nombre, s.Precio, sc.FechaFin from Suscripciones as SC
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

--query de tickets en negtickets
--select IDTicket, NombreGrupoSoporte, Descripcion, Solucion, FechaApertura, FechaCierre, EstadoTicket, t.Estado, T.IDUsuario IDUsuario, u.Usuario, u.UPassword, U.Apellido, U.Nombre, U.Telefono, U.Mail, L.IDLocalidad, L.Nombre, L.Estado, P.IDPais, P.Nombre, P.Estado from Tickets T, Usuarios U, Localidades L, Paises P where U.IDUsuario = T.IDUsuario and L.IDLocalidad = U.IDLocalidad and P.IDPais = L.IDPais 
--select * from Juegos
UPDATE Tickets
set EstadoTicket = 'C'
where IDTicket = 2;