using Application.Serviços.Interface;
using Core.Entity;
using Core.Interface;
using System.Collections.Generic;

namespace Application.Serviços.Implmentacao
{
    public class PacienteServico : IPacienteServico
    {

        private readonly IPacienteRepositorio _context;

        public PacienteServico(IPacienteRepositorio pacienteRepositorio)
        {
            _context = pacienteRepositorio;
        }
        public void Atualizar(int id, Paciente model)
        {
            if (id > 0 && model != null)
            {
                _context.Atualizar(id, model);
            }

        }

        public Paciente Cadastro(Paciente model)
        {
            if (model != null)
            {
               return _context.Cadastro(model);
            }

            return null;
        }

        public void Deletar(int id)
        {
            if(id > 0)
            {
                _context.Deletar(id);
            }
        }

        public Paciente ObterPorCPF(string CPF)
        {
            if (CPF != null)
            {
              return _context.ObterPorCPF(CPF);
            }
            return null;
        }

        public List<Paciente> ObterTodos()
        {
           return _context.ObterTodos();            
        }

        public Paciente ObterUm(int id)
        {
            if(id > 0)
            {
                return _context.ObterUm(id);
            }
            return null;
        }
    }
}
