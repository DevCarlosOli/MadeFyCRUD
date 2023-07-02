using MadeFy.Entities.Entities;
using System.Collections.Generic;

namespace MadeFy.Services.Interfaces
{
    public interface ICategoriaRepository
    {
        List<Categoria> GetAll();
        Categoria GetById(int id);
        void Add(Categoria categoria);
        void Update(Categoria categoria);
        void Delete(int id);
    }
}
