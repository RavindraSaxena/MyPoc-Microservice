CREATE DATABASE TestDB
GO

USE TestDB
GO

CREATE TABLE PERSON (
    ID INT IDENTITY(1,1),
    [NAME] varchar(100) not null
)
GO

insert into PERSON (NAME) values ('Kim');
insert into PERSON (NAME) values ('Pankaj');
insert into PERSON (NAME) values ('Tarun');
insert into PERSON (NAME) values ('Ravindra');
insert into PERSON (NAME) values ('Sharad');