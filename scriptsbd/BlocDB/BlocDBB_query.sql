CREATE TABLE Utilizador (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL UNIQUE,
    PasswordHash NVARCHAR(100) NOT NULL
);
 

 
CREATE TABLE Categorias (
    CategoriaID INT PRIMARY KEY IDENTITY(1,1),
    CategoriaNome NVARCHAR(50) NOT NULL,
	Description NVARCHAR(2000),
	CONSTRAINT UQ_CategoriaNome UNIQUE (CategoriaNome)
);
 


CREATE TABLE ListaLeituraa (
    ReadingID INT PRIMARY KEY IDENTITY(1,1),
    NomeObra NVARCHAR(100) NOT NULL,
	CategoriaNome NVARCHAR(50) NOT NULL,
	FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
);
 



CREATE TABLE  Anotacoess (
	NOMETXT NVARCHAR(MAX) NOT NULL,
	AnotacoesTxt NVARCHAR(MAX) NOT NULL,
	CategoriaNome NVARCHAR(50) NOT NULL,
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





Alter table Categorias
Drop Column NomeObra;
Select * From Categorias


Select *  From ListaLeitura

INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Terror');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Comédia');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Aventura');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Drama');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Suspense');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Ficção-Científica');
INSERT INTO ListaLeituraa (CategoriaNome) VALUES ('Teatro');



INSERT INTO Categorias (CategoriaNome, Description) VALUES
('Outro...','Categoria relacionada a outros assuntos');

SELECT DISTINCT CategoriaNome FROM Categorias


Select CONSTRAINT_NAME
From INFORMATION_SCHEMA.TABLE_CONSTRAINTS
Where TABLE_NAME= 'Categorias' AND CONSTRAINT_TYPE='UNIQUE';



	Alter table Anotacoes
	Drop constraint FK_Anotacoes_Categorias;

SELECT
    fk.name AS ForeignKey,
    tp.name AS ParentTable,
    tr.name AS ReferencedTable
FROM
    sys.foreign_keys AS fk
    INNER JOIN sys.tables AS tp ON fk.parent_object_id = tp.object_id
    INNER JOIN sys.tables AS tr ON fk.referenced_object_id = tr.object_id
WHERE
    tp.name = 'ListaLeitura';

	ALTER TABLE ListaLeitura
DROP CONSTRAINT FK__ListaLeit__Categ__2B3F6F97;

Alter table Anotacoes

Insert into ListaLeituraa(CategoriaNome) VALUES 
()

DROP TABLE IF EXISTS Anotacoes;


IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'UQ_CategoriaNome' AND object_id = OBJECT_ID('Categorias'))
BEGIN
   
    ALTER TABLE Categorias
    ADD CONSTRAINT UQ_CategoriaNome UNIQUE (CategoriaNome);
END


ALTER TABLE Anotacoes
ADD CONSTRAINT FK_Anotacoes_Categorias
FOREIGN KEY (CategoriaNome)
REFERENCES Categorias(CategoriaNome);
