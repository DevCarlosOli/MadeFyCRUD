using MadeFyCRUD.Domain.Models;
using MadeFyCRUD.Infrastructure.Interfaces;
using MadeFyCRUD.Infrastructure.Repositories;
using System;
using System.Linq;

namespace MadeFyCRUD.UI
{
    public class Program
    {
        private static readonly ICategoriaRepository CategoriaRepository = new CategoriaRepository();
        private static readonly IProdutoRepository ProdutoRepository = new ProdutoRepository();

        static void Main(string[] args)
        {
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1 - Listar Categorias");
            Console.WriteLine("2 - Listar Produtos");
            Console.WriteLine("3 - Cadastrar Categoria");
            Console.WriteLine("4 - Cadastrar Produto");
            Console.WriteLine("5 - Atualizar Categoria");
            Console.WriteLine("6 - Atualizar Produto");
            Console.WriteLine("7 - Excluir Categoria");
            Console.WriteLine("8 - Excluir Produto");
            Console.WriteLine("9 - Sair");

            var opcao = Console.ReadLine();

            while (opcao != "9")
            {
                switch (opcao)
                {
                    case "1":
                        ListarCategorias();
                        break;
                    case "2":
                        ListarProdutos();
                        break;
                    case "3":
                        CadastrarCategoria();
                        break;
                    case "4":
                        CadastrarProduto();
                        break;
                    case "5":
                        AtualizarCategoria();
                        break;
                    case "6":
                        AtualizarProduto();
                        break;
                    case "7":
                        ExcluirCategoria();
                        break;
                    case "8":
                        ExcluirProduto();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Listar Categorias");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Cadastrar Categoria");
                Console.WriteLine("4 - Cadastrar Produto");
                Console.WriteLine("5 - Atualizar Categoria");
                Console.WriteLine("6 - Atualizar Produto");
                Console.WriteLine("7 - Excluir Categoria");
                Console.WriteLine("8 - Excluir Produto");
                Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();
            }
        }

        #region Categorias
        private static void ListarCategorias()
        {
            var categorias = CategoriaRepository.GetAll();

            Console.WriteLine("Lista de Categorias:");
            Console.WriteLine("--------------------");
            foreach (var categoria in categorias)
            {
                Console.WriteLine($"ID: {categoria.ID}");
                Console.WriteLine($"Nome: {categoria.Nome}");
                Console.WriteLine($"Data de Cadastro: {categoria.DataCadastro}");
                Console.WriteLine($"Data de Atualização: {categoria.DataAtualizacao}");
                Console.WriteLine("--------------------");
            }
        }

        private static void CadastrarCategoria()
        {
            Console.WriteLine("Digite o nome da categoria:");
            var nome = Console.ReadLine();

            var categoria = new Categoria
            {
                Nome = nome,
                DataCadastro = DateTime.Now,
                DataAtualizacao = DateTime.Now
            };

            CategoriaRepository.Add(categoria);
            Console.WriteLine("Categoria cadastrada com sucesso!");
        }

