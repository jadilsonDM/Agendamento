using Application.Serviços.Interface;
using Core.Entity;
using Core.Interface;
using System.Collections.Generic;

namespace Application.Serviços.Implmentacao
{
    public class ExameServico : IGenericoServico<Exame>
    {



        private readonly IGenericoRepository<Exame> _context;

        public ExameServico(IGenericoRepository<Exame> exameServico)
        {
            _context = exameServico;
        }
        public void Atualizar(int id, Exame model)
        {
            if (id > 0 && model != null)
            {

                _context.Atualizar(id, model);
            }
        }

        public Exame Cadastro(Exame model)
        {
            if (model != null)
            {
                return _context.Cadastro(model);
            }
            return null;
        }

        public void Deletar(int id)
        {
            if (id > 0)
            {
                _context.Deletar(id);
            }
        }

        public List<Exame> ObterTodos()
        {
            return _context.ObterTodos();
        }

        public Exame ObterUm(int id)
        {
            if (id > 0)
            {
                return _context.ObterUm(id);
            }
            return null;
        }
    }
}
