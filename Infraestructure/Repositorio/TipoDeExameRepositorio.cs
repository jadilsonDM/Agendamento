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
    public class TipoDeExameRepositorio : IGenericoRepository<TipoDeExame>
    {

        private readonly AgendamentoDbContext _context;

        public TipoDeExameRepositorio(AgendamentoDbContext agendamentoDbContext)
        {
            _context = agendamentoDbContext;
        }




        public TipoDeExame Cadastro(TipoDeExame model)
        {
            _context.TipoDeExames.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void Atualizar(int id, TipoDeExame model)
        {
            var paciente = ObterUm(id);
            if (paciente != null)
            {
                paciente.Atualizar(model.NomeDoTipo, model.Descricao);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var tipoDeExame = ObterUm(id);
            if (tipoDeExame != null)
            {
                _context.TipoDeExames.Remove(tipoDeExame);
                _context.SaveChanges();
            }
        }

        public List<TipoDeExame> ObterTodos()
        {
            return _context.TipoDeExames.ToList();
        }

        public TipoDeExame ObterUm(int id)
        {
            return _context.TipoDeExames.SingleOrDefault(e => e.Id == id);
        }
    }
}
