using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class TipoDeExameViewModel
    {

        public int Id { get; set; }
        public string NomeDoTipo { get; set; }
        public string Descricao { get; set; }
        public List<Exame> Exames { get; set; }

        public TipoDeExameViewModel(int id, string nomeDoTipo, string descricao, List<Exame> exames)
        {
            Id = id;
            NomeDoTipo = nomeDoTipo;
            Descricao = descricao;
            Exames = exames;
        }
    }
}
