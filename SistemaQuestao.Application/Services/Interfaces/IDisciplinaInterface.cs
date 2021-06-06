using SistemaQuestao.Application.InputModels.Disciplina;
using SistemaQuestao.Application.ViewModels.Disciplina;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaQuestao.Application.Services.Interfaces
{
    public interface IDisciplinaInterface
    {
        List<GetDisciplinaAllViewModel> GetAllDisciplina();
        GetDisciplinaByIdViewModel GetByIdDisciplina(int id);
        int CreateDisciplina(CreateDisciplinaInputModel inputModel);
        void UpdateDisciplina(UpdateDisciplinaInputModel inputModel);
    }
}
