using Core.Entity;
using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serviços
{
    public class TipoDeExameServico : IGenericoServico<TipoDeExame>
    {
        private readonly IGenericoRepository<TipoDeExame> _context;

        public TipoDeExameServico(IGenericoRepository<TipoDeExame> tipoDeExameServico)
        {
            _context = tipoDeExameServico;
        }
        public void Atualizar(int id, TipoDeExame model)
        {
            if (id > 0 && model != null)
            {

                _context.Atualizar(id, model);
            }
        }

        public TipoDeExame Cadastro(TipoDeExame model)
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

        public List<TipoDeExame> ObterTodos()
        {
            return _context.ObterTodos();
        }

        public TipoDeExame ObterUm(int id)
        {
            if (id > 0)
            {
                return _context.ObterUm(id);
            }
            return null;
        }
    }
}
