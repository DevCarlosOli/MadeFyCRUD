using MadeFy.Entities.Entities;
using System.Collections.Generic;

namespace MadeFy.Services.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> GetAll();
        Produto GetById(int id);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int id);
    }
}
