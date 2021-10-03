using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Serviços.Interface
{
    public interface IConsultaServico : IGenericoServico<Consulta>
    {

        public Consulta ObterMarcacaoPorData(DateTime dataDeConsulta);
    }
}
