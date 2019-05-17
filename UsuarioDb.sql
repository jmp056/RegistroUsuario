create database UsuariosDb

use UsuariosDb

create table Usuarios
(
	IdUsuario int primary key identity,
	Nombre varchar(30) not null,
	Apellido varchar(30) not null,
	Email varchar (40) unique,
	NivelDeUsuario int not null check(NivelDeUsuario > 0 and NivelDeUsuario < 5),
	Usuario varchar(15) not null unique,
	Clave varchar(15) not null,
	FechaDeIngreso date constraint DFL_Usuario default getdate()
)