using Application.Serviços.Interface;
using Core.Entity;
using Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serviços.Implmentacao
{
    public class ConsultaServico : IConsultaServico
    {

        private readonly IConsultaRepositorio _context;

        public ConsultaServico(IConsultaRepositorio consultaRepositorio)
        {
            _context = consultaRepositorio;
        }


        public void Atualizar(int id, Consulta model)
        {
            if (id > 0 && model != null)
            {
                _context.Atualizar(id, model);
            }
        }

        public Consulta Cadastro(Consulta model)
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

        public Consulta ObterMarcacaoPorData(DateTime dataDeConsulta)
        {
            if (dataDeConsulta > DateTime.Now)
            {
                return _context.ObterMarcacaoPorData(dataDeConsulta);
            }
            return null;
        }

        public List<Consulta> ObterTodos()
        {
            return _context.ObterTodos();
        }

        public Consulta ObterUm(int id)
        {
            if(id > 0)
            {
                return _context.ObterUm(id);
            }
            return null;
        }
    }
}
