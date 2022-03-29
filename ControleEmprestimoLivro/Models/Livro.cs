using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Models
{
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o título do livro.  ")]
        public string NomeLivro { get; set; }
        [Required(ErrorMessage = "Informe o autor do livro. ")]
        public string Autor { get; set; }
        [Required(ErrorMessage = "Informe a editora responsável pelo livro. ")]
        public string Editora { get; set; }
        public virtual ICollection<Livro_Cliente> LivroCliente { get; set; }
    }
}
