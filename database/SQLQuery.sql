/*
use master;
ALTER LOGIN sa ENABLE;
ALTER LOGIN sa WITH PASSWORD = 'dbpasswd1234';
create database InkWatch_db;
create table users (
user_id int NOT NULL,
user_name varchar(50) NOT NULL,
user_passwd varchar(150) NOT NULL,
PRIMARY KEY (user_id));

create table deleted_users ( 
user_id int,
user_name varchar(50),
user_passwd varchar(150)
);
insert into users (user_name,user_passwd) VALUES ('admin',12345);*/





select * from users;