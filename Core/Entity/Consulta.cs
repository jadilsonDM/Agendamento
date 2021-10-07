using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Consulta
    {

        public int Id { get; private set; }
        public DateTime DataDaConsulta { get; private set; }
        public Paciente Paciente { get; private set; }
        public Exame Exame { get; private set; }
        public TipoDeExame TipoDeExame { get; private set; }
        public string Protocolo { get; set; }
        protected Consulta()
        {

        }

        public Consulta(int id, DateTime dataDaConsulta, Paciente paciente, Exame exame, TipoDeExame tipoDeExame)
        {
            Id = id;
            DataDaConsulta = dataDaConsulta;
            Paciente = paciente;
            Exame = exame;
            TipoDeExame = tipoDeExame;
        }
    }
}
