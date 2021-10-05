using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    public class Paciente
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public DateTime DataNscimento { get; private set; }
        public string Telefone { get; private set; }
        [NotMapped]
        public string Sexo { get; set; }
        public string Email { get; private set; }
        public Paciente(int id, string nome, string cPF, DateTime dataNscimento, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            CPF = cPF;
            DataNscimento = dataNscimento;
            Telefone = telefone;
            Email = email;
        }

        public void Atualizar(string nome, string cPF, DateTime dataNscimento, string telefone, string email)
        {

            Nome = nome;
            CPF = cPF;
            DataNscimento = dataNscimento;
            Telefone = telefone;
            Email = email;

        }


    }
}
