namespace Immobile.MapaDeErros.Repositories
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using Dapper;
    using Immobile.MapaDeErros.Models;
    using Microsoft.Extensions.Configuration;
    using Npgsql;
    public class FuncaoRepository : BaseRepository<Funcao>
    {
        public FuncaoRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public override void Add(Funcao item)
        {
            using (IDbConnection dbConnection = new NpgsqlConnection(ConnectionString))
            {
                string sQuery = "INSERT INTO Funcao (Nome, Status, DataCriacao, DataAtivacao, DataDesativacao)" 
                    + " VALUES(@Nome, @Status, @DataCriacao, @DataAtivacao, @DataDesativacao)";
                dbConnection.Open();
                dbConnection.Execute(sQuery, item);                
            }
        }

        public override IEnumerable<Funcao> FindAll()
        {
            using (IDbConnection dbConnection = new NpgsqlConnection(ConnectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Funcao>("SELECT * FROM Funcao");
            }
        }

        public override Funcao FindByID(int id)
        {
            using (IDbConnection dbConnection = new NpgsqlConnection(ConnectionString))
            {
                string sQuery = "SELECT * FROM Funcao"
                            + " WHERE Id = @Id";
                dbConnection.Open();
                return dbConnection.Query<Funcao>(sQuery, new { Id = id }).FirstOrDefault();
            }
        }

        public override bool Remove(int id)
        {
            using (IDbConnection dbConnection = new NpgsqlConnection(ConnectionString))
            {          
                string sQuery = "DELETE FROM Funcao"
                            + " WHERE Id = @Id";
                dbConnection.Open();
                return dbConnection.Execute(sQuery, new { Id = id }) > 0;
            }
        }

        public override void Update(Funcao item)
        {
            using (IDbConnection dbConnection = new NpgsqlConnection(ConnectionString))
            {
                string sQuery = "UPDATE Funcao SET" 
                            + " Nome = @Nome,"
                            + " Status = @Status," 
                            + " DataAtivacao= @DataAtivacao"
                            + " DataEncerramento= @DataEncerramento"
                            + " WHERE Id = @Id";
                dbConnection.Open();
                dbConnection.Query(sQuery, item);
            }
        }
    }
}