Use [ProyectoProgramacionAvanzada2024.Models.ApplicationDbContext]
Go

INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Juan Perez', 'password1', '2024-08-01', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Maria Gomez', 'password2', '2024-08-02', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Carlos Rodriguez', 'password3', '2024-08-03', 0);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Ana Sanchez', 'password4', '2024-08-04', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Luis Fernandez', 'password5', '2024-08-05', 0);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Laura Ramirez', 'password6', '2024-08-06', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Jorge Diaz', 'password7', '2024-08-07', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Elena Morales', 'password8', '2024-08-08', 0);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Pedro Castillo', 'password9', '2024-08-09', 1);
INSERT INTO Usuarios (nombreUsuario, contrasena, ultimaConexion, estado) VALUES ('Sofia Gutierrez', 'password10', '2024-08-10', 1);

INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Laptop', 800.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Mouse', 20.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Teclado', 50.00, 0, 0);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Monitor', 150.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Impresora', 200.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Disco Duro Externo', 100.00, 0, 0);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Memoria USB', 15.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Auriculares', 30.00, 1, 1);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Cámara Web', 70.00, 0, 0);
INSERT INTO Productoes (nombreProducto, precio, disponibilidad, estado) VALUES ('Router', 60.00, 1, 1);

INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (1, 1, 'Muy buena calidad', 5);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (2, 2, 'Funciona perfectamente', 4);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (3, 3, 'Esperaba más', 3);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (4, 4, 'Excelente monitor', 5);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (5, 5, 'Buena relación calidad-precio', 4);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (6, 6, 'No es lo que esperaba', 2);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (7, 7, 'Muy útil y compacto', 4);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (8, 8, 'Sonido excelente', 5);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (9, 9, 'Buena calidad de imagen', 4);
INSERT INTO Resenas (codigoProducto, codigoUsuario, comentario, calificacion) VALUES (10, 10, 'Configuración complicada', 3);

INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (1, 1);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (2, 2);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (3, 3);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (4, 4);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (5, 5);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (6, 6);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (7, 7);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (8, 8);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (9, 9);
INSERT INTO Carritoes (codigoCarrito, codigoUsuario) VALUES (10, 10);

INSERT INTO Pedidoes(codigoUsuario, fecha) VALUES (1, '2023-01-01');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (2, '2023-01-05');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (3, '2023-01-10');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (4, '2023-01-15');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (5, '2023-01-20');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (6, '2023-01-25');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (7, '2023-02-01');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (8, '2023-02-05');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (9, '2023-02-10');
INSERT INTO Pedidoes (codigoUsuario, fecha) VALUES (10, '2023-02-15');

INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (1, 1);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (2, 2);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (3, 3);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (4, 4);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (5, 5);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (6, 6);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (7, 7);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (8, 8);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (9, 9);
INSERT INTO ProductoCarritoes (codigoCarrito, codigoProducto) VALUES (10, 10);

INSERT INTO ProductoPedidoes(codigoPedido, codigoProducto) VALUES (1, 1);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (2, 2);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (3, 3);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (4, 4);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (5, 5);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (6, 6);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (7, 7);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (8, 8);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (9, 9);
INSERT INTO ProductoPedidoes (codigoPedido, codigoProducto) VALUES (10, 10);


