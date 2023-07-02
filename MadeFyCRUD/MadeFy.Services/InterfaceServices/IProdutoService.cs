using MadeFy.Entities.Entities;
using System.Collections.Generic;

namespace MadeFy.Services.InterfaceServices
{
    public interface IProdutoService
    {
        List<Produto> GetAll();
        Produto GetById(int id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int id);
    }
}
