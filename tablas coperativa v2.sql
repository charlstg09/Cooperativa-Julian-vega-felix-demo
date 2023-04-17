

CREATE TABLE trabajadores(
idTra INT PRIMARY KEY identity(1,1) NOT NULL,
nomTra VARCHAR(50) NOT NULL,
apelTra VARCHAR(90) NOT NULL,
telTra VARCHAR(10) NOT NULL,
RFC varchar(16),
CURP varchar(18) NOT NULL
);

CREATE TABLE mariscos (
idMar INT PRIMARY KEY NOT NULL identity(1,1),
tipMariscos VARCHAR NOT NULL
);



select * from mariscos

delete from mariscos

DBCC CHECKIDENT (mariscos, RESEED, 0);

alter table mariscos alter column tipMariscos varchar(50)

insert into mariscos  values ('pescado') 
insert into mariscos (tipMariscos) values ('jaiba')

insert into mariscos  (tipMariscos) values ('camaron')

CREATE TABLE admins (
idAdm int primary key identity(1,1) not null,
nombre varchar(50) not null,
usuario varchar(50) not null,
contraseña varchar(50) not null

);





CREATE TABLE entrega (
idEnt INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
idMar INT NOT NULL,
idTra INT NOT NULL,
fecEnt DATE NOT NULL,
pesTot DECIMAL NOT NULL,
FOREIGN KEY (idMar) REFERENCES mariscos(idMar),
FOREIGN KEY (idTra) REFERENCES trabajadores(idTra)

);



select * from trabajadores;


insert into admins values('admin supremo', 'admin', '12345')
insert into admins values('carlos felix','charls','pelon')


select * from admins;


