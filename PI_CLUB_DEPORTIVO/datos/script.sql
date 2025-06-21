DROP DATABASE IF EXISTS Proyecto;

CREATE DATABASE Proyecto;
USE Proyecto;

CREATE TABLE usuario (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100) NOT NULL,
    clave VARCHAR(100) NOT NULL
);

INSERT INTO usuario (nombre, clave) VALUES ('emma', '12345');

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
('Ana', 'Pérez', 32165478, 'ana.perez@email.com', '1155551234', 'Calle Falsa 123, Ciudad Autónoma de Buenos Aires', '2024-01-15', TRUE, 'socio'),
('Carlos', 'López', 25879631, 'carlos.lopez@otrocorreo.net', '35166667890', 'Avenida Principal 456, Córdoba', '2024-03-20', TRUE, 'socio'),
('Martina', 'Gómez', 41236987, 'martina.gomez@mail.org', '26177770123', 'Pasaje Central 789, Mendoza', '2024-05-10', FALSE, 'no_socio'),
('Juan', 'Rodríguez', 18963254, 'juan.rodriguez@miemail.com', '1144445678', 'Ruta Provincial 10, Provincia de Buenos Aires', '2024-07-01', TRUE, 'socio'),
('Sofía', 'Fernández', 38741259, 'sofia.fernandez@suemail.com', '38188889012', 'Barrio Nuevo 321, Tucumán', '2024-09-25', TRUE, 'socio'),
('Pedro', 'González', 29514782, 'pedro.gonzalez@correo.com', '34199992345', 'Urquiza 654, Rosario', '2024-11-30', FALSE, 'no_socio'),
('Laura', 'Díaz', 45698712, 'laura.diaz@otro.net', '22311114567', 'Calle 9 de Julio 159, Mar del Plata', '2025-02-10', TRUE, 'socio'),
('Manuel', 'Sánchez', 21369852, 'manuel.sanchez@mail.com', '37922227890', 'Rivadavia 876, Corrientes', '2025-04-05', TRUE, 'socio'),
('Agustina', 'Romero', 35789641, 'agustina.romero@mi.org', '29933330123', 'San Martín 421, Neuquén', '2025-05-12', TRUE, 'socio'),
('Santiago', 'Medina', 48215796, 'santiago.medina@su.com', '33644445678', 'Belgrano 987, San Nicolás', '2025-05-14', TRUE, 'no_socio');

--crear tabla de socio
CREATE TABLE socio (
	id INT AUTO_INCREMENT PRIMARY KEY,
	cliente_id INT NOT NULL,
	fechaVencimiento DATE NOT NULL,
	estado ENUM('activo', 'inactivo') NOT NULL,
	FOREIGN KEY (cliente_id) REFERENCES cliente(id)
);

-- Insertar datos de socio
INSERT INTO socio (cliente_id, fechaVencimiento, estado) VALUES
(1, DATE_ADD(CURDATE(), INTERVAL 5 DAY), 'activo'),
(2, CURDATE(), 'activo'),
(4, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'activo'),
(5, DATE_SUB(CURDATE(), INTERVAL 5 DAY), 'inactivo'),
(7, DATE_SUB(CURDATE(), INTERVAL 1 DAY), 'inactivo'),
(8, DATE_SUB(CURDATE(), INTERVAL 30 DAY), 'inactivo'),
(9, DATE_ADD(CURDATE(), INTERVAL 30 DAY), 'activo');

--crear tabla de cuota
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

-- Insertar datos de cuotas
INSERT INTO cuota (cliente_id, fechaVencimiento, fechaPago, monto, formaPago, promocion, estado) VALUES
(1, DATE_ADD(CURDATE(), INTERVAL 5 DAY), DATE_ADD(CURDATE(), INTERVAL 5 DAY), 1500.00, 'efectivo', 1, 'pagada'),
(2, '2025-06-20', '2025-06-19', 2200.50, 'tarjeta', 2, 'pagada'),
(4, '2025-06-25', '2025-06-23', 950.75, 'efectivo', 1, 'pagada'),
(2, '2025-07-20', '2025-07-18', 2200.50, 'efectivo', 1, 'pagada'),
(7, '2025-06-30', '2025-06-28', 1750.25, 'efectivo', 1, 'pagada'),
(3, '2025-06-10', '2025-06-10', 1800.00, 'efectivo', 1, 'pagada'),
(6, '2025-06-05', '2025-06-05', 1250.00, 'tarjeta', 1, 'pagada'),
(1, '2025-07-15', '2025-07-16', 1500.00, 'tarjeta', 1, 'pagada'),
(5, '2025-07-01', '2025-07-03', 3000.00, 'tarjeta', 3, 'pagada'),
(8, '2025-07-05', '2025-07-06', 2500.00, 'tarjeta', 2, 'pagada');



