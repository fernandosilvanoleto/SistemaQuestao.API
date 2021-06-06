using SistemaQuestao.Application.InputModels.Area;
using SistemaQuestao.Application.ViewModels.Area;
using System.Collections.Generic;

namespace SistemaQuestao.Application.Services.Interfaces
{
    public interface IAreaInterface
    {
        List<GetAreaAllViewModel> GetAllArea();
        GetAreaByIdViewModel GetByIdArea(int id); 
        int CreateArea(CreateAreaInputModel inputModel);
        void UpdateArea(UpdateAreaInputModel inputModel);
    }
}
