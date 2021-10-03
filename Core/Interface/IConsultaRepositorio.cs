using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interface
{
    public interface IConsultaRepositorio : IGenericoRepository<Consulta>
    {
        public Consulta ObterMarcacaoPorData(DateTime dataDeConsulta);




    }
}
