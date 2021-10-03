using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entity;

namespace Core.Interface
{
    public interface IPacienteRepositorio : IGenericoRepository<Paciente>
    {
        public Paciente ObterPorCPF(string CPF);
        
    }
}
