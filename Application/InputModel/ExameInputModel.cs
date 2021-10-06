using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class ExameInputModel
    {

        public int Id { get; set; }
        public string NomeDoExame { get; set; }
        public string Observacao { get; set; }
        public int IdTipoExame { get; set; }
        public TipoDeExame TipoDeExame { get; set; }

       
    }
}
