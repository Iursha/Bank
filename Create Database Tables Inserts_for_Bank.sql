--create DB Bank
USE master
IF EXISTS (SELECT name FROM master.sys.databases WHERE name = 'Bank')
   DROP DATABASE Bank;
CREATE DATABASE Bank;
GO
USE Bank
GO

IF OBJECT_ID ('Country', 'U') IS NOT NULL  
                DROP TABLE Country;
IF OBJECT_ID ('Currency', 'U') IS NOT NULL  
                DROP TABLE Currency;
IF OBJECT_ID ('Card_type', 'U') IS NOT NULL  
                DROP TABLE Card_type;
IF OBJECT_ID ('Additional_services', 'U') IS NOT NULL  
                DROP TABLE Additional_services ;
IF OBJECT_ID ('Pay_system', 'U') IS NOT NULL  
                DROP TABLE Pay_system ;
IF OBJECT_ID ('Branch', 'U') IS NOT NULL  
                DROP TABLE Branch;
IF OBJECT_ID ('Employee', 'U') IS NOT NULL  
                DROP TABLE Employee;
IF OBJECT_ID ('Customer', 'U') IS NOT NULL  
                DROP TABLE Customer;          
IF OBJECT_ID ('Cards', 'U') IS NOT NULL  
                DROP TABLE Cards;
IF OBJECT_ID ('Loan', 'U') IS NOT NULL  
                DROP TABLE Loan;
IF OBJECT_ID ('Account', 'U') IS NOT NULL  
                DROP TABLE Account;

IF OBJECT_ID ('SWIFT', 'U') IS NOT NULL  
                DROP TABLE SWIFT;
IF OBJECT_ID ('Interest', 'U') IS NOT NULL  
                DROP TABLE Interest;

-- create tables for DB Bank

CREATE TABLE Country 
( country_id      integer NOT NULL, 
   
  country_name    varchar(20),  
  CONSTRAINT Country_PK PRIMARY KEY(country_id)  
);

INSERT INTO Country  VALUES (1, 'Russia');
INSERT INTO Country  VALUES (2, 'Kazahstan');

CREATE TABLE Currency 
( currency_id 	integer NOT NULL, 
  currency_name varchar(3),
  descripyion   varchar(20),
  CONSTRAINT Currency_PK PRIMARY KEY(currency_id)  
);

INSERT INTO Currency  VALUES (4,'RUB','');
INSERT INTO Currency  VALUES (5,'USD','');
INSERT INTO Currency  VALUES (6,'EUR','');
--
CREATE TABLE Card_type 
( type_id 	integer NOT NULL,
  type_name     varchar(20),    
  CONSTRAINT Card_type_PK PRIMARY KEY(type_id)  
);

INSERT INTO Card_type  VALUES (7,'MasterCard');
INSERT INTO Card_type  VALUES (8,'Visa');

CREATE TABLE Additional_services 
( services_id 	   integer NOT NULL, 
  services_name	   varchar(30),   
  CONSTRAINT Add_services_PK PRIMARY KEY(services_id)
  
);

INSERT INTO Additional_services  VALUES (1, 'Internet Banking');
INSERT INTO Additional_services  VALUES (2, 'SMS Mesages');


CREATE TABLE Pay_system 
( pay_system_id    integer NOT NULL, 
  pay_system_name  varchar(20),   
  CONSTRAINT Pay_system_PK PRIMARY KEY(pay_system_id)  
);

INSERT INTO Pay_system  VALUES (1, 'SWIFT');
INSERT INTO Pay_system  VALUES (2, 'WesternUnion');
INSERT INTO Pay_system  VALUES (3, 'PAYPAL');

CREATE TABLE Branch 
( branch_id        integer NOT NULL, 
  branch_name      varchar(10),
  branch_address   varchar(50),
  phone            integer, 
  CONSTRAINT Branch_PK PRIMARY KEY(branch_id)  
);

INSERT INTO Branch  VALUES (45,'aa', 'USA',987755545);
INSERT INTO Branch  VALUES (46,'bb', 'Europe',755334422);
INSERT INTO Branch  VALUES (47,'cc', 'Australia',112223456);
INSERT INTO Branch  VALUES (48,'dd', 'Asia',223334567);

