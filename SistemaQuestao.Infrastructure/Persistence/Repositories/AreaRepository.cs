using SistemaQuestao.Core.Entities;
using SistemaQuestao.Core.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SistemaQuestao.Infrastructure.Persistence.Repositories
{
    public class AreaRepository : IAreaRepository
    {
        private readonly SistemaQuestaoDbContext _dbContext;
        public AreaRepository(SistemaQuestaoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task AddNewAreaAsync(Area area)
        {
            throw new System.NotImplementedException();
        }

        public List<Area> GetAllAreaAsync()
        {
            return _dbContext.Areas.ToList();
        }

        public Task<Area> GetByIdAreaAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
