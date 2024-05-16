
use BlocDB


CREATE TABLE Utilizador (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(100) NOT NULL,
);


CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    CategoriaNome NVARCHAR(50) NOT NULL UNIQUE,
	NomeObra NVARCHAR(50),
	Description NVARCHAR(2000)
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

CREATE TABLE  Anotacoes (
	UserID INT NOT NULL,
	CategoriasID INT,
    AnotacoesTxt NVARCHAR(MAX) NOT NULL,
	FOREIGN KEY (CategoriasID) REFERENCES Categorias(CategoriaID)
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

