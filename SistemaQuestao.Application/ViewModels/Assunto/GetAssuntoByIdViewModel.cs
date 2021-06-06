
using SistemaQuestao.Core.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaQuestao.Application.ViewModels.Assunto
{
    public class GetAssuntoByIdViewModel
    {
        public GetAssuntoByIdViewModel(string descricao, string observacao, AssuntoEnum status, string disciplina, string assuntoPai)
        {
            Descricao = descricao;
            Observacao = observacao;
            Status = Enum.GetName(typeof(AssuntoEnum), status);
            Disciplina = disciplina;
            AssuntoPai = assuntoPai;
        }
        [Display(Name = "Descrição")]
        public string Descricao { get; private set; }
        [Display(Name = "Observação")]
        public string? Observacao { get; private set; }
        public string Status { get; private set; }
        public string Disciplina { get; private set; }
        public string AssuntoPai { get; set; }

    }
}
