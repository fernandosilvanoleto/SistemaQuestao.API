using SistemaQuestao.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaQuestao.Core.Interfaces
{
    public interface IAreaRepository
    {
        List<Area> GetAllAreaAsync(); 
        Task<Area> GetByIdAreaAsync();
        Task AddNewAreaAsync(Area area);
    }
}
