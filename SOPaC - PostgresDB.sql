CREATE TABLESPACE ts_fast LOCATION 'E:\SQL';
CREATE DATABASE sopc TABLESPACE ts_fast;
--CREATE SCHEMA main;
--SET SEARCH_PATH = main;

--! Проверить сходятся ли все вк по типам

REVOKE ALL PRIVILEGES ON DATABASE sopc FROM PUBLIC;
REVOKE ALL PRIVILEGES ON SCHEMA public FROM PUBLIC;

	--Управляющий
CREATE ROLE main LOGIN SUPERUSER CONNECTION LIMIT 1 PASSWORD '123';
-- Остальные после создания таблиц

CREATE TYPE STATUSES AS ENUM (
    'сформирован', 'отправлен со склада', 'в пути', 'прибыл в сортировочный центр', 'готов к выдаче', 'получено'
);

CREATE DOMAIN C_DATE AS DATE
NOT NULL CHECK(VALUE <= CURRENT_DATE) DEFAULT CURRENT_DATE;

CREATE DOMAIN C_TIMESTAMP AS TIMESTAMP
NOT NULL CHECK(VALUE <= CURRENT_TIMESTAMP) DEFAULT CURRENT_TIMESTAMP;

CREATE DOMAIN NUMB_PHONE AS VARCHAR(11) CHECK(VALUE ~ '^[0-9]{11}$');

CREATE DOMAIN COUNT AS INT
DEFAULT 1 CHECK(VALUE >=1);
CREATE DOMAIN NUMB_CARD AS VARCHAR(16)
NOT NULL CHECK(
   	VALUE ~ '[0-9]{16}$'
);

CREATE DOMAIN NUMB_PHONE AS VARCHAR(15)
CHECK(	VALUE ~ '[^0-9]') ;

CREATE DOMAIN CASH AS MONEY
NOT NULL CHECK(	VALUE::numeric(10,2) >=0);

CREATE TABLE Client(
id_client 		  SERIAL PRIMARY KEY,
name 	  		  VARCHAR(25) NOT NULL,
family	  		  VARCHAR(45) NOT NULL,
patronymic 		  VARCHAR(45) NULL,
phone             NUMB_PHONE NULL UNIQUE,
email             VARCHAR(255) NULL UNIQUE
);

CREATE TABLE Order_status(
id_order_status 		  VARCHAR(10) PRIMARY KEY,
description_order_status  STATUSES
);

CREATE TABLE Order_( -- FK client order_
id_order    	  		  SERIAL PRIMARY KEY,
order_date  	  		  C_TIMESTAMP,
phone_number	  		  NUMB_PHONE, --номер, на который приходит информация о заказе
address     	  		  VARCHAR(255) NULL, --
id_client   	  		  INT,
id_order_status 		  VARCHAR(10),
CONSTRAINT fk_ord_ordstat FOREIGN KEY (id_Order_status) REFERENCES Order_status (id_Order_status) ON DELETE RESTRICT ON UPDATE CASCADE,
CONSTRAINT fk_ord_client  FOREIGN KEY (Id_Client) REFERENCES Client (Id_Client) ON DELETE NO ACTION ON UPDATE NO ACTION
);  -- TABLESPACE ts_fast;

CREATE TABLE Shop(
name_store 				  VARCHAR(35) PRIMARY KEY,
address    				  text NOT NULL
);

CREATE TABLE Employee_type(
id_employee_type 		VARCHAR(15) PRIMARY KEY ,
responsible_description TEXT NOT NULL
);

CREATE TABLE Employee_of_company( --FK - employee_type, shop
id_employee			    VARCHAR(8) PRIMARY KEY,
id_employment_contract  VARCHAR(8) UNIQUE,
passport_serial 	    NUMERIC(4) NOT NULL UNIQUE,
passport_nubmer 	    NUMERIC(6) NOT NULL UNIQUE,
adres 				    TEXT,
id_employee_type 	    VARCHAR(15),
emp_phone_number 	    NUMB_PHONE NOT NULL UNIQUE,
date_of_employment 	    DATE NOT NULL,
name_store 			    VARCHAR(35),
emp_family 			    VARCHAR(30) NOT NULL,
emp_name   			    VARCHAR(30) NOT NULL,
emp_patronymic 		    VARCHAR(30) NULL,
emp_login               VARCHAR(50) CONSTRAINT nnud_emp_log NOT NULL UNIQUE DEFAULT NULL,
emp_password            VARCHAR(50) CONSTRAINT nnud_emp_pasw NOT NULL UNIQUE DEFAULT NULL,
CONSTRAINT fk_emp_store FOREIGN KEY(name_store) REFERENCES Shop (name_store) ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT fk_emp_type  FOREIGN KEY(Id_employee_type) REFERENCES Employee_type (Id_employee_type) ON DELETE NO ACTION ON UPDATE CASCADE
);

