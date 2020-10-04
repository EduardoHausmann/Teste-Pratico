DROP TABLE IF EXISTS jogos, temporadas;
CREATE TABLE temporadas(
id_temporada INT PRIMARY KEY IDENTITY(1,1),
inicio DATE,
fim DATE
);

CREATE TABLE jogos(
id_jogo INT PRIMARY KEY IDENTITY(1,1),
pontuacao INT,
id_temporada INT,
FOREIGN KEY (id_temporada) REFERENCES temporadas(id_temporada)
);