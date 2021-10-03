using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agendamento.Models
{
    public class PacienteModel
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNscimento { get; private set; }
        public string Telefone { get; private set; }
        public string Sexo { get; set; }
        public string Email { get; private set; }
    }
}
