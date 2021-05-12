--Creacion base de datos
USE MASTER
GO
CREATE DATABASE FastCarlos 
GO
USE FastCarlos
--Creacion tablas
CREATE TABLE Categorias
(
	Cod_categoria int identity(1,1) NOT NULL PRIMARY KEY,
	Categoria varchar(80) NOT NULL,
	Imagen image
)
CREATE TABLE Productos
(
	Cod_producto int identity(1,1) NOT NULL PRIMARY KEY,
	Nombre varchar(80) NOT NULL,
	Cod_categoria int NOT NULL,
	Precio money NOT NULL,
	Descripcion varchar(200) NOT NULL,
	Stock int NOT NULL,
	MinutosPreparacion double precision NOT NULL,
	Imagen image
	CONSTRAINT FK_Producto_Categoria FOREIGN KEY (Cod_categoria) REFERENCES Categorias(Cod_categoria)
)
CREATE TABLE Usuarios
(
	Cod_usuario int identity(1,1) NOT NULL PRIMARY KEY,
	Nombres varchar(70) NOT NULL,
	Apellidos varchar(70) NOT NULL,
	DUI char(10) NOT NULL,
	Tipo varchar(10) NOT NULL
)
CREATE TABLE Ordenes
(
	Cod_orden int identity(1,1) PRIMARY KEY,
	Id_orden char(10) NOT NULL,
	Cod_producto int NOT NULL,
	Cantidad int NOT NULL,
	Estatus char(15) DEFAULT 'En Proceso'
	CONSTRAINT FK_Ordenes_Producto FOREIGN KEY (Cod_producto) REFERENCES Productos(Cod_producto)
)
--Creacion procedimientos almacenados
GO
CREATE PROCEDURE sp_update_status (@id_orden char(10), @Estatus char(15))
AS
	UPDATE Ordenes SET Estatus = @Estatus WHERE Id_orden = @id_orden
GO
CREATE PROCEDURE sp_ETA_order (@id_orden char(10))
AS
	SELECT SUM(O.Cantidad * P.MinutosPreparacion)
	FROM Ordenes O
	INNER JOIN Productos P ON P.Cod_producto = O.Cod_producto
	WHERE Id_orden = @id_orden
GO
--Creacion trigger
CREATE TRIGGER UpdateStock ON Ordenes AFTER INSERT
AS
	DECLARE @cant INT, @id_prod INT;
	SELECT @cant = Cantidad, @id_prod = Cod_producto
	FROM inserted
	UPDATE Productos SET Stock -= @cant WHERE Cod_producto = @id_prod;
