using MadeFy.Entities.Entities;
using MadeFy.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MadeFy.Services.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly string connectionString = "";

        public List<Produto> GetAll()
        {
            List<Produto> produtos = new List<Produto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Produto", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Produto produto = new Produto
                    {
                        Id = (int)reader["ID"],
                        Nome = (string)reader["Nome"],
                        Descricao = (string)reader["Descricao"],
                        Preco = (decimal)reader["Preco"],
                        Quantidade = (int)reader["Quantidade"],
                        Categoria = new Categoria(),
                        DataCadastro = (DateTime)reader["DataCadastro"],
                        DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                    };
                    produtos.Add(produto);
                }
            }
            return produtos;
        }

        public Produto GetById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Produto WHERE ID = @id", connection);
                command.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    Produto produto = new Produto
                    {
                        Id = (int)reader["ID"],
                        Nome = (string)reader["Nome"],
                        Descricao = (string)reader["Descricao"],
                        Preco = (decimal)reader["Preco"],
                        Quantidade = (int)reader["Quantidade"],
                        Categoria = new Categoria(),
                        DataCadastro = (DateTime)reader["DataCadastro"],
                        DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                    };

                    return produto;
                }

                return null;
            }
        }

        public void Add(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"INSERT INTO Produto (Nome, Descricao, Preco, Quantidade, DataCadastro, DataAtualizacao) 
                                                                   VALUES (@nome, @descricao, @preco, @quantidade, @dataCadastro, @dataAtualizacao)", connection);

                command.Parameters.AddWithValue("@nome", produto.Nome);
                command.Parameters.AddWithValue("@descricao", produto.Descricao);
                command.Parameters.AddWithValue("@preco", produto.Preco);
                command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@dataCadastro", produto.DataCadastro);
                command.Parameters.AddWithValue("@dataAtualizacao", produto.DataAtualizacao);
                command.ExecuteNonQuery();
            }
        }

        public void Update(Produto produto)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"UPDATE Produto SET Nome = @nome, Descricao = @descricao, Preco = @preco, Quantidade = @quantidade, DataAtualizacao = @dataAtualizacao 
                                                       WHERE ID = @id", connection);

                command.Parameters.AddWithValue("@nome", produto.Nome);
                command.Parameters.AddWithValue("@descricao", produto.Descricao);
                command.Parameters.AddWithValue("@preco", produto.Preco);
                command.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@dataAtualizacao", produto.DataAtualizacao);
                command.Parameters.AddWithValue("@id", produto.Id);
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(@"DELETE FROM Produto 
                                                            WHERE ID = @id", connection);

                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }
    }
}
