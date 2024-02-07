CREATE SCHEMA IF NOT EXISTS Anime;
CREATE TABLE Anime.MAL (
  id SERIAL PRIMARY KEY,
  name VARCHAR(255),
  genres VARCHAR(255),
  year INT
);

insert into Anime.MAL(name, genres, year) values('One Piece', 'advanture, action', 1999);