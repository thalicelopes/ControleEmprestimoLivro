using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Models
{
    public class Livro_Cliente
    {
        [Key]
        public int Id { get; set; }
        public int IdLivro { get; set; }
        public int IdCliente { get; set; }
        public DateTime DataEmprestimo { get; set; }
        public DateTime DataDevolucao { get; set; }
        [ForeignKey(nameof(IdLivro))]
        public virtual Livro Livro { get; set; }
        [ForeignKey(nameof(IdCliente))]
        public virtual Cliente Cliente { get; set; }
    }
}
