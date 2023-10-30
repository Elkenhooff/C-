CREATE DATABASE woodland;
USE woodland;

CREATE TABLE saves(
usuario VARCHAR(16) NOT NULL PRIMARY KEY,
wood DOUBLE NOT NULL,
money DOUBLE NOT NULL,
prestige DOUBLE NOT NULL,
ascension DOUBLE NOT NULL,
woodupg1 INT NOT NULL,
woodupg2 INT NOT NULL,
woodupg3 INT NOT NULL,
woodupg4 INT NOT NULL, 
woodupg5 INT NOT NULL,
woodupg6 INT NOT NULL,
woodupg7 INT NOT NULL,
woodupg8 INT NOT NULL,
plantilupg1 INT NOT NULL,
plantilupg2 INT NOT NULL,
plantilupg3 INT NOT NULL,
plantilupg4 INT NOT NULL,
plantilupg5 INT NOT NULL,
plantilupg6 INT NOT NULL,
plantilupg7 INT NOT NULL,
plantilupg8 INT NOT NULL,
plantilupg9 INT NOT NULL,
ascensionupg1 INT NOT NULL,
ascensionupg2 INT NOT NULL,
ascensionupg3 INT NOT NULL, 
ascensionupg4 INT NOT NULL,
ascensionupg5 INT NOT NULL,
ascensionupg6 INT NOT NULL,
ascensionupg7 INT NOT NULL,
ascensionupg8 INT NOT NULL,
arvores INT NOT NULL,
senha VARCHAR(16) NOT NULL
);

#INSERT INTO saves (usuario, wood, money, prestige, ascension, woodupg1, woodupg2, woodupg3, woodupg4, woodupg5, woodupg6, woodupg7, woodupg8, plantilupg1, plantilupg2, plantilupg3, plantilupg4, plantilupg5, plantilupg6, plantilupg7, plantilupg8, plantilupg9, ascensionupg1, ascensionupg2, ascensionupg3, ascensionupg4, ascensionupg5, ascensionupg6, ascensionupg7, ascensionupg8, arvores, senha)
VALUES ('Elkenhooff', 150.5, 200.0, 10.2, 0.5, 20, 15, 30, 25, 10, 5, 7, 12, 100, 200, 50, 60, 70, 80, 90, 100, 110, 5, 10, 15, 20, 25, 30, 35, 40, 500, '123@teste');

#INSERT INTO saves (usuario, wood, money, prestige, ascension, woodupg1, woodupg2, woodupg3, woodupg4, woodupg5, woodupg6, woodupg7, woodupg8, plantilupg1, plantilupg2, plantilupg3, plantilupg4, plantilupg5, plantilupg6, plantilupg7, plantilupg8, plantilupg9, ascensionupg1, ascensionupg2, ascensionupg3, ascensionupg4, ascensionupg5, ascensionupg6, ascensionupg7, ascensionupg8, arvores, senha)
VALUES ('Richard', 300.0, 500.7, 15.0, 1.2, 25, 20, 35, 30, 12, 8, 10, 15, 150, 250, 70, 80, 90, 100, 110, 120, 130, 10, 20, 30, 40, 50, 60, 70, 80, 1000, '123@mudar');

#INSERT INTO saves (usuario, wood, money, prestige, ascension, woodupg1, woodupg2, woodupg3, woodupg4, woodupg5, woodupg6, woodupg7, woodupg8, plantilupg1, plantilupg2, plantilupg3, plantilupg4, plantilupg5, plantilupg6, plantilupg7, plantilupg8, plantilupg9, ascensionupg1, ascensionupg2, ascensionupg3, ascensionupg4, ascensionupg5, ascensionupg6, ascensionupg7, ascensionupg8, arvores, senha)
VALUES ('Usuario3', 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 'senha789');

