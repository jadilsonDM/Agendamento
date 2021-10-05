using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class TipoDeExameInputModel
    {

        public int Id { get; set; }
        public string NomeDoTipo { get; set; }
        public string Descricao { get; set; }
        public List<Exame> Exames { get; set; }
        

    }
}
