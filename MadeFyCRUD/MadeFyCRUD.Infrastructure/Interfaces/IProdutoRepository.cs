using MadeFyCRUD.Domain.Models;
using System.Collections.Generic;

namespace MadeFyCRUD.Infrastructure.Interfaces
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
