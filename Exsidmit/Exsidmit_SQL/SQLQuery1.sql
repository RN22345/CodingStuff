create database exsidmit_DB;
use exsidmit_DB;

create table login_credentials (
	student_id int Unique,
	username nvarchar(50),
	userpassword nvarchar(50),
	course nvarchar(50),
	yearlevel int,
	age int,
	sex nvarchar (10)
)
-- drop table login_credentials;

select * from login_credentials;

insert into login_credentials (student_id, username, userpassword, course, yearlevel, age, sex)
values ('243361','Jesse', 'Pogiako123', 'BSIT', '2','20', 'Male');