GO
--Insercion de datos
INSERT INTO Categorias VALUES
	('Pizza', (SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\pizza.jpg', SINGLE_BLOB) Imagen)),
	('Hamburguesa', (SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa.jpg', SINGLE_BLOB) Imagen)),
	('Pasta', (SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\pasta.jpg', SINGLE_BLOB) Imagen)),
	('Bebida', (SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\bebida.jpg', SINGLE_BLOB) Imagen)),
	('Postre', (SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\postre.jpg', SINGLE_BLOB) Imagen))
INSERT INTO Productos VALUES
	('Pizza doble queso',1,8.99,'Deliciosa pizza doble queso',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pizza\doblequeso_pizza.jpg', SINGLE_BLOB) Imagen)),
	('Pizza de Pepperoni',1,6.99,'Deliciosa pizza de pepperoni',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pizza\pepperoni_pizza.jpg', SINGLE_BLOB) Imagen)),
	('Pizza de Jamón',1,5.99,'Deliciosa pizza de jamon',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pizza\jamon_pizza.jpg', SINGLE_BLOB) Imagen)),
	('Pizza de Hongos',1,7.99,'Deliciosa pizza de hongos',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pizza\hongos_pizza.jpg', SINGLE_BLOB) Imagen)),
	('Dulzona',2,8.0000,'1lb de res, salsa de mango, tocino y mozzarella',100,3,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\dulzona.png', SINGLE_BLOB) Imagen)),
	('La Jayana',2,15.0000,'1lb 1/2 de res, huevo, 3 quesos y tocino',100,5,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\jayana.png', SINGLE_BLOB) Imagen)),
	('Semáforo',2,8.0000,'tocino,cheddar y aguacate',100,3,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\semaforo.png', SINGLE_BLOB) Imagen)),
	('Chente',2,8.0000,'1/2 lb de res, guacamol,chirimol,jalapeño y mozzarella',100,3,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\chente.png', SINGLE_BLOB) Imagen)),
	('Garage',2,8.0000,'1/2 lb de res, aros de cebolla, salsa, vegetales, tocino y cheddar',100,3,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\garage.png', SINGLE_BLOB) Imagen)),
	('Sabrosa',2 ,8.5000 ,'1/2 lb de res, cebolla curtida, aguacate y mozzarella', 100, 4,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\hamburguesa\sabrosa.png', SINGLE_BLOB) Imagen)),
	('Pasta Toscana',3 ,8.5000 ,'Bañado en salsa blanca cremosa con champiñones, cebolla caramelizada, tomates cherry salteados y prosciutto italiano',100,5,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\toscana.png', SINGLE_BLOB) Imagen)),
	('Pasta de pollo y loroco',3 ,7.8000 ,'Pasta corta bañada en una cremosa salsa de pollo y loroco, tomate, albahaca y queso parmesano rallado',100,5,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\pollo y loroco.png', SINGLE_BLOB) Imagen)),
	('Ravioles de mozzarella',3,7.8000,'Ravioles rellenos conuna mezcla de queso mozzarella con albahaca y salsa pomodoro',100,5,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\mozzarella.png', SINGLE_BLOB) Imagen)),
	('Lasagna Clásica',3,8.5000,'Un clásico italiano. Capas de pasta con salsa bolognesa, pomodoro y bechamel',100,5,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\lasagna.png', SINGLE_BLOB) Imagen)),
	('Pasta Florentina',3,7.7000,'Pasta corta bañada en salsa florentina de espinaca y hongos',100,4,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\florentina.png', SINGLE_BLOB) Imagen)),
	('Alla bolognesa',3,7.7000,'Spaghetti bañado con salsa bolognesa hecha con carme molida, queso parmesano rallado y albahaca fresca',100,4,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Pastas\alla bolognesa.png', SINGLE_BLOB) Imagen)),
	('Cheesecake de fresa',5,2.9500,'Famoso cheesecake servido con un baño de mermelada de fresa',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\cheesecake fresa.png', SINGLE_BLOB) Imagen)),
	('Cheesecake de oreo',5,2.9500,'Cheesecake que contiene trozos de galleta oreo',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\cheesecake oreo.png', SINGLE_BLOB) Imagen)),
	('Pie de banano',5,2.9500,'Pie sabor a banano con canela',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\pie de banano.png', SINGLE_BLOB) Imagen)),
	('Pie de pecana',5,2.9500,'Pie que contiene semillas pecanas, almendra y nueces',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\pie de pecana.png', SINGLE_BLOB) Imagen)),
	('Tres leches',5,5.5000,'Pastel de vainilla, bañado con tres diferentes tipos de leche y cubierto de suave turrón',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\tres leches.png', SINGLE_BLOB) Imagen)),
	('Postre de melocotón',5,1.9000,'Torta suave de vainilla relleno y decorado con melocotón y crema chantilly acompanado de una deliciosa salsa de melocoton',100,2,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Postres\postre de melocoton.png', SINGLE_BLOB) Imagen)),
	('Sprite',4,1.0000,'250ml, bebida gaseosa con sabor a lima limón y sin cafeína',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\sprite.png', SINGLE_BLOB) Imagen)),
	('Coca Cola',4,1.0000,'250ml, bebida gaseosa',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\coca cola.png', SINGLE_BLOB) Imagen)),
	('Fanta',4,1.0000,'250ml, bebida gaseosa con sabor a naranja',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\fanta.png', SINGLE_BLOB) Imagen)),
	('Café Americano',4,0.7500,'Taza de café procesado por una máquina de Expreso',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\cafe americano.jpg', SINGLE_BLOB) Imagen)),
	('Pilsener',4,2.0000,'330ml, cerveza',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\pilsener.png', SINGLE_BLOB) Imagen)),
	('Regia',4,2.0000,'330ml, cerveza',100,1,(SELECT * FROM OPENROWSET(BULK N'C:\Users\r2zam\OneDrive\Escritorio\Images\Bebidas\regia.png', SINGLE_BLOB) Imagen))
INSERT INTO Usuarios VALUES
	('Juan Alberto','Sayes', '00943314-7','Cliente')