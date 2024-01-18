create  database catalogodemusica;
use catalogodemusica;

CREATE TABLE cliente (
    idcliente INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(64) NOT NULL,
    email VARCHAR(256) NOT NULL,
    telefone varchar(12) NOT NULL,
    senha VARCHAR(24) NOT NULL
);

CREATE TABLE artista (
    idartista INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(64) NOT NULL,
    cpf INT(11) NOT NULL,
    telefone CHAR(12) NOT NULL
);

CREATE TABLE estmusical (
    idEstmusical INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(64) NOT NULL
);

CREATE TABLE musica (
    idmusica INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
    nome VARCHAR(64) NOT NULL,
    artist INT NOT NULL,
    estmusical INT NOT NULL,
    FOREIGN KEY (artist)
        REFERENCES artista (idartista),
    FOREIGN KEY (estmusical)
        REFERENCES estmusical (idEstmusical)
);

CREATE VIEW playlist AS
SELECT m.idmusica AS ID, m.nome AS Musica, a.nome AS Artista, e.nome AS Estilo
FROM musica m
LEFT JOIN artista a ON m.artist = a.idartista
LEFT JOIN estmusical e ON m.estmusical = e.idEstmusical;
INSERT INTO cliente (nome, email, telefone, senha) VALUES
	('adm','adm@spotify.com','11110000','adm'),
    ('Maria Silva', 'maria@gmail.com', '55556666', 'senha123'),
    ('João Santos', 'joao@yahoo.com', '987654321', 'senha456'),
    ('Ana Oliveira', 'ana@hotmail.com', '123456789', 'senha789'),
    ('Pedro Lima', 'pedro@gmail.com', '4444333222', 'senhaabc'),
    ('Carlos Souza', 'carlos@gmail.com', '11112222333', 'senha123'),
    ('Larissa Santos', 'larissa@yahoo.com', '99998887777', 'senha456'),
    ('Ricardo Oliveira', 'ricardo@hotmail.com', '88887777666', 'senha789'),
    ('Fernanda Lima', 'fernanda@gmail.com', '55554444333', 'senhaabc'),
    ('Lucas Pereira', 'lucas@yahoo.com', '33332222111', 'senha456'),
    ('Aline Costa', 'aline@hotmail.com', '77776666555', 'senha789'),
    ('Rodrigo Silva', 'rodrigo@gmail.com', '44443333222', 'senhaabc'),
    ('Gabriela Santos', 'gabriela@yahoo.com', '22221111000', 'senha123'),
    ('Márcio Oliveira', 'marcio@hotmail.com', '66665555444', 'senha789'),
    ('Cristina Lima', 'cristina@gmail.com', '33332222111', 'senhaabc'),
    ('Guilherme Pereira', 'guilherme@yahoo.com', '55554444333', 'senha123'),
    ('Beatriz Costa', 'beatriz@hotmail.com', '88887777666', 'senha456'),
    ('Isabela Silva', 'isabela@gmail.com', '77776666555', 'senha789'),
    ('Mariana Santos', 'mariana@yahoo.com', '44443333222', 'senhaabc'),
    ('Paulo Oliveira', 'paulo@hotmail.com', '11112222333', 'senha123'),
    ('Amanda Lima', 'amanda@gmail.com', '22221111000', 'senha456'),
    ('Henrique Pereira', 'henrique@yahoo.com', '99998887777', 'senha789'),
    ('Patrícia Costa', 'patricia@hotmail.com', '66665555444', 'senhaabc'),
    ('Daniel Silva', 'daniel@gmail.com', '55554444333', 'senha123'),
    ('Lívia Santos', 'livia@yahoo.com', '44443333222', 'senha456'),
    ('Vinícius Oliveira', 'vinicius@hotmail.com', '11112222333', 'senha789'),
    ('Renata Lima', 'renata@gmail.com', '77776666555', 'senhaabc'),
    ('Alexandre Santos', 'alexandre@yahoo.com', '66665555444', 'senha123'),
    ('Camila Costa', 'camila@hotmail.com', '55554444333', 'senha456'),
    ('Gustavo Pereira', 'gustavo@gmail.com', '99998887777', 'senha789'),
    ('Juliana Silva', 'juliana@yahoo.com', '22221111000', 'senhaabc'),
    ('Felipe Oliveira', 'felipe@hotmail.com', '33332222111', 'senha123'),
    ('Vanessa Lima', 'vanessa@gmail.com', '44443333222', 'senha456'),
    ('Thiago Santos', 'thiago@yahoo.com', '11112222333', 'senha789'),
    ('Carolina Costa', 'carolina@hotmail.com', '77776666555', 'senhaabc');

INSERT INTO artista (nome, cpf, telefone) VALUES
    ('Taylor Swift', '11111111111', '1234567890'),
    ('Katy Perry', '22222222222', '9876543210'),
    ('Martin Garrix', '33333333333', '5555555555'),
    ('David Guetta', '44444444444', '9999999999'),
	('Beyoncé', '12121212121', '1112223333'),
    ('Ed Sheeran', '13131313131', '4445556666'),
    ('Rihanna', '14141414141', '7778889999'),
    ('Alok', '15151515151', '1234567890'),
	('Adele', '16161616161', '1112223333'),
    ('Drake', '17171717171', '4445556666'),
    ('Ariana Grande', '18181818181', '7778889999'),
    ('Shawn Mendes', '19191919191', '1234567890'),
    ('Lady Gaga', '20202020202', '1112223333'),
    ('Justin Bieber', '21212121212', '4445556666'),
    ('Bruno Mars', '22222222222', '7778889999'),
    ('Dua Lipa', '23232323232', '1234567890'),
    ('Coldplay', '24242424242', '1112223333'),
    ('The Weeknd', '25252525252', '4445556666'),
    ('Nicki Minaj', '26262626262', '7778889999'),
    ('John Legend', '27272727272', '1234567890'),
    ('Eminem', '28282828282', '1112223333'),
    ('Khalid', '29292929292', '4445556666'),
    ('Cardi B', '30303030303', '7778889999'),
    ('Post Malone', '31313131313', '1234567890');
    
    INSERT INTO estmusical (nome) VALUES
    ('Pop'),
    ('EDM'),
	('Funk'),
    ('Jazz'),
    ('Hip Hop'),
    ('Eletrônica'),
    ('Indie'),
	('Rock'),
    ('Samba'),
    ('Rap'),
    ('Country'),
    ('Reggae');

INSERT INTO musica (nome, artist, estmusical)
VALUES
    ('Love Story', 1, 1),        
    ('Firework', 2, 1),          
    ('Animals', 3, 2),           
    ('Titanium', 4, 2),
	('Halo', 5, 1),           
    ('Shape of You', 6, 1),    
    ('Diamonds', 7, 1),        
    ('Ocean Drive', 8, 4),     
    ('Rolling in the Deep', 9, 2),  
    ('Hotline Bling', 10, 3),      
    ('7 Rings', 11, 1),
    ('Irreplaceable', 6, 1); 

