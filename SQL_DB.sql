create database validationDb
go
use validationDb
go
create table UserTable
(
Userid int identity primary key,
username varchar(30),
pass varchar(30),
cpass varchar(30),
age int,
email varchar(50),
mobile varchar(40)
)
