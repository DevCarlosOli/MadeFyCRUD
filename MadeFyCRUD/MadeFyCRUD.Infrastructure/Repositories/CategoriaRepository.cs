using MadeFyCRUD.Domain.Models;
using MadeFyCRUD.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace MadeFyCRUD.Infrastructure.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly SqlConnection _connection;

        public CategoriaRepository()
        {
            _connection = ConnectionFactory.CreateConnection();
        }

        public List<Categoria> GetAll()
        {
            var categorias = new List<Categoria>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT ID, Nome, DataCadastro, DataAtualizacao FROM Categoria";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categorias.Add(new Categoria
                        {
                            ID = (int)reader["ID"],
                            Nome = (string)reader["Nome"],
                            DataCadastro = (DateTime)reader["DataCadastro"],
                            DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                        });
                    }
                }
            }

            return categorias;
        }

        public Categoria GetById(int id)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT ID, Nome, DataCadastro, DataAtualizacao FROM Categoria WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Categoria
                        {
                            ID = (int)reader["ID"],
                            Nome = (string)reader["Nome"],
                            DataCadastro = (DateTime)reader["DataCadastro"],
                            DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                        };
                    }

                    return null;
                }
            }
        }

        public void Add(Categoria categoria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Categoria (Nome, DataCadastro, DataAtualizacao) " +
                                      "VALUES (@Nome, @DataCadastro, @DataAtualizacao)";

                command.Parameters.AddWithValue("@Nome", categoria.Nome);
                command.Parameters.AddWithValue("@DataCadastro", DateTime.Now);
                command.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Categoria categoria)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = @"UPDATE Categoria
                                        SET Nome = @Nome, DataAtualizacao = @DataAtualizacao 
                                        WHERE ID = @ID";

                command.Parameters.AddWithValue("@Nome", categoria.Nome);
                command.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                command.Parameters.AddWithValue("@ID", categoria.ID);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Categoria WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
