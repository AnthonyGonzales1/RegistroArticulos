create database AticulosBD

go
create table Articulos
(
	ArticuloID int primary key identity(1,1),
	FechaVC datetime,
	Descripcion varchar(20),
	Precio float,
	Existencia float,
	CantdidadCo float
);
