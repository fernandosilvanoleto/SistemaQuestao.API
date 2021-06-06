using System.ComponentModel.DataAnnotations;

namespace SistemaQuestao.Application.InputModels.Disciplina
{
    public class UpdateDisciplinaInputModel
    {
        public int Id { get; set; }
        [StringLength(500, MinimumLength = 4, ErrorMessage = "{0} do tamanho deve ser de {2} até {1}")]
        public string? Complemento { get; set; }
    }
}
