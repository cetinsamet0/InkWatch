
-- Veritabanı oluşturuluyor
CREATE DATABASE IF NOT EXISTS InkWatchDB;
USE InkWatchDB;

-- Departmanlar
CREATE TABLE tbl_departmants (
    departmant_id INT AUTO_INCREMENT PRIMARY KEY,
    departmant_name VARCHAR(100) NOT NULL
);

INSERT INTO tbl_departmants (departmant_name) VALUES
('Bilgi İşlem'),
('İnsan Kaynakları'),
('Satın Alma');

-- Markalar
CREATE TABLE tbl_brands (
    brand_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_name VARCHAR(100) NOT NULL,
    brand_logo VARCHAR(255)
);

INSERT INTO tbl_brands (brand_name, brand_logo) VALUES
('HP', 'hp_logo.png'),
('Canon', 'canon_logo.png');

-- Modeller
CREATE TABLE tbl_models (
    model_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_id INT,
    model_name VARCHAR(100) NOT NULL,
    model_logo VARCHAR(255),
    FOREIGN KEY (brand_id) REFERENCES tbl_brands(brand_id)
);

INSERT INTO tbl_models (brand_id, model_name, model_logo) VALUES
(1, 'LaserJet Pro M404n', 'm404n_logo.png'),
(2, 'PIXMA G3411', 'g3411_logo.png');

-- Yazıcılar
CREATE TABLE tbl_printers (
    printer_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_id INT,
    model_id INT,
    departmant_id INT,
    printer_sn VARCHAR(100),
    printer_ip VARCHAR(50),
    FOREIGN KEY (brand_id) REFERENCES tbl_brands(brand_id),
    FOREIGN KEY (model_id) REFERENCES tbl_models(model_id),
    FOREIGN KEY (departmant_id) REFERENCES tbl_departmants(departmant_id)
);

INSERT INTO tbl_printers (brand_id, model_id, departmant_id, printer_sn, printer_ip) VALUES
(1, 1, 1, 'SN12345678', '192.168.1.10'),
(2, 2, 2, 'SN87654321', '192.168.1.11');

-- Parça Türleri
CREATE TABLE tbl_part_type (
    part_type_id INT AUTO_INCREMENT PRIMARY KEY,
    part_type_name VARCHAR(100) NOT NULL,
    explanation VARCHAR(255)
);

INSERT INTO tbl_part_type (part_type_name, explanation) VALUES
('Toner', 'Yazıcıya özel toner kartuşu'),
('Drum', 'Görüntüleme tamburu');

-- Parçalar
CREATE TABLE tbl_parts (
    part_id INT AUTO_INCREMENT PRIMARY KEY,
    model_id INT,
    part_type_id INT,
    part_name VARCHAR(100) NOT NULL,
    FOREIGN KEY (model_id) REFERENCES tbl_models(model_id),
    FOREIGN KEY (part_type_id) REFERENCES tbl_part_type(part_type_id)
);

INSERT INTO tbl_parts (model_id, part_type_id, part_name) VALUES
(1, 1, 'HP 59X Toner'),
(2, 1, 'Canon GI-490 Mürekkep');

