using Microsoft.EntityFrameworkCore;
using SistemaQuestao.Application.InputModels.AreaDisciplina;
using SistemaQuestao.Application.Services.Interfaces;
using SistemaQuestao.Application.ViewModels.AreaDisciplina;
using SistemaQuestao.Core.Entities;
using SistemaQuestao.Infrastructure.Persistence;
using System.Collections.Generic;
using System.Linq;

namespace SistemaQuestao.Application.Services.Repositories
{
    public class AreaDisciplinaService : IAreaDisciplinaInterface
    {
        private readonly SistemaQuestaoDbContext _dbContext;
        public AreaDisciplinaService(SistemaQuestaoDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int? ActiveAreaDisciplinaModel(int id)
        {
            try
            {
                var area_disciplina = _dbContext.AreaDisciplinas.SingleOrDefault(ad => ad.Id == id);

                if (area_disciplina == null)
                    return null;

                area_disciplina.AtivarAreaDisciplina();
                _dbContext.SaveChanges();

                return area_disciplina.Id;
            }
            catch (System.Exception)
            {
                return -1;
            }          
        }

        public int CreateDisciplina(CreateAreaDisciplinaInputModel inputModel)
        {
            try
            {
                var area_disciplina = new AreaDisciplina(inputModel.IdArea, inputModel.IdDisciplina);

                _dbContext.AreaDisciplinas.Add(area_disciplina);
                _dbContext.SaveChanges();

                return area_disciplina.Id;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public int? DeleteAreaDisciplinaModel(int id)
        {
            try
            {
                var area_disciplina = _dbContext.AreaDisciplinas.SingleOrDefault(ad => ad.Id == id);

                if (area_disciplina == null)
                    return null;

                area_disciplina.ExcluirAreaDisciplina();
                _dbContext.SaveChanges();

                return area_disciplina.Id;
            }
            catch (System.Exception)
            {
                return -1;
            }
        }

        public List<GetAreaDisciplinaAllViewModel> GetAllAreaDisciplina()
        {
            try
            {
                var area_disciplinas = _dbContext.AreaDisciplinas;

                var getAreaDisciplinaAllViewModel = area_disciplinas
                    .Include(a => a.Area)
                    .Include(d => d.Disciplina)
                    .Select(ad => new GetAreaDisciplinaAllViewModel(ad.Id, ad.IdArea, ad.Area.Nome, ad.IdDisciplina, ad.Disciplina.Nome, ad.StatusAreaDisciplina))
                    .ToList();

                return getAreaDisciplinaAllViewModel;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }

        public GetAreaDisciplinaByIdViewModel GetByIdAreaDisciplina(int id)
        {
            try
            {
                var area_disciplina = _dbContext.AreaDisciplinas
                    .Include(a => a.Area)
                    .Include(d => d.Disciplina)
                    .SingleOrDefault(ad => ad.Id == id);

                if (area_disciplina == null)
                    return null;

                var getAreaDisciplinaByIdViewModel = new GetAreaDisciplinaByIdViewModel(
                        area_disciplina.Id,
                        area_disciplina.IdArea,
                        area_disciplina.Area.Nome,
                        area_disciplina.IdDisciplina,
                        area_disciplina.Disciplina.Nome,
                        area_disciplina.StatusAreaDisciplina
                    );

                return getAreaDisciplinaByIdViewModel;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }            
        }

        public List<GetDisciplinasPorAreaEspecificViewModel> GetDisciplinasPorAreaEspecific(int idArea)
        {
            try
            {
                // FALTA TESTAR AGORA
                var area_disciplinas = _dbContext.AreaDisciplinas;

                if (area_disciplinas == null)
                    return null;

                var getDisciplinasPorAreaEspecifics = area_disciplinas
                    .Include(a => a.Area)
                    .Include(d => d.Disciplina)
                    .Where(ad => ad.IdArea == idArea)
                    .Select(area_disciplina => new GetDisciplinasPorAreaEspecificViewModel(
                       area_disciplina.Id,
                       area_disciplina.IdArea,
                       area_disciplina.Area.Nome,
                       area_disciplina.Area.Descricao,
                       area_disciplina.IdDisciplina,
                       area_disciplina.Disciplina.Nome,
                       area_disciplina.Disciplina.Complemento,
                       area_disciplina.StatusAreaDisciplina
                     ))
                    .ToList();

                return getDisciplinasPorAreaEspecifics;
            }
            catch (System.Exception)
            {
                throw new System.NotImplementedException();
            }
        }
    }
}
