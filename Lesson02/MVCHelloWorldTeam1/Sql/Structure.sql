CREATE SCHEMA `warehouse` ;

CREATE TABLE `warehouse`.`category` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(45) NOT NULL COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '',
  UNIQUE INDEX `id_UNIQUE` (`id` ASC)  COMMENT '');

CREATE TABLE `warehouse`.`product` (
  `id` INT NOT NULL AUTO_INCREMENT COMMENT '',
  `name` VARCHAR(45) NOT NULL COMMENT '',
  `category_id` INT NOT NULL COMMENT '',
  `price` DECIMAL NOT NULL COMMENT '',
  `quantity` DECIMAL NOT NULL DEFAULT 0 COMMENT '',
  `code` INT NOT NULL COMMENT '',
  `created_at` DATETIME NOT NULL COMMENT '',
  PRIMARY KEY (`id`)  COMMENT '',
  UNIQUE INDEX `id_UNIQUE` (`id` ASC)  COMMENT '',
  INDEX `product_category_idx` (`category_id` ASC)  COMMENT '',
  UNIQUE INDEX `code_UNIQUE` (`code` ASC)  COMMENT '',
  CONSTRAINT `product_category`
    FOREIGN KEY (`category_id`)
    REFERENCES `warehouse`.`category` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION);
