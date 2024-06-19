
use BlocDB


CREATE TABLE Utilizador (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(100) NOT NULL,
);




CREATE TABLE ListaLeitura (
    ReadingID INT PRIMARY KEY IDENTITY(1,1),
    UserID INT NOT NULL,
    NomeObra NVARCHAR(100) NOT NULL,
    CategoryID INT,
    ReadStatus BIT NOT NULL DEFAULT 0, -- 0 = não lido, 1 = lido
    FOREIGN KEY (UserID) REFERENCES Utilizador(UserID),
    FOREIGN KEY (CategoryID) REFERENCES Categorias(CategoriaID)
);



CREATE TABLE Documents (
    DocumentID INT PRIMARY KEY IDENTITY(1,1),
    DocumentName NVARCHAR(100) NOT NULL,
    FilePath NVARCHAR(255) NOT NULL,
);

CREATE TABLE CalendarioMarcacoes (
    MarcacaoID INT PRIMARY KEY IDENTITY(1,1),
    DataMarcacao DATE NOT NULL,
    Titulo NVARCHAR(100) NOT NULL,
    Descricao NVARCHAR(255),
    Localizacao NVARCHAR(100)
);

INSERT INTO Categorias (CategoriaNome)
VALUES ('Supermercado'),
       ('Trabalho'),
       ('Estudos'),
       ('Pessoais'),
       ('Diario'),
       ('Outro...');

SELECT * FROM Anotacoes

ALTER TABLE Anotacoes
DROP CONSTRAINT UC_NomeCategoria;


CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    CategoriaNome NVARCHAR(50) NOT NULL UNIQUE,
    NomeObra NVARCHAR(50),
    Description NVARCHAR(2000)
);

-- Criação da tabela Anotacoes
CREATE TABLE Anotacoes (
    UserID INT NOT NULL,
    NomeTXT NVARCHAR(MAX) NOT NULL,
    AnotacoesTxt NVARCHAR(MAX) NOT NULL,
    CategoriaNome NVARCHAR(50) NOT NULL,
    FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
	);

	DROP TABLE IF EXISTS Anotacoes;
	DROP TABLE IF EXISTS Categorias;


	ALTER TABLE Categorias
	DROP COLUMN CategoriaNome;

	ALTER TABLE Anotacoes
	DROP CONSTRAINT FK_Anotacoes_Categorias;
