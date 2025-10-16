CREATE DATABASE Project;
use Project;

CREATE TABLE [user] (
    full_name VARCHAR(100),
    email VARCHAR(100),
    date_of_birth DATE,
    gender VARCHAR(10),
    role VARCHAR(50),
    password VARCHAR(100),
    phone_number VARCHAR(15) PRIMARY KEY
);

CREATE TABLE admin (
    full_name VARCHAR(100),
    email VARCHAR(100),
    date_of_birth DATE,
    gender VARCHAR(10),
    role VARCHAR(50),
    password VARCHAR(100),
    phone_number VARCHAR(15) PRIMARY KEY
);


ALTER TABLE [user]
ADD membership VARCHAR(50);

CREATE TABLE premium (
    PAYMENT_ID INT PRIMARY KEY,
    P_AMOUNT DECIMAL(10, 2),
    DATE DATE,
    PROMOCODE VARCHAR(50)
);


ALTER TABLE premium
ADD user_phone_number VARCHAR(15),
FOREIGN KEY (user_phone_number) REFERENCES [user](phone_number);


CREATE TABLE artist (
    A_ID INT PRIMARY KEY,
    A_NAME VARCHAR(100),
    A_GENRE VARCHAR(100),
    A_BIOGRAPHY TEXT
);











