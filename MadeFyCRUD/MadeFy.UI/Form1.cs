using MadeFy.Application.Interfaces;
using MadeFy.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadeFy.UI
{
    public partial class MainForm : Form
    {
        private readonly ICategoriaService _categoriaService;
        private readonly IProdutoService _produtoService;

        public MainForm()
        {
            InitializeComponent();

            var dbContext = new DatabaseContext();
            var categoriaRepository = new CategoriaRepository(dbContext);
            var produtoRepository = new ProdutoRepository(dbContext);

            _categoriaService = new CategoriaService(categoriaRepository, produtoRepository);
            _produtoService = new ProdutoService(produtoRepository);
        }
    }
}
