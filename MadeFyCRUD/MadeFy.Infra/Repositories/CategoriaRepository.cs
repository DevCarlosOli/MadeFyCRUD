using MadeFy.Entities.Entities;
using MadeFy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MadeFy.Services.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly string connectionString = "";

        public List<Categoria> GetAll()
        {
            List<Categoria> categorias = new List<Categoria>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Categoria", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = (int)reader["ID"],
                        Nome = (string)reader["Nome"],
                        DataCadastro = (DateTime)reader["DataCadastro"],
                        DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                    };
                    categorias.Add(categoria);
                }
            }

            return categorias;
        }

        public Categoria GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Categoria WHERE ID = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    Categoria categoria = new Categoria
                    {
                        Id = (int)reader["ID"],
                        Nome = (string)reader["Nome"],
                        DataCadastro = (DateTime)reader["DataCadastro"],
                        DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                    };

                    return categoria;
                }
            }

            return null;
        }
        public void Add(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"INSERT INTO Categoria (Nome, DataCadastro, DataAtualizacao) 
                                                                     VALUES (@nome, @dataCadastro, @dataAtualizacao)", connection);

                command.Parameters.AddWithValue("@nome", categoria.Nome);
                command.Parameters.AddWithValue("@dataCadastro", categoria.DataCadastro);
                command.Parameters.AddWithValue("@dataAtualizacao", categoria.DataAtualizacao);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Categoria categoria)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"UPDATE Categoria SET Nome = @nome, DataAtualizacao = @dataAtualizacao 
                                                       WHERE ID = @id", connection);
                command.Parameters.AddWithValue("@nome", categoria.Nome);
                command.Parameters.AddWithValue("@dataAtualizacao", categoria.DataAtualizacao);
                command.Parameters.AddWithValue("@id", categoria.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"DELETE FROM Categoria 
                                                            WHERE ID = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
