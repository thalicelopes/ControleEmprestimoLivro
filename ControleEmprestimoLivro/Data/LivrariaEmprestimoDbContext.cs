using ControleEmprestimoLivro.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleEmprestimoLivro.Data
{
    public partial class LivrariaEmprestimoDbContext : DbContext
    {
        public LivrariaEmprestimoDbContext()
        {
        }
        public LivrariaEmprestimoDbContext(DbContextOptions<LivrariaEmprestimoDbContext> options)
            : base(options)
        { }

        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Livro_Cliente> Livro_Cliente { get; set; }
    }
}