-- CREAR TABLA DE ACTIVIDADES
CREATE TABLE IF NOT EXISTS actividad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    nombre VARCHAR(100),
    precio FLOAT,
	cupo INT
);


-- Insertando datos de  Actividades
INSERT INTO actividad (nombre, precio) VALUES
('Zumba', 1200.00,0),
('Yoga', 1500.00,20),
('Crossfit', 2000.00,20),
('Funcional', 1800.00,20),
('Pilates', 1600.00,20),
('Spinning', 1700.00,20),
('Boxeo', 1900.00,20);


-- CREAR TABLA DE PAGOS DE ACTIVIDAD (NO SOCIOS)
CREATE TABLE IF NOT EXISTS pagoactividad (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idActividad INT,
    idCliente INT,
    fechaPago DATE,
    formaPago ENUM('efectivo', 'tarjeta'),
    FOREIGN KEY (idActividad) REFERENCES actividad(id),
    FOREIGN KEY (idCliente) REFERENCES cliente(id)
);


--INSERTAR DATOS DE PAGO DE ACTIVIDAD
INSERT INTO pagoactividad (idActividad, idCliente, fechaPago, formaPago) VALUES
(1, 3, '2024-12-01', 'efectivo'),
(2, 6, '2025-01-10', 'tarjeta'),
(3, 10, '2025-02-15', 'efectivo'),
(4, 3, '2025-03-12', 'tarjeta'),
(5, 6, '2025-04-18', 'efectivo');



-- CREAR TABLA DE CARNET (SOCIOS)
CREATE TABLE IF NOT EXISTS carnet (
    id INT AUTO_INCREMENT PRIMARY KEY,
    idSocio INT,
    fechaEmision DATE,
    fechaVencimiento DATE,
    FOREIGN KEY (idSocio) REFERENCES socio(id)
);




-- Insertar carnets
INSERT INTO carnet (idSocio, fechaEmision, fechaVencimiento) VALUES
(1, '2024-06-15', '2025-06-15'),  -- Ana
(2, '2024-09-01', '2025-09-01'),  -- Carlos
(3, '2025-01-20', '2026-01-20'),  -- Juan
(4, '2025-03-10', '2026-03-10');  -- Sofía




-------------------------------------------------------------store procedure---------------------------------------------------------------------------------

-- store procedure: INGRESO LOGIN

delimiter //

create procedure IngresoLogin(in Usu varchar(100), in Pass varchar(100))

begin
	select id, nombre 
	from usuario 
	where nombre = Usu and clave = Pass;

end
//

-- TE TIENE QUE TRAER A EMMA
call IngresoLogin('emma', '12345')//


-- STORE PROCEDURE PARA EL REGISTRO DE CLIENTE
delimiter //
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
//
-- LLAMADO AL STORE ANTERIOR

SET @x = 0;

CALL NuevoCliente('Sofía', 'Fernández', 38741250, 'sofia.fernandez@suemail.com', '381-8888-9012', 'Barrio Nuevo 321, Tucumán', CURDATE(), TRUE, 'socio', @x);

SELECT @x AS respuesta;


----------------------------------------------------- store procedure socios con cuotas vencidas-----------------------------------------------------------

DELIMITER //

CREATE PROCEDURE obtener_socios_inactivos_vencidos()
BEGIN
    SELECT 
        c.id AS 'ID',
    	Concat(c.nombre, ' ', c.apellido) AS 'Cliente',
        CASE 
            WHEN q.estado = 'vencida' AND q.fechaPago IS NULL THEN 'inactivo'
            ELSE 'activo'
        END AS 'Estado', 
        c.dni AS 'DNI', 
        c.correo AS 'Correo',
        c.telefono AS 'Teléfono', 
        q.fechaVencimiento AS 'Fecha de vencimiento'
        DATEDIFF(CURDATE(), q.fechaVencimiento) AS 'Días desde el venc.'
    FROM 
        cliente c
    JOIN 
        cuota q ON c.id = q.cliente_id
    WHERE 
        q.estado = 'vencida'  -- Solo cuotas vencidas
        AND q.fechaVencimiento < CURDATE()  -- La cuota ya está vencida
        AND q.fechaPago IS NULL;  -- La cuota no ha sido pagada
END //

DELIMITER ;


-- Para ejecutar el Stored Procedure y obtener los resultados, simplemente ejecutas el siguiente comando:

CALL obtener_socios_inactivos_vencidos();


--------------------------------------------------------------VIStas DE NO_SOCIO--------------------------------------

CREATE VIEW vista_nosocios AS
SELECT *
FROM cliente
WHERE tipoCliente = 'no_socio';





