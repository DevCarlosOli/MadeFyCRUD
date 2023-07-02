using MadeFy.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace MadeFy.Infrastructure.Repositories
{
    public class ProdutoRepository
    {

        private readonly DatabaseContext _context;

        public ProdutoRepository(DatabaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Produto> GetAll()
        {
            return _context.Produtos.ToList();
        }

        public Produto GetByID(int produtoID)
        {
            return _context.Produtos.FirstOrDefault(p => p.ID == produtoID);
        }

        public void Add(Produto produto)
        {
            _context.Produtos.Add(produto);
            _context.SaveChanges();
        }

        public void Update(Produto produto)
        {
            _context.Entry(produto).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int produtoID)
        {
            var produto = _context.Produtos.Find(produtoID);
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}
