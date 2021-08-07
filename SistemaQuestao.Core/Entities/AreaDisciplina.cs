using SistemaQuestao.Core.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SistemaQuestao.Core.Entities
{
    public class AreaDisciplina : BaseEntity
    {
        public AreaDisciplina(int idArea, int idDisciplina)
        {
            IdArea = idArea;
            IdDisciplina = idDisciplina;

            StatusAreaDisciplina = AreaDisciplinaEnum.Ativo;
        }

        public int IdArea { get; private set; }
        public Area Area { get; private set; }
        public int IdDisciplina { get; private set; }
        public Disciplina Disciplina { get; private set; }

        [Display(Name = "Status")]
        public AreaDisciplinaEnum StatusAreaDisciplina { get; private set; }


        // MÉTODOS
        public void ExcluirAreaDisciplina()
        {
            if (StatusAreaDisciplina == AreaDisciplinaEnum.Ativo)
            {
                StatusAreaDisciplina = AreaDisciplinaEnum.Excluído;
            }
        }

        public void AtivarAreaDisciplina()
        {
            if (StatusAreaDisciplina == AreaDisciplinaEnum.Excluído)
            {
                StatusAreaDisciplina = AreaDisciplinaEnum.Ativo;
            }
        }
    }
}
