create database Friends;

use Friends;

create table Friend(

    _friendID int primary key Identity(1,1),
    _friendName varchar(100)not null,
    _place varchar(100) not null,
    _BirthDay varchar(100) not null,
    _NickName varchar(100) not null,
    _Gender varchar(50)
); 
