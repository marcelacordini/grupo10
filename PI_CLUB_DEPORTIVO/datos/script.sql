CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    clave VARCHAR(100)
);

INSERT INTO usuario (nombre, clave) VALUES ('Emma', '12345');

CREATE TABLE cliente (
	id INT AUTO_INCREMENT PRIMARY KEY,
	nombre VARCHAR(100) NOT NULL,
	apellido VARCHAR(100) NOT NULL,
	dni DECIMAL(8, 0) NOT NULL UNIQUE ,
	correo VARCHAR(100) NOT NULL,
	telefono VARCHAR(100),
	domicilio VARCHAR(200),
	fechaAlta DATE NOT NULL,
	aptoFisico BOOLEAN NOT NULL,
	tipoCliente ENUM('socio', 'no_socio') NOT NULL
);

-- Insertar datos
INSERT INTO cliente (nombre, apellido, dni, correo, telefono, domicilio, fechaAlta, aptoFisico, tipoCliente) VALUES
('Ana', 'Pérez', 32165478, 'ana.perez@email.com', '11-5555-1234', 'Calle Falsa 123, Ciudad Autónoma de Buenos Aires', '2024-01-15', TRUE, 'socio'),
('Carlos', 'López', 25879631, 'carlos.lopez@otrocorreo.net', '351-6666-7890', 'Avenida Principal 456, Córdoba', '2024-03-20', TRUE, 'socio'),
('Martina', 'Gómez', 41236987, 'martina.gomez@mail.org', '261-7777-0123', 'Pasaje Central 789, Mendoza', '2024-05-10', FALSE, 'no_socio'),
('Juan', 'Rodríguez', 18963254, 'juan.rodriguez@miemail.com', '11-4444-5678', 'Ruta Provincial 10, Provincia de Buenos Aires', '2024-07-01', TRUE, 'socio'),
('Sofía', 'Fernández', 38741259, 'sofia.fernandez@suemail.com', '381-8888-9012', 'Barrio Nuevo 321, Tucumán', '2024-09-25', TRUE, 'socio'),
('Pedro', 'González', 29514782, 'pedro.gonzalez@correo.com', '341-9999-2345', 'Urquiza 654, Rosario', '2024-11-30', FALSE, 'no_socio'),
('Laura', 'Díaz', 45698712, 'laura.diaz@otro.net', '223-1111-4567', 'Calle 9 de Julio 159, Mar del Plata', '2025-02-10', TRUE, 'socio'),
('Manuel', 'Sánchez', 21369852, 'manuel.sanchez@mail.com', '379-2222-7890', 'Rivadavia 876, Corrientes', '2025-04-05', TRUE, 'socio'),
('Agustina', 'Romero', 35789641, 'agustina.romero@mi.org', '299-3333-0123', 'San Martín 421, Neuquén', '2025-05-12', TRUE, 'socio'),
('Santiago', 'Medina', 48215796, 'santiago.medina@su.com', '336-4444-5678', 'Belgrano 987, San Nicolás', '2025-05-14', TRUE, 'no_socio');

CREATE TABLE socio (
	id INT AUTO_INCREMENT PRIMARY KEY,
	cliente_id INT NOT NULL,
	fechaVencimiento DATE NOT NULL,
	estado ENUM('activo', 'inactivo') NOT NULL,
	FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);

-- Insertar datos
INSERT INTO socio (cliente_id, fechaVencimiento, estado) VALUES
(1, DATE_ADD(CURDATE(), INTERVAL 5 DAY), 'activo'),
(2, CURDATE(), 'activo'),
(4, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'activo'),
(5, DATE_SUB(CURDATE(), INTERVAL 5 DAY), 'inactivo'),
(7, DATE_SUB(CURDATE(), INTERVAL 1 DAY), 'inactivo'),
(8, DATE_SUB(CURDATE(), INTERVAL 30 DAY), 'inactivo'),
(9, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'activo');


