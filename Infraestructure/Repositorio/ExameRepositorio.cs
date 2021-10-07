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
    public class ExameRepositorio : IGenericoRepository<Exame>
    {
        private readonly AgendamentoDbContext _context;

        public ExameRepositorio(AgendamentoDbContext agendamentoDbContext)
        {
            _context = agendamentoDbContext;
        }

       
        public Exame Cadastro(Exame model)
        {
            _context.Exames.Add(model);
            _context.SaveChanges();
            return model;
        }

        public void Atualizar(int id, Exame model)
        {
            var exame = ObterUm(id);
            if (exame != null)
            {
                exame.Atualizar(model.NomeDoExame, model.Observacao, model.IdTipoExame);
                _context.SaveChanges();
            }
        }

        public void Deletar(int id)
        {
            var exame = ObterUm(id);
            if (exame != null)
            {
                _context.Exames.Remove(exame);
                _context.SaveChanges();
            }
        }

        public List<Exame> ObterTodos()
        {
            return _context.Exames.ToList();
        }

        public Exame ObterUm(int id)
        {
            return _context.Exames.SingleOrDefault(e => e.Id == id);
        }
    }
}
