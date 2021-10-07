using Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.InputModel
{
    public class ExameInputModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do exame")]
        [MaxLength(100, ErrorMessage = "Deve conter no máximo 100 caracteres ")]
        public string NomeDoExame { get; set; }
        [MaxLength(1000, ErrorMessage ="Deve conter no máximo 1000 caracteres")]
        public string Observacao { get; set; }
        [Required(ErrorMessage = "Informe o tipo de exame")]
        public int IdTipoExame { get; set; }

      
    }
}
