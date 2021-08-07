using SistemaQuestao.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.AreaDisciplina
{
    public class GetDisciplinasPorAreaEspecificViewModel
    {
        public GetDisciplinasPorAreaEspecificViewModel(int id, int idArea, string area, string descricaoArea, int idDisciplina, string disciplina, string complementoDisciplina, AreaDisciplinaEnum statusAreaDisciplina)
        {
            Id = id;
            IdArea = idArea;
            Area = area;
            DescricaoArea = descricaoArea;
            IdDisciplina = idDisciplina;
            Disciplina = disciplina;
            ComplementoDisciplina = complementoDisciplina;
            StatusAreaDisciplina = Enum.GetName(typeof(AreaDisciplinaEnum), statusAreaDisciplina); ;
        }

        public int Id { get; private set; }
        public int IdArea { get; private set; }
        public string Area { get; private set; }
        public string DescricaoArea { get; private set; }
        public int IdDisciplina { get; private set; }
        public string Disciplina { get; private set; }
        public string ComplementoDisciplina { get; private set; }

        [Display(Name = "Status")]
        public string StatusAreaDisciplina { get; private set; }
    }
}
