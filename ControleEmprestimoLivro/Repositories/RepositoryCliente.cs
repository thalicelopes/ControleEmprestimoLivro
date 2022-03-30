using ControleEmprestimoLivro.Interfaces;
using ControleEmprestimoLivro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool saveChanges = true) : base(saveChanges)
        {

        }
    }
}
