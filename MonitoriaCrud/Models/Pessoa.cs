using System;
using System.ComponentModel.DataAnnotations;

namespace MonitoriaCrud.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Endereço { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        [StringLength(11)]
        public string CPF { get; set; }
        public DateTime Nascimento { get; set; }

    }
}
