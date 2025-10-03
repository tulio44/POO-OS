create database os_48;
use os_48;

create table usuario(
id int unsigned auto_increment not null primary key,
nome varchar(80) default null,
email varchar(80) default null,
telefone varchar(18) default null,
setor int default null
);

create table setor(
id int unsigned auto_increment not null primary key,
descricao varchar(100) default null
);

select * from setor;

create table tecnico(
id int unsigned auto_increment not null primary key,
descricao varchar(80) default null,
especialidade int default null
);
create table especialidade(
id int unsigned auto_increment not null primary key,
especialidade varchar(100) default null
);
create table OS(
id int unsigned auto_increment not null primary key,
desricao varchar(250) default null,
status_os varchar(250) default null,
tecnico int null default null,
usuario int null default null
);	