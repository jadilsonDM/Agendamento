using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModel
{
    public class ExameViewModel
    {
        public int Id { get; set; }
        public string NomeDoExame { get; set; }
        public string Observacao { get; set; }
        public int IdTipoExame { get; set; }
        public TipoDeExame TipoDeExame { get; set; }

        public ExameViewModel(int id, string nomeDoExame, string observacao, int idTipoExame, TipoDeExame tipoDeExame)
        {
            Id = id;
            NomeDoExame = nomeDoExame;
            Observacao = observacao;
            IdTipoExame = idTipoExame;
            TipoDeExame = tipoDeExame;
        }
    }
}
