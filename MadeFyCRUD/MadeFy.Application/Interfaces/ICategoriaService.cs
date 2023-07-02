using MadeFy.Domain.Entities;
using System.Collections.Generic;

namespace MadeFy.Application.Interfaces
{
    public interface ICategoriaService
    {
        IEnumerable<Categoria> GetAll();
        Categoria GetByID(int categoriaID);
        void Add(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(int categoriaID, bool excluirProdutosRelacionados);
    }
}
