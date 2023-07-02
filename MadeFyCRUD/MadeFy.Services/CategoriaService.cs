using MadeFy.Entities.Entities;
using MadeFy.Services.Interfaces;
using MadeFy.Services.InterfaceServices;
using System;
using System.Collections.Generic;

namespace MadeFy.Services
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _categoriaRepository;
        private readonly IProdutoRepository _produtoRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository, IProdutoRepository produtoRepository)
        {
            _categoriaRepository = categoriaRepository;
            _produtoRepository = produtoRepository;
        }

        public List<Categoria> GetAll()
        {
            return _categoriaRepository.GetAll();
        }

        public Categoria GetById(int id)
        {
            return _categoriaRepository.GetById(id);
        }

        public void Add(Categoria categoria)
        {
            categoria.DataCadastro = DateTime.Now;
            categoria.DataAtualizacao = DateTime.Now;
            _categoriaRepository.Add(categoria);
        }

        public void Update(Categoria categoria)
        {
            categoria.DataAtualizacao = DateTime.Now;
            _categoriaRepository.Update(categoria);
        }

        public void Delete(int id)
        {
            List<Produto> produtos = _produtoRepository.GetAll();
            foreach (Produto produto in produtos)
            {
                if (produto.Categoria.Id == id)
                {
                    Console.WriteLine("Existem produtos relacionados a essa categoria. Deseja excluir os produtos também? (S/N)");
                    string resposta = Console.ReadLine();

                    if (resposta.ToUpper() == "S")
                        _produtoRepository.Delete(produto.Id);
                }
            }

            _categoriaRepository.Delete(id);
        }
    }
}
