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
	CategoriaNome NVARCHAR(50) NOT NULL UNIQUE,
	FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
);
 
CREATE TABLE  Anotacoes (
	
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


Drop table ListaLeitura;
	
Use BlocDB

-- Inserir categorias fixas na tabela Categorias
INSERT INTO Categorias (CategoriaNome) VALUES 
('Pessoais'),
('Diárias'),
('Trabalho'),
('Estudo'),
('Compras'),
('Outro...');
