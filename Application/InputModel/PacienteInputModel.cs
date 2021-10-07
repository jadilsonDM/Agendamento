using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class PacienteInputModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome")]
        [MaxLength(100, ErrorMessage = "Informe o nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Informe o CPF")]
        [MaxLength(11,ErrorMessage = "Cpf deve ter apenas 11 caracteres. Sem pontos e traços")]
        public string CPF { get; set; }
        [Required(ErrorMessage = "Informe o Data de nascimento")]
        public DateTime DataNscimento { get; set; }
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Informe o Sexo")]
        public string Sexo { get; set; }
        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage = "Informe o Email válido")]
        public string Email { get; set; }
    }
}
