CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Nome NVARCHAR(100) NOT NULL,
	CPF NVARCHAR (11) NOT NULL,
    Email NVARCHAR(150) NOT NULL UNIQUE,
    Telefone NVARCHAR(20),
    DataCadastro DATE NOT NULL
);

CREATE TABLE Jogos (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    Titulo NVARCHAR(150) NOT NULL,
    IdGenero INT NOT NULL,
    Preco DECIMAL(10,2) NOT NULL,
    DataLancamento DATE NOT NULL,
	FOREIGN KEY (IdGenero) REFERENCES Genero(Id),
);

CREATE TABLE Registros (
    Id INT PRIMARY KEY IDENTITY(1, 1),
    IdUsuario INT NOT NULL,
    IdJogo INT NOT NULL,
    DataAluguel DATE NOT NULL,
    DataDevolucao DATE NOT NULL,

    FOREIGN KEY (IdUsuario) REFERENCES Usuarios(Id),
    FOREIGN KEY (IdJogo) REFERENCES Jogos(Id)
);

-- Insert Usuários
INSERT INTO Usuarios (Nome, CPF, Email, Telefone, DataCadastro)
VALUES 
('João Silva', '12345678901', 'joao@email.com', '11999990001', '2025-01-10'),
('Maria Oliveira', '98765432100', 'maria@email.com', '11999990002', '2025-01-15'),
('Carlos Souza', '45678912300', 'carlos@email.com', '11999990003', '2025-02-01');

-- Insert Jogos
INSERT INTO Jogos (Titulo, IdGenero, Preco, DataLancamento)
VALUES
('God of War Ragnarok', 1, 349.90, '2022-11-09'),
('FIFA 24', 2, 299.90, '2023-09-29'),
('The Witcher 3', 3, 199.90, '2015-05-19'),
('Uncharted 4', 4, 149.90, '2016-05-10'),
('Minecraft', 5, 99.90, '2011-11-18');

-- Insert Registros
INSERT INTO Registros (IdUsuario, IdJogo, DataAluguel, DataDevolucao)
VALUES
(1, 1, '2025-02-01', '2025-02-05'),
(2, 2, '2025-02-03', '2025-02-08'),
(3, 5, '2025-02-05', '2025-02-10'),
(1, 3, '2025-02-07', '2025-02-12');

-- SELECT COMPLETO:
SELECT 
    r.Id,
    u.Nome AS NomeUsuario,
    j.Titulo AS NomeJogo,
    j.IdGenero AS Genero,
    r.DataAluguel,
    r.DataDevolucao
FROM Registros r
INNER JOIN Usuarios u ON r.IdUsuario = u.Id
INNER JOIN Jogos j ON r.IdJogo = j.Id;