        private static void AtualizarCategoria()
        {
            Console.WriteLine("Digite o ID da categoria a ser atualizada:");
            var categoriaId = int.Parse(Console.ReadLine());

            var categoria = CategoriaRepository.GetById(categoriaId);

            if (categoria == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            Console.WriteLine("Digite o novo nome da categoria:");
            var nome = Console.ReadLine();

            categoria.Nome = nome;
            categoria.DataAtualizacao = DateTime.Now;

            CategoriaRepository.Update(categoria);
            Console.WriteLine("Categoria atualizada com sucesso!");
        }

        private static void ExcluirCategoria()
        {
            Console.WriteLine("Digite o ID da categoria da Categoria:");
            int categoriaId = Convert.ToInt32(Console.ReadLine());
            Categoria selectedCategoria = CategoriaRepository.GetById(categoriaId);

            if (selectedCategoria == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }            

            Console.WriteLine($"Tem certeza que deseja excluir a categoria '{selectedCategoria.Nome}'?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            string option = Console.ReadLine();

            if (option == "1")
            {
                var produtosRelacionados = ProdutoRepository.GetAll().Where(p => p.Categoria.ID == selectedCategoria.ID);
                if (produtosRelacionados.Any())
                {
                    Console.WriteLine("Existem produtos relacionados à categoria. Deseja excluir os produtos também? (S/N)");
                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "S")
                    {
                        foreach (var produto in produtosRelacionados)
                        {
                            ProdutoRepository.Delete(produto.ID);
                            Console.WriteLine("Produto excluído: " + produto.Nome);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Para deletar uma categoria é necessário deletar os produtos que tem vínculo com a mesma!");
                        return;
                    }
                }

                CategoriaRepository.Delete(categoriaId);
                Console.WriteLine("Categoria excluída com sucesso!");
            }
        }
        #endregion

        #region Produtos
        private static void ListarProdutos()
        {
            var produtos = ProdutoRepository.GetAll();

            Console.WriteLine("Lista de Produtos:");
            Console.WriteLine("------------------");
            foreach (var produto in produtos)
            {
                Console.WriteLine($"ID: {produto.ID}");
                Console.WriteLine($"Nome: {produto.Nome}");
                Console.WriteLine($"Descrição: {produto.Descricao}");
                Console.WriteLine($"Preço: {produto.Preco}");
                Console.WriteLine($"Quantidade: {produto.Quantidade}");
                Console.WriteLine($"Categoria: {produto.Categoria.Nome}");
                Console.WriteLine($"Data de Cadastro: {produto.DataCadastro}");
                Console.WriteLine($"Data de Atualização: {produto.DataAtualizacao}");
                Console.WriteLine("------------------");
            }
        }

        private static void CadastrarProduto()
        {
            Console.WriteLine("Digite o nome do produto:");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite a descrição do produto:");
            var descricao = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto:");
            var preco = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade do produto:");
            var quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o ID da categoria do produto:");
            var categoriaId = int.Parse(Console.ReadLine());

            var categoria = CategoriaRepository.GetById(categoriaId);

            if (categoria == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            var produto = new Produto
            {
                Nome = nome,
                Descricao = descricao,
                Preco = preco,
                Quantidade = quantidade,
                Categoria = categoria,
                DataCadastro = DateTime.Now,
                DataAtualizacao = DateTime.Now
            };

            ProdutoRepository.Add(produto);
            Console.WriteLine("Produto cadastrado com sucesso!");
        }

        private static void AtualizarProduto()
        {
            Console.WriteLine("Digite o ID do produto a ser atualizado:");
            var produtoId = int.Parse(Console.ReadLine());

            var produto = ProdutoRepository.GetById(produtoId);

            if (produto == null)
            {
                Console.WriteLine("Categoria não encontrada!");
                return;
            }

            Console.WriteLine("Qual dessas opções gostaria de atualizar:");
            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Descrição");
            Console.WriteLine("3 - Preço");
            Console.WriteLine("4 - Quantidade");
            Console.WriteLine("5 - Voltar");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Digite o nome do produto:");
                    var novoNome = Console.ReadLine();
                    produto.Nome = novoNome;
                    produto.DataAtualizacao = DateTime.Now;
                    break;
                case "2":
                    Console.WriteLine("Digite a descrição do produto:");
                    var novaDescricao = Console.ReadLine();
                    produto.Descricao = novaDescricao;
                    produto.DataAtualizacao = DateTime.Now;
                    break;
                case "3":
                    Console.WriteLine("Digite o preço do produto:");
                    var novoPreco = decimal.Parse(Console.ReadLine());
                    produto.Preco = novoPreco;
                    produto.DataAtualizacao = DateTime.Now;
                    break;
                case "4":
                    Console.WriteLine("Digite a quantidade do produto:");
                    var novaQuantidade = int.Parse(Console.ReadLine());
                    produto.Quantidade = novaQuantidade;
                    produto.DataAtualizacao = DateTime.Now;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            ProdutoRepository.Update(produto);
            Console.WriteLine("Produto atualizado com sucesso!");
        }

        private static void ExcluirProduto()
        {
            Console.WriteLine("Digite o ID do produto:");
            int produtoId = Convert.ToInt32(Console.ReadLine());
            Produto selectedproduto = ProdutoRepository.GetById(produtoId);

            if (selectedproduto == null)
            {
                Console.WriteLine("Produto não encontrado!");
                return;
            }

            Console.WriteLine($"Tem certeza que deseja excluir o produto '{selectedproduto.Nome}'?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            string option = Console.ReadLine();

            if (option == "1")
            {
                ProdutoRepository.Delete(produtoId);
                Console.WriteLine("Produto excluído com sucesso!");
            }
        }
        #endregion
    }
}
