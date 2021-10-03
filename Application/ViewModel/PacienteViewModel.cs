using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class PacienteViewModel
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Email { get; private set; }
        public string Sexo { get; set; }

        public PacienteViewModel(string nome, string cPF, DateTime dataNascimento, string telefone, string email, string sexo)
        {
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
        }
    }
}
