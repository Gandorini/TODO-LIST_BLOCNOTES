using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Bloc
{
    internal static class Program
    {
    

        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DatabaseInitializer.CreateDatabase();
            DatabaseInitializer.CreateTables();

            Application.Run(new Form1());

        }




        public static class DatabaseInitializer
        {
            public static void CreateDatabase()
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("IF DB_ID('BlocDBB') IS NULL CREATE DATABASE BlocDBB", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao criar base de dados: {ex.Message}");
                    }
                }
            }

            public static void CreateTables()
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BlocDBB;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True"))
                {
                    try
                    {
                        connection.Open();
                        string createTableQuery = @"
                    IF OBJECT_ID('Utilizador', 'U') IS NULL
                    CREATE TABLE Utilizador (
                        UserID INT PRIMARY KEY IDENTITY(1,1),
                        Username NVARCHAR(50) NOT NULL UNIQUE,
                        PasswordHash NVARCHAR(100) NOT NULL
                    );

                    IF OBJECT_ID('Categorias', 'U') IS NULL
                    CREATE TABLE Categorias (
                        CategoriaID INT PRIMARY KEY IDENTITY(1,1),
                        CategoriaNome NVARCHAR(50) NOT NULL,
                        Description NVARCHAR(2000),
                        CONSTRAINT UQ_CategoriaNome UNIQUE (CategoriaNome)
                    );

                    IF OBJECT_ID('ListaLeitura', 'U') IS NULL
                    CREATE TABLE ListaLeitura (
                        ReadingID INT PRIMARY KEY IDENTITY(1,1),
                        NomeObra NVARCHAR(100) NOT NULL,
                        CategoriaNome NVARCHAR(50) NOT NULL,
                        FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
                    );

                    IF OBJECT_ID('Anotacoes', 'U') IS NULL
                    CREATE TABLE Anotacoes (
                        NOMETXT NVARCHAR(MAX) NOT NULL,
                        AnotacoesTxt NVARCHAR(MAX) NOT NULL,
                        CategoriaNome NVARCHAR(50) NOT NULL,
                        FOREIGN KEY (CategoriaNome) REFERENCES Categorias(CategoriaNome)
                    );

                    IF OBJECT_ID('Documents', 'U') IS NULL
                    CREATE TABLE Documents (
                        DocumentID INT PRIMARY KEY IDENTITY(1,1),
                        DocumentName NVARCHAR(100) NOT NULL,
                        FilePath NVARCHAR(255) NOT NULL
                    );

                    IF OBJECT_ID('CalendarioMarcacoes', 'U') IS NULL
                    CREATE TABLE CalendarioMarcacoes (
                        MarcacaoID INT PRIMARY KEY IDENTITY(1,1),
                        DataMarcacao DATE NOT NULL,
                        Titulo NVARCHAR(100) NOT NULL,
                        Descricao NVARCHAR(255),
                        Localizacao NVARCHAR(100)
                    );
                    ";
                        using (SqlCommand command = new SqlCommand(createTableQuery, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao criar tabelas: {ex.Message}");
                    }
                }
            }
        }
    }
}
