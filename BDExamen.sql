create database inventario
use inventario
create table producto (
id int primary key,
nombre varchar(100),
descripcion varchar(255),
precio decimal(10,2),
cantidad int,
fec_ingreso date 
);
INSERT INTO producto (id, nombre, descripcion, precio, cantidad, fec_ingreso) VALUES
(1, 'Balón de fútbol', 'Balón profesional de fútbol tamaño 5', 29.99, 50, '2025-05-20'),
(2, 'Raqueta de tenis', 'Raqueta de grafito para adultos', 89.50, 20, '2025-05-18'),
(3, 'Guantes de boxeo', 'Guantes acolchados talla M', 45.00, 35, '2025-05-21'),
(4, 'Bicicleta de montaña', 'Bicicleta de montaña con suspensión delantera', 450.00, 10, '2025-05-15'),
(5, 'Pesas de 10kg', 'Par de mancuernas de 10 kg', 60.00, 25, '2025-05-22'),
(6, 'Cinta para correr', 'Cinta eléctrica con múltiples velocidades', 799.99, 5, '2025-05-10'),
(7, 'Camiseta deportiva', 'Camiseta transpirable talla L', 19.90, 100, '2025-05-23');