CREATE TABLE cuota (
	id INT AUTO_INCREMENT PRIMARY KEY,
	cliente_id INT NOT NULL,
	fechaVencimiento DATE NOT NULL,
	fechaPago DATE NOT NULL,
	monto FLOAT NOT NULL,
	formaPago ENUM('efectivo', 'tarjeta') NOT NULL DEFAULT 'efectivo',
	promocion int DEFAULT 1,
	estado ENUM('pagada', 'vencida') NOT NULL,
	FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);


INSERT INTO cuota (cliente_id, fechaVencimiento, fechaPago, monto, formaPago, promocion, estado) VALUES
(1, DATE_ADD(CURDATE(), INTERVAL 5 DAY), DATE_ADD(CURDATE(), INTERVAL 5 DAY), 1500.00, 'efectivo', 1, 'pagada'),
(2, '2025-06-20', '2025-06-19', 2200.50, 'tarjeta', 2, 'pagada'),
(3, '2025-06-10', NULL, 1800.00, 'efectivo', 1, 'vencida'),
(1, '2025-07-15', NULL, 1500.00, 'tarjeta', 1, NULL),
(4, '2025-06-25', '2025-06-23', 950.75, 'efectivo', 1, 'pagada'),
(5, '2025-07-01', NULL, 3000.00, 'tarjeta', 3, NULL),
(2, '2025-07-20', '2025-07-18', 2200.50, 'efectivo', 1, 'pagada'),
(6, '2025-06-05', NULL, 1250.00, 'tarjeta', 1, 'vencida'),
(7, '2025-06-30', '2025-06-28', 1750.25, 'efectivo', 1, 'pagada'),
(8, '2025-07-05', NULL, 2500.00, 'tarjeta', 2, NULL);


-- store procedure, Clic en el botón “+” (Create New SQL Tab) o File > New Query Tab. Pegar el código completo ahí:


delimiter //

create procedure IngresoLogin(in Usu varchar(100), in Pass varchar(100))

begin
  

  select id, nombre 
  from usuario 
  where nombre = Usu and clave = Pass;

end
//

-- TE TIENE QUE TRAER A EMMA
call IngresoLogin('Emma', '12345')//


-- STORE PROCEDURE PARA EL REGISTRO DE cliente
CREATE PROCEDURE proyecto.NuevoCliente(in Nom varchar(100),
	in Ape varchar(100),
	in Doc DECIMAL(8, 0),
	IN Cor VARCHAR(100),
	IN Tel VARCHAR(100),
	IN Dom VARCHAR(200),
	IN FAlta DATE,
	IN AFis BOOLEAN,
	in Tip varchar(8),
	out rta int)
BEGIN
	declare filas int default 0;
	declare existe int default 0;
    
     set filas = (select count(*) from cliente);
     if filas = 0 then
		set filas = 452; /* consideramos a este numero como el primer numero de cliente */
     else
     /* -------------------------------------------------------------------------------
		buscamos el ultimo numero de cliente almacenado para sumarle una unidad y
		considerarla como PRIMARY KEY de la tabla
   ___________________________________________________________________________ */
		set filas = (select max(id) + 1 from cliente);
		
		/* ---------------------------------------------------------
			para saber si ya esta almacenado el cliente
		------------------------------------------------------- */	
		set existe = (select count(*) from cliente where dni = Doc);
     end if;
	 
	  if existe = 0 then	 
		 insert into cliente values(filas,Nom,Ape,Doc,Cor,Tel,Dom,FAlta,AFis,Tip);
	  
	  		IF Tip = 'socio' THEN
	  			INSERT INTO socio (cliente_id, fechaVencimiento, estado) values(filas, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'activo');
	  		END IF;
	  		
	  		COMMIT;
	  
		 set rta  = filas;
	  else
		 set rta = existe;
      end if;
END

-- LLAMADO AL STORE ANTERIOR

SET @x = 0;

CALL NuevoCliente('Sofía', 'Fernández', 38741250, 'sofia.fernandez@suemail.com', '381-8888-9012', 'Barrio Nuevo 321, Tucumán', CURDATE(), TRUE, 'socio', @x);

SELECT @x AS respuesta;










