using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class PacienteViewModel
    {
        public int Id { get;  set; }
        public string Nome { get;  set; }
        public string CPF { get;  set; }
        public DateTime DataNascimento { get;  set; }
        public string Telefone { get;  set; }
        public string Email { get;  set; }
        public string Sexo { get; set; }

        public PacienteViewModel(int id, string nome, string cPF, DateTime dataNascimento, string telefone, string email, string sexo)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
        }
    }
}
