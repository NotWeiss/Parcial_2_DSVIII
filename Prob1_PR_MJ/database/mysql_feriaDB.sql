CREATE TABLE `facturas`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `nombre` VARCHAR(255) NOT NULL,
    `cedula` VARCHAR(255) NOT NULL,
    `dia` VARCHAR(255) NOT NULL,
    `modelo_id` INT UNSIGNED NOT NULL
);
CREATE TABLE `modelos`(
    `id` INT UNSIGNED NOT NULL AUTO_INCREMENT PRIMARY KEY,
    `modelo` VARCHAR(255) NOT NULL,
    `precio` DECIMAL(10, 2) NOT NULL
);
ALTER TABLE
    `facturas` ADD CONSTRAINT `facturas_modelo_id_foreign` FOREIGN KEY(`modelo_id`) REFERENCES `modelos`(`id`);