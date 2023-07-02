using MadeFyCRUD.Domain.Models;
using MadeFyCRUD.Infrastructure.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;

namespace MadeFyCRUD.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly SqlConnection _connection;

        public ProdutoRepository()
        {
            _connection = ConnectionFactory.CreateConnection();
        }

        public List<Produto> GetAll()
        {
            var produtos = new List<Produto>();

            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT P.ID, P.Nome, P.Descricao, P.Preco, P.Quantidade, P.CategoriaID, P.DataCadastro, P.DataAtualizacao, " +
                                      "C.ID AS CategoriaID, C.Nome AS CategoriaNome, C.DataCadastro AS CategoriaDataCadastro, C.DataAtualizacao AS CategoriaDataAtualizacao " +
                                      "FROM Produto P " +
                                      "INNER JOIN Categoria C ON P.CategoriaID = C.ID";

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var categoria = new Categoria
                        {
                            ID = (int)reader["CategoriaID"],
                            Nome = (string)reader["CategoriaNome"],
                            DataCadastro = (DateTime)reader["CategoriaDataCadastro"],
                            DataAtualizacao = (DateTime)reader["CategoriaDataAtualizacao"]
                        };

                        produtos.Add(new Produto
                        {
                            ID = (int)reader["ID"],
                            Nome = (string)reader["Nome"],
                            Descricao = (string)reader["Descricao"],
                            Preco = (decimal)reader["Preco"],
                            Quantidade = (int)reader["Quantidade"],
                            Categoria = categoria,
                            DataCadastro = (DateTime)reader["DataCadastro"],
                            DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                        });
                    }
                }
            }

            return produtos;
        }

        public Produto GetById(int id)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "SELECT P.ID, P.Nome, P.Descricao, P.Preco, P.Quantidade, P.CategoriaID, P.DataCadastro, P.DataAtualizacao, " +
                                      "C.ID AS CategoriaID, C.Nome AS CategoriaNome, C.DataCadastro AS CategoriaDataCadastro, C.DataAtualizacao AS CategoriaDataAtualizacao " +
                                      "FROM Produto P " +
                                      "INNER JOIN Categoria C ON P.CategoriaID = C.ID " +
                                      "WHERE P.ID = @ID";

                command.Parameters.AddWithValue("@ID", id);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        var categoria = new Categoria
                        {
                            ID = (int)reader["CategoriaID"],
                            Nome = (string)reader["CategoriaNome"],
                            DataCadastro = (DateTime)reader["CategoriaDataCadastro"],
                            DataAtualizacao = (DateTime)reader["CategoriaDataAtualizacao"]
                        };

                        return new Produto
                        {
                            ID = (int)reader["ID"],
                            Nome = (string)reader["Nome"],
                            Descricao = (string)reader["Descricao"],
                            Preco = (decimal)reader["Preco"],
                            Quantidade = (int)reader["Quantidade"],
                            Categoria = categoria,
                            DataCadastro = (DateTime)reader["DataCadastro"],
                            DataAtualizacao = (DateTime)reader["DataAtualizacao"]
                        };
                    }

                    return null;
                }
            }
        }

        public void Add(Produto produto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO Produto (Nome, Descricao, Preco, Quantidade, CategoriaID, DataCadastro, DataAtualizacao) " +
                                      "VALUES (@Nome, @Descricao, @Preco, @Quantidade, @CategoriaID, @DataCadastro, @DataAtualizacao)";

                command.Parameters.AddWithValue("@Nome", produto.Nome);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.Parameters.AddWithValue("@Preco", produto.Preco);
                command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@CategoriaID", produto.Categoria.ID);
                command.Parameters.AddWithValue("@DataCadastro", DateTime.Now);
                command.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);

                command.ExecuteNonQuery();
            }
        }

        public void Update(Produto produto)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "UPDATE Produto " +
                                      "SET Nome = @Nome, Descricao = @Descricao, Preco = @Preco, Quantidade = @Quantidade, " +
                                      "CategoriaID = @CategoriaID, DataAtualizacao = @DataAtualizacao " +
                                      "WHERE ID = @ID";

                command.Parameters.AddWithValue("@Nome", produto.Nome);
                command.Parameters.AddWithValue("@Descricao", produto.Descricao);
                command.Parameters.AddWithValue("@Preco", produto.Preco);
                command.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                command.Parameters.AddWithValue("@CategoriaID", produto.Categoria.ID);
                command.Parameters.AddWithValue("@DataAtualizacao", DateTime.Now);
                command.Parameters.AddWithValue("@ID", produto.ID);

                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var command = _connection.CreateCommand())
            {
                command.CommandText = "DELETE FROM Produto WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);

                command.ExecuteNonQuery();
            }
        }
    }
}
