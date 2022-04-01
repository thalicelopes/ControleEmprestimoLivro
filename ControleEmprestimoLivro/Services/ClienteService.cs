using ControleEmprestimoLivro.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; } = new RepositoryCliente();
    }
}
