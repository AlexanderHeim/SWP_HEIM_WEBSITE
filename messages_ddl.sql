create database if not exists db_blog collate utf8mb4_general_ci;

use db_blog;

create table if not exists messages(
	message_id int unsigned not null auto_increment PRIMARY KEY,
    username varchar(32) not null,
    text varchar(256) not null
)engine=InnoDb;
insert into messages values(null, "Alexander Heim", "Das ist eine Testnachricht. Bitte nicht beachten!");
insert into messages values(null, "Johannes Plattner", "Hallo meine Freunde. Ich weiß nicht was schreiben!");

select * from messages;