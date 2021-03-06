using SistemaQuestao.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Application.ViewModels.AreaDisciplina
{
    public class GetAreaDisciplinaAllViewModel
    {
        public GetAreaDisciplinaAllViewModel(int id, int idArea, string area, int idDisciplina, string disciplina, AreaDisciplinaEnum statusAreaDisciplina)
        {
            Id = id;
            IdArea = idArea;
            Area = area;
            IdDisciplina = idDisciplina;
            Disciplina = disciplina;
            StatusAreaDisciplina = Enum.GetName(typeof(AreaDisciplinaEnum), statusAreaDisciplina);
        }
        public int Id { get; private set; }
        public int IdArea { get; private set; }
        public string Area { get; private set; }
        public int IdDisciplina { get; private set; }
        public string Disciplina { get; private set; }

        [Display(Name = "Status")]
        public string StatusAreaDisciplina { get; private set; }
    }
}
