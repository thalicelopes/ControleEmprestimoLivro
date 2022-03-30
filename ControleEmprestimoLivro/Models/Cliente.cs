using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControleEmprestimoLivro.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o CPF do cliente. ")]
        [StringLength(14)]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe o nome do cliente. ")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o endereço do cliente. ")]
        public string Endereco { get; set; }
        [Required(ErrorMessage = "Informe a cidade do cliente. ")]
        public string Cidade { get; set; }
        [Required(ErrorMessage = "Informe o bairro do cliente. ")]
        public string Bairro { get; set; }
        [Required(ErrorMessage = "Informe o telefone do cliente. ")]
        public string Telefone { get; set; }
        public virtual ICollection<Livro_Cliente> LivroCliente { get; set; }
    }
}
