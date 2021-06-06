using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Application.InputModels.Disciplina
{
    public class CreateDisciplinaInputModel
    {
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [StringLength(80, MinimumLength = 3, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string Nome { get; set; }

        [StringLength(500, MinimumLength = 4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string? Complemento { get; set; }
    }
}
