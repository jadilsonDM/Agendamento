using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class PacienteInputModel
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNscimento { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Sexo { get; set; }
    }
}
