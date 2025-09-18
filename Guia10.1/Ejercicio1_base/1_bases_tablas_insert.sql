Use master 
GO 
 
drop database if exists Guia10_1_Ejercicio1_DB
GO
Create database Guia10_1_Ejercicio1_DB
GO 

Use Guia10_1_Ejercicio1_DB

GO 

Create Table Figuras
(
	Id INT IDENTITY (1,1),
	Tipo INT NOT NULL,-- 1 RECTANGULO  / 2 CIRCULO 
	Area Decimal (18,2),
	Ancho Decimal (18,2),
	Largo Decimal (18,2),
	Radio decimal (18,2),
	Constraint PK_Figura primary KEY (Id),
	Constraint C_Tipo Check (Tipo IN (1,2))
)

GO 


GO 

Insert into Figuras (Tipo,Ancho,Largo,Radio)
Values 
(1,1,1,null),
(1,1,1,null),
(1,2.2,1, null),
(2,null,null,2.1),
(2,null,null,2.1);


Select f.Id,
		CASE When f.Tipo=1 Then 'Rectangulo '
		When f.Tipo=2 THEN 'Circulo'
		Else 'No identificado'
		End,

		f.Area,
		f.Ancho,
		f.Largo,
		f.Radio
From Figuras f 

GO 
USE MASTER 
GO 