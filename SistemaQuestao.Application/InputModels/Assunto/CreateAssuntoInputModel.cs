using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.InputModels.Assunto
{
    public class CreateAssuntoInputModel
    {
        public string Descricao { get; set; }
        public string? Observacao { get; set; }
        public int IdDisciplina { get; set; }
        public int? IdAssuntoPai { get; private set; }
    }
}
