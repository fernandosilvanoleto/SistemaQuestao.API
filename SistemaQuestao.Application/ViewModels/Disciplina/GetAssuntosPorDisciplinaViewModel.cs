using SistemaQuestao.Core.Enums;
using System;

namespace SistemaQuestao.Application.ViewModels.Disciplina
{
    public class GetAssuntosPorDisciplinaViewModel
    {
        public GetAssuntosPorDisciplinaViewModel(int idDisciplina, string disciplina, string assunto, string? observacao_Assunto, AssuntoEnum statusAssunto, string? assuntoPai)
        {
            IdDisciplina = idDisciplina;
            Disciplina = disciplina;
            Assunto = assunto;
            Observacao_Assunto = observacao_Assunto;
            StatusAssunto = Enum.GetName(typeof(AssuntoEnum), statusAssunto);
            AssuntoPai = assuntoPai;
        }

        public int IdDisciplina { get; private set; }
        public string Disciplina { get; private set; }
        public string Assunto { get; private set; }
        public string? Observacao_Assunto { get; private set; }
        public string StatusAssunto { get; private set; }        
        public string? AssuntoPai { get; set; }
    }
}
