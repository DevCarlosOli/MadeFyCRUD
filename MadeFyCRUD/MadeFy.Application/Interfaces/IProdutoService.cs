using MadeFy.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadeFy.Application.Interfaces
{
    public interface IProdutoService
    {
        IEnumerable<Produto> GetAll();
        Produto GetByID(int produtoID);
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(int produtoID);
    }
}
