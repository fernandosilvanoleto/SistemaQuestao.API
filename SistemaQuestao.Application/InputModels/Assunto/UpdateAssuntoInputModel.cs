using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.InputModels.Assunto
{
    public class UpdateAssuntoInputModel
    {
        public int Id { get; set; }
        public string? Descricao { get; set; }
        public string? Observacao { get; set; }
    }
}
