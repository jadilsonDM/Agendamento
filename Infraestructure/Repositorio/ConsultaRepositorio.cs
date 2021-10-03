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
    public class ConsultaRepositorio : IConsultaRepositorio
    {

        private readonly AgendamentoDbContext _context;

        public ConsultaRepositorio(AgendamentoDbContext agendamentoDbContext)
        {
            _context = agendamentoDbContext;
        }       

        //TODO - Implementar busca de consulta por data
        public Consulta Cadastro(Consulta model)
        {
            _context.Consultas.Add(model);
            _context.SaveChanges();
            return model;
        }       
        public void Atualizar(int id, Consulta model)
        {
            var consulta = ObterUm(id);
            if (consulta != null)
            {
                _context.Consultas.Update(consulta);
                _context.SaveChanges();
            }
        }
        public void Deletar(int id)
        {
            var consulta = ObterUm(id);
            if (consulta != null)
            {
                _context.Consultas.Remove(consulta);
                _context.SaveChanges();
            }
        }
        public List<Consulta> ObterTodos()
        {
            return _context.Consultas.ToList();
        }

        public Consulta ObterUm(int id)
        {
            return _context.Consultas.SingleOrDefault(c => c.Id == id);
        }

        public Consulta ObterMarcacaoPorData( DateTime dataDeConsulta)
        {
            return _context.Consultas.SingleOrDefault(c => c.DataDaConsulta == dataDeConsulta);
        }

        
    }
}
