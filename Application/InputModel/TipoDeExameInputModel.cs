using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class TipoDeExameInputModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Exame")]
        [MaxLength(100, ErrorMessage = "O Exame não pode ter mais que 100 caracteres")]
        public string NomeDoTipo { get; set; }
        [Required(ErrorMessage = "Informe a descrição")]
        [MaxLength(256, ErrorMessage = "A descrição do exame não pode ter mais que 250 caracteres")]
        public string Descricao { get; set; }
        public List<Exame> Exames { get; set; }
        
    }
}