CREATE TABLE Employee 
( employee_id      integer NOT NULL, 
  employee_name    varchar(20),
  position         varchar(20),
  phone            integer,
  fk_branch_id     integer,   
  CONSTRAINT Employee_PK PRIMARY KEY(employee_id),  
  CONSTRAINT  Employee_FK_Branch FOREIGN KEY (fk_branch_id) REFERENCES Branch (branch_id),   
);

INSERT INTO Employee  VALUES (1, 'Jim Jones','credit_manager',5554433,45);
INSERT INTO Employee  VALUES (2, 'Julie Anderson','credit_manager',2203546,46);
INSERT INTO Employee  VALUES (3, 'Jim Anderson','credit_manager',4463235,47);
INSERT INTO Employee  VALUES (4, 'Brad Pitt','salesman',3363235,47);
INSERT INTO Employee  VALUES (5, 'Juliett Binosh','driver',5563235,47);
INSERT INTO Employee  VALUES (6, 'Mel Gibson','security',8863235,46);

CREATE TABLE Customer 
( customer_id       integer NOT NULL, 
  FIO               varchar(50),
  sex               varchar(1),
  birthday          date,
  country_id        integer not null,
  passport_seria    varchar(4),
  passport_number   integer,
  branch_id         integer not null,
  indexx            integer,  
  address           varchar(50),
  phone_home        integer,
  phone_mob         integer,
  e_mail            varchar(12), 
  status            integer,
  fk_employee_id    integer,    
  CONSTRAINT Customer_PK PRIMARY KEY(customer_id),
  CONSTRAINT Customer_FK_Country  FOREIGN KEY (country_id) REFERENCES Country (country_id),
  CONSTRAINT Customer_FK_Employee FOREIGN KEY (fk_employee_id) REFERENCES Employee (employee_id)
);

INSERT INTO Customer  VALUES 
(1, 'Jim Jones'     ,'M','19870621',1,'BN',112233,45,234532,'USA,CA'           ,3433445,9733445,'',2,1);        INSERT INTO Customer  VALUES 
(2, 'Julie Anderson','F','19771123',2,'AO',324425,46,556784,'Australia,Melburn',4463455,6789040,'',1,1);

--cards--
CREATE TABLE Cards 
( cards_id           integer NOT NULL, 
  term_to            date, 
  fk_services_id      integer,
  fk_customer_id     integer,
  fk_currency_id     integer,
  fk_pay_system_id   integer,
  fk_type_id         integer,
  pin_code           integer,
  given              varchar(1),
  date_open          date,
  fk_branch_id       integer,  
  fk_employee_id     integer,  
  CONSTRAINT Cards_PK PRIMARY KEY(Cards_id),
  CONSTRAINT Cards_FK_services FOREIGN KEY (fk_services_id) REFERENCES Additional_services(services_id),                   
  CONSTRAINT Cards_FK_Customer FOREIGN KEY (fk_customer_id) REFERENCES Customer (customer_id),
  CONSTRAINT Cards_FK_Currency FOREIGN KEY (fk_currency_id) REFERENCES Currency (currency_id),
  CONSTRAINT Cards_FK_pay FOREIGN KEY (fk_pay_system_id) REFERENCES Pay_system (pay_system_id),
  CONSTRAINT Cards_FK_Type FOREIGN KEY (fk_type_id) REFERENCES Card_type (type_id)      
);

INSERT INTO Cards  VALUES (114576777, '20160523',1,1,4,1,7,4423,'Y','20150523',46,6);
INSERT INTO Cards  VALUES (121212122, '20160524',2,1,4,2,7,4356,'N','20150524',47,2);
INSERT INTO Cards  VALUES (33445566,  '20180525',1,2,5,3,8,9802,'Y','20150525',46,5);
INSERT INTO Cards  VALUES (44552277,  '20170523',2,2,6,1,7,3110,'Y','20150523',48,2);

