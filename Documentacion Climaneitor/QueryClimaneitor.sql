CREATE DATABASE Climaneitor;
USE Climaneitor;

GO
--DROP TABLE Pronosticos;
CREATE TABLE Pronosticos(
	id_pronosticos INT IDENTITY(1,1),
	mes int,	
	temperaturaMax FLOAT,
	temperaturaMin FLOAT,
	humedadMax FLOAT,
	humedadMin FLOAT,
	presionMax FLOAT,
	presionMin FLOAT,
	llovio BIT,
	CONSTRAINT pk_Pro 
	PRIMARY KEY (id_pronosticos)
);
GO
CREATE TABLE Pesos(
	id_peso int,
	pesoTemp float,
	pesoHum float,
	pesoPres float,
	pesoUmbral float,
	constraint pk_pesos
	primary key (id_peso)
);
insert into Pesos values(1,0,0,0,0);
insert into Pesos values(2,0,0,0,0);
insert into Pesos values(3,0,0,0,0);
insert into Pesos values(4,0,0,0,0);
insert into Pesos values(5,0,0,0,0);
insert into Pesos values(6,0,0,0,0);
insert into Pesos values(7,0,0,0,0);
insert into Pesos values(8,0,0,0,0);
insert into Pesos values(9,0,0,0,0);
insert into Pesos values(10,0,0,0,0);
insert into Pesos values(11,0,0,0,0);
insert into Pesos values(12,0,0,0,0);
-- select * from Pesos;
GO 
--drop procedure modpesos;
CREATE PROCEDURE modPesos(
	@pMes int,
	@pesT float,
	@pesH float,
	@pesP float,
	@pesU float
)as
BEGIN
	update Pesos
	set 
	pesoHum = @pesH,
	pesoPres = @pesP,
	pesoTemp = @pesT,
	pesoUmbral = @pesU
	where id_peso = @pMes;	
END
-- DROP PROCEDURE addPronostico;
GO
CREATE PROCEDURE addPronostico (
	@mes int,
	@temperaturaMax FLOAT,
	@temperaturaMin FLOAT,	
	@humedadMax FLOAT,
	@humedadMin FLOAT,
	@presionMax FLOAT,
	@presionMin FLOAT,	
	@llovio bit
)
AS
BEGIN
	INSERT INTO Climaneitor.dbo.Pronosticos 
	(
		mes,
		temperaturaMax,
		temperaturaMin,
		humedadMax,
		humedadMin,
		presionMax,
		presionMin,
		llovio
	)
	VALUES (
		@mes,
		@temperaturaMax ,
		@temperaturaMin ,
		@humedadMax ,
		@humedadMin ,
		@presionMax ,
		@presionMin ,
		@llovio
	)
END
--A fin de realizar pruebas, solo ejecute esos 5 procedures
GO
--select * from Pesos;
--delete from Pronosticos;
--select * from pronosticos; 
--Enero
EXECUTE addPronostico 1,34,21,78,38,1016,1014,0;
EXECUTE addPronostico 1,29,20,87,51,1017,1012,1;
EXECUTE addPronostico 1,29,17,92,47,1016,1012,1;
--Febrero
EXECUTE addPronostico 2,28,18,85,48,1020,1010,1;
EXECUTE addPronostico 2,29,20,60,51,1023,1019,0;
--EXECUTE addPronostico 2,29,20,87,51,1017,1012,0;
--EXECUTE addPronostico 2,29,20,87,51,1017,1012,0;
--Marzo
/*EXECUTE addPronostico 3,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 3,27,16,92,62,1018,1014,1;
EXECUTE addPronostico 3,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 3,29,20,87,51,1017,1012,0;
--Abril
EXECUTE addPronostico 4,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 4,27,16,92,62,1018,1014,1;
EXECUTE addPronostico 4,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 4,29,20,87,51,1017,1012,0;
--Mayo
EXECUTE addPronostico 5,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 5,27,16,92,62,1018,1014,1;
EXECUTE addPronostico 5,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 5,29,20,87,51,1017,1012,0;
--Junio
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
--Julio
EXECUTE addPronostico 7,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 7,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 7,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 7,29,20,87,51,1017,1012,0;
--Agosto
EXECUTE addPronostico 8,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 8,27,16,92,62,1018,1014,1;
EXECUTE addPronostico 8,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 8,29,20,87,51,1017,1012,0;
--Septiembre
EXECUTE addPronostico 9,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 9,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 9,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 9,29,20,87,51,1017,1012,0;
--Octubre
EXECUTE addPronostico 10,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 10,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 10,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 10,29,20,87,51,1017,1012,0;
--Noviembre
EXECUTE addPronostico 11,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 11,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 11,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 11,29,20,87,51,1017,1012,0;
--Diciembre
EXECUTE addPronostico 12,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 12,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
EXECUTE addPronostico 6,29,20,87,51,1017,1012,0;
*/
-- select * from Pronosticos;