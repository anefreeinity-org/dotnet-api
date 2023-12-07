
CREATE SCHEMA IF NOT EXISTS Anime;
CREATE TABLE Anime.MAL (
  id INT,
  name VARCHAR(255),
  genres VARCHAR(255),
  year INT
);

insert into Anime.MAL(id, name, genres, year) values(1, 'One Piece', 'advanture, action', 1999);
insert into Anime.MAL(id, name, genres, year) values(2, 'Naruto', 'advanture, action', 2000);