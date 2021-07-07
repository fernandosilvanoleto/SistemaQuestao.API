using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.InputModels.Assunto
{
    public class UpdateDisciplinaRelacionadaInputModel
    {
        public int Id { get; set; }
        public int IdAssuntoPai { get; set; }
    }
}