--Loan
CREATE TABLE Loan 
( loan_id                      integer NOT NULL,
  account_id                   integer,
  date_open                    date, 
  date_close                   date,  
  fk_customer_id               integer,
  interest_rate                decimal(4,2),
  penalty                      decimal(4,2),
  delay                        integer,
  status                       varchar(6),
  issuance_date                date,
  fk_employee_id               integer,
  fk_branch_id                 integer,
  fk_currency_id               integer, 
  CONSTRAINT Loan_PK PRIMARY KEY(loan_id),  
  CONSTRAINT  Loan_FK_Customer FOREIGN KEY (fk_customer_id) REFERENCES Customer (customer_id),
  CONSTRAINT  Loan_FK_Currency FOREIGN KEY (fk_currency_id) REFERENCES Currency (currency_id)     
);

INSERT INTO Loan  VALUES (55, 2003564876,'20150523','',1,0.18,0.06,10,'','20150603',1,46,4);
INSERT INTO Loan  VALUES (56, 2003786488,'20150524','',2,0.23,0.08, 0,'',''        ,6,45,5);

--SWIFT
CREATE TABLE SWIFT 
(swift_id           int NOT NULL, 
 fk_employee_id     int NOT NULL, 
 fk_country_id      int NOT NULL, 
 amount             decimal(20, 2) NULL, 
 swift_date         date NULL, 
 fk_currency_id     int NULL, 
 PRIMARY KEY (swift_id),
 CONSTRAINT  SWIFT_FK_employee FOREIGN KEY (fk_employee_id) REFERENCES Employee (employee_id),
 CONSTRAINT  SWIFT_FK_Country  FOREIGN KEY (fk_country_id)     REFERENCES Country (country_id),
 CONSTRAINT  SWIFT_FK_Currency FOREIGN KEY (fk_currency_id) REFERENCES Currency (currency_id)
);

INSERT INTO SWIFT  VALUES (101, 2,1,45678.34,'20150603',4);
INSERT INTO SWIFT  VALUES (606, 6,2,20000.32,'20150623',5);

--account--

CREATE TABLE Account 
(account_id      int NOT NULL, 
 date_open       date NULL, 
 date_close      date NULL, 
 fk_customer_id  int NULL, 
 fk_loan_id      int NOT NULL, 
 amount          decimal(8, 2) NULL, 
 fk_currency_id  int NOT NULL, 
 fk_employee_id   int NOT NULL, 
 account_type    char(20) NULL, 
 fk_branch_id    int NULL, 
 fk_swift_id     int NULL, 
 description     char(50) NULL, 
 loro            char(3) NULL, 
 nostro          char(3) NULL, 
 PRIMARY KEY (account_id),
 CONSTRAINT  Account_FK_Customer FOREIGN KEY (fk_customer_id) REFERENCES Customer (customer_id),
 CONSTRAINT  Account_FK_Currency FOREIGN KEY (fk_currency_id) REFERENCES Currency (currency_id),
 CONSTRAINT  Account_FK_Loan     FOREIGN KEY (fk_loan_id)     REFERENCES Loan (loan_id),
 CONSTRAINT  Account_FK_employee FOREIGN KEY (fk_employee_id) REFERENCES Employee (employee_id),
 CONSTRAINT  Account_FK_branch   FOREIGN KEY (fk_branch_id)   REFERENCES Branch (branch_id),
 CONSTRAINT  Account_FK_swift    FOREIGN KEY (fk_swift_id)    REFERENCES Swift (swift_id) 
 );

INSERT INTO Account  VALUES (200355, '20150523','20150923',1,55,60000.00,4,2,'dddee',46,101,'desc','Yes','No');
INSERT INTO Account  VALUES (200356, '20150524','20150923',2,56,82000.00,5,6,'dder' ,48,606,'desc','Yes','No');

--Interest
CREATE TABLE Interest 
(acc_interest_id        int NOT NULL, 
 fk_main_account_id     int NOT NULL, 
 interest_rate          decimal(5, 2) NULL, 
 interest_amount        decimal(8, 2) NULL,
 interest_date          date, 
 PRIMARY KEY (acc_interest_id),
 CONSTRAINT  Interest_FK_Account FOREIGN KEY (fk_main_account_id) REFERENCES Account (account_id)
);

INSERT INTO Interest  VALUES (555, 200355,12.33,2367.45,'20150523');
INSERT INTO Interest  VALUES (777, 200356,22.12,3678.32,'20150524');