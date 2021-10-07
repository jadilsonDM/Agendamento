using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class Paciente
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Telefone { get; private set; }
        public string Sexo { get; set; }
        public string Email { get; private set; }
        public Paciente(int id, string nome, string cPF, DateTime dataNascimento, string telefone, string email, string sexo)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;
            Sexo = sexo;
        }

        public void Atualizar(string nome, string cPF, DateTime dataNascimento, string telefone, string email)
        {

            Nome = nome;
            CPF = cPF;
            DataNascimento = dataNascimento;
            Telefone = telefone;
            Email = email;

        }


    }
}
