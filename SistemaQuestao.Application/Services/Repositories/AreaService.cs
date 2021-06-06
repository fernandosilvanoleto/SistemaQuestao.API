using SistemaQuestao.Application.InputModels.Area;
using SistemaQuestao.Application.Services.Interfaces;
using SistemaQuestao.Application.ViewModels.Area;
using SistemaQuestao.Core.Entities;
using SistemaQuestao.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace SistemaQuestao.Application.Services.Repositories
{
    public class AreaService : IAreaInterface
    {
        private readonly SistemaQuestaoDbContext _dbContext;
        public AreaService(SistemaQuestaoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public int CreateArea(CreateAreaInputModel inputModel)
        {
            try
            {
                var area = new Area(inputModel.Nome, inputModel.Descricao);

                _dbContext.Areas.Add(area);
                _dbContext.SaveChanges();

                return area.Id;
            }
            catch (System.Exception)
            {
                return -1;
            }            
        }

        public List<GetAreaAllViewModel> GetAllArea()
        {
            try
            {
                var areas = _dbContext.Areas;

                var getAreaAllViewModel = areas
                    .Select(a => new GetAreaAllViewModel(a.Id, a.Nome, a.Descricao))
                    .ToList();

                return getAreaAllViewModel;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public GetAreaByIdViewModel GetByIdArea(int id)
        {
            try
            {
                var area = _dbContext.Areas.SingleOrDefault(a => a.Id == id);

                var getAreaByIdViewModel = new GetAreaByIdViewModel(
                        area.Id,
                        area.Nome,
                        area.Descricao,
                        area.DataCriacao
                    );

                return getAreaByIdViewModel;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public void UpdateArea(UpdateAreaInputModel inputModel)
        {
            try
            {
                var area = _dbContext.Areas.SingleOrDefault(a => a.Id == inputModel.Id);

                area.Update(inputModel.Descricao);
                _dbContext.SaveChanges();
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }

        }
    }
}
