using Core.Entity;
using Core.Interface;
using Infraestructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infraestructure.Repositorio
{
    public class PacienteRepositorio : IPacienteRepositorio
    {
        private readonly AgendamentoDbContext _context;

        public PacienteRepositorio(AgendamentoDbContext agendamentoDbContext)
        {
            _context = agendamentoDbContext;
        }
        public Paciente Cadastro(Paciente model)
        {
            _context.Pacientes.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void Atualizar(int id, Paciente model)
        {
            var paciente = ObterUm(id);
            if (paciente != null)
            {
                paciente.Atualizar(model.Nome, model.CPF, model.DataNascimento, model.Telefone, model.Email);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var paciente = ObterUm(id);
            if (paciente != null)
            {
                _context.Pacientes.Remove(paciente);
                _context.SaveChanges();
            }
        }

        public List<Paciente> ObterTodos()
        {
            return _context.Pacientes.ToList();
        }

        public Paciente ObterUm(int id)
        {
           return _context.Pacientes.SingleOrDefault(p => p.Id == id);
        }

        public Paciente ObterPorCPF(string CPF)
        {
            return _context.Pacientes.SingleOrDefault(p => p.CPF == CPF);
        }
    }
}
