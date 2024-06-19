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
    NomeObra NVARCHAR(100) NOT NULL,
    ReadStatus BIT NOT NULL DEFAULT 0, -- 0 = não lido, 1 = lido
);
 
CREATE TABLE  Anotacoes (
	UserID INT NOT NULL,
       NomeTXT NVARCHAR(MAX) NOT NULL,
       AnotacoesTxt NVARCHAR(MAX) NOT NULL,
       CategoriaNome NVARCHAR(50) NOT NULL UNIQUE,
	FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
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