CREATE TABLE Order_delivery( --FK order_, employee_of_company
id_order_delivery 		  SERIAL PRIMARY KEY,
time_delivery_start	      C_DATE,
time_delivery_compleate   DATE,
id_order 				  INT,
id_employee 			  VARCHAR(8),
CONSTRAINT fk_orddeliv_order FOREIGN KEY (Id_Order) REFERENCES Order_(Id_Order) ON DELETE CASCADE ON UPDATE CASCADE,
CONSTRAINT fk_orddeliv_empl FOREIGN KEY (id_employee) REFERENCES Employee_of_company(id_employee) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE Pushare_agreement( --FK shop, client, order
id_pushare_agreement	    SERIAL PRIMARY KEY,
name_store 			        VARCHAR(35),
id_client 				    INT,
all_cost 				    CASH,
pushare_agreement_date      C_TIMESTAMP,
id_order 				    INT,
paid        	  		    BOOLEAN CONSTRAINT def_pa_paid DEFAULT false,
CONSTRAINT fk_pa_Id_Client  FOREIGN KEY (Id_Client) REFERENCES Client (Id_Client) ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT fk_pa_order      FOREIGN KEY (Id_Order) REFERENCES Order_ (Id_Order)  ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT fk_pa_shop       FOREIGN KEY (Name_store) REFERENCES Shop (Name_store) ON DELETE NO ACTION ON UPDATE CASCADE
);

CREATE TABLE Guarantee(
id_guarantee 			  VARCHAR(10) PRIMARY KEY,
garranty_period_in_months INTEGER NULL,
garranty_conditions 	  TEXT NULL
);

CREATE TABLE Manufacturer(
id_manufacturer 		  VARCHAR(25) PRIMARY KEY,
name 					  VARCHAR(150) UNIQUE NOT NULL
);

CREATE TABLE Supply_order( -- FK Employee_of_company
id_supply_order 	           SERIAL PRIMARY KEY,
date_supl_order 	           C_TIMESTAMP,
id_employee    				   VARCHAR(10),
CONSTRAINT fk_suplorder_emp    FOREIGN KEY (id_employee) REFERENCES Employee_of_company(id_employee) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE Supplier(
id_supplier 			VARCHAR(25) PRIMARY KEY,
adress					TEXT,
name			  		VARCHAR(25) NOT NULL
);

CREATE TABLE Supply( -- FK supplier, Supply_order
id_supply 				        SERIAL PRIMARY KEY,
id_supply_order			        INT,
id_supplier			            VARCHAR(15),
date_supply 			        C_TIMESTAMP,
price_supply 			        CASH,
description_supply 		        TEXT NULL,
CONSTRAINT fk_supply_supplorder FOREIGN KEY (id_supply_order) REFERENCES Supply_order (id_supply_order) ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT fk_supply_supplier   FOREIGN KEY (Id_supplier) REFERENCES Supplier (Id_supplier) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE product( -- FK
id_product			SERIAL PRIMARY KEY,
price		        CASH,
сounts 		        COUNT
);

CREATE TABLE supplied_product( -- FK  supply, shop
name_store	 	                VARCHAR(35) NOT NULL,
id_suppply		  	            INT,
id_product						INT,
count 							COUNT,
price							CASH,
CONSTRAINT pk_supplied_product	PRIMARY KEY (id_suppply, id_product),
CONSTRAINT fk_pa_shop       	FOREIGN KEY (name_store) REFERENCES Shop (Name_store) ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT fk_suplgod_Supply    FOREIGN KEY (Id_suppply) REFERENCES Supply (Id_supply) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE Position_in_order( --FK pushare_agreement, product
id_position 			    VARCHAR (25),
id_pushare_agreement 	    INT,
id_product					INT,
count_staf					COUNT,
CONSTRAINT pk_pos_listgoods PRIMARY KEY (id_position, id_pushare_agreement),
CONSTRAINT fk_pos_product   FOREIGN KEY (id_product) REFERENCES product(id_product) ON DELETE RESTRICT ON UPDATE CASCADE,
CONSTRAINT fk_pos_pushagree FOREIGN KEY (id_pushare_agreement) REFERENCES Pushare_agreement(id_pushare_agreement) ON DELETE CASCADE ON UPDATE CASCADE
);

CREATE TABLE Phone_model( -- FK Guarantee, List_of_supported_models, product, Manufacturer
id_phone_model 			         VARCHAR(25) PRIMARY KEY,
name_model				         VARCHAR(35) NOT NULL,
specifications 			         TEXT NOT NULL,
guarantee_phone_model 	         VARCHAR(15),
manufacturer 			         VARCHAR(25),
id_product						 INT,
CONSTRAINT fk_phmod_id_product   FOREIGN KEY(id_product) REFERENCES product (id_product) ON DELETE NO ACTION ON UPDATE RESTRICT,
CONSTRAINT fk_phmod_guarante     FOREIGN KEY(Guarantee_Phone_model) REFERENCES Guarantee (ID_Guarantee) ON DELETE NO ACTION ON UPDATE RESTRICT,
CONSTRAINT fk_phmod_manufacturer FOREIGN KEY(Manufacturer) REFERENCES Manufacturer (Id_Manufacturer) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE Phone( -- FK phone model
imei 				        VARCHAR(17) PRIMARY KEY,
id_phone_model  	        VARCHAR(25),
CONSTRAINT fk_phone_phmodel FOREIGN KEY(Id_Phone_model) REFERENCES Phone_model(Id_Phone_model) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE Component( --FK - Guarantee, Manufacturer
id_component   			        VARCHAR(25) PRIMARY KEY,
type_c 			   			    VARCHAR(20) NOT NULL,
сounts 		       			    COUNT,
name  		       			 	VARCHAR(40) NOT NULL,
id_guarantee 	       			VARCHAR(15),
manufacturer       			    VARCHAR(25) NOT NULL,
id_product						INT,
CONSTRAINT fk_comp_id_product   FOREIGN KEY(id_product) REFERENCES product (id_product) ON DELETE NO ACTION ON UPDATE RESTRICT,
CONSTRAINT fk_comp_guarantee    FOREIGN KEY(id_guarantee) REFERENCES Guarantee (ID_Guarantee) ON DELETE RESTRICT ON UPDATE RESTRICT,
CONSTRAINT fk_comp_manufacturer FOREIGN KEY(manufacturer) REFERENCES Manufacturer (Id_Manufacturer) ON DELETE RESTRICT ON UPDATE CASCADE
);

CREATE TABLE List_of_supported_models( -- FK - phone model, component
id_list_of_sup_models 	        VARCHAR (5) PRIMARY KEY,
list_supmodel_name				VARCHAR(25),
id_component 			        VARCHAR(25),
id_phone_model 			        VARCHAR(25),
CONSTRAINT  fk_lm_phone_model   FOREIGN KEY (Id_Phone_model) REFERENCES Phone_model (Id_Phone_model) ON DELETE NO ACTION ON UPDATE CASCADE,
CONSTRAINT  fk_lm_component     FOREIGN KEY (Id_component) REFERENCES Component (Id_component) ON DELETE NO ACTION ON UPDATE CASCADE
);


	-- Администратор --
CREATE ROLE admin LOGIN;
--ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT, INSERT, UPDATE, DELETE, TRIGGER, CONNECT, TEMPORARY, EXECUTE  ON TABLES TO admin;
GRANT INSERT ON Client, Order_, Order_delivery, Order_status, Guarantee,Manufacturer, Pushare_agreement, Position_in_order, Phone_model, Component, List_of_supported_models, product, Supplier,Supply, Supply_order, supplied_product TO manager;
GRANT UPDATE ON Client, Order_, Order_delivery, Order_status, Guarantee,Manufacturer, Pushare_agreement, Position_in_order, Phone_model, Component, List_of_supported_models, product, Supplier,Supply, Supply_order, supplied_product TO manager;
GRANT DELETE ON Order_, Order_delivery, Order_status, Manufacturer, Position_in_order, Phone_model, Component, product, List_of_supported_models,  Supply_order, Supplier, supplied_product TO manager;

	-- Менеджер --
CREATE ROLE manager LOGIN;
--! ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON TABLES TO manager;
GRANT INSERT, UPDATE ON Client, Order_, Order_delivery, Order_status, Guarantee, Pushare_agreement, Position_in_order, Phone_model, Component, List_of_supported_models, product, Supplier,Supply, Supply_order, supplied_product TO manager;
GRANT DELETE ON Order_delivery, Position_in_order,product, List_of_supported_models,  Supplier, supplied_product TO manager;

	-- Продавец --
CREATE ROLE saler LOGIN;
--ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE ON TABLES TO saler;
GRANT INSERT ON Client, Order_, Order_delivery, Order_status, Pushare_agreement, Position_in_order, product TO client;
GRANT UPDATE ON Order_, Order_delivery, Order_status, Pushare_agreement, Position_in_order, product TO client;
GRANT DELETE ON Position_in_order TO client;

	-- Клиент --
CREATE ROLE client LOGIN;
--ALTER DEFAULT PRIVILEGES IN SCHEMA public GRANT SELECT ON TABLES TO client;
GRANT SELECT ON Guarantee, Shop, Phone_model, Component, product, List_of_supported_models TO client;


create unlogged table client_import (doc json);
\copy client_import from 'E:\_Ychybus\2 курс\УД\__Проект\Clients.json'


CREATE FUNCTION pickup_order() RETURNS TRIGGER AS
$body$
    BEGIN
        IF(EXISTS(
                SELECT *
                FROM order_ o
                    JOIN Pushare_agreement Pa on OLD.id_Order = Pa.id_order
                WHERE paid = true
            )
            OR EXISTS(
                SELECT *
                FROM order_ o
                    JOIN order_status os on OLD.id_Order_status = os.id_order_status
                WHERE NEW.description_Order_status != 'получено'
            )
        )
        THEN
            RETURN NEW;
        ELSE
            RAISE EXCEPTION 'Заказ не оплачен';
        end if;
    end;
$body$
language plpgsql;
CREATE TRIGGER t_pickup_order
    BEFORE UPDATE ON order_
    FOR EACH  STATEMENT EXECUTE  FUNCTION pickup_order();

