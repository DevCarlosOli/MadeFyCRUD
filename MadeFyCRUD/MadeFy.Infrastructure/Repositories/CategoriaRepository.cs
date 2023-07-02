using MadeFy.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MadeFy.Infrastructure.Repositories
{
    public class CategoriaRepository
    {

        private readonly DatabaseContext _context;

        public CategoriaRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> GetAll()
        {
            return _context.Categorias.ToList();
        }

        public Categoria GetByID(int categoriaID)
        {
            return _context.Categorias.FirstOrDefault(c => c.ID == categoriaID);
        }

        public void Add(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            _context.SaveChanges();
        }

        public void Update(Categoria categoria)
        {
            _context.Entry(categoria).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int categoriaID)
        {
            var categoria = _context.Categorias.Find(categoriaID);
            _context.Categorias.Remove(categoria);
            _context.SaveChanges();
        }
    }
}
