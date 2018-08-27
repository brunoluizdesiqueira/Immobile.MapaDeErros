using System.Data;
using System.IO;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace Immobile.MapaDeErros.Db
{
    public class Seed
    {
        private static IDbConnection _dbConnection;
        public static void CreateDb(IConfiguration configuration)
        {
            var connectionString = configuration.GetValue<string>("DBInfo:ConnectionString");
            var dbFilePath = configuration.GetValue<string>("DBInfo:ConnectionString");

            if (!File.Exists(dbFilePath))
            {
                _dbConnection = new NpgsqlConnection(connectionString);
                _dbConnection.Open();

                // Create a Funcao table
                _dbConnection.Execute(@"
                    CREATE TABLE IF NOT EXISTS Funcao (
                        ID SERIAL NOT NULL PRIMARY KEY,
                        Nome VARCHAR(128) NOT NULL,
                        Status INTEGER NOT NULL,
                        DataCriacao TIMESTAMP NOT NULL, 
                        DataAtivacao TIMESTAMP, 
                        DataDesativacao TIMESTAMP
                    )");

                // Create a Colaborador table
                _dbConnection.Execute(@"
                    CREATE TABLE IF NOT EXISTS Colaborador (
                        ID SERIAL NOT NULL PRIMARY KEY,
                        Nome VARCHAR(128) NOT NULL,
                        Login VARCHAR(500) NOT NULL,
                        Status INTEGER NOT NULL,
                        FuncaoID INTEGER NOT NULL,
                        DataCriacao TIMESTAMP, 
                        DataAtivacao TIMESTAMP, 
                        DataDesativacao TIMESTAMP
                    )");

                _dbConnection.Close();
            }

        }
    }
}