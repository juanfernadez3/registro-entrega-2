create database personaDB

use personaDB

	create table personas
	(
		Id int primary key identity ,
		nombre varchar(60),
		telefono varchar(16),
		cedula varchar(50),
		direccion varchar(70),
		fecha_nacimiento datetime

	)
	select * from Formulario_personaDB
