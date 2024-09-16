USE master
IF EXISTS (SELECT * FROM SYS.DATABASES WHERE NAME = 'Animal')
BEGIN
	ALTER DATABASE Animal SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE Animal;
END
GO

CREATE DATABASE Animal
GO

USE Animal
GO

CREATE TABLE Cattle
(
	id int primary key,
	type varchar(50) not null,
	quantity int not null,
	sound varchar(50) not null,
	milk int,
);
GO
INSERT INTO Cattle(id,type,quantity,sound,milk)
VALUES ('1','Bo',0,'um bo',0),
		('2','Cuu',0,'be be',0),
		('3','De',0,'de de',0)
SELECT * FROM Cattle