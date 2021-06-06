
using SistemaQuestao.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaQuestao.Application.ViewModels.Assunto
{
    public class GetAssuntoAllViewModel
    {
        public GetAssuntoAllViewModel(string descricao, string observacao, AssuntoEnum status, string disciplina)
        {
            Descricao = descricao;
            Observacao = observacao;
            Status = Enum.GetName(typeof(AssuntoEnum), status);
            Disciplina = disciplina;
        }

        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }
        [Display(Name = "Observação")]
        public string? Observacao { get; private set; }
        public string Status { get; private set; }
        public string Disciplina { get; private set; }
    }
}
