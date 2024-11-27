-- Deletar tabelas com CASCADE
DROP TABLE IF EXISTS sales_items CASCADE;
DROP TABLE IF EXISTS sales CASCADE;
DROP TABLE IF EXISTS products CASCADE;
DROP TABLE IF EXISTS clients CASCADE;

-- Recriar as tabelas
CREATE TABLE clients (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(100),
    tel VARCHAR(20),
    address VARCHAR(200), -- Adicionado
    IsDeleted BOOLEAN DEFAULT FALSE
);

CREATE TABLE products (
    id SERIAL PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    un DECIMAL(10, 2) NOT NULL,
    IsDeleted BOOLEAN DEFAULT FALSE
);

CREATE TABLE sales (
    id SERIAL PRIMARY KEY,
    client_id INT NOT NULL,
    data_sale TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (client_id) REFERENCES clients(id)
);

CREATE TABLE sales_items (
    id SERIAL PRIMARY KEY,
    sale_id INT NOT NULL,
    product_id INT NOT NULL,
    quantity INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    IsDeleted BOOLEAN DEFAULT FALSE,
    FOREIGN KEY (sale_id) REFERENCES sales(id),
    FOREIGN KEY (product_id) REFERENCES products(id)
);

CREATE INDEX idx_client_name ON clients(name);
CREATE INDEX idx_product_name ON products(name);
CREATE INDEX idx_sale_client_id ON sales(client_id);

-- Opcional daqui em diante, só fiz para agilizar a visualização e o teste de algumas funcionalidades

-- Inserir clientes
INSERT INTO clients (name, email, tel, address) VALUES
('Cliente 1', 'cliente1@example.com', '123456789', 'Endereço 1'),
('Cliente 2', 'cliente2@example.com', '987654321', 'Endereço 2'),
('Cliente 3', 'cliente3@example.com', '555555555', 'Endereço 3');

-- Inserir produtos
INSERT INTO products (name, price, un) VALUES
('Produto 1', 10.00, 1),
('Produto 2', 20.00, 1),
('Produto 3', 30.00, 1);

-- Inserir vendas
-- Venda 1: Cliente 1 compra 2 unidades do Produto 1
INSERT INTO sales (client_id, data_sale) VALUES (1, NOW());
INSERT INTO sales_items (sale_id, product_id, quantity, price) VALUES (1, 1, 2, (SELECT price FROM products WHERE id = 1));

-- Venda 2: Cliente 2 compra 1 unidade do Produto 2
INSERT INTO sales (client_id, data_sale) VALUES (2, NOW());
INSERT INTO sales_items (sale_id, product_id, quantity, price) VALUES (2, 2, 1, (SELECT price FROM products WHERE id = 2));

-- Venda 3: Cliente 3 compra 3 unidades do Produto 3
INSERT INTO sales (client_id, data_sale) VALUES (3, NOW());
INSERT INTO sales_items (sale_id, product_id, quantity, price) VALUES (3, 3, 3, (SELECT price FROM products WHERE id = 3));