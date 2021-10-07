using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class ConsultaInputModel
    {
        public int Id { get; set; }
        public DateTime DataDaConsulta { get; set; }
        public Paciente Paciente { get; set; }
        public Exame Exame { get; set; }
        public TipoDeExame TipoDeExame { get; set; }



    }
}
