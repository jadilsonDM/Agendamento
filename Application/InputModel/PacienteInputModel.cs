using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class PacienteInputModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNscimento { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
    }
}
