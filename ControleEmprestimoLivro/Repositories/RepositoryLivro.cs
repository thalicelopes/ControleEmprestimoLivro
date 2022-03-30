using ControleEmprestimoLivro.Interfaces;
using ControleEmprestimoLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
