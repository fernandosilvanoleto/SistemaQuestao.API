using SistemaQuestao.Application.InputModels.AreaDisciplina;
using SistemaQuestao.Application.ViewModels.AreaDisciplina;
using System.Collections.Generic;
namespace SistemaQuestao.Application.Services.Interfaces
{
    public interface IAreaDisciplinaInterface
    {
        List<GetAreaDisciplinaAllViewModel> GetAllAreaDisciplina();
        GetAreaDisciplinaByIdViewModel GetByIdAreaDisciplina(int id);
        int CreateDisciplina(CreateAreaDisciplinaInputModel inputModel);
        int? DeleteAreaDisciplinaModel(int id);
        int? ActiveAreaDisciplinaModel(int id);
    }
}
