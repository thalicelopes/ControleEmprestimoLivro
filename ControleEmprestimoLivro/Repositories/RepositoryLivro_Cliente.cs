using ControleEmprestimoLivro.Interfaces;
using ControleEmprestimoLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Repositories
{
    public class RepositoryLivro_Cliente : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro_Cliente(bool saveChanges = true) : base(saveChanges)
        {

        }

    }
}
