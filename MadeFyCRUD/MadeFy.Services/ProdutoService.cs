using MadeFy.Entities.Entities;
using MadeFy.Services.Interfaces;
using MadeFy.Services.InterfaceServices;
using MadeFy.Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadeFy.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public List<Produto> GetAll()
        {
            return _produtoRepository.GetAll();
        }

        public Produto GetById(int id)
        {
            return _produtoRepository.GetById(id);
        }

        public void Add(Produto produto)
        {
            produto.DataCadastro = DateTime.Now;
            produto.DataAtualizacao = DateTime.Now;
            _produtoRepository.Add(produto);
        }

        public void Update(Produto produto)
        {
            produto.DataAtualizacao = DateTime.Now;
            _produtoRepository.Update(produto);
        }

        public void Delete(int id)
        {
            Console.WriteLine("Deseja excluir o produto? (S/N)");
            string resposta = Console.ReadLine();

            if (resposta.ToUpper() == "S")
            {
                _produtoRepository.Delete(id);
            }
        }
    }
}
