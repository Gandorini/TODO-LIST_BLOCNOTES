Use BlocDBB
go
  Select * From  Categorias

ALTER TABLE Categorias
ADD CategoriaTipo NVARCHAR(50) NOT NULL DEFAULT 'Anotacao';

INSERT INTO Categorias (CategoriaNome, CategoriaTipo)
VALUES ('Terror', 'Descri��o...', 'GeneroLivro'),
		('Terror', 'Descri��o...', 'GeneroLivro'),
		('Terror', 'Descri��o...', 'GeneroLivro'),
		('Terror', 'Descri��o...', 'GeneroLivro'),
		('Terror', 'Descri��o...', 'GeneroLivro'),
		('Terror', 'Descri��o...', 'GeneroLivro');
