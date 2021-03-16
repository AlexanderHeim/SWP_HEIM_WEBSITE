create database if not exists db_blog collate utf8mb4_general_ci;
use db_blog;

create table if not exists articles(
	article_id int unsigned not null auto_increment primary key,
    title VARCHAR(128) not null,
    html_text VARCHAR(8192) not null
);