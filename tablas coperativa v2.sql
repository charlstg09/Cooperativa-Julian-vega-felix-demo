

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


CREATE TABLE personal(
idPer INT PRIMARY KEY identity(1,1) NOT NULL,
idAre int not null,
nomPer VARCHAR(50) NOT NULL,
apePer VARCHAR(90) NOT NULL,
telPer VARCHAR(10) NOT NULL,
RFC varchar(16),
CURP varchar(18) NOT NULL,
foreign key (idAre) references area(idAre)
);

create table area (
	idAre int primary key identity(1,1) not null,
	desAre varchar(10) not null
);



create table compañia (
	idCom int primary key identity(1,1) not null,
	nomCom varchar(60) not null,
	encComp varchar(80) not null, 
	numComp varchar(10) not null, 
	emaComp varchar(80) not null,

);




create table exportar (
	idExp int identity(1,1) not null,
	idCom int not null,
	idMar int not null,
	pesTot decimal(10,2) not null,
	foreign key (idCom) references compañia(idCom),
	foreign key (idMar) references mariscos(idMar)

);



exec sp_rename 'proovedores', 'personal';


create table area (
	idAre int primary key identity(1,1) not null,
	desAre varchar(10) not null
);

insert into area values('limpieza')
insert into area values ('resaga')
insert into area values('bomba')

select * from area

create table personal (
	idCom int primary key identity(1,1) not null,
	idAre int not null,
	nomCom varchar(60) not null,
	encComp varchar(80) not null, 
	numComp varchar(10) not null, 
	emaComp varchar(80) not null,
	foreign key (idAre) references area(idAre)

);


/*revisar */
drop table personal

CREATE TABLE personal(
idPer INT PRIMARY KEY identity(1,1) NOT NULL,
idAre int not null,

nomPer VARCHAR(50) NOT NULL,
apePer VARCHAR(90) NOT NULL,
telPer VARCHAR(10) NOT NULL,
RFC varchar(16),
CURP varchar(18) NOT NULL,
foreign key (idAre) references area(idAre)
);

alter table mariscos add subTipoMarisco varchar(50) not null

alter table mariscos add PrecioMarisco varchar(50)

alter table mariscos alter column PrecioMarisco decimal(10,2)
