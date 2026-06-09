CREATE TABLE Clientes (
    IdCliente INT PRIMARY KEY IDENTITY,
    Nombre NVARCHAR(50),
    Apellido NVARCHAR(50),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);

CREATE TABLE Productos (
    IdProducto INT PRIMARY KEY IDENTITY,
    Descripcion NVARCHAR(100),
    Precio DECIMAL(10,2),
    Stock INT
);

CREATE TABLE Proveedores (
    IdProveedor INT PRIMARY KEY IDENTITY,
    RazonSocial NVARCHAR(100),
    Telefono NVARCHAR(20),
    Email NVARCHAR(100)
);

INSERT INTO Clientes (Nombre, Apellido, Telefono, Email)
VALUES ('Juan', 'Pérez', '3511234567', 'juanperez@mail.com'),
       ('María', 'Gómez', '3517654321', 'mariagomez@mail.com'),
       ('Carlos', 'López', '3515554321', 'carloslopez@mail.com');

INSERT INTO Productos (Descripcion, Precio, Stock)
VALUES ('Lapicera', 1500, 25),
       ('Cuaderno', 2500, 10),
       ('Regla', 800, 15);

INSERT INTO Proveedores (RazonSocial, Telefono, Email)
VALUES ('Editorial Córdoba', '3517654321', 'editorial@mail.com'),
       ('Distribuidora Norte', '3519876543', 'distribuidora@mail.com'),
       ('Papelería Centro', '3511239876', 'papeleria@mail.com');

SELECT * FROM Clientes;
SELECT * FROM Productos;
SELECT * FROM Proveedores;
